using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TestRest2.Models;

namespace TestRest2.Controllers
{
    public class SectionController : Controller
    {
        public string GetName()
        {
            return "Name";
        }

        public int GetNum()
        {
            return 4;
        }

        public Book GetBook()
        {
            Book book =new Book();
            return book;
        }
    }
}