using Data_Access_Layer.Entities;
using MediatR;

namespace Session3_Employee.Mediatr.Command
{
    public class DeleteEmployeeCommand : IRequest<Employee>
    {  
        public Employee Employee { get;  }
        public DeleteEmployeeCommand(Employee emp)
        {
            Employee=emp;
        }
    }
}
