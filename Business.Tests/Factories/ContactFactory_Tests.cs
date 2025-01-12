using Business.Factories;
using Business.Models;

namespace Business.Tests.Factories;

public class ContactFactory_Tests
{
    [Fact]
    public void Create_ShouldReturnAContact()
    {
        var result = ContactFactory.Create();
        Assert.NotNull(result);
        Assert.IsType<Contact>(result);
    }
}
