<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualizer
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
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_autor = New System.Windows.Forms.TextBox()
        Me.lbl_autor = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.txt_estilo = New System.Windows.Forms.TextBox()
        Me.lbl_estilo = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.txt_dimesiones = New System.Windows.Forms.TextBox()
        Me.lbl_dimensiones = New System.Windows.Forms.Label()
        Me.txt_ubicacion = New System.Windows.Forms.TextBox()
        Me.lbl_ubicacion = New System.Windows.Forms.Label()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.pic_imagen = New System.Windows.Forms.PictureBox()
        Me.bttn_limpiar = New System.Windows.Forms.Button()
        Me.bttn_buscar = New System.Windows.Forms.Button()
        Me.bttn_agregar = New System.Windows.Forms.Button()
        Me.bttn_modificar = New System.Windows.Forms.Button()
        Me.bttn_eliminar = New System.Windows.Forms.Button()
        Me.bttn_salir = New System.Windows.Forms.Button()
        Me.bttn_imagen = New System.Windows.Forms.Button()
        CType(Me.pic_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = Global.Pinturas.My.MySettings.Default.Cnx
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(27, 32)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(31, 23)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "ID"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(145, 29)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(78, 30)
        Me.txt_id.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(145, 65)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(289, 30)
        Me.txt_nombre.TabIndex = 3
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(27, 68)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(68, 23)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_autor
        '
        Me.txt_autor.Location = New System.Drawing.Point(145, 101)
        Me.txt_autor.Name = "txt_autor"
        Me.txt_autor.Size = New System.Drawing.Size(289, 30)
        Me.txt_autor.TabIndex = 5
        '
        'lbl_autor
        '
        Me.lbl_autor.AutoSize = True
        Me.lbl_autor.Location = New System.Drawing.Point(27, 104)
        Me.lbl_autor.Name = "lbl_autor"
        Me.lbl_autor.Size = New System.Drawing.Size(53, 23)
        Me.lbl_autor.TabIndex = 4
        Me.lbl_autor.Text = "Autor"
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(145, 137)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(289, 30)
        Me.txt_tipo.TabIndex = 7
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(27, 140)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(43, 23)
        Me.lbl_tipo.TabIndex = 6
        Me.lbl_tipo.Text = "Tipo"
        '
        'txt_estilo
        '
        Me.txt_estilo.Location = New System.Drawing.Point(145, 173)
        Me.txt_estilo.Name = "txt_estilo"
        Me.txt_estilo.Size = New System.Drawing.Size(289, 30)
        Me.txt_estilo.TabIndex = 9
        '
        'lbl_estilo
        '
        Me.lbl_estilo.AutoSize = True
        Me.lbl_estilo.Location = New System.Drawing.Point(27, 176)
        Me.lbl_estilo.Name = "lbl_estilo"
        Me.lbl_estilo.Size = New System.Drawing.Size(52, 23)
        Me.lbl_estilo.TabIndex = 8
        Me.lbl_estilo.Text = "Estilo"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(27, 212)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(52, 23)
        Me.lbl_fecha.TabIndex = 10
        Me.lbl_fecha.Text = "Fecha"
        '
        'txt_dimesiones
        '
        Me.txt_dimesiones.Location = New System.Drawing.Point(145, 245)
        Me.txt_dimesiones.Name = "txt_dimesiones"
        Me.txt_dimesiones.Size = New System.Drawing.Size(289, 30)
        Me.txt_dimesiones.TabIndex = 13
        '
        'lbl_dimensiones
        '
        Me.lbl_dimensiones.AutoSize = True
        Me.lbl_dimensiones.Location = New System.Drawing.Point(27, 248)
        Me.lbl_dimensiones.Name = "lbl_dimensiones"
        Me.lbl_dimensiones.Size = New System.Drawing.Size(97, 23)
        Me.lbl_dimensiones.TabIndex = 12
        Me.lbl_dimensiones.Text = "Dimensiones"
        '
        'txt_ubicacion
        '
        Me.txt_ubicacion.Location = New System.Drawing.Point(145, 281)
        Me.txt_ubicacion.Name = "txt_ubicacion"
        Me.txt_ubicacion.Size = New System.Drawing.Size(289, 30)
        Me.txt_ubicacion.TabIndex = 15
        '
        'lbl_ubicacion
        '
        Me.lbl_ubicacion.AutoSize = True
        Me.lbl_ubicacion.Location = New System.Drawing.Point(27, 284)
        Me.lbl_ubicacion.Name = "lbl_ubicacion"
        Me.lbl_ubicacion.Size = New System.Drawing.Size(82, 23)
        Me.lbl_ubicacion.TabIndex = 14
        Me.lbl_ubicacion.Text = "Ubicacion"
        '
        'dt_fecha
        '
        Me.dt_fecha.Location = New System.Drawing.Point(145, 209)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(289, 30)
        Me.dt_fecha.TabIndex = 16
        '
        'pic_imagen
        '
        Me.pic_imagen.Location = New System.Drawing.Point(482, 61)
        Me.pic_imagen.Name = "pic_imagen"
        Me.pic_imagen.Size = New System.Drawing.Size(296, 250)
        Me.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_imagen.TabIndex = 17
        Me.pic_imagen.TabStop = False
        '
        'bttn_limpiar
        '
        Me.bttn_limpiar.Location = New System.Drawing.Point(31, 351)
        Me.bttn_limpiar.Name = "bttn_limpiar"
        Me.bttn_limpiar.Size = New System.Drawing.Size(120, 40)
        Me.bttn_limpiar.TabIndex = 18
        Me.bttn_limpiar.Text = "Limpiar"
        Me.bttn_limpiar.UseVisualStyleBackColor = True
        '
        'bttn_buscar
        '
        Me.bttn_buscar.Location = New System.Drawing.Point(157, 351)
        Me.bttn_buscar.Name = "bttn_buscar"
        Me.bttn_buscar.Size = New System.Drawing.Size(120, 40)
        Me.bttn_buscar.TabIndex = 19
        Me.bttn_buscar.Text = "Buscar"
        Me.bttn_buscar.UseVisualStyleBackColor = True
        '
        'bttn_agregar
        '
        Me.bttn_agregar.Location = New System.Drawing.Point(283, 351)
        Me.bttn_agregar.Name = "bttn_agregar"
        Me.bttn_agregar.Size = New System.Drawing.Size(120, 40)
        Me.bttn_agregar.TabIndex = 20
        Me.bttn_agregar.Text = "Agregar"
        Me.bttn_agregar.UseVisualStyleBackColor = True
        '
        'bttn_modificar
        '
        Me.bttn_modificar.Location = New System.Drawing.Point(409, 351)
        Me.bttn_modificar.Name = "bttn_modificar"
        Me.bttn_modificar.Size = New System.Drawing.Size(120, 40)
        Me.bttn_modificar.TabIndex = 21
        Me.bttn_modificar.Text = "Modificar"
        Me.bttn_modificar.UseVisualStyleBackColor = True
        '
        'bttn_eliminar
        '
        Me.bttn_eliminar.Location = New System.Drawing.Point(535, 351)
        Me.bttn_eliminar.Name = "bttn_eliminar"
        Me.bttn_eliminar.Size = New System.Drawing.Size(120, 40)
        Me.bttn_eliminar.TabIndex = 22
        Me.bttn_eliminar.Text = "Eliminar"
        Me.bttn_eliminar.UseVisualStyleBackColor = True
        '
        'bttn_salir
        '
        Me.bttn_salir.Location = New System.Drawing.Point(658, 351)
        Me.bttn_salir.Name = "bttn_salir"
        Me.bttn_salir.Size = New System.Drawing.Size(120, 40)
        Me.bttn_salir.TabIndex = 23
        Me.bttn_salir.Text = "Salir"
        Me.bttn_salir.UseVisualStyleBackColor = True
        '
        'bttn_imagen
        '
        Me.bttn_imagen.Location = New System.Drawing.Point(572, 15)
        Me.bttn_imagen.Name = "bttn_imagen"
        Me.bttn_imagen.Size = New System.Drawing.Size(120, 40)
        Me.bttn_imagen.TabIndex = 24
        Me.bttn_imagen.Text = "Imagen"
        Me.bttn_imagen.UseVisualStyleBackColor = True
        '
        'Visualizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 403)
        Me.Controls.Add(Me.bttn_imagen)
        Me.Controls.Add(Me.bttn_salir)
        Me.Controls.Add(Me.bttn_eliminar)
        Me.Controls.Add(Me.bttn_modificar)
        Me.Controls.Add(Me.bttn_agregar)
        Me.Controls.Add(Me.bttn_buscar)
        Me.Controls.Add(Me.bttn_limpiar)
        Me.Controls.Add(Me.pic_imagen)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.txt_ubicacion)
        Me.Controls.Add(Me.lbl_ubicacion)
        Me.Controls.Add(Me.txt_dimesiones)
        Me.Controls.Add(Me.lbl_dimensiones)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.txt_estilo)
        Me.Controls.Add(Me.lbl_estilo)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.txt_autor)
        Me.Controls.Add(Me.lbl_autor)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Visualizer"
        Me.Text = "Mueso del Arte"
        CType(Me.pic_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_autor As TextBox
    Friend WithEvents lbl_autor As Label
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents txt_estilo As TextBox
    Friend WithEvents lbl_estilo As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents txt_dimesiones As TextBox
    Friend WithEvents lbl_dimensiones As Label
    Friend WithEvents txt_ubicacion As TextBox
    Friend WithEvents lbl_ubicacion As Label
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents pic_imagen As PictureBox
    Friend WithEvents bttn_limpiar As Button
    Friend WithEvents bttn_buscar As Button
    Friend WithEvents bttn_agregar As Button
    Friend WithEvents bttn_modificar As Button
    Friend WithEvents bttn_eliminar As Button
    Friend WithEvents bttn_salir As Button
    Friend WithEvents bttn_imagen As Button
End Class
