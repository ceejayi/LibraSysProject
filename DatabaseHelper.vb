Imports System.Data.SqlClient

Public Class DatabaseHelper
    ' Centralized connection string to the hosted DB
    Public Shared connStr As String = "workstation id=Loyalty_FeedbackDB.mssql.somee.com;packet size=4096;user id=bea1121_SQLLogin_1;pwd=owhb99h6m4;data source=Loyalty_FeedbackDB.mssql.somee.com;persist security info=False;initial catalog=Loyalty_FeedbackDB;TrustServerCertificate=True"

    ' Your company ID for LibraSys
    Public Shared CompanyID As Integer = 6 ' LibraSys
End Class
