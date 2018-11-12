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

        public List<Terning> kast { get; set; }

        private List<Kombi> FærdigKombi;

        private void CheckMatch()
        {
            Sort();

            //et par
            for (int i = 0; i < kast.Count; i++)
            {

                



            }





        }


        private void Sort()
        {
            kast.Sort((x, y) => x.værdi.CompareTo(y.værdi));

        }


    }
}
