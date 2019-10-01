Imports System.IO

Public Class FormMainViewer

    Private CurrentImage As Bitmap

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
            Display_Image(pictureFileDialog.FileName)
        End If

    End Sub

#End Region

#Region "Helper Functions"

    Public Sub Display_Image(ByVal myPictureDirectory As String)

        PictureBox_Main.SizeMode = PictureBoxSizeMode.AutoSize

        CurrentImage = New Bitmap(myPictureDirectory)
        PictureBox_Main.Image = CType(CurrentImage, Image)

    End Sub

#End Region

End Class
