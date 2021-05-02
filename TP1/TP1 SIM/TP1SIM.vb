Public Class Form1

    Dim a As Integer
    Dim c As Integer
    Dim m As Integer
    Dim s As Integer
    Dim n As Integer = 0
    Dim xi As Double

    Private Sub Generar(sender As Object, e As EventArgs) Handles btnGenerar.Click

        'Genera 20 números aleatorios

        LoadBotones()
        btnLineal.Enabled = False
        btnMultiplicativo.Enabled = False

        Dim rnd As Double

        For i = 1 To 20
            rnd = GenerarAleatorio()
            n = n + 1
            dgvLista.Rows.Add(New Object() {i, rnd})


        Next

    End Sub

    Private Sub Agregar(sender As Object, e As EventArgs) Handles btnAgregar.Click

        'Agrega un nuevo número aleatorio

        Dim rnd As Double
        rnd = GenerarAleatorio()
        n = n + 1
        dgvLista.Rows.Add(New Object() {n, rnd})
        dgvLista.FirstDisplayedScrollingRowIndex() = n - 9 'Scrollea solo

    End Sub

    Public Function GenerarAleatorio() As Double

        'Función de cálculo de números aleatorios


        Dim rnd

        If n = 0 Then
            xi = ((a * s) + c) Mod m
        Else

            xi = ((a * xi) + c) Mod m
        End If

        rnd = xi / m
        Return rnd

    End Function

    Private Sub LoadBotones()

        'Habilita o deshabilita los botones dependiendo del último estado

        If btnGenerar.Enabled = True Then
            btnGenerar.Enabled = False
            btnAgregar.Enabled = True
            btnLimpiar.Enabled = True
        Else
            btnGenerar.Enabled = True
            btnAgregar.Enabled = False
            btnLimpiar.Enabled = False
        End If

    End Sub

    Private Sub Limpiar(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Reestablece el form a su estado inicial

        dgvLista.Rows.Clear()
        LoadBotones()
        txtA.Text = 0
        txtC.Text = 0
        txtM.Text = 0
        txtS.Text = 0
        txtA.Focus()
        btnLineal.Enabled = True
        btnMultiplicativo.Enabled = True
        btnLineal.Checked = True
        txtC.Enabled = True
        xi = 0
        n = 0

    End Sub



    'Métodos LOST FOCUS: Cargan el valor de una variable cuando este se modifica
    Private Sub txtA_LostFocus(sender As Object, e As EventArgs) Handles txtA.LostFocus
        a = txtA.Text
    End Sub

    Private Sub txtC_LostFocus(sender As Object, e As EventArgs) Handles txtC.LostFocus
        c = txtC.Text
    End Sub

    Private Sub txtM_LostFocus(sender As Object, e As EventArgs) Handles txtM.LostFocus
        m = txtM.Text
    End Sub

    Private Sub txtS_LostFocus(sender As Object, e As EventArgs) Handles txtS.LostFocus
        s = txtS.Text
    End Sub

    Private Sub btnMultiplicativo_Click(sender As Object, e As EventArgs) Handles btnMultiplicativo.Click
        txtC.Text = 0
        c = txtC.Text
        txtC.Enabled = False
    End Sub

    Private Sub btnLineal_Click(sender As Object, e As EventArgs) Handles btnLineal.Click
        txtC.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_chi_Click(sender As Object, e As EventArgs) Handles btn_chi.Click
        Chi.Show()
    End Sub

    'Validaciones
    Private Sub txtA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtA.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtC.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtM.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtS.KeyPress
        If Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
