using Day3StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3StarWars.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Character> Characters = new List<Character>();

            Characters.Add(new Jedi("Luke Skywalker", "Human", "Male", "Green"));
            Characters.Add(new Jedi("Yoda", "YodaSpecies", "Male", "Green"));
            Characters.Add(new Jedi("Aalya Secura", "AlienGirl", "Female", "Blue"));

            Characters.Add(new BountyHunter("Boba Fett", "HumanClone", "Male", "Gun"));
            Characters.Add(new BountyHunter("Bossk", "Trandosha", "Male", "Big Gun"));

            return View(Characters);
        }

        public ActionResult Jedi()
        {
            List<Character> Characters = new List<Character>();

            Characters.Add(new Jedi("Luke Skywalker", "Human", "Male", "Green"));
            Characters.Add(new Jedi("Yoda", "YodaSpecies", "Male", "Green"));
            Characters.Add(new Jedi("Aalya Secura", "AlienGirl", "Female", "Blue"));

            Characters.Add(new BountyHunter("Boba Fett", "HumanClone", "Male", "Gun"));
            Characters.Add(new BountyHunter("Bossk", "Trandosha", "Male", "Big Gun"));

            List<Jedi> Jedis = Characters.Where(j => j.CharacterType == Character.Type.Jedi).Cast<Jedi>().ToList();
            
            return View(Jedis);
        }

        public ActionResult BountyHunter()
        {
            List<Character> Characters = new List<Character>();

            Characters.Add(new Jedi("Luke Skywalker", "Human", "Male", "Green"));
            Characters.Add(new Jedi("Yoda", "YodaSpecies", "Male", "Green"));
            Characters.Add(new Jedi("Aalya Secura", "AlienGirl", "Female", "Blue"));

            Characters.Add(new BountyHunter("Boba Fett", "HumanClone", "Male", "Gun"));
            Characters.Add(new BountyHunter("Bossk", "Trandosha", "Male", "Big Gun"));

            List<BountyHunter> BountyHunters = Characters.Where(b => b.CharacterType == Character.Type.BountyHunter).Cast<BountyHunter>().ToList();

            return View(BountyHunters);
        }


        public ActionResult About()
        {
            Jedi Luke = new Jedi("Luke Skywalker", "Human", "Male", "Green");
            string Sound = Luke.Fighting();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}