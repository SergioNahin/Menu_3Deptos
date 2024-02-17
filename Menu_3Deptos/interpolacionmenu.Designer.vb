<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class interpolacionmenu
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(interpolacionmenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tn = New System.Windows.Forms.TextBox()
        Me.tvx = New System.Windows.Forms.TextBox()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tv = New System.Windows.Forms.TextBox()
        Me.Parejas = New System.Windows.Forms.Button()
        Me.Primer = New System.Windows.Forms.Button()
        Me.Segundo = New System.Windows.Forms.Button()
        Me.Graficar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tib = New System.Windows.Forms.TextBox()
        Me.Volver = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dame cifras significativas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dame el numero de parejas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dame el numero interpolar"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(230, 74)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 20)
        Me.tc.TabIndex = 3
        '
        'tn
        '
        Me.tn.Location = New System.Drawing.Point(230, 108)
        Me.tn.Name = "tn"
        Me.tn.Size = New System.Drawing.Size(100, 20)
        Me.tn.TabIndex = 4
        '
        'tvx
        '
        Me.tvx.Location = New System.Drawing.Point(230, 143)
        Me.tvx.Name = "tvx"
        Me.tvx.Size = New System.Drawing.Size(100, 20)
        Me.tvx.TabIndex = 5
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(48, 194)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(346, 150)
        Me.Salida.TabIndex = 6
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Solucion"
        '
        'tv
        '
        Me.tv.Location = New System.Drawing.Point(230, 412)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(100, 20)
        Me.tv.TabIndex = 8
        '
        'Parejas
        '
        Me.Parejas.Location = New System.Drawing.Point(434, 77)
        Me.Parejas.Name = "Parejas"
        Me.Parejas.Size = New System.Drawing.Size(113, 23)
        Me.Parejas.TabIndex = 9
        Me.Parejas.Text = "&Introducir parejas"
        Me.Parejas.UseVisualStyleBackColor = True
        '
        'Primer
        '
        Me.Primer.Location = New System.Drawing.Point(457, 111)
        Me.Primer.Name = "Primer"
        Me.Primer.Size = New System.Drawing.Size(75, 23)
        Me.Primer.TabIndex = 10
        Me.Primer.Text = "&Primer grado"
        Me.Primer.UseVisualStyleBackColor = True
        '
        'Segundo
        '
        Me.Segundo.Location = New System.Drawing.Point(442, 145)
        Me.Segundo.Name = "Segundo"
        Me.Segundo.Size = New System.Drawing.Size(90, 23)
        Me.Segundo.TabIndex = 11
        Me.Segundo.Text = "&Segundo grado"
        Me.Segundo.UseVisualStyleBackColor = True
        '
        'Graficar
        '
        Me.Graficar.Location = New System.Drawing.Point(457, 183)
        Me.Graficar.Name = "Graficar"
        Me.Graficar.Size = New System.Drawing.Size(75, 23)
        Me.Graficar.TabIndex = 12
        Me.Graficar.Text = "&Graficar"
        Me.Graficar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(457, 223)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 13
        Me.Limpiar.Text = "&Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(457, 263)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 14
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Graf
        '
        ChartArea1.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Graf.Legends.Add(Legend1)
        Me.Graf.Location = New System.Drawing.Point(578, 74)
        Me.Graf.Name = "Graf"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Graf.Series.Add(Series1)
        Me.Graf.Series.Add(Series2)
        Me.Graf.Size = New System.Drawing.Size(300, 300)
        Me.Graf.TabIndex = 15
        Me.Graf.Text = "Chart1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Ib"
        '
        'tib
        '
        Me.tib.Location = New System.Drawing.Point(106, 367)
        Me.tib.Name = "tib"
        Me.tib.Size = New System.Drawing.Size(100, 20)
        Me.tib.TabIndex = 17
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(788, 395)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(110, 53)
        Me.Volver.TabIndex = 39
        Me.Volver.Text = "Regresar"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'interpolacionmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_3Deptos.My.Resources.Resources._6
        Me.ClientSize = New System.Drawing.Size(910, 450)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.tib)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Graficar)
        Me.Controls.Add(Me.Segundo)
        Me.Controls.Add(Me.Primer)
        Me.Controls.Add(Me.Parejas)
        Me.Controls.Add(Me.tv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.tvx)
        Me.Controls.Add(Me.tn)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "interpolacionmenu"
        Me.Text = "Interpolacion"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents tn As TextBox
    Friend WithEvents tvx As TextBox
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents tv As TextBox
    Friend WithEvents Parejas As Button
    Friend WithEvents Primer As Button
    Friend WithEvents Segundo As Button
    Friend WithEvents Graficar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents tib As TextBox
    Friend WithEvents Volver As Button
End Class
