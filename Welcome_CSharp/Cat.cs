/*
 * Name: Cody Gonsowski
 * Date: 9/10/2019
 * File: Cat.cs
 * Desc: This is the implementation of the Cat class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_CSharp
{
    public class Cat : Pet
    {

        public Cat()
        {
            Name = "<cat>";
            Species = "Cat";
        }
        /*
         * Desc:
         *   Default constructor for the Cat class.
         *   
         * Result:
         *   A new Cat is created, with name <cat> and species Cat.
         */

        public override void Speak()
        {
            Console.WriteLine($"{Name} meows lazily.");
        }
        /*
         * Desc:
         *   Makes the cat speak.
         *   
         * Result:
         *   The cat meows at the console.
         */

        public override void Play()
        {
            Console.WriteLine($"{Name} chases after the laser!");
        }
        /*
         * Desc:
         *   Makes the cat play.
         *   
         * Result:
         *   The cat claws up the console.
         */

        public override void Info()
        {
            Console.WriteLine($"\tName: {Name}");
            Console.WriteLine($"\tSpecies: {Species}");
        }
        /*
         * Desc:
         *   Displays the cat's info.
         *   
         * Result:
         *   The cat's info is written to console.
         */
    }
}
