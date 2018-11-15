<!-- default file list -->
*Files to look at*:

* [CustomTableView.cs](./CS/MasterDetailPerformance/CustomTableView.cs) (VB: [CustomTableView.vb](./VB/MasterDetailPerformance/CustomTableView.vb))
* [Entitiy.cs](./CS/MasterDetailPerformance/DemoData/Entitiy.cs) (VB: [Entitiy.vb](./VB/MasterDetailPerformance/DemoData/Entitiy.vb))
* [MainWindow.xaml](./CS/MasterDetailPerformance/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/MasterDetailPerformance/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/MasterDetailPerformance/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MasterDetailPerformance/MainWindow.xaml.vb))
<!-- default file list end -->
# How to print / export top N grid rows


This example demonstrates how to display top N (10) rows in the grid print preview. The main point is to create a DevExpress.Xpf.Grid.TableView descendant, override the CreatePrintingDataTreeBuilder method to return a custom ItemsGenerationServerStrategy and select the required number of rows by overriding the FetchAllFilteredAndSortedRows method. In the example, the number of rows is set by the ItemsGenerationTop10RowsStrategy.SelectedRecordsNumber property.<br /><br />

<br/>


