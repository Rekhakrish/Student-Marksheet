<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        LblStudentno = New Label()
        LblStuName = New Label()
        LblStulastname = New Label()
        LblStudentdob = New Label()
        Lblclass = New Label()
        LblFfatherName = New Label()
        LblMothername = New Label()
        Lblschoolname = New Label()
        TxtStuRollno = New TextBox()
        TxtStuName = New TextBox()
        TxtStulastname = New TextBox()
        TxtStudob = New TextBox()
        Txtclass = New TextBox()
        TxtFathername = New TextBox()
        TxtMothername = New TextBox()
        Txtschoolname = New TextBox()
        Btngetdata = New Button()
        BtnGetgrade = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.PaleTurquoise
        Label1.Location = New Point(329, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 15)
        Label1.TabIndex = 0
        Label1.Text = "Student Information"' 
        ' LblStudentno
        ' 
        LblStudentno.AutoSize = True
        LblStudentno.BackColor = Color.PaleTurquoise
        LblStudentno.Location = New Point(71, 64)
        LblStudentno.Name = "LblStudentno"
        LblStudentno.Size = New Size(87, 15)
        LblStudentno.TabIndex = 1
        LblStudentno.Text = "Student RollNo"' 
        ' LblStuName
        ' 
        LblStuName.AutoSize = True
        LblStuName.BackColor = Color.PaleTurquoise
        LblStuName.Location = New Point(71, 110)
        LblStuName.Name = "LblStuName"
        LblStuName.Size = New Size(108, 15)
        LblStuName.TabIndex = 2
        LblStuName.Text = "Student First Name"' 
        ' LblStulastname
        ' 
        LblStulastname.AutoSize = True
        LblStulastname.BackColor = Color.PaleTurquoise
        LblStulastname.Location = New Point(71, 158)
        LblStulastname.Name = "LblStulastname"
        LblStulastname.Size = New Size(107, 15)
        LblStulastname.TabIndex = 3
        LblStulastname.Text = "Student Last Name"' 
        ' LblStudentdob
        ' 
        LblStudentdob.AutoSize = True
        LblStudentdob.BackColor = Color.PaleTurquoise
        LblStudentdob.Location = New Point(71, 205)
        LblStudentdob.Name = "LblStudentdob"
        LblStudentdob.Size = New Size(75, 15)
        LblStudentdob.TabIndex = 4
        LblStudentdob.Text = "Date Of Birth"' 
        ' Lblclass
        ' 
        Lblclass.AutoSize = True
        Lblclass.BackColor = Color.PaleTurquoise
        Lblclass.Location = New Point(439, 56)
        Lblclass.Name = "Lblclass"
        Lblclass.Size = New Size(34, 15)
        Lblclass.TabIndex = 5
        Lblclass.Text = "Class"' 
        ' LblFfatherName
        ' 
        LblFfatherName.AutoSize = True
        LblFfatherName.BackColor = Color.PaleTurquoise
        LblFfatherName.Location = New Point(439, 150)
        LblFfatherName.Name = "LblFfatherName"
        LblFfatherName.Size = New Size(83, 15)
        LblFfatherName.TabIndex = 6
        LblFfatherName.Text = "Father's Name"' 
        ' LblMothername
        ' 
        LblMothername.AutoSize = True
        LblMothername.BackColor = Color.PaleTurquoise
        LblMothername.Location = New Point(439, 197)
        LblMothername.Name = "LblMothername"
        LblMothername.Size = New Size(89, 15)
        LblMothername.TabIndex = 7
        LblMothername.Text = "Mother's Name"' 
        ' Lblschoolname
        ' 
        Lblschoolname.AutoSize = True
        Lblschoolname.BackColor = Color.PaleTurquoise
        Lblschoolname.Location = New Point(439, 102)
        Lblschoolname.Name = "Lblschoolname"
        Lblschoolname.Size = New Size(78, 15)
        Lblschoolname.TabIndex = 8
        Lblschoolname.Text = "School Name"' 
        ' TxtStuRollno
        ' 
        TxtStuRollno.Location = New Point(228, 56)
        TxtStuRollno.Name = "TxtStuRollno"
        TxtStuRollno.Size = New Size(100, 23)
        TxtStuRollno.TabIndex = 9
        ' 
        ' TxtStuName
        ' 
        TxtStuName.Location = New Point(228, 102)
        TxtStuName.Name = "TxtStuName"
        TxtStuName.Size = New Size(100, 23)
        TxtStuName.TabIndex = 10
        ' 
        ' TxtStulastname
        ' 
        TxtStulastname.Location = New Point(228, 150)
        TxtStulastname.Name = "TxtStulastname"
        TxtStulastname.Size = New Size(100, 23)
        TxtStulastname.TabIndex = 11
        ' 
        ' TxtStudob
        ' 
        TxtStudob.Location = New Point(228, 197)
        TxtStudob.Name = "TxtStudob"
        TxtStudob.Size = New Size(100, 23)
        TxtStudob.TabIndex = 12
        ' 
        ' Txtclass
        ' 
        Txtclass.Location = New Point(562, 48)
        Txtclass.Name = "Txtclass"
        Txtclass.Size = New Size(100, 23)
        Txtclass.TabIndex = 13
        ' 
        ' TxtFathername
        ' 
        TxtFathername.Location = New Point(562, 147)
        TxtFathername.Name = "TxtFathername"
        TxtFathername.Size = New Size(100, 23)
        TxtFathername.TabIndex = 14
        ' 
        ' TxtMothername
        ' 
        TxtMothername.Location = New Point(562, 189)
        TxtMothername.Name = "TxtMothername"
        TxtMothername.Size = New Size(100, 23)
        TxtMothername.TabIndex = 15
        ' 
        ' Txtschoolname
        ' 
        Txtschoolname.Location = New Point(562, 94)
        Txtschoolname.Name = "Txtschoolname"
        Txtschoolname.Size = New Size(100, 23)
        Txtschoolname.TabIndex = 16
        ' 
        ' Btngetdata
        ' 
        Btngetdata.BackColor = Color.MediumTurquoise
        Btngetdata.Location = New Point(219, 250)
        Btngetdata.Name = "Btngetdata"
        Btngetdata.Size = New Size(124, 37)
        Btngetdata.TabIndex = 17
        Btngetdata.Text = "Add Information"
        Btngetdata.UseVisualStyleBackColor = False
        ' 
        ' BtnGetgrade
        ' 
        BtnGetgrade.BackColor = Color.MediumTurquoise
        BtnGetgrade.Location = New Point(405, 250)
        BtnGetgrade.Name = "BtnGetgrade"
        BtnGetgrade.Size = New Size(132, 37)
        BtnGetgrade.TabIndex = 18
        BtnGetgrade.Text = "Get Grade "
        BtnGetgrade.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(98, 320)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(542, 117)
        DataGridView1.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 462)
        Controls.Add(DataGridView1)
        Controls.Add(BtnGetgrade)
        Controls.Add(Btngetdata)
        Controls.Add(Txtschoolname)
        Controls.Add(TxtMothername)
        Controls.Add(TxtFathername)
        Controls.Add(Txtclass)
        Controls.Add(TxtStudob)
        Controls.Add(TxtStulastname)
        Controls.Add(TxtStuName)
        Controls.Add(TxtStuRollno)
        Controls.Add(Lblschoolname)
        Controls.Add(LblMothername)
        Controls.Add(LblFfatherName)
        Controls.Add(Lblclass)
        Controls.Add(LblStudentdob)
        Controls.Add(LblStulastname)
        Controls.Add(LblStuName)
        Controls.Add(LblStudentno)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblStudentno As Label
    Friend WithEvents LblStuName As Label
    Friend WithEvents LblStulastname As Label
    Friend WithEvents LblStudentdob As Label
    Friend WithEvents Lblclass As Label
    Friend WithEvents LblFfatherName As Label
    Friend WithEvents LblMothername As Label
    Friend WithEvents Lblschoolname As Label
    Friend WithEvents TxtStuRollno As TextBox
    Friend WithEvents TxtStuName As TextBox
    Friend WithEvents TxtStulastname As TextBox
    Friend WithEvents TxtStudob As TextBox
    Friend WithEvents Txtclass As TextBox
    Friend WithEvents TxtFathername As TextBox
    Friend WithEvents TxtMothername As TextBox
    Friend WithEvents Txtschoolname As TextBox
    Friend WithEvents Btngetdata As Button
    Friend WithEvents BtnGetgrade As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
