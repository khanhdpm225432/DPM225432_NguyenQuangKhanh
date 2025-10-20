using Solution.InvoiceProject;

class Program
{
    static void Main()
    {
        Invoice invoice = new Invoice("Nguyen Van A", 3450.75);
        invoice.PrintOwing();
    }
}

