Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for TestReport
''' </summary>
Public Class TestReport
	Inherits DevExpress.XtraReports.UI.XtraReport

	Private EvenStyle As XRControlStyle
	Private OddStyle As XRControlStyle
	Private HeaderStyle2 As XRControlStyle
	Private HeaderStyle1 As XRControlStyle
	Private jsonDataSource1 As DevExpress.DataAccess.Json.JsonDataSource
	Private TopMargin As TopMarginBand
	Private BottomMargin As BottomMarginBand
	Private pageInfo1 As XRPageInfo
	Private pageInfo2 As XRPageInfo
	Private ReportHeader As ReportHeaderBand
	Private label1 As XRLabel
	Private GroupHeader1 As GroupHeaderBand
	Private table1 As XRTable
	Private tableRow1 As XRTableRow
	Private tableCell1 As XRTableCell
	Private tableCell2 As XRTableCell
	Private GroupHeader2 As GroupHeaderBand
	Private table2 As XRTable
	Private tableRow2 As XRTableRow
	Private tableCell3 As XRTableCell
	Private tableCell4 As XRTableCell
	Private tableCell5 As XRTableCell
	Private tableCell6 As XRTableCell
	Private tableCell7 As XRTableCell
	Private tableCell8 As XRTableCell
	Private Detail As DetailBand
	Private table3 As XRTable
	Private tableRow3 As XRTableRow
	Private tableCell9 As XRTableCell
	Private tableCell10 As XRTableCell
	Private tableCell11 As XRTableCell
	Private tableCell12 As XRTableCell
	Private tableCell13 As XRTableCell
	Private tableCell14 As XRTableCell
	Private GroupFooter1 As GroupFooterBand
	Private label2 As XRLabel
	Private Title As XRControlStyle
	Private GroupCaption1 As XRControlStyle
	Private GroupData1 As XRControlStyle
	Private DetailCaption1 As XRControlStyle
	Private DetailData1 As XRControlStyle
	Private GroupFooterBackground3 As XRControlStyle
	Private DetailData3_Odd As XRControlStyle
	Private PageInfo As XRControlStyle

	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim uriJsonSource1 As New DevExpress.DataAccess.Json.UriJsonSource()
			Dim jsonSchemaNode1 As New DevExpress.DataAccess.Json.JsonSchemaNode("root", True)
			Dim jsonSchemaNode2 As New DevExpress.DataAccess.Json.JsonSchemaNode("Customers", True, DevExpress.DataAccess.Json.JsonNodeType.Array)
			Dim jsonSchemaNode3 As New DevExpress.DataAccess.Json.JsonSchemaNode("Id", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode4 As New DevExpress.DataAccess.Json.JsonSchemaNode("CompanyName", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode5 As New DevExpress.DataAccess.Json.JsonSchemaNode("ContactName", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode6 As New DevExpress.DataAccess.Json.JsonSchemaNode("ContactTitle", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode7 As New DevExpress.DataAccess.Json.JsonSchemaNode("Address", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode8 As New DevExpress.DataAccess.Json.JsonSchemaNode("City", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode9 As New DevExpress.DataAccess.Json.JsonSchemaNode("PostalCode", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode10 As New DevExpress.DataAccess.Json.JsonSchemaNode("Country", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode11 As New DevExpress.DataAccess.Json.JsonSchemaNode("Phone", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode12 As New DevExpress.DataAccess.Json.JsonSchemaNode("Fax", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Dim jsonSchemaNode13 As New DevExpress.DataAccess.Json.JsonSchemaNode("Region", True, DevExpress.DataAccess.Json.JsonNodeType.Property, GetType(String))
			Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.HeaderStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.HeaderStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.jsonDataSource1 = New DevExpress.DataAccess.Json.JsonDataSource(Me.components)
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.table1 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table2 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table3 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' EvenStyle
			' 
			Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(239)))), (CInt((CByte(243)))), (CInt((CByte(250)))))
			Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(199)))), (CInt((CByte(209)))), (CInt((CByte(228)))))
			Me.EvenStyle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.EvenStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.EvenStyle.Name = "EvenStyle"
			Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
			Me.EvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' OddStyle
			' 
			Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(199)))), (CInt((CByte(209)))), (CInt((CByte(228)))))
			Me.OddStyle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.OddStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.OddStyle.Name = "OddStyle"
			Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
			Me.OddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' HeaderStyle2
			' 
			Me.HeaderStyle2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(201)))), (CInt((CByte(214)))), (CInt((CByte(237)))))
			Me.HeaderStyle2.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(175)))), (CInt((CByte(190)))), (CInt((CByte(216)))))
			Me.HeaderStyle2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
			Me.HeaderStyle2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.HeaderStyle2.Name = "HeaderStyle2"
			Me.HeaderStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
			Me.HeaderStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' HeaderStyle1
			' 
			Me.HeaderStyle1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(201)))), (CInt((CByte(214)))), (CInt((CByte(237)))))
			Me.HeaderStyle1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(175)))), (CInt((CByte(190)))), (CInt((CByte(216)))))
			Me.HeaderStyle1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.HeaderStyle1.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold)
			Me.HeaderStyle1.Name = "HeaderStyle1"
			Me.HeaderStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.HeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' jsonDataSource1
			' 
			Me.jsonDataSource1.ConnectionName = "JsonConnection 1"
			uriJsonSource1.Uri = New System.Uri("https://raw.githubusercontent.com/DevExpress-Examples/DataSources/master/JSON/cus" & "tomers.json", System.UriKind.Absolute)
			Me.jsonDataSource1.JsonSource = uriJsonSource1
			Me.jsonDataSource1.Name = "jsonDataSource1"
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode3)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode4)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode5)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode6)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode7)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode8)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode9)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode10)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode11)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode12)
			jsonSchemaNode2.Nodes.Add(jsonSchemaNode13)
			jsonSchemaNode1.Nodes.Add(jsonSchemaNode2)
			Me.jsonDataSource1.Schema = jsonSchemaNode1
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pageInfo1, Me.pageInfo2})
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Country", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 27F
			Me.GroupHeader1.Level = 1
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table2})
			Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader2.HeightF = 28F
			Me.GroupHeader2.Level = 2
			Me.GroupHeader2.Name = "GroupHeader2"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table3})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label2})
			Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
			Me.GroupFooter1.HeightF = 6F
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' pageInfo1
			' 
			Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.pageInfo1.Name = "pageInfo1"
			Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.pageInfo1.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo1.StyleName = "PageInfo"
			' 
			' pageInfo2
			' 
			Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
			Me.pageInfo2.Name = "pageInfo2"
			Me.pageInfo2.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo2.StyleName = "PageInfo"
			Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.pageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' label1
			' 
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(650F, 24.19433F)
			Me.label1.StyleName = "Title"
			Me.label1.Text = "Customers"
			' 
			' table1
			' 
			Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
			Me.table1.Name = "table1"
			Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
			Me.table1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' tableRow1
			' 
			Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2})
			Me.tableRow1.Name = "tableRow1"
			Me.tableRow1.Weight = 1R
			' 
			' tableCell1
			' 
			Me.tableCell1.Name = "tableCell1"
			Me.tableCell1.StyleName = "GroupCaption1"
			Me.tableCell1.Text = "COUNTRY"
			Me.tableCell1.Weight = 0.099467444786658657R
			' 
			' tableCell2
			' 
			Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")})
			Me.tableCell2.Name = "tableCell2"
			Me.tableCell2.StyleName = "GroupData1"
			Me.tableCell2.Weight = 0.90053260216346154R
			' 
			' table2
			' 
			Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table2.Name = "table2"
			Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2})
			Me.table2.SizeF = New System.Drawing.SizeF(650F, 28F)
			' 
			' tableRow2
			' 
			Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8})
			Me.tableRow2.Name = "tableRow2"
			Me.tableRow2.Weight = 1R
			' 
			' tableCell3
			' 
			Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell3.Name = "tableCell3"
			Me.tableCell3.StyleName = "DetailCaption1"
			Me.tableCell3.StylePriority.UseBorders = False
			Me.tableCell3.Text = "Company Name"
			Me.tableCell3.Weight = 0.22312110314002404R
			' 
			' tableCell4
			' 
			Me.tableCell4.Name = "tableCell4"
			Me.tableCell4.StyleName = "DetailCaption1"
			Me.tableCell4.Text = "Contact Name"
			Me.tableCell4.Weight = 0.20194373497596155R
			' 
			' tableCell5
			' 
			Me.tableCell5.Name = "tableCell5"
			Me.tableCell5.StyleName = "DetailCaption1"
			Me.tableCell5.Text = "Contact Title"
			Me.tableCell5.Weight = 0.18498198289137621R
			' 
			' tableCell6
			' 
			Me.tableCell6.Name = "tableCell6"
			Me.tableCell6.StyleName = "DetailCaption1"
			Me.tableCell6.Text = "Address"
			Me.tableCell6.Weight = 0.13281962468073918R
			' 
			' tableCell7
			' 
			Me.tableCell7.Name = "tableCell7"
			Me.tableCell7.StyleName = "DetailCaption1"
			Me.tableCell7.Text = "City"
			Me.tableCell7.Weight = 0.079181829599233769R
			' 
			' tableCell8
			' 
			Me.tableCell8.Name = "tableCell8"
			Me.tableCell8.StyleName = "DetailCaption1"
			Me.tableCell8.Text = "Postal Code"
			Me.tableCell8.Weight = 0.17795177753155048R
			' 
			' table3
			' 
			Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table3.Name = "table3"
			Me.table3.OddStyleName = "DetailData3_Odd"
			Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow3})
			Me.table3.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' tableRow3
			' 
			Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14})
			Me.tableRow3.Name = "tableRow3"
			Me.tableRow3.Weight = 11.5R
			' 
			' tableCell9
			' 
			Me.tableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
			Me.tableCell9.Name = "tableCell9"
			Me.tableCell9.StyleName = "DetailData1"
			Me.tableCell9.StylePriority.UseBorders = False
			Me.tableCell9.Weight = 0.22312107966496395R
			' 
			' tableCell10
			' 
			Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")})
			Me.tableCell10.Name = "tableCell10"
			Me.tableCell10.StyleName = "DetailData1"
			Me.tableCell10.Weight = 0.20194373497596155R
			' 
			' tableCell11
			' 
			Me.tableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactTitle]")})
			Me.tableCell11.Name = "tableCell11"
			Me.tableCell11.StyleName = "DetailData1"
			Me.tableCell11.Weight = 0.18498197115384615R
			' 
			' tableCell12
			' 
			Me.tableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")})
			Me.tableCell12.Name = "tableCell12"
			Me.tableCell12.StyleName = "DetailData1"
			Me.tableCell12.Weight = 0.13281961294320913R
			' 
			' tableCell13
			' 
			Me.tableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[City]")})
			Me.tableCell13.Name = "tableCell13"
			Me.tableCell13.StyleName = "DetailData1"
			Me.tableCell13.Weight = 0.079181823730468753R
			' 
			' tableCell14
			' 
			Me.tableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PostalCode]")})
			Me.tableCell14.Name = "tableCell14"
			Me.tableCell14.StyleName = "DetailData1"
			Me.tableCell14.Weight = 0.17795175405649039R
			' 
			' label2
			' 
			Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.label2.Name = "label2"
			Me.label2.SizeF = New System.Drawing.SizeF(650F, 2.08F)
			Me.label2.StyleName = "GroupFooterBackground3"
			Me.label2.StylePriority.UseBorders = False
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Arial", 14.25F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' GroupCaption1
			' 
			Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.GroupCaption1.BorderColor = System.Drawing.Color.White
			Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupCaption1.BorderWidth = 2F
			Me.GroupCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupCaption1.Name = "GroupCaption1"
			Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupData1
			' 
			Me.GroupData1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.GroupData1.BorderColor = System.Drawing.Color.White
			Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupData1.BorderWidth = 2F
			Me.GroupData1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupData1.ForeColor = System.Drawing.Color.White
			Me.GroupData1.Name = "GroupData1"
			Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailCaption1
			' 
			Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.DetailCaption1.BorderColor = System.Drawing.Color.White
			Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailCaption1.BorderWidth = 2F
			Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption1.ForeColor = System.Drawing.Color.White
			Me.DetailCaption1.Name = "DetailCaption1"
			Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData1
			' 
			Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailData1.BorderWidth = 2F
			Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData1.ForeColor = System.Drawing.Color.Black
			Me.DetailData1.Name = "DetailData1"
			Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupFooterBackground3
			' 
			Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(131)))), (CInt((CByte(131)))), (CInt((CByte(131)))))
			Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
			Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupFooterBackground3.BorderWidth = 2F
			Me.GroupFooterBackground3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
			Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' TestReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.Detail, Me.GroupFooter1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.jsonDataSource1})
			Me.DataMember = "Customers"
			Me.DataSource = Me.jsonDataSource1
			Me.DisplayName = "Product List"
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.PageInfo})
			Me.Version = "21.2"
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub tableCell4_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
		TryCast(sender, XRTableCell).Text &= " Customized"
	End Sub

End Class
