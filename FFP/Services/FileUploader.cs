using FFP.WebApp.Services.IService;

namespace FFP.WebApp.Services
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public Task<string> Upload(IFormFile file, string targetRelativePath)
        {
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, targetRelativePath);

            if (!Directory.Exists(finalPath))
            {
                Directory.CreateDirectory(finalPath);
            }

            using (var fileStream = new FileStream(Path.Combine(finalPath, fileName), FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return Task.FromResult("/" + targetRelativePath + "/" + fileName);
        }
    }
}
