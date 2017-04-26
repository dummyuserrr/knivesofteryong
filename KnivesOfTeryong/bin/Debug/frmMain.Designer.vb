<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnStorage = New System.Windows.Forms.Button()
        Me.pnlStorage = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvStorage = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlArchive = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArchiveSearch = New System.Windows.Forms.TextBox()
        Me.lvArchive = New System.Windows.Forms.ListView()
        Me.pnlOptions.SuspendLayout()
        Me.pnlStorage.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.pnlArchive.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOptions
        '
        Me.pnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlOptions.Controls.Add(Me.btnExit)
        Me.pnlOptions.Controls.Add(Me.btnArchive)
        Me.pnlOptions.Controls.Add(Me.btnStorage)
        Me.pnlOptions.Location = New System.Drawing.Point(-1, 152)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(713, 53)
        Me.pnlOptions.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(475, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(236, 53)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnArchive
        '
        Me.btnArchive.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchive.ForeColor = System.Drawing.Color.White
        Me.btnArchive.Location = New System.Drawing.Point(238, 0)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(237, 53)
        Me.btnArchive.TabIndex = 1
        Me.btnArchive.Text = "Archive"
        Me.btnArchive.UseVisualStyleBackColor = False
        '
        'btnStorage
        '
        Me.btnStorage.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStorage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStorage.ForeColor = System.Drawing.Color.White
        Me.btnStorage.Location = New System.Drawing.Point(1, 0)
        Me.btnStorage.Name = "btnStorage"
        Me.btnStorage.Size = New System.Drawing.Size(237, 53)
        Me.btnStorage.TabIndex = 0
        Me.btnStorage.Text = "Storage"
        Me.btnStorage.UseVisualStyleBackColor = False
        '
        'pnlStorage
        '
        Me.pnlStorage.BackColor = System.Drawing.Color.Transparent
        Me.pnlStorage.Controls.Add(Me.Label3)
        Me.pnlStorage.Controls.Add(Me.Label1)
        Me.pnlStorage.Controls.Add(Me.txtSearch)
        Me.pnlStorage.Controls.Add(Me.lvStorage)
        Me.pnlStorage.Location = New System.Drawing.Point(0, 204)
        Me.pnlStorage.Name = "pnlStorage"
        Me.pnlStorage.Size = New System.Drawing.Size(713, 416)
        Me.pnlStorage.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(495, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Right-click listview to view options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(98, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(323, 29)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = "Type Item ID or Item Name"
        '
        'lvStorage
        '
        Me.lvStorage.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvStorage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvStorage.Location = New System.Drawing.Point(12, 47)
        Me.lvStorage.Name = "lvStorage"
        Me.lvStorage.Size = New System.Drawing.Size(686, 357)
        Me.lvStorage.TabIndex = 0
        Me.lvStorage.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AddNewItemToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 92)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem.Text = "&View Details"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'AddNewItemToolStripMenuItem
        '
        Me.AddNewItemToolStripMenuItem.Name = "AddNewItemToolStripMenuItem"
        Me.AddNewItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddNewItemToolStripMenuItem.Text = "&Add New Item"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem.Text = "R&efresh"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDetailsToolStripMenuItem, Me.RefreshToolStripMenuItem1, Me.RestoreToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(138, 70)
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ViewDetailsToolStripMenuItem.Text = "&View Details"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.RefreshToolStripMenuItem1.Text = "R&efresh"
        '
        'RestoreToolStripMenuItem1
        '
        Me.RestoreToolStripMenuItem1.Name = "RestoreToolStripMenuItem1"
        Me.RestoreToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.RestoreToolStripMenuItem1.Text = "&Restore"
        '
        'pnlArchive
        '
        Me.pnlArchive.BackColor = System.Drawing.Color.Transparent
        Me.pnlArchive.Controls.Add(Me.Label4)
        Me.pnlArchive.Controls.Add(Me.Label2)
        Me.pnlArchive.Controls.Add(Me.txtArchiveSearch)
        Me.pnlArchive.Controls.Add(Me.lvArchive)
        Me.pnlArchive.Location = New System.Drawing.Point(0, 204)
        Me.pnlArchive.Name = "pnlArchive"
        Me.pnlArchive.Size = New System.Drawing.Size(713, 416)
        Me.pnlArchive.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(495, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Right-click listview to view options"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search:"
        '
        'txtArchiveSearch
        '
        Me.txtArchiveSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchiveSearch.Location = New System.Drawing.Point(98, 10)
        Me.txtArchiveSearch.Name = "txtArchiveSearch"
        Me.txtArchiveSearch.Size = New System.Drawing.Size(323, 29)
        Me.txtArchiveSearch.TabIndex = 4
        Me.txtArchiveSearch.Text = "Type Item ID or Item Name"
        '
        'lvArchive
        '
        Me.lvArchive.ContextMenuStrip = Me.ContextMenuStrip2
        Me.lvArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lvArchive.Location = New System.Drawing.Point(12, 47)
        Me.lvArchive.Name = "lvArchive"
        Me.lvArchive.Size = New System.Drawing.Size(686, 357)
        Me.lvArchive.TabIndex = 3
        Me.lvArchive.UseCompatibleStateImageBehavior = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.KnivesOfTeryong.My.Resources.Resources.bgbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 621)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.pnlStorage)
        Me.Controls.Add(Me.pnlArchive)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Knives Of Teryong"
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlStorage.ResumeLayout(False)
        Me.pnlStorage.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.pnlArchive.ResumeLayout(False)
        Me.pnlArchive.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    '=========================================STAAAAAARTTTTT!!!!!!!!==============================
    Dim kunik As connection = New connection
    Public lv As String
    Public sorting As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kunik.connect()
        btnStorage.BackColor = Color.MidnightBlue
        pnlStorage.BringToFront()
        'load lvstorage columns
        With lvStorage
            .View = View.Details
            .GridLines = True
            .AllowColumnReorder = False
            .FullRowSelect = True
            .MultiSelect = False
            '.Sorting = SortOrder.None
            .Columns.Add("Item ID", 150)
            .Columns.Add("Name", 150)
            .Columns.Add("Brand", 150)
            .Columns.Add("Quantity", 90)
            .Columns.Add("Price", 150)
        End With
        'load lvarchive columns
        With lvArchive
            .View = View.Details
            .GridLines = True
            .AllowColumnReorder = False
            .FullRowSelect = True
            .MultiSelect = False
            '.Sorting = SortOrder.None
            .Columns.Add("Item ID", 150)
            .Columns.Add("Name", 150)
            .Columns.Add("Brand", 150)
            .Columns.Add("Quantity", 90)
            .Columns.Add("Price", 150)
        End With
        lvStorage.Items.Clear()
        kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0")
        lvArchive.Items.Clear()
        kunik.loadarchives(lvArchive, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 1")
    End Sub

    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnArchive As System.Windows.Forms.Button
    Friend WithEvents btnStorage As System.Windows.Forms.Button
    Friend WithEvents pnlStorage As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lvStorage As System.Windows.Forms.ListView
    Friend WithEvents pnlArchive As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtArchiveSearch As System.Windows.Forms.TextBox
    Friend WithEvents lvArchive As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lvStorage.Items.Clear()
        kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where item_id like '%" & txtSearch.Text & "%' and isarchived = 0 or item_name like '%" & txtSearch.Text & "%' and isarchived = 0")
    End Sub


    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        For Each selected As ListViewItem In lvStorage.SelectedItems
            lv = selected.Text
        Next
        kunik.loadData("select * from tblknives where item_id = '" & lv & "'")
        frmInfo.ShowDialog()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If lvStorage.SelectedItems.Count <> 0 Then
            ViewToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
            AddNewItemToolStripMenuItem.Enabled = True
            RefreshToolStripMenuItem.Enabled = True
        Else
            ViewToolStripMenuItem.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
            AddNewItemToolStripMenuItem.Enabled = True
            RefreshToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub AddNewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewItemToolStripMenuItem.Click
        For Each selected As ListViewItem In lvStorage.SelectedItems
            lv = selected.Text
        Next
        frmAdd.ShowDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        txtSearch.Clear()
        lvStorage.Items.Clear()
        kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnArchive.BackColor = Color.CornflowerBlue
        btnStorage.BackColor = Color.CornflowerBlue
        btnExit.BackColor = Color.MidnightBlue
        If MessageBox.Show("Close application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
        btnArchive.BackColor = Color.CornflowerBlue
        btnStorage.BackColor = Color.MidnightBlue
        btnExit.BackColor = Color.CornflowerBlue
        pnlStorage.BringToFront()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        For Each selected As ListViewItem In lvStorage.SelectedItems
            lv = selected.Text
        Next
        If MessageBox.Show("Delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            kunik.delete("update tblknives set isarchived = 1 where item_id = '" & lv & "'")
            lvStorage.Items.Clear()
            kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0")
            lvArchive.Items.Clear()
            kunik.loadarchives(lvArchive, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 1")
        End If
    End Sub

    Private Sub btnStorage_Click(sender As Object, e As EventArgs) Handles btnStorage.Click
        pnlStorage.BringToFront()
        btnArchive.BackColor = Color.CornflowerBlue
        btnStorage.BackColor = Color.MidnightBlue
        btnExit.BackColor = Color.CornflowerBlue
        txtArchiveSearch.Text = "Type Item ID or Item Name"
        lvArchive.Items.Clear()
        kunik.loadarchives(lvArchive, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 1")

    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        pnlArchive.BringToFront()
        btnArchive.BackColor = Color.MidnightBlue
        btnStorage.BackColor = Color.CornflowerBlue
        btnExit.BackColor = Color.CornflowerBlue
        txtSearch.Text = "Type Item ID or Item Name"
        lvStorage.Items.Clear()
        kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0")

    End Sub
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        If lvArchive.SelectedItems.Count > 0 Then
            ViewDetailsToolStripMenuItem.Enabled = True
            RefreshToolStripMenuItem.Enabled = True
            RestoreToolStripMenuItem1.Enabled = True
        Else
            ViewDetailsToolStripMenuItem.Enabled = False
            RefreshToolStripMenuItem.Enabled = True
            RestoreToolStripMenuItem1.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem1.Click
        lvArchive.Items.Clear()
        kunik.loadarchives(lvArchive, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 1")
    End Sub

    Private Sub txtArchiveSearch_TextChanged(sender As Object, e As EventArgs) Handles txtArchiveSearch.TextChanged
        lvArchive.Items.Clear()
        kunik.loadarchives(lvArchive, "select item_id, item_name, item_brand, quantity, price from tblknives where item_id like '%" & txtArchiveSearch.Text & "%' and isarchived = 1 or item_name like '%" & txtArchiveSearch.Text & "%' and isarchived = 1")
    End Sub

    Private Sub RestoreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem1.Click
        For Each selected As ListViewItem In lvArchive.SelectedItems
            lv = selected.Text
        Next
        If MessageBox.Show("Restore this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            kunik.restore("update tblknives set isarchived = 0 where item_id = '" & lv & "'")
            lvStorage.Items.Clear()
            kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0")
            lvArchive.Items.Clear()
            kunik.loadarchives(lvArchive, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 1")

        End If
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        For Each selected As ListViewItem In lvArchive.SelectedItems
            lv = selected.Text
        Next
        kunik.loadArchivedData("select * from tblknives where item_id = '" & lv & "'")
        frmArchivedInfo.ShowDialog()
    End Sub

    Private Sub txtArchiveSearch_Click(sender As Object, e As EventArgs) Handles txtArchiveSearch.Click
        If txtArchiveSearch.Text = "Type Item ID or Item Name" Then
            txtArchiveSearch.Clear()
        End If

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        If txtSearch.Text = "Type Item ID or Item Name" Then
            txtSearch.Clear()
        End If
    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

    Private Sub lvStorage_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvStorage.ColumnClick
        If e.Column = 0 Then
            sorting = "item_id"
            lvStorage.Items.Clear()
            kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0 order by '" & sorting.ToString & "' asc")
            ' MessageBox.Show(sorting)
        ElseIf e.Column = 1 Then
            sorting = "item_name"
            lvStorage.Items.Clear()
            kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0 order by '" & sorting.ToString & "' asc")
            ' MessageBox.Show(sorting)
        ElseIf e.Column = 2 Then
            sorting = "item_brand"
            lvStorage.Items.Clear()
            kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0 order by '" & sorting.ToString & "' asc")
        ElseIf e.Column = 3 Then
            sorting = "quantity"
            lvStorage.Items.Clear()
            kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0 order by '" & sorting.ToString & "' asc")
        ElseIf e.Column = 4 Then
            sorting = "price"
            lvStorage.Items.Clear()
            kunik.getRecord(lvStorage, "select item_id, item_name, item_brand, quantity, price from tblknives where isarchived = 0 order by '" & sorting.ToString & "' asc")
        End If
    End Sub
End Class
