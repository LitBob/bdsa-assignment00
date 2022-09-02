using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Returns_Yay_On_2004()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"2004"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Returns_Nay_On_2005()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"2005"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Returns_Nay_On_2100()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"2100"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Returns_Yay_On_2400()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"2400"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Returns_Year_Out_Of_Scope_On_1580()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"1580"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("Year Out of Scope", output);
        }

        [Fact]
        public void Returns_Error_if_input_is_not_parsable_to_int()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var args = new string[] {"test"};
            Program.Main(args);

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal("Error", output);
        }
    }
}
