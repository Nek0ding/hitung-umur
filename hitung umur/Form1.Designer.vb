<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        btn_ok = New Button()
        btn_cancel = New Button()
        input_tanggal = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 64)
        Label1.TabIndex = 0
        Label1.Text = "Masukkan tanggal lahir anda" & vbCrLf & "format:dd/mm/yyyy" & vbCrLf
        ' 
        ' btn_ok
        ' 
        btn_ok.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ok.Location = New Point(664, 57)
        btn_ok.Name = "btn_ok"
        btn_ok.Size = New Size(124, 44)
        btn_ok.TabIndex = 1
        btn_ok.Text = "OK"
        btn_ok.UseVisualStyleBackColor = True
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_cancel.Location = New Point(664, 129)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(124, 40)
        btn_cancel.TabIndex = 2
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' input_tanggal
        ' 
        input_tanggal.Location = New Point(25, 329)
        input_tanggal.Multiline = True
        input_tanggal.Name = "input_tanggal"
        input_tanggal.Size = New Size(746, 64)
        input_tanggal.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(input_tanggal)
        Controls.Add(btn_cancel)
        Controls.Add(btn_ok)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents input_tanggal As TextBox

End Class
