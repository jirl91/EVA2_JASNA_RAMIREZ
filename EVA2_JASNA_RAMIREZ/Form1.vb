
Imports MySql.Data.MySqlClient

Public Class Form1

    ' Cadena de conexión para MySQL
    Dim connectionString As String = "Server=localhost;Database=registropersona;User ID='root';Password='';"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Consulta para obtener los nombres de las comunas
                Dim sql As String = "SELECT NombreComuna FROM comuna"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cbComuna.Items.Clear() ' Limpiar el ComboBox antes de llenarlo
                        While reader.Read()
                            ' Agregar los nombres de las comunas al ComboBox
                            cbComuna.Items.Add(reader("NombreComuna").ToString())
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al cargar las comunas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub




    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String

        ' Validar la selección del sexo
        If RdoMasculino.Checked Then
            sexo = "Masculino"
        ElseIf RdoFemenino.Checked Then
            sexo = "Femenino"
        ElseIf RdoNoEspecificada.Checked Then
            sexo = "No especifica"
        Else
            MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener otros campos
        Dim comuna As String = cbComuna.SelectedItem?.ToString()
        Dim ciudad As String = txtCiudad.Text
        Dim observacion As String = txtObservacion.Text

        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "INSERT INTO Personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                    "VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpiar el formulario después de guardar
                    LimpiarFormulario()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Método para limpiar el formulario
    Private Sub LimpiarFormulario()
        txtRut.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        RdoMasculino.Checked = False
        RdoFemenino.Checked = False
        RdoNoEspecificada.Checked = False
        cbComuna.SelectedIndex = -1
        txtRut.Focus() ' Colocar el foco en el campo RUT
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim rut As String = txtRut.Text

        ' Validar que el RUT no esté vacío
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese el RUT para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buscar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "SELECT Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion FROM Personas WHERE RUT = @rut"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Si se encuentra un registro, llenar los campos del formulario
                            txtNombre.Text = reader("Nombre").ToString()
                            txtApellido.Text = reader("Apellido").ToString()
                            Dim sexo As String = reader("Sexo").ToString()
                            cbComuna.SelectedItem = reader("Comuna").ToString()
                            txtCiudad.Text = reader("Ciudad").ToString()
                            txtObservacion.Text = reader("Observacion").ToString()

                            ' Seleccionar el radio button correspondiente al sexo
                            If sexo = "Masculino" Then
                                RdoMasculino.Checked = True
                            ElseIf sexo = "Femenino" Then
                                RdoFemenino.Checked = True
                            Else
                                RdoNoEspecificada.Checked = True
                            End If

                            MessageBox.Show("Datos encontrados y cargados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se encontraron datos para el RUT ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al buscar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click

        ' Limpiar los campos de texto
        txtRut.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCiudad.Text = ""
        txtObservacion.Text = ""

        ' Limpiar los radio buttons
        RdoMasculino.Checked = False
        RdoFemenino.Checked = False
        RdoNoEspecificada.Checked = False

        ' Limpiar la selección del combo box
        cbComuna.SelectedIndex = -1

        ' Opcional: Reiniciar el enfoque al primer campo
        txtRut.Focus()

    End Sub


End Class