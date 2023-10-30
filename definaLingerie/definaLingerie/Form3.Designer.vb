<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_deslogar = New System.Windows.Forms.Button()
        Me.btn_relatorios = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_deslogar
        '
        Me.btn_deslogar.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_deslogar.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deslogar.ForeColor = System.Drawing.Color.Ivory
        Me.btn_deslogar.Location = New System.Drawing.Point(691, 346)
        Me.btn_deslogar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(209, 84)
        Me.btn_deslogar.TabIndex = 9
        Me.btn_deslogar.Text = "Deslogar"
        Me.btn_deslogar.UseVisualStyleBackColor = False
        '
        'btn_relatorios
        '
        Me.btn_relatorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_relatorios.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorios.ForeColor = System.Drawing.Color.Ivory
        Me.btn_relatorios.Location = New System.Drawing.Point(391, 346)
        Me.btn_relatorios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_relatorios.Name = "btn_relatorios"
        Me.btn_relatorios.Size = New System.Drawing.Size(209, 84)
        Me.btn_relatorios.TabIndex = 8
        Me.btn_relatorios.Text = "Relatórios"
        Me.btn_relatorios.UseVisualStyleBackColor = False
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_clientes.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.Color.Ivory
        Me.btn_clientes.Location = New System.Drawing.Point(102, 346)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(194, 84)
        Me.btn_clientes.TabIndex = 7
        Me.btn_clientes.Text = "Administrar Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(354, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 65)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Área do Funcionário"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 570)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.btn_relatorios)
        Me.Controls.Add(Me.btn_clientes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_deslogar As Button
    Friend WithEvents btn_relatorios As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents Label1 As Label
End Class
