﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace WebReportingCustomColorScheme
	Public Class RouteConfig
		Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
			routes.IgnoreRoute("{resource}.ashx/{*pathInfo}")

			routes.MapRoute(name:= "Default", url:= "{controller}/{action}/{id}", defaults:= New With {
				Key .controller = "Home",
				Key .action = "Index",
				Key .id = UrlParameter.Optional
			})
		End Sub
	End Class
End Namespace