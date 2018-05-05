using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveExisting()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "jarid.wade@icloud.com",
                FirstName = "Jarid",
                LastName = "Wade"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.FirstName, actual.FirstName);
        }
    }
}
