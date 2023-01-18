using GraphQL_HotChocolate_ASP.NET_CORE_.Models;
using GraphQL_HotChocolate_ASP.NET_CORE_.Services;

namespace GraphQL_HotChocolate_ASP.NET_CORE_.GraphQL
{
    public class Query
    {
        private readonly IEmployeeService _employeeService;
        public Query(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IQueryable<Employee> Employees => _employeeService.GetAll();

    }
}
