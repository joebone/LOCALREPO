<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoProv = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblConn = New System.Windows.Forms.Label()
        Me.lblDbCmn = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.treeZonExterno = New System.Windows.Forms.TreeView()
        Me.treeZonJuniper = New System.Windows.Forms.TreeView()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.JnZonBusc = New System.Windows.Forms.ComboBox()
        Me.lblBcnZonJuni = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodExtern = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmbCodExterno = New System.Windows.Forms.ComboBox()
        Me.chkMostrar = New System.Windows.Forms.CheckBox()
        Me.cmbIdZon = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Producto"
        '
        'cmbTipoProv
        '
        Me.cmbTipoProv.FormattingEnabled = true
        Me.cmbTipoProv.Location = New System.Drawing.Point(94, 4)
        Me.cmbTipoProv.Name = "cmbTipoProv"
        Me.cmbTipoProv.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoProv.TabIndex = 1
        Me.cmbTipoProv.Text = "OLA"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(438, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Change_DBLocal"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'lblConn
        '
        Me.lblConn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblConn.AutoSize = true
        Me.lblConn.Location = New System.Drawing.Point(443, 12)
        Me.lblConn.Name = "lblConn"
        Me.lblConn.Size = New System.Drawing.Size(64, 13)
        Me.lblConn.TabIndex = 4
        Me.lblConn.Text = "Conn: None"
        Me.lblConn.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDbCmn
        '
        Me.lblDbCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblDbCmn.AutoSize = true
        Me.lblDbCmn.Location = New System.Drawing.Point(438, 53)
        Me.lblDbCmn.Name = "lblDbCmn"
        Me.lblDbCmn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDbCmn.Size = New System.Drawing.Size(72, 13)
        Me.lblDbCmn.TabIndex = 5
        Me.lblDbCmn.Text = "Comun: None"
        Me.lblDbCmn.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(438, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Change_DBComun"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Zonas Externas"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'treeZonExterno
        '
        Me.treeZonExterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.treeZonExterno.Location = New System.Drawing.Point(12, 144)
        Me.treeZonExterno.Name = "treeZonExterno"
        Me.treeZonExterno.Size = New System.Drawing.Size(329, 248)
        Me.treeZonExterno.TabIndex = 8
        '
        'treeZonJuniper
        '
        Me.treeZonJuniper.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.treeZonJuniper.Location = New System.Drawing.Point(347, 144)
        Me.treeZonJuniper.Name = "treeZonJuniper"
        Me.treeZonJuniper.Size = New System.Drawing.Size(319, 248)
        Me.treeZonJuniper.TabIndex = 9
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtLog.Location = New System.Drawing.Point(12, 532)
        Me.txtLog.Multiline = true
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(654, 52)
        Me.txtLog.TabIndex = 10
        '
        'JnZonBusc
        '
        Me.JnZonBusc.FormattingEnabled = true
        Me.JnZonBusc.Location = New System.Drawing.Point(502, 117)
        Me.JnZonBusc.Name = "JnZonBusc"
        Me.JnZonBusc.Size = New System.Drawing.Size(164, 21)
        Me.JnZonBusc.TabIndex = 11
        '
        'lblBcnZonJuni
        '
        Me.lblBcnZonJuni.AutoSize = true
        Me.lblBcnZonJuni.Location = New System.Drawing.Point(388, 120)
        Me.lblBcnZonJuni.Name = "lblBcnZonJuni"
        Me.lblBcnZonJuni.Size = New System.Drawing.Size(99, 13)
        Me.lblBcnZonJuni.TabIndex = 12
        Me.lblBcnZonJuni.Text = "Buscar Zon Juniper"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(14, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Codigo Externo"
        '
        'txtCodExtern
        '
        Me.txtCodExtern.Location = New System.Drawing.Point(17, 415)
        Me.txtCodExtern.Name = "txtCodExtern"
        Me.txtCodExtern.Size = New System.Drawing.Size(241, 20)
        Me.txtCodExtern.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(451, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ZonZonas"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(344, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "IdZon"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(538, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "zon_MostrarZona"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(591, 443)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Map!"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 574)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(678, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'cmbCodExterno
        '
        Me.cmbCodExterno.FormattingEnabled = true
        Me.cmbCodExterno.Location = New System.Drawing.Point(446, 411)
        Me.cmbCodExterno.Name = "cmbCodExterno"
        Me.cmbCodExterno.Size = New System.Drawing.Size(73, 21)
        Me.cmbCodExterno.TabIndex = 21
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = true
        Me.chkMostrar.Location = New System.Drawing.Point(541, 415)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(81, 17)
        Me.chkMostrar.TabIndex = 22
        Me.chkMostrar.Text = "CheckBox1"
        Me.chkMostrar.UseVisualStyleBackColor = true
        '
        'cmbIdZon
        '
        Me.cmbIdZon.FormattingEnabled = true
        Me.cmbIdZon.Location = New System.Drawing.Point(347, 412)
        Me.cmbIdZon.Name = "cmbIdZon"
        Me.cmbIdZon.Size = New System.Drawing.Size(93, 21)
        Me.cmbIdZon.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 596)
        Me.Controls.Add(Me.cmbIdZon)
        Me.Controls.Add(Me.chkMostrar)
        Me.Controls.Add(Me.cmbCodExterno)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodExtern)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBcnZonJuni)
        Me.Controls.Add(Me.JnZonBusc)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.treeZonJuniper)
        Me.Controls.Add(Me.treeZonExterno)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblDbCmn)
        Me.Controls.Add(Me.lblConn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbTipoProv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "FastMapper"
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoProv As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblConn As System.Windows.Forms.Label
    Friend WithEvents lblDbCmn As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents treeZonExterno As System.Windows.Forms.TreeView
    Friend WithEvents treeZonJuniper As System.Windows.Forms.TreeView
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents JnZonBusc As System.Windows.Forms.ComboBox
    Friend WithEvents lblBcnZonJuni As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodExtern As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmbCodExterno As System.Windows.Forms.ComboBox
    Friend WithEvents chkMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents cmbIdZon As System.Windows.Forms.ComboBox

End Class
