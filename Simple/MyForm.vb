Imports System.Windows.Forms

Public Class MyForm
    Inherits Form

    Private MessageTextBox As TextBox   'Field represent Control
    Private MessageLabel As Label
    Private WithEvents ShowMessageButton As Button


    Public Sub New()
        Me.Text = "My Form"

        MessageTextBox = New TextBox()  'constructor
        MessageTextBox.Left = 25        'properties
        MessageTextBox.Top = 25
        MessageTextBox.Width = 200
        Me.Controls.Add(MessageTextBox) 'add to collection

        ShowMessageButton = New Button()
        ShowMessageButton.Left = 25
        ShowMessageButton.Top = 75
        ShowMessageButton.Width = 200
        ShowMessageButton.Text = "Show Message"
        Me.Controls.Add(ShowMessageButton)

        MessageLabel = New Label()
        MessageLabel.Left = 25
        MessageLabel.Top = 125
        MessageLabel.Width = 200
        MessageLabel.Text = "[Label]"
        Me.Controls.Add(MessageLabel)
    End Sub

    Private Sub ClickHanlder(sender As Object, e As EventArgs) _
        Handles ShowMessageButton.Click
        MessageLabel.Text = MessageTextBox.Text
        MsgBox("Button Click")

    End Sub
End Class
