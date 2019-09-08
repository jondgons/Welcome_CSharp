using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            Console.WriteLine("Hello! Welcome to the PetHouse!");
            Console.WriteLine("What would you like to do today?");
            Console.Write("\n\t1 - Add a Pet" +
                          "\n\t2 - Speak" +
                          "\n\t3 - Play" +
                          "\n\t4 - Info");

            userChoice = Convert.ToInt32(Console.ReadKey());
        }
    }
}
