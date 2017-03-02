Option Strict On
Option Explicit On

Imports Microsoft.VisualBasic

'SAIU DO AR - WENT OFF THE AIR:
'http://vbdotnetforum.com/index.php?/topic/44-easter-egg/

Public Class frmSolucao1
    Dim imgGuarda As Image

    Private Sub frmSolucao1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True

        Me.Height = 240
        Me.MdiParent = mdiEasterEgg

        imgGuarda = PictureBox1.Image
    End Sub

    Private Sub frmSolucao1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim ShiftMask As Boolean
        Dim CtlMask As Boolean

        ShiftMask = (CInt(e.Shift) And Keys.Shift) > 0
        CtlMask = (CInt(e.Control) And Keys.Control) > 0

        'Este trecho só funciona se for teclado "Ctrl+Shif+S".
        If ShiftMask = True And CtlMask = True And e.KeyCode = Keys.S Then

            txtTestaOutroEasterEgg.Visible = Not txtTestaOutroEasterEgg.Visible
            If txtTestaOutroEasterEgg.Visible Then txtTestaOutroEasterEgg.Focus()
            lblExplicacao6.Visible = Not lblExplicacao6.Visible
            If Me.Height = 480 Then Me.Height = 240 Else Me.Height = 480

            txtTestaOutroEasterEgg2.Visible = False
            txtTestaOutroEasterEgg2.Text = ""
            lblExplicacao8.Visible = False
            lblExplanation8.Visible = False
            PictureBox1.Visible = False
        End If

    End Sub

    Private Sub txtTestaOutroEasterEgg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTestaOutroEasterEgg.KeyDown
        Dim ShiftMask As Boolean
        Dim CtlMask As Boolean

        ShiftMask = (CInt(e.Shift) And Keys.Shift) > 0
        CtlMask = (CInt(e.Control) And Keys.Control) > 0

        If ShiftMask = True And CtlMask = True And e.KeyCode = Keys.T Then
            MsgBox("Easter Egg dentro da TextBox, leia o texto a seguir... " & vbCrLf & "Easter Egg inside the TextBox, please read the following text...", , "Solução 1 TextBox")
            txtTestaOutroEasterEgg2.Visible = True
            txtTestaOutroEasterEgg2.Focus()
            txtTestaOutroEasterEgg2.Text = "Agora o ""Ctrl+Shift+T"" NÃO funciona mais pq o cursor está aqui! Teste e depois pressione ""Crtl+Shift+S"" novamente. "
            txtTestaOutroEasterEgg2.Text = txtTestaOutroEasterEgg2.Text & vbCrLf & "Now the ""Ctrl+Shift+T"" no longer works because the cursor is here! Test and then press ""Crtl + Shift + S"" again."

            lblExplicacao8.Visible = True
            lblExplanation8.Visible = True
            PictureBox1.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = PictureBox1.InitialImage
        KeyPreview = False
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = imgGuarda
        KeyPreview = True
    End Sub

End Class
