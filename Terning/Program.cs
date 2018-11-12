using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {


            //Opretter spillet
            var kast = new List<Terning>();

            for (int i = 0; i < 6; i++)
            {
                kast.Add(new Terning());
            }


            
            
            
            //Kaster 6 terninger
            foreach (var item in kast)
            {
                item.Ryst();
                item.Skriv();
            }


            

            Console.WriteLine("");

            foreach (var item in kast)
            {
                item.Skriv();
            }


            //Check for mulige kombinationer og giv brugeren et valg om at holde bestemte terninger





            Console.ReadLine();

        }
    }
}
