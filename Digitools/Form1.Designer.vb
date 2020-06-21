<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.btn_conv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenue sur Digi Tools !"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_calc
        '
        Me.btn_calc.BackgroundImage = CType(resources.GetObject("btn_calc.BackgroundImage"), System.Drawing.Image)
        Me.btn_calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_calc.Font = New System.Drawing.Font("Pacifico", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calc.ForeColor = System.Drawing.Color.White
        Me.btn_calc.Location = New System.Drawing.Point(57, 127)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(250, 133)
        Me.btn_calc.TabIndex = 1
        Me.btn_calc.Text = "Calculatrice"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'btn_conv
        '
        Me.btn_conv.BackgroundImage = CType(resources.GetObject("btn_conv.BackgroundImage"), System.Drawing.Image)
        Me.btn_conv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_conv.Font = New System.Drawing.Font("Pacifico", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_conv.ForeColor = System.Drawing.Color.Black
        Me.btn_conv.Location = New System.Drawing.Point(390, 127)
        Me.btn_conv.Name = "btn_conv"
        Me.btn_conv.Size = New System.Drawing.Size(250, 133)
        Me.btn_conv.TabIndex = 1
        Me.btn_conv.Text = "Convertisseur de devises"
        Me.btn_conv.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 330)
        Me.Controls.Add(Me.btn_conv)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DigiTools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_conv As Button
End Class
