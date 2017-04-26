Public Class frmAdd

    Dim kunik As New connection
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtItemID.Text = "" Or txtItemName.Text = "" Or txtItemBrand.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Save data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                kunik.add("insert into tblknives values ('" & txtItemID.Text & "', '" & txtItemName.Text & "', '" & txtItemBrand.Text & "', '" & numQuantity.Text & "', '" & txtPrice.Text & "', 0)")
                frmMain.lvStorage.Items.Clear()
                kunik.getRecord(frmMain.lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives")
            End If
        End If
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtItemID.Clear()
        txtItemBrand.Clear()
        txtItemName.Clear()
        txtPrice.Clear()
        numQuantity.Value = 0
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lblStatus.Text = ""
        Else
            If e.KeyChar = "." Then
                e.Handled = False
                lblStatus.Text = ""
            Else
                e.Handled = True
                ' MessageBox.Show("Symbols or special characters are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lblStatus.Text = "Type numbers only!"
            End If
        End If
    End Sub

    Private Sub txtItemBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemBrand.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lblStatus.Text = ""
        Else
            If e.KeyChar = " " Or e.KeyChar = "-" Or e.KeyChar = "_" Or e.KeyChar = "@" Then
                e.Handled = False
                lblStatus.Text = ""
            Else
                e.Handled = True
                ' MessageBox.Show("Symbols or special characters are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lblStatus.Text = "Type letters or numbers only!"
            End If
        End If
    End Sub

    Private Sub txtItemName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemName.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lblStatus.Text = ""
        Else
            If e.KeyChar = " " Then
                e.Handled = False
                lblStatus.Text = ""
            Else
                e.Handled = True
                lblStatus.Text = "Type letters or numbers only!"
                ' MessageBox.Show("Symbols or special characters are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub txtItemID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemID.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lblStatus.Text = ""
        Else
            e.Handled = True
            ' MessageBox.Show("Symbols or special characters are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lblStatus.Text = "Type numbers only!"
        End If

    End Sub

 
    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        If txtItemName.Text <= Space(999) Then
            lblStatus.Text = "Invalid value for Item Name"
        End If
    End Sub

    Private Sub txtItemBrand_TextChanged(sender As Object, e As EventArgs) Handles txtItemBrand.TextChanged
        If txtItemBrand.Text <= Space(999) Then
            lblStatus.Text = "Invalid value for Item Name"
        End If
    End Sub
End Class