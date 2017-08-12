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
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'botonConectar
        '
        Me.botonConectar.Location = New System.Drawing.Point(194, 228)
        Me.botonConectar.Name = "botonConectar"
        Me.botonConectar.Size = New System.Drawing.Size(75, 23)
        Me.botonConectar.TabIndex = 0
        Me.botonConectar.Text = "Conectar"
        Me.botonConectar.UseVisualStyleBackColor = True
        '
        'ListBoxDatos
        '
        Me.ListBoxDatos.FormattingEnabled = True
        Me.ListBoxDatos.Location = New System.Drawing.Point(13, 32)
        Me.ListBoxDatos.Name = "ListBoxDatos"
        Me.ListBoxDatos.Size = New System.Drawing.Size(256, 173)
        Me.ListBoxDatos.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ClientesToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ClientesToolStripMenuItem.Text = "Productos"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 311)
        Me.Controls.Add(Me.ListBoxDatos)
        Me.Controls.Add(Me.botonConectar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormularioPrincipal"
        Me.Text = "Cafeteria (VB)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonConectar As Button
    Friend WithEvents ListBoxDatos As ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
