<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_reserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reserva))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btn_remover = New System.Windows.Forms.Button()
        Me.cmb_cpf_acomp = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_cpf_acomp_cadastrado = New System.Windows.Forms.TextBox()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_nome_acomp = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_cpf_acomp = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_nome_cli = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_celular_cli = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_cpf_cli = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_hora_saida = New System.Windows.Forms.DateTimePicker()
        Me.txt_data_saida = New System.Windows.Forms.DateTimePicker()
        Me.txt_hora_entrada = New System.Windows.Forms.DateTimePicker()
        Me.txt_data_entrada = New System.Windows.Forms.DateTimePicker()
        Me.txt_num_reserva = New System.Windows.Forms.TextBox()
        Me.txt_preco_pac_serv = New System.Windows.Forms.TextBox()
        Me.cmb_pacote_serv = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_preco_quarto = New System.Windows.Forms.TextBox()
        Me.cmb_quarto = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_valor_parcela = New System.Windows.Forms.TextBox()
        Me.cmb_parcela = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.cmb_forma_pagamento = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.dgv_reserva = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 42)
        Me.ToolStrip1.TabIndex = 78
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservaToolStripMenuItem, Me.PacoteDeServiçosToolStripMenuItem, Me.QuartosToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.EncerrarSessToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(48, 39)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ReservaToolStripMenuItem
        '
        Me.ReservaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckinToolStripMenuItem, Me.CheckoutToolStripMenuItem1})
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
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FuncionáriosToolStripMenuItem.Image = CType(resources.GetObject("FuncionáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'EncerrarSessToolStripMenuItem
        '
        Me.EncerrarSessToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EncerrarSessToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSessToolStripMenuItem.Name = "EncerrarSessToolStripMenuItem"
        Me.EncerrarSessToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.EncerrarSessToolStripMenuItem.Text = "Encerrar sessão"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(802, 654)
        Me.TabControl1.TabIndex = 79
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(794, 620)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastrar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.btn_inserir)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txt_nome_acomp)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txt_cpf_acomp)
        Me.GroupBox6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(373, 17)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(412, 220)
        Me.GroupBox6.TabIndex = 57
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Acompanhante"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btn_remover)
        Me.GroupBox7.Controls.Add(Me.cmb_cpf_acomp)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.txt_cpf_acomp_cadastrado)
        Me.GroupBox7.Location = New System.Drawing.Point(23, 108)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(344, 88)
        Me.GroupBox7.TabIndex = 27
        Me.GroupBox7.TabStop = False
        '
        'btn_remover
        '
        Me.btn_remover.AutoSize = True
        Me.btn_remover.Image = CType(resources.GetObject("btn_remover.Image"), System.Drawing.Image)
        Me.btn_remover.Location = New System.Drawing.Point(301, 50)
        Me.btn_remover.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_remover.Name = "btn_remover"
        Me.btn_remover.Size = New System.Drawing.Size(30, 31)
        Me.btn_remover.TabIndex = 28
        Me.btn_remover.UseVisualStyleBackColor = True
        '
        'cmb_cpf_acomp
        '
        Me.cmb_cpf_acomp.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_cpf_acomp.FormattingEnabled = True
        Me.cmb_cpf_acomp.Location = New System.Drawing.Point(87, 13)
        Me.cmb_cpf_acomp.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_cpf_acomp.Name = "cmb_cpf_acomp"
        Me.cmb_cpf_acomp.Size = New System.Drawing.Size(209, 28)
        Me.cmb_cpf_acomp.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label18.Location = New System.Drawing.Point(5, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 23)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Nome:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label21.Location = New System.Drawing.Point(5, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 23)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "CPF:"
        '
        'txt_cpf_acomp_cadastrado
        '
        Me.txt_cpf_acomp_cadastrado.Enabled = False
        Me.txt_cpf_acomp_cadastrado.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_cpf_acomp_cadastrado.Location = New System.Drawing.Point(87, 51)
        Me.txt_cpf_acomp_cadastrado.Name = "txt_cpf_acomp_cadastrado"
        Me.txt_cpf_acomp_cadastrado.Size = New System.Drawing.Size(209, 28)
        Me.txt_cpf_acomp_cadastrado.TabIndex = 30
        '
        'btn_inserir
        '
        Me.btn_inserir.AutoSize = True
        Me.btn_inserir.Image = CType(resources.GetObject("btn_inserir.Image"), System.Drawing.Image)
        Me.btn_inserir.Location = New System.Drawing.Point(324, 56)
        Me.btn_inserir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(30, 30)
        Me.btn_inserir.TabIndex = 26
        Me.btn_inserir.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label22.Location = New System.Drawing.Point(19, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 23)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Nome:"
        '
        'txt_nome_acomp
        '
        Me.txt_nome_acomp.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_nome_acomp.Location = New System.Drawing.Point(110, 58)
        Me.txt_nome_acomp.Name = "txt_nome_acomp"
        Me.txt_nome_acomp.Size = New System.Drawing.Size(209, 28)
        Me.txt_nome_acomp.TabIndex = 24
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label23.Location = New System.Drawing.Point(19, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 23)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "CPF:"
        '
        'txt_cpf_acomp
        '
        Me.txt_cpf_acomp.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_cpf_acomp.Location = New System.Drawing.Point(110, 21)
        Me.txt_cpf_acomp.Name = "txt_cpf_acomp"
        Me.txt_cpf_acomp.Size = New System.Drawing.Size(210, 28)
        Me.txt_cpf_acomp.TabIndex = 20
        '
        'GroupBox8
        '
        Me.GroupBox8.AutoSize = True
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.txt_nome_cli)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.txt_celular_cli)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Controls.Add(Me.txt_cpf_cli)
        Me.GroupBox8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(14, 17)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(355, 220)
        Me.GroupBox8.TabIndex = 56
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cliente"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label24.Location = New System.Drawing.Point(30, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 23)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "Nome:"
        '
        'txt_nome_cli
        '
        Me.txt_nome_cli.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_nome_cli.Location = New System.Drawing.Point(34, 104)
        Me.txt_nome_cli.Name = "txt_nome_cli"
        Me.txt_nome_cli.Size = New System.Drawing.Size(285, 28)
        Me.txt_nome_cli.TabIndex = 24
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label25.Location = New System.Drawing.Point(30, 142)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 23)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Celular:"
        '
        'txt_celular_cli
        '
        Me.txt_celular_cli.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_celular_cli.Location = New System.Drawing.Point(34, 168)
        Me.txt_celular_cli.Name = "txt_celular_cli"
        Me.txt_celular_cli.Size = New System.Drawing.Size(285, 28)
        Me.txt_celular_cli.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label26.Location = New System.Drawing.Point(30, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 23)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "CPF:"
        '
        'txt_cpf_cli
        '
        Me.txt_cpf_cli.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_cpf_cli.Location = New System.Drawing.Point(34, 47)
        Me.txt_cpf_cli.Name = "txt_cpf_cli"
        Me.txt_cpf_cli.Size = New System.Drawing.Size(285, 28)
        Me.txt_cpf_cli.TabIndex = 20
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.txt_hora_saida)
        Me.GroupBox9.Controls.Add(Me.txt_data_saida)
        Me.GroupBox9.Controls.Add(Me.txt_hora_entrada)
        Me.GroupBox9.Controls.Add(Me.txt_data_entrada)
        Me.GroupBox9.Controls.Add(Me.txt_num_reserva)
        Me.GroupBox9.Controls.Add(Me.txt_preco_pac_serv)
        Me.GroupBox9.Controls.Add(Me.cmb_pacote_serv)
        Me.GroupBox9.Controls.Add(Me.Label27)
        Me.GroupBox9.Controls.Add(Me.Label28)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.Label31)
        Me.GroupBox9.Controls.Add(Me.txt_preco_quarto)
        Me.GroupBox9.Controls.Add(Me.cmb_quarto)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.btn_cadastrar)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Controls.Add(Me.Label37)
        Me.GroupBox9.Controls.Add(Me.Label38)
        Me.GroupBox9.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox9.Location = New System.Drawing.Point(14, 242)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(771, 372)
        Me.GroupBox9.TabIndex = 58
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Dados de Reserva"
        '
        'txt_hora_saida
        '
        Me.txt_hora_saida.CalendarFont = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora_saida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_hora_saida.Location = New System.Drawing.Point(510, 65)
        Me.txt_hora_saida.Name = "txt_hora_saida"
        Me.txt_hora_saida.Size = New System.Drawing.Size(169, 26)
        Me.txt_hora_saida.TabIndex = 89
        Me.txt_hora_saida.Value = New Date(2022, 6, 19, 19, 38, 0, 0)
        '
        'txt_data_saida
        '
        Me.txt_data_saida.CalendarFont = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_saida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_data_saida.Location = New System.Drawing.Point(510, 34)
        Me.txt_data_saida.Name = "txt_data_saida"
        Me.txt_data_saida.Size = New System.Drawing.Size(169, 26)
        Me.txt_data_saida.TabIndex = 88
        Me.txt_data_saida.Value = New Date(2022, 6, 19, 0, 0, 0, 0)
        '
        'txt_hora_entrada
        '
        Me.txt_hora_entrada.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.txt_hora_entrada.CalendarFont = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_hora_entrada.Location = New System.Drawing.Point(172, 67)
        Me.txt_hora_entrada.Name = "txt_hora_entrada"
        Me.txt_hora_entrada.Size = New System.Drawing.Size(169, 26)
        Me.txt_hora_entrada.TabIndex = 87
        Me.txt_hora_entrada.Value = New Date(2022, 6, 19, 19, 27, 0, 0)
        '
        'txt_data_entrada
        '
        Me.txt_data_entrada.CalendarFont = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_data_entrada.Location = New System.Drawing.Point(172, 34)
        Me.txt_data_entrada.Name = "txt_data_entrada"
        Me.txt_data_entrada.Size = New System.Drawing.Size(169, 26)
        Me.txt_data_entrada.TabIndex = 86
        Me.txt_data_entrada.Value = New Date(2022, 6, 19, 0, 0, 0, 0)
        '
        'txt_num_reserva
        '
        Me.txt_num_reserva.Enabled = False
        Me.txt_num_reserva.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_num_reserva.Location = New System.Drawing.Point(147, 116)
        Me.txt_num_reserva.Name = "txt_num_reserva"
        Me.txt_num_reserva.Size = New System.Drawing.Size(183, 28)
        Me.txt_num_reserva.TabIndex = 77
        '
        'txt_preco_pac_serv
        '
        Me.txt_preco_pac_serv.Enabled = False
        Me.txt_preco_pac_serv.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_preco_pac_serv.Location = New System.Drawing.Point(186, 294)
        Me.txt_preco_pac_serv.Name = "txt_preco_pac_serv"
        Me.txt_preco_pac_serv.Size = New System.Drawing.Size(143, 28)
        Me.txt_preco_pac_serv.TabIndex = 76
        '
        'cmb_pacote_serv
        '
        Me.cmb_pacote_serv.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_pacote_serv.FormattingEnabled = True
        Me.cmb_pacote_serv.Location = New System.Drawing.Point(186, 257)
        Me.cmb_pacote_serv.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_pacote_serv.Name = "cmb_pacote_serv"
        Me.cmb_pacote_serv.Size = New System.Drawing.Size(143, 28)
        Me.cmb_pacote_serv.TabIndex = 74
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label27.Location = New System.Drawing.Point(112, 294)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 23)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Preço :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label28.Location = New System.Drawing.Point(15, 257)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(166, 23)
        Me.Label28.TabIndex = 73
        Me.Label28.Text = "Pacote de Serviço:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label29.Location = New System.Drawing.Point(31, 116)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 23)
        Me.Label29.TabIndex = 67
        Me.Label29.Text = "Nª Reserva:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label30.Location = New System.Drawing.Point(76, 200)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 23)
        Me.Label30.TabIndex = 65
        Me.Label30.Text = "Preço:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label31.Location = New System.Drawing.Point(66, 160)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(75, 23)
        Me.Label31.TabIndex = 63
        Me.Label31.Text = "Quarto:"
        '
        'txt_preco_quarto
        '
        Me.txt_preco_quarto.Enabled = False
        Me.txt_preco_quarto.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_preco_quarto.Location = New System.Drawing.Point(146, 200)
        Me.txt_preco_quarto.Name = "txt_preco_quarto"
        Me.txt_preco_quarto.Size = New System.Drawing.Size(183, 28)
        Me.txt_preco_quarto.TabIndex = 66
        '
        'cmb_quarto
        '
        Me.cmb_quarto.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_quarto.FormattingEnabled = True
        Me.cmb_quarto.Location = New System.Drawing.Point(146, 160)
        Me.cmb_quarto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_quarto.Name = "cmb_quarto"
        Me.cmb_quarto.Size = New System.Drawing.Size(183, 28)
        Me.cmb_quarto.TabIndex = 64
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btn_refresh)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.txt_valor_parcela)
        Me.GroupBox10.Controls.Add(Me.cmb_parcela)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.txt_total)
        Me.GroupBox10.Controls.Add(Me.cmb_forma_pagamento)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Location = New System.Drawing.Point(342, 121)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(423, 159)
        Me.GroupBox10.TabIndex = 61
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Pagamento"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.Location = New System.Drawing.Point(242, 34)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(35, 28)
        Me.btn_refresh.TabIndex = 59
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(238, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Valor:"
        '
        'txt_valor_parcela
        '
        Me.txt_valor_parcela.Enabled = False
        Me.txt_valor_parcela.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_valor_parcela.Location = New System.Drawing.Point(304, 114)
        Me.txt_valor_parcela.Name = "txt_valor_parcela"
        Me.txt_valor_parcela.Size = New System.Drawing.Size(101, 28)
        Me.txt_valor_parcela.TabIndex = 57
        '
        'cmb_parcela
        '
        Me.cmb_parcela.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_parcela.FormattingEnabled = True
        Me.cmb_parcela.Location = New System.Drawing.Point(133, 114)
        Me.cmb_parcela.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_parcela.Name = "cmb_parcela"
        Me.cmb_parcela.Size = New System.Drawing.Size(100, 28)
        Me.cmb_parcela.TabIndex = 56
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label32.Location = New System.Drawing.Point(20, 114)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(108, 23)
        Me.Label32.TabIndex = 55
        Me.Label32.Text = "Parcela (x):"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_total.Location = New System.Drawing.Point(96, 34)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(137, 28)
        Me.txt_total.TabIndex = 54
        '
        'cmb_forma_pagamento
        '
        Me.cmb_forma_pagamento.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_forma_pagamento.FormattingEnabled = True
        Me.cmb_forma_pagamento.Location = New System.Drawing.Point(96, 77)
        Me.cmb_forma_pagamento.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_forma_pagamento.Name = "cmb_forma_pagamento"
        Me.cmb_forma_pagamento.Size = New System.Drawing.Size(137, 28)
        Me.cmb_forma_pagamento.TabIndex = 37
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label33.Location = New System.Drawing.Point(25, 34)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 23)
        Me.Label33.TabIndex = 53
        Me.Label33.Text = "Total:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label34.Location = New System.Drawing.Point(20, 77)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(71, 23)
        Me.Label34.TabIndex = 38
        Me.Label34.Text = "Forma:"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(622, 294)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(143, 59)
        Me.btn_cadastrar.TabIndex = 48
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label35.Location = New System.Drawing.Point(374, 37)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(130, 23)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Data de saída:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.White
        Me.Label36.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label36.Location = New System.Drawing.Point(15, 37)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(151, 23)
        Me.Label36.TabIndex = 29
        Me.Label36.Text = "Data de entrada:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label37.Location = New System.Drawing.Point(446, 67)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(58, 23)
        Me.Label37.TabIndex = 40
        Me.Label37.Text = "Hora:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label38.Location = New System.Drawing.Point(108, 67)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(58, 23)
        Me.Label38.TabIndex = 39
        Me.Label38.Text = "Hora:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmb_categoria)
        Me.TabPage2.Controls.Add(Me.dgv_reserva)
        Me.TabPage2.Controls.Add(Me.txt_pesquisa)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(794, 620)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(255, 6)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(249, 28)
        Me.cmb_categoria.TabIndex = 82
        '
        'dgv_reserva
        '
        Me.dgv_reserva.AllowUserToAddRows = False
        Me.dgv_reserva.AllowUserToDeleteRows = False
        Me.dgv_reserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_reserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_reserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column10, Me.Column8, Me.Column2, Me.Column4, Me.Column7, Me.Column13, Me.Column14})
        Me.dgv_reserva.Location = New System.Drawing.Point(6, 54)
        Me.dgv_reserva.Name = "dgv_reserva"
        Me.dgv_reserva.ReadOnly = True
        Me.dgv_reserva.Size = New System.Drawing.Size(780, 529)
        Me.dgv_reserva.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Núm - Reserva"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 127
        '
        'Column6
        '
        Me.Column6.HeaderText = "Núm - Quarto"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 122
        '
        'Column10
        '
        Me.Column10.HeaderText = "Cód - Pacote Serviço"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 161
        '
        'Column8
        '
        Me.Column8.HeaderText = "CPF - Cliente"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 114
        '
        'Column2
        '
        Me.Column2.HeaderText = "Data - Entrada"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 123
        '
        'Column4
        '
        Me.Column4.HeaderText = "Data - Saída"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 109
        '
        'Column7
        '
        Me.Column7.HeaderText = "E-mail Funcionário"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Column13
        '
        Me.Column13.HeaderText = "Editar"
        Me.Column13.Image = CType(resources.GetObject("Column13.Image"), System.Drawing.Image)
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column13.Width = 56
        '
        'Column14
        '
        Me.Column14.HeaderText = "Remover"
        Me.Column14.Image = CType(resources.GetObject("Column14.Image"), System.Drawing.Image)
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column14.Width = 79
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(47, 6)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(202, 29)
        Me.txt_pesquisa.TabIndex = 81
        '
        'frm_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(825, 753)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESERVA - FSHM"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PacoteDeServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btn_remover As Button
    Friend WithEvents cmb_cpf_acomp As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_cpf_acomp_cadastrado As TextBox
    Friend WithEvents btn_inserir As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_nome_acomp As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_cpf_acomp As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_nome_cli As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_celular_cli As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_cpf_cli As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txt_num_reserva As TextBox
    Friend WithEvents txt_preco_pac_serv As TextBox
    Friend WithEvents cmb_pacote_serv As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_preco_quarto As TextBox
    Friend WithEvents cmb_quarto As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents cmb_parcela As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents cmb_forma_pagamento As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_reserva As DataGridView
    Friend WithEvents txt_pesquisa As TextBox
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_valor_parcela As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewImageColumn
    Friend WithEvents Column14 As DataGridViewImageColumn
    Friend WithEvents txt_hora_saida As DateTimePicker
    Friend WithEvents txt_data_saida As DateTimePicker
    Friend WithEvents txt_hora_entrada As DateTimePicker
    Friend WithEvents txt_data_entrada As DateTimePicker
    Friend WithEvents btn_refresh As Button
End Class
