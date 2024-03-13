using Homework_Delegates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Data
{
    internal class PersonDbContext
    {
        public static List<Person> people;
        static PersonDbContext() 
        {
            people = new List<Person>
            {
                new Person
                {
                    Id=1,
                    Name = "Fexriyye",
                    Surname = "Tagizade",
                    Address = "28 May",
                    Salary = 1200
                },
                new Person
                {
                    Id=2,
                    Name = "Elmir",
                    Surname = "Qafarzade",
                    Address = "Sahil",
                    Salary = 800
                },
                new Person
                {
                    Id=3,
                    Name = "Sirac",
                    Surname = "Memmedov",
                    Address = "Neftchiler",
                    Salary = 1800
                },
                new Person
                {
                    Id=4,
                    Name = "Reshad",
                    Surname = "Agayev",
                    Address = "Ehmedli",
                    Salary = 900
                },
                new Person
                {
                    Id=5,
                    Name = "Behruz",
                    Surname = "Aliyev",
                    Address = "Kurdexani",
                    Salary = 1400
                },
            };
        }
    }
}
