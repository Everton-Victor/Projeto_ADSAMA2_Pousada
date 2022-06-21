<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_funcionarios
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
        Dim CheckoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_funcionarios))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_cadastro = New System.Windows.Forms.TabPage()
        Me.cmb_status_conta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.cmb_tipo_conta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.tab_lista = New System.Windows.Forms.TabPage()
        Me.dgv_fun = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tab_cadastro.SuspendLayout()
        Me.tab_lista.SuspendLayout()
        CType(Me.dgv_fun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckoutToolStripMenuItem
        '
        CheckoutToolStripMenuItem.Image = CType(resources.GetObject("CheckoutToolStripMenuItem.Image"), System.Drawing.Image)
        CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        CheckoutToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        CheckoutToolStripMenuItem.Text = "Reserva"
        AddHandler CheckoutToolStripMenuItem.Click, AddressOf Me.CheckoutToolStripMenuItem_Click_1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_cadastro)
        Me.TabControl1.Controls.Add(Me.tab_lista)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(29, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(932, 464)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 3
        '
        'tab_cadastro
        '
        Me.tab_cadastro.Controls.Add(Me.cmb_status_conta)
        Me.tab_cadastro.Controls.Add(Me.Label7)
        Me.tab_cadastro.Controls.Add(Me.cmb_cargo)
        Me.tab_cadastro.Controls.Add(Me.Label2)
        Me.tab_cadastro.Controls.Add(Me.txt_nome)
        Me.tab_cadastro.Controls.Add(Me.btn_entrar)
        Me.tab_cadastro.Controls.Add(Me.cmb_tipo_conta)
        Me.tab_cadastro.Controls.Add(Me.Label6)
        Me.tab_cadastro.Controls.Add(Me.Label5)
        Me.tab_cadastro.Controls.Add(Me.Label4)
        Me.tab_cadastro.Controls.Add(Me.txt_email)
        Me.tab_cadastro.Controls.Add(Me.Label3)
        Me.tab_cadastro.Controls.Add(Me.txt_confirmar_senha)
        Me.tab_cadastro.Controls.Add(Me.Label1)
        Me.tab_cadastro.Controls.Add(Me.txt_senha)
        Me.tab_cadastro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_cadastro.Location = New System.Drawing.Point(4, 34)
        Me.tab_cadastro.Name = "tab_cadastro"
        Me.tab_cadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_cadastro.Size = New System.Drawing.Size(924, 426)
        Me.tab_cadastro.TabIndex = 0
        Me.tab_cadastro.Text = "Cadastro"
        Me.tab_cadastro.UseVisualStyleBackColor = True
        '
        'cmb_status_conta
        '
        Me.cmb_status_conta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status_conta.FormattingEnabled = True
        Me.cmb_status_conta.Location = New System.Drawing.Point(697, 64)
        Me.cmb_status_conta.Name = "cmb_status_conta"
        Me.cmb_status_conta.Size = New System.Drawing.Size(193, 36)
        Me.cmb_status_conta.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(687, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 36)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Status da Conta:"
        '
        'cmb_cargo
        '
        Me.cmb_cargo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(697, 233)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(193, 36)
        Me.cmb_cargo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 36)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nome:"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.txt_nome.Location = New System.Drawing.Point(172, 114)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(428, 36)
        Me.txt_nome.TabIndex = 1
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_entrar.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Location = New System.Drawing.Point(721, 315)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(169, 59)
        Me.btn_entrar.TabIndex = 7
        Me.btn_entrar.Text = "Confirmar"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'cmb_tipo_conta
        '
        Me.cmb_tipo_conta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_conta.FormattingEnabled = True
        Me.cmb_tipo_conta.Location = New System.Drawing.Point(697, 152)
        Me.cmb_tipo_conta.Name = "cmb_tipo_conta"
        Me.cmb_tipo_conta.Size = New System.Drawing.Size(193, 36)
        Me.cmb_tipo_conta.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(691, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 36)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tipo de Conta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(691, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 36)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Cargo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 36)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "E-mail:"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.txt_email.Location = New System.Drawing.Point(172, 50)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(428, 36)
        Me.txt_email.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 72)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Confirmar  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Senha:"
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(172, 248)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(428, 36)
        Me.txt_confirmar_senha.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 36)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Senha:"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.txt_senha.Location = New System.Drawing.Point(172, 179)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(428, 36)
        Me.txt_senha.TabIndex = 2
        '
        'tab_lista
        '
        Me.tab_lista.Controls.Add(Me.dgv_fun)
        Me.tab_lista.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.tab_lista.Location = New System.Drawing.Point(4, 34)
        Me.tab_lista.Name = "tab_lista"
        Me.tab_lista.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_lista.Size = New System.Drawing.Size(924, 426)
        Me.tab_lista.TabIndex = 1
        Me.tab_lista.Text = "Lista"
        Me.tab_lista.UseVisualStyleBackColor = True
        '
        'dgv_fun
        '
        Me.dgv_fun.AllowUserToAddRows = False
        Me.dgv_fun.AllowUserToDeleteRows = False
        Me.dgv_fun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_fun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_fun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fun.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column4, Me.Column5})
        Me.dgv_fun.GridColor = System.Drawing.Color.White
        Me.dgv_fun.Location = New System.Drawing.Point(5, 4)
        Me.dgv_fun.Name = "dgv_fun"
        Me.dgv_fun.ReadOnly = True
        Me.dgv_fun.RowHeadersWidth = 62
        Me.dgv_fun.Size = New System.Drawing.Size(973, 422)
        Me.dgv_fun.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "E-mail"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 72
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 68
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cargo"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 67
        '
        'Column7
        '
        Me.Column7.HeaderText = "Conta"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 67
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 70
        '
        'Column9
        '
        Me.Column9.HeaderText = "Data/Hora Criação"
        Me.Column9.MinimumWidth = 8
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 133
        '
        'Column10
        '
        Me.Column10.HeaderText = "Data/Hora Alteração"
        Me.Column10.MinimumWidth = 8
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 144
        '
        'Column4
        '
        Me.Column4.HeaderText = "Editar"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 51
        '
        'Column5
        '
        Me.Column5.HeaderText = "Excluir"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 56
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(998, 42)
        Me.ToolStrip1.TabIndex = 78
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservaToolStripMenuItem, Me.PacoteDeServiçosToolStripMenuItem, Me.QuartosToolStripMenuItem, Me.EncerrarSessToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(48, 39)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ReservaToolStripMenuItem
        '
        Me.ReservaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {CheckoutToolStripMenuItem, Me.CheckinToolStripMenuItem, Me.CheckoutToolStripMenuItem1})
        Me.ReservaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservaToolStripMenuItem.Image = CType(resources.GetObject("ReservaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ReservaToolStripMenuItem.Text = "Cliente"
        '
        'CheckinToolStripMenuItem
        '
        Me.CheckinToolStripMenuItem.Image = CType(resources.GetObject("CheckinToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckinToolStripMenuItem.Name = "CheckinToolStripMenuItem"
        Me.CheckinToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.CheckinToolStripMenuItem.Text = "Check-in"
        '
        'CheckoutToolStripMenuItem1
        '
        Me.CheckoutToolStripMenuItem1.Image = CType(resources.GetObject("CheckoutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CheckoutToolStripMenuItem1.Name = "CheckoutToolStripMenuItem1"
        Me.CheckoutToolStripMenuItem1.Size = New System.Drawing.Size(145, 26)
        Me.CheckoutToolStripMenuItem1.Text = "Checkout"
        '
        'PacoteDeServiçosToolStripMenuItem
        '
        Me.PacoteDeServiçosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacoteDeServiçosToolStripMenuItem.Image = CType(resources.GetObject("PacoteDeServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PacoteDeServiçosToolStripMenuItem.Name = "PacoteDeServiçosToolStripMenuItem"
        Me.PacoteDeServiçosToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.PacoteDeServiçosToolStripMenuItem.Text = "Pacote de serviços"
        '
        'QuartosToolStripMenuItem
        '
        Me.QuartosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuartosToolStripMenuItem.Image = CType(resources.GetObject("QuartosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuartosToolStripMenuItem.Name = "QuartosToolStripMenuItem"
        Me.QuartosToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.QuartosToolStripMenuItem.Text = "Quartos"
        '
        'EncerrarSessToolStripMenuItem
        '
        Me.EncerrarSessToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EncerrarSessToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSessToolStripMenuItem.Name = "EncerrarSessToolStripMenuItem"
        Me.EncerrarSessToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.EncerrarSessToolStripMenuItem.Text = "Encerrar sessão"
        '
        'frm_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 585)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FUNCIONÁRIOS - FSHM"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_cadastro.ResumeLayout(False)
        Me.tab_cadastro.PerformLayout()
        Me.tab_lista.ResumeLayout(False)
        CType(Me.dgv_fun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_cadastro As TabPage
    Friend WithEvents cmb_status_conta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents cmb_tipo_conta As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents tab_lista As TabPage
    Friend WithEvents dgv_fun As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PacoteDeServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessToolStripMenuItem As ToolStripMenuItem
End Class
