using FilterPattern.Classes;
using FilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleAndMale = new AndCriteria(new CriteriaSingle(), new CriteriaMale());
            ICriteria singleOrFemale = new OrCriteria(new CriteriaSingle(), new CriteriaFemale());

            Console.WriteLine("Males");
            Console.WriteLine("****************");
            PrintPersons(male.meetCriteria(persons));
            Console.WriteLine("\n");

            Console.WriteLine("Females");
            Console.WriteLine("****************");
            PrintPersons(female.meetCriteria(persons));
            Console.WriteLine("\n");

            Console.WriteLine("Single males");
            Console.WriteLine("****************");
            PrintPersons(singleAndMale.meetCriteria(persons));
            Console.WriteLine("\n");

            Console.WriteLine("Single or females");
            Console.WriteLine("****************");
            PrintPersons(singleOrFemale.meetCriteria(persons));

            Console.ReadLine();
        }

        public static void PrintPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(String.Format("Person: [ Name : {0}, Gender : {1}, Marital Status : {2} ]", person.getName(), person.getGender(), person.getMaritalStatus()));
            }
        }
    }
}
