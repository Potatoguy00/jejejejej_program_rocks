using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Person //bas-klass för personer
    {

        //skapar tomma strängar för namn, telefonnummer, bilmodellen och bilregistreringsnummer
        private string namn;
        private string telefon;

        private string CarModel;
        private int CarRegNr;

        //konstruktor som tar in namn, telefonnummer, bilmodell och bilregistreringsnummer
        public Person(string namn, string telefon, string CarModel, int CarRegNr)
        {
            this.namn = namn;
            this.telefon = telefon;
            this.CarModel = CarModel;
            this.CarRegNr = CarRegNr;
        }

        //returnerar personens namn
        public string GetNamn()
        {
            return namn;
        }
        //returnerar personens telefonnummer
        public string GetTelefon() => telefon;

        //returnerar personens bilmodell
        public string GetCarModel() => CarModel;

        //returnerar personens bilregistreringsnummer
        public int GetCarRegNr() => CarRegNr;
    }
}
