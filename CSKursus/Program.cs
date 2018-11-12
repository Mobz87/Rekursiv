using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKursus
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Start på op tælling:");

            //LøkkeSomMedtode(1, 20);

            PathFinder(@"c:/");

            Console.ReadLine();





        }

        public static void LøkkeSomMedtode(int fra, int til)
        {

            Console.WriteLine(fra);

            if (fra < til)
            {
                LøkkeSomMedtode(fra + 1, til);
            }
        }



        public static void PathFinder(string path)
        {

            DirectoryInfo d = new DirectoryInfo(path);
            


                FileInfo[] files = d.GetFiles();
                DirectoryInfo[] Folders = d.GetDirectories();
 


            foreach (var file in files)
            {
                Console.WriteLine(file.FullName);
            }

            foreach (var folder in Folders)
            {
                PathFinder(folder.FullName);
            }

        }

    }




}



