using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Person //bas-klass för personer
    {

        // Fält för namn, telefonnummer, bilmodell och bilregistreringsnummer
        private string namn;
        private string telefon;

        private string CarModel;
        private int CarRegNr;


        public Person(string namn, string telefon, string CarModel, int CarRegNr)  //konstruktor som tar in namn, telefonnummer, bilmodell och bilregistreringsnummer
        {
            this.namn = namn; //sätter fältet namn till det som skrivs in
            this.telefon = telefon; //sätter fältet telefon till det som skriv in
            this.CarModel = CarModel; //sätter fältet CarModel till det som skrivs in
            this.CarRegNr = CarRegNr; //sätter fältet CarRegNr till det som skrivs in
        }


        public string GetNamn() //returnerar personens namn
        {
            return namn;
        }
        public string GetTelefon() => telefon; //returnerar personens telefonnummer

        public string GetCarModel() => CarModel; //returnerar personens bilmodell

        public int GetCarRegNr() => CarRegNr; //returnerar personens bilregistreringsnummer
    }
}
