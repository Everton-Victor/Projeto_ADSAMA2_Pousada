﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pacote_servico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pacote_servico))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_pac_serv = New System.Windows.Forms.TextBox()
        Me.txt_preco = New System.Windows.Forms.MaskedTextBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_pac_serv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_pac_serv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(727, 42)
        Me.ToolStrip1.TabIndex = 79
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservaToolStripMenuItem, Me.QuartosToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.EncerrarSessToolStripMenuItem})
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
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
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
        'QuartosToolStripMenuItem
        '
        Me.QuartosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuartosToolStripMenuItem.Image = CType(resources.GetObject("QuartosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuartosToolStripMenuItem.Name = "QuartosToolStripMenuItem"
        Me.QuartosToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.QuartosToolStripMenuItem.Text = "Quartos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FuncionáriosToolStripMenuItem.Image = CType(resources.GetObject("FuncionáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'EncerrarSessToolStripMenuItem
        '
        Me.EncerrarSessToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EncerrarSessToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSessToolStripMenuItem.Name = "EncerrarSessToolStripMenuItem"
        Me.EncerrarSessToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.EncerrarSessToolStripMenuItem.Text = "Encerrar sessão"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(690, 435)
        Me.TabControl1.TabIndex = 78
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_cod_pac_serv)
        Me.TabPage1.Controls.Add(Me.txt_preco)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.cmb_tipo)
        Me.TabPage1.Controls.Add(Me.txt_descricao)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(682, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(522, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 28)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Código:"
        '
        'txt_cod_pac_serv
        '
        Me.txt_cod_pac_serv.Enabled = False
        Me.txt_cod_pac_serv.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_pac_serv.Location = New System.Drawing.Point(527, 139)
        Me.txt_cod_pac_serv.Name = "txt_cod_pac_serv"
        Me.txt_cod_pac_serv.Size = New System.Drawing.Size(100, 35)
        Me.txt_cod_pac_serv.TabIndex = 13
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(288, 139)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(158, 32)
        Me.txt_preco.TabIndex = 12
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(23, 30)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(224, 225)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 11
        Me.img_foto.TabStop = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(473, 330)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(155, 61)
        Me.btn_cadastrar.TabIndex = 9
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(291, 220)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(155, 33)
        Me.cmb_tipo.TabIndex = 8
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(23, 306)
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(365, 32)
        Me.txt_descricao.TabIndex = 7
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(288, 61)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(339, 32)
        Me.txt_nome.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(285, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.Label6.Location = New System.Drawing.Point(286, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 28)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Preço:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(18, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 28)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Descrição:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 18.0!)
        Me.Label8.Location = New System.Drawing.Point(285, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nome:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_pac_serv)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(682, 397)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_pac_serv
        '
        Me.dgv_pac_serv.AllowUserToAddRows = False
        Me.dgv_pac_serv.AllowUserToDeleteRows = False
        Me.dgv_pac_serv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pac_serv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_pac_serv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pac_serv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2})
        Me.dgv_pac_serv.Location = New System.Drawing.Point(6, 0)
        Me.dgv_pac_serv.Name = "dgv_pac_serv"
        Me.dgv_pac_serv.ReadOnly = True
        Me.dgv_pac_serv.Size = New System.Drawing.Size(702, 409)
        Me.dgv_pac_serv.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 71
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 66
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descrição"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 87
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 56
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Preço"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 64
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 45
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Remover"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 63
        '
        'frm_pacote_servico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(727, 499)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_pacote_servico"
        Me.Text = "PACOTE DE SERVIÇOS - FSHM"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_pac_serv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_preco As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_pac_serv As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents txt_cod_pac_serv As TextBox
    Friend WithEvents Label1 As Label
End Class
