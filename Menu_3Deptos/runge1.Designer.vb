<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class runge1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(runge1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tx = New System.Windows.Forms.TextBox()
        Me.ty = New System.Windows.Forms.TextBox()
        Me.txf = New System.Windows.Forms.TextBox()
        Me.th = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tvy = New System.Windows.Forms.TextBox()
        Me.Volver = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "dame x0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "dame y0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "dame xf"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "dame h"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 221)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "dame funcion"
        '
        'tx
        '
        Me.tx.Location = New System.Drawing.Point(102, 53)
        Me.tx.Margin = New System.Windows.Forms.Padding(2)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(76, 20)
        Me.tx.TabIndex = 5
        '
        'ty
        '
        Me.ty.Location = New System.Drawing.Point(102, 89)
        Me.ty.Margin = New System.Windows.Forms.Padding(2)
        Me.ty.Name = "ty"
        Me.ty.Size = New System.Drawing.Size(76, 20)
        Me.ty.TabIndex = 6
        '
        'txf
        '
        Me.txf.Location = New System.Drawing.Point(102, 135)
        Me.txf.Margin = New System.Windows.Forms.Padding(2)
        Me.txf.Name = "txf"
        Me.txf.Size = New System.Drawing.Size(76, 20)
        Me.txf.TabIndex = 7
        '
        'th
        '
        Me.th.Location = New System.Drawing.Point(102, 176)
        Me.th.Margin = New System.Windows.Forms.Padding(2)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(76, 20)
        Me.th.TabIndex = 8
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(102, 221)
        Me.tf.Margin = New System.Windows.Forms.Padding(2)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(76, 20)
        Me.tf.TabIndex = 9
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(68, 257)
        Me.Salida.Margin = New System.Windows.Forms.Padding(2)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 51
        Me.Salida.RowTemplate.Height = 24
        Me.Salida.Size = New System.Drawing.Size(404, 122)
        Me.Salida.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "indice"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "xi"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "yi"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(280, 93)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(56, 19)
        Me.Calcular.TabIndex = 11
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "dame cifras"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(291, 41)
        Me.tc.Margin = New System.Windows.Forms.Padding(2)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(76, 20)
        Me.tc.TabIndex = 13
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(280, 130)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(56, 19)
        Me.Limpiar.TabIndex = 14
        Me.Limpiar.Text = "&Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(280, 173)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(56, 19)
        Me.Salir.TabIndex = 15
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 212)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Valor y"
        '
        'tvy
        '
        Me.tvy.Location = New System.Drawing.Point(469, 210)
        Me.tvy.Margin = New System.Windows.Forms.Padding(2)
        Me.tvy.Name = "tvy"
        Me.tvy.Size = New System.Drawing.Size(76, 20)
        Me.tvy.TabIndex = 17
        '
        'Volver
        '
        Me.Volver.BackColor = System.Drawing.SystemColors.Control
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Image = Global.Menu_3Deptos.My.Resources.Resources.atras
        Me.Volver.Location = New System.Drawing.Point(477, 366)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(137, 50)
        Me.Volver.TabIndex = 147
        Me.Volver.Text = "Regresar"
        Me.Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Volver.UseVisualStyleBackColor = False
        '
        'runge1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._20
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 428)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.tvy)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.txf)
        Me.Controls.Add(Me.ty)
        Me.Controls.Add(Me.tx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "runge1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rungekutta"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tx As TextBox
    Friend WithEvents ty As TextBox
    Friend WithEvents txf As TextBox
    Friend WithEvents th As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Calcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tvy As TextBox
    Friend WithEvents Volver As Button
End Class
