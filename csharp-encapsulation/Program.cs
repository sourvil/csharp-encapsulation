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
            human.Name = "Burak";   // public
            human.BirthYear = 1980;        // public
            human.WorkStartYear = 2000;
            Console.WriteLine("Work Experience: {0} year(s)",  human.WorkExperienceYear);  // internal
            //Console.WriteLine("Age: {0}", human.Age);  // protected -- error

            Baby baby = new Baby();
            baby.Name = "Nehir";
            baby.BirthYear = 2010;
            //baby._workStartYear = 2015; // private -- error
            Console.WriteLine("BabyAge: {0}", baby.BabyAge); // public/protected - derived class

            Console.ReadLine();
        }
    }
}
