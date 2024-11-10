using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Library
    {
        private Book[] books;
        private int bookCount;

        public Library(int capacity = 8)
        {
            books = new Book[capacity];
            bookCount = 0;
        }

        public void AddBook(Book book)
        {
            if (bookCount < books.Length)
                books[bookCount++] = book;
            
            else
                Console.WriteLine("Library is full, cannot add more books.");
            
        }

        public Book GetBookById(int id)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Id == id)
                    return books[i];  
            }
            return null;  
        }

        public Book GetBookByName(string name)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Name == name) 
                    return books[i]; 
            }
            return null;  
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] result = new Book[bookCount];
            int resultCount = 0;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Genre == genre)
                    result[resultCount++] = books[i]; 
            }

            Array.Resize(ref result, resultCount);  
            return result;
        }

        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] result = new Book[bookCount];
            int resultCount = 0;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Price >= minPrice && books[i].Price <= maxPrice)
                    result[resultCount++] = books[i];  
            }

            Array.Resize(ref result, resultCount);  
            return result;
        }
    }
}
