﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eulermej
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eulermej))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tvy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.th = New System.Windows.Forms.TextBox()
        Me.txf = New System.Windows.Forms.TextBox()
        Me.ty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lf = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.tx = New System.Windows.Forms.TextBox()
        Me.Volver = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(589, 221)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Valor  y"
        '
        'tvy
        '
        Me.tvy.Location = New System.Drawing.Point(640, 220)
        Me.tvy.Margin = New System.Windows.Forms.Padding(2)
        Me.tvy.Name = "tvy"
        Me.tvy.Size = New System.Drawing.Size(140, 20)
        Me.tvy.TabIndex = 144
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(330, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Dame cifras"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(412, 27)
        Me.tc.Margin = New System.Windows.Forms.Padding(2)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(140, 20)
        Me.tc.TabIndex = 142
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(117, 153)
        Me.tf.Margin = New System.Windows.Forms.Padding(2)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(192, 20)
        Me.tf.TabIndex = 141
        '
        'th
        '
        Me.th.Location = New System.Drawing.Point(104, 124)
        Me.th.Margin = New System.Windows.Forms.Padding(2)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(140, 20)
        Me.th.TabIndex = 140
        '
        'txf
        '
        Me.txf.Location = New System.Drawing.Point(104, 91)
        Me.txf.Margin = New System.Windows.Forms.Padding(2)
        Me.txf.Name = "txf"
        Me.txf.Size = New System.Drawing.Size(140, 20)
        Me.txf.TabIndex = 139
        '
        'ty
        '
        Me.ty.Location = New System.Drawing.Point(104, 59)
        Me.ty.Margin = New System.Windows.Forms.Padding(2)
        Me.ty.Name = "ty"
        Me.ty.Size = New System.Drawing.Size(140, 20)
        Me.ty.TabIndex = 138
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Dame función"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Dame h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Dame xf"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Dame y0"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lf.Location = New System.Drawing.Point(22, 30)
        Me.lf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(57, 15)
        Me.lf.TabIndex = 133
        Me.lf.Text = "Dame x0"
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1})
        Me.Salida.Location = New System.Drawing.Point(49, 202)
        Me.Salida.Margin = New System.Windows.Forms.Padding(2)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(502, 267)
        Me.Salida.TabIndex = 132
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "indice"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "xi"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "yi"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(601, 66)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(78, 22)
        Me.Limpiar.TabIndex = 131
        Me.Limpiar.Text = "&Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(601, 111)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(78, 22)
        Me.Salir.TabIndex = 130
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(601, 22)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(78, 22)
        Me.Calcular.TabIndex = 129
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'tx
        '
        Me.tx.Location = New System.Drawing.Point(104, 27)
        Me.tx.Margin = New System.Windows.Forms.Padding(2)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(140, 20)
        Me.tx.TabIndex = 128
        '
        'Volver
        '
        Me.Volver.BackColor = System.Drawing.SystemColors.Control
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Image = Global.Menu_3Deptos.My.Resources.Resources.atras
        Me.Volver.Location = New System.Drawing.Point(628, 478)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(137, 50)
        Me.Volver.TabIndex = 146
        Me.Volver.Text = "Regresar"
        Me.Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Volver.UseVisualStyleBackColor = False
        '
        'Eulermej
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._19
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1069, 573)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tvy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.txf)
        Me.Controls.Add(Me.ty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lf)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tx)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Eulermej"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Euler Mejorado"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents tvy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents th As TextBox
    Friend WithEvents txf As TextBox
    Friend WithEvents ty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lf As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents tx As TextBox
    Friend WithEvents Volver As Button
End Class