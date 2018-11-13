using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Yatzy
    {

        private enum Kombi
        {
            EtPar,
            ToPar,
            TreEns,
            FireEns,
            Lav,
            Høj,
            FuldHus,
            Chance,
            Zatzy

        }

        private List<Terning> kast;

        private List<Kombi> FærdigKombi;
        private char userInput;
        private int Points;

        public bool CheckMatch()
        {
            Sort();

            //et par

            //Tjek om par allerede er taget?
            if (!FærdigKombi.Any(item => item == Kombi.EtPar))
            {


                //Tjekker bagfra
                for (int i = kast.Count - 1; i > 1; i--)
                {

                    //Hvis to ens står ved siden af hinanden
                    if (kast[i].værdi == kast[i - 1].værdi)
                    {
                        //Skriv til user og vent på svar
                        Console.WriteLine($"Vi har match på {kast[i].værdi} - Hvis du tage den? [y/n]");
                        userInput = Console.ReadKey().KeyChar;
                        Console.WriteLine("");

                        //Hvis bruger acceptere
                        if (userInput == 'y')
                        {
                            //Tildeler points
                            Points += kast[i].værdi * 2;

                            //Skriver besked
                            Console.WriteLine($"Tillykke du har nu fået et match! Du har nu: {Points}Points");

                            //Registere match så den ikke kommer igen
                            FærdigKombi.Add(Kombi.EtPar);

                            return true;
                        }
                        return false;
                    }

                }
                
            }
            return false;
        }


        private void Sort()
        {
            kast.Sort((x, y) => x.værdi.CompareTo(y.værdi));

        }

        public void KastTerning()
        {
            //Console.WriteLine("Klar til at kaste terninger?");
            //Console.ReadLine();
            foreach (var item in kast)
            {
                item.Ryst();
             }
            Sort();

        }

        public void Skriv()
        {
            Console.WriteLine("Nyt Kast:");
            foreach (var item in kast)
            {
                item.Skriv();
            }


        }
       

        public void Behold()
        {
            Console.WriteLine("Genkaste nogle af dine terninger? Skriv hvilke fra 1 til 6 f.eks. [246]");
            String Read = Console.ReadLine();

            foreach (char Tal in Read)
            {
                kast[(int)Tal-49].Ryst();
            }
            Sort();

        }

        public void ClearDisplay()
        {

            Console.Clear();

        }







    public Yatzy()
        {
            FærdigKombi = new List<Kombi>();

            //Opretter spillet med antal terninger
            kast = new List<Terning>();            

            for (int i = 0; i < 6; i++)
            {
                kast.Add(new Terning());
            }




        }


    }
}
