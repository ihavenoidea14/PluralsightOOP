using System;

namespace ACM.BL
{
    public class Customer
    {
        public int InstanceCount { get; set; }
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

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
