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
