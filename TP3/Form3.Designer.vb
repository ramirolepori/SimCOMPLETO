<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_desviacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_media = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_max = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_min = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rd_5 = New System.Windows.Forms.RadioButton()
        Me.rd_10 = New System.Windows.Forms.RadioButton()
        Me.rd_12 = New System.Windows.Forms.RadioButton()
        Me.rd_8 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_N = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TablaChi = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cacc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acu = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.esp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.txt_tabla = New System.Windows.Forms.TextBox()
        Me.txt_calc = New System.Windows.Forms.TextBox()
        Me.tablon = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcalse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TablaChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Desviación"
        '
        'txt_desviacion
        '
        Me.txt_desviacion.Enabled = False
        Me.txt_desviacion.Location = New System.Drawing.Point(237, 173)
        Me.txt_desviacion.Name = "txt_desviacion"
        Me.txt_desviacion.Size = New System.Drawing.Size(43, 20)
        Me.txt_desviacion.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Media"
        '
        'txt_media
        '
        Me.txt_media.Enabled = False
        Me.txt_media.Location = New System.Drawing.Point(237, 147)
        Me.txt_media.Name = "txt_media"
        Me.txt_media.Size = New System.Drawing.Size(43, 20)
        Me.txt_media.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Max"
        '
        'txt_max
        '
        Me.txt_max.Enabled = False
        Me.txt_max.Location = New System.Drawing.Point(39, 172)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(100, 20)
        Me.txt_max.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Min"
        '
        'txt_min
        '
        Me.txt_min.Enabled = False
        Me.txt_min.Location = New System.Drawing.Point(39, 146)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(100, 20)
        Me.txt_min.TabIndex = 19
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 124)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(45, 61)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(100, 46)
        Me.btn_generar.TabIndex = 3
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'rd_5
        '
        Me.rd_5.AutoSize = True
        Me.rd_5.Location = New System.Drawing.Point(177, 21)
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
        Me.rd_10.Location = New System.Drawing.Point(177, 67)
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
        Me.rd_12.Location = New System.Drawing.Point(177, 90)
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
        Me.rd_8.Location = New System.Drawing.Point(177, 44)
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
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N"
        '
        'txt_N
        '
        Me.txt_N.Location = New System.Drawing.Point(45, 22)
        Me.txt_N.Name = "txt_N"
        Me.txt_N.Size = New System.Drawing.Size(100, 20)
        Me.txt_N.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(317, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Tabla de chi cuadrado:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(317, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Tabla de frecuencias"
        '
        'TablaChi
        '
        Me.TablaChi.AllowUserToAddRows = False
        Me.TablaChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablaChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.asd, Me.c3, Me.c4, Me.c5, Me.Cacc})
        Me.TablaChi.Location = New System.Drawing.Point(320, 316)
        Me.TablaChi.Name = "TablaChi"
        Me.TablaChi.Size = New System.Drawing.Size(607, 259)
        Me.TablaChi.TabIndex = 29
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
        'Acu
        '
        Me.Acu.AllowUserToAddRows = False
        Me.Acu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Acu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Acu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.ob, Me.prob, Me.esp})
        Me.Acu.Location = New System.Drawing.Point(320, 28)
        Me.Acu.Name = "Acu"
        Me.Acu.Size = New System.Drawing.Size(607, 259)
        Me.Acu.TabIndex = 28
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Intervalos:"
        '
        'btn_clean
        '
        Me.btn_clean.Location = New System.Drawing.Point(211, 585)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(100, 46)
        Me.btn_clean.TabIndex = 33
        Me.btn_clean.Text = "Limpiar"
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(933, 28)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(373, 414)
        Me.Chart1.TabIndex = 41
        Me.Chart1.Text = "Chart1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(946, 552)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Resultado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(946, 526)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Chi Tabla"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(946, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Chi Calculado"
        '
        'txt_resultado
        '
        Me.txt_resultado.Enabled = False
        Me.txt_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resultado.Location = New System.Drawing.Point(1024, 549)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(236, 26)
        Me.txt_resultado.TabIndex = 37
        '
        'txt_tabla
        '
        Me.txt_tabla.Enabled = False
        Me.txt_tabla.Location = New System.Drawing.Point(1024, 523)
        Me.txt_tabla.Name = "txt_tabla"
        Me.txt_tabla.Size = New System.Drawing.Size(236, 20)
        Me.txt_tabla.TabIndex = 36
        '
        'txt_calc
        '
        Me.txt_calc.Enabled = False
        Me.txt_calc.Location = New System.Drawing.Point(1024, 497)
        Me.txt_calc.Name = "txt_calc"
        Me.txt_calc.Size = New System.Drawing.Size(236, 20)
        Me.txt_calc.TabIndex = 35
        '
        'tablon
        '
        Me.tablon.AllowUserToAddRows = False
        Me.tablon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Mcalse})
        Me.tablon.Location = New System.Drawing.Point(8, 223)
        Me.tablon.Name = "tablon"
        Me.tablon.Size = New System.Drawing.Size(303, 352)
        Me.tablon.TabIndex = 42
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Intervalo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Inferior"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Superior"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Mcalse
        '
        Me.Mcalse.HeaderText = "Marca de Clase"
        Me.Mcalse.Name = "Mcalse"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(949, 460)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(341, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Hipótesis: Los números aleatorios generados tienen distribución Normal"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 643)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tablon)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_tabla)
        Me.Controls.Add(Me.txt_calc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_clean)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_desviacion)
        Me.Controls.Add(Me.TablaChi)
        Me.Controls.Add(Me.Acu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_media)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_max)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_min)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Normal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TablaChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txt_desviacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_media As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_max As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_min As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_generar As Button
    Friend WithEvents rd_5 As RadioButton
    Friend WithEvents rd_10 As RadioButton
    Friend WithEvents rd_12 As RadioButton
    Friend WithEvents rd_8 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_N As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TablaChi As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents asd As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents Cacc As DataGridViewTextBoxColumn
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents ob As DataGridViewTextBoxColumn
    Friend WithEvents prob As DataGridViewTextBoxColumn
    Friend WithEvents esp As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_clean As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents txt_tabla As TextBox
    Friend WithEvents txt_calc As TextBox
    Friend WithEvents tablon As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Mcalse As DataGridViewTextBoxColumn
    Friend WithEvents Acu As DataGridView
    Friend WithEvents Label12 As Label
End Class
