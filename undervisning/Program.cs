using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace undervisning
{
    class Program
    {
        static void Main(string[] args)
        {


            var Kasser = new Vare();

            //Kasser.Pris = 10;
            //Kasser.Pris = 15;

            //Kasser.Pris = Kasser.Pris;

            //Kasser.Navn = "Kasper";

            //Kasser.Navn = Kasser.Navn;

            //Console.ReadLine();

            Kasser.Fornavn = "Mads";
            Kasser.Efternavn = "Foged";

            Console.WriteLine(Kasser.FuldtNavn);



            Console.ReadLine();

        }
    }
}
