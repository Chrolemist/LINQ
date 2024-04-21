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
                        orderby p.YearsExperience ascending
                        select p;

            foreach (var person in query)
            {
                Console.WriteLine(person.Print);
            }
            
        }
    }
}
