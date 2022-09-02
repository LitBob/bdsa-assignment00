using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Returns_Yay_On_4()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"4"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Returns_Nay_On_5()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"5"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Returns_Nay_On_100()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"100"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Returns_Yay_On_400()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"400"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("yay", output);
        }
    }
}
