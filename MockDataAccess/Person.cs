using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataAccess
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int YearsExperience { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string Print
        {
            get
            {
                return $"{FullName} ({Birthday.ToString("MM/dd/yyyy")}) - {YearsExperience} years experience";
            }
        }
    }
}
