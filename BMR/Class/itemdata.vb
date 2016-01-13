Public Class itemdata
    Public Value As Object
    Public Description As String
    Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
        Value = NewValue
        Description = NewDescription
    End Sub
    Public Overrides Function ToString() As String
        Return Description
    End Function
End Class
Public Module Necessary
    Public Function ReturnItem(ByVal Cmb As ComboBox) As Object
        If Cmb.SelectedIndex = -1 Then
            Return Nothing
        End If
        Return Cmb.SelectedItem.Value
    End Function
End Module
