using Data_Access_Layer.Entities;

namespace Session3_Employee.Interface
{
    public interface IEmployeeService
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public  Task<Employee> AddEmployee(Employee employee);

        public Task<Employee> Edit(Employee employee);
        public Task<Employee> Delete(Employee employee);


    }
}
