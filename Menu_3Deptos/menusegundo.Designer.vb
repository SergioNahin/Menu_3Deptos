<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menusegundo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menusegundo))
        Me.Jacobit = New System.Windows.Forms.Button()
        Me.interpo = New System.Windows.Forms.Button()
        Me.Gausse = New System.Windows.Forms.Button()
        Me.cuadrados = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Jacobit
        '
        Me.Jacobit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Jacobit.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jacobit.Image = Global.Menu_3Deptos.My.Resources.Resources._14
        Me.Jacobit.Location = New System.Drawing.Point(67, 68)
        Me.Jacobit.Name = "Jacobit"
        Me.Jacobit.Size = New System.Drawing.Size(181, 84)
        Me.Jacobit.TabIndex = 0
        Me.Jacobit.Text = "Jacobi"
        Me.Jacobit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Jacobit.UseVisualStyleBackColor = True
        '
        'interpo
        '
        Me.interpo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.interpo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interpo.Image = Global.Menu_3Deptos.My.Resources.Resources._41
        Me.interpo.Location = New System.Drawing.Point(67, 224)
        Me.interpo.Name = "interpo"
        Me.interpo.Size = New System.Drawing.Size(181, 84)
        Me.interpo.TabIndex = 1
        Me.interpo.Text = "Interpolación"
        Me.interpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.interpo.UseVisualStyleBackColor = True
        '
        'Gausse
        '
        Me.Gausse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Gausse.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gausse.Image = Global.Menu_3Deptos.My.Resources.Resources._31
        Me.Gausse.Location = New System.Drawing.Point(579, 68)
        Me.Gausse.Name = "Gausse"
        Me.Gausse.Size = New System.Drawing.Size(181, 84)
        Me.Gausse.TabIndex = 2
        Me.Gausse.Text = "Gauss"
        Me.Gausse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Gausse.UseVisualStyleBackColor = True
        '
        'cuadrados
        '
        Me.cuadrados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cuadrados.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuadrados.Image = Global.Menu_3Deptos.My.Resources.Resources._71
        Me.cuadrados.Location = New System.Drawing.Point(579, 224)
        Me.cuadrados.Name = "cuadrados"
        Me.cuadrados.Size = New System.Drawing.Size(181, 84)
        Me.cuadrados.TabIndex = 3
        Me.cuadrados.Text = " Minimos Cuadrados"
        Me.cuadrados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cuadrados.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Image = Global.Menu_3Deptos.My.Resources.Resources.atras
        Me.Volver.Location = New System.Drawing.Point(656, 385)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(132, 53)
        Me.Volver.TabIndex = 40
        Me.Volver.Text = "Regresar"
        Me.Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Volver.UseVisualStyleBackColor = True
        '
        'menusegundo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.cuadrados)
        Me.Controls.Add(Me.Gausse)
        Me.Controls.Add(Me.interpo)
        Me.Controls.Add(Me.Jacobit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menusegundo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Segundo Departamental"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Jacobit As Button
    Friend WithEvents interpo As Button
    Friend WithEvents Gausse As Button
    Friend WithEvents cuadrados As Button
    Friend WithEvents Volver As Button
End Class
