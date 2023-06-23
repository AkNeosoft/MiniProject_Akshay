using Data_Access_Layer.Entities;
using MediatR;
using Session3_Employee.Interface;
using Session3_Employee.Mediatr.Query;

namespace Session3_Employee.Mediatr.Handler
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeesQuery, List<Employee>>
    {
        readonly IEmployeeService _employeeService;
        public GetAllEmployeeHandler(IEmployeeService employeeService)
        {
            this._employeeService=employeeService;
        }
        public Task<List<Employee>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => {
                return _employeeService.GetAll();
            });
        }
    }
}
