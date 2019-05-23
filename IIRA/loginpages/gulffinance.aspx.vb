﻿
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web
Imports System.Web.Services
Partial Class loginpages_gulffinance
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Session("username") = "" Or Session("username") = Nothing Then

            Response.Redirect("../login.aspx")
            'Else
            '    lblname.Text = Session("username")
        End If
    End Sub

    Protected Sub btnlogout_Click(sender As Object, e As System.EventArgs) Handles btnlogout.Click
        If Page.IsPostBack = False Then

            Response.Redirect("../login.aspx")
            Session.Abandon()
            Session("username") = ""

        Else

            Session.Abandon()
            Session("username") = ""
            Response.Redirect("../login.aspx")
        End If
    End Sub


    Protected Sub LinkButton2_Click(sender As Object, e As System.EventArgs) Handles LinkButton2.Click
        If Session("username") = "" Or Session("username") = Nothing Then
            Response.Redirect("~/login.aspx")
        Else
            Dim URL As String = "https://s3-us-west-2.amazonaws.com/iirating/loginpages/Reports/FR-GFH-May'2017.pdf"
            Dim fileInfo As New FileInfo(Server.MapPath(URL))

            If fileInfo.Exists Then
                Response.Clear()
                Response.AddHeader("Content-Disposition", "attachment; filename =" + fileInfo.Name)
                Response.AddHeader("Content-Length", fileInfo.Length.ToString())
                Response.ContentType = "application/pdf"
                Response.Flush()
                Response.WriteFile(fileInfo.FullName)

            End If
        End If
    End Sub
Protected Sub LinkButton1_Click(sender As Object, e As System.EventArgs) Handles LinkButton1.Click
        If Session("username") = "" Or Session("username") = Nothing Then
            Response.Redirect("~/login.aspx")
        Else
            Dim URL As String = "https://s3-us-west-2.amazonaws.com/iirating/loginpages/Reports/FR-GFH'Sep'2014.pdf"
            Dim fileInfo As New FileInfo(Server.MapPath(URL))

            If fileInfo.Exists Then
                Response.Clear()
                Response.AddHeader("Content-Disposition", "attachment; filename =" + fileInfo.Name)
                Response.AddHeader("Content-Length", fileInfo.Length.ToString())
                Response.ContentType = "application/pdf"
                Response.Flush()
                Response.WriteFile(fileInfo.FullName)

            End If
        End If
    End Sub
Protected Sub LinkButton3_Click(sender As Object, e As System.EventArgs) Handles LinkButton3.Click
        If Session("username") = "" Or Session("username") = Nothing Then
            Response.Redirect("~/login.aspx")
        Else
            Dim URL As String = "https://s3-us-west-2.amazonaws.com/iirating/loginpages/Reports/FR-GFH-Dec'2018.pdf"
            Dim fileInfo As New FileInfo(Server.MapPath(URL))

            If fileInfo.Exists Then
                Response.Clear()
                Response.AddHeader("Content-Disposition", "attachment; filename =" + fileInfo.Name)
                Response.AddHeader("Content-Length", fileInfo.Length.ToString())
                Response.ContentType = "application/pdf"
                Response.Flush()
                Response.WriteFile(fileInfo.FullName)

            End If
        End If
    End Sub

    
End Class
