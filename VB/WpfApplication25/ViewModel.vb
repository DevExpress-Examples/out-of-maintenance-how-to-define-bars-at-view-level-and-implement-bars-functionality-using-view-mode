Imports DevExpress.Mvvm

Namespace WpfApplication25

    Public Class ViewModel

        Public Overridable Property Text As String

        Public Overridable ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return Nothing
            End Get
        End Property

        Public Sub ShowText()
            MessageBoxService.ShowMessage(Text)
        End Sub
    End Class
End Namespace
