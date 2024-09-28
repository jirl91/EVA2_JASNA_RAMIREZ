<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtRut = New TextBox()
        Buscar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        RdoNoEspecificada = New RadioButton()
        RdoFemenino = New RadioButton()
        RdoMasculino = New RadioButton()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cbComuna = New ComboBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtCiudad = New TextBox()
        txtObservacion = New TextBox()
        Guardar = New Button()
        Limpiar = New Button()
        Label8 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 20)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(167, 50)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(245, 27)
        txtRut.TabIndex = 1
        ' 
        ' Buscar
        ' 
        Buscar.Location = New Point(475, 73)
        Buscar.Name = "Buscar"
        Buscar.Size = New Size(94, 29)
        Buscar.TabIndex = 2
        Buscar.Text = "Buscar"
        Buscar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 4
        Label3.Text = "Apellidos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RdoNoEspecificada)
        GroupBox1.Controls.Add(RdoFemenino)
        GroupBox1.Controls.Add(RdoMasculino)
        GroupBox1.Location = New Point(65, 269)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(504, 87)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo"
        ' 
        ' RdoNoEspecificada
        ' 
        RdoNoEspecificada.AutoSize = True
        RdoNoEspecificada.Location = New Point(372, 51)
        RdoNoEspecificada.Name = "RdoNoEspecificada"
        RdoNoEspecificada.Size = New Size(120, 24)
        RdoNoEspecificada.TabIndex = 2
        RdoNoEspecificada.TabStop = True
        RdoNoEspecificada.Text = "No especifica"
        RdoNoEspecificada.UseVisualStyleBackColor = True
        ' 
        ' RdoFemenino
        ' 
        RdoFemenino.AutoSize = True
        RdoFemenino.Location = New Point(188, 51)
        RdoFemenino.Name = "RdoFemenino"
        RdoFemenino.Size = New Size(95, 24)
        RdoFemenino.TabIndex = 1
        RdoFemenino.TabStop = True
        RdoFemenino.Text = "Femenino"
        RdoFemenino.UseVisualStyleBackColor = True
        ' 
        ' RdoMasculino
        ' 
        RdoMasculino.AutoSize = True
        RdoMasculino.Location = New Point(15, 51)
        RdoMasculino.Name = "RdoMasculino"
        RdoMasculino.Size = New Size(97, 24)
        RdoMasculino.TabIndex = 0
        RdoMasculino.TabStop = True
        RdoMasculino.Text = "Masculino"
        RdoMasculino.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(65, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 7
        Label5.Text = "Comuna"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(67, 440)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 8
        Label6.Text = "Ciudad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(67, 494)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 20)
        Label7.TabIndex = 9
        Label7.Text = "Observacion"
        ' 
        ' cbComuna
        ' 
        cbComuna.FormattingEnabled = True
        cbComuna.Location = New Point(167, 384)
        cbComuna.Name = "cbComuna"
        cbComuna.Size = New Size(245, 28)
        cbComuna.TabIndex = 10
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(167, 142)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(245, 27)
        txtNombre.TabIndex = 11
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(167, 194)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(245, 27)
        txtApellido.TabIndex = 12
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(167, 433)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(245, 27)
        txtCiudad.TabIndex = 13
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(167, 487)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(245, 27)
        txtObservacion.TabIndex = 14
        ' 
        ' Guardar
        ' 
        Guardar.Location = New Point(216, 550)
        Guardar.Name = "Guardar"
        Guardar.Size = New Size(143, 29)
        Guardar.TabIndex = 15
        Guardar.Text = "Guardar MySql"
        Guardar.UseVisualStyleBackColor = True
        ' 
        ' Limpiar
        ' 
        Limpiar.Location = New Point(475, 125)
        Limpiar.Name = "Limpiar"
        Limpiar.Size = New Size(94, 29)
        Limpiar.TabIndex = 16
        Limpiar.Text = "Limpiar"
        Limpiar.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(167, 92)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 20)
        Label8.TabIndex = 17
        Label8.Text = "Ejemplo: 189996668"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 606)
        Controls.Add(Label8)
        Controls.Add(Limpiar)
        Controls.Add(Guardar)
        Controls.Add(txtObservacion)
        Controls.Add(txtCiudad)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(cbComuna)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Buscar)
        Controls.Add(txtRut)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "EVA2_JASNA_RAMIREZ"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdoNoEspecificada As RadioButton
    Friend WithEvents RdoFemenino As RadioButton
    Friend WithEvents RdoMasculino As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbComuna As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Guardar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Label8 As Label

End Class
