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
    public class Authors : Controller
    {
        EFCoreWebDemoContext context = new EFCoreWebDemoContext();

        public ActionResult Show(int id)
        {
            var query = (from a in context.Authors
            join b in context.Books on a.AuthorId equals b.AuthorId
            where a.AuthorId == id
            orderby b.Title
            select new AuthorsBooksViewModel() 
            { 
                Authors = a, 
                Books = b
            }).ToList();

            var allAuthors = (from a in context.Authors select new Author {AuthorId = a.AuthorId, FirstName = a.FirstName, LastName = a.LastName }).ToArray();
            ViewBag.Authors = allAuthors;
            ViewBag.actualAuthorId = id;
            
            return View(query);
        }

    }
}