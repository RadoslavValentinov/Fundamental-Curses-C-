using System;

namespace AgencyProfit
{
    class Program
    {
        static void Main()
        {
            string aviocumpani = Console.ReadLine();
            double ticketsgrownup = double.Parse(Console.ReadLine());
            double ticketschildren = double.Parse(Console.ReadLine());
            double Netprice = double.Parse(Console.ReadLine());
            double servicecharge = double.Parse(Console.ReadLine());
            double childrentiket =Netprice- Netprice * 0.7 + (servicecharge);
            double ticketgrow = Netprice + servicecharge;
            double total = childrentiket * ticketschildren + ticketgrow * ticketsgrownup;
            Console.WriteLine($"The profit of your agency from {aviocumpani} tickets is {total * 0.2:f2} lv.");
        }
    }
}
