using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_CSharp
{
    public class Cat : Pet
    {

        public Cat() : base("<cat>", "Cat") { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} meows lazily.");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} chases after the laser!");
        }

        public override void Info()
        {
            Console.WriteLine($"\tName: {Name}");
            Console.WriteLine($"\tSpecies: {Species}");
        }
    }
}
