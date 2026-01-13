<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addRoom
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.addRoomBtn = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.roomNumBox = New System.Windows.Forms.TextBox()
        Me.rate3hrsBox = New System.Windows.Forms.TextBox()
        Me.rate12hrsBox = New System.Windows.Forms.TextBox()
        Me.rate6hrsBox = New System.Windows.Forms.TextBox()
        Me.rate1dayBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.roomTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.roomStatusBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat Black", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(12, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(324, 52)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "ADD NEW ROOM"
        '
        'addRoomBtn
        '
        Me.addRoomBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.addRoomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.addRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addRoomBtn.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRoomBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addRoomBtn.Location = New System.Drawing.Point(192, 445)
        Me.addRoomBtn.Name = "addRoomBtn"
        Me.addRoomBtn.Size = New System.Drawing.Size(105, 39)
        Me.addRoomBtn.TabIndex = 20
        Me.addRoomBtn.Text = "Add Room"
        Me.addRoomBtn.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancel.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cancel.Location = New System.Drawing.Point(81, 445)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(105, 39)
        Me.cancel.TabIndex = 21
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label13.Location = New System.Drawing.Point(17, 70)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(135, 24)
        Me.label13.TabIndex = 22
        Me.label13.Text = "ROOM NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "RATES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(28, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "3HRS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(28, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "6HRS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(206, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "12HRS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(206, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "1DAY"
        '
        'roomNumBox
        '
        Me.roomNumBox.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomNumBox.Location = New System.Drawing.Point(32, 97)
        Me.roomNumBox.Name = "roomNumBox"
        Me.roomNumBox.Size = New System.Drawing.Size(318, 27)
        Me.roomNumBox.TabIndex = 28
        '
        'rate3hrsBox
        '
        Me.rate3hrsBox.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate3hrsBox.Location = New System.Drawing.Point(32, 266)
        Me.rate3hrsBox.Name = "rate3hrsBox"
        Me.rate3hrsBox.Size = New System.Drawing.Size(140, 27)
        Me.rate3hrsBox.TabIndex = 29
        '
        'rate12hrsBox
        '
        Me.rate12hrsBox.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate12hrsBox.Location = New System.Drawing.Point(210, 266)
        Me.rate12hrsBox.Name = "rate12hrsBox"
        Me.rate12hrsBox.Size = New System.Drawing.Size(140, 27)
        Me.rate12hrsBox.TabIndex = 33
        '
        'rate6hrsBox
        '
        Me.rate6hrsBox.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate6hrsBox.Location = New System.Drawing.Point(32, 323)
        Me.rate6hrsBox.Name = "rate6hrsBox"
        Me.rate6hrsBox.Size = New System.Drawing.Size(140, 27)
        Me.rate6hrsBox.TabIndex = 34
        '
        'rate1dayBox
        '
        Me.rate1dayBox.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate1dayBox.Location = New System.Drawing.Point(210, 323)
        Me.rate1dayBox.Name = "rate1dayBox"
        Me.rate1dayBox.Size = New System.Drawing.Size(140, 27)
        Me.rate1dayBox.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(12, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "INITIAL STATUS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(17, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "ROOM TYPE"
        '
        'roomTypeComboBox
        '
        Me.roomTypeComboBox.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.roomTypeComboBox.FormattingEnabled = True
        Me.roomTypeComboBox.Items.AddRange(New Object() {"ECONOMY", "PREMIUM", "DELUXE", "EXECUTIVE", "LUXURY"})
        Me.roomTypeComboBox.Location = New System.Drawing.Point(31, 170)
        Me.roomTypeComboBox.Name = "roomTypeComboBox"
        Me.roomTypeComboBox.Size = New System.Drawing.Size(319, 33)
        Me.roomTypeComboBox.TabIndex = 40
        '
        'roomStatusBox
        '
        Me.roomStatusBox.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.roomStatusBox.FormattingEnabled = True
        Me.roomStatusBox.Items.AddRange(New Object() {"Available", "Occupied", "Maintenance"})
        Me.roomStatusBox.Location = New System.Drawing.Point(32, 390)
        Me.roomStatusBox.Name = "roomStatusBox"
        Me.roomStatusBox.Size = New System.Drawing.Size(319, 33)
        Me.roomStatusBox.TabIndex = 41
        '
        'addRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 505)
        Me.Controls.Add(Me.roomStatusBox)
        Me.Controls.Add(Me.roomTypeComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rate1dayBox)
        Me.Controls.Add(Me.rate6hrsBox)
        Me.Controls.Add(Me.rate12hrsBox)
        Me.Controls.Add(Me.rate3hrsBox)
        Me.Controls.Add(Me.roomNumBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.addRoomBtn)
        Me.Controls.Add(Me.Label12)
        Me.Name = "addRoom"
        Me.Text = "addRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label12 As Label
    Private WithEvents addRoomBtn As Button
    Private WithEvents cancel As Button
    Private WithEvents label13 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents roomNumBox As TextBox
    Private WithEvents rate3hrsBox As TextBox
    Private WithEvents rate12hrsBox As TextBox
    Private WithEvents rate6hrsBox As TextBox
    Private WithEvents rate1dayBox As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents roomTypeComboBox As ComboBox
    Friend WithEvents roomStatusBox As ComboBox
End Class
