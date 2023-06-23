using Data_Access_Layer.Entities;
using MediatR;

namespace Session3_Employee.Mediatr.Command
{
    public class UpdateEmployeeCommand:IRequest<Employee>
    {
        public UpdateEmployeeCommand(Employee emp)
        {
              employee=emp;
        }

        public Employee employee { get; }
    }
}
