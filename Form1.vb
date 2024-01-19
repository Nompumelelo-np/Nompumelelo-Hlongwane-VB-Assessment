Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private TextList As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Words"
    End Sub




    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertText As String
        insertText = TextBox1.Text.Trim()

        If Not String.IsNullOrEmpty(insertText) Then
            If Not TextList.Contains(insertText) Then
                TextList.Add(insertText)
                ListBox1.Items.Add(insertText)
            Else
                MessageBox.Show("Word exists in the list")
            End If
        Else
            MessageBox.Show("Enter a word")
        End If

        TextBox1.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Label.Text = ListBox1.SelectedItem.ToString()
            Label.BackColor = Color.White
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged,
           RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged

        Dim SelectedRadioButton As RadioButton
        SelectedRadioButton = DirectCast(sender, RadioButton)

        If ListBox1.SelectedIndex <> -1 Then
            Dim textlabel As String
            textlabel = Label.Text

            If SelectedRadioButton Is RadioButton1 Then
                textlabel = textlabel.ToUpper()
            ElseIf SelectedRadioButton Is RadioButton2 Then
                textlabel = textlabel.ToLower()
            ElseIf SelectedRadioButton Is RadioButton3 Then
                Label.ForeColor = Color.Purple
            ElseIf SelectedRadioButton Is RadioButton4 Then
                Label.ForeColor = Color.Blue
            End If

            Label.Text = textlabel
        End If
    End Sub
End Class

