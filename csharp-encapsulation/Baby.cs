using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_encapsulation
{
    class Baby : Human
    {
        public int BabyAge { get { return this.Age; } }

        public override void VirtualPublicMethod()
        {
            //base.VirtualPublicMethod();
            Console.WriteLine("Baby VirtualPublicMethod");
        }

        //public override void PublicMethod() { }; // error -- not virtual
    }
}
