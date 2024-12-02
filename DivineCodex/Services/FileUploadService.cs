using Microsoft.AspNetCore.Components.Forms;

public class FileUploadService
{
    private readonly IWebHostEnvironment _environment;

    public FileUploadService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public async Task<string> UploadProfileImageAsync(IBrowserFile file, string userId)
    {
        var folderPath = Path.Combine(_environment.WebRootPath, "uploads", "profileImages");
        Directory.CreateDirectory(folderPath);

        var fileName = $"{userId}_{Path.GetFileName(file.Name)}";
        var filePath = Path.Combine(folderPath, fileName);

        using var stream = new FileStream(filePath, FileMode.Create);
        await file.OpenReadStream(maxAllowedSize: 1024 * 1024 * 2).CopyToAsync(stream); // Limit to 2MB

        return $"/uploads/profileImages/{fileName}";  // Return relative path
    }
}