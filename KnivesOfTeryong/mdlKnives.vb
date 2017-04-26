Imports MySql.Data.MySqlClient

Module mdlKnives
    Public Class connection
        Public conn As MySqlConnection = New MySqlConnection
        Public cnstring As String = "server=localhost; uid=hudjin; pwd=pogiako; database=dbteryongknives;"
        Public flag As Integer = 0

        Public Sub connect()
            Try
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    conn.ConnectionString = cnstring
                    conn.Open()
                    'MessageBox.Show("Done")
                Else
                    conn.ConnectionString = cnstring
                    conn.Open()
                    'MessageBox.Show("Done")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub login(ByVal qry As String)
            Try
                connect()
                Dim comm As MySqlCommand
                Dim reader As MySqlDataReader

                comm = New MySqlCommand(qry, conn)
                reader = comm.ExecuteReader	

                While reader.Read
                    flag = flag + 1
                End While
                If flag >= 1 Then
                    'MessageBox.Show("Done")
                    frmLogin.Hide()
                    frmMain.Show()
                Else
                    MessageBox.Show("Wrong Username or Password. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                frmLogin.txtUsername.Focus()
            End Try
        End Sub

        Public Sub getRecord(ByRef lvrecord As ListView, ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Dim reader As MySqlDataReader
            Dim itemlist As ListViewItem
            Dim strvalue As String

            'lvrecord.Refresh()
            Try
                comm = New MySqlCommand(qry, conn)
                reader = comm.ExecuteReader
                Do While reader.Read
                    itemlist = New ListViewItem("", 0)
                    strvalue = IIf(reader.IsDBNull(0), "0", reader.GetValue(0))
                    itemlist.Text = strvalue
                    For rcd = 1 To reader.FieldCount - 1
                        If reader.IsDBNull(rcd) Then
                            itemlist.SubItems.Add("")
                        Else
                            itemlist.SubItems.Add(reader.GetValue(rcd))
                        End If
                    Next
                    lvrecord.Items.Add(itemlist)
                Loop

            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub loadarchives(ByRef lvrecord As ListView, ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Dim reader As MySqlDataReader
            Dim strvalue As String
            Dim itemlist As ListViewItem
            'lvrecord.Refresh()
            Try
                comm = New MySqlCommand(qry, conn)
                reader = comm.ExecuteReader
                Do While reader.Read
                    itemlist = New ListViewItem("", 0)
                    strvalue = IIf(reader.IsDBNull(0), "", reader.GetValue(0))
                    itemlist.Text = strvalue
                    For rcd = 1 To reader.FieldCount - 1
                        If reader.IsDBNull(rcd) Then
                            itemlist.SubItems.Add("")
                        Else
                            itemlist.SubItems.Add(reader.GetValue(rcd))
                        End If
                    Next
                    lvrecord.Items.Add(itemlist)
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub add(ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Try
                comm = New MySqlCommand(qry, conn)
                comm.ExecuteNonQuery()
                MessageBox.Show("Data has been added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub loadData(ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Dim reader As MySqlDataReader
            Try
                comm = New MySqlCommand(qry, conn)
                reader = comm.ExecuteReader

                While reader.Read
                    frmInfo.txtItemID.Text = reader.GetString("item_id")
                    frmInfo.txtItemName.Text = reader.GetString("item_name")
                    frmInfo.txtItemBrand.Text = reader.GetString("item_brand")
                    frmInfo.numQuantity.Text = reader.GetString("quantity")
                    frmInfo.txtPrice.Text = reader.GetString("price")
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub loadArchivedData(ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Dim reader As MySqlDataReader
            Try
                comm = New MySqlCommand(qry, conn)
                reader = comm.ExecuteReader

                While reader.Read
                    frmArchivedInfo.txtItemID.Text = reader.GetString("item_id")
                    frmArchivedInfo.txtItemName.Text = reader.GetString("item_name")
                    frmArchivedInfo.txtItemBrand.Text = reader.GetString("item_brand")
                    frmArchivedInfo.numQuantity.Text = reader.GetString("quantity")
                    frmArchivedInfo.txtPrice.Text = reader.GetString("price")
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub delete(ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Try
                comm = New MySqlCommand(qry, conn)
                comm.ExecuteNonQuery()
                MessageBox.Show("Item data has been deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub restore(ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Try
                comm = New MySqlCommand(qry, conn)
                comm.ExecuteNonQuery()
                MessageBox.Show("Item has been restored", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub update(ByVal qry As String)
            connect()
            Dim comm As MySqlCommand
            Try
                comm = New MySqlCommand(qry, conn)
                comm.ExecuteNonQuery()
                MessageBox.Show("Data has been updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.lvStorage.Items.Clear()
                getRecord(frmMain.lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives")
                frmInfo.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

    End Class
End Module
