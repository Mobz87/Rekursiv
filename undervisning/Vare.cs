using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace undervisning
{
    class Vare
    {


        private string _navn;
        private double _pris;
        private string _efternavn;

        public String Fornavn { get; set; }


        //private string _fuldtNavn;

        public string FuldtNavn
        {
            get {



                return Fornavn + " " + _efternavn; }
            
        }




        public string Efternavn
        {
            get { return _efternavn; }

            set
            {

                if (value.Length < 3)
                {
                    _efternavn = "";
                }
                else
                {
                    _efternavn = value;
                }
            }
        }



        public string Navn
        {
            get
            {
                Console.WriteLine($"LOG: {_navn} er blevet sendt");
                return _navn;
            }
            set
            {
                Console.WriteLine($"LOG: Navn før: {_navn}. Navn nu: {value}");
                _navn = value;
            }
        }



        public double Pris
        {
            get
            {
                Console.WriteLine($"LOG: {_pris} er blevet sendt");
                return _pris;
            }
            set
            {

                Console.WriteLine($"LOG: Pris før: {_pris}. Pris nu: {value}");
                _pris = value;
            }
        }


        public void PrisMedMoms()
        {


        }




        public Vare() : this("", 10)
        {


        }

        public Vare(String navn, double pris)
        {

            this._navn = navn;
            this._pris = pris;




        }





    }
}
