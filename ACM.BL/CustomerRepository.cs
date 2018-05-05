using System;
using System.Collections.Generic;
namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository() {}

        /// <summary>
        /// Retrieve the specified Customer.
        /// </summary>
        /// <returns>The retrieve.</returns>
        /// <param name="customerId">Customer identifier.</param>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "jarid.wade@icloud.com";
                customer.FirstName = "Jarid";
                customer.LastName = "Wade";
            }
            return customer;
        }

        /// <summary>
        /// Retrieve all Customers
        /// </summary>
        /// <returns>Customers</returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Save this instance.
        /// </summary>
        /// <returns>The save.</returns>
        public bool Save()
        {
            return true;
        }
    }
}
