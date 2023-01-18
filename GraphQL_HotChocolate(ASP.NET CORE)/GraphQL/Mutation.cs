using GraphQL_HotChocolate_ASP.NET_CORE_.Models;
using GraphQL_HotChocolate_ASP.NET_CORE_.Services;

namespace GraphQL_HotChocolate_ASP.NET_CORE_.GraphQL
{
    public class Mutation
    {
        private readonly IEmployeeService _employeeService;
        public Mutation(IEmployeeService employeeService)
        {
            _employeeService= employeeService;
        }
        public async Task<Employee> Create(Employee employee) => await _employeeService.Create(employee);
        public async Task<bool> Delete(DeleteVM deleteVM) => await _employeeService.Delete(deleteVM);

    }
}
