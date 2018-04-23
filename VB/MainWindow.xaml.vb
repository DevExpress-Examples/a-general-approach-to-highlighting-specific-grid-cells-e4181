Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Media

Namespace WpfApplication
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window
        Public Sub New()
            InitializeComponent()
            Dim cellsToHiglight As New ObservableCollection(Of HighlightedGridCell)()
            cellsToHiglight.Add(New HighlightedGridCell(gridControl1.GetRow(0), gridControl1.Columns("ID"), Colors.Red))
            CellsHightlightHelper.SetCellsToHighlight(gridControl1, cellsToHiglight)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim cellsToHiglight As New ObservableCollection(Of HighlightedGridCell)()
            cellsToHiglight.Add(New HighlightedGridCell(gridControl1.GetRow(1), gridControl1.Columns("Name"), Colors.Yellow))
            cellsToHiglight.Add(New HighlightedGridCell(gridControl1.GetRow(1), gridControl1.Columns("Date"), Colors.Orange))
            CellsHightlightHelper.SetCellsToHighlight(gridControl1, cellsToHiglight)
        End Sub
    End Class
End Namespace