using System.Collections.Generic;

namespace PTApi.Persistence.Blob.Models
{
    public class FileDetails
    {
        public string Name { get; set; }
        public string BlobName { get; set; }
    }

    public class FilesViewModel
    {
        public List<FileDetails> Files { get; set; }= new List<FileDetails>();
    }
}