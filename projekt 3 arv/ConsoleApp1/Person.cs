using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Person
    {
        private string namn;
        private string telefon;

        private string CarModel;
        private int CarRegNr;


        public Person(string namn, string telefon, string CarModel, int CarRegNr)
        {
            this.namn = namn;
            this.telefon = telefon;
            this.CarModel = CarModel;
            this.CarRegNr = CarRegNr;
        }

        public string GetNamn()
        {
            return namn;
        }
        public string GetTelefon() => telefon;

        public string GetCarModel() => CarModel;
        public int GetCarRegNr() => CarRegNr;
    }
}
