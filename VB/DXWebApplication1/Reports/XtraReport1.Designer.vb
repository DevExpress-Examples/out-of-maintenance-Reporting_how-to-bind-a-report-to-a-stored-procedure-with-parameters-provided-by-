Namespace DXWebApplication1.Reports
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

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
            Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim storedProcQuery1 As New DevExpress.DataAccess.Sql.StoredProcQuery()
            Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim queryParameter2 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.paramCategoryName = New DevExpress.XtraReports.Parameters.Parameter()
            Me.paramOrdYear = New DevExpress.XtraReports.Parameters.Parameter()
            Me.sqlDataSourceMainData = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.sqlDataSourceCategoryInfo = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("TotalPurchase", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' paramCategoryName
            ' 
            Me.paramCategoryName.Description = "CategoryName"
            dynamicListLookUpSettings1.DataAdapter = Nothing
            dynamicListLookUpSettings1.DataMember = "Categories"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSourceCategoryInfo
            dynamicListLookUpSettings1.DisplayMember = "CategoryName"
            dynamicListLookUpSettings1.FilterString = Nothing
            dynamicListLookUpSettings1.ValueMember = "CategoryName"
            Me.paramCategoryName.LookUpSettings = dynamicListLookUpSettings1
            Me.paramCategoryName.Name = "paramCategoryName"
            ' 
            ' paramOrdYear
            ' 
            Me.paramOrdYear.Description = "Order Year"
            Me.paramOrdYear.Name = "paramOrdYear"
            Me.paramOrdYear.Type = GetType(Integer)
            Me.paramOrdYear.ValueInfo = "1997"
            ' 
            ' sqlDataSourceMainData
            ' 
            Me.sqlDataSourceMainData.ConnectionName = "northwindConnection"
            Me.sqlDataSourceMainData.Name = "sqlDataSourceMainData"
            storedProcQuery1.Name = "SalesByCategory"
            queryParameter1.Name = "@CategoryName"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.paramCategoryName]", GetType(String))
            queryParameter2.Name = "@OrdYear"
            queryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.paramOrdYear]", GetType(String))
            storedProcQuery1.Parameters.Add(queryParameter1)
            storedProcQuery1.Parameters.Add(queryParameter2)
            storedProcQuery1.StoredProcName = "SalesByCategory"
            Me.sqlDataSourceMainData.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { storedProcQuery1})
            Me.sqlDataSourceMainData.ResultSchemaSerializable = resources.GetString("sqlDataSourceMainData.ResultSchemaSerializable")
            ' 
            ' sqlDataSourceCategoryInfo
            ' 
            Me.sqlDataSourceCategoryInfo.ConnectionName = "northwindConnection"
            Me.sqlDataSourceCategoryInfo.Name = "sqlDataSourceCategoryInfo"
            tableQuery1.Name = "Categories"
            tableInfo1.Name = "Categories"
            columnInfo1.Name = "CategoryName"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            Me.sqlDataSourceCategoryInfo.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSourceCategoryInfo.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZUNhdGVnb3J5SW5mbyI+PFZpZXcgTmFtZT0iQ2F0ZWdvc" & "mllcyI+PEZpZWxkIE5hbWU9IkNhdGVnb3J5TmFtZSIgVHlwZT0iU3RyaW5nIiAvPjwvVmlldz48L0Rhd" & "GFTZXQ+"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SalesByCategory.ProductName")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.22222222222222221R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SalesByCategory.TotalPurchase")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.22222222222222221R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
            Me.ReportHeader.HeightF = 53.83334F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.PageHeader.HeightF = 25F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Italic)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(335.4167F, 43.83334F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "Sales By Category"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable2.StylePriority.UseBackColor = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell3, Me.xrTableCell4})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 11.5R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "Product Name"
            Me.xrTableCell3.Weight = 0.22222222222222221R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "Total Purchase"
            Me.xrTableCell4.Weight = 0.22222222222222221R
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSourceMainData, Me.sqlDataSourceCategoryInfo})
            Me.DataMember = "SalesByCategory"
            Me.DataSource = Me.sqlDataSourceMainData
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramCategoryName, Me.paramOrdYear})
            Me.Version = "14.2"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private paramCategoryName As DevExpress.XtraReports.Parameters.Parameter
        Private paramOrdYear As DevExpress.XtraReports.Parameters.Parameter
        Private sqlDataSourceMainData As DevExpress.DataAccess.Sql.SqlDataSource
        Private sqlDataSourceCategoryInfo As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
