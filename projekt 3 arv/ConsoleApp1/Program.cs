using System;
using System.Collections.Generic;

namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
            string CustomerName = String.Empty;
            string CustomerTelephone = String.Empty;

            Customer Customer1 = new Customer("CHAM", "752879", 2021, false, "ford", 999);
            CustomerName = Customer1.GetNamn();
            Customer1.PrintInfo();

            Customer Customer2 = new Customer("PAGNE", "070094762", 2021, true, "volvo", 777);
            CustomerTelephone = Customer2.GetTelefon();
            Customer2.PrintInfo();  
        }


    }
}