<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_checkin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_checkin))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckoutToolStripMenuItem
        '
        CheckoutToolStripMenuItem.Image = CType(resources.GetObject("CheckoutToolStripMenuItem.Image"), System.Drawing.Image)
        CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        CheckoutToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        CheckoutToolStripMenuItem.Text = "Reserva"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(789, 42)
        Me.ToolStrip1.TabIndex = 23
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
        Me.ReservaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {CheckoutToolStripMenuItem, Me.CheckoutToolStripMenuItem1})
        Me.ReservaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservaToolStripMenuItem.Image = CType(resources.GetObject("ReservaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ReservaToolStripMenuItem.Text = "Cliente"
        '
        'CheckoutToolStripMenuItem1
        '
        Me.CheckoutToolStripMenuItem1.Name = "CheckoutToolStripMenuItem1"
        Me.CheckoutToolStripMenuItem1.Size = New System.Drawing.Size(151, 26)
        Me.CheckoutToolStripMenuItem1.Text = "Check-out"
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
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(620, 339)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(157, 59)
        Me.btn_cadastrar.TabIndex = 75
        Me.btn_cadastrar.Text = "CHECK-IN"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox4.Location = New System.Drawing.Point(591, 53)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 28)
        Me.TextBox4.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(467, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Nª Rerserva:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 227)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados da Reserva"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(139, 36)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(209, 28)
        Me.ComboBox2.TabIndex = 37
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
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(271, 172)
        Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(88, 28)
        Me.DateTimePicker3.TabIndex = 74
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 172)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 28)
        Me.DateTimePicker1.TabIndex = 73
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox7.Location = New System.Drawing.Point(184, 123)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(175, 28)
        Me.TextBox7.TabIndex = 70
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox6.Location = New System.Drawing.Point(97, 79)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(185, 28)
        Me.TextBox6.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(16, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 23)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Pacote de Serviço:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label13.Location = New System.Drawing.Point(208, 172)
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
        Me.Label9.Location = New System.Drawing.Point(16, 172)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 23)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "CPF:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 311)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(367, 133)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acompanhante"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 44)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(209, 28)
        Me.ComboBox1.TabIndex = 36
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
        Me.Label7.Location = New System.Drawing.Point(25, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 23)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "CPF:"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox5.Location = New System.Drawing.Point(107, 82)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(209, 28)
        Me.TextBox5.TabIndex = 34
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox1.Location = New System.Drawing.Point(98, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 28)
        Me.TextBox1.TabIndex = 28
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
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox2.Location = New System.Drawing.Point(89, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 28)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox3.Location = New System.Drawing.Point(65, 53)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(203, 28)
        Me.TextBox3.TabIndex = 87
        '
        'frm_checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(789, 417)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_checkin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHECK-IN"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacoteDeServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
