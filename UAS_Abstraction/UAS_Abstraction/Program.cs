using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UAS_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fashion fashion;   //Abstract class

            Console.WriteLine();
            fashion = new Sneakers();
            fashion.Sepatu();

            Console.WriteLine();
            fashion = new Pantofel();
            fashion.Sepatu();

            Console.WriteLine();
            fashion = new Heels();
            fashion.Sepatu();

            Console.ReadKey();

            /*IFashion fashion;         // menggunakan Interface
             
             Console.WriteLine();

             fashion = new Sneakers();
             fashion.Sepatu();
             Console.WriteLine();
             
             fashion = new Pantofel();
             fashion.Sepatu();
             Console.WriteLine();
             
             fashion = new Heels();
             fashion.Sepatu();
             Console.WriteLine();*/

            Console.ReadKey();
        }
    }
}
