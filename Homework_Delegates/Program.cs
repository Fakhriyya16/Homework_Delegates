
using Homework_Delegates;
using Homework_Delegates.Controllers;

DelegatePractise delegatePractise = new DelegatePractise();

//delegatePractise.SumOfNumsByCondition(new List<int> { 1,2,3,3,4,5,7,9}, m=> m > 7);

//delegatePractise.Execute();

PersonController personController = new PersonController();
BookController bookController = new BookController();

//personController.ShowPersonBySalary();
bookController.NumberOfBooks();
