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

        public override void Speak()
        {
            Console.WriteLine($"{Name} says nothing and stares deep into your soul...");
        }

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

        public override void SpeedUp()
        {
            speed += .5;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }

        public override void SpeedDown()
        {
            speed -= .5;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }

        public override void Turbo()
        {
            speed *= 2;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }

        public override void Slug()
        {
            speed /= 2;
            Console.WriteLine($"{Name}'s new speed is {speed}.");
        }
    }
}
