Module Module1
    Public Function seterr(ByVal control As Control, ByVal Msg As String)
        FrmMain.C1SuperErrorProvider1.Dispose()
        FrmMain.C1SuperTooltip1.RemoveAll()
        FrmMain.C1SuperErrorProvider1.SetError(control, Msg)
        FrmMain.C1SuperTooltip1.SetToolTip(control, Msg)
        FrmMain.C1SuperTooltip1.IsBalloon = True
    End Function
    
End Module
