using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private double price;
        private int count;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Price cannot be negative."); 
                price = value;
            }
        }

        public int Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Count cannot be negative.");
                count = value;
            }
        }

        public Product(int id, string name, double price, int count)
        {
            if (id <= 0 || string.IsNullOrEmpty(name))
                Console.WriteLine("Invalid id or name.");

            Id = id;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}

