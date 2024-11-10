using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Book:Product
    {
        public string Genre { get; set; }

        public Book(int id, string name, double price, int count, string genre)
            : base(id, name, price, count)
        {
            if (string.IsNullOrEmpty(genre))
                Console.WriteLine("Genre cannot be null or empty.");    
            Genre = genre;
        }
    }
}
