using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;
using static PTApi.Persistence.Blob.BlobStorage;

namespace PTApi.Persistence.Blob
{
    public interface IBlobStorage
    {
        Task UploadAsync(string blobName, string filePath);
        Task UploadAsync(string blobName, Stream stream);
        Task<string> SaveDocument(Stream stream);
        Task<AzureBlobModel> DownloadDocument(string documentId, string fileName);
        Task<bool> DeleteDocument(string documentId);
        Task<bool> DeleteComLogo(string documentId);
        string UriFor(string documentId);
        Task<MemoryStream> DownloadAsync(string blobName);
        Task DownloadAsync(string blobName, string path);
        Task DeleteAsync(string blobName);
        Task<bool> ExistsAsync(string blobName);
        Task<List<BlobItem>> ListAsync();
        Task<List<BlobItem>> ListAsync(string rootFolder);
        Task<List<string>> ListFoldersAsync();
        Task<List<string>> ListFoldersAsync(string rootFolder);

        Task<CloudBlobContainer> GetImageContainerAsync();
        Task<CloudBlockBlob> GetBlockBlobAsync(string blobName);
    }
}