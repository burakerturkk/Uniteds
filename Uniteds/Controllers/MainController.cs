using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uniteds.Models;
using Uniteds.Repositories;

namespace Uniteds.Controllers
{
    public class MainController : Controller
    {
        SubNoteRepository subrepo = new SubNoteRepository();
        NoteRepository noteRepository = new NoteRepository();
        Context c = new Context();
        public IActionResult Index()
        {
           
            var list = noteRepository.TList();
            var sublist = subrepo.TList();
            foreach (var item in list)
            {
                item.SubNote = sublist.Where(x => x.NoteId == item.Id).ToList();
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult AddTopNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTopNote(Note n)
        {
            if (!ModelState.IsValid)
            {
                return View("AddTopNote");
            }
            noteRepository.TAdd(n);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteTopNote(int id)
        {
            var x = noteRepository.TGet(id);
            noteRepository.TDelete(x);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddSubNote()
        {
            List<SelectListItem> values = (from x in c.Notes.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Content,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.v1 = values;

         
            return View();
        }

        [HttpPost]
        public IActionResult AddSubNote(SubNote sn)
        {
            if (!ModelState.IsValid)
            {
                return View("AddSubNote");
            }
            subrepo.TAdd(sn);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSubNote(int id)
        {
            var x = subrepo.TGet(id);
            subrepo.TDelete(x);
            return RedirectToAction("Index");
        }
    }
}