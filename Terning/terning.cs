using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Terning
    {

        public int værdi { get; private set; }
        private bool snyd;
        private static Random rnd = new Random();

        public void Skriv()
        {

            Console.WriteLine(værdi);

        }


        public void Ryst()
        {

            if (snyd)
            {
                værdi = 6;
            }
            else
            {
                værdi = rnd.Next(1, 7);
            }

        }


        public Terning()
        {
            snyd = false;
            Ryst();
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
            Ryst();
        }

    }

}
