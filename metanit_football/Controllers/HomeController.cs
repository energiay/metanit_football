using metanit_football.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace metanit_football.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var players = db.Players.Include(p => p.Team);
            return View(players.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            // Формируем селектЛист (список команд) для передачи в представление
            SelectList teams = new SelectList(db.Teams, "Id", "Name");
            ViewBag.Teams = teams;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Player player)
        {
            db.Players.Add(player);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            if (Id==null)
            {
                return HttpNotFound();
            }

            Player player = db.Players.Find(Id);
            if (player!=null)
            {
                SelectList teams = new SelectList(db.Teams, "Id", "Name", player.TeamId);
                ViewBag.Teams = teams;
                return View(player);
            }

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Edit(Player player)
        {
            db.Entry(player).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}