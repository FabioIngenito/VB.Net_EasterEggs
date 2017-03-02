Option Strict On
Option Explicit On

Public Class frmSolucao2
    'How to add an easter egg to your Program in Visual Basic 2008 
    'http://www.youtube.com/watch?v=ara5iTh-D_o
    'Just a short video on how you can add an easter egg to your Visual Basic 2008 Program by typing a code, keyword, or hitting any series of buttons. 
    'In this example, I used the combination 1234, just for an example.
    'Code (Just paste it right in to any of your programs, changing Form2 to whatever your form is called.): 

    Private Sub frmSolucao2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True
        Me.MdiParent = mdiEasterEgg
    End Sub

    Private Sub frmSolucao2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Note: D1, D2, D3, and D4 are just the numbers above Q, W, E, and R. Change the Keys.D1 to whatever you want. 
        Dim blnAcesso As Boolean = True

        If e.KeyCode = Keys.D1 Then
            Timer1.Enabled = True
            rbtTimer1Ligado.Checked = True
        End If

        If e.KeyCode = Keys.D2 And Timer1.Enabled Then
            Timer2.Enabled = True
            rbtTimer2Ligado.Checked = True
        End If

        If e.KeyCode = Keys.D3 And Timer1.Enabled And Timer2.Enabled Then
            Timer3.Enabled = True
            rbtTimer3Ligado.Checked = True
        End If

        If e.KeyCode = Keys.D4 And Timer1.Enabled And Timer2.Enabled And Timer3.Enabled Then
            'Put what you want to be an easter egg here. 
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            rbtBotao4Ligado.Checked = True
            MessageBox.Show("Easter Egg", "Solução 2")
            rbtTimer1Desligado.Checked = True
            rbtTimer2Desligado.Checked = True
            rbtTimer3Desligado.Checked = True
            rbtBotao4Desligado.Checked = True
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        rbtTimer1Desligado.Checked = True
        rbtTimer1Desligado.Focus()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        rbtTimer2Desligado.Checked = True
        rbtTimer2Desligado.Focus()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        rbtTimer3Desligado.Checked = True
        rbtTimer3Desligado.Focus()
    End Sub

    'Garante que o Timer 1 não receberá valores diferentes de números
    Private Sub txtTempoTimer1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempoTimer1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back Then e.Handled = True
    End Sub

    'Garante que o Timer 2 não receberá valores diferentes de números
    Private Sub txtTempoTimer2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempoTimer2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back Then e.Handled = True
    End Sub

    'Garante que o Timer 3 não receberá valores diferentes de números
    Private Sub txtTempoTimer3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempoTimer3.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back Then e.Handled = True
    End Sub

    'Para o usuário não alterar o estado do radiobutton clicando... somente pode alterar usando o teclado.
    Private Sub rbtTimer1Ligado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtTimer1Ligado.Click
        rbtTimer1Desligado.Focus()
    End Sub

    'Para o usuário não alterar o estado do radiobutton clicando... somente pode alterar usando o teclado.
    Private Sub rbtTimer2Ligado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtTimer2Ligado.Click
        rbtTimer2Desligado.Focus()
    End Sub

    'Para o usuário não alterar o estado do radiobutton clicando... somente pode alterar usando o teclado.
    Private Sub rbtTimer3Ligado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtTimer3Ligado.Click
        rbtTimer3Desligado.Focus()
    End Sub

    'Para o usuário não alterar o estado do radiobutton clicando... somente pode alterar usando o teclado.
    Private Sub rbtBotao4Ligado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtBotao4Ligado.Click
        rbtBotao4Desligado.Focus()
    End Sub

    'Se o timer 1 for maior que zero acito o valor, senão define tudo como 10 segundos.
    Private Sub btnOk1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk1.Click

        If Not txtTempoTimer1.Text.Trim = "" AndAlso CType(txtTempoTimer1.Text, Integer) > 0 Then
            Timer1.Interval = CType(txtTempoTimer1.Text, Integer)
        Else
            txtTempoTimer1.Text = "10000"
            Timer1.Interval = 10000
        End If

    End Sub

    'Se o timer 2 for maior que zero acito o valor, senão define tudo como 10 segundos.
    Private Sub btnOk2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk2.Click

        If Not txtTempoTimer2.Text.Trim = "" AndAlso CType(txtTempoTimer2.Text, Integer) > 0 Then
            Timer2.Interval = CType(txtTempoTimer2.Text, Integer)
        Else
            txtTempoTimer2.Text = "10000"
            Timer2.Interval = 10000
        End If

    End Sub

    'Se o timer 3 for maior que zero acito o valor, senão define tudo como 10 segundos.
    Private Sub btnOk3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk3.Click

        If Not txtTempoTimer3.Text.Trim = "" AndAlso CType(txtTempoTimer3.Text, Integer) > 0 Then
            Timer3.Interval = CType(txtTempoTimer3.Text, Integer)
        Else
            txtTempoTimer3.Text = "10000"
            Timer3.Interval = 10000
        End If

    End Sub

    'Quando recebe o foco, não pode ter o "KeyPreview ligado, senão confundirá a digitação do numérico "1" (um).
    Private Sub txtTempoTimer1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTempoTimer1.GotFocus, txtTempoTimer2.GotFocus, txtTempoTimer3.GotFocus
        KeyPreview = False
    End Sub

    'Quando perde o foco, pode voltar ao normal aceitando a digitação do numérico "1" (um).
    Private Sub txtTempoTimer1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTempoTimer1.LostFocus, txtTempoTimer2.LostFocus, txtTempoTimer3.LostFocus
        KeyPreview = True
    End Sub

End Class