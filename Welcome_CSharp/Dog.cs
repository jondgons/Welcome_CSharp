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

        public override void Info()
        {
            throw new NotImplementedException();
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
