using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.Violateprinciple
{
    public class Invoice
    {

        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double DiscountRate { get; set; }
        public double TaxRate { get; set; }
        public double Total {  get; set; }
        public Invoice(Book book, int quantity, double discountRate, double taxRate, double total)
        {
            Book = book;
            Quantity = quantity;
            DiscountRate = discountRate;
            TaxRate = taxRate;
            Total = total;
        }
        public double CalculateTotal()
        {
            double price = (Book.Price - (Book.Price-(Book.Price * DiscountRate)) * Quantity);
            double priceWithTaxes = (price * TaxRate) + price;
            return priceWithTaxes;
        }

        public void PrintInvoice()
            =>Console.WriteLine($"Book Name : {Book.Name}, Book Price :{Book.Price} Quantity: {Quantity} Total : {Total}");
        public void SaveToFile(string filename)
        => Console.WriteLine("File Saved !");


}
}
