using Business.Interfaces;

namespace Business.Services;

public class FileService : IFileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;

    public FileService(string fileName)
    {
        _directoryPath = "Data";
        _filePath = Path.Combine(_directoryPath, fileName);
    }
    public bool Save(string content)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            File.WriteAllText(_filePath, content);
            return true;
        }

        catch { return false; }
    }

    public string Get()
    {
        if (File.Exists(_filePath))
        {
            return File.ReadAllText(_filePath);
        }

        return null!;
    }
}
