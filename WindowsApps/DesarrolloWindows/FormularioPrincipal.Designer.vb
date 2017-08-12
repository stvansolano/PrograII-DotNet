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
        Me.ListBoxDatos = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'botonConectar
        '
        Me.botonConectar.Location = New System.Drawing.Point(197, 226)
        Me.botonConectar.Name = "botonConectar"
        Me.botonConectar.Size = New System.Drawing.Size(75, 23)
        Me.botonConectar.TabIndex = 0
        Me.botonConectar.Text = "Conectar"
        Me.botonConectar.UseVisualStyleBackColor = True
        '
        'ListBoxDatos
        '
        Me.ListBoxDatos.FormattingEnabled = True
        Me.ListBoxDatos.Location = New System.Drawing.Point(16, 47)
        Me.ListBoxDatos.Name = "ListBoxDatos"
        Me.ListBoxDatos.Size = New System.Drawing.Size(256, 173)
        Me.ListBoxDatos.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "Archivo"
        '
        'OrdenesToolStripMenuItem
        '
        Me.OrdenesToolStripMenuItem.Name = "OrdenesToolStripMenuItem"
        Me.OrdenesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrdenesToolStripMenuItem.Text = "Ordenes"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBoxDatos)
        Me.Controls.Add(Me.botonConectar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormularioPrincipal"
        Me.Text = "Cafeteria"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonConectar As Button
    Friend WithEvents ListBoxDatos As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OrdenesToolStripMenuItem As ToolStripMenuItem
End Class
