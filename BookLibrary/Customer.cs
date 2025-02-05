using System;

namespace BookstoreLibrary
{
    /// <summary>
    /// Represents a customer in the bookstore system.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the customer's email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
