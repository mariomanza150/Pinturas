Imports System.Data.OleDb
Public Class Visualizer
    Dim strFileName As String
    Private Sub bttn_return_Click(sender As Object, e As EventArgs) Handles bttn_salir.Click
        Me.Close()
    End Sub

    Private Sub bttn_clean_Click(sender As Object, e As EventArgs) Handles bttn_limpiar.Click
        txt_id.Clear()
        txt_nombre.Clear()
        txt_autor.Clear()
        txt_tipo.Clear()
        txt_estilo.Clear()
        txt_dimesiones.Clear()
        txt_ubicacion.Clear()
        pic_imagen.Image = Nothing
    End Sub

    Private Sub bttn_find_Click(sender As Object, e As EventArgs) Handles bttn_buscar.Click
        Dim BUSCAR = "SELECT * FROM Pinturas WHERE Id=@Id"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Id", txt_id.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txt_nombre.Text = Lectura(1)
            txt_autor.Text = Lectura(2)
            txt_tipo.Text = Lectura(3)
            txt_estilo.Text = Lectura(4)
            dt_fecha.Value = Lectura(5)
            txt_dimesiones.Text = Lectura(6)
            txt_ubicacion.Text = Lectura(7)
            If IsDBNull(Lectura(8)) Then
                pic_imagen.Image = Nothing
            Else
                pic_imagen.ImageLocation = Lectura(8)
            End If
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Agenda")
            txt_id.Clear()
            txt_id.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub bttn_add_Click(sender As Object, e As EventArgs) Handles bttn_agregar.Click
        Try
            Dim Insertar = "Insert Into Pinturas Values (@Id, @Nombre, @Autor, @Tipo, @Estilo, @Fecha, @Dimensiones, @Ubicacion, @Imagen)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text)
            Cmd.Parameters.AddWithValue("@Autor", txt_autor.Text)
            Cmd.Parameters.AddWithValue("@Tipo", txt_tipo.Text)
            Cmd.Parameters.AddWithValue("@Estilo", txt_estilo.Text)
            Cmd.Parameters.AddWithValue("@Fecha", dt_fecha.Value)
            Cmd.Parameters.AddWithValue("@Dimensiones", txt_dimesiones.Text)
            Cmd.Parameters.AddWithValue("@Ubicacion", txt_ubicacion.Text)
            pic_imagen.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Imagen", pic_imagen.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos fueron Registrados")
        Catch ex As Exception
            MsgBox("Los datos a Registrar Ya Existen")
        End Try
    End Sub

    Private Sub bttn_modify_Click(sender As Object, e As EventArgs) Handles bttn_modificar.Click
        Try
            Dim Actualizar = "UPDATE Pinturas SET Nombre=@Nombre, Autor=@Autor, Tipo=@Tipo, Estilo=@Estilo, Fecha=@Fecha, Dimensiones=@Dimensiones, Ubicacion=@Ubicacion, Imagen=@Imagen WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text)
            Cmd.Parameters.AddWithValue("@Autor", txt_autor.Text)
            Cmd.Parameters.AddWithValue("@Tipo", txt_tipo.Text)
            Cmd.Parameters.AddWithValue("@Estilo", txt_estilo.Text)
            Cmd.Parameters.AddWithValue("@Fecha", dt_fecha.Value)
            Cmd.Parameters.AddWithValue("@Dimensiones", txt_dimesiones.Text)
            Cmd.Parameters.AddWithValue("@Ubicacion", txt_ubicacion.Text)
            pic_imagen.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Imagen", pic_imagen.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bttn_delete_Click(sender As Object, e As EventArgs) Handles bttn_eliminar.Click
        Try
            Dim Eliminar = "DELETE FROM Pinturas WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los datos Fueron Eliminados....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txt_id.Clear()
        txt_nombre.Clear()
        txt_autor.Clear()
        txt_tipo.Clear()
        txt_estilo.Clear()
        txt_dimesiones.Clear()
        txt_ubicacion.Clear()
        pic_imagen.Image = Nothing
        txt_id.Focus()
    End Sub

    Private Sub bttn_image_Click(sender As Object, e As EventArgs) Handles bttn_imagen.Click
        Dim dialog As New OpenFileDialog
        With dialog
            .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 1
            .Title = "Abrir un archivo de imagen"
        End With
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = dialog.FileName
                pic_imagen.Image = Image.FromFile(strFileName)
                dialog.Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class