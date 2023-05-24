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
        Me.BtnImprimirCargos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnImprimirCargos
        '
        Me.BtnImprimirCargos.Location = New System.Drawing.Point(52, 55)
        Me.BtnImprimirCargos.Name = "BtnImprimirCargos"
        Me.BtnImprimirCargos.Size = New System.Drawing.Size(179, 71)
        Me.BtnImprimirCargos.TabIndex = 0
        Me.BtnImprimirCargos.Text = "Mostrar Reportes de Cargos"
        Me.BtnImprimirCargos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 299)
        Me.Controls.Add(Me.BtnImprimirCargos)
        Me.Name = "Form1"
        Me.Text = "Fomulario Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnImprimirCargos As Button
End Class
