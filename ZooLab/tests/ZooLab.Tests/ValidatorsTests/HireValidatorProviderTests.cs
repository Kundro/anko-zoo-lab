using FluentAssertions;
using System;
using Xunit;
using ZooLab.Entities.Animals.Mammal;
using ZooLab.Entities.Employees;
using ZooLab.Validators;

namespace ZooLab.Tests.ValidatorsTests
{
    public class HireValidatorProviderTests
    {
        [Fact]
        public void ShouldBeAbleToCreateProvider()
        {
            HireValidatorProvider provider = new HireValidatorProvider();
            provider.Should().NotBeNull();
        }

        [Fact]
        public void ShouldBeAbleToTakeZookeeperHireValidator()
        {
            HireValidatorProvider provider = new HireValidatorProvider();
            Zookeeper zookeeper = new Zookeeper("name", "surname");
            IHireValidator validator = provider.GetHireValidator(zookeeper);
            validator.Should().NotBeNull();
            validator.GetType().Should().Be(typeof(ZookeeperHireValidator));
        }

        [Fact]
        public void ShouldBeAbleToTakeVeterinarianHireValidator()
        {
            HireValidatorProvider provider = new HireValidatorProvider();
            Veterinarian veterinarian = new Veterinarian("name", "surname");
            IHireValidator validator = provider.GetHireValidator(veterinarian);
            validator.Should().NotBeNull();
            validator.GetType().Should().Be(typeof(VeterinarianHireValidator));
        }

        private class TestEmployee : IEmployee
        {
            public TestEmployee(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public string FirstName { get; private set; }

            public string LastName { get; private set; }
        }

        [Fact]
        public void ShouldBeAbleToCreateFakeEmployeeClass()
        {
            HireValidatorProvider provider = new HireValidatorProvider();
            TestEmployee test = new TestEmployee("name", "surname");
            test.Should().NotBeNull();
            Assert.Throws<Exception>(() => provider.GetHireValidator(test));
                
        }
    }
}
