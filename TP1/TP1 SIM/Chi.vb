Public Class Chi
    Private Sub Chi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_a.Enabled = False
        txt_c.Enabled = False
        txt_ml.Enabled = False
        txt_s.Enabled = False

    End Sub
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click

        GroupBox1.Enabled = False
        btn_generar.Enabled = False
        btn_clean.Enabled = True
        Dim m As Integer = txt_m.Text
        Dim k As Integer = txt_k.Text
        Dim acuinf As Double = 0
        Dim acusup As Double = 0
        Dim inf As Double
        Dim sup As Double
        Dim seed As Integer = 6
        Dim AcuInter(k) As Integer
        Dim grafico(k) As Integer
        Dim esperado(k) As Integer
        Dim acuchi As Double = 0
        Dim a As Double = txt_a.Text
        Dim c As Double = txt_c.Text
        Dim ml As Double = txt_ml.Text
        Dim s As Double = txt_s.Text


        For index = 1 To k
            inf = 0 + acusup
            acusup = (1 / k) + acusup
            sup = acusup - 0.0001

            Dim Vector() As Double = {inf, sup}
            tablon.Rows.Add(index, Vector(0), Vector(1))


        Next

        If rdb_windows.Checked = True Then
            Dim n As New Random()
            Dim rnd As Double


            'generador de numeros aleatorios y los pone en un vector
            For i = 0 To m

                rnd = n.NextDouble
                For fila = 0 To k

                    If rnd >= tablon.Item(1, fila).Value And rnd < tablon.Item(2, fila).Value Then
                        AcuInter(fila + 1) = AcuInter(fila + 1) + 1
                        grafico(fila) = grafico(fila) + 1
                        esperado(fila) = m / k
                    End If
                Next

            Next

            For y = 1 To k
                'Establece los intervalos esperados en tabla.
                Dim IntEsperados As Double = m / k
                Dim chi As Double
                chi = ((AcuInter(y) - IntEsperados) ^ 2) / IntEsperados
                acuchi = acuchi + chi
                Acu.Rows.Add(y, AcuInter(y), IntEsperados, chi, acuchi)
            Next
        Else
            Dim rnd As Double
            Dim xi As Double = 0
            Dim n As Integer = 0

            'generador de numeros aleatorios y los pone en un vector
            For i = 1 To m


                If n = 0 Then
                    xi = ((a * s) + c) Mod ml
                Else
                    xi = ((a * xi) + c) Mod ml
                End If
                n = n + 1
                rnd = xi / ml

                For fila = 0 To k

                    If rnd >= tablon.Item(1, fila).Value And rnd < tablon.Item(2, fila).Value Then
                        AcuInter(fila + 1) = AcuInter(fila + 1) + 1
                        grafico(fila) = grafico(fila) + 1
                        esperado(fila) = m / k

                    End If
                Next

            Next

            For y = 1 To k
                'Calcula la frecuencia esperada y luego el valor del chi y chu acumulado
                Dim IntEsperados As Double = m / k
                Dim chi As Double
                chi = ((AcuInter(y) - IntEsperados) ^ 2) / IntEsperados
                acuchi = acuchi + chi
                Acu.Rows.Add(y, AcuInter(y), IntEsperados, chi, acuchi)
            Next

        End If

        txt_resul.Text = Acu.Item(4, k - 1).Value

        'Cree un form nuevo solo para mostrar el gráfico, para que quede más presentable
        Grafica.CargarGrafico(grafico.AsEnumerable, esperado.AsEnumerable)
        Grafica.ShowDialog()


    End Sub



    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        GroupBox1.Enabled = True
        btn_generar.Enabled = True
        btn_clean.Enabled = False
        tablon.Rows.Clear()
        Acu.Rows.Clear()
        txt_resul.Text = ""
        Grafica.Close()

    End Sub

    Private Sub rdb_lineal_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_lineal.CheckedChanged
        txt_a.Enabled = True
        txt_c.Enabled = True
        txt_ml.Enabled = True
        txt_s.Enabled = True

    End Sub

    Private Sub rdb_windows_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_windows.CheckedChanged
        txt_a.Enabled = False
        txt_c.Enabled = False
        txt_ml.Enabled = False
        txt_s.Enabled = False
    End Sub

    'Validaciones

    Private Sub txt_a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_a.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_c_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_c.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_k_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_k.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_m.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ml_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ml.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_s_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_s.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class