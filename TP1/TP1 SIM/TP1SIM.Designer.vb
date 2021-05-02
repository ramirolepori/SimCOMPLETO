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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.txtS = New System.Windows.Forms.TextBox()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.random = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_chi = New System.Windows.Forms.Button()
        Me.btnMultiplicativo = New System.Windows.Forms.RadioButton()
        Me.btnLineal = New System.Windows.Forms.RadioButton()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 288
        Me.Label3.Text = "m"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 389
        Me.Label4.Text = "Semilla"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(26, 45)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(45, 20)
        Me.txtA.TabIndex = 1
        Me.txtA.Text = "0"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(97, 45)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(45, 20)
        Me.txtC.TabIndex = 2
        Me.txtC.Text = "0"
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(169, 45)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(45, 20)
        Me.txtM.TabIndex = 3
        Me.txtM.Text = "0"
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(305, 45)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(45, 20)
        Me.txtS.TabIndex = 4
        Me.txtS.Text = "0"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.count, Me.random})
        Me.dgvLista.Location = New System.Drawing.Point(6, 71)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(344, 257)
        Me.dgvLista.TabIndex = 894
        '
        'count
        '
        Me.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.count.HeaderText = "Nº"
        Me.count.Name = "count"
        Me.count.ReadOnly = True
        Me.count.Width = 40
        '
        'random
        '
        Me.random.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.random.DefaultCellStyle = DataGridViewCellStyle3
        Me.random.HeaderText = "Aleatorio"
        Me.random.Name = "random"
        Me.random.ReadOnly = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(106, 334)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(77, 23)
        Me.btnGenerar.TabIndex = 5
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(189, 334)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(77, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Enabled = False
        Me.btnLimpiar.Location = New System.Drawing.Point(272, 334)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 23)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_chi)
        Me.GroupBox1.Controls.Add(Me.btnMultiplicativo)
        Me.GroupBox1.Controls.Add(Me.btnLineal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgvLista)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Controls.Add(Me.txtS)
        Me.GroupBox1.Controls.Add(Me.txtC)
        Me.GroupBox1.Controls.Add(Me.txtM)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 364)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generador de números aleatorios"
        '
        'btn_chi
        '
        Me.btn_chi.Location = New System.Drawing.Point(6, 334)
        Me.btn_chi.Name = "btn_chi"
        Me.btn_chi.Size = New System.Drawing.Size(77, 23)
        Me.btn_chi.TabIndex = 895
        Me.btn_chi.Text = "Test Chi"
        Me.btn_chi.UseVisualStyleBackColor = True
        '
        'btnMultiplicativo
        '
        Me.btnMultiplicativo.AutoSize = True
        Me.btnMultiplicativo.Location = New System.Drawing.Point(130, 19)
        Me.btnMultiplicativo.Name = "btnMultiplicativo"
        Me.btnMultiplicativo.Size = New System.Drawing.Size(150, 17)
        Me.btnMultiplicativo.TabIndex = 56
        Me.btnMultiplicativo.Text = "Congruencial multiplicativo"
        Me.btnMultiplicativo.UseVisualStyleBackColor = True
        '
        'btnLineal
        '
        Me.btnLineal.AutoSize = True
        Me.btnLineal.Checked = True
        Me.btnLineal.Location = New System.Drawing.Point(6, 19)
        Me.btnLineal.Name = "btnLineal"
        Me.btnLineal.Size = New System.Drawing.Size(118, 17)
        Me.btnLineal.TabIndex = 55
        Me.btnLineal.TabStop = True
        Me.btnLineal.Text = "Congruencial Lineal"
        Me.btnLineal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 383)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Simulación TP1"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtM As TextBox
    Friend WithEvents txtS As TextBox
    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents x As DataGridViewTextBoxColumn
    Friend WithEvents btnMultiplicativo As RadioButton
    Friend WithEvents btnLineal As RadioButton
    Friend WithEvents count As DataGridViewTextBoxColumn
    Friend WithEvents random As DataGridViewTextBoxColumn
    Friend WithEvents btn_chi As Button
End Class
