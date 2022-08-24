using System.Collections.Generic;
using Xunit;

namespace ZooLab.App.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void ShouldBeAbleToRunZooApp()
        {
            IConsole NewConsole = new MockConsole();
            RunApp.RunZoo();
            List<string> consoleOutput = new List<string>()
                {
                    "Zoo created in zoo1",
                    "Zoo created in zoo2",
                    "Added new zoo.",
                    "Added new zoo.",
                    "\"Enclosure1\" enclosure was added to Zoo at zoo1",
                    "\"Enclosure2\" enclosure was added to Zoo at zoo2",
                    "\"Enclosure3\" enclosure was added to Zoo at zoo2",
                    "\"Enclosure4\" enclosure was added to Zoo at zoo2",
                    "Employee name1 surname1 hired to zoo (zoo1)",
                    "Employee name2 surname2 hired to zoo (zoo1)",
                    "Employee name3 surname3 hired to zoo (zoo2)",
                    "Employee name4 surname4 hired to zoo (zoo2)"
                };
            Assert.Equal(consoleOutput, Logger.Log);
        }
    }
}
