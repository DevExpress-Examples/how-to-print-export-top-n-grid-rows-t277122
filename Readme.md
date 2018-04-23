# How to print / export top N grid rows


This example demonstrates how to display top N (10) rows in the grid print preview. The main point is to create a DevExpress.Xpf.Grid.TableView descendant, override the CreatePrintingDataTreeBuilder method to return a custom ItemsGenerationServerStrategy and select the required number of rows by overriding the FetchAllFilteredAndSortedRows method. In the example, the number of rows is set by the ItemsGenerationTop10RowsStrategy.SelectedRecordsNumber property.<br /><br />

<br/>


