using Data_Access_Layer.Entities;
using MediatR;
using Session3_Employee.Interface;
using Session3_Employee.Mediatr.Command;

namespace Session3_Employee.Mediatr.Handler
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {

        readonly IEmployeeService _employeeService;

        public AddEmployeeHandler(IEmployeeService employeeService)
        {
           _employeeService= employeeService;
        }
        public async Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeService.AddEmployee(request.employee);
        }
    }
}
