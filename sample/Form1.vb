Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Parameters

Public Class Form1
    Dim attempt As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles gbtn_login.Click
        If (gtxt_username.Text = String.Empty) Then
            MsgBox("Please enter your username")
        ElseIf (gtxt_password.Text = String.Empty) Then
            MsgBox("Please enter your password")
        Else
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prc_netwklogin"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_username", gtxt_username.Text)
                    .Parameters.AddWithValue("@p_password", gtxt_password.Text)

                    sqlAdapter = New MySqlDataAdapter
                    datatbl = New DataTable
                    sqlAdapter.SelectCommand = command
                    sqlAdapter.Fill(datatbl)

                    If datatbl.Rows.Count > 0 Then
                        Me.Hide()
                        CC_id = datatbl.Rows(0).Item("netwkid")
                        networkingdashboard.ShowDialog()
                        Me.Dispose()
                    ElseIf attempt = 3 Then
                        MsgBox("Maximum number of attempts (3), program will now close")
                        Me.Dispose()
                    Else
                        MsgBox("Password and username does not match, Please re-enter, You currently have reached attempt " & attempt & " of 3.")
                        attempt = attempt + 1

                    End If

                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub check_pass_CheckedChanged(sender As Object, e As EventArgs) Handles check_pass.CheckedChanged
        Dim passwordHolder As String
        passwordHolder = gtxt_password.Text.ToString
        If check_pass.Checked = True Then
            gtxt_password.PasswordChar = ""
        Else
            gtxt_password.PasswordChar = "*"
        End If

    End Sub

    Private Sub txt_username_Leave(sender As Object, e As EventArgs) Handles gtxt_username.Leave
        If gtxt_username.Text = String.Empty Then
            gtxt_username.Focus()
            errorUsername.SetError(gtxt_username, "This field can't be empty")
        Else
            errorUsername.Clear()
        End If
    End Sub

    Private Sub txt_password_Leave(sender As Object, e As EventArgs) Handles gtxt_password.Leave
        If gtxt_password.Text = String.Empty Then
            gtxt_password.Focus()
            errorPassword.SetError(gtxt_password, "This field can't be empty")
        Else
            errorPassword.Clear()
        End If
    End Sub
End Class
