Imports System.Collections.ObjectModel
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace WpfApplication
    Public NotInheritable Class CellsHightlightHelper
        Public Shared ReadOnly CellsToHighlightProperty As DependencyProperty = DependencyProperty.RegisterAttached("CellsToHighlight", GetType(ObservableCollection(Of HighlightedGridCell)), GetType(CellsHightlightHelper), Nothing)

        Public Shared Function GetCellsToHighlight(ByVal target As DependencyObject) As ObservableCollection(Of HighlightedGridCell)
            Return CType(target.GetValue(CellsToHighlightProperty), ObservableCollection(Of HighlightedGridCell))
        End Function
        Public Shared Sub SetCellsToHighlight(ByVal target As GridControl, ByVal value As ObservableCollection(Of HighlightedGridCell))
            target.SetValue(CellsToHighlightProperty, value)
        End Sub
    End Class
End Namespace