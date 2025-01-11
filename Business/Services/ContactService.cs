using System.Text.Json;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class ContactService(IFileService fileService) : IContactService
{
    private readonly IFileService _fileService = fileService;
    private List<Contact> _contacts = [];

    public bool Add(Contact contact)
    {
        try
        {
            _contacts.Add(contact);
            var json = JsonSerializer.Serialize(_contacts);
            _fileService.Save(json);

            return true;
        }

        catch { return false; }
    }

    public IEnumerable<Contact> GetAll()
    {
        try
        {
            var json = _fileService.Get();
            _contacts = JsonSerializer.Deserialize<List<Contact>>(json)!;
        }

        catch { _contacts = []; }

        return _contacts;
    }
}
