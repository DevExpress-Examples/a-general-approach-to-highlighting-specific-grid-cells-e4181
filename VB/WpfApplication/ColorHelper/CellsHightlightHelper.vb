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
Imports DevExpress.Xpf.Grid

Namespace WpfApplication
	Public NotInheritable Class CellsHightlightHelper

		Public Shared ReadOnly CellsToHighlightProperty As DependencyProperty = DependencyProperty.RegisterAttached("CellsToHighlight", GetType(ObservableCollection(Of HighlightedGridCell)), GetType(CellsHightlightHelper), Nothing)



		Private Sub New()
		End Sub
		Public Shared Function GetCellsToHighlight(ByVal target As DependencyObject) As ObservableCollection(Of HighlightedGridCell)
			Return CType(target.GetValue(CellsToHighlightProperty), ObservableCollection(Of HighlightedGridCell))
		End Function
		Public Shared Sub SetCellsToHighlight(ByVal target As GridControl, ByVal value As ObservableCollection(Of HighlightedGridCell))
			target.SetValue(CellsToHighlightProperty, value)
		End Sub



	End Class
End Namespace