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
        Me.chkfood = New System.Windows.Forms.CheckBox()
        Me.chkcar = New System.Windows.Forms.CheckBox()
        Me.chknovel = New System.Windows.Forms.CheckBox()
        Me.chkprogramming = New System.Windows.Forms.CheckBox()
        Me.chkdance = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkfood
        '
        Me.chkfood.AutoSize = True
        Me.chkfood.Location = New System.Drawing.Point(12, 237)
        Me.chkfood.Name = "chkfood"
        Me.chkfood.Size = New System.Drawing.Size(51, 19)
        Me.chkfood.TabIndex = 0
        Me.chkfood.Text = "food"
        Me.chkfood.UseVisualStyleBackColor = True
        '
        'chkcar
        '
        Me.chkcar.AutoSize = True
        Me.chkcar.Location = New System.Drawing.Point(12, 262)
        Me.chkcar.Name = "chkcar"
        Me.chkcar.Size = New System.Drawing.Size(42, 19)
        Me.chkcar.TabIndex = 1
        Me.chkcar.Text = "car"
        Me.chkcar.UseVisualStyleBackColor = True
        '
        'chknovel
        '
        Me.chknovel.AutoSize = True
        Me.chknovel.Location = New System.Drawing.Point(12, 287)
        Me.chknovel.Name = "chknovel"
        Me.chknovel.Size = New System.Drawing.Size(55, 19)
        Me.chknovel.TabIndex = 2
        Me.chknovel.Text = "novel"
        Me.chknovel.UseVisualStyleBackColor = True
        '
        'chkprogramming
        '
        Me.chkprogramming.AutoSize = True
        Me.chkprogramming.Location = New System.Drawing.Point(12, 312)
        Me.chkprogramming.Name = "chkprogramming"
        Me.chkprogramming.Size = New System.Drawing.Size(100, 19)
        Me.chkprogramming.TabIndex = 3
        Me.chkprogramming.Text = "programming"
        Me.chkprogramming.UseVisualStyleBackColor = True
        '
        'chkdance
        '
        Me.chkdance.AutoSize = True
        Me.chkdance.Location = New System.Drawing.Point(12, 337)
        Me.chkdance.Name = "chkdance"
        Me.chkdance.Size = New System.Drawing.Size(58, 19)
        Me.chkdance.TabIndex = 4
        Me.chkdance.Text = "dance"
        Me.chkdance.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(565, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkdance)
        Me.Controls.Add(Me.chkprogramming)
        Me.Controls.Add(Me.chknovel)
        Me.Controls.Add(Me.chkcar)
        Me.Controls.Add(Me.chkfood)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkfood As CheckBox
    Friend WithEvents chkcar As CheckBox
    Friend WithEvents chknovel As CheckBox
    Friend WithEvents chkprogramming As CheckBox
    Friend WithEvents chkdance As CheckBox
    Friend WithEvents Button1 As Button
End Class
