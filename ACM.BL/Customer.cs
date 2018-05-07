using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {

        public Customer() : this(0) {}

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string Fullname
        {
            get
            {
                return LastName + ", " + FirstName;
            }
            
        }

        /// <summary>
        /// Validate this instance.
        /// </summary>
        /// <returns>The validate.</returns>
        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress);
        }
    }
}
