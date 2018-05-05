using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
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
            // Arrange
            Customer customer1 = new Customer();
            var customer2 = new Customer();

            customer1.LastName = "Wade";
            customer1.EmailAddress = "jarid.wade@icloud.com";

            customer2.LastName = "Wade";
            customer2.EmailAddress = "";

            // Act
            bool valid1 = customer1.Validate();
            bool valid2 = customer2.Validate();

            // Assert
            Assert.Equal(true, valid1);
            Assert.Equal(false, valid2);
        }
    }
}
