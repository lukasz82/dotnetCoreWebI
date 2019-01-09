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
using System.Dynamic;
using Microsoft.AspNetCore.Routing;

using Microsoft.EntityFrameworkCore;

namespace dotnetCoreMVC.Controllers
{
    
    public class ArrayTest : Controller
    {
        EFCoreWebDemoContext context = new EFCoreWebDemoContext();

        [HttpGet]
        public JsonResult ReturnJsonTest(int id)
        {

            var query = from a in context.Authors
            join b in context.Books on a.AuthorId equals b.AuthorId
            where a.AuthorId == id
            select new
            {
                AuthorId = a.AuthorId.ToString(), 
                FirstName = a.FirstName, 
                LastName = a.LastName, 
                Title = b.Title 
            };
            return Json(query);
        }

        public ActionResult Show()
        {
            return View();
        }
        
    }
}