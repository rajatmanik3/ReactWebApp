using Azure.Storage.Blobs;

namespace WebApp.Services
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobClient;

        public BlobService(BlobServiceClient blobClient) 
        {
            _blobClient = blobClient;
        }
        public Task<string> DeleteBlob(string blobName, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetBlob(string blobName, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateBlob(string blobName, string containerName, IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
