<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GetByUserNameButton = New System.Windows.Forms.Button()
        Me.GetByPrimaryKeyButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(625, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'GetByUserNameButton
        '
        Me.GetByUserNameButton.Location = New System.Drawing.Point(13, 15)
        Me.GetByUserNameButton.Name = "GetByUserNameButton"
        Me.GetByUserNameButton.Size = New System.Drawing.Size(104, 23)
        Me.GetByUserNameButton.TabIndex = 1
        Me.GetByUserNameButton.Text = "GetByUserName"
        Me.GetByUserNameButton.UseVisualStyleBackColor = True
        '
        'GetByPrimaryKeyButton
        '
        Me.GetByPrimaryKeyButton.Location = New System.Drawing.Point(123, 15)
        Me.GetByPrimaryKeyButton.Name = "GetByPrimaryKeyButton"
        Me.GetByPrimaryKeyButton.Size = New System.Drawing.Size(98, 23)
        Me.GetByPrimaryKeyButton.TabIndex = 2
        Me.GetByPrimaryKeyButton.Text = "GetByPrimaryKey"
        Me.GetByPrimaryKeyButton.UseVisualStyleBackColor = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 274)
        Me.Controls.Add(Me.GetByPrimaryKeyButton)
        Me.Controls.Add(Me.GetByUserNameButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EmployeeForm"
        Me.Text = "Employee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GetByUserNameButton As System.Windows.Forms.Button
    Friend WithEvents GetByPrimaryKeyButton As System.Windows.Forms.Button
End Class
