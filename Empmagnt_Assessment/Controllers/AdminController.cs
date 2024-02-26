using Empmagnt_Assessment.Data;
using Microsoft.AspNetCore.Mvc;
using Empmagnt_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Empmagnt_Assessment.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataDbContext dataDbContext;

        public AdminController(DataDbContext dataDbContext)
        {
            this.dataDbContext = dataDbContext;
        }




        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult AddEmpPage()
        {
            return View();
        }





        [HttpPost]
        public ActionResult Adminlogin(string UserName, string Password)
        {

            if (UserName == Password)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }




        [HttpGet]

        public async Task<IActionResult> Dashboard()
        {
            var localvar = await dataDbContext.EmployeeInfos
                .OrderBy(x => x.DOJ)
                .ToListAsync();

            return View(localvar);
        }





        [HttpPost]

        public async Task<IActionResult> AddEmp(EmployeeInfo employeeInfo)
        {
            var localvar = new EmployeeInfo()
            {
                Id = Guid.NewGuid(),
                EmpCode = "EMP" + employeeInfo.EmpCode,
                FirstName = employeeInfo.FirstName,
                LastName = employeeInfo.LastName,
                DOB = employeeInfo.DOB,
                Age = employeeInfo.Age,
                DOJ = employeeInfo.DOJ,
                Email = employeeInfo.Email,
                MobileNumber = employeeInfo.MobileNumber,
                DeptCode = employeeInfo.DeptCode,
                Address = employeeInfo.Address,
                City = employeeInfo.City,
                State = employeeInfo.State,
            };
             await dataDbContext.EmployeeInfos.AddAsync(localvar);
             await dataDbContext.SaveChangesAsync();
             return RedirectToAction("Dashboard");

        }





        [HttpGet]

        public async Task<IActionResult> GetSalDetails()
        {

            var localvar = await dataDbContext.EmployeeSalaryDetails.ToListAsync();
            return View(localvar);

        }






        [HttpGet]

        public async Task<IActionResult> EditSal(Guid id)
        {
            var localvar = await dataDbContext.EmployeeSalaryDetails.FindAsync(id);

            if (localvar != null)
            {
                return View(localvar);

            }

            return RedirectToAction("GetSalDetails");

        }





        [HttpPost]

        public async Task<IActionResult> ViewUpdate(UpdateSalary model)

        {
            var localvar = await dataDbContext.EmployeeSalaryDetails.FindAsync(model.Id);
            if (localvar != null)
            {
                localvar.BasicPay=model.BasicPay;
                localvar.DA=model.DA;
                localvar.HRA=model.HRA;
                localvar.OtherAllowances=model.OtherAllowances;
                localvar.Deductions=model.Deductions;
                localvar.GrossPay=model.GrossPay;

                await dataDbContext.SaveChangesAsync();
                return RedirectToAction("GetSalDetails");
            }
            return RedirectToAction("GetSalDetails");
        }





    }
}
