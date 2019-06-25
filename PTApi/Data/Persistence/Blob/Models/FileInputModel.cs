using Microsoft.AspNetCore.Http;

namespace PTApi.Persistence.Blob.Models
{
    public class FileInputModel
    {
        public string Folder { get; set; }
        public IFormFile File { get; set; }
    }
}