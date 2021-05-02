Public Class Form3
    Private Sub Btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click

        If txt_media.Text = "" Or IsNumeric(txt_media.Text) = False Then
            MsgBox("Debe especificar un valor numerico para la media")
        Else

            GroupBox1.Enabled = False
            btn_generar.Enabled = False
            btn_clean.Enabled = True
            Dim m As Integer = txt_N.Text
            Dim k As Integer
            Dim inf As Double
            Dim sup As Double
            Dim acusup As Double
            '------------------------------------------------------------------------
            'Asigna valor a K (numero de intervalos)
            If rd_5.Checked = True Then
                k = 5
            End If
            If rd_8.Checked = True Then
                k = 8
            End If
            If rd_10.Checked = True Then
                k = 10
            End If
            If rd_12.Checked = True Then
                k = 12
            End If
            '------------------------------------------------------------------------
            Dim randoms(m - 1) As Double
            Dim media As Double = txt_media.Text
            Dim desviacion As Double = txt_desviacion.Text
            Dim max As Double
            Dim min As Double
            Dim marcaDeClase(k - 1) As Double
            Dim FrecEsperada(k - 1) As Double
            Dim probMC(k - 1) As Double
            Dim intChi(k - 1) As Double
            '------------------------------------------------------------------------
            Dim AcuInter(k) As Integer
            Dim grafico(k) As Integer
            Dim esperado(k) As Integer
            Dim acuchi As Double = 0
            Dim n As New Random()
            Dim rnd_uniforme As Double
            Dim rnd_normal As Double


            ' genera numeros aleatorios
            ' k_uniformes: k valores generados uniformes, hacen 1 valor normal, por la formula de "Zi", por convolución (n:12, media:6, ds:1/12)
            Dim k_uniformes = 12
            For index = 0 To (m - 1)
                For i = 0 To k_uniformes
                    rnd_uniforme += n.NextDouble()
                Next
                rnd_normal = rnd_uniforme - (k_uniformes / 2)
                randoms(index) = rnd_normal
                rnd_uniforme = 0
            Next

            'Transforma N(0,1) a N(desviacion,media)
            For index = 0 To randoms.Length - 1
                randoms(index) = randoms(index) * desviacion + media
            Next


            max = randoms.Max
            min = randoms.Min

            'Muestra los valores notables
            txt_min.Text = min
            txt_max.Text = max
            txt_media.Enabled = False
            txt_desviacion.Enabled = False


            'Calcula los intervalos
            Dim Diferencia As Double
            Dim AnchoIntervalo As Double
            Diferencia = max - min
            AnchoIntervalo = Diferencia / k
            'acuinf = 0
            For index = 0 To (k - 1)
                inf = min
                acusup = (inf + AnchoIntervalo)
                sup = acusup - 0.0000001
                min = acusup
                marcaDeClase(index) = ((inf + sup) / 2)
                tablon.Rows.Add(index + 1, inf, sup, marcaDeClase(index))
            Next

            For numero = 0 To (m - 1)
                For inter = 0 To (k - 1)

                    'Calcula la frecuencia observada
                    If (randoms(numero) >= tablon.Item(1, inter).Value) And (randoms(numero) <= tablon.Item(2, inter).Value) Then
                        AcuInter(inter) = AcuInter(inter) + 1
                    End If

                Next
            Next

            If Math.Truncate(max) = Math.Truncate(tablon.Item(2, (k - 1)).Value) Then
                AcuInter(k - 1) = AcuInter(k - 1) + 1
            End If

            'Calcula la probabilidad y la divide por la marca de clase (Lambda*(EXP(-Lambda*MarcaClase)))*(Sup-Inf) Luego calcula la frecuencia esperada y los muestra en tabla
            Dim parte1 As Double
            Dim parte2 As Double
            Dim parte21 As Double

            For index = 0 To (k - 1)
                parte1 = desviacion * Math.Sqrt(2 * Math.PI)
                parte21 = ((marcaDeClase(index) - media) / desviacion) ^ 2
                parte2 = Math.Exp((-0.5) * parte21)

                'probMC(index) = ((1 / desviacion * Math.Sqrt(2 * Math.PI)) * Math.Exp((-0.5) * ((marcaDeClase(index) - media) / desviacion) ^ 2)) '* (tablon.Item(2, index).Value - tablon.Item(1, index).Value)
                probMC(index) = (parte2 / parte1) * (tablon.Item(2, index).Value - tablon.Item(1, index).Value)
                FrecEsperada(index) = probMC(index) * m
                Acu.Rows.Add((index + 1), AcuInter(index), probMC(index), FrecEsperada(index))
            Next

            'Establece los intervalos del CHI cuadrado, sumando los que no sean mayores a 5 y calcula el valor del chi cuadrado
            Dim acumuladorFe As Double = 0
            Dim acumuladorFo As Double = 0
            Dim minimoChi As Double
            Dim maximoCHi As Double
            Dim flagPrimerValor As Boolean = True
            Dim chi As Double

            For index = 0 To (k - 1)

                If FrecEsperada((k - 1) - index) < 5 Or flagPrimerValor = False Then

                    If flagPrimerValor = True Then
                        maximoCHi = tablon.Item(2, (k - 1) - index).Value
                    End If

                    flagPrimerValor = False
                    acumuladorFe = acumuladorFe + FrecEsperada((k - 1) - index)


                    If acumuladorFe >= 5 Then
                        minimoChi = tablon.Item(1, (k - 1) - index).Value
                        chi = (((acumuladorFe - acumuladorFo) ^ 2) / acumuladorFe)
                        acuchi = acuchi + chi
                        acumuladorFo = acumuladorFo + AcuInter((k - 1) - index)
                        TablaChi.Rows.Add(minimoChi, maximoCHi, acumuladorFo, acumuladorFe, chi, acuchi)
                        acumuladorFe = 0
                        acumuladorFo = 0
                        flagPrimerValor = True
                    Else

                        acumuladorFo = acumuladorFo + AcuInter((k - 1) - index)
                    End If

                Else
                    minimoChi = tablon.Item(1, (k - 1) - index).Value
                    maximoCHi = tablon.Item(2, (k - 1) - index).Value
                    chi = (((AcuInter((k - 1) - index) - FrecEsperada((k - 1) - index)) ^ 2) / FrecEsperada((k - 1) - index))
                    acuchi = acuchi + chi
                    TablaChi.Rows.Add(minimoChi, maximoCHi, AcuInter((k - 1) - index), FrecEsperada((k - 1) - index), chi, acuchi)
                    acumuladorFe = 0
                    acumuladorFo = 0
                End If

            Next

            'Verifica el valor del CHI obtenido con una exactitud de 95%
            Dim ChiCalculado As Double = acuchi
            Dim ChiTabla As Double
            Dim GradosDeLibertad As Double = k - 3 'Numero de intervalos - Valores empiricos(lambda) - 1

            If GradosDeLibertad = 2 Then
                ChiTabla = 5.9915
            End If
            If GradosDeLibertad = 5 Then
                ChiTabla = 11.0705
            End If

            If GradosDeLibertad = 7 Then
                ChiTabla = 14.0671
            End If

            If GradosDeLibertad = 9 Then
                ChiTabla = 16.919
            End If

            If ChiCalculado <= ChiTabla Then
                txt_resultado.Text = "No se rechaza"
                txt_resultado.BackColor = Color.LightGreen
            Else
                txt_resultado.Text = "Se rechaza"
                txt_resultado.BackColor = Color.Red
            End If
            txt_calc.Text = ChiCalculado
            txt_tabla.Text = ChiTabla

            'Genera el grafico
            Chart1.Series.Clear()
            Chart1.DataBindTable(AcuInter.AsEnumerable)
            Chart1.Series(0).Name = "f Observada"
            Chart1.DataBindTable(FrecEsperada.AsEnumerable)
            Chart1.Series("0").Name = "f Esperada"
        End If
    End Sub



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_media.Enabled = True
        txt_desviacion.Enabled = True
        btn_clean.Enabled = False
        btn_generar.Enabled = True

    End Sub


    Private Sub Btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        btn_generar.Enabled = True
        txt_calc.Text = ""
        txt_desviacion.Text = ""
        txt_max.Text = ""
        txt_media.Text = ""
        txt_media.Enabled = True
        txt_desviacion.Enabled = True
        txt_min.Text = ""
        txt_N.Text = ""
        txt_resultado.Text = ""
        txt_tabla.Text = ""
        tablon.Rows.Clear()
        TablaChi.Rows.Clear()
        Acu.Rows.Clear()
        txt_resultado.BackColor = Color.White
        btn_clean.Enabled = False

        GroupBox1.Enabled = True
        Chart1.Series.Clear()


    End Sub

    Private Sub Tablon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txt_min_TextChanged(sender As Object, e As EventArgs) Handles txt_min.TextChanged

    End Sub

    Private Sub txt_max_TextChanged(sender As Object, e As EventArgs) Handles txt_max.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_media_TextChanged(sender As Object, e As EventArgs) Handles txt_media.TextChanged

    End Sub

    Private Sub txt_desviacion_TextChanged(sender As Object, e As EventArgs) Handles txt_desviacion.TextChanged

    End Sub

End Class