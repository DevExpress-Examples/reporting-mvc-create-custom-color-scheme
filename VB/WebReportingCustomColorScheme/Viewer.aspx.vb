Imports System
Imports System.Web.UI

Namespace WebReportingCustomColorScheme
    Partial Public Class Viewer
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxWebDocumentViewer1.OpenReport(New XtraReport1())
        End Sub
    End Class
End Namespace