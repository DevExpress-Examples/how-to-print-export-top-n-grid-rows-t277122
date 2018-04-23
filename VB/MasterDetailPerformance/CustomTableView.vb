Imports System.Collections
Imports System.Linq
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Grid.Printing

Namespace MasterDetailPerformance
    Public Class CustomTableView
        Inherits TableView

        Protected Overrides Function CreatePrintingDataTreeBuilder(ByVal totalHeaderWidth As Double, ByVal itemsGenerationStrategy As ItemsGenerationStrategyBase, ByVal masterDetailPrintInfo As MasterDetailPrintInfo, ByVal bandsLayout As BandsLayoutBase) As PrintingDataTreeBuilderBase
            Return MyBase.CreatePrintingDataTreeBuilder(totalHeaderWidth, New ItemsGenerationTop10RowsStrategy(ViewInfo.GridView), masterDetailPrintInfo, bandsLayout)
        End Function
    End Class
    Public Class ItemsGenerationTop10RowsStrategy
        Inherits ItemsGenerationServerStrategy

        Public Sub New(ByVal view As DataViewBase)
            MyBase.New(view)
        End Sub
        Public Overrides ReadOnly Property RequireFullExpand() As Boolean
            Get
                Return True
            End Get
        End Property

        Private _SelectedRecordsNumber As Integer = 10

        Public Property SelectedRecordsNumber() As Integer
            Get
                Return _SelectedRecordsNumber
            End Get
            Set(ByVal value As Integer)
                _SelectedRecordsNumber = value
            End Set
        End Property
        Protected Overrides Function FetchAllFilteredAndSortedRows() As IList
            Return DirectCast(View.DataControl.ItemsSource, IEnumerable).Cast(Of Object)().Take(SelectedRecordsNumber).ToList()
        End Function

        Protected Overrides Function GetAllFilteredAndSortedRows() As IList
            Return FetchAllFilteredAndSortedRows()
        End Function
    End Class
End Namespace
