using FilterPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Interfaces
{
    public interface ICriteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }
}
