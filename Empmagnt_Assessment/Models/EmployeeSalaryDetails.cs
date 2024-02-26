using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Empmagnt_Assessment.Models
{
    public class EmployeeSalaryDetails
    {

        public Guid Id { get; set; }

        [Required]
        [ForeignKey("EmployeeInfo")]
        public String EmpCode { get; set; }
        public String BasicPay { get; set; }
        public String DA { get; set; }
        public String HRA { get; set; }
        public String OtherAllowances { get; set; }
        public String Deductions { get; set; }
        public String GrossPay { get; set; }



    }
}
