Imports System.Collections.ObjectModel

Namespace WpfApplication

    Public Class DataHelper

        Public Shared Function GetDataSource(ByVal count As Integer) As Object
            Dim collection As ObservableCollection(Of GridItem) = New ObservableCollection(Of GridItem)()
            For i As Integer = 0 To count - 1
                collection.Add(New GridItem(Date.Now.AddMinutes(count * i).AddDays((i - count \ 2) * count), String.Format("Name{0}", i), 0))
            Next

            Return collection
        End Function
    End Class

    Public Class GridItem

        ''' <summary>
        ''' Initializes a new instance of the GridItem class.
        ''' </summary>
        ''' <param name="date"></param>
        ''' <param name="name"></param>
        ''' <param name="iD"></param>
        Public Sub New(ByVal [date] As Date, ByVal name As String, ByVal iD As Integer)
            _Date = [date]
            _Name = name
            _ID = iD
        End Sub

        Public Sub New()
        End Sub

        ' Fields...
        Private _Date As Date

        Private _Name As String

        Public Property Name As String
            Get
                Return _Name
            End Get

            Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        ' Fields...
        Private _ID As Integer

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Public Property [Date] As Date
            Get
                Return _Date
            End Get

            Set(ByVal value As Date)
                _Date = value
            End Set
        End Property
    End Class
End Namespace
