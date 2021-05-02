<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chi
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_k = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_m = New System.Windows.Forms.TextBox()
        Me.rdb_windows = New System.Windows.Forms.RadioButton()
        Me.rdb_lineal = New System.Windows.Forms.RadioButton()
        Me.txt_ml = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_s = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.tablon = New System.Windows.Forms.DataGridView()
        Me.int = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acu = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txt_resul = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(337, 80)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(78, 23)
        Me.btn_generar.TabIndex = 1
        Me.btn_generar.Text = "Realizar Test"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_k)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_m)
        Me.GroupBox1.Controls.Add(Me.rdb_windows)
        Me.GroupBox1.Controls.Add(Me.btn_generar)
        Me.GroupBox1.Controls.Add(Me.rdb_lineal)
        Me.GroupBox1.Controls.Add(Me.txt_ml)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_c)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_s)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_a)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 115)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test de Chi Cuadrado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 413
        Me.Label5.Text = "m"
        '
        'txt_k
        '
        Me.txt_k.Location = New System.Drawing.Point(97, 56)
        Me.txt_k.Name = "txt_k"
        Me.txt_k.Size = New System.Drawing.Size(45, 20)
        Me.txt_k.TabIndex = 412
        Me.txt_k.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 414
        Me.Label6.Text = "k"
        '
        'txt_m
        '
        Me.txt_m.Location = New System.Drawing.Point(26, 56)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.Size = New System.Drawing.Size(45, 20)
        Me.txt_m.TabIndex = 411
        Me.txt_m.Text = "0"
        '
        'rdb_windows
        '
        Me.rdb_windows.AutoSize = True
        Me.rdb_windows.Checked = True
        Me.rdb_windows.Location = New System.Drawing.Point(6, 19)
        Me.rdb_windows.Name = "rdb_windows"
        Me.rdb_windows.Size = New System.Drawing.Size(125, 17)
        Me.rdb_windows.TabIndex = 410
        Me.rdb_windows.TabStop = True
        Me.rdb_windows.Text = "Método del Lenguaje"
        Me.rdb_windows.UseVisualStyleBackColor = True
        '
        'rdb_lineal
        '
        Me.rdb_lineal.AutoSize = True
        Me.rdb_lineal.Location = New System.Drawing.Point(137, 19)
        Me.rdb_lineal.Name = "rdb_lineal"
        Me.rdb_lineal.Size = New System.Drawing.Size(154, 17)
        Me.rdb_lineal.TabIndex = 405
        Me.rdb_lineal.Text = "Método Congruencial Mixto"
        Me.rdb_lineal.UseVisualStyleBackColor = True
        '
        'txt_ml
        '
        Me.txt_ml.Location = New System.Drawing.Point(181, 82)
        Me.txt_ml.Name = "txt_ml"
        Me.txt_ml.Size = New System.Drawing.Size(45, 20)
        Me.txt_ml.TabIndex = 403
        Me.txt_ml.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 406
        Me.Label1.Text = "A"
        '
        'txt_c
        '
        Me.txt_c.Location = New System.Drawing.Point(97, 82)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(45, 20)
        Me.txt_c.TabIndex = 402
        Me.txt_c.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 407
        Me.Label2.Text = "C"
        '
        'txt_s
        '
        Me.txt_s.Location = New System.Drawing.Point(286, 82)
        Me.txt_s.Name = "txt_s"
        Me.txt_s.Size = New System.Drawing.Size(45, 20)
        Me.txt_s.TabIndex = 404
        Me.txt_s.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 408
        Me.Label3.Text = "mod"
        '
        'txt_a
        '
        Me.txt_a.Location = New System.Drawing.Point(26, 82)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(45, 20)
        Me.txt_a.TabIndex = 401
        Me.txt_a.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 409
        Me.Label4.Text = "Semilla"
        '
        'btn_clean
        '
        Me.btn_clean.Location = New System.Drawing.Point(669, 446)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(75, 23)
        Me.btn_clean.TabIndex = 411
        Me.btn_clean.Text = "Limpiar"
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'tablon
        '
        Me.tablon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.int, Me.Column2, Me.Column1})
        Me.tablon.Location = New System.Drawing.Point(12, 133)
        Me.tablon.Name = "tablon"
        Me.tablon.Size = New System.Drawing.Size(221, 301)
        Me.tablon.TabIndex = 412
        '
        'int
        '
        Me.int.HeaderText = "Intervalo"
        Me.int.Name = "int"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Inferior"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Superior"
        Me.Column1.Name = "Column1"
        '
        'Acu
        '
        Me.Acu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Acu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Acu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.asd, Me.Column4, Me.Column5, Me.Column6})
        Me.Acu.Location = New System.Drawing.Point(239, 133)
        Me.Acu.Name = "Acu"
        Me.Acu.Size = New System.Drawing.Size(507, 301)
        Me.Acu.TabIndex = 413
        '
        'Column3
        '
        Me.Column3.HeaderText = "Intervalo"
        Me.Column3.Name = "Column3"
        '
        'asd
        '
        Me.asd.HeaderText = "f Obtenida"
        Me.asd.Name = "asd"
        '
        'Column4
        '
        Me.Column4.HeaderText = "f Esperada"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "C"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "C Acumulado"
        Me.Column6.Name = "Column6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(539, 451)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 415
        Me.Label7.Text = "Resultado"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(786, 47)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(482, 422)
        Me.Chart1.TabIndex = 416
        Me.Chart1.Text = "Distribucion"
        Title1.Name = "Distribucion Real"
        Me.Chart1.Titles.Add(Title1)
        '
        'txt_resul
        '
        Me.txt_resul.BackColor = System.Drawing.Color.White
        Me.txt_resul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_resul.Location = New System.Drawing.Point(600, 447)
        Me.txt_resul.Name = "txt_resul"
        Me.txt_resul.Size = New System.Drawing.Size(63, 20)
        Me.txt_resul.TabIndex = 417
        Me.txt_resul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 480)
        Me.Controls.Add(Me.txt_resul)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Acu)
        Me.Controls.Add(Me.tablon)
        Me.Controls.Add(Me.btn_clean)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Chi"
        Me.Text = "Test de Chi Cuadrado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tablon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_k As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_m As TextBox
    Friend WithEvents rdb_windows As RadioButton
    Friend WithEvents rdb_lineal As RadioButton
    Friend WithEvents txt_ml As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_c As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_s As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_a As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_clean As Button
    Friend WithEvents tablon As DataGridView
    Friend WithEvents Acu As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents int As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_resul As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents asd As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
