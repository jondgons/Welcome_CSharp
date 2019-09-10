/*
 * Name: Cody Gonsowski
 * Date: 9/10/2019
 * File: Dog.cs
 * Desc: This is the implementation of the Dog class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_CSharp
{
    public class Dog : Pet
    {

        public Dog()
        {
            Name = "<dog>";
            Species = "Dog";
        }
        /*
         * Desc:
         *   Default constructor for the Dog class.
         *   
         * Result:
         *   A new Dog is created, with name <dog> and species Dog.
         */

        public override void Speak()
        {
            Console.WriteLine($"{Name} barks happily!");
        }
        /*
         * Desc:
         *   Makes the dog speak.
         *   
         * Result:
         *   The dog barks at the console.
         */

        public override void Play()
        {
            Console.WriteLine($"{Name} fetches the ball!");
        }
        /*
         * Desc:
         *   Makes the dog play.
         *   
         * Result:
         *   The dog fetches the console.
         */

        public override void Info()
        {
            Console.WriteLine($"\tName: {Name}");
            Console.WriteLine($"\tSpecies: {Species}");
        }
        /*
         * Desc:
         *   Displays the dog's info.
         *   
         * Result:
         *   The dog's info is written to console.
         */
    }
}
