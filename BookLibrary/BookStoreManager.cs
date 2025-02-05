using System;
using System.Collections.Generic;
using System.Linq;

namespace BookstoreLibrary
{
    /// <summary>
    /// Manages bookstore operations such as adding books, searching books, and handling purchases.
    /// </summary>
    public class BookStoreManager
    {
        private readonly List<Book> _inventory = new List<Book>();

        /// <summary>
        /// Adds a book to the bookstore inventory.
        /// </summary>
        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            }

            _inventory.Add(book);
        }

        /// <summary>
        /// Searches for books by title or ISBN.
        /// </summary>
        public Book FindBook(string searchTerm)
        {
            return _inventory.FirstOrDefault(b => b.Title.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                  b.ISBN.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Processes the purchase of a book.
        /// </summary>
        public bool PurchaseBook(string isbn, Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }

            var book = FindBook(isbn);
            if (book == null)
            {
                return false; // Book not found
            }

            _inventory.Remove(book); // Remove from inventory
            return true;
        }
    }
}
