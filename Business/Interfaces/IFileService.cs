namespace Business.Interfaces;

public interface IFileService
{
    bool Save(string content);
    string Get();
}
