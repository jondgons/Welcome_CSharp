/*
 * Name: Cody Gonsowski
 * Date: 9/10/2019
 * File: Pet.cs
 * Desc: This is the implementation of the Pet class.
 */

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

        public Pet() { }
        /*
         * Desc:
         *   Default constructor for the Pet class, used as a base for the concrete classes.
         *   
         * Result:
         *   None, Pet cannot be instantiated.
         */

        public string Name { get; set; }
        /*
         * Desc:
         *   Getter/setter for private string name.
         *   
         * Result:
         *   Returns/updates name respectively.
         */

        public string Species { get; set; }
        /*
         * Desc:
         *   Getter/setter for private string species.
         *   
         * Result:
         *   Returns/updates species respectively.
         */

        public virtual void Speak()
        {
            Console.WriteLine($"{name} makes a sound!");
        }
        /*
         * Desc:
         *   Makes the pet speak, relative to its species (subclass).
         *   
         * Result:
         *   Writes to console what the pet says.
         */

        public virtual void Play()
        {
            Console.WriteLine($"{name} plays with the object!");
        }
        /*
         * Desc:
         *   Makes the pet play with something, relative to its species (subclass).
         *   
         * Result:
         *   Writes to console what the pet plays with.
         */

        public virtual void Info()
        {
            Console.WriteLine($"\tName: {name}");
            Console.WriteLine($"\tSpecies: {species}");
        }
        /*
         * Desc:
         *   Displays the pet's info.
         *   
         * Result:
         *   Writes to console the pet's name and species.
         */

        public virtual void SpeedUp() { return; }
        /*
         * Desc:
         *   Placeholder for Snail's SpeedUp() function.
         *   
         * Return:
         *   Nothing.
         */
        public virtual void SpeedDown() { return; }
        /*
         * Desc:
         *   Placeholder for Snail's SpeedDown() function.
         *   
         * Return:
         *   Nothing.
         */
        public virtual void Turbo() { return; }
        /*
         * Desc:
         *   Placeholder for Snail's Turbo() function.
         *   
         * Return:
         *   Nothing.
         */
        public virtual void Slug() { return; }
        /*
         * Desc:
         *   Placeholder for Snail's Slug() function.
         *   
         * Return:
         *   Nothing.
         */
    }
}
