<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleado
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.CmbCampo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvRegistros = New System.Windows.Forms.DataGridView()
        Me.TxtRango2 = New System.Windows.Forms.TextBox()
        Me.TxtRango1 = New System.Windows.Forms.TextBox()
        Me.DtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.DtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Controls.Add(Me.BtnImprimir)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Controls.Add(Me.CmbCampo)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1098, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione por que campo desea buscar"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.Location = New System.Drawing.Point(883, 29)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(188, 35)
        Me.BtnMostrar.TabIndex = 2
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'TxtDato
        '
        Me.TxtDato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDato.Location = New System.Drawing.Point(307, 57)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(549, 30)
        Me.TxtDato.TabIndex = 1
        '
        'CmbCampo
        '
        Me.CmbCampo.FormattingEnabled = True
        Me.CmbCampo.Items.AddRange(New Object() {"Profesión", "Nombres ", "Apellidos"})
        Me.CmbCampo.Location = New System.Drawing.Point(30, 56)
        Me.CmbCampo.Name = "CmbCampo"
        Me.CmbCampo.Size = New System.Drawing.Size(262, 31)
        Me.CmbCampo.TabIndex = 0
        Me.CmbCampo.Text = "Seleccione el campo..."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkBlue
        Me.GroupBox2.Controls.Add(Me.DgvRegistros)
        Me.GroupBox2.Controls.Add(Me.TxtRango2)
        Me.GroupBox2.Controls.Add(Me.TxtRango1)
        Me.GroupBox2.Controls.Add(Me.DtpFecha2)
        Me.GroupBox2.Controls.Add(Me.DtpFecha1)
        Me.GroupBox2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(13, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1096, 565)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registros Encontrados: 0"
        '
        'DgvRegistros
        '
        Me.DgvRegistros.AllowUserToAddRows = False
        Me.DgvRegistros.AllowUserToResizeColumns = False
        Me.DgvRegistros.AllowUserToResizeRows = False
        Me.DgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRegistros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvRegistros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRegistros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRegistros.EnableHeadersVisualStyles = False
        Me.DgvRegistros.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DgvRegistros.Location = New System.Drawing.Point(3, 26)
        Me.DgvRegistros.Name = "DgvRegistros"
        Me.DgvRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvRegistros.RowHeadersVisible = False
        Me.DgvRegistros.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DgvRegistros.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvRegistros.RowTemplate.Height = 24
        Me.DgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRegistros.Size = New System.Drawing.Size(1090, 536)
        Me.DgvRegistros.TabIndex = 0
        '
        'TxtRango2
        '
        Me.TxtRango2.Location = New System.Drawing.Point(415, 202)
        Me.TxtRango2.Name = "TxtRango2"
        Me.TxtRango2.Size = New System.Drawing.Size(200, 30)
        Me.TxtRango2.TabIndex = 4
        '
        'TxtRango1
        '
        Me.TxtRango1.Location = New System.Drawing.Point(141, 202)
        Me.TxtRango1.Name = "TxtRango1"
        Me.TxtRango1.Size = New System.Drawing.Size(200, 30)
        Me.TxtRango1.TabIndex = 3
        '
        'DtpFecha2
        '
        Me.DtpFecha2.Location = New System.Drawing.Point(415, 144)
        Me.DtpFecha2.Name = "DtpFecha2"
        Me.DtpFecha2.Size = New System.Drawing.Size(200, 30)
        Me.DtpFecha2.TabIndex = 2
        '
        'DtpFecha1
        '
        Me.DtpFecha1.Location = New System.Drawing.Point(141, 144)
        Me.DtpFecha1.Name = "DtpFecha1"
        Me.DtpFecha1.Size = New System.Drawing.Size(200, 30)
        Me.DtpFecha1.TabIndex = 1
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Location = New System.Drawing.Point(883, 79)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(188, 35)
        Me.BtnImprimir.TabIndex = 3
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1121, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FrmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Empleado por Profesión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents TxtDato As TextBox
    Friend WithEvents CmbCampo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvRegistros As DataGridView
    Friend WithEvents TxtRango2 As TextBox
    Friend WithEvents TxtRango1 As TextBox
    Friend WithEvents DtpFecha2 As DateTimePicker
    Friend WithEvents DtpFecha1 As DateTimePicker
    Friend WithEvents BtnImprimir As Button
End Class
