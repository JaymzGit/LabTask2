Public Class Registration
    Private Sub ChangeColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColourToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Developed by: - " +
                        vbNewLine + "Name : James Khor Xuan Hao" +
                        vbNewLine + "Registration Number : 10DDT21F1032" +
                        vbNewLine + "Class : DDT5B", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim email As String
        email = InputBox("Please enter your email address", "Verify Account")
        lblName.Text = txtName.Text
        lblStudentID.Text = txtStudentID.Text
        lblDepartment.Text = ComboBox1.SelectedItem
        lblEmail.Text = email
        lblAge.Text = txtAge.Text
        lblAddress.Text = txtAddress.Text
        MessageBox.Show("The data has been successfully inserted. 
                        Please check the details section. 
                        Click the 'Upload' button to upload a photo.",
                        "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnUpload.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Photo.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtStudentID.Text = ""
        ComboBox1.SelectedItem = ""
        txtAge.Text = ""
        txtAddress.Text = ""

        lblName.Text = "__"
        lblStudentID.Text = "__"
        lblDepartment.Text = "__"
        lblEmail.Text = "__"
        lblAge.Text = "__"
        lblAddress.Text = "__"
        Photo.Image = Nothing
    End Sub
End Class