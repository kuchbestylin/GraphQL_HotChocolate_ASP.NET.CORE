using System.ComponentModel.DataAnnotations;

namespace GraphQL_HotChocolate_ASP.NET_CORE_.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
