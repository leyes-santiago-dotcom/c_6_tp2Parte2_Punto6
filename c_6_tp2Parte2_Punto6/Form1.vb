Public Class Form1
    '6. Determinar todos los números capicúas de 3 cifras. 
    Dim Numero, Unidad, Centena As Integer

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        lstMuestra.Items.Add("los numeros capicua de 3 cifras son: ")
        For Numero = 100 To 999 Step 1
            Centena = (Numero \ 100)
            Unidad = (Numero Mod 10)
            If Centena = Unidad Then
                lstMuestra.Items.Add(Numero)
            End If
        Next
    End Sub
End Class
