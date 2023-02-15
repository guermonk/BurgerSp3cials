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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Veggie2 = New System.Windows.Forms.PictureBox()
        Me.PrimeBeef1 = New System.Windows.Forms.PictureBox()
        CType(Me.Veggie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimeBeef1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(293, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Farm Burger Specials"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Wheat
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Olive
        Me.btn1.Location = New System.Drawing.Point(88, 281)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(101, 27)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Prime Beef"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.Color.Wheat
        Me.BtnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelect.ForeColor = System.Drawing.Color.Olive
        Me.BtnSelect.Location = New System.Drawing.Point(342, 281)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(101, 27)
        Me.BtnSelect.TabIndex = 2
        Me.BtnSelect.Text = "Select Meal "
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Wheat
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Olive
        Me.btn2.Location = New System.Drawing.Point(598, 281)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(101, 27)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "Veggie"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(342, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Choose a burger and click the Select Meal button."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enjoy your burger special"
        '
        'Veggie2
        '
        Me.Veggie2.Image = Global.farmBurgerSpecials.My.Resources.Resources.testing
        Me.Veggie2.Location = New System.Drawing.Point(568, 104)
        Me.Veggie2.Name = "Veggie2"
        Me.Veggie2.Size = New System.Drawing.Size(158, 180)
        Me.Veggie2.TabIndex = 8
        Me.Veggie2.TabStop = False
        Me.Veggie2.Visible = False
        '
        'PrimeBeef1
        '
        Me.PrimeBeef1.Image = Global.farmBurgerSpecials.My.Resources.Resources.OIP
        Me.PrimeBeef1.Location = New System.Drawing.Point(61, 104)
        Me.PrimeBeef1.Name = "PrimeBeef1"
        Me.PrimeBeef1.Size = New System.Drawing.Size(158, 180)
        Me.PrimeBeef1.TabIndex = 7
        Me.PrimeBeef1.TabStop = False
        Me.PrimeBeef1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Veggie2)
        Me.Controls.Add(Me.PrimeBeef1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Burger Specials"
        CType(Me.Veggie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimeBeef1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrimeBeef1 As PictureBox
    Friend WithEvents Veggie2 As PictureBox
End Class
