Public Class Grafica

    Private Sub Grafico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub CargarGrafico(graf As IEnumerable, esp As IEnumerable)

        Chart1.Series.Clear()
        Chart1.DataBindTable(graf)
        Chart1.Series(0).Name = "f Obtenida"
        Chart1.DataBindTable(esp)
        Chart1.Series("0").Name = "f Esperada"
    End Sub
End Class