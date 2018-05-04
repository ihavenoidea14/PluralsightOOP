using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class UnitTest1
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();

            customer.FirstName = "Jarid";
            customer.LastName = "Wade";


            string expected = "Wade, Jarid";

            // Act
            string actual = customer.Fullname;


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidationTest()
        {
            Customer customer = new Customer();

            customer.LastName = "Wade";
            customer.EmailAddress = "";

            bool valid = customer.Validate();

            Assert.Equal(false, valid);
        }
    }
}
