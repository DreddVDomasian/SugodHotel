<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestManagement
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
    Public components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 545)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button7.Location = New System.Drawing.Point(6, 362)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(308, 46)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "STAFF MANAGEMENT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(6, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(308, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "CHECK-OUT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(6, 195)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(308, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "CHECK-IN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(6, 139)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(308, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "GUEST MANAGEMENT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(6, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(308, 49)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ROOM MANAGEMENT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "DASHBOARD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GuestManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GuestManagement"
        Me.Text = "GuestManagement"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
