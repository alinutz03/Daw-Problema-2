using examenvar1.Context;
using examenvar1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace examenvar1.Controllers
{
    public class StudentController: Controller
    {
        private readonly StudentContext _context;
        public StudentController(StudentContext ctx)
        {
            _context = ctx;
        }

        public IActionResult Index()
        {
            
            var Student = _context.Studenti.Include(s => s.Grupa).ToList();

            return View(Student);
        }

        [HttpGet]
        public IActionResult StergeStudent(int id) //Iii trimitem Id ul stirii ca parametru in url 
        {
            var student = _context.Studenti.Find(id); //Cautam stirea dupa id
            _context.Studenti.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult GetAdaugareStudent()
        {
            ViewBag.Grupa = _context.Grupe.Select(x => new SelectListItem { Text = x.Denumire, Value = x.Id.ToString() }).ToList(); // Trebuia oare si AdresaSediu ????
            //ViewBag.CanalTV = _context.CanaleTV.OrderBy(f => f.Nume).ToList();
            return View("AdaugaStudent");
        }


        [HttpPost]
        public IActionResult PostAdaugareStudent(Student student)
        {
            {
                _context.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult EditeazaStudent(int id) //Iii trimitem Id ul stirii ca parametru in url 
        {
            var student = _context.Studenti.Find(id); //Cautam stirea dupa id
            ViewBag.Grupa = _context.Grupe.Select(x => new SelectListItem { Text = x.Denumire, Value = x.Id.ToString() }).ToList(); //populam lista de categorii din formular
            return View(student); //trimitem stirea pe care o modificam catre view
        }
        [HttpPost]
        public IActionResult EditeazaStudent(Student student)
        {
            {
                _context.Studenti.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult ListarePeGrupe()
        {
            var groupCounts = _context.Studenti
            .GroupBy(s => s.GrupaId)
            .Select(g => new { GroupID = g.Key, Count = g.Count() })
            .ToList();

            ViewBag.GroupCounts = groupCounts;
            return View("ListarePeGrupe");
        }
    }
}

