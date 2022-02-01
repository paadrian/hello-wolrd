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
            var stringBuilder = new StringBuilder();
            SystemUnderTest _systemUnderTest = new((text) => stringBuilder.AppendLine(text));

            _systemUnderTest.Invoking(sut => sut.SayHello()).Should().NotThrow();

            var result = stringBuilder.ToString();
            result.Should().Be(string.Join(Environment.NewLine, @"Hello, World!", "Bonjour le monde!", 
                "Buna ziua lume!","Hallo Welt!", ""));
        }
    }
}