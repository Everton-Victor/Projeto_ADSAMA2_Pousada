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
        Dim CheckoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reserva))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckoutToolStripMenuItem
        '
        CheckoutToolStripMenuItem.Image = CType(resources.GetObject("CheckoutToolStripMenuItem.Image"), System.Drawing.Image)
        CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        CheckoutToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        CheckoutToolStripMenuItem.Text = "Check-out"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(19, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "CPF:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox3.Location = New System.Drawing.Point(101, 23)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(209, 28)
        Me.TextBox3.TabIndex = 20
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(741, 42)
        Me.ToolStrip1.TabIndex = 22
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
        Me.ReservaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckinToolStripMenuItem, CheckoutToolStripMenuItem})
        Me.ReservaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservaToolStripMenuItem.Image = CType(resources.GetObject("ReservaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ReservaToolStripMenuItem.Text = "Cliente"
        '
        'CheckinToolStripMenuItem
        '
        Me.CheckinToolStripMenuItem.Image = CType(resources.GetObject("CheckinToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckinToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckinToolStripMenuItem.Name = "CheckinToolStripMenuItem"
        Me.CheckinToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.CheckinToolStripMenuItem.Text = "Check-in"
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
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(335, 224)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nome:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox2.Location = New System.Drawing.Point(101, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 28)
        Me.TextBox2.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Celular:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox1.Location = New System.Drawing.Point(101, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 28)
        Me.TextBox1.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(343, 49)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(372, 224)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acompanhante"
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(313, 124)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 28
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(344, 88)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 13)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(209, 28)
        Me.ComboBox1.TabIndex = 32
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
        Me.Label7.Location = New System.Drawing.Point(5, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 23)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "CPF:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox5.Location = New System.Drawing.Point(87, 51)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(209, 28)
        Me.TextBox5.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(313, 60)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 26
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Nome:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox4.Location = New System.Drawing.Point(101, 61)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(209, 28)
        Me.TextBox4.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(19, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "CPF:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox6.Location = New System.Drawing.Point(101, 23)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(209, 28)
        Me.TextBox6.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(27, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 23)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Pacote de serviço:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(27, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 23)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Quarto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label12.Location = New System.Drawing.Point(27, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 23)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Data de saída:"
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox11.Location = New System.Drawing.Point(199, 396)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(209, 28)
        Me.TextBox11.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(27, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Data de entrada:"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(199, 283)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(209, 28)
        Me.ComboBox2.TabIndex = 34
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(199, 321)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(209, 28)
        Me.ComboBox3.TabIndex = 35
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(199, 359)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 28)
        Me.DateTimePicker1.TabIndex = 36
        '
        'frm_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 444)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reversa"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacoteDeServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
