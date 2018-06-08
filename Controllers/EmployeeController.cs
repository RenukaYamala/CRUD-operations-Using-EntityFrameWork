using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee_UsingEntityFrameWork.Data;
using Employee_UsingEntityFrameWork.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_UsingEntityFrameWork.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (var _context = new EmployeeDBContext())
            {
                var listOfStudents = new List<EmployeeModel>();
                listOfStudents = _context.Employees.ToList();
                return Ok(listOfStudents);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]EmployeeModel EmployeeObject)
        {
            using (var _context = new EmployeeDBContext())
            {
                _context.Employees.Add(EmployeeObject);
                _context.SaveChanges();
            }
            return Ok("Student Added");
        }

        [HttpPut]
        public ActionResult Put([FromBody]EmployeeModel StudentObject)
        {
            using (var _context = new EmployeeDBContext())
            {
                _context.Employees.Update(StudentObject);
                _context.SaveChanges();
            }
            return Ok("Student updated");
        }

        [HttpDelete]
        public ActionResult Delete([FromBody]EmployeeModel StudentObject)
        {
            using (var _context = new EmployeeDBContext())
            {
                _context.Employees.Remove(StudentObject);
                _context.SaveChanges();
            }
            return Ok("Student Deleted");
        }

    }
}
