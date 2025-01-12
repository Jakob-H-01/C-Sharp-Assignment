using Business.Helpers;

namespace Business.Tests.Helpers;

public class IdGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnAStringContainingAGuid()
    {
        var result = IdGenerator.Generate();
        Assert.NotNull(result);
        Assert.True(Guid.TryParse(result, out _));
    }
}
