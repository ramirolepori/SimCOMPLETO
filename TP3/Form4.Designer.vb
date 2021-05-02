<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rd_5 = New System.Windows.Forms.RadioButton()
        Me.rd_10 = New System.Windows.Forms.RadioButton()
        Me.rd_12 = New System.Windows.Forms.RadioButton()
        Me.rd_8 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_N = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_max = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_min = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.txt_tabla = New System.Windows.Forms.TextBox()
        Me.txt_calc = New System.Windows.Forms.TextBox()
        Me.TablaChi = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cacc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.Acu = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.esp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tablon = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inferior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Superior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcalse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_generar)
        Me.GroupBox1.Controls.Add(Me.rd_5)
        Me.GroupBox1.Controls.Add(Me.rd_10)
        Me.GroupBox1.Controls.Add(Me.rd_12)
        Me.GroupBox1.Controls.Add(Me.rd_8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_N)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 124)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(27, 63)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(100, 46)
        Me.btn_generar.TabIndex = 3
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'rd_5
        '
        Me.rd_5.AutoSize = True
        Me.rd_5.Location = New System.Drawing.Point(159, 23)
        Me.rd_5.Name = "rd_5"
        Me.rd_5.Size = New System.Drawing.Size(80, 17)
        Me.rd_5.TabIndex = 6
        Me.rd_5.TabStop = True
        Me.rd_5.Text = "5 Intervalos"
        Me.rd_5.UseVisualStyleBackColor = True
        '
        'rd_10
        '
        Me.rd_10.AutoSize = True
        Me.rd_10.Location = New System.Drawing.Point(159, 69)
        Me.rd_10.Name = "rd_10"
        Me.rd_10.Size = New System.Drawing.Size(86, 17)
        Me.rd_10.TabIndex = 5
        Me.rd_10.TabStop = True
        Me.rd_10.Text = "10 Intervalos"
        Me.rd_10.UseVisualStyleBackColor = True
        '
        'rd_12
        '
        Me.rd_12.AutoSize = True
        Me.rd_12.Location = New System.Drawing.Point(159, 92)
        Me.rd_12.Name = "rd_12"
        Me.rd_12.Size = New System.Drawing.Size(86, 17)
        Me.rd_12.TabIndex = 4
        Me.rd_12.TabStop = True
        Me.rd_12.Text = "12 Intervalos"
        Me.rd_12.UseVisualStyleBackColor = True
        '
        'rd_8
        '
        Me.rd_8.AutoSize = True
        Me.rd_8.Location = New System.Drawing.Point(159, 46)
        Me.rd_8.Name = "rd_8"
        Me.rd_8.Size = New System.Drawing.Size(80, 17)
        Me.rd_8.TabIndex = 3
        Me.rd_8.TabStop = True
        Me.rd_8.Text = "8 Intervalos"
        Me.rd_8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N"
        '
        'txt_N
        '
        Me.txt_N.Location = New System.Drawing.Point(27, 24)
        Me.txt_N.Name = "txt_N"
        Me.txt_N.Size = New System.Drawing.Size(100, 20)
        Me.txt_N.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "B"
        '
        'txt_b
        '
        Me.txt_b.Enabled = False
        Me.txt_b.Location = New System.Drawing.Point(242, 211)
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(100, 20)
        Me.txt_b.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "A"
        '
        'txt_a
        '
        Me.txt_a.Enabled = False
        Me.txt_a.Location = New System.Drawing.Point(242, 185)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(100, 20)
        Me.txt_a.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Max"
        '
        'txt_max
        '
        Me.txt_max.Enabled = False
        Me.txt_max.Location = New System.Drawing.Point(67, 211)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(100, 20)
        Me.txt_max.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Min"
        '
        'txt_min
        '
        Me.txt_min.Enabled = False
        Me.txt_min.Location = New System.Drawing.Point(67, 185)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(100, 20)
        Me.txt_min.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(345, 293)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Tabla de chi cuadrado:"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(973, 8)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(373, 414)
        Me.Chart1.TabIndex = 38
        Me.Chart1.Text = "Chart1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(986, 532)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Resultado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(986, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Chi Tabla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(986, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Chi Calculado"
        '
        'txt_resultado
        '
        Me.txt_resultado.Enabled = False
        Me.txt_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resultado.Location = New System.Drawing.Point(1064, 529)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(236, 26)
        Me.txt_resultado.TabIndex = 34
        '
        'txt_tabla
        '
        Me.txt_tabla.Enabled = False
        Me.txt_tabla.Location = New System.Drawing.Point(1064, 503)
        Me.txt_tabla.Name = "txt_tabla"
        Me.txt_tabla.Size = New System.Drawing.Size(236, 20)
        Me.txt_tabla.TabIndex = 33
        '
        'txt_calc
        '
        Me.txt_calc.Enabled = False
        Me.txt_calc.Location = New System.Drawing.Point(1064, 477)
        Me.txt_calc.Name = "txt_calc"
        Me.txt_calc.Size = New System.Drawing.Size(236, 20)
        Me.txt_calc.TabIndex = 32
        '
        'TablaChi
        '
        Me.TablaChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablaChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.asd, Me.c3, Me.c4, Me.c5, Me.Cacc})
        Me.TablaChi.Location = New System.Drawing.Point(348, 312)
        Me.TablaChi.Name = "TablaChi"
        Me.TablaChi.Size = New System.Drawing.Size(607, 259)
        Me.TablaChi.TabIndex = 31
        '
        'Column2
        '
        Me.Column2.HeaderText = "Desde"
        Me.Column2.Name = "Column2"
        '
        'asd
        '
        Me.asd.HeaderText = "Hasta"
        Me.asd.Name = "asd"
        '
        'c3
        '
        Me.c3.HeaderText = "Frec. Observada"
        Me.c3.Name = "c3"
        '
        'c4
        '
        Me.c4.HeaderText = "Frec. Esperada"
        Me.c4.Name = "c4"
        '
        'c5
        '
        Me.c5.HeaderText = "C"
        Me.c5.Name = "c5"
        '
        'Cacc
        '
        Me.Cacc.HeaderText = "C Acc"
        Me.Cacc.Name = "Cacc"
        '
        'btn_clean
        '
        Me.btn_clean.Location = New System.Drawing.Point(116, 577)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(100, 46)
        Me.btn_clean.TabIndex = 30
        Me.btn_clean.Text = "Limpiar"
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'Acu
        '
        Me.Acu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Acu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Acu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.ob, Me.prob, Me.esp})
        Me.Acu.Location = New System.Drawing.Point(348, 31)
        Me.Acu.Name = "Acu"
        Me.Acu.Size = New System.Drawing.Size(607, 259)
        Me.Acu.TabIndex = 29
        '
        'num
        '
        Me.num.HeaderText = "Num"
        Me.num.Name = "num"
        '
        'ob
        '
        Me.ob.HeaderText = "Frec. Observada"
        Me.ob.Name = "ob"
        '
        'prob
        '
        Me.prob.HeaderText = "P()c / mc"
        Me.prob.Name = "prob"
        '
        'esp
        '
        Me.esp.HeaderText = "Frec. Esperada"
        Me.esp.Name = "esp"
        '
        'tablon
        '
        Me.tablon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Inferior, Me.Superior, Me.Mcalse})
        Me.tablon.Location = New System.Drawing.Point(28, 243)
        Me.tablon.Name = "tablon"
        Me.tablon.Size = New System.Drawing.Size(303, 328)
        Me.tablon.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = "Intervalo"
        Me.Column1.Name = "Column1"
        '
        'Inferior
        '
        Me.Inferior.HeaderText = "Inferior"
        Me.Inferior.Name = "Inferior"
        '
        'Superior
        '
        Me.Superior.HeaderText = "Superior"
        Me.Superior.Name = "Superior"
        '
        'Mcalse
        '
        Me.Mcalse.HeaderText = "Marca de Clase"
        Me.Mcalse.Name = "Mcalse"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(970, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(350, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Hipótesis: Los números aleatorios generados tienen distribución Uniforme"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 631)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_tabla)
        Me.Controls.Add(Me.txt_calc)
        Me.Controls.Add(Me.TablaChi)
        Me.Controls.Add(Me.btn_clean)
        Me.Controls.Add(Me.Acu)
        Me.Controls.Add(Me.tablon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_b)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_a)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_max)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_min)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Uniforme"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_generar As Button
    Friend WithEvents rd_5 As RadioButton
    Friend WithEvents rd_10 As RadioButton
    Friend WithEvents rd_12 As RadioButton
    Friend WithEvents rd_8 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_N As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_b As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_a As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_max As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_min As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents txt_tabla As TextBox
    Friend WithEvents txt_calc As TextBox
    Friend WithEvents TablaChi As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents asd As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents Cacc As DataGridViewTextBoxColumn
    Friend WithEvents btn_clean As Button
    Friend WithEvents Acu As DataGridView
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents ob As DataGridViewTextBoxColumn
    Friend WithEvents prob As DataGridViewTextBoxColumn
    Friend WithEvents esp As DataGridViewTextBoxColumn
    Friend WithEvents tablon As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Inferior As DataGridViewTextBoxColumn
    Friend WithEvents Superior As DataGridViewTextBoxColumn
    Friend WithEvents Mcalse As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
End Class
