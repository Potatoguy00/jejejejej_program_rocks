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
        int inskrivningsår; //fält för inskrivningår
        bool betaldKåravgift; //fält för om kåravgiften är betald eller inte

        //konstruktor som tar in namn, telefonnummer, inskrivningsår, om kåravgiften är betald, bilmodell och bilregistreringsnummer
        public Customer(string n, string t, int år, bool betalat, string CarModel, int CarRegNr) : base(n, t, CarModel, CarRegNr)
        {
            inskrivningsår = år; //sätter inskrivningår till det som skrivs in
            betaldKåravgift = betalat; //sätter betaldkåravgift till det som skriv in
        }
        //skriver ut all info om kunden
        public void PrintInfo() //metod som skriver ut all info om kunden
        {

            Console.WriteLine("Namn: " + GetNamn()); // skriver ut kundens namn som den får från bas-klassen person
            Console.WriteLine("TelNr: " + GetTelefon()); //skriver ut kundens telefonnummer som den får från bas-klassen person
            Console.WriteLine("CarModel: " + GetCarModel()); //skriver ut kundens bilmodell som den får från bas-klassen person
            Console.WriteLine("CarRegNr: " + GetCarRegNr()); //skriver ut kundens bilregistreringsnummer som den får från bas-klassen person
            Console.WriteLine("inskrivningsår: " + inskrivningsår); //skriver ut kundens inskrivningsår

            //skriver ut om kåravgiften är betald eller inte
            if (betaldKåravgift) //körs om den är betald
            {
                Console.WriteLine("Kåravgiften är betald!\n"); //skriver ut "Kåravgiften är betald!"
            }

            if (!betaldKåravgift) //körs om den inte är betald
            {
                Console.WriteLine("Kåravgiften är inte betald!\n"); //skriver ut "Kåravgiften är inte betald!"
            }
        }
    }    
}
