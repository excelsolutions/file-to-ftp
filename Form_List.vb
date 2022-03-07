Imports System.ComponentModel

Public Class Form_List


    Private Sub Form_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Utworzenie kolumn w Formie_Operacje
        Me.Lista_Operacji.Columns.Add("No.", 50)
        Me.Lista_Operacji.Columns.Add("File name", 150)
        Me.Lista_Operacji.Columns.Add("Path to file", 300)
        Me.Lista_Operacji.Columns.Add("New name of file", 300)
        Me.Lista_Operacji.Columns.Add("Status", 80)

    End Sub

    Private Sub Lista_Operacji_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista_Operacji.SelectedIndexChanged

    End Sub

    Private Sub Form_List_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'anulowanie zamknięcia formy
        e.Cancel = True
        Hide()
    End Sub
End Class