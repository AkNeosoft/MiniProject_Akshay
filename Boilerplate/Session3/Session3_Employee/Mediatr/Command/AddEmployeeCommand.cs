using Data_Access_Layer.Entities;
using MediatR;

namespace Session3_Employee.Mediatr.Command
{
    public class AddEmployeeCommand : IRequest<Employee>
    {
        public Employee employee { get;  }
        public AddEmployeeCommand(Employee emp)
        {
            employee = emp;
        }
    }
}
