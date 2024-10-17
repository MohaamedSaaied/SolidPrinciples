using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.Violateprinciple
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author {  get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Book(Guid id, string name, string description, string author, int year, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            Year = year;
            Price = price;
        }

    }
}
