using Entities;
using Microsoft.AspNetCore.Mvc.Filters;

namespace coderview_API.IService
{
    public interface IFileService
    {
        int AddFile(FileItem fileItem);
        void DeleteFile(int id);
        FileItem GetFileById(int id);
        List<FileItem> GetAllFilesList();

    }
}
