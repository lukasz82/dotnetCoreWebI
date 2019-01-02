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
        public string Add (string title, int actualAuthorId)
        {
            string result = title + " " + actualAuthorId;
            var books = context.Set<Book>();
            books.Add(new Book{Title = title, AuthorId = actualAuthorId });

            try
            {
                context.SaveChanges();
                return "Wszystko jest ok, dodano do bazy " + result;
            }
            catch (Exception e)
            {
                result = "";
                return "cos poszlo nie tak" + e + result;
            }
        }

    }
}