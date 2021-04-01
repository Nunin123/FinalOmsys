<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnManageStock = New System.Windows.Forms.Button()
        Me.lblWelcomeBack = New System.Windows.Forms.Label()
        Me.lblOrderMgmtSys = New System.Windows.Forms.Label()
        Me.lblOMSYS = New System.Windows.Forms.Label()
        Me.btnManageOrder = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManageStock
        '
        Me.btnManageStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageStock.BackColor = System.Drawing.Color.DarkCyan
        Me.btnManageStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageStock.ForeColor = System.Drawing.Color.White
        Me.btnManageStock.Location = New System.Drawing.Point(224, 365)
        Me.btnManageStock.Name = "btnManageStock"
        Me.btnManageStock.Size = New System.Drawing.Size(221, 60)
        Me.btnManageStock.TabIndex = 1
        Me.btnManageStock.Text = "Manage Stocks"
        Me.btnManageStock.UseVisualStyleBackColor = False
        '
        'lblWelcomeBack
        '
        Me.lblWelcomeBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcomeBack.AutoSize = True
        Me.lblWelcomeBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeBack.Location = New System.Drawing.Point(254, 243)
        Me.lblWelcomeBack.Name = "lblWelcomeBack"
        Me.lblWelcomeBack.Size = New System.Drawing.Size(157, 23)
        Me.lblWelcomeBack.TabIndex = 8
        Me.lblWelcomeBack.Text = "Welcome Back"
        '
        'lblOrderMgmtSys
        '
        Me.lblOrderMgmtSys.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrderMgmtSys.AutoSize = True
        Me.lblOrderMgmtSys.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMgmtSys.Location = New System.Drawing.Point(222, 182)
        Me.lblOrderMgmtSys.Name = "lblOrderMgmtSys"
        Me.lblOrderMgmtSys.Size = New System.Drawing.Size(209, 19)
        Me.lblOrderMgmtSys.TabIndex = 7
        Me.lblOrderMgmtSys.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'lblOMSYS
        '
        Me.lblOMSYS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOMSYS.AutoSize = True
        Me.lblOMSYS.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOMSYS.Location = New System.Drawing.Point(176, 86)
        Me.lblOMSYS.Name = "lblOMSYS"
        Me.lblOMSYS.Size = New System.Drawing.Size(315, 96)
        Me.lblOMSYS.TabIndex = 6
        Me.lblOMSYS.Text = "OMSYS"
        '
        'btnManageOrder
        '
        Me.btnManageOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageOrder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnManageOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageOrder.ForeColor = System.Drawing.Color.White
        Me.btnManageOrder.Location = New System.Drawing.Point(224, 299)
        Me.btnManageOrder.Name = "btnManageOrder"
        Me.btnManageOrder.Size = New System.Drawing.Size(221, 60)
        Me.btnManageOrder.TabIndex = 0
        Me.btnManageOrder.Text = "Manage Orders"
        Me.btnManageOrder.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogout.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(224, 431)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(221, 60)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 548)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnManageOrder)
        Me.Controls.Add(Me.btnManageStock)
        Me.Controls.Add(Me.lblWelcomeBack)
        Me.Controls.Add(Me.lblOrderMgmtSys)
        Me.Controls.Add(Me.lblOMSYS)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManageStock As Button
    Friend WithEvents lblWelcomeBack As Label
    Friend WithEvents lblOrderMgmtSys As Label
    Friend WithEvents lblOMSYS As Label
    Friend WithEvents btnManageOrder As Button
    Friend WithEvents btnLogout As Button
End Class
