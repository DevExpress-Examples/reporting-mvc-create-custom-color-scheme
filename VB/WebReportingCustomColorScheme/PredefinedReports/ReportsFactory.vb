Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

Namespace WebReportingCustomColorScheme.PredefinedReports
	Public Module ReportsFactory
		Sub New()
			Reports.Add("TestReport", Function() New TestReport())
		End Sub
		Public Reports As New Dictionary(Of String, Func(Of XtraReport))()
	End Module
End Namespace