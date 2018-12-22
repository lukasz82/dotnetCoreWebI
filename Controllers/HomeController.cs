using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetCoreMVC.Models;

namespace dotnetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Mails> mails = new List<Mails>();
            string smg = "";
            for (int i = 0; i < 10; i++)
            {
                smg = "Wiadomosc nr : " + i.ToString();
                mails.Add(new Mails() {mailId=i, message=smg});
            }

            List<Person> persons = new List<Person>();
            for (int i = 0; i < 20; i++)
            {
                smg = i.ToString();
                persons.Add(new Person() {name = "Osoba nr " + smg,surname = "Nazwisko nr" + smg, personId = i});
            }

            EFCoreWebDemoContext context = new EFCoreWebDemoContext();
            var db = context.Authors.ToList();

            List<ReturnList> res = new List<ReturnList>();
            res.Add(new ReturnList {emailList = mails, personList = persons, authors = db});

            //return View(result);
            return View(res);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
