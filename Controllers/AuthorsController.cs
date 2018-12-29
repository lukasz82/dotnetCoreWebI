using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetCoreMVC.Models;
using System.Collections;

using Microsoft.EntityFrameworkCore;

namespace dotnetCoreMVC.Controllers
{
    public class Authors : Controller
    {
        EFCoreWebDemoContext context = new EFCoreWebDemoContext();
        public ActionResult Show(int id)
        {
            var query = from a in context.Authors
            join b in context.Books on a.AuthorId equals b.AuthorId
            where a.AuthorId == id
            select new string[] { a.AuthorId.ToString(), a.FirstName, a.LastName, b.Title };

            var allAuthors = context.Authors.ToList();

           ViewBag.wynik = query;
           // ViewBag.yyy = allAuthors;
            
            return View(query);
        }
    }
}