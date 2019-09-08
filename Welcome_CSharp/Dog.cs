using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_CSharp
{
    public class Dog : Pet
    {

        public Dog() : base("<dog>", "Dog") { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} barks happily!");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} fetches the ball!");
        }

        public override void Info()
        {
            Console.WriteLine($"\tName: {Name}");
            Console.WriteLine($"\tSpecies: {Species}");
        }
    }
}
