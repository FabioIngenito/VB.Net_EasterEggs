<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolucao3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolucao3))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblExplicacao1 = New System.Windows.Forms.Label()
        Me.lblExplicacao2 = New System.Windows.Forms.Label()
        Me.lblExplicacao5 = New System.Windows.Forms.Label()
        Me.lblExplicacao3 = New System.Windows.Forms.Label()
        Me.txtLinha = New System.Windows.Forms.TextBox()
        Me.txtColuna = New System.Windows.Forms.TextBox()
        Me.lblLinha = New System.Windows.Forms.Label()
        Me.lblColuna = New System.Windows.Forms.Label()
        Me.lblExplicaca4 = New System.Windows.Forms.Label()
        Me.grbTimer1 = New System.Windows.Forms.GroupBox()
        Me.rbtKeyPreviewDesligado = New System.Windows.Forms.RadioButton()
        Me.rbtKeyPreviewLigado = New System.Windows.Forms.RadioButton()
        Me.lblKeyPreview = New System.Windows.Forms.Label()
        Me.lblExplicacao6 = New System.Windows.Forms.Label()
        Me.lblExplanation1 = New System.Windows.Forms.Label()
        Me.lblExplanation2 = New System.Windows.Forms.Label()
        Me.lblExplanation3 = New System.Windows.Forms.Label()
        Me.lblExplanation4 = New System.Windows.Forms.Label()
        Me.lblExplanation5 = New System.Windows.Forms.Label()
        Me.lblExplanation6 = New System.Windows.Forms.Label()
        Me.grbTimer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(384, 9)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(258, 589)
        Me.ListBox1.TabIndex = 0
        '
        'lblExplicacao1
        '
        Me.lblExplicacao1.Location = New System.Drawing.Point(12, 9)
        Me.lblExplicacao1.Name = "lblExplicacao1"
        Me.lblExplicacao1.Size = New System.Drawing.Size(366, 58)
        Me.lblExplicacao1.TabIndex = 1
        Me.lblExplicacao1.Text = resources.GetString("lblExplicacao1.Text")
        '
        'lblExplicacao2
        '
        Me.lblExplicacao2.Location = New System.Drawing.Point(12, 134)
        Me.lblExplicacao2.Name = "lblExplicacao2"
        Me.lblExplicacao2.Size = New System.Drawing.Size(366, 33)
        Me.lblExplicacao2.TabIndex = 2
        Me.lblExplicacao2.Text = "É preciso seguir a ordem. Se ocorre 'sujeira' no meio da digitação, guarda o valo" &
    "r e compara. Exemplo: ""1-A-2-3-4-5-6-7-8"". NÃO funcionará!"
        '
        'lblExplicacao5
        '
        Me.lblExplicacao5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplicacao5.ForeColor = System.Drawing.Color.Brown
        Me.lblExplicacao5.Location = New System.Drawing.Point(12, 470)
        Me.lblExplicacao5.Name = "lblExplicacao5"
        Me.lblExplicacao5.Size = New System.Drawing.Size(366, 17)
        Me.lblExplicacao5.TabIndex = 13
        Me.lblExplicacao5.Text = "Pressione: ""1-2-3-4-5-6-7-8"" (KeyPreview=Ligado)."
        '
        'lblExplicacao3
        '
        Me.lblExplicacao3.Location = New System.Drawing.Point(12, 203)
        Me.lblExplicacao3.Name = "lblExplicacao3"
        Me.lblExplicacao3.Size = New System.Drawing.Size(366, 56)
        Me.lblExplicacao3.TabIndex = 3
        Me.lblExplicacao3.Text = resources.GetString("lblExplicacao3.Text")
        '
        'txtLinha
        '
        Me.txtLinha.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLinha.Location = New System.Drawing.Point(83, 395)
        Me.txtLinha.Name = "txtLinha"
        Me.txtLinha.ReadOnly = True
        Me.txtLinha.Size = New System.Drawing.Size(68, 20)
        Me.txtLinha.TabIndex = 6
        '
        'txtColuna
        '
        Me.txtColuna.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtColuna.Location = New System.Drawing.Point(310, 395)
        Me.txtColuna.Name = "txtColuna"
        Me.txtColuna.ReadOnly = True
        Me.txtColuna.Size = New System.Drawing.Size(68, 20)
        Me.txtColuna.TabIndex = 8
        '
        'lblLinha
        '
        Me.lblLinha.AutoSize = True
        Me.lblLinha.Location = New System.Drawing.Point(12, 398)
        Me.lblLinha.Name = "lblLinha"
        Me.lblLinha.Size = New System.Drawing.Size(65, 13)
        Me.lblLinha.TabIndex = 5
        Me.lblLinha.Text = "Linha - Line:"
        '
        'lblColuna
        '
        Me.lblColuna.AutoSize = True
        Me.lblColuna.Location = New System.Drawing.Point(217, 398)
        Me.lblColuna.Name = "lblColuna"
        Me.lblColuna.Size = New System.Drawing.Size(87, 13)
        Me.lblColuna.TabIndex = 7
        Me.lblColuna.Text = "Coluna - Column:"
        '
        'lblExplicaca4
        '
        Me.lblExplicaca4.Location = New System.Drawing.Point(12, 325)
        Me.lblExplicaca4.Name = "lblExplicaca4"
        Me.lblExplicaca4.Size = New System.Drawing.Size(366, 30)
        Me.lblExplicaca4.TabIndex = 4
        Me.lblExplicaca4.Text = "Outra forma que pensei. Só deixa ""True"" o ""KeyPreview"" se o cursor estiver entre " &
    "'Linha = 0 até 100' e o 'Coluna = 0 até 100'."
        '
        'grbTimer1
        '
        Me.grbTimer1.Controls.Add(Me.rbtKeyPreviewDesligado)
        Me.grbTimer1.Controls.Add(Me.rbtKeyPreviewLigado)
        Me.grbTimer1.Location = New System.Drawing.Point(84, 424)
        Me.grbTimer1.Name = "grbTimer1"
        Me.grbTimer1.Size = New System.Drawing.Size(294, 31)
        Me.grbTimer1.TabIndex = 10
        Me.grbTimer1.TabStop = False
        '
        'rbtKeyPreviewDesligado
        '
        Me.rbtKeyPreviewDesligado.AutoSize = True
        Me.rbtKeyPreviewDesligado.Checked = True
        Me.rbtKeyPreviewDesligado.Location = New System.Drawing.Point(153, 9)
        Me.rbtKeyPreviewDesligado.Name = "rbtKeyPreviewDesligado"
        Me.rbtKeyPreviewDesligado.Size = New System.Drawing.Size(130, 17)
        Me.rbtKeyPreviewDesligado.TabIndex = 12
        Me.rbtKeyPreviewDesligado.TabStop = True
        Me.rbtKeyPreviewDesligado.Text = "Desligado - Turned off"
        Me.rbtKeyPreviewDesligado.UseVisualStyleBackColor = True
        '
        'rbtKeyPreviewLigado
        '
        Me.rbtKeyPreviewLigado.AutoSize = True
        Me.rbtKeyPreviewLigado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtKeyPreviewLigado.ForeColor = System.Drawing.Color.Brown
        Me.rbtKeyPreviewLigado.Location = New System.Drawing.Point(15, 9)
        Me.rbtKeyPreviewLigado.Name = "rbtKeyPreviewLigado"
        Me.rbtKeyPreviewLigado.Size = New System.Drawing.Size(133, 17)
        Me.rbtKeyPreviewLigado.TabIndex = 11
        Me.rbtKeyPreviewLigado.Text = "Ligado - Turned on"
        Me.rbtKeyPreviewLigado.UseVisualStyleBackColor = True
        '
        'lblKeyPreview
        '
        Me.lblKeyPreview.AutoSize = True
        Me.lblKeyPreview.ForeColor = System.Drawing.Color.Blue
        Me.lblKeyPreview.Location = New System.Drawing.Point(12, 435)
        Me.lblKeyPreview.Name = "lblKeyPreview"
        Me.lblKeyPreview.Size = New System.Drawing.Size(66, 13)
        Me.lblKeyPreview.TabIndex = 9
        Me.lblKeyPreview.Text = "KeyPreview:"
        '
        'lblExplicacao6
        '
        Me.lblExplicacao6.Location = New System.Drawing.Point(12, 525)
        Me.lblExplicacao6.Name = "lblExplicacao6"
        Me.lblExplicacao6.Size = New System.Drawing.Size(366, 35)
        Me.lblExplicacao6.TabIndex = 14
        Me.lblExplicacao6.Text = "Problema: O registro de posição do cursor não funciona em cima de um objeto no fo" &
    "rmulário!"
        '
        'lblExplanation1
        '
        Me.lblExplanation1.Location = New System.Drawing.Point(12, 67)
        Me.lblExplanation1.Name = "lblExplanation1"
        Me.lblExplanation1.Size = New System.Drawing.Size(366, 58)
        Me.lblExplanation1.TabIndex = 15
        Me.lblExplanation1.Text = resources.GetString("lblExplanation1.Text")
        '
        'lblExplanation2
        '
        Me.lblExplanation2.Location = New System.Drawing.Point(12, 167)
        Me.lblExplanation2.Name = "lblExplanation2"
        Me.lblExplanation2.Size = New System.Drawing.Size(366, 33)
        Me.lblExplanation2.TabIndex = 16
        Me.lblExplanation2.Text = "You have to follow the order. If there is 'dirt' in the middle of typing, save th" &
    "e value and compares. Example: ""1-A-2-3-4-5-6-7-8"". Will NOT work!"
        '
        'lblExplanation3
        '
        Me.lblExplanation3.Location = New System.Drawing.Point(12, 259)
        Me.lblExplanation3.Name = "lblExplanation3"
        Me.lblExplanation3.Size = New System.Drawing.Size(366, 56)
        Me.lblExplanation3.TabIndex = 17
        Me.lblExplanation3.Text = resources.GetString("lblExplanation3.Text")
        '
        'lblExplanation4
        '
        Me.lblExplanation4.Location = New System.Drawing.Point(12, 355)
        Me.lblExplanation4.Name = "lblExplanation4"
        Me.lblExplanation4.Size = New System.Drawing.Size(366, 30)
        Me.lblExplanation4.TabIndex = 18
        Me.lblExplanation4.Text = "Another way that I thought. Just let ""True"" the ""KeyPreview"" If the cursor is bet" &
    "ween 'line = 0 to 100' and '100' to Column = 0."
        '
        'lblExplanation5
        '
        Me.lblExplanation5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanation5.ForeColor = System.Drawing.Color.Brown
        Me.lblExplanation5.Location = New System.Drawing.Point(12, 487)
        Me.lblExplanation5.Name = "lblExplanation5"
        Me.lblExplanation5.Size = New System.Drawing.Size(366, 17)
        Me.lblExplanation5.TabIndex = 19
        Me.lblExplanation5.Text = "Press: ""1-2-3-4-5-6-7-8"" (KeyPreview=Turn on)."
        '
        'lblExplanation6
        '
        Me.lblExplanation6.Location = New System.Drawing.Point(12, 560)
        Me.lblExplanation6.Name = "lblExplanation6"
        Me.lblExplanation6.Size = New System.Drawing.Size(366, 33)
        Me.lblExplanation6.TabIndex = 20
        Me.lblExplanation6.Text = "Problem: the record of the cursor position does not work over an object on the fo" &
    "rm."
        '
        'frmSolucao3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 611)
        Me.Controls.Add(Me.lblExplanation6)
        Me.Controls.Add(Me.lblExplanation5)
        Me.Controls.Add(Me.lblExplanation4)
        Me.Controls.Add(Me.lblExplanation3)
        Me.Controls.Add(Me.lblExplanation2)
        Me.Controls.Add(Me.lblExplanation1)
        Me.Controls.Add(Me.lblExplicacao6)
        Me.Controls.Add(Me.lblKeyPreview)
        Me.Controls.Add(Me.grbTimer1)
        Me.Controls.Add(Me.lblExplicaca4)
        Me.Controls.Add(Me.lblColuna)
        Me.Controls.Add(Me.lblLinha)
        Me.Controls.Add(Me.txtColuna)
        Me.Controls.Add(Me.txtLinha)
        Me.Controls.Add(Me.lblExplicacao3)
        Me.Controls.Add(Me.lblExplicacao5)
        Me.Controls.Add(Me.lblExplicacao2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblExplicacao1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolucao3"
        Me.ShowIcon = False
        Me.Text = "Solução 3"
        Me.grbTimer1.ResumeLayout(False)
        Me.grbTimer1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblExplicacao1 As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao2 As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao5 As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao3 As System.Windows.Forms.Label
    Friend WithEvents txtLinha As System.Windows.Forms.TextBox
    Friend WithEvents txtColuna As System.Windows.Forms.TextBox
    Friend WithEvents lblLinha As System.Windows.Forms.Label
    Friend WithEvents lblColuna As System.Windows.Forms.Label
    Friend WithEvents lblExplicaca4 As System.Windows.Forms.Label
    Friend WithEvents grbTimer1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtKeyPreviewDesligado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtKeyPreviewLigado As System.Windows.Forms.RadioButton
    Friend WithEvents lblKeyPreview As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao6 As System.Windows.Forms.Label
    Friend WithEvents lblExplanation1 As Label
    Friend WithEvents lblExplanation2 As Label
    Friend WithEvents lblExplanation3 As Label
    Friend WithEvents lblExplanation4 As Label
    Friend WithEvents lblExplanation5 As Label
    Friend WithEvents lblExplanation6 As Label
End Class
