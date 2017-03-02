<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiEasterEgg
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
        Me.Solução1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Solução2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Solução3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Solução4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Solução1ToolStripMenuItem
        '
        Me.Solução1ToolStripMenuItem.Name = "Solução1ToolStripMenuItem"
        Me.Solução1ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.Solução1ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Solução1ToolStripMenuItem.Text = "Solution &1"
        '
        'Solução2ToolStripMenuItem
        '
        Me.Solução2ToolStripMenuItem.Name = "Solução2ToolStripMenuItem"
        Me.Solução2ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.Solução2ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Solução2ToolStripMenuItem.Text = "Solution &2"
        '
        'Solução3ToolStripMenuItem
        '
        Me.Solução3ToolStripMenuItem.Name = "Solução3ToolStripMenuItem"
        Me.Solução3ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.Solução3ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Solução3ToolStripMenuItem.Text = "Solution &3"
        '
        'Solução4ToolStripMenuItem
        '
        Me.Solução4ToolStripMenuItem.Name = "Solução4ToolStripMenuItem"
        Me.Solução4ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.Solução4ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Solução4ToolStripMenuItem.Text = "Solution &4"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Solução1ToolStripMenuItem, Me.Solução2ToolStripMenuItem, Me.Solução3ToolStripMenuItem, Me.Solução4ToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(615, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mdiEasterEgg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 646)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiEasterEgg"
        Me.Text = "mdiEasterEgg"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Solução1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Solução2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Solução3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Solução4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip

End Class
