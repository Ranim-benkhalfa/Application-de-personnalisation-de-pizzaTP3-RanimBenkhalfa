Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim taillepizza As String = ComboBox1.SelectedItem?.ToString()
        Dim typecroute As String = ""
        Dim ingredients As String = "Ingrédients supplémentaires:"
        'Déterminer le type de croute séléctionné 
        If CheckBox1.Checked Then
            typecroute = "Croute fine"
        ElseIf CheckBox2.Checked Then
            typecroute = "Croute classique"
        ElseIf CheckBox3.Checked Then
            typecroute = "Croute épaisse"


        End If

        'Ajouter les ingrédients sélectionnés
        If RadioButton1.Checked Then
            ingredients &= "Champignons"
        End If
        If RadioButton2.Checked Then
            ingredients &= "Olives"
        End If
        If RadioButton3.Checked Then
            ingredients &= "Poivrons"
        End If
        If RadioButton3.Checked Then
            ingredients &= "Fromage supplémentaire"
        End If
        'Afficher le récapitulatif
        Label1.Text = "Taille de la pizza: " & taillepizza & vbCrLf & "Type de croute:" & typecroute & vbCrLf & ingredients

    End Sub


End Class



