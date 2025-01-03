<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        Button3 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(38, 31)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 66)
        Button1.TabIndex = 0
        Button1.Text = "Taille pizza"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(346, 51)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(366, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(38, 132)
        Button2.Name = "Button2"
        Button2.Size = New Size(203, 62)
        Button2.TabIndex = 2
        Button2.Text = "Type de croute"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        CheckBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(693, 156)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(171, 32)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Croute épaisse"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        CheckBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox2.Location = New Point(482, 156)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(188, 32)
        CheckBox2.TabIndex = 4
        CheckBox2.Text = "Croute classique"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        CheckBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox3.Location = New Point(310, 156)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(139, 32)
        CheckBox3.TabIndex = 5
        CheckBox3.Text = "Croute fine"
        CheckBox3.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(12, 238)
        Button3.Name = "Button3"
        Button3.Size = New Size(335, 60)
        Button3.TabIndex = 6
        Button3.Text = "Ingrédients supplémentaires"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        RadioButton1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(353, 253)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(181, 32)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Champinignons"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        RadioButton2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(549, 253)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(90, 32)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Olives"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        RadioButton3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(645, 253)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(116, 32)
        RadioButton3.TabIndex = 9
        RadioButton3.TabStop = True
        RadioButton3.Text = "Poivrons"
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        RadioButton4.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton4.Location = New Point(767, 253)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(266, 32)
        RadioButton4.TabIndex = 10
        RadioButton4.TabStop = True
        RadioButton4.Text = "Fromage supplémentaire"
        RadioButton4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(379, 365)
        Label1.Name = "Label1"
        Label1.Size = New Size(350, 41)
        Label1.TabIndex = 11
        Label1.Text = "Afficher le récapitulatif"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Cover_Pizza
        ClientSize = New Size(1084, 450)
        Controls.Add(Label1)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button3)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label1 As Label

End Class
