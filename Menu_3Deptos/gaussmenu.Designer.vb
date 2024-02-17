<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gaussmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gaussmenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.a11 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.a21 = New System.Windows.Forms.TextBox()
        Me.a31 = New System.Windows.Forms.TextBox()
        Me.a12 = New System.Windows.Forms.TextBox()
        Me.a22 = New System.Windows.Forms.TextBox()
        Me.a32 = New System.Windows.Forms.TextBox()
        Me.a13 = New System.Windows.Forms.TextBox()
        Me.a23 = New System.Windows.Forms.TextBox()
        Me.a33 = New System.Windows.Forms.TextBox()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Coeficientes = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xi = New System.Windows.Forms.TextBox()
        Me.yi = New System.Windows.Forms.TextBox()
        Me.zi = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Volver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metodo de Gauss-Seindel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dame cifras significativas"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(152, 73)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 20)
        Me.tc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "x+"
        '
        'a11
        '
        Me.a11.Location = New System.Drawing.Point(23, 133)
        Me.a11.Name = "a11"
        Me.a11.Size = New System.Drawing.Size(100, 20)
        Me.a11.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "x+"
        '
        'a21
        '
        Me.a21.Location = New System.Drawing.Point(23, 184)
        Me.a21.Name = "a21"
        Me.a21.Size = New System.Drawing.Size(100, 20)
        Me.a21.TabIndex = 6
        '
        'a31
        '
        Me.a31.Location = New System.Drawing.Point(23, 230)
        Me.a31.Name = "a31"
        Me.a31.Size = New System.Drawing.Size(100, 20)
        Me.a31.TabIndex = 7
        '
        'a12
        '
        Me.a12.Location = New System.Drawing.Point(202, 133)
        Me.a12.Name = "a12"
        Me.a12.Size = New System.Drawing.Size(100, 20)
        Me.a12.TabIndex = 8
        '
        'a22
        '
        Me.a22.Location = New System.Drawing.Point(202, 180)
        Me.a22.Name = "a22"
        Me.a22.Size = New System.Drawing.Size(100, 20)
        Me.a22.TabIndex = 9
        '
        'a32
        '
        Me.a32.Location = New System.Drawing.Point(202, 230)
        Me.a32.Name = "a32"
        Me.a32.Size = New System.Drawing.Size(100, 20)
        Me.a32.TabIndex = 10
        '
        'a13
        '
        Me.a13.Location = New System.Drawing.Point(378, 133)
        Me.a13.Name = "a13"
        Me.a13.Size = New System.Drawing.Size(100, 20)
        Me.a13.TabIndex = 11
        '
        'a23
        '
        Me.a23.Location = New System.Drawing.Point(378, 180)
        Me.a23.Name = "a23"
        Me.a23.Size = New System.Drawing.Size(100, 20)
        Me.a23.TabIndex = 12
        '
        'a33
        '
        Me.a33.Location = New System.Drawing.Point(378, 230)
        Me.a33.Name = "a33"
        Me.a33.Size = New System.Drawing.Size(100, 20)
        Me.a33.TabIndex = 13
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(590, 133)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(100, 20)
        Me.b1.TabIndex = 14
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(590, 184)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(100, 20)
        Me.b2.TabIndex = 15
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(590, 230)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(100, 20)
        Me.b3.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "x+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "y+"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "y+"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "y+"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(520, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "z+"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(514, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "z+"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(520, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "z+"
        '
        'Coeficientes
        '
        Me.Coeficientes.Location = New System.Drawing.Point(59, 276)
        Me.Coeficientes.Name = "Coeficientes"
        Me.Coeficientes.Size = New System.Drawing.Size(75, 23)
        Me.Coeficientes.TabIndex = 24
        Me.Coeficientes.Text = "&Coeficientes"
        Me.Coeficientes.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(170, 276)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 25
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(284, 286)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 26
        Me.Limpiar.Text = "&Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(393, 286)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 27
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Salida.Location = New System.Drawing.Point(23, 331)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(749, 150)
        Me.Salida.TabIndex = 28
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(778, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "x="
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(778, 382)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Y="
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(778, 415)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "z="
        '
        'xi
        '
        Me.xi.Location = New System.Drawing.Point(840, 338)
        Me.xi.Name = "xi"
        Me.xi.Size = New System.Drawing.Size(100, 20)
        Me.xi.TabIndex = 32
        '
        'yi
        '
        Me.yi.Location = New System.Drawing.Point(840, 379)
        Me.yi.Name = "yi"
        Me.yi.Size = New System.Drawing.Size(100, 20)
        Me.yi.TabIndex = 33
        '
        'zi
        '
        Me.zi.Location = New System.Drawing.Point(840, 415)
        Me.zi.Name = "zi"
        Me.zi.Size = New System.Drawing.Size(100, 20)
        Me.zi.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(538, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Formula recursiva"
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(840, 62)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(110, 53)
        Me.Volver.TabIndex = 38
        Me.Volver.Text = "Regresar"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Menu_3Deptos.My.Resources.Resources.gaussseidelform1
        Me.PictureBox1.Location = New System.Drawing.Point(438, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 103)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'gaussmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1078, 528)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.zi)
        Me.Controls.Add(Me.yi)
        Me.Controls.Add(Me.xi)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Coeficientes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.a33)
        Me.Controls.Add(Me.a23)
        Me.Controls.Add(Me.a13)
        Me.Controls.Add(Me.a32)
        Me.Controls.Add(Me.a22)
        Me.Controls.Add(Me.a12)
        Me.Controls.Add(Me.a31)
        Me.Controls.Add(Me.a21)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.a11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gaussmenu"
        Me.Text = "Form1"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents a11 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents a21 As TextBox
    Friend WithEvents a31 As TextBox
    Friend WithEvents a12 As TextBox
    Friend WithEvents a22 As TextBox
    Friend WithEvents a32 As TextBox
    Friend WithEvents a13 As TextBox
    Friend WithEvents a23 As TextBox
    Friend WithEvents a33 As TextBox
    Friend WithEvents b1 As TextBox
    Friend WithEvents b2 As TextBox
    Friend WithEvents b3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Coeficientes As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents xi As TextBox
    Friend WithEvents yi As TextBox
    Friend WithEvents zi As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Volver As Button
End Class
