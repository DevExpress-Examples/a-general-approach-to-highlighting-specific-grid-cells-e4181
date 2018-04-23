Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace WpfApplication
	Public Class ViewModel

		Public Sub New()

		End Sub

		' Fields...
		Private _DataSource As Object


		Public Property DataSource() As Object
			Get
				If _DataSource Is Nothing Then
					_DataSource = DataHelper.GetDataSource(1020)
				End If
				Return _DataSource
			End Get
			Set(ByVal value As Object)
				_DataSource = value

			End Set
		End Property
	End Class
End Namespace
