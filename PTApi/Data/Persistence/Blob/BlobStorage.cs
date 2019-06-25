using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace PTApi.Persistence.Blob
{
    public class BlobStorage : IBlobStorage
    {
        #region " Public "

        CloudBlobClient blobClient;
        string baseUri = "https://pmofilesdb.blob.core.windows.net/";


        public BlobStorage(BlobSetting settings)
        {
            this.settings = settings;
            var credentials = new StorageCredentials("pmofilesdb", "tb9gl6ComX8UHTFrrfx++v3C9YQO9pcMy/ZxHOEffR9wZzIhZWbJppvhqBLMiVZ1Ki0Y8x5EAKEk1eEsCxpTyQ==");
            blobClient = new CloudBlobClient(new Uri(baseUri), credentials);
        }

        public async Task UploadAsync(string blobName, string filePath)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Upload
            using (var fileStream = System.IO.File.Open(filePath, FileMode.Open))
            {
                fileStream.Position = 0;
                await blockBlob.UploadFromStreamAsync(fileStream);
            }
        }

        public async Task<string> SaveDocument(Stream stream)
        {
            var documentId = Guid.NewGuid().ToString();
            var container = blobClient.GetContainerReference("images");
            var blob = container.GetBlockBlobReference(documentId);
            await blob.UploadFromStreamAsync(stream);
            return documentId;
        }

        public async Task UploadAsync(string blobName, Stream stream)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Upload
            stream.Position = 0;
            await blockBlob.UploadFromStreamAsync(stream);
        }

        public string UriFor(string documentId)
        {
            // var sasPolicy = new SharedAccessBlobPolicy
            // {
            //     Permissions = SharedAccessBlobPermissions.Read,
            //     SharedAccessStartTime = DateTime.UtcNow.AddMinutes(-15),
            //     SharedAccessExpiryTime = DateTime.UtcNow.AddDays(1)
            // };

            // var container = blobClient.GetContainerReference("images");
            // var blob = container.GetBlockBlobReference(documentId);
            // var sas = blob.GetSharedAccessSignature(sasPolicy);
            string sas = "?sv=2018-03-28&si=images-167DCA4429C&sr=c&sig=DFWuQN2HlL0sSyDArfjUETOARGm%2F1OJErTl3KwYbB3o%3D";
            return $"{baseUri}images/{documentId}{sas}";
        }

        // ?sv=2018-03-28&si=images-167DCA4429C&sr=c&sig=DFWuQN2HlL0sSyDArfjUETOARGm%2F1OJErTl3KwYbB3o%3D




        public async Task<MemoryStream> DownloadAsync(string blobName)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Download
            using (var stream = new MemoryStream())
            {
                await blockBlob.DownloadToStreamAsync(stream);
                return stream;
            }
        }

        public async Task<bool> DeleteDocument(string documentId)
        {
            var container = blobClient.GetContainerReference("images");
            var blob = container.GetBlockBlobReference(documentId);
            bool blobExisted = await blob.DeleteIfExistsAsync();
            return blobExisted;
        }
        public async Task<bool> DeleteComLogo(string documentId)
        {
            var container = blobClient.GetContainerReference("logos");
            var blob = container.GetBlockBlobReference(documentId);
            bool blobExisted = await blob.DeleteIfExistsAsync();
            return blobExisted;
        }

        public class AzureBlobModel
        {
            public string FileName { get; set; }
            public long? FileSize { get; set; }
            public Stream Stream { get; set; }
            public string ContentType { get; set; }
        }

        public async Task<AzureBlobModel> DownloadDocument(string documentId, string fileName)
        {
            var container = blobClient.GetContainerReference("images");
            var blob = container.GetBlockBlobReference(documentId);

            var doc = new AzureBlobModel()
            {
                FileName = fileName,
                Stream = new MemoryStream(),
            };

            doc.Stream = await blob.OpenReadAsync();
            doc.ContentType = blob.Properties.ContentType;
            doc.FileSize = blob.Properties.Length;

            return doc;
        }

        public async Task DownloadAsync(string blobName, string path)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Download
            await blockBlob.DownloadToFileAsync(path, FileMode.Create);
        }

        public async Task DeleteAsync(string blobName)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Delete
            await blockBlob.DeleteAsync();
        }

        public async Task<bool> ExistsAsync(string blobName)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Exists
            return await blockBlob.ExistsAsync();
        }

        public async Task<List<BlobItem>> ListAsync()
        {
            return await GetBlobListAsync();
        }

        public async Task<List<BlobItem>> ListAsync(string rootFolder)
        {
            if (rootFolder == "*") return await ListAsync(); //All Blobs
            if (rootFolder == "/") rootFolder = "";          //Root Blobs

            var list = await GetBlobListAsync();
            return list.Where(i => i.Folder == rootFolder).ToList();
        }

        public async Task<List<string>> ListFoldersAsync()
        {
            var list = await GetBlobListAsync();
            return list.Where(i => !string.IsNullOrEmpty(i.Folder))
                       .Select(i => i.Folder)
                       .Distinct()
                       .OrderBy(i => i)
                       .ToList();
        }

        public async Task<List<string>> ListFoldersAsync(string rootFolder)
        {
            if (rootFolder == "*" || rootFolder == "") return await ListFoldersAsync(); //All Folders

            var list = await GetBlobListAsync();
            return list.Where(i => i.Folder.StartsWith(rootFolder))
                       .Select(i => i.Folder)
                       .Distinct()
                       .OrderBy(i => i)
                       .ToList();
        }

        #endregion

        #region " Private "

        private readonly BlobSetting settings;

        public async Task<CloudBlobContainer> GetImageContainerAsync()
        {
            //Account
            CloudStorageAccount storageAccount = new CloudStorageAccount(
                new StorageCredentials(settings.StorageAccount, settings.StorageKey), false);

            //Client
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            //Container
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(settings.ContainerName);
            await blobContainer.CreateIfNotExistsAsync();
            // await blobContainer.SetPermissionsAsync(new BlobContainerPermissions() { PublicAccess = BlobContainerPublicAccessType.Blob });

            return blobContainer;
        }

        public async Task<CloudBlockBlob> GetBlockBlobAsync(string blobName)
        {
            //Container
            CloudBlobContainer blobContainer = await GetImageContainerAsync();

            //Blob
            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(blobName);

            return blockBlob;
        }

        public async Task<List<BlobItem>> GetBlobListAsync(bool useFlatListing = true)
        {
            //Container
            CloudBlobContainer blobContainer = await GetImageContainerAsync();

            //List
            var list = new List<BlobItem>();
            BlobContinuationToken token = null;
            do
            {
                BlobResultSegment resultSegment =
                    await blobContainer.ListBlobsSegmentedAsync("", useFlatListing, new BlobListingDetails(), null, token, null, null);
                token = resultSegment.ContinuationToken;

                foreach (IListBlobItem item in resultSegment.Results)
                {
                    list.Add(new BlobItem(item));
                }
            } while (token != null);

            return list.OrderBy(i => i.Folder).ThenBy(i => i.Name).ToList();
        }

        #endregion


    }
}