<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_checkout
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
        Dim CheckoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_checkout))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_num_reserva = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.cmb_num_reserva = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_pac_serv = New System.Windows.Forms.TextBox()
        Me.txt_num_quarto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmb_cpf_acomp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome_acomp = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckoutToolStripMenuItem
        '
        CheckoutToolStripMenuItem.Image = CType(resources.GetObject("CheckoutToolStripMenuItem.Image"), System.Drawing.Image)
        CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        CheckoutToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        CheckoutToolStripMenuItem.Text = "Reserva"
        AddHandler CheckoutToolStripMenuItem.Click, AddressOf Me.CheckoutToolStripMenuItem_Click_2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 42)
        Me.ToolStrip1.TabIndex = 102
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
        Me.ReservaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {CheckoutToolStripMenuItem, Me.CheckoutToolStripMenuItem1, Me.RegistroToolStripMenuItem})
        Me.ReservaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservaToolStripMenuItem.Image = CType(resources.GetObject("ReservaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ReservaToolStripMenuItem.Text = "Cliente"
        '
        'CheckoutToolStripMenuItem1
        '
        Me.CheckoutToolStripMenuItem1.Image = CType(resources.GetObject("CheckoutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CheckoutToolStripMenuItem1.Name = "CheckoutToolStripMenuItem1"
        Me.CheckoutToolStripMenuItem1.Size = New System.Drawing.Size(141, 26)
        Me.CheckoutToolStripMenuItem1.Text = "Check-in"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Image = CType(resources.GetObject("RegistroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.RegistroToolStripMenuItem.Text = "Registro"
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
        'txt_num_reserva
        '
        Me.txt_num_reserva.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_num_reserva.Location = New System.Drawing.Point(536, 62)
        Me.txt_num_reserva.Name = "txt_num_reserva"
        Me.txt_num_reserva.Size = New System.Drawing.Size(208, 28)
        Me.txt_num_reserva.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(412, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Nª Rerserva:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_hora)
        Me.GroupBox2.Controls.Add(Me.txt_data)
        Me.GroupBox2.Controls.Add(Me.cmb_num_reserva)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_pac_serv)
        Me.GroupBox2.Controls.Add(Me.txt_num_quarto)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 227)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados da Reserva"
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_hora.Location = New System.Drawing.Point(259, 182)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(89, 28)
        Me.txt_hora.TabIndex = 98
        '
        'txt_data
        '
        Me.txt_data.Enabled = False
        Me.txt_data.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_data.Location = New System.Drawing.Point(77, 182)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(114, 28)
        Me.txt_data.TabIndex = 97
        '
        'cmb_num_reserva
        '
        Me.cmb_num_reserva.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_num_reserva.FormattingEnabled = True
        Me.cmb_num_reserva.Location = New System.Drawing.Point(139, 36)
        Me.cmb_num_reserva.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_num_reserva.Name = "cmb_num_reserva"
        Me.cmb_num_reserva.Size = New System.Drawing.Size(209, 28)
        Me.cmb_num_reserva.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(16, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 23)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Nª Rerserva:"
        '
        'txt_pac_serv
        '
        Me.txt_pac_serv.Enabled = False
        Me.txt_pac_serv.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_pac_serv.Location = New System.Drawing.Point(139, 134)
        Me.txt_pac_serv.Name = "txt_pac_serv"
        Me.txt_pac_serv.Size = New System.Drawing.Size(209, 28)
        Me.txt_pac_serv.TabIndex = 70
        '
        'txt_num_quarto
        '
        Me.txt_num_quarto.Enabled = False
        Me.txt_num_quarto.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_num_quarto.Location = New System.Drawing.Point(139, 79)
        Me.txt_num_quarto.Name = "txt_num_quarto"
        Me.txt_num_quarto.Size = New System.Drawing.Size(209, 28)
        Me.txt_num_quarto.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(16, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 46)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Pacote " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Serviço:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label13.Location = New System.Drawing.Point(197, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 23)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Hora:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(16, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 23)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Data:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(16, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 23)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Quarto:"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(601, 348)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(174, 59)
        Me.btn_cadastrar.TabIndex = 98
        Me.btn_cadastrar.Text = "CHECKOUT"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 23)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "CPF:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 305)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmb_cpf_acomp)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txt_nome_acomp)
        Me.GroupBox4.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(367, 133)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acompanhante"
        '
        'cmb_cpf_acomp
        '
        Me.cmb_cpf_acomp.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.cmb_cpf_acomp.FormattingEnabled = True
        Me.cmb_cpf_acomp.Location = New System.Drawing.Point(98, 44)
        Me.cmb_cpf_acomp.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_cpf_acomp.Name = "cmb_cpf_acomp"
        Me.cmb_cpf_acomp.Size = New System.Drawing.Size(218, 28)
        Me.cmb_cpf_acomp.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(25, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Nome:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(25, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 23)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "CPF:"
        '
        'txt_nome_acomp
        '
        Me.txt_nome_acomp.Enabled = False
        Me.txt_nome_acomp.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_nome_acomp.Location = New System.Drawing.Point(98, 82)
        Me.txt_nome_acomp.Name = "txt_nome_acomp"
        Me.txt_nome_acomp.Size = New System.Drawing.Size(218, 28)
        Me.txt_nome_acomp.TabIndex = 34
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txt_celular)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_nome)
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 127)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nome:"
        '
        'txt_celular
        '
        Me.txt_celular.Enabled = False
        Me.txt_celular.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_celular.Location = New System.Drawing.Point(98, 76)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(218, 28)
        Me.txt_celular.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(17, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Celular:"
        '
        'txt_nome
        '
        Me.txt_nome.Enabled = False
        Me.txt_nome.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_nome.Location = New System.Drawing.Point(98, 31)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(218, 28)
        Me.txt_nome.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(697, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(65, 62)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(146, 28)
        Me.txt_cpf.TabIndex = 105
        '
        'frm_checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 417)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_num_reserva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHECKOUT - FSHM"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PacoteDeServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_num_reserva As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmb_num_reserva As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_pac_serv As TextBox
    Friend WithEvents txt_num_quarto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmb_cpf_acomp As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome_acomp As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_data As TextBox
    Friend WithEvents txt_hora As TextBox
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_cpf As MaskedTextBox
End Class
