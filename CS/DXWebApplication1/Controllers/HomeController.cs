using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View();
        }

        private DXWebApplication1.Reports.XtraReport1 report = new DXWebApplication1.Reports.XtraReport1();

        public ActionResult DocumentViewerPartial() {
            return PartialView("_DocumentViewerPartial", report);
        }

        public ActionResult DocumentViewerPartialExport() {
            return DocumentViewerExtension.ExportTo(report, Request);
        }
    }
}
