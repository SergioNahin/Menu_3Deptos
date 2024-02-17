<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jacobimenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jacobimenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Coeficientes = New System.Windows.Forms.Button()
        Me.a11 = New System.Windows.Forms.TextBox()
        Me.a21 = New System.Windows.Forms.TextBox()
        Me.a31 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.a12 = New System.Windows.Forms.TextBox()
        Me.a22 = New System.Windows.Forms.TextBox()
        Me.a32 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.a13 = New System.Windows.Forms.TextBox()
        Me.a23 = New System.Windows.Forms.TextBox()
        Me.a33 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xi = New System.Windows.Forms.TextBox()
        Me.yi = New System.Windows.Forms.TextBox()
        Me.zi = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Volver = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metodo Jacobi"
        '
        'Coeficientes
        '
        Me.Coeficientes.Location = New System.Drawing.Point(55, 247)
        Me.Coeficientes.Name = "Coeficientes"
        Me.Coeficientes.Size = New System.Drawing.Size(75, 23)
        Me.Coeficientes.TabIndex = 1
        Me.Coeficientes.Text = "&Coeficientes"
        Me.Coeficientes.UseVisualStyleBackColor = True
        '
        'a11
        '
        Me.a11.Location = New System.Drawing.Point(44, 115)
        Me.a11.Name = "a11"
        Me.a11.Size = New System.Drawing.Size(100, 20)
        Me.a11.TabIndex = 2
        '
        'a21
        '
        Me.a21.Location = New System.Drawing.Point(44, 154)
        Me.a21.Name = "a21"
        Me.a21.Size = New System.Drawing.Size(100, 20)
        Me.a21.TabIndex = 3
        '
        'a31
        '
        Me.a31.Location = New System.Drawing.Point(44, 195)
        Me.a31.Name = "a31"
        Me.a31.Size = New System.Drawing.Size(100, 20)
        Me.a31.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "x +"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "x +"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "x + "
        '
        'a12
        '
        Me.a12.Location = New System.Drawing.Point(195, 115)
        Me.a12.Name = "a12"
        Me.a12.Size = New System.Drawing.Size(100, 20)
        Me.a12.TabIndex = 8
        '
        'a22
        '
        Me.a22.Location = New System.Drawing.Point(195, 152)
        Me.a22.Name = "a22"
        Me.a22.Size = New System.Drawing.Size(100, 20)
        Me.a22.TabIndex = 9
        '
        'a32
        '
        Me.a32.Location = New System.Drawing.Point(195, 191)
        Me.a32.Name = "a32"
        Me.a32.Size = New System.Drawing.Size(100, 20)
        Me.a32.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "y + "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(311, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "y +  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(311, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "y + "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Dame cifras significativas"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(195, 64)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 20)
        Me.tc.TabIndex = 15
        '
        'a13
        '
        Me.a13.Location = New System.Drawing.Point(361, 116)
        Me.a13.Name = "a13"
        Me.a13.Size = New System.Drawing.Size(100, 20)
        Me.a13.TabIndex = 16
        '
        'a23
        '
        Me.a23.Location = New System.Drawing.Point(361, 154)
        Me.a23.Name = "a23"
        Me.a23.Size = New System.Drawing.Size(100, 20)
        Me.a23.TabIndex = 17
        '
        'a33
        '
        Me.a33.Location = New System.Drawing.Point(361, 189)
        Me.a33.Name = "a33"
        Me.a33.Size = New System.Drawing.Size(100, 20)
        Me.a33.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(477, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "z  = "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(477, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "z  = "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(477, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "z  = "
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(520, 115)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(100, 20)
        Me.b1.TabIndex = 22
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(520, 152)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(100, 20)
        Me.b2.TabIndex = 23
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(520, 188)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(100, 20)
        Me.b3.TabIndex = 24
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Salida.Location = New System.Drawing.Point(12, 288)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(744, 150)
        Me.Salida.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "Indice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "x(i)"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "y(i)"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "z(i)"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "ex"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ey"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "ez"
        Me.Column7.Name = "Column7"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(166, 247)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 26
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(274, 247)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 27
        Me.Limpiar.Text = "&Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(386, 247)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 28
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(775, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 24)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "x  ="
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(775, 372)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 24)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "y  ="
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(775, 416)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 24)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "z  ="
        '
        'xi
        '
        Me.xi.Location = New System.Drawing.Point(824, 328)
        Me.xi.Name = "xi"
        Me.xi.Size = New System.Drawing.Size(100, 20)
        Me.xi.TabIndex = 32
        '
        'yi
        '
        Me.yi.Location = New System.Drawing.Point(824, 376)
        Me.yi.Name = "yi"
        Me.yi.Size = New System.Drawing.Size(100, 20)
        Me.yi.TabIndex = 33
        '
        'zi
        '
        Me.zi.Location = New System.Drawing.Point(824, 422)
        Me.zi.Name = "zi"
        Me.zi.Size = New System.Drawing.Size(100, 20)
        Me.zi.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(594, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Formula recursiva"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Menu_3Deptos.My.Resources.Resources.jacobiform
        Me.PictureBox1.Location = New System.Drawing.Point(507, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 66)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(814, 208)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(110, 53)
        Me.Volver.TabIndex = 39
        Me.Volver.Text = "Regresar"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'jacobimenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._3
        Me.ClientSize = New System.Drawing.Size(931, 450)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.zi)
        Me.Controls.Add(Me.yi)
        Me.Controls.Add(Me.xi)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.a33)
        Me.Controls.Add(Me.a23)
        Me.Controls.Add(Me.a13)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.a32)
        Me.Controls.Add(Me.a22)
        Me.Controls.Add(Me.a12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.a31)
        Me.Controls.Add(Me.a21)
        Me.Controls.Add(Me.a11)
        Me.Controls.Add(Me.Coeficientes)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jacobimenu"
        Me.Text = "Método Jacobi"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Coeficientes As Button
    Friend WithEvents a11 As TextBox
    Friend WithEvents a21 As TextBox
    Friend WithEvents a31 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents a12 As TextBox
    Friend WithEvents a22 As TextBox
    Friend WithEvents a32 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents a13 As TextBox
    Friend WithEvents a23 As TextBox
    Friend WithEvents a33 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents b1 As TextBox
    Friend WithEvents b2 As TextBox
    Friend WithEvents b3 As TextBox
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents xi As TextBox
    Friend WithEvents yi As TextBox
    Friend WithEvents zi As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Volver As Button
End Class
