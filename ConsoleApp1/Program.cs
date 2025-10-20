using Extract_Method;
using System.Xml.Linq;

namespace Extract_Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Nguyen Van A", 1234.56);
            invoice.PrintOwing();
        }
    }

}
