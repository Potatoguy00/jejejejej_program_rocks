using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Customer : Person //customer ärver från person och lägger till inskrivningsår och om kåravgiften är betald
    {
        //fält för inskrivningsår och om kåravgiften är betald
        int inskrivningsår; 
        bool betaldKåravgift;

        //konstruktor som tar in namn, telefonnummer, inskrivningsår, om kåravgiften är betald, bilmodell och bilregistreringsnummer
        public Customer(string n, string t, int år, bool betalat, string CarModel, int CarRegNr) : base(n, t, CarModel, CarRegNr)
        {
            inskrivningsår = år;
            betaldKåravgift = betalat;
        }
        //skriver ut all info om kunden
        public void PrintInfo()
        {

            Console.WriteLine("Namn: " + base.GetNamn());
            Console.WriteLine("TelNr: " + base.GetTelefon());
            Console.WriteLine("CarModel: " + base.GetCarModel());
            Console.WriteLine("CarRegNr: " + base.GetCarRegNr());
            Console.WriteLine("inskrivningsår: " + inskrivningsår);

            //skriver ut om kåravgiften är betald eller inte
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
