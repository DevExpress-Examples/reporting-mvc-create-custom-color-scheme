Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.IO
Imports System.Web
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Routing

Imports DevExpress.Web.Mvc
Imports WebReportingCustomColorScheme.Services

Namespace WebReportingCustomColorScheme
	' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	' visit http://go.microsoft.com/?LinkId=9394801

	Public Class MvcApplication
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start()
			DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
			DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New ReportStorageWebExtension1(Server.MapPath("/Reports")))

			System.Net.ServicePointManager.SecurityProtocol = System.Net.ServicePointManager.SecurityProtocol Or System.Net.SecurityProtocolType.Tls12
			MVCxReportDesigner.StaticInitialize()

			AreaRegistration.RegisterAllAreas()

			GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
			RouteConfig.RegisterRoutes(RouteTable.Routes)

			ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()

			AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
		End Sub

		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
			Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
			'TODO: Handle Exception
		End Sub
	End Class
End Namespace
