Imports System.Windows
Imports System.Windows.Controls
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid

Namespace WpfApplication

    Public Module CellsHightlightHelper

        Public ReadOnly CellsToHighlightProperty As DependencyProperty = DependencyProperty.RegisterAttached("CellsToHighlight", GetType(ObservableCollection(Of HighlightedGridCell)), GetType(CellsHightlightHelper), Nothing)

        Public Function GetCellsToHighlight(ByVal target As DependencyObject) As ObservableCollection(Of HighlightedGridCell)
            Return CType(target.GetValue(CellsToHighlightProperty), ObservableCollection(Of HighlightedGridCell))
        End Function

        Public Sub SetCellsToHighlight(ByVal target As GridControl, ByVal value As ObservableCollection(Of HighlightedGridCell))
            target.SetValue(CellsToHighlightProperty, value)
        End Sub
    End Module
End Namespace
