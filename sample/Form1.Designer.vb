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
        components = New ComponentModel.Container()
        gtxt_username = New TextBox()
        gtxt_password = New TextBox()
        Label1 = New Label()
        password = New Label()
        gbtn_login = New Button()
        check_pass = New CheckBox()
        errorUsername = New ErrorProvider(components)
        errorPassword = New ErrorProvider(components)
        CType(errorUsername, ComponentModel.ISupportInitialize).BeginInit()
        CType(errorPassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gtxt_username
        ' 
        gtxt_username.Location = New Point(359, 191)
        gtxt_username.Name = "gtxt_username"
        gtxt_username.Size = New Size(100, 23)
        gtxt_username.TabIndex = 2
        ' 
        ' gtxt_password
        ' 
        gtxt_password.Location = New Point(359, 232)
        gtxt_password.Name = "gtxt_password"
        gtxt_password.Size = New Size(100, 23)
        gtxt_password.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(290, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 4
        Label1.Text = "username"
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Location = New Point(290, 240)
        password.Name = "password"
        password.Size = New Size(57, 15)
        password.TabIndex = 5
        password.Text = "password"
        ' 
        ' gbtn_login
        ' 
        gbtn_login.Location = New Point(368, 282)
        gbtn_login.Name = "gbtn_login"
        gbtn_login.Size = New Size(75, 23)
        gbtn_login.TabIndex = 6
        gbtn_login.Text = "gbtn_login"
        gbtn_login.UseVisualStyleBackColor = True
        ' 
        ' check_pass
        ' 
        check_pass.AutoSize = True
        check_pass.Location = New Point(477, 239)
        check_pass.Name = "check_pass"
        check_pass.Size = New Size(85, 19)
        check_pass.TabIndex = 7
        check_pass.Text = "check_pass"
        check_pass.UseVisualStyleBackColor = True
        ' 
        ' errorUsername
        ' 
        errorUsername.ContainerControl = Me
        ' 
        ' errorPassword
        ' 
        errorPassword.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(860, 450)
        Controls.Add(check_pass)
        Controls.Add(gbtn_login)
        Controls.Add(password)
        Controls.Add(Label1)
        Controls.Add(gtxt_password)
        Controls.Add(gtxt_username)
        Name = "Form1"
        Text = "Form1"
        CType(errorUsername, ComponentModel.ISupportInitialize).EndInit()
        CType(errorPassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gtxt_username As TextBox
    Friend WithEvents gtxt_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents password As Label
    Friend WithEvents gbtn_login As Button
    Friend WithEvents check_pass As CheckBox
    Friend WithEvents errorUsername As ErrorProvider
    Friend WithEvents errorPassword As ErrorProvider

End Class
