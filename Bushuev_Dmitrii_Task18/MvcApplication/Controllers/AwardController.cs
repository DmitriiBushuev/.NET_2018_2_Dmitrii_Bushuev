using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Department.BLL;
using DAL;
using Models;

namespace MvcApplication.Controllers
{
    public class AwardController : Controller
    {
        private static AwardsBL awards = new AwardsBL();

        static AwardController()
        {
            awards.InitList();
        }

        // GET: Award
        public ActionResult Index()
        {
            ViewBag.HeaderText = "Awards list";
            return View(awards.GetList().Select(ConvertAward));
        }

        // GET: Award/Details/5
        public ActionResult Details(int id)
        {
            Award a = awards.GetList().First(s => s.Id == id);
            return View(ConvertAward(a));
        }

        public ActionResult Edit(int id)
        {
            var currentAward = awards.GetList().FirstOrDefault(a => a.Id == id);
            return View(AwardViewModel.GetViewModel(currentAward, Array.Empty<Award>()));
        }

        // GET: Award/Create
        public ActionResult Create(string title,string description)
        {
            //awards.Add(title, description);
            return View();
        }

        // POST: Award/Create
        [HttpPost]
        public ActionResult Create(Award award)
        {
            try
            {
                awards.Add(award);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Edit(AwardViewModel awardModel)
        {
            try
            {
                awards.Edit(awardModel.ToAward());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var currentAward = awards.GetList().FirstOrDefault(u => u.Id == id);
            if (currentAward != null)
            {
                awards.Delete(currentAward);
            }

            return RedirectToAction("Index");
        }

        public AwardViewModel ConvertAward(Award award)
        {
            var awardModel = new AwardViewModel
            {
                Id = award.Id,
                Title = award.Title,
                Description = award.Description,
            };
            return awardModel;
        }
    }
}
