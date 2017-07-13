using FilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Classes
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();

            foreach (Person person in persons)
            {
                if (String.Compare(person.getMaritalStatus().ToUpper(), "SINGLE") == 0)
                    singlePersons.Add(person);
            }

            return singlePersons;
        }
    }
}
