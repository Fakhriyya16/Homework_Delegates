using Homework_Delegates.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Controllers
{
    internal class PersonController
    {
        PersonService personService;
        public PersonController()
        {
            personService = new PersonService();
        }
        public void ShowPersonBySalary()
        {
            var response = personService.ShowPersonBySalary(m => m.Salary > 1000);
            foreach(var item in response)
            {
                Console.WriteLine(item.Name + " " + item.Surname + "-" + item.Address + "-" + item.Salary );
            }
        }
    }
}
