using System;
using System.Collections.Generic;

namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapar strängar för att lagra namn och telefonnummer
            string CustomerName = String.Empty;
            string CustomerTelephone = String.Empty;

            //skapar en customer-instans med namn, telefonnummer, inskrivningsår, om kåravgiften är betald, bilmodell och bilregistreringsnummer
            Customer Customer1 = new Customer("CHAM", "0752879", 2021, false, "ford", 999); 
            CustomerName = Customer1.GetNamn(); //hämtar kundens namn
            Customer1.PrintInfo(); //Skriver ut info om kunden

            //skapar en till customer-instans med andra värden
            Customer Customer2 = new Customer("PAGNE", "070094762", 2021, true, "volvo", 777);
            CustomerTelephone = Customer2.GetTelefon(); //hämtar kundens telefonnummer
            Customer2.PrintInfo();  //skriver ut all info om kunden
        }


    }
}