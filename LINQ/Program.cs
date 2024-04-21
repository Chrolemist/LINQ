using MockDataAccess;
using System.Net;

namespace LINQ
{
    class Program
    {
        public static ListManager ListManager { get; set; }
        static void Main(string[] args)
        {
            List<Person> personCollection = ListManager.LoadSampleData();

            var query = from p in personCollection
                        where p.YearsExperience > 10
                        orderby p.YearsExperience ascending
                        select p;

            foreach (var person in personCollection)
            {
                Console.WriteLine(person.Print);
            }
            
        }
    }
}
