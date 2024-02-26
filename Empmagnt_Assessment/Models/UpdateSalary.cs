namespace Empmagnt_Assessment.Models
{
    public class UpdateSalary
    {
        public Guid Id { get; set; }
        public String EmpCode { get; set; }
        public String BasicPay { get; set; }
        public String DA { get; set; }
        public String HRA { get; set; }
        public String OtherAllowances { get; set; }
        public String Deductions { get; set; }
        public String GrossPay { get; set; }
    }
}
