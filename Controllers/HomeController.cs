using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetCoreMVC.Models;

using Microsoft.EntityFrameworkCore;

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
            
            var query = (from a in context.Authors 
                        join b in context.Books on a.AuthorId equals b.AuthorId
                        select new BooksAndAuthors
                        {
                            FirstName = a.FirstName,
                            LastName = a.LastName, 
                            AuthorId = a.AuthorId,
                            Title = b.Title
                        }).ToList();

            List<ReturnList> res = new List<ReturnList>();
            res.Add(new ReturnList {emailList = mails, personList = persons, authors = db, booksAndAuthors = query});

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
