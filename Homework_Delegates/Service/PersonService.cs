using Homework_Delegates.Data;
using Homework_Delegates.Models;
using Homework_Delegates.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Service
{
    internal class PersonService : IPersonService
    {
        public List<Person> ShowPersonBySalary(Predicate<Person> func)
        {
            List<Person> foundPeople = new List<Person>();
            foreach (var person in PersonDbContext.people)
            {
                if (func(person))
                {
                    foundPeople.Add(person);
                }
            }
            return foundPeople;
        }
    }
}
