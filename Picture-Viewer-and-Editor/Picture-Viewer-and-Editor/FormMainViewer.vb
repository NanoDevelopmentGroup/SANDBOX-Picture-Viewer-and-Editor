Imports System.IO

Public Class FormMainViewer

#Region "ButtonClicks"

    Private Sub Button_Open_Click(sender As Object, e As EventArgs) Handles Button_Open.Click

        Dim pictureFileDialog As New OpenFileDialog

        Dim debugPath As String = Directory.GetCurrentDirectory()
        Dim projectPath As String = Directory.GetParent(debugPath).Parent.FullName
        Dim totalPath As String = System.IO.Path.Combine(projectPath, "..\\TestingResources")

        With pictureFileDialog
            .InitialDirectory = System.IO.Path.GetFullPath(totalPath)
            .RestoreDirectory = True
            .Title = "Select an Image File"
        End With

        If pictureFileDialog.ShowDialog() = DialogResult.OK Then

        End If

    End Sub

#End Region

#Region "Helper Functions"



#End Region

End Class
