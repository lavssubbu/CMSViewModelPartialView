using Microsoft.AspNetCore.Mvc;
using CMSViewModelDemo.Models;
using CMSViewModelDemo.ViewModel;

namespace CMSViewModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> emplst = new List<Employee>()
        {
            new Employee(){eid=111,ename="Megha",salary=90000,dept="HR",AddressId=1},
             new Employee(){eid=112,ename="Megha",salary=90000,dept="HR",AddressId=2},
              new Employee(){eid=113,ename="Megha",salary=90000,dept="HR",AddressId=3}
        };
        public IActionResult Index()
        {
            return View(emplst);
        }
        public IActionResult Details()
        {
            //Employee Basic details
            Employee emp = new Employee()
            {
                eid = 114,
                ename = "Dheepu",
                salary = 70000,
                dept = "Developer",
                AddressId = 4
            };
            //Address details
            Address addr = new Address()
            {
                DNo = 4,
                StName = "NehruSt",
                City = "Bangalore",
                State = "Karnataka",
                country = "India"
            };

            EmpAddressViewModel empAddress = new EmpAddressViewModel()
            {
                employee = emp,
                address = addr
            };
            
            return View(empAddress);
        }
    }
}
