Option Strict On
Option Explicit On

Public Class frmSolucao3
    Private arrstrAcesso(7) As String
    Private blnPrimeiraChamada As Boolean = False

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True
        Me.MdiParent = mdiEasterEgg
    End Sub

    'Acumular dentro do valor da array acima somente se a sequencia estive seguindo um caminho correto.
    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim blnPreenche As Boolean = True
        Dim blnDispara As Boolean = True
        Dim arrstrChave() As String = New String(7) {"1", "2", "3", "4", "5", "6", "7", "8"}

        ListBox1.Items.Add("KeyData = " & e.KeyData & " - " & "KeyCode = " & e.KeyCode & " - " & "KeyValue = " & e.KeyValue)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1

        'Não aceita Shift, Ctrl, Alt
        If e.KeyData < 0 Or e.KeyData > 255 Then Exit Sub

        For bytI As Byte = 0 To CByte(arrstrChave.Length - 1)

            If IsNothing(arrstrAcesso(bytI)) Then
                arrstrAcesso(bytI) = Strings.Chr(e.KeyData)

                If IsNothing(arrstrAcesso(CByte(arrstrChave.Length - 1))) Then
                    blnPreenche = False
                    Exit For
                End If

            End If

        Next

        If blnPreenche Then

            If blnPrimeiraChamada Then

                For bytI As Byte = 0 To CByte(arrstrChave.Length - 1)
                    arrstrAcesso(bytI) = arrstrAcesso(bytI + 1)

                    If bytI = arrstrChave.Length - 2 Then
                        arrstrAcesso(bytI + 1) = Strings.Chr(e.KeyData)
                        Exit For
                    End If

                Next

            Else
                blnPrimeiraChamada = True
            End If

            For bytI As Byte = 0 To CByte(arrstrChave.Length - 1)

                If Not arrstrAcesso(bytI) = arrstrChave(bytI) Then
                    blnDispara = False
                    Exit For
                End If

            Next

            If blnDispara Then
                MessageBox.Show("Easter Egg", "Solução 3")
            End If

        End If

    End Sub

    Private Sub frmSolucao3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        txtLinha.Text = CStr(e.X)
        txtColuna.Text = CStr(e.Y)

        If e.X <= 100 And e.Y <= 100 Then
            rbtKeyPreviewLigado.Checked = True
            KeyPreview = True
        Else
            rbtKeyPreviewDesligado.Checked = True
            KeyPreview = False
        End If

    End Sub

    'Para o usuário não alterar o estado do radiobutton clicando... somente pode alterar usando o teclado.
    Private Sub rbtKeyPreviewLigado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtKeyPreviewLigado.CheckedChanged
        rbtKeyPreviewDesligado.Focus()
    End Sub

End Class