using Microsoft.AspNetCore.Mvc;
using CgpaProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace CgpaProject.Controllers
{
    public class ResultController : Controller
    {

        private readonly dbContext _db;


        public ResultController(dbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {

            var resultList = _db.Results.Include(o => o.Subject).Include(o => o.SecondSubject);
            

            return View(await resultList.ToListAsync());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var resultObj = _db.Results.FirstOrDefault(x => x.Id == id);


            if (resultObj == null)
            {
                return NotFound();
            }
            return View(resultObj);
        }


        public IActionResult Create()
        {
            ViewData["SubjectId"] = new SelectList(_db.Subjects, "Id", "SubjectName");
            ViewData["SecondSubjectId"] = new SelectList(_db.SecondSubjects, "Id", "SecondSubjectName");
            

            Result result = new Result();
             
            int count = _db.Results.Count();
            count = count + 1;

            result.SerialNumber = "Sl-" + DateTime.Now.Year + "-" + count;


            return View(result);

        }

        [HttpPost]
         

        public IActionResult Create(Result result)
        {
            //if (dataPass != null && ModelState.IsValid)
            if (ModelState.IsValid)
            {
                _db.Add(result);
                _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            ViewData["SubjectId"] = new SelectList(_db.Subjects, "Id", "SubjectName", result.SubjectId);
            ViewData["SecondSubjectId"] = new SelectList(_db.SecondSubjects, "Id", "SecondSubjectName", result.SecondSubjectId);
           

            return View(result);
        }

        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var resultObj = _db.Results.FirstOrDefault(x => x.Id == id);
            if (resultObj == null)
            {
                return NotFound();
            }
            ViewData["SubjectId"] = new SelectList(_db.Subjects, "Id", "SubjectName");
            ViewData["SecondSubjectId"] = new SelectList(_db.SecondSubjects, "Id", "SecondSubjectName");
  
            return View(resultObj);
        }

        [HttpPost]

        public IActionResult Edit(Result resultObj)
        {
            if (resultObj == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(resultObj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["SubjectId"] = new SelectList(_db.Subjects, "Id", "SubjectName");
            ViewData["SecondSubjectId"] = new SelectList(_db.SecondSubjects, "Id", "SecondSubjectName");
             


            return View(resultObj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var resultObj = _db.Results.FirstOrDefault(x => x.Id == id);
            _db.Results.Remove(resultObj);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        private bool OrderExists(int id)
        {
            return _db.Results.Any(e => e.Id == id);
        }
        public IActionResult JavaScript()
        {
            return View();
        }
    }
}
