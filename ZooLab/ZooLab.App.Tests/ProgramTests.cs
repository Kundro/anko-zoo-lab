using Xunit;

namespace ZooLab.App.Tests
{
    public class ProgramTests
    {
            [Fact]
            public void ShouldBeAbleToRunZooApp()
            {
            ZooLab.App.RunApp.RunZoo();
            }
    }
}
