Imports System.Data.SqlClient

Public Class Form2



    Private Sub BtnResult_Click_1(sender As Object, e As EventArgs)
        Dim engmark As Integer = Txtengmark.Text
        Dim tammark As Integer = Txttamilmark.Text
        Dim matmark As Integer = Txtmathsmark.Text
        Dim scimark As Integer = Txtsciencemark.Text
        Dim socmark As Integer = Txtsocialmark.Text



        If engmark >= 90 Then
            txtenggrade.Text = "A"
        ElseIf engmark < 90 And engmark >= 70 Then
            txtenggrade.Text = "B"
        ElseIf engmark < 70 And engmark >= 50 Then
            txtenggrade.Text = "C"
        Else
            txtenggrade.Text = "D"
        End If

        If tammark >= 90 Then
            Txttamgrade.Text = "A"
        ElseIf tammark < 90 And tammark >= 70 Then
            Txttamgrade.Text = "B"
        ElseIf tammark < 70 And tammark >= 50 Then
            Txttamgrade.Text = "C"
        Else
            Txttamgrade.Text = "D"
        End If

        If matmark >= 90 Then
            Txtmathsgrade.Text = "A"
        ElseIf matmark < 90 And matmark >= 70 Then
            Txtmathsgrade.Text = "B"
        ElseIf matmark < 70 And matmark >= 50 Then
            Txtmathsgrade.Text = "C"
        Else
            Txtmathsgrade.Text = "D"
        End If

        If scimark >= 90 Then
            Txtscigrade.Text = "A"
        ElseIf scimark < 90 And scimark >= 70 Then
            Txtscigrade.Text = "B"
        ElseIf scimark < 70 And scimark >= 50 Then
            Txtscigrade.Text = "C"
        Else
            Txtscigrade.Text = "D"
        End If

        If socmark >= 90 Then
            Txtsocgrade.Text = "A"
        ElseIf socmark < 90 And socmark >= 70 Then
            Txtsocgrade.Text = "B"
        ElseIf socmark < 70 And socmark >= 50 Then
            Txtsocgrade.Text = "C"
        Else
            Txtsocgrade.Text = "D"
        End If

        Txtengper.Text = engmark / 100
        Txttamper.Text = tammark / 100
        Txtmatper.Text = matmark / 100
        Txtsciper.Text = scimark / 100
        Txtsocper.Text = socmark / 100
    End Sub

    Private Sub Txtengmark_TextChanged_1(sender As Object, e As EventArgs)
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If


    End Sub

    Private Sub Txttamilmark_TextChanged_1(sender As Object, e As EventArgs)
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If

    End Sub

    Private Sub Txtmathsmark_TextChanged_1(sender As Object, e As EventArgs)
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If

    End Sub

    Private Sub Txtsciencemark_TextChanged_1(sender As Object, e As EventArgs)
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If

    End Sub

    Private Sub Txtsocialmark_TextChanged_1(sender As Object, e As EventArgs)
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If

    End Sub

    Private Sub BtnResult_Click_2(sender As Object, e As EventArgs) Handles BtnResult.Click
        DataGridView1.Visible = True
        Dim con As SqlConnection = New SqlConnection("Data Source=NLTI155\SQLEXPRESS;Initial Catalog=StudentMarksheet;Integrated Security=True")
        Dim engmark As Integer = Txtengmark.Text
        Dim tammark As Integer = Txttamilmark.Text
        Dim matmark As Integer = Txtmathsmark.Text
        Dim scimark As Integer = Txtsciencemark.Text
        Dim socmark As Integer = Txtsocialmark.Text
        Dim totalmark As Integer = Txttotalmark.Text
        Dim totalper As Integer = Txtoverallper.Text
        Dim totalgrade As String = txtoverallgrade.Text
        Dim sturollnoM As Integer = Txtstumarksroll.Text

        If engmark >= 90 Then
            txtenggrade.Text = "A"
        ElseIf engmark < 90 And engmark >= 70 Then
            txtenggrade.Text = "B"
        ElseIf engmark < 70 And engmark >= 50 Then
            txtenggrade.Text = "C"
        Else
            txtenggrade.Text = "D"
        End If

        If tammark >= 90 Then
            Txttamgrade.Text = "A"
        ElseIf tammark < 90 And tammark >= 70 Then
            Txttamgrade.Text = "B"
        ElseIf tammark < 70 And tammark >= 50 Then
            Txttamgrade.Text = "C"
        Else
            Txttamgrade.Text = "D"
        End If

        If matmark >= 90 Then
            Txtmathsgrade.Text = "A"
        ElseIf matmark < 90 And matmark >= 70 Then
            Txtmathsgrade.Text = "B"
        ElseIf matmark < 70 And matmark >= 50 Then
            Txtmathsgrade.Text = "C"
        Else
            Txtmathsgrade.Text = "D"
        End If

        If scimark >= 90 Then
            Txtscigrade.Text = "A"
        ElseIf scimark < 90 And scimark >= 70 Then
            Txtscigrade.Text = "B"
        ElseIf scimark < 70 And scimark >= 50 Then
            Txtscigrade.Text = "C"
        Else
            Txtscigrade.Text = "D"
        End If

        If socmark >= 90 Then
            Txtsocgrade.Text = "A"
        ElseIf socmark < 90 And socmark >= 70 Then
            Txtsocgrade.Text = "B"
        ElseIf socmark < 70 And socmark >= 50 Then
            Txtsocgrade.Text = "C"
        Else
            Txtsocgrade.Text = "D"
        End If

        Txtengper.Text = engmark / 100
        Txttamper.Text = tammark / 100
        Txtmatper.Text = matmark / 100
        Txtsciper.Text = scimark / 100
        Txtsocper.Text = socmark / 100
        con.Open()
        Dim command As New SqlCommand("Insert into StudentMarks(StudentRollNo,English,Tamil,Mathematics,Science,social,Totalmark,OverallPercentage,overallgrade)values('" & sturollnoM & "','" & engmark & "','" & tammark & "','" & matmark & "','" & scimark & "','" & socmark & "','" & totalmark & "','" & totalper & "','" & totalgrade & "')", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted")

        LoadDataInGrid()

    End Sub

    Private Sub Txtengmark_TextChanged_2(sender As Object, e As EventArgs) Handles Txtengmark.TextChanged
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If
    End Sub

    Private Sub Txttamilmark_TextChanged_2(sender As Object, e As EventArgs) Handles Txttamilmark.TextChanged
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If
    End Sub

    Private Sub Txtmathsmark_TextChanged_2(sender As Object, e As EventArgs) Handles Txtmathsmark.TextChanged
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If
    End Sub

    Private Sub Txtsciencemark_TextChanged_2(sender As Object, e As EventArgs) Handles Txtsciencemark.TextChanged
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If
    End Sub

    Private Sub Txtsocialmark_TextChanged_2(sender As Object, e As EventArgs) Handles Txtsocialmark.TextChanged
        Dim engmark As Integer = 0
        Dim tammark As Integer = 0
        Dim matmark As Integer = 0
        Dim scimark As Integer = 0
        Dim socmark As Integer = 0

        Integer.TryParse(Txtengmark.Text, engmark)
        Integer.TryParse(Txttamilmark.Text, tammark)
        Integer.TryParse(Txtmathsmark.Text, matmark)
        Integer.TryParse(Txtsciencemark.Text, scimark)
        Integer.TryParse(Txtsocialmark.Text, socmark)

        Txttotalmark.Text = engmark + tammark + matmark + scimark + socmark
        Txtoverallper.Text = (engmark + tammark + matmark + scimark + socmark) / 5
        If Txtoverallper.Text >= 90 Then
            txtoverallgrade.Text = "A"
        ElseIf Txtoverallper.Text < 90 And Txtoverallper.Text >= 70 Then
            txtoverallgrade.Text = "B"
        ElseIf Txtoverallper.Text < 70 And Txtoverallper.Text >= 50 Then
            txtoverallgrade.Text = "c"
        Else
            txtoverallgrade.Text = "D"
        End If

    End Sub
    Private Sub LoadDataInGrid()
        DataGridView1.Visible = True
        Dim con As SqlConnection = New SqlConnection("Data Source=NLTI155\SQLEXPRESS;Initial Catalog=StudentMarksheet;Integrated Security=True")
        Dim command As New SqlCommand("select * from StudentMarks", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
