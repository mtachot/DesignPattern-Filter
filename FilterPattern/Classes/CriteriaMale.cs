using FilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Classes
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();

            foreach (Person person in persons)
            {
                if (String.Compare(person.getGender().ToUpper(), "MALE") == 0)
                    malePersons.Add(person);
            }

            return malePersons;
        }
    }
}
