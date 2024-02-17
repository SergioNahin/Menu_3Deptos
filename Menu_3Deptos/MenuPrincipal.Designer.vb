<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menufinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menufinal))
        Me.menu1 = New System.Windows.Forms.Button()
        Me.menu2 = New System.Windows.Forms.Button()
        Me.menu3 = New System.Windows.Forms.Button()
        Me.integrantes = New System.Windows.Forms.Button()
        Me.integrap = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'menu1
        '
        Me.menu1.BackColor = System.Drawing.Color.CadetBlue
        Me.menu1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu1.Image = Global.Menu_3Deptos.My.Resources.Resources.primer_parci
        Me.menu1.Location = New System.Drawing.Point(12, 61)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(358, 66)
        Me.menu1.TabIndex = 0
        Me.menu1.Text = "Primer Parcial"
        Me.menu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.menu1.UseVisualStyleBackColor = False
        '
        'menu2
        '
        Me.menu2.BackColor = System.Drawing.Color.CadetBlue
        Me.menu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu2.Image = Global.Menu_3Deptos.My.Resources.Resources.segund_par
        Me.menu2.Location = New System.Drawing.Point(12, 133)
        Me.menu2.Name = "menu2"
        Me.menu2.Size = New System.Drawing.Size(358, 66)
        Me.menu2.TabIndex = 1
        Me.menu2.Text = "Segundo Parcial"
        Me.menu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.menu2.UseVisualStyleBackColor = False
        '
        'menu3
        '
        Me.menu3.BackColor = System.Drawing.Color.CadetBlue
        Me.menu3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu3.Image = Global.Menu_3Deptos.My.Resources.Resources.book_glasses_icon_icons_com_56355
        Me.menu3.Location = New System.Drawing.Point(12, 205)
        Me.menu3.Name = "menu3"
        Me.menu3.Size = New System.Drawing.Size(358, 66)
        Me.menu3.TabIndex = 2
        Me.menu3.Text = "Tercer Parcial"
        Me.menu3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.menu3.UseVisualStyleBackColor = False
        '
        'integrantes
        '
        Me.integrantes.BackColor = System.Drawing.Color.CadetBlue
        Me.integrantes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.integrantes.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.integrantes.Image = Global.Menu_3Deptos.My.Resources.Resources.integr
        Me.integrantes.Location = New System.Drawing.Point(12, 277)
        Me.integrantes.Name = "integrantes"
        Me.integrantes.Size = New System.Drawing.Size(358, 66)
        Me.integrantes.TabIndex = 3
        Me.integrantes.Text = "Integrantes"
        Me.integrantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.integrantes.UseVisualStyleBackColor = False
        '
        'integrap
        '
        Me.integrap.AutoSize = True
        Me.integrap.BackColor = System.Drawing.Color.Transparent
        Me.integrap.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.integrap.ForeColor = System.Drawing.Color.CadetBlue
        Me.integrap.Location = New System.Drawing.Point(424, 40)
        Me.integrap.Name = "integrap"
        Me.integrap.Size = New System.Drawing.Size(0, 22)
        Me.integrap.TabIndex = 4
        '
        'menufinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.integrap)
        Me.Controls.Add(Me.integrantes)
        Me.Controls.Add(Me.menu3)
        Me.Controls.Add(Me.menu2)
        Me.Controls.Add(Me.menu1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menufinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu1 As Button
    Friend WithEvents menu2 As Button
    Friend WithEvents menu3 As Button
    Friend WithEvents integrantes As Button
    Friend WithEvents integrap As Label
End Class
