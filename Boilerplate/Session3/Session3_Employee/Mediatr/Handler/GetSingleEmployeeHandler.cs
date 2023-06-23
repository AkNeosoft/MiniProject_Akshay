using Data_Access_Layer.Entities;
using MediatR;
using Session3_Employee.Interface;
using Session3_Employee.Mediatr.Query;

namespace Session3_Employee.Mediatr.Handler
{
    public class GetSingleEmployeeHandler : IRequestHandler<GetSingleEmployeeQuery, Employee>
    {

        readonly IEmployeeService _employeeService;
        public GetSingleEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService; 

        }
        public Task<Employee> Handle(GetSingleEmployeeQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => {
                return _employeeService.GetById(request.Id);
            });
        }
    }
}
