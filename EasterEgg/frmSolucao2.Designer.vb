<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolucao2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolucao2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblExplicacao5 = New System.Windows.Forms.Label()
        Me.lblExplicacao1 = New System.Windows.Forms.Label()
        Me.lblExplicacao6 = New System.Windows.Forms.Label()
        Me.lblTimer1 = New System.Windows.Forms.Label()
        Me.lblTimer2 = New System.Windows.Forms.Label()
        Me.lblTimer3 = New System.Windows.Forms.Label()
        Me.grbTimer1 = New System.Windows.Forms.GroupBox()
        Me.rbtTimer1Desligado = New System.Windows.Forms.RadioButton()
        Me.rbtTimer1Ligado = New System.Windows.Forms.RadioButton()
        Me.grbTimer3 = New System.Windows.Forms.GroupBox()
        Me.rbtTimer3Desligado = New System.Windows.Forms.RadioButton()
        Me.rbtTimer3Ligado = New System.Windows.Forms.RadioButton()
        Me.lblBotao4 = New System.Windows.Forms.Label()
        Me.grbBotao4 = New System.Windows.Forms.GroupBox()
        Me.rbtBotao4Desligado = New System.Windows.Forms.RadioButton()
        Me.rbtBotao4Ligado = New System.Windows.Forms.RadioButton()
        Me.txtTempoTimer1 = New System.Windows.Forms.TextBox()
        Me.txtTempoTimer2 = New System.Windows.Forms.TextBox()
        Me.txtTempoTimer3 = New System.Windows.Forms.TextBox()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.lblExplicacao4 = New System.Windows.Forms.Label()
        Me.btnOk1 = New System.Windows.Forms.Button()
        Me.btnOk2 = New System.Windows.Forms.Button()
        Me.btnOk3 = New System.Windows.Forms.Button()
        Me.grbTimer2 = New System.Windows.Forms.GroupBox()
        Me.rbtTimer2Desligado = New System.Windows.Forms.RadioButton()
        Me.rbtTimer2Ligado = New System.Windows.Forms.RadioButton()
        Me.lblExplicacao7 = New System.Windows.Forms.Label()
        Me.lblExplanation1 = New System.Windows.Forms.Label()
        Me.lblExplanation4 = New System.Windows.Forms.Label()
        Me.lblExplanation5 = New System.Windows.Forms.Label()
        Me.lblExplanation6 = New System.Windows.Forms.Label()
        Me.lblExplanation7 = New System.Windows.Forms.Label()
        Me.grbTimer1.SuspendLayout()
        Me.grbTimer3.SuspendLayout()
        Me.grbBotao4.SuspendLayout()
        Me.grbTimer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Timer2
        '
        Me.Timer2.Interval = 20000
        '
        'Timer3
        '
        Me.Timer3.Interval = 20000
        '
        'lblExplicacao5
        '
        Me.lblExplicacao5.Location = New System.Drawing.Point(14, 244)
        Me.lblExplicacao5.Name = "lblExplicacao5"
        Me.lblExplicacao5.Size = New System.Drawing.Size(628, 31)
        Me.lblExplicacao5.TabIndex = 23
        Me.lblExplicacao5.Text = "Se você colocar um ""refresh"" nos timers ele pode desligar com o tempo. O problema" &
    " que é possível dentro deste tempo colocar 'sujeira'. Exemplo: Digite: ""1-A-2-3-" &
    "4-5"". Funciona! Por isto NÃO gostei."
        '
        'lblExplicacao1
        '
        Me.lblExplicacao1.Location = New System.Drawing.Point(12, 9)
        Me.lblExplicacao1.Name = "lblExplicacao1"
        Me.lblExplicacao1.Size = New System.Drawing.Size(630, 33)
        Me.lblExplicacao1.TabIndex = 0
        Me.lblExplicacao1.Text = resources.GetString("lblExplicacao1.Text")
        '
        'lblExplicacao6
        '
        Me.lblExplicacao6.Location = New System.Drawing.Point(14, 321)
        Me.lblExplicacao6.Name = "lblExplicacao6"
        Me.lblExplicacao6.Size = New System.Drawing.Size(628, 43)
        Me.lblExplicacao6.TabIndex = 24
        Me.lblExplicacao6.Text = resources.GetString("lblExplicacao6.Text")
        '
        'lblTimer1
        '
        Me.lblTimer1.AutoSize = True
        Me.lblTimer1.Location = New System.Drawing.Point(36, 87)
        Me.lblTimer1.Name = "lblTimer1"
        Me.lblTimer1.Size = New System.Drawing.Size(45, 13)
        Me.lblTimer1.TabIndex = 3
        Me.lblTimer1.Text = "Timer 1:"
        '
        'lblTimer2
        '
        Me.lblTimer2.AutoSize = True
        Me.lblTimer2.Location = New System.Drawing.Point(36, 124)
        Me.lblTimer2.Name = "lblTimer2"
        Me.lblTimer2.Size = New System.Drawing.Size(45, 13)
        Me.lblTimer2.TabIndex = 8
        Me.lblTimer2.Text = "Timer 2:"
        '
        'lblTimer3
        '
        Me.lblTimer3.AutoSize = True
        Me.lblTimer3.Location = New System.Drawing.Point(36, 163)
        Me.lblTimer3.Name = "lblTimer3"
        Me.lblTimer3.Size = New System.Drawing.Size(45, 13)
        Me.lblTimer3.TabIndex = 13
        Me.lblTimer3.Text = "Timer 3:"
        '
        'grbTimer1
        '
        Me.grbTimer1.Controls.Add(Me.rbtTimer1Desligado)
        Me.grbTimer1.Controls.Add(Me.rbtTimer1Ligado)
        Me.grbTimer1.Location = New System.Drawing.Point(87, 93)
        Me.grbTimer1.Name = "grbTimer1"
        Me.grbTimer1.Size = New System.Drawing.Size(254, 31)
        Me.grbTimer1.TabIndex = 4
        Me.grbTimer1.TabStop = False
        '
        'rbtTimer1Desligado
        '
        Me.rbtTimer1Desligado.AutoSize = True
        Me.rbtTimer1Desligado.Checked = True
        Me.rbtTimer1Desligado.Location = New System.Drawing.Point(123, 8)
        Me.rbtTimer1Desligado.Name = "rbtTimer1Desligado"
        Me.rbtTimer1Desligado.Size = New System.Drawing.Size(118, 17)
        Me.rbtTimer1Desligado.TabIndex = 6
        Me.rbtTimer1Desligado.TabStop = True
        Me.rbtTimer1Desligado.Text = "Desligado - Turn off"
        Me.rbtTimer1Desligado.UseVisualStyleBackColor = True
        '
        'rbtTimer1Ligado
        '
        Me.rbtTimer1Ligado.AutoSize = True
        Me.rbtTimer1Ligado.ForeColor = System.Drawing.Color.Blue
        Me.rbtTimer1Ligado.Location = New System.Drawing.Point(14, 9)
        Me.rbtTimer1Ligado.Name = "rbtTimer1Ligado"
        Me.rbtTimer1Ligado.Size = New System.Drawing.Size(103, 17)
        Me.rbtTimer1Ligado.TabIndex = 5
        Me.rbtTimer1Ligado.Text = "Ligado - Turn on"
        Me.rbtTimer1Ligado.UseVisualStyleBackColor = True
        '
        'grbTimer3
        '
        Me.grbTimer3.Controls.Add(Me.rbtTimer3Desligado)
        Me.grbTimer3.Controls.Add(Me.rbtTimer3Ligado)
        Me.grbTimer3.Location = New System.Drawing.Point(87, 169)
        Me.grbTimer3.Name = "grbTimer3"
        Me.grbTimer3.Size = New System.Drawing.Size(254, 31)
        Me.grbTimer3.TabIndex = 14
        Me.grbTimer3.TabStop = False
        '
        'rbtTimer3Desligado
        '
        Me.rbtTimer3Desligado.AutoSize = True
        Me.rbtTimer3Desligado.Checked = True
        Me.rbtTimer3Desligado.Location = New System.Drawing.Point(123, 9)
        Me.rbtTimer3Desligado.Name = "rbtTimer3Desligado"
        Me.rbtTimer3Desligado.Size = New System.Drawing.Size(118, 17)
        Me.rbtTimer3Desligado.TabIndex = 16
        Me.rbtTimer3Desligado.TabStop = True
        Me.rbtTimer3Desligado.Text = "Desligado - Turn off"
        Me.rbtTimer3Desligado.UseVisualStyleBackColor = True
        '
        'rbtTimer3Ligado
        '
        Me.rbtTimer3Ligado.AutoSize = True
        Me.rbtTimer3Ligado.ForeColor = System.Drawing.Color.Blue
        Me.rbtTimer3Ligado.Location = New System.Drawing.Point(13, 9)
        Me.rbtTimer3Ligado.Name = "rbtTimer3Ligado"
        Me.rbtTimer3Ligado.Size = New System.Drawing.Size(103, 17)
        Me.rbtTimer3Ligado.TabIndex = 15
        Me.rbtTimer3Ligado.Text = "Ligado - Turn on"
        Me.rbtTimer3Ligado.UseVisualStyleBackColor = True
        '
        'lblBotao4
        '
        Me.lblBotao4.AutoSize = True
        Me.lblBotao4.Location = New System.Drawing.Point(36, 200)
        Me.lblBotao4.Name = "lblBotao4"
        Me.lblBotao4.Size = New System.Drawing.Size(47, 13)
        Me.lblBotao4.TabIndex = 18
        Me.lblBotao4.Text = "Botão 4:"
        '
        'grbBotao4
        '
        Me.grbBotao4.Controls.Add(Me.rbtBotao4Desligado)
        Me.grbBotao4.Controls.Add(Me.rbtBotao4Ligado)
        Me.grbBotao4.Location = New System.Drawing.Point(87, 206)
        Me.grbBotao4.Name = "grbBotao4"
        Me.grbBotao4.Size = New System.Drawing.Size(254, 31)
        Me.grbBotao4.TabIndex = 19
        Me.grbBotao4.TabStop = False
        '
        'rbtBotao4Desligado
        '
        Me.rbtBotao4Desligado.AutoSize = True
        Me.rbtBotao4Desligado.Checked = True
        Me.rbtBotao4Desligado.Location = New System.Drawing.Point(123, 9)
        Me.rbtBotao4Desligado.Name = "rbtBotao4Desligado"
        Me.rbtBotao4Desligado.Size = New System.Drawing.Size(118, 17)
        Me.rbtBotao4Desligado.TabIndex = 21
        Me.rbtBotao4Desligado.TabStop = True
        Me.rbtBotao4Desligado.Text = "Desligado - Turn off"
        Me.rbtBotao4Desligado.UseVisualStyleBackColor = True
        '
        'rbtBotao4Ligado
        '
        Me.rbtBotao4Ligado.AutoSize = True
        Me.rbtBotao4Ligado.ForeColor = System.Drawing.Color.Brown
        Me.rbtBotao4Ligado.Location = New System.Drawing.Point(13, 9)
        Me.rbtBotao4Ligado.Name = "rbtBotao4Ligado"
        Me.rbtBotao4Ligado.Size = New System.Drawing.Size(103, 17)
        Me.rbtBotao4Ligado.TabIndex = 20
        Me.rbtBotao4Ligado.Text = "Ligado - Turn on"
        Me.rbtBotao4Ligado.UseVisualStyleBackColor = True
        '
        'txtTempoTimer1
        '
        Me.txtTempoTimer1.Location = New System.Drawing.Point(359, 104)
        Me.txtTempoTimer1.MaxLength = 9
        Me.txtTempoTimer1.Name = "txtTempoTimer1"
        Me.txtTempoTimer1.Size = New System.Drawing.Size(73, 20)
        Me.txtTempoTimer1.TabIndex = 7
        Me.txtTempoTimer1.Text = "10000"
        '
        'txtTempoTimer2
        '
        Me.txtTempoTimer2.Location = New System.Drawing.Point(359, 141)
        Me.txtTempoTimer2.MaxLength = 9
        Me.txtTempoTimer2.Name = "txtTempoTimer2"
        Me.txtTempoTimer2.Size = New System.Drawing.Size(73, 20)
        Me.txtTempoTimer2.TabIndex = 12
        Me.txtTempoTimer2.Text = "10000"
        '
        'txtTempoTimer3
        '
        Me.txtTempoTimer3.AcceptsTab = True
        Me.txtTempoTimer3.Location = New System.Drawing.Point(359, 180)
        Me.txtTempoTimer3.MaxLength = 9
        Me.txtTempoTimer3.Name = "txtTempoTimer3"
        Me.txtTempoTimer3.Size = New System.Drawing.Size(73, 20)
        Me.txtTempoTimer3.TabIndex = 17
        Me.txtTempoTimer3.Text = "10000"
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Location = New System.Drawing.Point(356, 81)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(226, 13)
        Me.lblTempo.TabIndex = 2
        Me.lblTempo.Text = "Tempo em Milisegundos - Time in milliseconds:"
        '
        'lblExplicacao4
        '
        Me.lblExplicacao4.AutoSize = True
        Me.lblExplicacao4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplicacao4.ForeColor = System.Drawing.Color.Brown
        Me.lblExplicacao4.Location = New System.Drawing.Point(356, 220)
        Me.lblExplicacao4.Name = "lblExplicacao4"
        Me.lblExplicacao4.Size = New System.Drawing.Size(126, 13)
        Me.lblExplicacao4.TabIndex = 22
        Me.lblExplicacao4.Text = "Pressione: ""1-2-3-4""."
        '
        'btnOk1
        '
        Me.btnOk1.Location = New System.Drawing.Point(438, 104)
        Me.btnOk1.Name = "btnOk1"
        Me.btnOk1.Size = New System.Drawing.Size(144, 20)
        Me.btnOk1.TabIndex = 25
        Me.btnOk1.Text = "OK 1"
        Me.btnOk1.UseVisualStyleBackColor = True
        '
        'btnOk2
        '
        Me.btnOk2.Location = New System.Drawing.Point(438, 141)
        Me.btnOk2.Name = "btnOk2"
        Me.btnOk2.Size = New System.Drawing.Size(144, 20)
        Me.btnOk2.TabIndex = 26
        Me.btnOk2.Text = "OK 2"
        Me.btnOk2.UseVisualStyleBackColor = True
        '
        'btnOk3
        '
        Me.btnOk3.Location = New System.Drawing.Point(438, 180)
        Me.btnOk3.Name = "btnOk3"
        Me.btnOk3.Size = New System.Drawing.Size(144, 20)
        Me.btnOk3.TabIndex = 27
        Me.btnOk3.Text = "OK 3"
        Me.btnOk3.UseVisualStyleBackColor = True
        '
        'grbTimer2
        '
        Me.grbTimer2.Controls.Add(Me.rbtTimer2Desligado)
        Me.grbTimer2.Controls.Add(Me.rbtTimer2Ligado)
        Me.grbTimer2.Location = New System.Drawing.Point(87, 132)
        Me.grbTimer2.Name = "grbTimer2"
        Me.grbTimer2.Size = New System.Drawing.Size(254, 31)
        Me.grbTimer2.TabIndex = 9
        Me.grbTimer2.TabStop = False
        '
        'rbtTimer2Desligado
        '
        Me.rbtTimer2Desligado.AutoSize = True
        Me.rbtTimer2Desligado.Checked = True
        Me.rbtTimer2Desligado.Location = New System.Drawing.Point(123, 6)
        Me.rbtTimer2Desligado.Name = "rbtTimer2Desligado"
        Me.rbtTimer2Desligado.Size = New System.Drawing.Size(118, 17)
        Me.rbtTimer2Desligado.TabIndex = 11
        Me.rbtTimer2Desligado.TabStop = True
        Me.rbtTimer2Desligado.Text = "Desligado - Turn off"
        Me.rbtTimer2Desligado.UseVisualStyleBackColor = True
        '
        'rbtTimer2Ligado
        '
        Me.rbtTimer2Ligado.AutoSize = True
        Me.rbtTimer2Ligado.ForeColor = System.Drawing.Color.Blue
        Me.rbtTimer2Ligado.Location = New System.Drawing.Point(13, 7)
        Me.rbtTimer2Ligado.Name = "rbtTimer2Ligado"
        Me.rbtTimer2Ligado.Size = New System.Drawing.Size(103, 17)
        Me.rbtTimer2Ligado.TabIndex = 10
        Me.rbtTimer2Ligado.Text = "Ligado - Turn on"
        Me.rbtTimer2Ligado.UseVisualStyleBackColor = True
        '
        'lblExplicacao7
        '
        Me.lblExplicacao7.Location = New System.Drawing.Point(12, 406)
        Me.lblExplicacao7.Name = "lblExplicacao7"
        Me.lblExplicacao7.Size = New System.Drawing.Size(630, 15)
        Me.lblExplicacao7.TabIndex = 28
        Me.lblExplicacao7.Text = "Detalhe2: Para mudar o tempo do 'timer', clique no botão ""OK"" correspondente ao '" &
    "timer'."
        '
        'lblExplanation1
        '
        Me.lblExplanation1.Location = New System.Drawing.Point(12, 42)
        Me.lblExplanation1.Name = "lblExplanation1"
        Me.lblExplanation1.Size = New System.Drawing.Size(630, 33)
        Me.lblExplanation1.TabIndex = 29
        Me.lblExplanation1.Text = resources.GetString("lblExplanation1.Text")
        '
        'lblExplanation4
        '
        Me.lblExplanation4.AutoSize = True
        Me.lblExplanation4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanation4.ForeColor = System.Drawing.Color.Brown
        Me.lblExplanation4.Location = New System.Drawing.Point(488, 220)
        Me.lblExplanation4.Name = "lblExplanation4"
        Me.lblExplanation4.Size = New System.Drawing.Size(102, 13)
        Me.lblExplanation4.TabIndex = 30
        Me.lblExplanation4.Text = "Press: ""1-2-3-4""."
        '
        'lblExplanation5
        '
        Me.lblExplanation5.Location = New System.Drawing.Point(14, 275)
        Me.lblExplanation5.Name = "lblExplanation5"
        Me.lblExplanation5.Size = New System.Drawing.Size(628, 31)
        Me.lblExplanation5.TabIndex = 31
        Me.lblExplanation5.Text = "If you put a ""refresh"" in the timers he can switch off over time. The problem tha" &
    "t is possible within this time put ' dirt '. Example: Type: ""1-A-2-3-4-5"". It wo" &
    "rks! For this I DIDN'T like."
        '
        'lblExplanation6
        '
        Me.lblExplanation6.Location = New System.Drawing.Point(14, 364)
        Me.lblExplanation6.Name = "lblExplanation6"
        Me.lblExplanation6.Size = New System.Drawing.Size(628, 31)
        Me.lblExplanation6.TabIndex = 32
        Me.lblExplanation6.Text = resources.GetString("lblExplanation6.Text")
        '
        'lblExplanation7
        '
        Me.lblExplanation7.Location = New System.Drawing.Point(12, 421)
        Me.lblExplanation7.Name = "lblExplanation7"
        Me.lblExplanation7.Size = New System.Drawing.Size(630, 15)
        Me.lblExplanation7.TabIndex = 33
        Me.lblExplanation7.Text = "Detail2: To change the time on the timer, click the ""OK"" button corresponding to " &
    "the timer."
        '
        'frmSolucao2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 456)
        Me.Controls.Add(Me.lblExplanation7)
        Me.Controls.Add(Me.lblExplanation6)
        Me.Controls.Add(Me.lblExplanation5)
        Me.Controls.Add(Me.lblExplanation4)
        Me.Controls.Add(Me.lblExplanation1)
        Me.Controls.Add(Me.lblExplicacao7)
        Me.Controls.Add(Me.btnOk3)
        Me.Controls.Add(Me.btnOk2)
        Me.Controls.Add(Me.btnOk1)
        Me.Controls.Add(Me.grbTimer2)
        Me.Controls.Add(Me.lblExplicacao4)
        Me.Controls.Add(Me.lblTempo)
        Me.Controls.Add(Me.txtTempoTimer3)
        Me.Controls.Add(Me.txtTempoTimer2)
        Me.Controls.Add(Me.txtTempoTimer1)
        Me.Controls.Add(Me.grbBotao4)
        Me.Controls.Add(Me.lblBotao4)
        Me.Controls.Add(Me.grbTimer3)
        Me.Controls.Add(Me.grbTimer1)
        Me.Controls.Add(Me.lblTimer3)
        Me.Controls.Add(Me.lblTimer2)
        Me.Controls.Add(Me.lblTimer1)
        Me.Controls.Add(Me.lblExplicacao6)
        Me.Controls.Add(Me.lblExplicacao5)
        Me.Controls.Add(Me.lblExplicacao1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolucao2"
        Me.ShowIcon = False
        Me.Text = "Solução 2"
        Me.grbTimer1.ResumeLayout(False)
        Me.grbTimer1.PerformLayout()
        Me.grbTimer3.ResumeLayout(False)
        Me.grbTimer3.PerformLayout()
        Me.grbBotao4.ResumeLayout(False)
        Me.grbBotao4.PerformLayout()
        Me.grbTimer2.ResumeLayout(False)
        Me.grbTimer2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lblExplicacao5 As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao1 As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao6 As System.Windows.Forms.Label
    Friend WithEvents lblTimer1 As System.Windows.Forms.Label
    Friend WithEvents lblTimer2 As System.Windows.Forms.Label
    Friend WithEvents lblTimer3 As System.Windows.Forms.Label
    Friend WithEvents grbTimer1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTimer1Desligado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTimer1Ligado As System.Windows.Forms.RadioButton
    Friend WithEvents grbTimer3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTimer3Desligado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTimer3Ligado As System.Windows.Forms.RadioButton
    Friend WithEvents lblBotao4 As System.Windows.Forms.Label
    Friend WithEvents grbBotao4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtBotao4Desligado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtBotao4Ligado As System.Windows.Forms.RadioButton
    Friend WithEvents txtTempoTimer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTempoTimer2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTempoTimer3 As System.Windows.Forms.TextBox
    Friend WithEvents lblTempo As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao4 As System.Windows.Forms.Label
    Friend WithEvents btnOk1 As System.Windows.Forms.Button
    Friend WithEvents btnOk2 As System.Windows.Forms.Button
    Friend WithEvents btnOk3 As System.Windows.Forms.Button
    Friend WithEvents grbTimer2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTimer2Desligado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTimer2Ligado As System.Windows.Forms.RadioButton
    Friend WithEvents lblExplicacao7 As System.Windows.Forms.Label
    Friend WithEvents lblExplanation1 As Label
    Friend WithEvents lblExplanation4 As Label
    Friend WithEvents lblExplanation5 As Label
    Friend WithEvents lblExplanation6 As Label
    Friend WithEvents lblExplanation7 As Label
End Class
