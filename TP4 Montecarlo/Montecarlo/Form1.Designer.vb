<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabProba = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_sim = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_n = New System.Windows.Forms.TextBox()
        Me.gp_1 = New System.Windows.Forms.GroupBox()
        Me.rdb_4p = New System.Windows.Forms.RadioButton()
        Me.rdb_3p = New System.Windows.Forms.RadioButton()
        Me.rdb_2p = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdb_1p = New System.Windows.Forms.RadioButton()
        Me.txt_Amostrar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.TabSim = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_uPromedio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_uTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TabProba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_1.SuspendLayout()
        CType(Me.TabSim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabProba
        '
        Me.TabProba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TabProba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabProba.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.TabProba.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabProba.Location = New System.Drawing.Point(6, 181)
        Me.TabProba.Name = "TabProba"
        Me.TabProba.ReadOnly = True
        Me.TabProba.Size = New System.Drawing.Size(364, 382)
        Me.TabProba.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Pasajeros que se presentan"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Probabilidad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btn_sim
        '
        Me.btn_sim.Location = New System.Drawing.Point(9, 139)
        Me.btn_sim.Name = "btn_sim"
        Me.btn_sim.Size = New System.Drawing.Size(154, 23)
        Me.btn_sim.TabIndex = 1
        Me.btn_sim.Text = "Simular"
        Me.btn_sim.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad de vuelos"
        '
        'txt_n
        '
        Me.txt_n.Location = New System.Drawing.Point(9, 43)
        Me.txt_n.Name = "txt_n"
        Me.txt_n.Size = New System.Drawing.Size(154, 20)
        Me.txt_n.TabIndex = 3
        '
        'gp_1
        '
        Me.gp_1.Controls.Add(Me.rdb_4p)
        Me.gp_1.Controls.Add(Me.btn_sim)
        Me.gp_1.Controls.Add(Me.rdb_3p)
        Me.gp_1.Controls.Add(Me.rdb_2p)
        Me.gp_1.Controls.Add(Me.Label3)
        Me.gp_1.Controls.Add(Me.rdb_1p)
        Me.gp_1.Controls.Add(Me.txt_Amostrar)
        Me.gp_1.Controls.Add(Me.Label2)
        Me.gp_1.Controls.Add(Me.TabProba)
        Me.gp_1.Controls.Add(Me.txt_n)
        Me.gp_1.Controls.Add(Me.Label1)
        Me.gp_1.Location = New System.Drawing.Point(13, 9)
        Me.gp_1.Name = "gp_1"
        Me.gp_1.Size = New System.Drawing.Size(376, 569)
        Me.gp_1.TabIndex = 4
        Me.gp_1.TabStop = False
        Me.gp_1.Text = "Configuracion"
        '
        'rdb_4p
        '
        Me.rdb_4p.AutoSize = True
        Me.rdb_4p.Location = New System.Drawing.Point(203, 103)
        Me.rdb_4p.Name = "rdb_4p"
        Me.rdb_4p.Size = New System.Drawing.Size(80, 17)
        Me.rdb_4p.TabIndex = 10
        Me.rdb_4p.Text = "4 Pasajeros"
        Me.rdb_4p.UseVisualStyleBackColor = True
        '
        'rdb_3p
        '
        Me.rdb_3p.AutoSize = True
        Me.rdb_3p.Location = New System.Drawing.Point(203, 80)
        Me.rdb_3p.Name = "rdb_3p"
        Me.rdb_3p.Size = New System.Drawing.Size(80, 17)
        Me.rdb_3p.TabIndex = 9
        Me.rdb_3p.Text = "3 Pasajeros"
        Me.rdb_3p.UseVisualStyleBackColor = True
        '
        'rdb_2p
        '
        Me.rdb_2p.AutoSize = True
        Me.rdb_2p.Location = New System.Drawing.Point(203, 57)
        Me.rdb_2p.Name = "rdb_2p"
        Me.rdb_2p.Size = New System.Drawing.Size(80, 17)
        Me.rdb_2p.TabIndex = 8
        Me.rdb_2p.Text = "2 Pasajeros"
        Me.rdb_2p.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sobreventa permitida:"
        '
        'rdb_1p
        '
        Me.rdb_1p.AutoSize = True
        Me.rdb_1p.Checked = True
        Me.rdb_1p.Location = New System.Drawing.Point(203, 34)
        Me.rdb_1p.Name = "rdb_1p"
        Me.rdb_1p.Size = New System.Drawing.Size(80, 17)
        Me.rdb_1p.TabIndex = 6
        Me.rdb_1p.TabStop = True
        Me.rdb_1p.Text = "1 Pasajeros"
        Me.rdb_1p.UseVisualStyleBackColor = True
        '
        'txt_Amostrar
        '
        Me.txt_Amostrar.Location = New System.Drawing.Point(9, 91)
        Me.txt_Amostrar.Name = "txt_Amostrar"
        Me.txt_Amostrar.Size = New System.Drawing.Size(154, 20)
        Me.txt_Amostrar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mostrar ultimos"
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(1189, 544)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(154, 23)
        Me.btn_reset.TabIndex = 11
        Me.btn_reset.Text = "Reiniciar"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'TabSim
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.TabSim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TabSim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TabSim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TabSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabSim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Rnd, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TabSim.DefaultCellStyle = DataGridViewCellStyle3
        Me.TabSim.Location = New System.Drawing.Point(395, 12)
        Me.TabSim.Name = "TabSim"
        Me.TabSim.ReadOnly = True
        Me.TabSim.Size = New System.Drawing.Size(948, 506)
        Me.TabSim.TabIndex = 12
        '
        'Column3
        '
        Me.Column3.HeaderText = "Vuelo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Rnd
        '
        Me.Rnd.HeaderText = "RND"
        Me.Rnd.Name = "Rnd"
        Me.Rnd.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Pasajeros que se presentaron"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Pasajeros sin cupo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Utilidad"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Perdida"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Utilidad total del vuelo"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Utilidad Total"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'txt_uPromedio
        '
        Me.txt_uPromedio.Location = New System.Drawing.Point(398, 547)
        Me.txt_uPromedio.Name = "txt_uPromedio"
        Me.txt_uPromedio.Size = New System.Drawing.Size(154, 20)
        Me.txt_uPromedio.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(395, 531)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Utilidad promedio"
        '
        'txt_uTotal
        '
        Me.txt_uTotal.Location = New System.Drawing.Point(604, 547)
        Me.txt_uTotal.Name = "txt_uTotal"
        Me.txt_uTotal.Size = New System.Drawing.Size(154, 20)
        Me.txt_uTotal.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(601, 531)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Utilidad total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 590)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.txt_uTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_uPromedio)
        Me.Controls.Add(Me.TabSim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gp_1)
        Me.Name = "Form1"
        Me.Text = "Aerolineas Grupo 6"
        CType(Me.TabProba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_1.ResumeLayout(False)
        Me.gp_1.PerformLayout()
        CType(Me.TabSim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabProba As DataGridView
    Friend WithEvents btn_sim As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_n As TextBox
    Friend WithEvents gp_1 As GroupBox
    Friend WithEvents rdb_4p As RadioButton
    Friend WithEvents rdb_3p As RadioButton
    Friend WithEvents rdb_2p As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents rdb_1p As RadioButton
    Friend WithEvents txt_Amostrar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents TabSim As DataGridView
    Friend WithEvents txt_uPromedio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_uTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Rnd As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
