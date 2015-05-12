<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCrearCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbApellido = New System.Windows.Forms.TextBox()
        Me.TbDni = New System.Windows.Forms.TextBox()
        Me.btnCrearCliente = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DNI"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(130, 35)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(157, 20)
        Me.TbNombre.TabIndex = 3
        '
        'TbApellido
        '
        Me.TbApellido.Location = New System.Drawing.Point(130, 74)
        Me.TbApellido.Name = "TbApellido"
        Me.TbApellido.Size = New System.Drawing.Size(157, 20)
        Me.TbApellido.TabIndex = 4
        '
        'TbDni
        '
        Me.TbDni.Location = New System.Drawing.Point(130, 108)
        Me.TbDni.Name = "TbDni"
        Me.TbDni.Size = New System.Drawing.Size(157, 20)
        Me.TbDni.TabIndex = 5
        '
        'btnCrearCliente
        '
        Me.btnCrearCliente.Location = New System.Drawing.Point(47, 178)
        Me.btnCrearCliente.Name = "btnCrearCliente"
        Me.btnCrearCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearCliente.TabIndex = 6
        Me.btnCrearCliente.Text = "Crear"
        Me.btnCrearCliente.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(191, 178)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FormCrearCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 315)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.btnCrearCliente)
        Me.Controls.Add(Me.TbDni)
        Me.Controls.Add(Me.TbApellido)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCrearCliente"
        Me.Text = "FormCrearCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbNombre As System.Windows.Forms.TextBox
    Friend WithEvents TbApellido As System.Windows.Forms.TextBox
    Friend WithEvents TbDni As System.Windows.Forms.TextBox
    Friend WithEvents btnCrearCliente As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
