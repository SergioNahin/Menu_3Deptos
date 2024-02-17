<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.btnbiseccion = New System.Windows.Forms.Button()
        Me.btnregla = New System.Windows.Forms.Button()
        Me.btnraiz = New System.Windows.Forms.Button()
        Me.btnnewton = New System.Windows.Forms.Button()
        Me.btnjacobi = New System.Windows.Forms.Button()
        Me.btngaussen = New System.Windows.Forms.Button()
        Me.btnInterpolacion = New System.Windows.Forms.Button()
        Me.btnImpares = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnbiseccion
        '
        Me.btnbiseccion.BackColor = System.Drawing.Color.BurlyWood
        Me.btnbiseccion.Image = Global.Menu.My.Resources.Resources._5
        Me.btnbiseccion.Location = New System.Drawing.Point(587, 251)
        Me.btnbiseccion.Name = "btnbiseccion"
        Me.btnbiseccion.Size = New System.Drawing.Size(136, 80)
        Me.btnbiseccion.TabIndex = 7
        Me.btnbiseccion.Text = "Bisección"
        Me.btnbiseccion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnbiseccion.UseVisualStyleBackColor = False
        '
        'btnregla
        '
        Me.btnregla.BackColor = System.Drawing.Color.LightGreen
        Me.btnregla.Image = Global.Menu.My.Resources.Resources._7
        Me.btnregla.Location = New System.Drawing.Point(587, 152)
        Me.btnregla.Name = "btnregla"
        Me.btnregla.Size = New System.Drawing.Size(136, 80)
        Me.btnregla.TabIndex = 6
        Me.btnregla.Text = "Regla Falsa"
        Me.btnregla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnregla.UseVisualStyleBackColor = False
        '
        'btnraiz
        '
        Me.btnraiz.BackColor = System.Drawing.Color.LightCyan
        Me.btnraiz.Image = Global.Menu.My.Resources.Resources._6
        Me.btnraiz.Location = New System.Drawing.Point(587, 48)
        Me.btnraiz.Name = "btnraiz"
        Me.btnraiz.Size = New System.Drawing.Size(136, 80)
        Me.btnraiz.TabIndex = 5
        Me.btnraiz.Text = "Raiz"
        Me.btnraiz.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnraiz.UseVisualStyleBackColor = False
        '
        'btnnewton
        '
        Me.btnnewton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnnewton.Image = Global.Menu.My.Resources.Resources._3
        Me.btnnewton.Location = New System.Drawing.Point(322, 152)
        Me.btnnewton.Name = "btnnewton"
        Me.btnnewton.Size = New System.Drawing.Size(136, 80)
        Me.btnnewton.TabIndex = 4
        Me.btnnewton.Text = "Newton Raphson"
        Me.btnnewton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnnewton.UseVisualStyleBackColor = False
        '
        'btnjacobi
        '
        Me.btnjacobi.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnjacobi.Image = Global.Menu.My.Resources.Resources._4
        Me.btnjacobi.Location = New System.Drawing.Point(322, 48)
        Me.btnjacobi.Name = "btnjacobi"
        Me.btnjacobi.Size = New System.Drawing.Size(136, 80)
        Me.btnjacobi.TabIndex = 3
        Me.btnjacobi.Text = "Jacobi"
        Me.btnjacobi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnjacobi.UseVisualStyleBackColor = False
        '
        'btngaussen
        '
        Me.btngaussen.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btngaussen.Image = Global.Menu.My.Resources.Resources._8
        Me.btngaussen.Location = New System.Drawing.Point(26, 251)
        Me.btngaussen.Name = "btngaussen"
        Me.btngaussen.Size = New System.Drawing.Size(136, 80)
        Me.btngaussen.TabIndex = 2
        Me.btngaussen.Text = "Gauss Seindel"
        Me.btngaussen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btngaussen.UseVisualStyleBackColor = False
        '
        'btnInterpolacion
        '
        Me.btnInterpolacion.BackColor = System.Drawing.Color.Plum
        Me.btnInterpolacion.Image = Global.Menu.My.Resources.Resources._2
        Me.btnInterpolacion.Location = New System.Drawing.Point(26, 138)
        Me.btnInterpolacion.Name = "btnInterpolacion"
        Me.btnInterpolacion.Size = New System.Drawing.Size(136, 80)
        Me.btnInterpolacion.TabIndex = 1
        Me.btnInterpolacion.Text = "Interpolación"
        Me.btnInterpolacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInterpolacion.UseVisualStyleBackColor = False
        '
        'btnImpares
        '
        Me.btnImpares.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnImpares.Image = Global.Menu.My.Resources.Resources._11
        Me.btnImpares.Location = New System.Drawing.Point(26, 35)
        Me.btnImpares.Name = "btnImpares"
        Me.btnImpares.Size = New System.Drawing.Size(136, 80)
        Me.btnImpares.TabIndex = 0
        Me.btnImpares.Text = "Impares"
        Me.btnImpares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImpares.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(585, 63)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MÉTODOS NUMÉRICOS"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(786, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnbiseccion)
        Me.Controls.Add(Me.btnregla)
        Me.Controls.Add(Me.btnraiz)
        Me.Controls.Add(Me.btnnewton)
        Me.Controls.Add(Me.btnjacobi)
        Me.Controls.Add(Me.btngaussen)
        Me.Controls.Add(Me.btnInterpolacion)
        Me.Controls.Add(Me.btnImpares)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImpares As Button
    Friend WithEvents btnInterpolacion As Button
    Friend WithEvents btngaussen As Button
    Friend WithEvents btnjacobi As Button
    Friend WithEvents btnnewton As Button
    Friend WithEvents btnraiz As Button
    Friend WithEvents btnregla As Button
    Friend WithEvents btnbiseccion As Button
    Friend WithEvents Label1 As Label
End Class
