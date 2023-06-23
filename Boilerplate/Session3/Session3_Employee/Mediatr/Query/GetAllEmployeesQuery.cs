using Data_Access_Layer.Entities;
using MediatR;

namespace Session3_Employee.Mediatr.Query
{
    public class GetAllEmployeesQuery: IRequest<List<Employee>>
    {
    }
}
