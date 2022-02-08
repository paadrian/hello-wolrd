using Xunit;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SystemUnderTest = HelloWorld.Greatings;
using FluentAssertions;

namespace HelloWorld.Tests
{
    public class GreatingsTests
    {
        [Fact()]
        public void SayHello_ShouldWriteGreetingsIn4Language_Always()
        {
			// arrange
            var expectedResult = string.Join(Environment.NewLine, "Hello, World!", "Bonjour le monde!",
                "Buna ziua lume!", "Hallo Welt!", "");

            var inMemoryOutput = new StringBuilder();
			var inMemoryOutputProvider = (string text) => { inMemoryOutput.AppendLine(text); };

            var systemUnderTest = new SystemUnderTest(inMemoryOutputProvider);
			//act

			var sayHello = systemUnderTest.Invoking(sut => sut.SayHello()); 

			// assert
			sayHello.Should().NotThrow();
			var result = inMemoryOutput.ToString().Should().Be(expectedResult);
        }
    }
}