using Business.Models;

namespace Business.Interfaces;

public interface IContactService
{
    bool Add(Contact contact);
    IEnumerable<Contact> GetAll();
}
