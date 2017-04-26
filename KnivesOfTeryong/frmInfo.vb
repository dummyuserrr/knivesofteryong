Public Class frmInfo
    Dim kunik As New connection
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
                lblStatus.Text = "Type numbers only!"
                ' MessageBox.Show("Symbols or special characters are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                lblStatus.Text = "Type letter or numbers only!"
                ' MessageBox.Show("Symbols or special characters are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            lblStatus.Text = "Type numbers only!"
            ' MessageBox.Show("Symbols or special characters are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtItemID.Enabled = True
        txtItemName.Enabled = True
        txtItemBrand.Enabled = True
        numQuantity.Enabled = True
        txtPrice.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtItemID.Enabled = False
        txtItemName.Enabled = False
        txtItemBrand.Enabled = False
        numQuantity.Enabled = False
        txtPrice.Enabled = False
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        kunik.loadData("select * from tblknives where item_id = '" & frmMain.lv & "'")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            kunik.update("update tblknives set item_id = '" & txtItemID.Text & "',item_name = '" & txtItemName.Text & "',item_brand = '" & txtItemBrand.Text & "',quantity = '" & numQuantity.Text & "',price = '" & txtPrice.Text & "' where item_id = '" & frmMain.lv & "'")
            txtItemID.Enabled = False
            txtItemName.Enabled = False
            txtItemBrand.Enabled = False
            numQuantity.Enabled = False
            txtPrice.Enabled = False
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            kunik.loadData("select * from tblknives where item_id = '" & frmMain.lv & "'")
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