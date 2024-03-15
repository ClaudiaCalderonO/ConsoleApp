using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class Employee : Person
    {
        public DateTime HireDate { get; set; }
    }
}