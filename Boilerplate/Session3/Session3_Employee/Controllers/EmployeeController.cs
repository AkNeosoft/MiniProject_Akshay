using Data_Access_Layer.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Session3_Employee.Mediatr.Command;
using Session3_Employee.Mediatr.Query;

namespace Session3_Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMediator mediator;

        
        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await mediator.Send(new GetAllEmployeesQuery());
            return View(employees);
        }
        [HttpGet]

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee( Employee emp )
        {
            await mediator.Send(new AddEmployeeCommand(emp));
            return RedirectToAction("GetAllEmployees");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int  id)
        {
           var emp=  await mediator.Send(new GetSingleEmployeeQuery(id));

            return View(emp);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(Employee emp)
        {
            await mediator.Send(new UpdateEmployeeCommand(emp));

            return RedirectToAction("GetAllEmployees");
        }
        [HttpGet]

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emp = await mediator.Send(new GetSingleEmployeeQuery(id));
            return View(emp);
        }

        [HttpPost]

        public async Task<IActionResult> DeleteEmployee(Employee emp)
        {
            await mediator.Send(new DeleteEmployeeCommand(emp));
            return RedirectToAction("GetAllEmployees");
        }

    }
}
