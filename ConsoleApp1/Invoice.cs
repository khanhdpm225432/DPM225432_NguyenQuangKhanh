using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Method
{
  

    public class Invoice
    {
        private string name;
        private double outstanding;

        public Invoice(string name, double outstanding)
        {
            this.name = name;
            this.outstanding = outstanding;
        }

        public void PrintOwing()
        {
            PrintBanner();
            PrintDetails();
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private void PrintDetails()
        {
            Console.WriteLine("Name: " + (name ?? "Unknown"));
            Console.WriteLine("Amount: " + outstanding.ToString("F2"));
        }

        public double GetOutstanding()
        {
            return outstanding;
        }
    }


}
