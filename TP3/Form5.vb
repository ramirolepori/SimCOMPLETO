Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function FACTORIAL(numero As Integer)
        Dim n As Integer
        FACTORIAL = 1
        For n = 1 To numero
            FACTORIAL = FACTORIAL * n
        Next
    End Function
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click

        GroupBox1.Enabled = False
        btn_generar.Enabled = False
        btn_clean.Enabled = True
        Dim m As Integer = txt_N.Text
        Dim inf As Double
        Dim sup As Double
        Dim acusup As Double
        '------------------------------------------------------------------------
        Dim randoms(m - 1) As Double
        Dim lambda As Double = txt_lambda.Text
        Dim max As Double
        Dim min As Double
        Dim ne As Double = Math.E
        ' Dim marcaDeClase(k - 1) As Double
        ' Dim intChi(k - 1) As Double
        '------------------------------------------------------------------------
        '  Dim AcuInter(k) As Integer
        ' Dim grafico(k) As Integer
        '  Dim esperado(k) As Integer
        Dim acuchi As Double = 0
        Dim n As New Random()
        Dim U As Double

        'Genera los numeros aleatorios

        Dim P As Double
        Dim X As Double
        Dim A As Double
        Dim rnd As Double

        For index = 1 To (m)

            P = 1
            X = -1
            A = Math.Exp(-lambda)

            Do
                rnd = n.NextDouble
                P = P * rnd
                X = X + 1
            Loop While (P >= A)

            randoms(index - 1) = X
        Next

        max = randoms.Max
        min = randoms.Min

        'Muestra los valores notables
        txt_min.Text = min
        txt_max.Text = max
        Dim menorActual As Integer = min
        Dim vectorPoisson((max - min) + 1) As Integer
        Dim ValorPoisson((max - min) + 1) As Integer

        For vec = 0 To (m - 1)

            For index = 0 To (m - 1)
                If randoms(index) = menorActual Then
                    vectorPoisson(vec) = vectorPoisson(vec) + 1
                    ValorPoisson(vec) = menorActual

                End If


            Next

            menorActual = menorActual + 1
        Next

        For index = 0 To ((max - min) + 1)

            If ValorPoisson(index) = 0 Then
                ValorPoisson(index) = ValorPoisson(index - 1) + 1
            End If
        Next



        Dim FrecEsperada(ValorPoisson.Length - 1) As Double
        Dim probMC(ValorPoisson.Length - 1) As Double
        Dim factor As Double


        For index = 0 To (ValorPoisson.Length - 2)
            factor = FACTORIAL(ValorPoisson(index))
            probMC(index) = ((lambda ^ ValorPoisson(index)) * (ne ^ (-(lambda)))) / (factor)
            FrecEsperada(index) = Math.Round((probMC(index) * m))
            tablon.Rows.Add(index, ValorPoisson(index), vectorPoisson(index), FrecEsperada(index))
        Next



        ''Establece los intervalos del CHI cuadrado, sumando los que no sean mayores a 5 y calcula el valor del chi cuadrado
        Dim acumuladorFe As Double = 0
        Dim acumuladorFo As Double = 0
        Dim actual As Double = 0
        Dim Valores As String = ""
        Dim chi As Double
        Dim numIntervalos As Integer = 0

        For index = 0 To (ValorPoisson.Length - 2)

            If (FrecEsperada(index) < 5) And (acumuladorFe < 5) Then
                acumuladorFe = acumuladorFe + FrecEsperada(index)
                acumuladorFo = acumuladorFo + vectorPoisson(index)
                Valores = Valores + "," + ValorPoisson(index).ToString


                If acumuladorFe >= 5 Then
                    chi = (((acumuladorFe - acumuladorFo) ^ 2) / acumuladorFe)
                    acuchi = acuchi + chi
                    TablaChi.Rows.Add(Valores, acumuladorFo, acumuladorFe, chi, acuchi)
                    acumuladorFe = 0
                    acumuladorFo = 0
                    Valores = ""
                    numIntervalos = numIntervalos + 1
                End If
            Else
                acumuladorFe = FrecEsperada(index)
                acumuladorFo = vectorPoisson(index)
                Valores = ValorPoisson(index).ToString
                chi = (((acumuladorFe - acumuladorFo) ^ 2) / acumuladorFe)
                acuchi = acuchi + chi
                TablaChi.Rows.Add(Valores, acumuladorFo, acumuladorFe, chi, acuchi)
                acumuladorFe = 0
                acumuladorFo = 0
                Valores = ""
                numIntervalos = numIntervalos + 1
            End If


        Next


        ''Verifica el valor del CHI obtenido con una exactitud de 95%
        Dim ChiCalculado As Double = acuchi
        Dim ChiTabla As Double
        Dim GradosDeLibertad As Double = numIntervalos - 2 'Numero de intervalos - Valores empiricos(lambda) - 1

        If GradosDeLibertad = 2 Then
            ChiTabla = 5.99
        End If
        If GradosDeLibertad = 3 Then
            ChiTabla = 7.81
        End If
        If GradosDeLibertad = 4 Then
            ChiTabla = 9.49
        End If
        If GradosDeLibertad = 5 Then
            ChiTabla = 11.1
        End If
        If GradosDeLibertad = 6 Then
            ChiTabla = 12.6
        End If
        If GradosDeLibertad = 7 Then
            ChiTabla = 14.0671
        End If
        If GradosDeLibertad = 8 Then
            ChiTabla = 15.5
        End If
        If GradosDeLibertad = 9 Then
            ChiTabla = 16.919
        End If
        If GradosDeLibertad = 10 Then
            ChiTabla = 18.3
        End If
        If GradosDeLibertad = 11 Then
            ChiTabla = 19.7
        End If
        If GradosDeLibertad = 12 Then
            ChiTabla = 21
        End If
        If GradosDeLibertad = 13 Then
            ChiTabla = 22.4
        End If
        If GradosDeLibertad = 14 Then
            ChiTabla = 23.7
        End If
        If GradosDeLibertad = 15 Then
            ChiTabla = 25
        End If
        If GradosDeLibertad > 15 Then
            txt_resultado.Text = "Buscar en tabla"
            txt_resultado.BackColor = Color.LightYellow
        Else
            If ChiCalculado <= ChiTabla Then
                txt_resultado.Text = "No se rechaza"
                txt_resultado.BackColor = Color.LightGreen
            Else
                txt_resultado.Text = "Se rechaza"
                txt_resultado.BackColor = Color.Red
            End If
        End If
        txt_calc.Text = ChiCalculado
            txt_tabla.Text = ChiTabla
        txt_lib.Text = GradosDeLibertad
        'Genera el grafico
        Chart1.Series.Clear()
        Chart1.DataBindTable(vectorPoisson.AsEnumerable)
        Chart1.Series(0).Name = "f Observada"
        Chart1.DataBindTable(FrecEsperada.AsEnumerable)
        Chart1.Series("0").Name = "f Esperada"


    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        btn_generar.Enabled = True
        txt_calc.Text = ""
        txt_lambda.Text = ""
        txt_max.Text = ""
        txt_media.Text = ""
        txt_lib.Text = ""
        txt_lambda.Enabled = True
        txt_min.Text = ""
        txt_N.Text = ""
        txt_resultado.Text = ""
        txt_tabla.Text = ""
        tablon.Rows.Clear()
        TablaChi.Rows.Clear()
        txt_resultado.BackColor = Color.White
        btn_clean.Enabled = False
        GroupBox1.Enabled = True
        Chart1.Series.Clear()
    End Sub

    Private Sub tablon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablon.CellContentClick

    End Sub
End Class