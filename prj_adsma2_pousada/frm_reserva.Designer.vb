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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cpf_cli = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_cli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_celular_cli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_quartos = New System.Windows.Forms.ComboBox()
        Me.cmb_pac_serv = New System.Windows.Forms.ComboBox()
        Me.dtp_data_entrada = New System.Windows.Forms.DateTimePicker()
        Me.cmb_forma = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_preco_pac_serv = New System.Windows.Forms.TextBox()
        Me.txt_preco_quarto = New System.Windows.Forms.TextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.dtp_data_saida = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmb_parcela = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_total_pagar = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.num_reserva = New System.Windows.Forms.TextBox()
        Me.dtp_hora_saida = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hora_entrada = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.cmb_cpf_acomp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome_acomp_pesq = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_acomp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cpf_acomp = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(32, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "CPF:"
        '
        'txt_cpf_cli
        '
        Me.txt_cpf_cli.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_cpf_cli.Location = New System.Drawing.Point(34, 47)
        Me.txt_cpf_cli.Name = "txt_cpf_cli"
        Me.txt_cpf_cli.Size = New System.Drawing.Size(282, 28)
        Me.txt_cpf_cli.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nome_cli)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_celular_cli)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_cpf_cli)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(355, 220)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nome:"
        '
        'txt_nome_cli
        '
        Me.txt_nome_cli.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_nome_cli.Location = New System.Drawing.Point(34, 104)
        Me.txt_nome_cli.Name = "txt_nome_cli"
        Me.txt_nome_cli.Size = New System.Drawing.Size(285, 28)
        Me.txt_nome_cli.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(32, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Celular:"
        '
        'txt_celular_cli
        '
        Me.txt_celular_cli.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_celular_cli.Location = New System.Drawing.Point(36, 168)
        Me.txt_celular_cli.Name = "txt_celular_cli"
        Me.txt_celular_cli.Size = New System.Drawing.Size(282, 28)
        Me.txt_celular_cli.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(350, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 23)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Pacote de Serviço:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label12.Location = New System.Drawing.Point(43, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 23)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Data de saída:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(22, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Data de entrada:"
        '
        'cmb_quartos
        '
        Me.cmb_quartos.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_quartos.FormattingEnabled = True
        Me.cmb_quartos.Location = New System.Drawing.Point(138, 81)
        Me.cmb_quartos.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_quartos.Name = "cmb_quartos"
        Me.cmb_quartos.Size = New System.Drawing.Size(183, 28)
        Me.cmb_quartos.TabIndex = 34
        '
        'cmb_pac_serv
        '
        Me.cmb_pac_serv.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_pac_serv.FormattingEnabled = True
        Me.cmb_pac_serv.Location = New System.Drawing.Point(521, 32)
        Me.cmb_pac_serv.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_pac_serv.Name = "cmb_pac_serv"
        Me.cmb_pac_serv.Size = New System.Drawing.Size(223, 28)
        Me.cmb_pac_serv.TabIndex = 35
        '
        'dtp_data_entrada
        '
        Me.dtp_data_entrada.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.dtp_data_entrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data_entrada.Location = New System.Drawing.Point(178, 183)
        Me.dtp_data_entrada.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_data_entrada.Name = "dtp_data_entrada"
        Me.dtp_data_entrada.Size = New System.Drawing.Size(143, 28)
        Me.dtp_data_entrada.TabIndex = 36
        '
        'cmb_forma
        '
        Me.cmb_forma.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_forma.FormattingEnabled = True
        Me.cmb_forma.Location = New System.Drawing.Point(96, 77)
        Me.cmb_forma.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_forma.Name = "cmb_forma"
        Me.cmb_forma.Size = New System.Drawing.Size(137, 28)
        Me.cmb_forma.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(58, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 23)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Quarto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(20, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 23)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Forma:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label13.Location = New System.Drawing.Point(115, 218)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 23)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Hora:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label14.Location = New System.Drawing.Point(115, 282)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 23)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Hora:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label15.Location = New System.Drawing.Point(68, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 23)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Preço:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label16.Location = New System.Drawing.Point(447, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 23)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Preço :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_preco_pac_serv
        '
        Me.txt_preco_pac_serv.Enabled = False
        Me.txt_preco_pac_serv.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_preco_pac_serv.Location = New System.Drawing.Point(521, 69)
        Me.txt_preco_pac_serv.Name = "txt_preco_pac_serv"
        Me.txt_preco_pac_serv.Size = New System.Drawing.Size(223, 28)
        Me.txt_preco_pac_serv.TabIndex = 44
        '
        'txt_preco_quarto
        '
        Me.txt_preco_quarto.Enabled = False
        Me.txt_preco_quarto.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_preco_quarto.Location = New System.Drawing.Point(138, 121)
        Me.txt_preco_quarto.Name = "txt_preco_quarto"
        Me.txt_preco_quarto.Size = New System.Drawing.Size(183, 28)
        Me.txt_preco_quarto.TabIndex = 45
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(583, 266)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(143, 59)
        Me.btn_cadastrar.TabIndex = 48
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'dtp_data_saida
        '
        Me.dtp_data_saida.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.dtp_data_saida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data_saida.Location = New System.Drawing.Point(178, 247)
        Me.dtp_data_saida.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_data_saida.Name = "dtp_data_saida"
        Me.dtp_data_saida.Size = New System.Drawing.Size(143, 28)
        Me.dtp_data_saida.TabIndex = 49
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.num_reserva)
        Me.GroupBox4.Controls.Add(Me.txt_preco_pac_serv)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.cmb_pac_serv)
        Me.GroupBox4.Controls.Add(Me.btn_cadastrar)
        Me.GroupBox4.Controls.Add(Me.dtp_hora_saida)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.dtp_hora_entrada)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.dtp_data_saida)
        Me.GroupBox4.Controls.Add(Me.txt_preco_quarto)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.dtp_data_entrada)
        Me.GroupBox4.Controls.Add(Me.cmb_quartos)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(771, 349)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados de Reserva"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmb_parcela)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txt_total_pagar)
        Me.GroupBox5.Controls.Add(Me.cmb_forma)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(354, 121)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(399, 120)
        Me.GroupBox5.TabIndex = 61
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pagamento"
        '
        'cmb_parcela
        '
        Me.cmb_parcela.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_parcela.FormattingEnabled = True
        Me.cmb_parcela.Location = New System.Drawing.Point(322, 77)
        Me.cmb_parcela.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_parcela.Name = "cmb_parcela"
        Me.cmb_parcela.Size = New System.Drawing.Size(68, 28)
        Me.cmb_parcela.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label17.Location = New System.Drawing.Point(239, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 23)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Parcela:"
        '
        'txt_total_pagar
        '
        Me.txt_total_pagar.Enabled = False
        Me.txt_total_pagar.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_total_pagar.Location = New System.Drawing.Point(84, 34)
        Me.txt_total_pagar.Name = "txt_total_pagar"
        Me.txt_total_pagar.Size = New System.Drawing.Size(149, 28)
        Me.txt_total_pagar.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label20.Location = New System.Drawing.Point(20, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 23)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label19.Location = New System.Drawing.Point(22, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 23)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Nª Reserva:"
        '
        'num_reserva
        '
        Me.num_reserva.Enabled = False
        Me.num_reserva.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.num_reserva.Location = New System.Drawing.Point(138, 42)
        Me.num_reserva.Name = "num_reserva"
        Me.num_reserva.Size = New System.Drawing.Size(183, 28)
        Me.num_reserva.TabIndex = 60
        '
        'dtp_hora_saida
        '
        Me.dtp_hora_saida.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.dtp_hora_saida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_hora_saida.Location = New System.Drawing.Point(178, 279)
        Me.dtp_hora_saida.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_hora_saida.Name = "dtp_hora_saida"
        Me.dtp_hora_saida.Size = New System.Drawing.Size(143, 28)
        Me.dtp_hora_saida.TabIndex = 53
        '
        'dtp_hora_entrada
        '
        Me.dtp_hora_entrada.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.dtp_hora_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_hora_entrada.Location = New System.Drawing.Point(178, 215)
        Me.dtp_hora_entrada.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_hora_entrada.Name = "dtp_hora_entrada"
        Me.dtp_hora_entrada.Size = New System.Drawing.Size(143, 28)
        Me.dtp_hora_entrada.TabIndex = 52
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(814, 42)
        Me.ToolStrip1.TabIndex = 77
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
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(222, 42)
        Me.ReservaToolStripMenuItem.Text = "Cliente"
        '
        'CheckinToolStripMenuItem
        '
        Me.CheckinToolStripMenuItem.Name = "CheckinToolStripMenuItem"
        Me.CheckinToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.CheckinToolStripMenuItem.Text = "Check-in"
        '
        'CheckoutToolStripMenuItem1
        '
        Me.CheckoutToolStripMenuItem1.Name = "CheckoutToolStripMenuItem1"
        Me.CheckoutToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.CheckoutToolStripMenuItem1.Text = "Check-out"
        '
        'PacoteDeServiçosToolStripMenuItem
        '
        Me.PacoteDeServiçosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacoteDeServiçosToolStripMenuItem.Image = CType(resources.GetObject("PacoteDeServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PacoteDeServiçosToolStripMenuItem.Name = "PacoteDeServiçosToolStripMenuItem"
        Me.PacoteDeServiçosToolStripMenuItem.Size = New System.Drawing.Size(222, 42)
        Me.PacoteDeServiçosToolStripMenuItem.Text = "Pacote de serviços"
        '
        'QuartosToolStripMenuItem
        '
        Me.QuartosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuartosToolStripMenuItem.Image = CType(resources.GetObject("QuartosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuartosToolStripMenuItem.Name = "QuartosToolStripMenuItem"
        Me.QuartosToolStripMenuItem.Size = New System.Drawing.Size(222, 42)
        Me.QuartosToolStripMenuItem.Text = "Quartos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FuncionáriosToolStripMenuItem.Image = CType(resources.GetObject("FuncionáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(222, 42)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'EncerrarSessToolStripMenuItem
        '
        Me.EncerrarSessToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EncerrarSessToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSessToolStripMenuItem.Name = "EncerrarSessToolStripMenuItem"
        Me.EncerrarSessToolStripMenuItem.Size = New System.Drawing.Size(222, 42)
        Me.EncerrarSessToolStripMenuItem.Text = "Encerrar sessão"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btn_ok)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_nome_acomp)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_cpf_acomp)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(384, 47)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(412, 220)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acompanhante"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_remove)
        Me.GroupBox3.Controls.Add(Me.cmb_cpf_acomp)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_nome_acomp_pesq)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 108)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(344, 88)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'btn_remove
        '
        Me.btn_remove.AutoSize = True
        Me.btn_remove.Image = CType(resources.GetObject("btn_remove.Image"), System.Drawing.Image)
        Me.btn_remove.Location = New System.Drawing.Point(301, 50)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(30, 31)
        Me.btn_remove.TabIndex = 28
        Me.btn_remove.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Nome:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(5, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 23)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "CPF:"
        '
        'txt_nome_acomp_pesq
        '
        Me.txt_nome_acomp_pesq.Enabled = False
        Me.txt_nome_acomp_pesq.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_nome_acomp_pesq.Location = New System.Drawing.Point(87, 51)
        Me.txt_nome_acomp_pesq.Name = "txt_nome_acomp_pesq"
        Me.txt_nome_acomp_pesq.Size = New System.Drawing.Size(209, 28)
        Me.txt_nome_acomp_pesq.TabIndex = 30
        '
        'btn_ok
        '
        Me.btn_ok.AutoSize = True
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.Location = New System.Drawing.Point(313, 58)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(30, 30)
        Me.btn_ok.TabIndex = 26
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Nome:"
        '
        'txt_nome_acomp
        '
        Me.txt_nome_acomp.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_nome_acomp.Location = New System.Drawing.Point(101, 59)
        Me.txt_nome_acomp.Name = "txt_nome_acomp"
        Me.txt_nome_acomp.Size = New System.Drawing.Size(209, 28)
        Me.txt_nome_acomp.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(19, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "CPF:"
        '
        'txt_cpf_acomp
        '
        Me.txt_cpf_acomp.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_cpf_acomp.Location = New System.Drawing.Point(101, 21)
        Me.txt_cpf_acomp.Name = "txt_cpf_acomp"
        Me.txt_cpf_acomp.Size = New System.Drawing.Size(209, 28)
        Me.txt_cpf_acomp.TabIndex = 20
        '
        'frm_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 624)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reversa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cpf_cli As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_cli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_celular_cli As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_quartos As ComboBox
    Friend WithEvents cmb_pac_serv As ComboBox
    Friend WithEvents dtp_data_entrada As DateTimePicker
    Friend WithEvents cmb_forma As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_preco_pac_serv As TextBox
    Friend WithEvents txt_preco_quarto As TextBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents dtp_data_saida As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtp_hora_entrada As DateTimePicker
    Friend WithEvents dtp_hora_saida As DateTimePicker
    Friend WithEvents txt_total_pagar As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PacoteDeServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmb_parcela As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents num_reserva As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_remove As Button
    Friend WithEvents cmb_cpf_acomp As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome_acomp_pesq As TextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome_acomp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cpf_acomp As TextBox
    Friend WithEvents GroupBox5 As GroupBox
End Class
