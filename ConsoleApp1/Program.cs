using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Test1 = new A();
            var Test2 = new A();
            var Test3 = new A();


            Test3.Write = "tekst1";
            Test1.Write = "tekst";



            Test2 = Test1;
            Test1 = Test3;




            Console.WriteLine(Test1.Write);
            Console.WriteLine(Test2.Write);
            Console.WriteLine(Test3.Write);


            Console.ReadLine();




        }
    }


    public class A
    {

        public string Write { get; set; }


    }




}
