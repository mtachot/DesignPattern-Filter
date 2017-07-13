using FilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Classes
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();

            foreach (Person person in persons)
            {
                if (String.Compare(person.getGender().ToUpper(), "FEMALE") == 0)
                    femalePersons.Add(person);
            }

            return femalePersons;
        }
    }
}
