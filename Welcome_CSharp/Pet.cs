using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_CSharp
{
    public abstract class Pet
    {
        private string name = "<name>";
        private string species = "<species>";

        public Pet(string n, string s)
        {
            name = n;
            species = s;
        }

        public string Name { get; set; }
        public string Species { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"{name} makes a sound!");
        }

        public virtual void Play()
        {
            Console.WriteLine($"{name} plays with the object!");
        }

        public virtual void Info()
        {
            Console.WriteLine($"\tName: {name}");
            Console.WriteLine($"\tSpecies: {species}");
        }
    }
}
