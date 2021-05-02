Public Class Form1

    Dim Rnd As New Random
    Dim CostoRuptura As Integer = 8
    Dim CostoAlmacenamiento As Integer = 5
    Dim TiempoDeSim As Integer = 365
    'Variables de Politica A

    Dim diaA As Integer = 0
    Dim RandomDemandaA As Double
    Dim DemandaA As Integer
    Dim stockA As Integer
    Dim DemandaNoCubiertaA As Integer
    Dim RandomDemoraA As Double
    Dim DemoraA As Integer
    Dim CantidadPedidaA As Integer
    Dim AcumuladorDemandaA As Integer
    Dim ArriboA As Integer
    Dim CostoAlmacenamientoA As Integer
    Dim CostoRupturaA As Integer
    Dim CostoPedidoA As Integer
    Dim CostoTotalA As Integer
    Dim TotalDecenasA As Integer
    Dim promedioCostoA As Double
    Dim promedioVentaA As Double
    Dim ProximoPedidoA As Integer
    Dim CantidadRepoA As Integer = 180
    Dim TiempoDeRepoA As Integer = 7

    'Variables de Politica B

    Dim diaB As Integer = 0
    Dim RandomDemandaB As Double
    Dim DemandaB As Integer
    Dim stockB As Integer
    Dim DemandaNoCubiertaB As Integer
    Dim RandomDemoraB As Double
    Dim DemoraB As Integer
    Dim CantidadPedidaB As Integer
    Dim AcumuladorDemandaB As Integer
    Dim ArriboB As Integer
    Dim CostoAlmacenamientoB As Integer
    Dim CostoRupturaB As Integer
    Dim CostoPedidoB As Integer
    Dim CostoTotalB As Integer
    Dim TiempoDeRepoB As Integer = 15
    Dim CantidadDeDiasDemanda As Integer = 10
    Dim TotalDecenasB As Integer
    Dim promedioCostoB As Double
    Dim promedioVentaB As Double
    Dim ProximoPedidoB As Integer
    Dim ContadorDiasDesdePedido As Integer

    'Variables de Politica C

    Dim diaC As Integer = 0
    Dim RandomDemandaC As Double
    Dim DemandaC As Integer
    Dim stockC As Integer
    Dim DemandaNoCubiertaC As Integer
    Dim RandomDemoraC As Double
    Dim DemoraC As Integer
    Dim CantidadPedidaC As Integer
    Dim AcumuladorDemandaC As Integer
    Dim ArriboC As Integer
    Dim CostoAlmacenamientoC As Integer
    Dim CostoRupturaC As Integer
    Dim CostoPedidoC As Integer
    Dim CostoTotalC As Integer
    Dim TotalDecenasC As Integer
    Dim CantidadRepoC As Integer = 100
    Dim TiempoDeRepoC As Integer = 5
    Dim promedioCostoC As Double
    Dim promedioVentaC As Double
    Dim ProximoPedidoC As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_reiniciar.Enabled = False
        txt_TiempoSim.Text = TiempoDeSim

        txt_TA.Text = TiempoDeRepoA
        txt_RA.Text = CantidadRepoA

        txt_TB.Text = TiempoDeRepoB
        txt_RB.Text = CantidadDeDiasDemanda

        txt_TC.Text = TiempoDeRepoC
        txt_RC.Text = CantidadRepoC

    End Sub

    Private Sub nuevaDemandaA(rnd As Double)
        If rnd < 0.05 Then
            DemandaA = 0
        ElseIf rnd < 0.17 Then
            DemandaA = 10
        ElseIf rnd < 0.35 Then
            DemandaA = 20
        ElseIf rnd < 0.6 Then
            DemandaA = 30
        ElseIf rnd < 0.82 Then
            DemandaA = 40
        ElseIf rnd <= 1 Then
            DemandaA = 50

        End If
    End Sub
    Private Sub nuevaDemoraA(rnd As Double)
        If rnd < 0.15 Then
            DemoraA = 1
        ElseIf rnd < 0.35 Then
            DemoraA = 2
        ElseIf rnd < 0.75 Then
            DemoraA = 3
        ElseIf rnd <= 1 Then
            DemoraA = 4
        End If
    End Sub
    Private Sub nuevaDemandaB(rnd As Double)
        If rnd < 0.05 Then
            DemandaB = 0
        ElseIf rnd < 0.17 Then
            DemandaB = 10
        ElseIf rnd < 0.35 Then
            DemandaB = 20
        ElseIf rnd < 0.6 Then
            DemandaB = 30
        ElseIf rnd < 0.82 Then
            DemandaB = 40
        ElseIf rnd <= 1 Then
            DemandaB = 50

        End If
    End Sub
    Private Sub nuevaDemoraB(rnd As Double)
        If rnd < 0.15 Then
            DemoraB = 1
        ElseIf rnd < 0.35 Then
            DemoraB = 2
        ElseIf rnd < 0.75 Then
            DemoraB = 3
        ElseIf rnd <= 1 Then
            DemoraB = 4
        End If
    End Sub
    Private Sub CalculoCostoB(pedido As Integer)
        If pedido <= 100 Then
            CostoPedidoB = 200
        ElseIf pedido <= 200 Then
            CostoPedidoB = 280
        ElseIf pedido > 200 Then
            CostoPedidoB = 300
        End If
    End Sub
    Private Sub CalculoCostoA(pedido As Integer)
        If pedido <= 100 Then
            CostoPedidoA = 200
        ElseIf pedido <= 200 Then
            CostoPedidoA = 280
        ElseIf pedido > 200 Then
            CostoPedidoA = 300
        End If
    End Sub
    Private Sub CalculoCostoC(pedido As Integer)
        If pedido <= 100 Then
            CostoPedidoC = 200
        ElseIf pedido <= 200 Then
            CostoPedidoC = 280
        ElseIf pedido > 200 Then
            CostoPedidoC = 300
        End If
    End Sub
    Private Sub nuevaDemandaC(rnd As Double)
        If rnd < 0.05 Then
            DemandaC = 0
        ElseIf rnd < 0.17 Then
            DemandaC = 10
        ElseIf rnd < 0.35 Then
            DemandaC = 20
        ElseIf rnd < 0.6 Then
            DemandaC = 30
        ElseIf rnd < 0.82 Then
            DemandaC = 40
        ElseIf rnd <= 1 Then
            DemandaC = 50

        End If
    End Sub
    Private Sub nuevaDemoraC(rnd As Double)
        If rnd < 0.15 Then
            DemoraC = 1
        ElseIf rnd < 0.35 Then
            DemoraC = 2
        ElseIf rnd < 0.75 Then
            DemoraC = 3
        ElseIf rnd <= 1 Then
            DemoraC = 4
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txt_TiempoSim.Enabled = False
        txt_RA.Enabled = False
        txt_TA.Enabled = False
        txt_RB.Enabled = False
        txt_TB.Enabled = False
        txt_RC.Enabled = False
        txt_TC.Enabled = False

        personalizar.Enabled = False
        btn_reiniciar.Enabled = True
        Button1.Enabled = False
        'POLITICA A
        'Dia 0
        If personalizar.Checked = True Then
            TiempoDeSim = txt_TiempoSim.Text

            TiempoDeRepoA = txt_TA.Text
            CantidadRepoA = txt_RA.Text


            Dim a As Integer = txt_RB.Text
            Dim b As Integer = txt_TB.Text

            If a < b Then
                TiempoDeRepoB = txt_TB.Text
                CantidadDeDiasDemanda = txt_RB.Text
            Else
                MsgBox("El la cantidad de dias para calcular la demanda a acumulada no puede ser mayor al tiempo. No se ha guardado ningun cambio en la politica B")
            End If


            TiempoDeRepoC = txt_TC.Text
            CantidadRepoC = txt_RC.Text
        End If


        For diaA = 0 To TiempoDeSim


            If diaA = 0 Then

                RandomDemandaA = 0
                DemandaA = 0
                stockA = 20
                DemandaNoCubiertaA = 0
                RandomDemoraA = 0
                DemoraA = 0
                CantidadPedidaA = 0
                AcumuladorDemandaA = 0
                ArriboA = 0
                CostoAlmacenamientoA = 0
                CostoRupturaA = 0
                CostoPedidoA = 0
                CostoTotalA = 0
                TotalDecenasA = 0

                grillaA.Rows.Add()
                grillaA.Rows(0).Cells(0).Value = diaA
                grillaA.Rows(0).Cells(1).Value = RandomDemandaA
                grillaA.Rows(0).Cells(2).Value = DemandaA
                grillaA.Rows(0).Cells(3).Value = stockA
                grillaA.Rows(0).Cells(4).Value = DemandaNoCubiertaA
                grillaA.Rows(0).Cells(5).Value = RandomDemoraA
                grillaA.Rows(0).Cells(6).Value = DemoraA
                grillaA.Rows(0).Cells(7).Value = CantidadPedidaA
                grillaA.Rows(0).Cells(8).Value = AcumuladorDemandaA
                grillaA.Rows(0).Cells(9).Value = ArriboA
                grillaA.Rows(0).Cells(10).Value = CostoAlmacenamientoA
                grillaA.Rows(0).Cells(11).Value = CostoRupturaA
                grillaA.Rows(0).Cells(12).Value = CostoPedidoA
                grillaA.Rows(0).Cells(13).Value = CostoTotalA
                grillaA.Rows(0).Cells(14).Value = TotalDecenasA


            End If
            'Dia uno. Hace pedido
            If diaA = 1 Then
                RandomDemandaA = Rnd.NextDouble
                nuevaDemandaA(RandomDemandaA)
                If stockA >= DemandaA Then
                    stockA = stockA - DemandaA
                    DemandaNoCubiertaA = 0
                    TotalDecenasA = DemandaA
                Else
                    DemandaNoCubiertaA = DemandaA - stockA
                    TotalDecenasA = stockA
                    stockA = 0
                End If
                RandomDemoraA = Rnd.NextDouble
                nuevaDemoraA(RandomDemoraA)
                CantidadPedidaA = CantidadRepoA
                AcumuladorDemandaA = AcumuladorDemandaA + DemandaA
                ArriboA = diaA + DemoraA
                CostoAlmacenamientoA = CostoAlmacenamiento * stockA
                CostoRupturaA = CostoRuptura * DemandaNoCubiertaA
                CalculoCostoA(CantidadPedidaA)
                CostoTotalA = CostoAlmacenamientoA + CostoRupturaA + CostoPedidoA
                ProximoPedidoA = diaA + TiempoDeRepoA
                grillaA.Rows.Add()
                grillaA.Rows(1).Cells(0).Value = diaA
                grillaA.Rows(1).Cells(1).Value = RandomDemandaA
                grillaA.Rows(1).Cells(2).Value = DemandaA
                grillaA.Rows(1).Cells(3).Value = stockA
                grillaA.Rows(1).Cells(4).Value = DemandaNoCubiertaA
                grillaA.Rows(1).Cells(5).Value = RandomDemoraA
                grillaA.Rows(1).Cells(6).Value = DemoraA
                grillaA.Rows(1).Cells(7).Value = CantidadPedidaA
                grillaA.Rows(1).Cells(8).Value = AcumuladorDemandaA
                grillaA.Rows(1).Cells(9).Value = ArriboA
                grillaA.Rows(1).Cells(10).Value = CostoAlmacenamientoA
                grillaA.Rows(1).Cells(11).Value = CostoRupturaA
                grillaA.Rows(1).Cells(12).Value = CostoPedidoA
                grillaA.Rows(1).Cells(13).Value = CostoTotalA
                grillaA.Rows(1).Cells(14).Value = TotalDecenasA
            End If

            'Dia de realizar pedido
            If diaA = ProximoPedidoA And (diaA > 1) Then

                If diaA = ArriboA Then
                    stockA = stockA + CantidadRepoA
                    ArriboA = 0
                End If

                RandomDemandaA = Rnd.NextDouble
                nuevaDemandaA(RandomDemandaA)
                If stockA >= DemandaA Then
                    stockA = stockA - DemandaA
                    DemandaNoCubiertaA = 0
                    TotalDecenasA = TotalDecenasA + DemandaA
                Else
                    DemandaNoCubiertaA = DemandaA - stockA
                    TotalDecenasA = TotalDecenasA + stockA
                    stockA = 0
                End If
                RandomDemoraA = Rnd.NextDouble
                nuevaDemoraA(RandomDemoraA)
                CantidadPedidaA = CantidadRepoA
                AcumuladorDemandaA = AcumuladorDemandaA + DemandaA
                ArriboA = diaA + DemoraA
                CostoAlmacenamientoA = CostoAlmacenamiento * stockA
                CostoRupturaA = CostoRuptura * DemandaNoCubiertaA
                CalculoCostoA(CantidadPedidaA)
                CostoTotalA = CostoTotalA + CostoAlmacenamientoA + CostoRupturaA + CostoPedidoA
                ProximoPedidoA = diaA + TiempoDeRepoA
                grillaA.Rows.Add()
                grillaA.Rows(diaA).Cells(0).Value = diaA
                grillaA.Rows(diaA).Cells(1).Value = RandomDemandaA
                grillaA.Rows(diaA).Cells(2).Value = DemandaA
                grillaA.Rows(diaA).Cells(3).Value = stockA
                grillaA.Rows(diaA).Cells(4).Value = DemandaNoCubiertaA
                grillaA.Rows(diaA).Cells(5).Value = RandomDemoraA
                grillaA.Rows(diaA).Cells(6).Value = DemoraA
                grillaA.Rows(diaA).Cells(7).Value = CantidadPedidaA
                grillaA.Rows(diaA).Cells(8).Value = AcumuladorDemandaA
                grillaA.Rows(diaA).Cells(9).Value = ArriboA
                grillaA.Rows(diaA).Cells(10).Value = CostoAlmacenamientoA
                grillaA.Rows(diaA).Cells(11).Value = CostoRupturaA
                grillaA.Rows(diaA).Cells(12).Value = CostoPedidoA
                grillaA.Rows(diaA).Cells(13).Value = CostoTotalA
                grillaA.Rows(diaA).Cells(14).Value = TotalDecenasA

            Else
                'Dia corriente
                If (diaA > 1) Then


                    If diaA = ArriboA Then
                        stockA = stockA + CantidadRepoA
                        ArriboA = 0
                    End If
                    RandomDemandaA = Rnd.NextDouble
                    nuevaDemandaA(RandomDemandaA)
                    If stockA >= DemandaA Then
                        stockA = stockA - DemandaA
                        DemandaNoCubiertaA = 0
                        TotalDecenasA = TotalDecenasA + DemandaA
                    Else
                        DemandaNoCubiertaA = DemandaA - stockA
                        TotalDecenasA = TotalDecenasA + stockA
                        stockA = 0
                    End If
                    RandomDemoraA = 0
                    DemoraA = 0
                    CantidadPedidaA = 0
                    AcumuladorDemandaA = AcumuladorDemandaA + DemandaA
                    CostoAlmacenamientoA = CostoAlmacenamiento * stockA
                    CostoRupturaA = CostoRuptura * DemandaNoCubiertaA
                    CostoPedidoA = 0
                    CostoTotalA = CostoTotalA + CostoAlmacenamientoA + CostoRupturaA + CostoPedidoA

                    grillaA.Rows.Add()
                    grillaA.Rows(diaA).Cells(0).Value = diaA
                    grillaA.Rows(diaA).Cells(1).Value = RandomDemandaA
                    grillaA.Rows(diaA).Cells(2).Value = DemandaA
                    grillaA.Rows(diaA).Cells(3).Value = stockA
                    grillaA.Rows(diaA).Cells(4).Value = DemandaNoCubiertaA
                    grillaA.Rows(diaA).Cells(5).Value = RandomDemoraA
                    grillaA.Rows(diaA).Cells(6).Value = DemoraA
                    grillaA.Rows(diaA).Cells(7).Value = CantidadPedidaA
                    grillaA.Rows(diaA).Cells(8).Value = AcumuladorDemandaA
                    grillaA.Rows(diaA).Cells(9).Value = ArriboA
                    grillaA.Rows(diaA).Cells(10).Value = CostoAlmacenamientoA
                    grillaA.Rows(diaA).Cells(11).Value = CostoRupturaA
                    grillaA.Rows(diaA).Cells(12).Value = CostoPedidoA
                    grillaA.Rows(diaA).Cells(13).Value = CostoTotalA
                    grillaA.Rows(diaA).Cells(14).Value = TotalDecenasA
                End If
            End If
        Next


        'POLITICA B
        'Dia 0
        For diaB = 0 To TiempoDeSim


            If diaB = 0 Then

                RandomDemandaB = 0
                DemandaB = 0
                stockB = 20
                DemandaNoCubiertaB = 0
                RandomDemoraB = 0
                DemoraB = 0
                CantidadPedidaB = 0
                AcumuladorDemandaB = 0
                ArriboB = 0
                CostoAlmacenamientoB = 0
                CostoRupturaB = 0
                CostoPedidoB = 0
                CostoTotalB = 0
                TotalDecenasB = 0

                GrillaB.Rows.Add()
                GrillaB.Rows(0).Cells(0).Value = diaB
                GrillaB.Rows(0).Cells(1).Value = RandomDemandaB
                GrillaB.Rows(0).Cells(2).Value = DemandaB
                GrillaB.Rows(0).Cells(3).Value = stockB
                GrillaB.Rows(0).Cells(4).Value = DemandaNoCubiertaB
                GrillaB.Rows(0).Cells(5).Value = RandomDemoraB
                GrillaB.Rows(0).Cells(6).Value = DemoraB
                GrillaB.Rows(0).Cells(7).Value = CantidadPedidaB
                GrillaB.Rows(0).Cells(8).Value = AcumuladorDemandaB
                GrillaB.Rows(0).Cells(9).Value = ArriboB
                GrillaB.Rows(0).Cells(10).Value = CostoAlmacenamientoB
                GrillaB.Rows(0).Cells(11).Value = CostoRupturaB
                GrillaB.Rows(0).Cells(12).Value = CostoPedidoB
                GrillaB.Rows(0).Cells(13).Value = CostoTotalB
                GrillaB.Rows(0).Cells(14).Value = TotalDecenasB


            End If
            'Dia uno. Hace pedido
            If diaB = 1 Then
                RandomDemandaB = Rnd.NextDouble
                nuevaDemandaB(RandomDemandaB)
                If stockB >= DemandaB Then
                    stockB = stockB - DemandaB
                    DemandaNoCubiertaB = 0
                    TotalDecenasB = DemandaB
                Else
                    DemandaNoCubiertaB = DemandaB - stockB
                    TotalDecenasB = stockB
                    stockB = 0
                End If
                RandomDemoraB = Rnd.NextDouble
                nuevaDemoraB(RandomDemoraB)
                CantidadPedidaB = DemandaB
                AcumuladorDemandaB = AcumuladorDemandaB + DemandaB
                ArriboB = diaB + DemoraB
                CostoAlmacenamientoB = CostoAlmacenamiento * stockB
                CostoRupturaB = CostoRuptura * DemandaNoCubiertaB
                CalculoCostoB(CantidadPedidaB)
                CostoTotalB = CostoAlmacenamientoB + CostoRupturaB + CostoPedidoB
                ProximoPedidoB = diaB + TiempoDeRepoB
                ContadorDiasDesdePedido = 0
                AcumuladorDemandaB = 0
                GrillaB.Rows.Add()
                GrillaB.Rows(1).Cells(0).Value = diaB
                GrillaB.Rows(1).Cells(1).Value = RandomDemandaB
                GrillaB.Rows(1).Cells(2).Value = DemandaB
                GrillaB.Rows(1).Cells(3).Value = stockB
                GrillaB.Rows(1).Cells(4).Value = DemandaNoCubiertaB
                GrillaB.Rows(1).Cells(5).Value = RandomDemoraB
                GrillaB.Rows(1).Cells(6).Value = DemoraB
                GrillaB.Rows(1).Cells(7).Value = CantidadPedidaB
                GrillaB.Rows(1).Cells(8).Value = AcumuladorDemandaB
                GrillaB.Rows(1).Cells(9).Value = ArriboB
                GrillaB.Rows(1).Cells(10).Value = CostoAlmacenamientoB
                GrillaB.Rows(1).Cells(11).Value = CostoRupturaB
                GrillaB.Rows(1).Cells(12).Value = CostoPedidoB
                GrillaB.Rows(1).Cells(13).Value = CostoTotalB
                GrillaB.Rows(1).Cells(14).Value = TotalDecenasB
            End If

            'Dia de realizar pedido
            If diaB = ProximoPedidoB And (diaB > 1) Then

                If diaB = ArriboB Then
                    stockB = stockB + CantidadPedidaB
                    ArriboB = 0
                    CantidadPedidaB = 0
                End If

                If diaB = ArriboB Then
                    stockB = stockB + CantidadPedidaB
                End If
                RandomDemandaB = Rnd.NextDouble
                nuevaDemandaB(RandomDemandaB)
                AcumuladorDemandaB = AcumuladorDemandaB + DemandaB
                If stockB >= DemandaB Then
                    stockB = stockB - DemandaB
                    DemandaNoCubiertaB = 0
                    TotalDecenasB = TotalDecenasB + DemandaB
                Else
                    DemandaNoCubiertaB = DemandaB - stockB
                    TotalDecenasB = TotalDecenasB + stockB
                    stockB = 0
                End If
                RandomDemoraB = Rnd.NextDouble
                nuevaDemoraB(RandomDemoraB)
                CantidadPedidaB = AcumuladorDemandaB
                AcumuladorDemandaB = 0
                ArriboB = diaB + DemoraB
                CostoAlmacenamientoB = CostoAlmacenamiento * stockB
                CostoRupturaB = CostoRuptura * DemandaNoCubiertaB
                CalculoCostoB(CantidadPedidaB)
                CostoTotalB = CostoTotalB + CostoAlmacenamientoB + CostoRupturaB + CostoPedidoB
                ProximoPedidoB = diaB + TiempoDeRepoB
                ContadorDiasDesdePedido = 0
                GrillaB.Rows.Add()
                GrillaB.Rows(diaB).Cells(0).Value = diaB
                GrillaB.Rows(diaB).Cells(1).Value = RandomDemandaB
                GrillaB.Rows(diaB).Cells(2).Value = DemandaB
                GrillaB.Rows(diaB).Cells(3).Value = stockB
                GrillaB.Rows(diaB).Cells(4).Value = DemandaNoCubiertaB
                GrillaB.Rows(diaB).Cells(5).Value = RandomDemoraB
                GrillaB.Rows(diaB).Cells(6).Value = DemoraB
                GrillaB.Rows(diaB).Cells(7).Value = CantidadPedidaB
                GrillaB.Rows(diaB).Cells(8).Value = AcumuladorDemandaB
                GrillaB.Rows(diaB).Cells(9).Value = ArriboB
                GrillaB.Rows(diaB).Cells(10).Value = CostoAlmacenamientoB
                GrillaB.Rows(diaB).Cells(11).Value = CostoRupturaB
                GrillaB.Rows(diaB).Cells(12).Value = CostoPedidoB
                GrillaB.Rows(diaB).Cells(13).Value = CostoTotalB
                GrillaB.Rows(diaB).Cells(14).Value = TotalDecenasB

            Else
                'Dia corriente
                If (diaB > 1) Then


                    If diaB = ArriboB Then
                        stockB = stockB + CantidadPedidaB
                        ArriboB = 0
                        CantidadPedidaB = 0
                    End If
                    RandomDemandaB = Rnd.NextDouble
                    nuevaDemandaB(RandomDemandaB)
                    If stockB >= DemandaB Then
                        stockB = stockB - DemandaB
                        DemandaNoCubiertaB = 0
                        TotalDecenasB = TotalDecenasB + DemandaB
                    Else
                        DemandaNoCubiertaB = DemandaB - stockB
                        TotalDecenasB = TotalDecenasB + stockB
                        stockB = 0
                    End If
                    RandomDemoraB = 0
                    DemoraB = 0
                    If ContadorDiasDesdePedido >= ((TiempoDeRepoB - CantidadDeDiasDemanda)) Then
                        AcumuladorDemandaB = AcumuladorDemandaB + DemandaB
                    End If

                    CostoAlmacenamientoB = CostoAlmacenamiento * stockB
                    CostoRupturaB = CostoRuptura * DemandaNoCubiertaB
                    CostoPedidoB = 0
                    CostoTotalB = CostoTotalB + CostoAlmacenamientoB + CostoRupturaB + CostoPedidoB
                    ContadorDiasDesdePedido = ContadorDiasDesdePedido + 1
                    GrillaB.Rows.Add()
                    GrillaB.Rows(diaB).Cells(0).Value = diaB
                    GrillaB.Rows(diaB).Cells(1).Value = RandomDemandaB
                    GrillaB.Rows(diaB).Cells(2).Value = DemandaB
                    GrillaB.Rows(diaB).Cells(3).Value = stockB
                    GrillaB.Rows(diaB).Cells(4).Value = DemandaNoCubiertaB
                    GrillaB.Rows(diaB).Cells(5).Value = RandomDemoraB
                    GrillaB.Rows(diaB).Cells(6).Value = DemoraB
                    GrillaB.Rows(diaB).Cells(7).Value = CantidadPedidaB
                    GrillaB.Rows(diaB).Cells(8).Value = AcumuladorDemandaB
                    GrillaB.Rows(diaB).Cells(9).Value = ArriboB
                    GrillaB.Rows(diaB).Cells(10).Value = CostoAlmacenamientoB
                    GrillaB.Rows(diaB).Cells(11).Value = CostoRupturaB
                    GrillaB.Rows(diaB).Cells(12).Value = CostoPedidoB
                    GrillaB.Rows(diaB).Cells(13).Value = CostoTotalB
                    GrillaB.Rows(diaB).Cells(14).Value = TotalDecenasB
                End If
            End If
        Next

        'POLITICA C
        'Dia 0
        For diaC = 0 To TiempoDeSim


            If diaC = 0 Then

                RandomDemandaC = 0
                DemandaC = 0
                stockC = 20
                DemandaNoCubiertaC = 0
                RandomDemoraC = 0
                DemoraC = 0
                CantidadPedidaC = 0
                AcumuladorDemandaC = 0
                ArriboC = 0
                CostoAlmacenamientoC = 0
                CostoRupturaC = 0
                CostoPedidoC = 0
                CostoTotalC = 0
                TotalDecenasC = 0

                agrillaC.Rows.Add()
                agrillaC.Rows(0).Cells(0).Value = diaC
                agrillaC.Rows(0).Cells(1).Value = RandomDemandaC
                agrillaC.Rows(0).Cells(2).Value = DemandaC
                agrillaC.Rows(0).Cells(3).Value = stockC
                agrillaC.Rows(0).Cells(4).Value = DemandaNoCubiertaC
                agrillaC.Rows(0).Cells(5).Value = RandomDemoraC
                agrillaC.Rows(0).Cells(6).Value = DemoraC
                agrillaC.Rows(0).Cells(7).Value = CantidadPedidaC
                agrillaC.Rows(0).Cells(8).Value = AcumuladorDemandaC
                agrillaC.Rows(0).Cells(9).Value = ArriboC
                agrillaC.Rows(0).Cells(10).Value = CostoAlmacenamientoC
                agrillaC.Rows(0).Cells(11).Value = CostoRupturaC
                agrillaC.Rows(0).Cells(12).Value = CostoPedidoC
                agrillaC.Rows(0).Cells(13).Value = CostoTotalC
                agrillaC.Rows(0).Cells(14).Value = TotalDecenasC


            End If
            'Dia uno. Hace pedido
            If diaC = 1 Then
                RandomDemandaC = Rnd.NextDouble
                nuevaDemandaC(RandomDemandaC)
                If stockC >= DemandaC Then
                    stockC = stockC - DemandaC
                    DemandaNoCubiertaC = 0
                    TotalDecenasC = DemandaC
                Else
                    DemandaNoCubiertaC = DemandaC - stockC
                    TotalDecenasC = stockC
                    stockC = 0
                End If
                RandomDemoraC = Rnd.NextDouble
                nuevaDemoraC(RandomDemoraC)
                CantidadPedidaC = CantidadRepoC
                AcumuladorDemandaC = AcumuladorDemandaC + DemandaC
                ArriboC = diaC + DemoraC
                CostoAlmacenamientoC = CostoAlmacenamiento * stockC
                CostoRupturaC = CostoRuptura * DemandaNoCubiertaC
                CalculoCostoC(CantidadPedidaC)
                CostoTotalC = CostoAlmacenamientoC + CostoRupturaC + CostoPedidoC
                ProximoPedidoC = diaC + TiempoDeRepoC
                agrillaC.Rows.Add()
                agrillaC.Rows(1).Cells(0).Value = diaC
                agrillaC.Rows(1).Cells(1).Value = RandomDemandaC
                agrillaC.Rows(1).Cells(2).Value = DemandaC
                agrillaC.Rows(1).Cells(3).Value = stockC
                agrillaC.Rows(1).Cells(4).Value = DemandaNoCubiertaC
                agrillaC.Rows(1).Cells(5).Value = RandomDemoraC
                agrillaC.Rows(1).Cells(6).Value = DemoraC
                agrillaC.Rows(1).Cells(7).Value = CantidadPedidaC
                agrillaC.Rows(1).Cells(8).Value = AcumuladorDemandaC
                agrillaC.Rows(1).Cells(9).Value = ArriboC
                agrillaC.Rows(1).Cells(10).Value = CostoAlmacenamientoC
                agrillaC.Rows(1).Cells(11).Value = CostoRupturaC
                agrillaC.Rows(1).Cells(12).Value = CostoPedidoC
                agrillaC.Rows(1).Cells(13).Value = CostoTotalC
                agrillaC.Rows(1).Cells(14).Value = TotalDecenasC
            End If



            'Dia de realizar pedido
            If diaC = ProximoPedidoC And (diaC > 1) Then

                If diaC = ArriboC Then
                    stockC = stockC + CantidadRepoC
                    ArriboC = 0
                End If

                RandomDemandaC = Rnd.NextDouble
                nuevaDemandaC(RandomDemandaC)
                If stockC >= DemandaC Then
                    stockC = stockC - DemandaC
                    DemandaNoCubiertaC = 0
                    TotalDecenasC = TotalDecenasC + DemandaC
                Else
                    DemandaNoCubiertaC = DemandaC - stockC
                    TotalDecenasC = TotalDecenasC + stockC
                    stockC = 0
                End If
                RandomDemoraC = Rnd.NextDouble
                nuevaDemoraC(RandomDemoraC)
                CantidadPedidaC = CantidadRepoC
                AcumuladorDemandaC = AcumuladorDemandaC + DemandaC
                ArriboC = diaC + DemoraC
                CostoAlmacenamientoC = CostoAlmacenamiento * stockC
                CostoRupturaC = CostoRuptura * DemandaNoCubiertaC
                CalculoCostoC(CantidadPedidaC)
                CostoTotalC = CostoTotalC + CostoAlmacenamientoC + CostoRupturaC + CostoPedidoC
                ProximoPedidoC = diaC + TiempoDeRepoC
                agrillaC.Rows.Add()
                agrillaC.Rows(diaC).Cells(0).Value = diaC
                agrillaC.Rows(diaC).Cells(1).Value = RandomDemandaC
                agrillaC.Rows(diaC).Cells(2).Value = DemandaC
                agrillaC.Rows(diaC).Cells(3).Value = stockC
                agrillaC.Rows(diaC).Cells(4).Value = DemandaNoCubiertaC
                agrillaC.Rows(diaC).Cells(5).Value = RandomDemoraC
                agrillaC.Rows(diaC).Cells(6).Value = DemoraC
                agrillaC.Rows(diaC).Cells(7).Value = CantidadPedidaC
                agrillaC.Rows(diaC).Cells(8).Value = AcumuladorDemandaC
                agrillaC.Rows(diaC).Cells(9).Value = ArriboC
                agrillaC.Rows(diaC).Cells(10).Value = CostoAlmacenamientoC
                agrillaC.Rows(diaC).Cells(11).Value = CostoRupturaC
                agrillaC.Rows(diaC).Cells(12).Value = CostoPedidoC
                agrillaC.Rows(diaC).Cells(13).Value = CostoTotalC
                agrillaC.Rows(diaC).Cells(14).Value = TotalDecenasC

            Else
                'Dia corriente
                If (diaC > 1) Then


                    If diaC = ArriboC Then
                        stockC = stockC + CantidadRepoC
                        ArriboC = 0
                    End If
                    RandomDemandaC = Rnd.NextDouble
                    nuevaDemandaC(RandomDemandaC)
                    If stockC >= DemandaC Then
                        stockC = stockC - DemandaC
                        DemandaNoCubiertaC = 0
                        TotalDecenasC = TotalDecenasC + DemandaC
                    Else
                        DemandaNoCubiertaC = DemandaC - stockC
                        TotalDecenasC = TotalDecenasC + stockC
                        stockC = 0
                    End If
                    RandomDemoraC = 0
                    DemoraC = 0
                    CantidadPedidaC = 0
                    AcumuladorDemandaC = AcumuladorDemandaC + DemandaC
                    CostoAlmacenamientoC = CostoAlmacenamiento * stockC
                    CostoRupturaC = CostoRuptura * DemandaNoCubiertaC
                    CostoPedidoC = 0
                    CostoTotalC = CostoTotalC + CostoAlmacenamientoC + CostoRupturaC + CostoPedidoC

                    agrillaC.Rows.Add()
                    agrillaC.Rows(diaC).Cells(0).Value = diaC
                    agrillaC.Rows(diaC).Cells(1).Value = RandomDemandaC
                    agrillaC.Rows(diaC).Cells(2).Value = DemandaC
                    agrillaC.Rows(diaC).Cells(3).Value = stockC
                    agrillaC.Rows(diaC).Cells(4).Value = DemandaNoCubiertaC
                    agrillaC.Rows(diaC).Cells(5).Value = RandomDemoraC
                    agrillaC.Rows(diaC).Cells(6).Value = DemoraC
                    agrillaC.Rows(diaC).Cells(7).Value = CantidadPedidaC
                    agrillaC.Rows(diaC).Cells(8).Value = AcumuladorDemandaC
                    agrillaC.Rows(diaC).Cells(9).Value = ArriboC
                    agrillaC.Rows(diaC).Cells(10).Value = CostoAlmacenamientoC
                    agrillaC.Rows(diaC).Cells(11).Value = CostoRupturaC
                    agrillaC.Rows(diaC).Cells(12).Value = CostoPedidoC
                    agrillaC.Rows(diaC).Cells(13).Value = CostoTotalC
                    agrillaC.Rows(diaC).Cells(14).Value = TotalDecenasC
                End If
            End If
        Next


        'calculo de resultados
        promedioCostoA = CostoTotalA / TiempoDeSim
        promedioCostoB = CostoTotalB / TiempoDeSim
        promedioCostoC = CostoTotalC / TiempoDeSim

        promedioVentaA = TotalDecenasA / TiempoDeSim
        promedioVentaB = TotalDecenasB / TiempoDeSim
        promedioVentaC = TotalDecenasC / TiempoDeSim

        txt_promedio_costoA.Text = promedioCostoA
        txt_promedio_costoB.Text = promedioCostoB
        txt_promedio_costoC.Text = promedioCostoC

        txt_promedio_ventasA.Text = promedioVentaA
        txt_promedio_ventasB.Text = promedioVentaB
        txt_promedio_ventasC.Text = promedioVentaC

    End Sub

    Private Sub Btn_reiniciar_Click(sender As Object, e As EventArgs) Handles btn_reiniciar.Click
        TiempoDeRepoB = 15
        CantidadDeDiasDemanda = 10
        CantidadRepoA = 180
        TiempoDeRepoA = 7
        CantidadRepoC = 100
        TiempoDeRepoC = 5
        TiempoDeSim = 365

        txt_TiempoSim.Text = TiempoDeSim

        txt_TA.Text = TiempoDeRepoA
        txt_RA.Text = CantidadRepoA

        txt_TB.Text = TiempoDeRepoB
        txt_RB.Text = CantidadDeDiasDemanda

        txt_TC.Text = TiempoDeRepoC
        txt_RC.Text = CantidadRepoC

        grillaA.Rows.Clear()
        GrillaB.Rows.Clear()
        agrillaC.Rows.Clear()
        txt_promedio_costoA.Text = ""
        txt_promedio_costoB.Text = ""
        txt_promedio_costoC.Text = ""
        txt_promedio_ventasA.Text = ""
        txt_promedio_ventasB.Text = ""
        txt_promedio_ventasC.Text = ""
        personalizar.Enabled = True
        btn_reiniciar.Enabled = False
        Button1.Enabled = True
        personalizar.Checked = False
    End Sub

    Private Sub Personalizar_CheckedChanged(sender As Object, e As EventArgs) Handles personalizar.CheckedChanged

        If personalizar.Checked = True Then
            txt_TiempoSim.Enabled = True
            txt_RA.Enabled = True
            txt_TA.Enabled = True
            txt_RB.Enabled = True
            txt_TB.Enabled = True
            txt_RC.Enabled = True
            txt_TC.Enabled = True

        Else
            txt_TiempoSim.Text = TiempoDeSim

            txt_TA.Text = TiempoDeRepoA
            txt_RA.Text = CantidadRepoA

            txt_TB.Text = TiempoDeRepoB
            txt_RB.Text = CantidadDeDiasDemanda

            txt_TC.Text = TiempoDeRepoC
            txt_RC.Text = CantidadRepoC

            txt_TiempoSim.Enabled = False
            txt_RA.Enabled = False
            txt_TA.Enabled = False
            txt_RB.Enabled = False
            txt_TB.Enabled = False
            txt_RC.Enabled = False
            txt_TC.Enabled = False

        End If
    End Sub


End Class
