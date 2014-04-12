using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMSLITE.Repository;

namespace CMSLITE.Controllers
{
    public class AdminController : Controller
    {

        PagesDataContext ctxpag = new PagesDataContext();
   
        //
        // GET: /Admin/

        public ActionResult Index()
        {

            var page = ctxpag.Pages;
                         
            return View(page);
            
        }

        public ActionResult PageEditor()
        {
            var pageEditor = ctxpag.PageEditors;

            return PartialView("_PageEditor",pageEditor);
        }

    }
}
