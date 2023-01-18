using GraphQL_HotChocolate_ASP.NET_CORE_.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_HotChocolate_ASP.NET_CORE_.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _dbContext;
        public EmployeeService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Employee> Create(Employee employee)
        {
            var data = new Employee
            {
                Name = employee.Name,
                Designation = employee.Designation,
            };
            await _dbContext.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<bool> Delete(DeleteVM deleteVM)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == deleteVM.Id);
            if(employee is not null)
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public IQueryable<Employee> GetAll()
        {
            return _dbContext.Employees.AsQueryable();
        }
    }
    public class DeleteVM
    {
        public int Id { get; set; }
    }
}
