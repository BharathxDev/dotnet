using DevOpsProductApp.Pages;
using Xunit;

namespace DevOpsProductApp.Tests;

public class ProductTests
{
    [Fact]
    public void IndexModel_ShouldBeCreated()
    {
        var model = new IndexModel();

        Assert.NotNull(model);
    }

    [Fact]
    public void ErrorModel_ShouldBeCreated()
    {
        var model = new ErrorModel();

        Assert.NotNull(model);
    }
}
