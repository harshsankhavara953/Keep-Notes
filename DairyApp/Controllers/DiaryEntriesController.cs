using DairyApp.Data;
using DairyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DairyApp.Controllers
{
    public class DiaryEntriesController: Controller
    {

        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if(obj !=null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            // If validation fails, redisplay the form with errors
            return View(obj);

        }
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if(Id==null || Id == 0)
            {
                return NotFound();

            }

            DiaryEntry ? diaryEntry = _db.DiaryEntries.Find(Id);
            if (diaryEntry == null) {
                return NotFound();
              }
            return View(diaryEntry);
        }
        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj);// item updated in database
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            // If validation fails, redisplay the form with errors
            return View(obj);

        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();

            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(Id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            return View(diaryEntry);
        }
        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Remove(obj);// item updated in database
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            // If validation fails, redisplay the form with errors
            return View(obj);

        }

    }
}
