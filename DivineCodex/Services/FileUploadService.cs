using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;

// File: FileUploadService.cs


public class FileUploadService
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public FileUploadService(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    public async Task<string> UploadProfileImageAsync(IBrowserFile file, string userId)
    {
        if (file == null)
        {
            Console.WriteLine("No file received.");
            return null;
        }

        var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
        if (!Directory.Exists(uploadsFolder))
        {
            Directory.CreateDirectory(uploadsFolder);
        }

        var fileName = $"{userId}_{file.Name}";
        var filePath = Path.Combine(uploadsFolder, fileName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await file.OpenReadStream(maxAllowedSize: 10 * 1024 * 1024).CopyToAsync(fileStream);
        }

        Console.WriteLine($"File saved: {filePath}");
        return $"/uploads/{fileName}";
    }

}
