Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace DXWebApplication1.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

            Return View()
        End Function

        Private report As New DXWebApplication1.Reports.XtraReport1()

        Public Function DocumentViewerPartial() As ActionResult
            Return PartialView("_DocumentViewerPartial", report)
        End Function

        Public Function DocumentViewerPartialExport() As ActionResult
            Return DocumentViewerExtension.ExportTo(report, Request)
        End Function
    End Class
End Namespace
