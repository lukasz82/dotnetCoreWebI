using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetCoreMVC.Models;
using System.Collections;
using System.Collections.Specialized;
using System.Data;


using Microsoft.EntityFrameworkCore;

namespace dotnetCoreMVC.Controllers
{
    public class Books : Controller
    {
        EFCoreWebDemoContext context = new EFCoreWebDemoContext();

        [HttpPost]
        public ActionResult Add(string title, int actualAuthorId)
        {
            var books = context.Set<Book>();
            books.Add(new Book { Title = title, AuthorId = actualAuthorId });

            try
            {
                ViewBag.result = title + " " + actualAuthorId;
                context.SaveChanges();
                return RedirectToAction("Show", "Authors", new { id = actualAuthorId });
            }
            catch (Exception e)
            {
                ViewBag.result = title + " " + actualAuthorId + e;
                return RedirectToAction("Show", "Authors", new { id = actualAuthorId });
            }
        }

        public ActionResult Delete(int bookId, int authorId)
        {
            var books = context.Set<Book>();
            books.Remove(new Book { BookId = bookId });

            try
            {
                context.SaveChanges();
                return RedirectToAction("Show", "Authors", new { id = authorId });
            }
            catch (Exception e)
            {
                return RedirectToAction("Show", "Authors", new { id = authorId });
            }
        }

        [HttpPost]
        public ActionResult Update(int bookId, string title, int authorId)
        {
            var books = context.Set<Book>();
            books.Update(new Book { BookId = bookId, Title = title, AuthorId = authorId });
            // TODO: dodać obsugę blędów
            try
            {
                context.SaveChanges();
                return RedirectToAction("Show", "Authors", new { id = authorId });
            }
            catch (Exception e)
            {
                return RedirectToAction("Show", "Authors", new { id = authorId });
            }
        }
        public ActionResult Edit(int id)
        {

            var query = (from b in context.Books
                         join a in context.Authors on b.AuthorId equals a.AuthorId
                         where b.BookId == id
                         select new AuthorsBooksViewModel()
                         {
                             Authors = a,
                             Books = b
                         }).FirstOrDefault();

            // TODO: ten zapis się powiela, zrobić klase do wyswietlania wszystkich autorow
            var allAuthors = (from a in context.Authors select new Author { AuthorId = a.AuthorId, FirstName = a.FirstName, LastName = a.LastName }).ToArray();
            ViewBag.Authors = allAuthors;

            return View(query);
        }

        public ActionResult SearchTemplate()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Search(string title)
        {
            if (title != null)
            {
                var query = from b in context.Books
                            where EF.Functions.Like(b.Title, "%" + title + "%")
                            orderby b.Title
                            select b;
                return Json(query);
            }
            var fullQuery = from b in context.Books orderby b.Title select b;
            return Json(fullQuery);
        }
    }
}