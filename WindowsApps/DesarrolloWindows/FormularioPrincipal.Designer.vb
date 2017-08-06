<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.botonConectar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'botonConectar
        '
        Me.botonConectar.Location = New System.Drawing.Point(194, 211)
        Me.botonConectar.Name = "botonConectar"
        Me.botonConectar.Size = New System.Drawing.Size(75, 23)
        Me.botonConectar.TabIndex = 0
        Me.botonConectar.Text = "Conectar"
        Me.botonConectar.UseVisualStyleBackColor = True
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.botonConectar)
        Me.Name = "FormularioPrincipal"
        Me.Text = "Cafeteria"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents botonConectar As Button
End Class
