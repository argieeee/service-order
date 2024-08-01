Imports System.Data.SqlClient

Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Module Module1
    Public connection As New MySqlConnection ' variable mag gunit sa imong connection
    Public command As New MySqlCommand ' variable mag gunit sa mga sql command execution
    Public strConnection As String      'will hold the database credentials (ex userid, password)
    Public servername As String     'localhost
    Public databasename As String   'arsprintingpress
    Public databaseuserid As String 'Root
    Public databasepassword As String
    Public port As String               '3306
    Public studentPhotopath As String
    Public sqlAdapter As New MySqlDataAdapter
    Public datatbl As New DataTable
    Public action As String
    Public jobNum As String
    Public newNotifCount As Integer
    Public ID As Integer
    Public row As Integer
    Public dr As MySqlDataReader
    Public Cimage As New DataGridViewImageColumn
    Public ds As New DataSet
    Public Photo As String
    Public Stat As String
    Public imagePath As String
    Public storedImageName As String
    Public CC_id As Integer
    Public prevForm As New Form
End Module
