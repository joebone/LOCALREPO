<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SELServidor
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
        Me.SrvCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoginCombo = New System.Windows.Forms.ComboBox()
        Me.BdCombo = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'SrvCombo
        '
        Me.SrvCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SrvCombo.FormattingEnabled = true
        Me.SrvCombo.Items.AddRange(New Object() {"yosemiteii", "mojaveii", "titanii", "redwoodiii", "menorca"})
        Me.SrvCombo.Location = New System.Drawing.Point(116, 53)
        Me.SrvCombo.Name = "SrvCombo"
        Me.SrvCombo.Size = New System.Drawing.Size(156, 21)
        Me.SrvCombo.TabIndex = 0
        Me.SrvCombo.Text = "yosemiteii"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servidor"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(59, 149)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(150, 23)
        Me.btnTest.TabIndex = 2
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Enabled = false
        Me.btnSave.Location = New System.Drawing.Point(59, 179)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "BD"
        '
        'LoginCombo
        '
        Me.LoginCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LoginCombo.FormattingEnabled = true
        Me.LoginCombo.Items.AddRange(New Object() {"desarrollo; juniper", "sa; as"})
        Me.LoginCombo.Location = New System.Drawing.Point(116, 75)
        Me.LoginCombo.Name = "LoginCombo"
        Me.LoginCombo.Size = New System.Drawing.Size(156, 21)
        Me.LoginCombo.TabIndex = 6
        Me.LoginCombo.Text = "desarrollo;juniper"
        '
        'BdCombo
        '
        Me.BdCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BdCombo.FormattingEnabled = true
        Me.BdCombo.Location = New System.Drawing.Point(116, 97)
        Me.BdCombo.Name = "BdCombo"
        Me.BdCombo.Size = New System.Drawing.Size(156, 21)
        Me.BdCombo.TabIndex = 7
        Me.BdCombo.Text = "Bd_Demo35a"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Items.AddRange(New Object() {"Yosemiteii- BDComun;     yosemiteii¬BD_Comun¬desarrollo¬juniper", "Yosemiteii- Bookingengine;     yosemiteii¬BD_BookingEngine¬desarrollo¬juniper", "Yosemiteii- Demo35a;     yosemiteii¬BD_Demo35a¬desarrollo¬juniper"})
        Me.ComboBox1.Location = New System.Drawing.Point(116, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(15, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PreSelec"
        '
        'SELServidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BdCombo)
        Me.Controls.Add(Me.LoginCombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SrvCombo)
        Me.Name = "SELServidor"
        Me.Text = "SELServidor"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents SrvCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LoginCombo As System.Windows.Forms.ComboBox
    Friend WithEvents BdCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
