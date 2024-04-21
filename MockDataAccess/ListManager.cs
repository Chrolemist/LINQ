namespace MockDataAccess
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();
            
            output.Add(new Person() { FirstName = "Tim", LastName = "Corey", Birthday = DateTime.Parse("1970-2-25"), YearsExperience = 20});
            output.Add(new Person() { FirstName = "Joe", LastName = "Smith", Birthday = DateTime.Parse("1980-3-14"), YearsExperience = 10});
            output.Add(new Person() { FirstName = "Sue", LastName = "Storm", Birthday = DateTime.Parse("1990-5-5"), YearsExperience = 15});
            output.Add(new Person() { FirstName = "Sara", LastName = "Peck", Birthday = DateTime.Parse("2000-6-20"), YearsExperience = 8});
            output.Add(new Person() { FirstName = "Jane", LastName = "Doe", Birthday = DateTime.Parse("2010-7-4"), YearsExperience = 5});
            output.Add(new Person() { FirstName = "Samantha", LastName = "Jones", Birthday = DateTime.Parse("2020-8-10"), YearsExperience = 2});
            output.Add(new Person() { FirstName = "Bob", LastName = "Smith", Birthday = DateTime.Parse("2030-9-15"), YearsExperience = 1});
               
            return output;
        }

    }
}
