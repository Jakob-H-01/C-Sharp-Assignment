using Business.Helpers;

namespace Business.Models;

public class Contact
{
    public string? Id { get; set; } = IdGenerator.Generate();
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? StreetAddress { get; set; }
    public string? ZipCode { get; set; }
    public string? City { get; set; }
}
