Public Class ListBox

    Private Sub lstalpha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstalpha.SelectedIndexChanged
        Dim i As Integer
        lstname.ClearSelected()
        For i = 0 To lstname.Items.Count - 1
            If lstname.Items.Item(i).ToString().StartsWith(lstalpha.SelectedItem.ToString()) = True Then
                lstname.SetSelected(i, True)
            End If
            lblmsg.Text = "Total number of selected Items: " & lstname.SelectedItems.Count
        Next
    End Sub


   
End Class
