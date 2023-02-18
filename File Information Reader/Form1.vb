Imports System.IO

Public Class Form1
    ' Membuat procedure btnOpen_Click untuk menampilkan file
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|(*.*)"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileReader As System.IO.StreamReader
            Dim stringReader As String

            fileReader = My.Computer.FileSystem.OpenTextFileReader(openFileDialog.FileName)

            stringReader = fileReader.ReadLine()

            ' Menampilkan isi file pada kotak teks
            While Not stringReader Is Nothing
                txtInsideFile.Text += stringReader + Environment.NewLine
                stringReader = fileReader.ReadLine()
            End While

            txtCreated.Text = File.GetCreationTime(openFileDialog.FileName)
            txtUpdated.Text = File.GetLastWriteTime(openFileDialog.FileName)

            fileReader.Close()
        End If
    End Sub
End Class
