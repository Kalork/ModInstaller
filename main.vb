﻿Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Public Class main

    Public Version As String = "0.0.0"

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim p As New Process 'Verification si déjà lancé
        Try
            If UBound(Diagnostics.Process.GetProcessesByName("ModInstaller")) < 1 Then

            Else
                MsgBox("Le logiciel est deja lancé", MsgBoxStyle.Critical)
                End
            End If
        Catch err As Exception
            MsgBox("Erreur : " & err.ToString)
        End Try

        Try 'Verification version
            My.Computer.Network.DownloadFile("http://kalork.no-ip.org/Softs/ModInstaller/VersionI", "VersionI")
            Dim VersionInternetTemp As New System.IO.StreamReader("VersionI")
            Dim VersionInternet As String
            VersionInternet = VersionInternetTemp.ReadLine
            VersionInternetTemp.Close()
            Kill("VersionI")

            If Version <> VersionInternet Then
                MsgBox("Mise à jour disponible ! Elle va être téléchargée.", MsgBoxStyle.Information)
                'UPDATER A FAIRE
                End
            End If

        Catch ex As Exception
            MsgBox("Impossible de vérifier les mise à jour : " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BT_openOFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_openOFD.Click

        Dim selectedFile As String = String.Empty

        OFD_src.ShowDialog()
        selectedFile = OFD_src.FileName
        If selectedFile IsNot Nothing Then
            TB_src.Text = selectedFile
        End If

    End Sub

    Private Sub BT_Install_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Install.Click

        ' A FAIRE

    End Sub

End Class
