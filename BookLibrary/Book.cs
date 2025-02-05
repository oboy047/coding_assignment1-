using System;

namespace BookstoreLibrary
{
    /// <summary>
    /// Represents a book in the bookstore.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the book title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author's name.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the ISBN number.
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the price of the book.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the Book class.
        /// </summary>
        public Book(string title, string authorName, string isbn, decimal price)
        {
            Title = title;
            AuthorName = authorName;
            ISBN = isbn;
            Price = price;
        }
    }
}
