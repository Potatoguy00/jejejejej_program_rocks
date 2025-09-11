using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Customer : Person
    {
        int inskrivningsår; 
        bool betaldKåravgift;

        public Customer(string n, string t, int år, bool betalat, string CarModel, int CarRegNr) : base(n, t, CarModel, CarRegNr)
        {
            inskrivningsår = år;
            betaldKåravgift = betalat;
        }
        public void PrintInfo()
        {

            Console.WriteLine("Namn: " + base.GetNamn());
            Console.WriteLine("TelNr: " + base.GetTelefon());
            Console.WriteLine("CarModel: " + base.GetCarModel());
            Console.WriteLine("CarRegNr: " + base.GetCarRegNr());
            Console.WriteLine("inskrivningsår: " + inskrivningsår);
            if (betaldKåravgift)
            {
                Console.WriteLine("Kåravgiften är betald!\n");
            }

            if (!betaldKåravgift)
            {
                Console.WriteLine("Kåravgiften är inte betald!\n");
            }
        }
    }    
}
