'------------------------------------------------------------------------------
' Detectar varias pulsaciones de teclas (ejemplo de VB)             (01/Oct/20)
' Proyecto para .NET Framework 4.8
'
' Válido para simples pulsaciones al estilo Ctrl+B
' o de varias teclas seguidas: Ctrl+K, Ctrl+L
'
' Para ejemplo de artículo en http://www.elguillemola.com:
'
'
' Código convertido del proyecto de C# a VB ;-)
'
' (c) Guillermo (elGuille) Som, 2020
'------------------------------------------------------------------------------
Option Strict On
Option Infer On

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Centrar el formulario
        Me.CenterToScreen()

        ' Detectar todas las pulsaciones en el formulario
        Me.KeyPreview = True

        ' mostrar las teclas que se quieren detectar
        txtTeclasDetectar.Text = "Simples:
Ctrl+B
Ctrl+Shift+V

Dobles:
Shift+Alt+L, Shift+Alt+S
Ctrl+K, Ctrl+C
Ctrl+K, Ctrl+U
Ctrl+K, Ctrl+L
Ctrl+K, Ctrl+K"
    End Sub

    ' Para doble pulsación de teclas
    Private CtrlK As Integer
    Private CtrlC As Integer
    Private CtrlU As Integer
    Private CtrlL As Integer
    Private ShiftAltL As Integer
    Private ShiftAltS As Integer

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Comprobaciones para Ctrl+Shift

        ' esta de forma simple
        If e.Control AndAlso e.Shift Then
            If e.KeyCode = Keys.V Then
                e.Handled = True

                'MostrarRecortes();
                txtPulsadas.Text = "Capturada: Ctrl+Shift+V" & vbCrLf & txtPulsadas.Text
            End If

            ' Estas son con varias combinaciones

            ' Comprobaciones para Shift+Alt
        ElseIf e.Shift AndAlso e.Alt Then
            ' si se ha pulsado Shift+Alt+L
            If e.KeyCode = Keys.L Then
                e.Handled = True

                ShiftAltL += 1
                ' si se ha pulsado Shift+Alt+S
            ElseIf e.KeyCode = Keys.S Then
                e.Handled = True

                ShiftAltS += 1
            End If
            ' Si se ha pulsado Shitf+Alt+S, Shift+Alt+L
            ' (en cualquier orden)
            If ShiftAltL = 1 AndAlso ShiftAltS = 1 Then
                e.Handled = True

                'ClasificarSeleccion();
                txtPulsadas.Text = "Capturada: Shift+Alt+L, Shift+Alt+S" & vbCrLf & txtPulsadas.Text
            End If

            ' Comprobaciones para solo la tecla Ctrl (sin Shift ni Alt)
        ElseIf e.Control AndAlso Not e.Shift AndAlso Not e.Alt Then
            ' Solo se ha pulsado la tecla Ctrl
            ' comprobar el resto de combinaciones
            ' Forma simple si se ha pulsado Ctrl+B
            If e.KeyCode = Keys.B Then
                e.Handled = True

                ' Esta solo es para detectar
                ' la combinación 'simple' de Ctrl+B
                ' No es necesario llevar la cuenta de las pulsaciones
                txtPulsadas.Text = "Capturada: Ctrl+B" & vbCrLf & txtPulsadas.Text

            ElseIf e.KeyCode = Keys.K Then
                e.Handled = True

                CtrlK += 1
                txtPulsadas.Text = "Ctrl+K - " & txtPulsadas.Text
            ElseIf e.KeyCode = Keys.C Then
                e.Handled = True

                CtrlC += 1
                txtPulsadas.Text = "Ctrl+C - " & txtPulsadas.Text
            ElseIf e.KeyCode = Keys.U Then
                e.Handled = True

                CtrlU += 1
                txtPulsadas.Text = "Ctrl+U - " & txtPulsadas.Text
            ElseIf e.KeyCode = Keys.L Then
                e.Handled = True

                CtrlL += 1
                txtPulsadas.Text = "Ctrl+L - " & txtPulsadas.Text
            End If

            ' Si se ha pulsado Ctrl+K, CtrlC
            If CtrlK = 1 AndAlso CtrlC = 1 Then
                e.Handled = True

                ' Ctrl+K, Ctrl+C
                CtrlK = 0
                CtrlC = 0
                'PonerComentarios(richTextBoxCodigo);
                txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+C" & vbCrLf & txtPulsadas.Text

                ' Si se ha pulsado Ctrl+K, Ctrl+U
            ElseIf CtrlK = 1 AndAlso CtrlU = 1 Then
                e.Handled = True

                ' Ctrl+K, Ctrl+U
                CtrlK = 0
                CtrlU = 0
                'QuitarComentarios(richTextBoxCodigo);
                txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+U" & vbCrLf & txtPulsadas.Text

                ' Si se ha pulsado Ctrl+K, Ctrl+L
            ElseIf CtrlK = 1 AndAlso CtrlL = 1 Then
                e.Handled = True

                ' Ctrl+K, Ctrl+L
                CtrlK = 0
                CtrlL = 0
                ' preguntar
                'buttonEditorMarcadorQuitarTodos.PerformClick();
                txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+L" & vbCrLf & txtPulsadas.Text

                ' Si se ha pulsado Ctrl+K, Ctrl+K
            ElseIf CtrlK = 2 Then
                e.Handled = True

                ' Ctrl+K, Ctrl+K
                CtrlK = 0
                'MarcadorPonerQuitar();

                txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+K" & vbCrLf & txtPulsadas.Text
            End If
        Else
            txtPulsadas.Text = $"{vbCrLf}No es una de las teclas comprobadas: {e.KeyCode} +{vbCrLf}" &
                               $"    Ctrl: {e.Control}, Shift: {e.Shift}, Alt: {e.Alt}{vbCrLf}" & txtPulsadas.Text

            CtrlK = 0
            CtrlC = 0
            CtrlU = 0
            ShiftAltL = 0
            ShiftAltS = 0

            ' Otras pulsaciones
            ' No están detectadas explícitamente

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPulsadas.Clear()

    End Sub

End Class
