using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models;

[Table("Students")]
public class Student
{
    [Key]
    public int StudentID { get; set; }

    [Required]
    [StringLength(50)]
    public string? StudentName { get; set; }

    public DateTime DateOfBirth { get; set; }

    [Range(0, 300)]
    public decimal Height { get; set; }

    [Range(0, 400)]
    public float Weight { get; set; }
}
