<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        components = New System.ComponentModel.Container()

        Me.txtPulsada = New Windows.Forms.TextBox
        Me.label1 = New Windows.Forms.Label
        Me.label2 = New Windows.Forms.Label
        Me.txtPulsadas = New Windows.Forms.TextBox
        Me.btnLimpiar = New Windows.Forms.Button
        Me.txtTeclasDetectar = New Windows.Forms.TextBox
        Me.SuspendLayout()
        ' 
        ' txtPulsada
        ' 
        Me.txtPulsada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), Windows.Forms.AnchorStyles)
        Me.txtPulsada.Font = New Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
        Me.txtPulsada.Location = New Drawing.Point(134, 12)
        Me.txtPulsada.Name = "txtPulsada"
        Me.txtPulsada.Size = New Drawing.Size(414, 23)
        Me.txtPulsada.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.Location = New Drawing.Point(12, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New Drawing.Size(116, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Tecla pulsada:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ' 
        ' label2
        ' 
        Me.label2.Location = New Drawing.Point(12, 38)
        Me.label2.Margin = New Windows.Forms.Padding(3)
        Me.label2.Name = "label2"
        Me.label2.Size = New Drawing.Size(116, 20)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Teclas pulsadas:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ' 
        ' txtPulsadas
        ' 
        Me.txtPulsadas.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), Windows.Forms.AnchorStyles)
        Me.txtPulsadas.Font = New Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
        Me.txtPulsadas.Location = New Drawing.Point(134, 38)
        Me.txtPulsadas.Multiline = True
        Me.txtPulsadas.Name = "txtPulsadas"
        Me.txtPulsadas.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPulsadas.Size = New Drawing.Size(414, 280)
        Me.txtPulsadas.TabIndex = 3
        ' 
        ' btnLimpiar
        ' 
        Me.btnLimpiar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Location = New Drawing.Point(473, 331)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        'AddHandler Me.btnLimpiar.Click, New EventHandler(AddressOf Me.btnLimpiar_Click)
        ' 
        ' txtTeclasDetectar
        ' 
        Me.txtTeclasDetectar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left)), Windows.Forms.AnchorStyles)
        Me.txtTeclasDetectar.Font = New Drawing.Font("Consolas", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
        Me.txtTeclasDetectar.Location = New Drawing.Point(12, 67)
        Me.txtTeclasDetectar.Multiline = True
        Me.txtTeclasDetectar.Name = "txtTeclasDetectar"
        Me.txtTeclasDetectar.[ReadOnly] = True
        Me.txtTeclasDetectar.Size = New Drawing.Size(116, 251)
        Me.txtTeclasDetectar.TabIndex = 4
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New Drawing.Size(579, 366)
        Me.Controls.Add(Me.txtTeclasDetectar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtPulsadas)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtPulsada)
        Me.MinimumSize = New Drawing.Size(540, 320)
        Me.Name = "Form1"
        Me.Text = "Detectar la pulsación de varias teclas (VB con .NET Framework 4.8)"
        'AddHandler Me.Load, New EventHandler(AddressOf Me.Form1_Load)
        'AddHandler Me.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf Me.Form1_KeyDown)
        Me.ResumeLayout(False)
        Me.PerformLayout()


        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.ClientSize = New System.Drawing.Size(800, 450)
        'Me.Text = "Form1"
    End Sub

    Private WithEvents txtPulsada As Windows.Forms.TextBox
    Private label1 As Windows.Forms.Label
    Private label2 As Windows.Forms.Label
    Private WithEvents txtPulsadas As Windows.Forms.TextBox
    Private WithEvents btnLimpiar As Windows.Forms.Button
    Private WithEvents txtTeclasDetectar As Windows.Forms.TextBox

End Class
