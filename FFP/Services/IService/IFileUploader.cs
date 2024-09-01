namespace FFP.WebApp.Services.IService
{
    public interface IFileUploader
    {
        public Task<string> Upload(IFormFile file, string targetRelativePath);
    }
}
