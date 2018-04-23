Imports System
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Media

Namespace WpfApplication
    Public Class BindingToColorConverter
        Inherits DependencyObject
        Implements IMultiValueConverter

        Private Function IMultiValueConverter_Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim cellsToHighlight As ObservableCollection(Of HighlightedGridCell) = TryCast(values(0), ObservableCollection(Of HighlightedGridCell))
            Dim row As Object = values(1)
            Dim column As Object = values(2)
            Return GetColorToHighlight(row, column, cellsToHighlight)
        End Function

        Private Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        Private Function GetColorToHighlight(ByVal row As Object, ByVal column As Object, ByVal cellsToHighlight As ObservableCollection(Of HighlightedGridCell)) As Object
            If row Is Nothing OrElse column Is Nothing OrElse cellsToHighlight Is Nothing Then
                Return Nothing
            End If
            For Each cell As HighlightedGridCell In cellsToHighlight
                If cell.Column Is column AndAlso cell.Row Is row Then
                    Return New SolidColorBrush(cell.Color)
                End If
            Next cell
            Return Nothing
        End Function
    End Class
End Namespace