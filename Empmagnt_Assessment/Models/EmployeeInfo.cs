using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empmagnt_Assessment.Models
{
    public class EmployeeInfo
    {

        public Guid Id { get; set; }

        [Key]
        public String EmpCode { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public DateOnly DOB { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateOnly DOJ { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String MobileNumber { get; set; }


        [Required]
        [ForeignKey("DepartmentInfo")]
        public String DeptCode { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String State { get; set; }
    }
}
