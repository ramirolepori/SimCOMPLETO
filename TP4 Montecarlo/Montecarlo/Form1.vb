Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_sim_Click(sender As Object, e As EventArgs) Handles btn_sim.Click

        If txt_Amostrar.Text = "" And txt_n.Text = "" Then
            MsgBox("Ingrese valores")
        Else

            Dim n As Integer = txt_n.Text
            Dim nAMostrar As Integer = txt_Amostrar.Text
            Dim random As New Random()
            Dim utilidadVuelo As Double
            Dim PasajerosPresentes As Integer
            Dim pasajerosSinCupo As Integer
            Dim costoTotal As Double
            Dim acumuladorUtilidad As Double
            Dim CapacidadDelVuelo As Integer = 30
            Dim PasajerosQueViajan As Integer
            Dim UtilidadPasaje As Integer = 100
            Dim CostoNoVendido As Integer = 150
            Dim UtilidadTotalVuelo As Double
            Dim promedio As Double
            Dim rnd As Double
            Dim flagEncontrado As Boolean = False



            If (IsNumeric(txt_n.Text) = False) Or (IsNumeric(txt_Amostrar.Text) = False) Or (n < nAMostrar) Then
                MsgBox("Los valores deben ser numericos y el valor a mostrar no puede ser mayor que el valor que el numero de vuelos a simular")

            Else


                gp_1.Enabled = False
                btn_reset.Enabled = True

                If rdb_1p.Checked = True Then
                    TabProba.Rows.Add(28, 0.1)
                    TabProba.Rows.Add(29, 0.35)
                    TabProba.Rows.Add(30, 0.85)
                    TabProba.Rows.Add(31, 1)
                End If
                If rdb_2p.Checked = True Then
                    TabProba.Rows.Add(28, 0.05)
                    TabProba.Rows.Add(29, 0.3)
                    TabProba.Rows.Add(30, 0.8)
                    TabProba.Rows.Add(31, 0.95)
                    TabProba.Rows.Add(32, 1)
                End If
                If rdb_3p.Checked = True Then
                    TabProba.Rows.Add(28, 0)
                    TabProba.Rows.Add(29, 0.05)
                    TabProba.Rows.Add(30, 0.25)
                    TabProba.Rows.Add(31, 0.7)
                    TabProba.Rows.Add(32, 0.9)
                    TabProba.Rows.Add(33, 1)
                End If
                If rdb_4p.Checked = True Then
                    TabProba.Rows.Add(28, 0)
                    TabProba.Rows.Add(29, 0.05)
                    TabProba.Rows.Add(30, 0.15)
                    TabProba.Rows.Add(31, 0.55)
                    TabProba.Rows.Add(32, 0.85)
                    TabProba.Rows.Add(33, 0.95)
                    TabProba.Rows.Add(34, 1)
                End If



                For vuelo = 0 To n
                    flagEncontrado = False
                    rnd = random.NextDouble()
                    ' 31 pasajeros
                    If rdb_1p.Checked = True Then
                        If rnd < TabProba.Item(1, 0).Value And flagEncontrado = False Then
                            PasajerosPresentes = 28
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 1).Value And flagEncontrado = False Then
                            PasajerosPresentes = 29
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 2).Value And flagEncontrado = False Then
                            PasajerosPresentes = 30
                            flagEncontrado = True
                        End If
                        If rnd <= TabProba.Item(1, 3).Value And flagEncontrado = False Then
                            PasajerosPresentes = 31
                            flagEncontrado = True
                        End If
                    End If
                    '32 pasajeros
                    If rdb_2p.Checked = True Then
                        If rnd < TabProba.Item(1, 0).Value And flagEncontrado = False Then
                            PasajerosPresentes = 28
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 1).Value And flagEncontrado = False Then
                            PasajerosPresentes = 29
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 2).Value And flagEncontrado = False Then
                            PasajerosPresentes = 30
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 3).Value And flagEncontrado = False Then
                            PasajerosPresentes = 31
                            flagEncontrado = True
                        End If
                        If rnd <= TabProba.Item(1, 4).Value And flagEncontrado = False Then
                            PasajerosPresentes = 32
                            flagEncontrado = True
                        End If
                    End If
                    '33 pasajeros
                    If rdb_3p.Checked = True Then
                        If rnd < TabProba.Item(1, 0).Value And flagEncontrado = False Then
                            PasajerosPresentes = 28
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 1).Value And flagEncontrado = False Then
                            PasajerosPresentes = 29
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 2).Value And flagEncontrado = False Then
                            PasajerosPresentes = 30
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 3).Value And flagEncontrado = False Then
                            PasajerosPresentes = 31
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 4).Value And flagEncontrado = False Then
                            PasajerosPresentes = 32
                            flagEncontrado = True
                        End If
                        If rnd <= TabProba.Item(1, 5).Value And flagEncontrado = False Then
                            PasajerosPresentes = 33
                            flagEncontrado = True
                        End If
                    End If
                    '34 pasajeros
                    If rdb_4p.Checked = True Then
                        If rnd < TabProba.Item(1, 0).Value And flagEncontrado = False Then
                            PasajerosPresentes = 28
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 1).Value And flagEncontrado = False Then
                            PasajerosPresentes = 29
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 2).Value And flagEncontrado = False Then
                            PasajerosPresentes = 30
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 3).Value And flagEncontrado = False Then
                            PasajerosPresentes = 31
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 4).Value And flagEncontrado = False Then
                            PasajerosPresentes = 32
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 5).Value And flagEncontrado = False Then
                            PasajerosPresentes = 33
                            flagEncontrado = True
                        End If
                        If rnd < TabProba.Item(1, 6).Value And flagEncontrado = False Then
                            PasajerosPresentes = 34
                            flagEncontrado = True
                        End If
                    End If

                    If PasajerosPresentes > CapacidadDelVuelo Then
                        PasajerosQueViajan = CapacidadDelVuelo
                        pasajerosSinCupo = PasajerosPresentes - PasajerosQueViajan
                    Else
                        pasajerosSinCupo = 0
                        PasajerosQueViajan = PasajerosPresentes
                    End If

                    utilidadVuelo = UtilidadPasaje * PasajerosQueViajan
                    costoTotal = pasajerosSinCupo * CostoNoVendido
                    UtilidadTotalVuelo = utilidadVuelo - costoTotal
                    acumuladorUtilidad = acumuladorUtilidad + UtilidadTotalVuelo

                    If (n - nAMostrar) <= vuelo Then
                        TabSim.Rows.Add(vuelo, rnd, PasajerosPresentes, pasajerosSinCupo, utilidadVuelo, costoTotal, UtilidadTotalVuelo, acumuladorUtilidad)
                    End If
                Next

                promedio = acumuladorUtilidad / n
                txt_uPromedio.Text = promedio
                txt_uTotal.Text = acumuladorUtilidad

            End If
        End If
    End Sub

    Private Sub Btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        TabSim.Rows.Clear()
        TabProba.Rows.Clear()
        btn_reset.Enabled = False
        txt_n.Text = ""
        txt_uPromedio.Text = ""
        txt_uTotal.Text = ""
        txt_Amostrar.Text = ""
        gp_1.Enabled = True
    End Sub

    Private Sub gp_1_Enter(sender As Object, e As EventArgs) Handles gp_1.Enter

    End Sub
End Class
