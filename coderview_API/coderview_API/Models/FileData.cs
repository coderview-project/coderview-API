using coderview_API.Attributes;
using Microsoft.VisualBasic.FileIO;

namespace coderview_API.Models
{
    public class FileData
    {

        [FileExtension(FileType.Image)]
        [FileWeight(1024)]
        public string FileName { get; set; }
        public string Base64FileContent { get; set; }

    }
}
