using Data_Access_Layer.Entities;
using MediatR;

namespace Session3_Employee.Mediatr.Query
{
    public class GetSingleEmployeeQuery  :IRequest<Employee>
    {
        public int Id { get; set; }
        public GetSingleEmployeeQuery(int id)
        {
            Id= id;
        }

    }
}
