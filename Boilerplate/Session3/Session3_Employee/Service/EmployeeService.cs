using Data_Access_Layer.dbContext;
using Data_Access_Layer.Entities;
using Session3_Employee.Interface;

namespace Session3_Employee.Service
{
    public class EmployeeService: IEmployeeService
    {
        readonly EmployeeDbContext _employeeDbContext;

        public EmployeeService(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext=employeeDbContext;
        }

        public List<Employee> GetAll()
        {
            return _employeeDbContext.EmployeeTbl.ToList();
        }

        public Employee GetById(int id)
        {
            return _employeeDbContext.EmployeeTbl.Where(X => X.Id == id).FirstOrDefault();
        }


        public async Task<Employee> AddEmployee(Employee employee)
        {
            _employeeDbContext.EmployeeTbl.Add(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> Edit(Employee employee)
        {
           //Employee emp=  _employeeDbContext.EmployeeTbl.Where(X => X.Id == employee.Id).FirstOrDefault();
           // if(emp != null)
           // {

                _employeeDbContext.EmployeeTbl.Update(employee);
                await _employeeDbContext.SaveChangesAsync();
                return employee;

            //}
            //else
            //{
            //    throw new Exception("Employee With This Id Does Not Exists");
            //}

           
        }
        public async Task<Employee> Delete(Employee employee)
        {
         _employeeDbContext.EmployeeTbl.Remove(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }
    }
}
