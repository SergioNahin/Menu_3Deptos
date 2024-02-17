<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menutercero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menutercero))
        Me.internewton = New System.Windows.Forms.Button()
        Me.Rectangulo = New System.Windows.Forms.Button()
        Me.Simpson = New System.Windows.Forms.Button()
        Me.Trapecio = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.gauss = New System.Windows.Forms.Button()
        Me.Rungekutta = New System.Windows.Forms.Button()
        Me.eulerme = New System.Windows.Forms.Button()
        Me.eulerb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'internewton
        '
        Me.internewton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.internewton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.internewton.Image = Global.Menu_3Deptos.My.Resources.Resources.alien1_96106
        Me.internewton.Location = New System.Drawing.Point(37, 39)
        Me.internewton.Name = "internewton"
        Me.internewton.Size = New System.Drawing.Size(173, 81)
        Me.internewton.TabIndex = 0
        Me.internewton.Text = "Interpolacion Newton"
        Me.internewton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.internewton.UseVisualStyleBackColor = True
        '
        'Rectangulo
        '
        Me.Rectangulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rectangulo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rectangulo.Image = Global.Menu_3Deptos.My.Resources.Resources.spacerover1_96094
        Me.Rectangulo.Location = New System.Drawing.Point(577, 39)
        Me.Rectangulo.Name = "Rectangulo"
        Me.Rectangulo.Size = New System.Drawing.Size(155, 81)
        Me.Rectangulo.TabIndex = 1
        Me.Rectangulo.Text = "Rectangulo"
        Me.Rectangulo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Rectangulo.UseVisualStyleBackColor = True
        '
        'Simpson
        '
        Me.Simpson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Simpson.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpson.Image = Global.Menu_3Deptos.My.Resources.Resources.flag_96085
        Me.Simpson.Location = New System.Drawing.Point(572, 183)
        Me.Simpson.Name = "Simpson"
        Me.Simpson.Size = New System.Drawing.Size(155, 81)
        Me.Simpson.TabIndex = 2
        Me.Simpson.Text = "Simpson"
        Me.Simpson.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Simpson.UseVisualStyleBackColor = True
        '
        'Trapecio
        '
        Me.Trapecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Trapecio.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trapecio.Image = Global.Menu_3Deptos.My.Resources.Resources.lasergun_96100
        Me.Trapecio.Location = New System.Drawing.Point(37, 183)
        Me.Trapecio.Name = "Trapecio"
        Me.Trapecio.Size = New System.Drawing.Size(173, 81)
        Me.Trapecio.TabIndex = 3
        Me.Trapecio.Text = "Trapecio"
        Me.Trapecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Trapecio.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.BackColor = System.Drawing.SystemColors.Control
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Image = Global.Menu_3Deptos.My.Resources.Resources.atras
        Me.Volver.Location = New System.Drawing.Point(590, 359)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(137, 50)
        Me.Volver.TabIndex = 11
        Me.Volver.Text = "Regresar"
        Me.Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Volver.UseVisualStyleBackColor = False
        '
        'gauss
        '
        Me.gauss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gauss.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gauss.Image = Global.Menu_3Deptos.My.Resources.Resources.brainslug_96083
        Me.gauss.Location = New System.Drawing.Point(305, 183)
        Me.gauss.Name = "gauss"
        Me.gauss.Size = New System.Drawing.Size(173, 81)
        Me.gauss.TabIndex = 12
        Me.gauss.Text = "Cuadratica Gauss"
        Me.gauss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.gauss.UseVisualStyleBackColor = True
        '
        'Rungekutta
        '
        Me.Rungekutta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rungekutta.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rungekutta.Image = Global.Menu_3Deptos.My.Resources.Resources.spaceshuttlelaunch_96152
        Me.Rungekutta.Location = New System.Drawing.Point(305, 328)
        Me.Rungekutta.Name = "Rungekutta"
        Me.Rungekutta.Size = New System.Drawing.Size(173, 81)
        Me.Rungekutta.TabIndex = 13
        Me.Rungekutta.Text = "Rungekutta"
        Me.Rungekutta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Rungekutta.UseVisualStyleBackColor = True
        '
        'eulerme
        '
        Me.eulerme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eulerme.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eulerme.Image = Global.Menu_3Deptos.My.Resources.Resources.atronaut_96141
        Me.eulerme.Location = New System.Drawing.Point(305, 39)
        Me.eulerme.Name = "eulerme"
        Me.eulerme.Size = New System.Drawing.Size(173, 81)
        Me.eulerme.TabIndex = 14
        Me.eulerme.Text = "Método Euler Mejorado"
        Me.eulerme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.eulerme.UseVisualStyleBackColor = True
        '
        'eulerb
        '
        Me.eulerb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eulerb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eulerb.Image = Global.Menu_3Deptos.My.Resources.Resources.internationalspacestation_96150
        Me.eulerb.Location = New System.Drawing.Point(37, 328)
        Me.eulerb.Name = "eulerb"
        Me.eulerb.Size = New System.Drawing.Size(173, 81)
        Me.eulerb.TabIndex = 15
        Me.eulerb.Text = "Método Euler"
        Me.eulerb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.eulerb.UseVisualStyleBackColor = True
        '
        'menutercero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._18
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(739, 457)
        Me.Controls.Add(Me.eulerb)
        Me.Controls.Add(Me.eulerme)
        Me.Controls.Add(Me.Rungekutta)
        Me.Controls.Add(Me.gauss)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.Trapecio)
        Me.Controls.Add(Me.Simpson)
        Me.Controls.Add(Me.Rectangulo)
        Me.Controls.Add(Me.internewton)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menutercero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Tercer Departamental"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents internewton As Button
    Friend WithEvents Rectangulo As Button
    Friend WithEvents Simpson As Button
    Friend WithEvents Trapecio As Button
    Friend WithEvents Volver As Button
    Friend WithEvents gauss As Button
    Friend WithEvents Rungekutta As Button
    Friend WithEvents eulerme As Button
    Friend WithEvents eulerb As Button
End Class
