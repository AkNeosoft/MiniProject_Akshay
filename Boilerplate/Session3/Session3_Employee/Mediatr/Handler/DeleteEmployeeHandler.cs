using Data_Access_Layer.Entities;
using MediatR;
using Session3_Employee.Interface;
using Session3_Employee.Mediatr.Command;

namespace Session3_Employee.Mediatr.Handler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, Employee>
    {
        readonly IEmployeeService _employeeService;
        public DeleteEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService= employeeService;
        }
        public async Task<Employee> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeService.Delete(request.Employee);
        }
    }
}
