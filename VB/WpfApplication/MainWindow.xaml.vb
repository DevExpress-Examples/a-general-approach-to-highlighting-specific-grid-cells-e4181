Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Markup
Imports System.Collections.ObjectModel

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