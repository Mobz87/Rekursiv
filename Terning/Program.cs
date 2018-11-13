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

            var Spil = new Yatzy();


            while (true)
            {
                Spil.ClearDisplay();
                Spil.KastTerning();
                Spil.Skriv();
                for (int i = 0; i < 3; i++)
                {
                    if (Spil.CheckMatch())

                    {
                        i = 4;
                    }

                    if (i < 2)
                    {
                        Spil.Behold();
                        Spil.Skriv();

                    }
                    
                }

                
            }




            Console.WriteLine("");


            //Check for mulige kombinationer og giv brugeren et valg om at holde bestemte terninger





            Console.ReadLine();

        }
    }
}
