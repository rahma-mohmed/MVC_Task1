using Microsoft.AspNetCore.Mvc;
using Task1_Day1.Models;

namespace Task1_Day1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Student student = StudentList.Students.FirstOrDefault(x => x.Id == id);
            return View("getDetails" , student);
        }

        public IActionResult GetAll()
        {
            List<Student> li = StudentList.Students;
            return View("All",li);
        }
    }
}
