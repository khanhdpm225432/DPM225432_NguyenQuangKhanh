using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    using System;

    namespace InvoiceProject
    {
        public class Invoice
        {
            // Fields
            private string name;
            private double outstanding;

            // Constructor
            public Invoice(string name, double outstanding)
            {
                this.name = name;
                this.outstanding = outstanding;
            }

            // Public method in charge of printing invoice details
            public void PrintOwing()
            {
                PrintBanner();
                PrintDetails();
            }

            // Private method to print a banner/header
            private void PrintBanner()
            {
                Console.WriteLine("******************************");
                Console.WriteLine("****** Customer Owes *********");
                Console.WriteLine("******************************");
            }

            // Private method to print the details (name and amount)
            private void PrintDetails()
            {
                Console.WriteLine("Name: " + (string.IsNullOrEmpty(name) ? "Unknown" : name));
                Console.WriteLine("Amount: " + outstanding.ToString("C2")); // C2: format currency with 2 decimals
            }

            // Optionally, a getter method (not necessary if you use properties)
            public double GetOutstanding()
            {
                return outstanding;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Tạo một hóa đơn và in ra thông tin
                Invoice invoice = new Invoice("Nguyen Van A", 1250.50);
                invoice.PrintOwing();

                // Bạn có thể thử tạo thêm hóa đơn khác để

            }
