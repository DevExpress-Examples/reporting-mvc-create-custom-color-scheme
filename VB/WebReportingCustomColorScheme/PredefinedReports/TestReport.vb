Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel

''' <summary>
''' Summary description for TestReport
''' </summary>
Public Class TestReport
	Inherits DevExpress.XtraReports.UI.XtraReport

	Private ReportHeader As ReportHeaderBand
	Private xrLabel2 As XRLabel
	Private GroupHeader1 As GroupHeaderBand
	Private xrTable2 As XRTable
	Private lbCategory As XRLabel
	Private xrTableRow2 As XRTableRow
	Private xrTableCell1 As XRTableCell
	Private Detail As DetailBand
	Private xrTable1 As XRTable
	Private xrTableRow1 As XRTableRow
	Private xrTableCell4 As XRTableCell
	Private xrTableCell5 As XRTableCell
	Private xrTableCell6 As XRTableCell
	Private xrTableCell2 As XRTableCell
	Private xrTableCell3 As XRTableCell
	Private BottomMargin As BottomMarginBand
	Private xrPageInfo1 As XRPageInfo
	Private topMarginBand1 As TopMarginBand
	Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
	Private EvenStyle As XRControlStyle
	Private OddStyle As XRControlStyle
	Private HeaderStyle2 As XRControlStyle
	Private HeaderStyle1 As XRControlStyle

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
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TestReport))
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.lbCategory = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.HeaderStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.HeaderStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.ReportHeader.HeightF = 67F
			Me.ReportHeader.Name = "ReportHeader"
			Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2, Me.lbCategory})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 75F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.GroupHeader1.RepeatEveryPage = True
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.HeightF = 27F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.BottomMargin.HeightF = 85F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 21.75F)
			Me.xrLabel2.ForeColor = System.Drawing.Color.Black
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(21F, 2F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(608F, 64F)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.Text = "Product List by Category"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTable2
			' 
			Me.xrTable2.BookmarkParent = Me.lbCategory
			Me.xrTable2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[ProductName]")})
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(21F, 48F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(608F, 27F)
			Me.xrTable2.StyleName = "HeaderStyle2"
			' 
			' lbCategory
			' 
			Me.lbCategory.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {
				New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]"),
				New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoryName]")
			})
			Me.lbCategory.InteractiveSorting.FieldName = "CategoryID"
			Me.lbCategory.InteractiveSorting.TargetBand = Me.GroupHeader1
			Me.lbCategory.LocationFloat = New DevExpress.Utils.PointFloat(21F, 8F)
			Me.lbCategory.Name = "lbCategory"
			Me.lbCategory.SizeF = New System.Drawing.SizeF(608F, 32F)
			Me.lbCategory.StyleName = "HeaderStyle1"
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow2.EvenStyleName = "EvenStyle"
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.OddStyleName = "OddStyle"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.InteractiveSorting.FieldName = "ProductName"
			Me.xrTableCell1.InteractiveSorting.TargetBand = Me.Detail
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Product Name"
			Me.xrTableCell1.Weight = 0.34539473684210525R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "Quantity Per Unit"
			Me.xrTableCell2.Weight = 0.48848684210526316R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.InteractiveSorting.FieldName = "UnitPrice"
			Me.xrTableCell3.InteractiveSorting.TargetBand = Me.Detail
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "Unit Price"
			Me.xrTableCell3.Weight = 0.16611842105263158R
			' 
			' xrTable1
			' 
			Me.xrTable1.BookmarkParent = Me.lbCategory
			Me.xrTable1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[ProductName]")})
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(21F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(608F, 27F)
			Me.xrTable1.StylePriority.UseBorders = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow1.EvenStyleName = "EvenStyle"
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.OddStyleName = "OddStyle"
			Me.xrTableRow1.StyleName = "EvenStyle"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.Weight = 0.34539473684210525R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityPerUnit]")})
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.Weight = 0.48848684210526316R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F)
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell6.TextFormatString = "{0:$0.00}"
			Me.xrTableCell6.Weight = 0.16611842105263158R
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(534F, 7F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
			Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrPageInfo1.TextFormatString = "Page : {0} / {1}"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryName"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""134"" />"
			table1.Name = "Categories"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""267"" />"
			table2.Name = "Products"
			columnExpression2.Table = table2
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "QuantityPerUnit"
			columnExpression3.Table = table2
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "UnitPrice"
			columnExpression4.Table = table2
			column4.Expression = columnExpression4
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Name = "ProductsByCategories"
			relationColumnInfo1.NestedKeyColumn = "CategoryID"
			relationColumnInfo1.ParentKeyColumn = "CategoryID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			selectQuery1.Relations.Add(join1)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
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
			' TestReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.BottomMargin, Me.topMarginBand1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "ProductsByCategories"
			Me.DataSource = Me.sqlDataSource1
			Me.DisplayName = "Product List"
			Me.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 85)
			Me.PageWidth = 740
			Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.EvenStyle, Me.OddStyle, Me.HeaderStyle2, Me.HeaderStyle1})
			Me.StyleSheetPath = ""
			Me.Version = "19.2"
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub tableCell4_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
		TryCast(sender, XRTableCell).Text &= " Customized"
	End Sub

End Class