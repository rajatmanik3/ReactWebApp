namespace WebApp.Services
{
    public interface IBlobService
    {
        Task<string> GetBlob(string blobName, string containerName);
        Task<string> DeleteBlob(string blobName, string containerName);
        Task<string> UpdateBlob(string blobName, string containerName, IFormFile file);
    }
}
