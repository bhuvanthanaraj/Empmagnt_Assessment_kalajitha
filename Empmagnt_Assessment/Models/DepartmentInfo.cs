using System.ComponentModel.DataAnnotations;

namespace Empmagnt_Assessment.Models
{
    public class DepartmentInfo
    {
        public Guid Id { get; set; }


        [Required]
        [Key]
        public String DepCode { get; set; }

        [Required]
        public String DeptName { get; set; }


    }
}
