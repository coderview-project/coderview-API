using coderview_API.Attributes;
using coderview_API.IService;
using coderview_API.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IO.Compression;
using System.Net.Mime;


namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FileController
    {
        private readonly IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador, Coder")]
        [HttpPost(Name = "PostFile")]
        public int PostFile([FromForm] FileUploadModel fileUploadModel)
        {
            try
            {
                var fileItem = new FileItem();
                fileItem.Id = 0;
                fileItem.Name = fileUploadModel.File.FileName;
                fileItem.InsertDate = DateTime.Now;
                fileItem.UpdateDate = DateTime.Now;
                fileItem.FileExtension = fileUploadModel.FileExtension;

                using (var stream = new MemoryStream())
                {
                    fileUploadModel.File.CopyTo(stream);
                    fileItem.Content = stream.ToArray();
                }

                return _fileService.PostFile(fileItem);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpDelete(Name = "DeleteFile")]

        public void DeleteFile([FromQuery] int id)
        {
            _fileService.DeleteFile(id);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador, Coder")]
        [HttpGet(Name = "GetFileById")]
        public FileStreamResult GetFileById(int id)
        {
            try
            {
                var fileItem = _fileService.GetFileById(id);
                var stream = new MemoryStream(fileItem.Content);
                var mimeType = MediaTypeNames.Image.Jpeg.ToString();
                return new FileStreamResult(stream, new MediaTypeHeaderValue(mimeType))
                {
                    FileDownloadName = fileItem.Name
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpGet(Name = "GetAllFilesList")]
        public List<FileItem> GetAllFilesList()
        {
            return _fileService.GetAllFilesList();
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpGet(Name = "GetAllFilesZip")]
        public FileStreamResult GetAllFilesZip()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //required: using System.IO.Compression;
                using (var zip = new ZipArchive(ms, ZipArchiveMode.Create, true))
                {
                    //QUery the Products table and get all image content
                    _fileService.GetAllFilesList().ForEach(file =>
                    {
                        var entry = zip.CreateEntry(file.Name);
                        using (var fileStream = new MemoryStream(file.Content))
                        using (var entryStream = entry.Open())
                        {
                            fileStream.CopyTo(entryStream);
                        }
                    });
                }
                return new FileStreamResult(ms, MediaTypeNames.Application.Zip)
                {
                    FileDownloadName = "files.zip"
                };
            }
        }
    }
}
