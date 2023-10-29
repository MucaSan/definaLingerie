<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cmb_data = New System.Windows.Forms.DateTimePicker()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_valor = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_filtrar = New System.Windows.Forms.ToolStripButton()
        Me.btn_deletar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(29, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 41)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data Nascimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Senha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Usuário"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "E-mail"
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.White
        Me.txt_cpf.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(116, 37)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Multiline = True
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(288, 24)
        Me.txt_cpf.TabIndex = 7
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.White
        Me.txt_nome.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(116, 97)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nome.Multiline = True
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(288, 24)
        Me.txt_nome.TabIndex = 8
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.White
        Me.txt_user.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(118, 157)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_user.Multiline = True
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(288, 24)
        Me.txt_user.TabIndex = 9
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.White
        Me.txt_senha.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(118, 205)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Multiline = True
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(288, 24)
        Me.txt_senha.TabIndex = 10
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(118, 308)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(288, 24)
        Me.txt_email.TabIndex = 11
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.Color.White
        Me.txt_telefone.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(116, 361)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefone.Multiline = True
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(288, 24)
        Me.txt_telefone.TabIndex = 12
        '
        'cmb_data
        '
        Me.cmb_data.Location = New System.Drawing.Point(116, 247)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(282, 22)
        Me.cmb_data.TabIndex = 13
        '
        'btn_criar
        '
        Me.btn_criar.Location = New System.Drawing.Point(497, 349)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(146, 40)
        Me.btn_criar.TabIndex = 14
        Me.btn_criar.Text = "CRIAR"
        Me.btn_criar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(685, 349)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(146, 40)
        Me.btn_editar.TabIndex = 15
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_valor, Me.ToolStripLabel2, Me.cmb_parametro, Me.btn_filtrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1140, 28)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(194, 25)
        Me.ToolStripLabel1.Text = "Insira o valor correspodente"
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(100, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(172, 25)
        Me.ToolStripLabel2.Text = "Selecione um parâmetro"
        '
        'cmb_parametro
        '
        Me.cmb_parametro.Name = "cmb_parametro"
        Me.cmb_parametro.Size = New System.Drawing.Size(121, 28)
        '
        'btn_filtrar
        '
        Me.btn_filtrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_filtrar.Image = CType(resources.GetObject("btn_filtrar.Image"), System.Drawing.Image)
        Me.btn_filtrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(29, 25)
        Me.btn_filtrar.Text = "ToolStripButton1"
        '
        'btn_deletar
        '
        Me.btn_deletar.Location = New System.Drawing.Point(887, 349)
        Me.btn_deletar.Name = "btn_deletar"
        Me.btn_deletar.Size = New System.Drawing.Size(146, 40)
        Me.btn_deletar.TabIndex = 16
        Me.btn_deletar.Text = "DELETAR"
        Me.btn_deletar.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 521)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_deletar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.cmb_data)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmb_data As DateTimePicker
    Friend WithEvents btn_criar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_deletar As Button
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_valor As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_parametro As ToolStripComboBox
    Friend WithEvents btn_filtrar As ToolStripButton
End Class
