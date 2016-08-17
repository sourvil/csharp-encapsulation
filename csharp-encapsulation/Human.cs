using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_encapsulation
{
    public class Human
    {
        private int _birthYear;

        /// <summary>
        /// Set "BirthYear" of Human
        /// </summary>
        public int BirthYear
        {
            set { _birthYear = value; }
        }

        private string _name;

        /// <summary>
        /// Set or Get "Name" of Human
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Get "Age" of Human
        /// </summary>
        protected int Age { get { return DateTime.Today.Year - this._birthYear; } }



        private int _workStartYear;
        /// <summary>
        /// Set WorkStartYear of Human
        /// </summary>
        public int WorkStartYear
        {
            set { _workStartYear = value; }
        }


        internal int WorkExperienceYear { get { return DateTime.Now.Year - this._workStartYear; } }

    }
}
