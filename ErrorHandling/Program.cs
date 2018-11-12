using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            string fil;
            int tal;

            fil = @"c:\temp\tal.txt";

            if (!File.Exists(fil))
            {
                //Files findes ikke
                throw new ApplicationException("Filen findes ikke " + fil);
            }


            try
            {

                //Læser og convertere
               tal = Convert.ToInt32 (File.ReadAllText(fil));

                //lægger en til tallet
               tal++;

                //skriver tallet til filen
                File.WriteAllText(fil, tal.ToString());




            }
            catch  (FormatException)
            {
                //Hvis Int32 går galt
                throw new ApplicationException("Indhold kan ikke konverteres til et heltal");


            }
            catch (Exception)
            {

                throw new ApplicationException("Filen kunne ikke læses..");
            }




        }
    }
}
