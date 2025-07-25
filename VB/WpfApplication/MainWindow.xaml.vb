Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Collections.ObjectModel

Namespace WpfApplication

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim cellsToHiglight As ObservableCollection(Of HighlightedGridCell) = New ObservableCollection(Of HighlightedGridCell)()
            cellsToHiglight.Add(New HighlightedGridCell(Me.gridControl1.GetRow(0), Me.gridControl1.Columns("ID"), Colors.Red))
            CellsHightlightHelper.SetCellsToHighlight(Me.gridControl1, cellsToHiglight)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim cellsToHiglight As ObservableCollection(Of HighlightedGridCell) = New ObservableCollection(Of HighlightedGridCell)()
            cellsToHiglight.Add(New HighlightedGridCell(Me.gridControl1.GetRow(1), Me.gridControl1.Columns("Name"), Colors.Yellow))
            cellsToHiglight.Add(New HighlightedGridCell(Me.gridControl1.GetRow(1), Me.gridControl1.Columns("Date"), Colors.Orange))
            CellsHightlightHelper.SetCellsToHighlight(Me.gridControl1, cellsToHiglight)
        End Sub
    End Class
End Namespace
