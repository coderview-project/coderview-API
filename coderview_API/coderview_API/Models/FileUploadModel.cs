using coderview_API.Attributes;
using Entities.Enums;


namespace coderview_API.Models
{
    public class FileUploadModel
    {
        [FileExtension(FileType.Image)]

        [FileWeight(1024)]
        public IFormFile File { get; set; }
        public FileExtensionEnum FileExtension { get; set; }

    }
}
