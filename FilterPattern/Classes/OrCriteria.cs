using FilterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Classes
{
    public class OrCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = criteria.meetCriteria(persons);
            List<Person> otherCriteriaPersons = otherCriteria.meetCriteria(persons);

            foreach (Person person in firstCriteriaPersons)
            {
                if (!otherCriteriaPersons.Contains(person))
                    otherCriteriaPersons.Add(person);
            }

            return otherCriteriaPersons;
        }
    }
}
