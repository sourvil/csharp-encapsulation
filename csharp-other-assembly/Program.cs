using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_encapsulation;

namespace csharp_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Burak Donbay";   // public
            human.BirthYear = 1970;        // public
            //Console.WriteLine(human.WorkExperienceYear);  // internal -- error
            //Console.WriteLine(human.Age); // protected -- error

            Console.ReadLine();
        }
    }
}
