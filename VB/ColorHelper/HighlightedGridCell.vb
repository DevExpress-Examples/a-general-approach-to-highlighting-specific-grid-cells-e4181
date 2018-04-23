Imports System.Windows.Media
Imports DevExpress.Xpf.Grid

Namespace WpfApplication
    Public Class HighlightedGridCell
        ''' <summary>
        ''' Initializes a new instance of the HighlightedGridCell class.
        ''' </summary>
        ''' <param name="row"></param>
        ''' <param name="column"></param>
        ''' <param name="color"></param>
        Public Sub New(ByVal row As Object, ByVal column As GridColumn, ByVal color As Color)
            _Color = color
            _Row = row
            _Column = column
        End Sub

        ' Fields...
        Private _Color As Color
        Private _Row As Object
        Private _Column As GridColumn

        Public Property Column() As GridColumn
            Get
                Return _Column
            End Get
            Set(ByVal value As GridColumn)
                _Column = value

            End Set
        End Property

        Public Property Row() As Object
            Get
                Return _Row
            End Get
            Set(ByVal value As Object)
                _Row = value
            End Set
        End Property

        Public Property Color() As Color
            Get
                Return _Color
            End Get
            Set(ByVal value As Color)
                _Color = value

            End Set
        End Property
    End Class
End Namespace
