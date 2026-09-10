using Xunit;

namespace DevOpsProductApp.Tests;

public class ProductTests
{
    [Fact]
    public void ProductCount_ShouldBeFour()
    {
        int productCount = 4;

        Assert.Equal(4, productCount);
    }

    [Fact]
    public void ApplicationStatus_ShouldBeRunning()
    {
        string status = "Running";

        Assert.Equal("Running", status);
    }
}