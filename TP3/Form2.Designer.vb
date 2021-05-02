<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_N = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rd_5 = New System.Windows.Forms.RadioButton()
        Me.rd_10 = New System.Windows.Forms.RadioButton()
        Me.rd_12 = New System.Windows.Forms.RadioButton()
        Me.rd_8 = New System.Windows.Forms.RadioButton()
        Me.tablon = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inferior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Superior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcalse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acu = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.esp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_min = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_max = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_media = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_lambda = New System.Windows.Forms.TextBox()
        Me.TablaChi = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cacc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_calc = New System.Windows.Forms.TextBox()
        Me.txt_tabla = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_generar)
        Me.GroupBox1.Controls.Add(Me.rd_5)
        Me.GroupBox1.Controls.Add(Me.rd_10)
        Me.GroupBox1.Controls.Add(Me.rd_12)
        Me.GroupBox1.Controls.Add(Me.rd_8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_N)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 124)
        Me.GroupBox1.TabIndex = 2
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
        'tablon
        '
        Me.tablon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Inferior, Me.Superior, Me.Mcalse})
        Me.tablon.Location = New System.Drawing.Point(14, 247)
        Me.tablon.Name = "tablon"
        Me.tablon.Size = New System.Drawing.Size(303, 328)
        Me.tablon.TabIndex = 3
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
        'Acu
        '
        Me.Acu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Acu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Acu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.ob, Me.prob, Me.esp})
        Me.Acu.Location = New System.Drawing.Point(334, 35)
        Me.Acu.Name = "Acu"
        Me.Acu.Size = New System.Drawing.Size(607, 259)
        Me.Acu.TabIndex = 4
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
        'btn_clean
        '
        Me.btn_clean.Location = New System.Drawing.Point(217, 577)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(100, 46)
        Me.btn_clean.TabIndex = 8
        Me.btn_clean.Text = "Limpiar"
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Min"
        '
        'txt_min
        '
        Me.txt_min.Enabled = False
        Me.txt_min.Location = New System.Drawing.Point(42, 142)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(100, 20)
        Me.txt_min.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Max"
        '
        'txt_max
        '
        Me.txt_max.Enabled = False
        Me.txt_max.Location = New System.Drawing.Point(42, 168)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(100, 20)
        Me.txt_max.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Media"
        '
        'txt_media
        '
        Me.txt_media.Enabled = False
        Me.txt_media.Location = New System.Drawing.Point(217, 142)
        Me.txt_media.Name = "txt_media"
        Me.txt_media.Size = New System.Drawing.Size(100, 20)
        Me.txt_media.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Lambda"
        '
        'txt_lambda
        '
        Me.txt_lambda.Enabled = False
        Me.txt_lambda.Location = New System.Drawing.Point(217, 168)
        Me.txt_lambda.Name = "txt_lambda"
        Me.txt_lambda.Size = New System.Drawing.Size(100, 20)
        Me.txt_lambda.TabIndex = 16
        '
        'TablaChi
        '
        Me.TablaChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablaChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.asd, Me.c3, Me.c4, Me.c5, Me.Cacc})
        Me.TablaChi.Location = New System.Drawing.Point(334, 316)
        Me.TablaChi.Name = "TablaChi"
        Me.TablaChi.Size = New System.Drawing.Size(607, 259)
        Me.TablaChi.TabIndex = 17
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
        'txt_calc
        '
        Me.txt_calc.Enabled = False
        Me.txt_calc.Location = New System.Drawing.Point(1050, 481)
        Me.txt_calc.Name = "txt_calc"
        Me.txt_calc.Size = New System.Drawing.Size(236, 20)
        Me.txt_calc.TabIndex = 18
        '
        'txt_tabla
        '
        Me.txt_tabla.Enabled = False
        Me.txt_tabla.Location = New System.Drawing.Point(1050, 507)
        Me.txt_tabla.Name = "txt_tabla"
        Me.txt_tabla.Size = New System.Drawing.Size(236, 20)
        Me.txt_tabla.TabIndex = 19
        '
        'txt_resultado
        '
        Me.txt_resultado.Enabled = False
        Me.txt_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resultado.Location = New System.Drawing.Point(1050, 533)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(236, 26)
        Me.txt_resultado.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(972, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Chi Calculado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(972, 510)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Chi Tabla"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(972, 536)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Resultado"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(959, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(373, 414)
        Me.Chart1.TabIndex = 24
        Me.Chart1.Text = "Chart1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Intervalos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(331, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Tabla de frecuencias"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Tabla de chi cuadrado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(956, 443)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(412, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Hipótesis: Los números aleatorios generados tienen distribución Exponencial Negat" &
    "iva"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 635)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_tabla)
        Me.Controls.Add(Me.txt_calc)
        Me.Controls.Add(Me.TablaChi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_lambda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_media)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_max)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_min)
        Me.Controls.Add(Me.btn_clean)
        Me.Controls.Add(Me.Acu)
        Me.Controls.Add(Me.tablon)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Exponencial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_N As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd_10 As RadioButton
    Friend WithEvents rd_12 As RadioButton
    Friend WithEvents rd_8 As RadioButton
    Friend WithEvents btn_generar As Button
    Friend WithEvents rd_5 As RadioButton
    Friend WithEvents tablon As DataGridView
    Friend WithEvents Acu As DataGridView
    Friend WithEvents btn_clean As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_min As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_max As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_media As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_lambda As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Inferior As DataGridViewTextBoxColumn
    Friend WithEvents Superior As DataGridViewTextBoxColumn
    Friend WithEvents Mcalse As DataGridViewTextBoxColumn
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents ob As DataGridViewTextBoxColumn
    Friend WithEvents prob As DataGridViewTextBoxColumn
    Friend WithEvents esp As DataGridViewTextBoxColumn
    Friend WithEvents TablaChi As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents asd As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents Cacc As DataGridViewTextBoxColumn
    Friend WithEvents txt_calc As TextBox
    Friend WithEvents txt_tabla As TextBox
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
