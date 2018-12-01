<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Controls
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Form1Opacity = New System.Windows.Forms.TrackBar()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Form1OpacityTitle = New System.Windows.Forms.Label()
        Me.Form1OpacityText = New System.Windows.Forms.Label()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.MoveButton = New System.Windows.Forms.CheckBox()
        Me.showTip = New System.Windows.Forms.CheckBox()
        CType(Me.Form1Opacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Form1Opacity
        '
        Me.Form1Opacity.LargeChange = 10
        Me.Form1Opacity.Location = New System.Drawing.Point(86, 13)
        Me.Form1Opacity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Form1Opacity.Maximum = 100
        Me.Form1Opacity.Name = "Form1Opacity"
        Me.Form1Opacity.Size = New System.Drawing.Size(145, 45)
        Me.Form1Opacity.TabIndex = 0
        Me.Form1Opacity.TickFrequency = 10
        Me.Form1Opacity.Value = 80
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(11, 49)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(127, 31)
        Me.ResetButton.TabIndex = 1
        Me.ResetButton.Text = "重置"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Form1OpacityTitle
        '
        Me.Form1OpacityTitle.AutoSize = True
        Me.Form1OpacityTitle.Location = New System.Drawing.Point(12, 16)
        Me.Form1OpacityTitle.Name = "Form1OpacityTitle"
        Me.Form1OpacityTitle.Size = New System.Drawing.Size(68, 16)
        Me.Form1OpacityTitle.TabIndex = 2
        Me.Form1OpacityTitle.Text = "視窗透明度"
        '
        'Form1OpacityText
        '
        Me.Form1OpacityText.AutoSize = True
        Me.Form1OpacityText.Location = New System.Drawing.Point(238, 16)
        Me.Form1OpacityText.Name = "Form1OpacityText"
        Me.Form1OpacityText.Size = New System.Drawing.Size(33, 16)
        Me.Form1OpacityText.TabIndex = 3
        Me.Form1OpacityText.Text = "80%"
        '
        'EndButton
        '
        Me.EndButton.Location = New System.Drawing.Point(12, 88)
        Me.EndButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(260, 31)
        Me.EndButton.TabIndex = 4
        Me.EndButton.Text = "關閉程式"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'MoveButton
        '
        Me.MoveButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.MoveButton.Location = New System.Drawing.Point(145, 49)
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.Size = New System.Drawing.Size(123, 31)
        Me.MoveButton.TabIndex = 5
        Me.MoveButton.Text = "移動視窗"
        Me.MoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MoveButton.UseVisualStyleBackColor = True
        '
        'showTip
        '
        Me.showTip.AutoSize = True
        Me.showTip.Location = New System.Drawing.Point(15, 127)
        Me.showTip.Name = "showTip"
        Me.showTip.Size = New System.Drawing.Size(111, 20)
        Me.showTip.TabIndex = 6
        Me.showTip.Text = "啟動時顯示提示"
        Me.showTip.UseVisualStyleBackColor = True
        '
        'Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 150)
        Me.Controls.Add(Me.showTip)
        Me.Controls.Add(Me.MoveButton)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.Form1OpacityText)
        Me.Controls.Add(Me.Form1OpacityTitle)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Form1Opacity)
        Me.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Controls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Controls"
        Me.TopMost = True
        CType(Me.Form1Opacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Form1Opacity As TrackBar
    Friend WithEvents ResetButton As Button
    Friend WithEvents Form1OpacityTitle As Label
    Friend WithEvents Form1OpacityText As Label
    Friend WithEvents EndButton As Button
    Friend WithEvents MoveButton As CheckBox
    Friend WithEvents showTip As CheckBox
End Class
