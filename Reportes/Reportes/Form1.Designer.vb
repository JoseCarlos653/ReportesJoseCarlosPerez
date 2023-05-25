<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesDeCargosToolStripMenuItem, Me.ReportesDeEmpleadosToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReportesDeCargosToolStripMenuItem
        '
        Me.ReportesDeCargosToolStripMenuItem.BackColor = System.Drawing.Color.DarkBlue
        Me.ReportesDeCargosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesDeCargosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportesDeCargosToolStripMenuItem.Name = "ReportesDeCargosToolStripMenuItem"
        Me.ReportesDeCargosToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.ReportesDeCargosToolStripMenuItem.Text = "Reportes de Cargos"
        '
        'ReportesDeEmpleadosToolStripMenuItem
        '
        Me.ReportesDeEmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.DarkBlue
        Me.ReportesDeEmpleadosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesDeEmpleadosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportesDeEmpleadosToolStripMenuItem.Name = "ReportesDeEmpleadosToolStripMenuItem"
        Me.ReportesDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.ReportesDeEmpleadosToolStripMenuItem.Text = "Reportes de Empleados"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.DarkBlue
        Me.EmpleadosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(712, 368)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Fomulario Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesDeCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
