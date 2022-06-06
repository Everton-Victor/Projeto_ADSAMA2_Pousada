<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_checkin_checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_checkin_checkout))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckoutToolStripMenuItem
        '
        CheckoutToolStripMenuItem.Image = CType(resources.GetObject("CheckoutToolStripMenuItem.Image"), System.Drawing.Image)
        CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        CheckoutToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
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
        Me.ReservaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {CheckoutToolStripMenuItem})
        Me.ReservaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservaToolStripMenuItem.Image = CType(resources.GetObject("ReservaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ReservaToolStripMenuItem.Text = "Cliente"
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
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(397, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 365)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados da Reserva"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 365)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nome:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox2.Location = New System.Drawing.Point(108, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 28)
        Me.TextBox2.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Celular:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox1.Location = New System.Drawing.Point(108, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 28)
        Me.TextBox1.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "CPF:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TextBox3.Location = New System.Drawing.Point(108, 44)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(209, 28)
        Me.TextBox3.TabIndex = 26
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 198)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 215)
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
        'frm_checkin_checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(789, 431)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_checkin_checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check-in/ Check-out"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
End Class
