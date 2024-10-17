using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffee.EmployeeManager.Data;
public class Department
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }

    public ICollection<Employee> Employees { get; } = [];
}
