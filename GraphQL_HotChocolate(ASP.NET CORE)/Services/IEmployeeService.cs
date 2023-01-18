using GraphQL_HotChocolate_ASP.NET_CORE_.Models;

namespace GraphQL_HotChocolate_ASP.NET_CORE_.Services
{
    public interface IEmployeeService
    {
        Task<Employee> Create(Employee employee);
        Task<bool> Delete(DeleteVM deleteVM);
        IQueryable<Employee> GetAll();

    }
}
