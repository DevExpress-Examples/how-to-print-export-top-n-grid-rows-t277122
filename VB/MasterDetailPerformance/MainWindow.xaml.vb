Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Grid
Imports DevExpress.DocumentView
Imports System.Windows.Data
Imports System.Windows
Imports System.Collections.Generic
Imports System

Namespace MasterDetailPerformance


    Partial Public Class MainWindow
        Public Property Data() As List(Of Entitiy)
        Public Sub New()
            Me.InitializeComponent()
            InitData()
        End Sub
        Private Sub InitData()
            Me.Data = New List(Of Entitiy)()
            For i As Integer = 0 To 999
                Me.Data.Add(New Entitiy With {.ID = i, .Name = "Test Name #" & i.ToString()})
            Next i
            Me.DataContext = Me
        End Sub
        Private Sub PreviewButton_OnClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.PreviewDocument()
        End Sub

        Private Sub PreviewDocument()
            Dim linkModel = New LinkPreviewModel(New PrintableControlLink(DirectCast(Me.GridControl.View, IPrintableControl)))
            linkModel.Link.CreateDocument(True)
            Me.DocumentPreview.Model = linkModel
        End Sub
    End Class
End Namespace