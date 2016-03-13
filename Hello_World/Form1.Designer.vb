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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_click = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_click
        '
        Me.btn_click.BackColor = System.Drawing.Color.Transparent
        Me.btn_click.BackgroundImage = CType(resources.GetObject("btn_click.BackgroundImage"), System.Drawing.Image)
        Me.btn_click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_click.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_click.FlatAppearance.BorderSize = 0
        Me.btn_click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_click.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_click.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_click.Location = New System.Drawing.Point(157, 87)
        Me.btn_click.Name = "btn_click"
        Me.btn_click.Size = New System.Drawing.Size(191, 41)
        Me.btn_click.TabIndex = 0
        Me.btn_click.Text = "Click Here"
        Me.btn_click.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(516, 230)
        Me.Controls.Add(Me.btn_click)
        Me.Name = "Form1"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_click As System.Windows.Forms.Button

End Class
