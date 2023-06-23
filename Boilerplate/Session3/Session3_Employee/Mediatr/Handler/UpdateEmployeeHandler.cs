using Data_Access_Layer.Entities;
using MediatR;
using Session3_Employee.Interface;
using Session3_Employee.Mediatr.Command;

namespace Session3_Employee.Mediatr.Handler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, Employee>
    {
        readonly IEmployeeService _employeeService;

        public UpdateEmployeeHandler(IEmployeeService employeeService)
        {
               _employeeService=employeeService;    
        }
        public async Task<Employee> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeService.Edit(request.employee);
        }
    }
}
