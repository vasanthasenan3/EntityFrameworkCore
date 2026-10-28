using Asp.netpractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Asp.netpractice.Controlers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public HomeController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

        public IActionResult SaveData(Students stud)
        {
            if (ModelState.IsValid)
            {
                stud.Id = 0; 
                _dbcontext.Add(stud);
                _dbcontext.SaveChanges();
                return View("SaveData", stud);

            }
            return View();
        }
        public IActionResult updateData(Students stud)
        {
            var existingstud = _dbcontext.UnPaidStudents.FirstOrDefault(x => x.Id == stud.Id);
            if (existingstud != null)
            {
                existingstud.Name = stud.Name;
                existingstud.PhoneNo = stud.PhoneNo;
                existingstud.FeePending = stud.FeePending;
                existingstud.Department = stud.Department;
                existingstud.Email = stud.Email;
                _dbcontext.SaveChanges();
                return View("SaveData", stud);
            }
            return View("SaveData", stud);
        }


        public IActionResult DeleteData(Students stud)
        {
            var delete = _dbcontext.UnPaidStudents.FirstOrDefault(x => x.Id == stud.Id);
            if (delete != null)
            {
                _dbcontext.UnPaidStudents.Remove(delete);
                _dbcontext.SaveChanges();
                return View("SaveData", stud);
            }
            return View("SaveData", stud);
        }
    }
}
