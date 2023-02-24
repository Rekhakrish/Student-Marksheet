Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    ' DataGridView1.Visible = False

    Private Sub Btngetdata_Click(sender As Object, e As EventArgs)
        Dim StuRollno As Integer = TxtStuRollno.Text
        Dim firstname As String = TxtStuName.Text
        Dim lastname As String = TxtStulastname.Text
        Dim dob As Date = TxtStudob.Text
        Dim stuclass As Integer = Txtclass.Text
        Dim school As String = Txtschoolname.Text
        Dim fathername As String = TxtFathername.Text
        Dim Mothername As String = TxtMothername.Text


        'RichTextBox1.Text = (StuRollno.ToString() + "," + firstname.ToString() + "," + lastname.ToString() + "," + dob.ToString() + "," + stuclass.ToString() + "," + school.ToString() + "," +
        '    fathername.ToString() + "," + Mothername.ToString())

    End Sub

    Private Sub BtnGetgrade_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Btngetdata_Click_1(sender As Object, e As EventArgs) Handles Btngetdata.Click
        DataGridView1.Visible = True
        Dim con As SqlConnection = New SqlConnection("Data Source=NLTI155\SQLEXPRESS;Initial Catalog=StudentMarksheet;Integrated Security=True")
        Dim StuRollno As Integer = TxtStuRollno.Text
        Dim firstname As String = TxtStuName.Text
        Dim lastname As String = TxtStulastname.Text
        Dim dob As Date = TxtStudob.Text
        Dim stuclass As Integer = Txtclass.Text
        Dim school As String = Txtschoolname.Text
        Dim fathername As String = TxtFathername.Text
        Dim Mothername As String = TxtMothername.Text
        con.Open()
        Dim command As New SqlCommand("Insert into studentInfo(StudentRollNo,StudentFirstName,StudentLastName,DateofBirth,studentclass,schoolname,FatherName,MotherName)values('" & StuRollno & "','" & firstname & "','" & lastname & "','" & dob & "','" & stuclass & "','" & school & "','" & fathername & "','" & Mothername & "')", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted")

        LoadDataInGrid()

    End Sub

    Private Sub BtnGetgrade_Click_1(sender As Object, e As EventArgs) Handles BtnGetgrade.Click
        Form2.Show()
        Me.Hide()
        DataGridView1.Visible = False
    End Sub

    Private Sub LoadDataInGrid()
        DataGridView1.Visible = True
        Dim con As SqlConnection = New SqlConnection("Data Source=NLTI155\SQLEXPRESS;Initial Catalog=StudentMarksheet;Integrated Security=True")
        Dim command As New SqlCommand("select * from studentInfo", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
End Class
