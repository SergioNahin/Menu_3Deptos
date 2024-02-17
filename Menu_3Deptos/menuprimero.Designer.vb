<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuprimero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuprimero))
        Me.impare = New System.Windows.Forms.Button()
        Me.raiz = New System.Windows.Forms.Button()
        Me.bisecci = New System.Windows.Forms.Button()
        Me.reglaf = New System.Windows.Forms.Button()
        Me.newton = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'impare
        '
        Me.impare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.impare.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.impare.Image = Global.Menu_3Deptos.My.Resources.Resources._32officeicons_22_89702
        Me.impare.Location = New System.Drawing.Point(90, 67)
        Me.impare.Name = "impare"
        Me.impare.Size = New System.Drawing.Size(141, 89)
        Me.impare.TabIndex = 0
        Me.impare.Text = "Números Impares"
        Me.impare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.impare.UseVisualStyleBackColor = True
        '
        'raiz
        '
        Me.raiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.raiz.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raiz.Image = Global.Menu_3Deptos.My.Resources.Resources._32officeicons_20_89419
        Me.raiz.Location = New System.Drawing.Point(340, 181)
        Me.raiz.Name = "raiz"
        Me.raiz.Size = New System.Drawing.Size(141, 89)
        Me.raiz.TabIndex = 1
        Me.raiz.Text = "Raiz de dos"
        Me.raiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.raiz.UseVisualStyleBackColor = True
        '
        'bisecci
        '
        Me.bisecci.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bisecci.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bisecci.Image = Global.Menu_3Deptos.My.Resources.Resources._32officeicons_25_89711
        Me.bisecci.Location = New System.Drawing.Point(549, 279)
        Me.bisecci.Name = "bisecci"
        Me.bisecci.Size = New System.Drawing.Size(141, 89)
        Me.bisecci.TabIndex = 2
        Me.bisecci.Text = "Biseccion"
        Me.bisecci.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bisecci.UseVisualStyleBackColor = True
        '
        'reglaf
        '
        Me.reglaf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reglaf.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reglaf.Image = Global.Menu_3Deptos.My.Resources.Resources._32officeicons_15_89722
        Me.reglaf.Location = New System.Drawing.Point(549, 67)
        Me.reglaf.Name = "reglaf"
        Me.reglaf.Size = New System.Drawing.Size(141, 89)
        Me.reglaf.TabIndex = 3
        Me.reglaf.Text = "Regla Falsa"
        Me.reglaf.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.reglaf.UseVisualStyleBackColor = True
        '
        'newton
        '
        Me.newton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newton.Image = Global.Menu_3Deptos.My.Resources.Resources._32officeicons_21_89726
        Me.newton.Location = New System.Drawing.Point(90, 279)
        Me.newton.Name = "newton"
        Me.newton.Size = New System.Drawing.Size(141, 89)
        Me.newton.TabIndex = 4
        Me.newton.Text = "Newton Raphson"
        Me.newton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.newton.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Image = Global.Menu_3Deptos.My.Resources.Resources.atras
        Me.Volver.Location = New System.Drawing.Point(651, 388)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(137, 50)
        Me.Volver.TabIndex = 10
        Me.Volver.Text = "Regresar"
        Me.Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Volver.UseVisualStyleBackColor = True
        '
        'menuprimero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._9
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.newton)
        Me.Controls.Add(Me.reglaf)
        Me.Controls.Add(Me.bisecci)
        Me.Controls.Add(Me.raiz)
        Me.Controls.Add(Me.impare)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menuprimero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Primer Departamental"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents impare As Button
    Friend WithEvents raiz As Button
    Friend WithEvents bisecci As Button
    Friend WithEvents reglaf As Button
    Friend WithEvents newton As Button
    Friend WithEvents Volver As Button
End Class
