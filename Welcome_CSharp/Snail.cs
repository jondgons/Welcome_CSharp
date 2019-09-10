/*
 * Name: Cody Gonsowski
 * Date: 9/10/2019
 * File: Snail.cs
 * Desc: This is the implementation of the Snail class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_CSharp
{
    public class Snail : Pet
    {
        private double speed;

        public Snail()
        {
            Name = "<snail>";
            Species = "Snail";
            speed = 1.0;
        }
        /*
         * Desc:
         *   Default constructor for the Snail class.
         *   
         * Result:
         *   A new Snail is created, with name <snail> and species Snail.
         */

        public override void Speak()
        {
            Console.WriteLine($"{Name} says nothing and stares deep into your soul...");
        }
        /*
         * Desc:
         *   Makes the snail speak?
         *   
         * Result:
         *   The snail bores holes into the console with its eyes.
         */

        public override void Play()
        {
            if (speed > 0 && speed < 4.0)
            {
                Console.WriteLine($"{Name} slowly makes its way up your arm...");
            }
            else if (speed == 0)
            {
                Console.WriteLine($"You watch {Name} for a while... it doesn't move.");
            }
            else if (speed < 0)
            {
                Console.WriteLine($"{Name} slugs away from you... backwards?!");
            }
            else if (speed >= 4.0 && speed < 32.0)
            {
                Console.WriteLine($"{Name} speeds along like a tiny car!");
            }
            else if (speed >= 32.0 && speed < 128.0)
            {
                Console.WriteLine($"{Name} flies like Superman!!");
            }
            else if (speed >= 128.0)
            {
                Console.WriteLine($"{Name} vanishes and reappears instantly across the room!!!");
            }
        }
        /*
         * Desc:
         *   Makes the snail play depending on speed.
         *   
         * Result:
         *   The snail slimes the console, dependent on its speed.
         */

        public override void Info()
        {
            Console.WriteLine($"\tName: {Name}");
            Console.WriteLine($"\tSpecies: {Species}");
            Console.WriteLine($"\tSpeed: {speed}");
            if (speed > 0 && speed < 4.0)
            {
                Console.WriteLine("\tSpeed Effects: None");
            }
            else if (speed == 0)
            {
                Console.WriteLine("\tSpeed Effects: Immobile");
                Console.WriteLine($"\t\t{Name} is unable to move...");
            }
            else if (speed < 0)
            {
                Console.WriteLine("\tSpeed Effects: Reverse");
                Console.WriteLine($"\t\t{Name} can only move backwards?");
            }
            else if (speed >= 4.0 && speed < 32.0)
            {
                Console.WriteLine("\tSpeed Effects: Quicken");
                Console.WriteLine($"\t\t{Name} goes incredibly fast!");
            }
            else if (speed >= 32.0 && speed < 128.0)
            {
                Console.WriteLine("\tSpeed Effects: Flight");
                Console.WriteLine($"\t\t{Name} gains the power of flight!!");
            }
            else if (speed >= 128.0)
            {
                Console.WriteLine("\tSpeed Effects: Teleportation");
                Console.WriteLine($"\t\t{Name} relocates itself through molecular means!!!");
            }
        }
        /*
         * Desc:
         *   Displays the snail's info.
         *   
         * Result:
         *   The snail's info is written to console, including speed and special attributes.
         */

        public override void SpeedUp()
        {
            speed += .5;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }
        /*
         * Desc:
         *   Increments the snail's speed by .5.
         *   
         * Result:
         *   Snail's speed is increased by .5.
         */

        public override void SpeedDown()
        {
            speed -= .5;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }
        /*
         * Desc:
         *   Decrements the snail's speed by .5.
         *   
         * Result:
         *   Snail's speed is decreased by .5.
         */

        public override void Turbo()
        {
            speed *= 2;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }
        /*
         * Desc:
         *   Doubles the snail's speed.
         *   
         * Result:
         *   Snail's speed is doubled.
         */

        public override void Slug()
        {
            speed /= 2;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }
        /*
         * Desc:
         *   Halves the snail's speed.
         *   
         * Result:
         *   Snail's speed is halved.
         */
    }
}
