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
        btnClose = New Button()
        btnCheckGrade = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtMarks = New TextBox()
        txtGrade = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(346, 379)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnCheckGrade
        ' 
        btnCheckGrade.Location = New Point(346, 324)
        btnCheckGrade.Name = "btnCheckGrade"
        btnCheckGrade.Size = New Size(94, 29)
        btnCheckGrade.TabIndex = 0
        btnCheckGrade.Text = "Check Grade"
        btnCheckGrade.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(206, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter your marks"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(206, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 1
        Label2.Text = "Your Grade is"
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(390, 140)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(125, 27)
        txtMarks.TabIndex = 2
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(390, 203)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(125, 27)
        txtGrade.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(240, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(303, 36)
        Label3.TabIndex = 1
        Label3.Text = "Grade Generator"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtGrade)
        Controls.Add(txtMarks)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnCheckGrade)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Grade Generator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnCheckGrade As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents Label3 As Label
End Class
