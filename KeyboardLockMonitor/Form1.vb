Public Class Form1

    Dim isMoving = False
    Dim oPointClicked As Point

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.canMove Then
            Me.Cursor = Cursors.SizeAll
        Else
            Me.Cursor = Cursors.Default
        End If
        'If My.Computer.Keyboard.NumLock Then
        '    Label1.BackColor = Color.Blue
        'Else
        '    Label1.BackColor = TransparencyKey
        'End If
        'If My.Computer.Keyboard.CapsLock Then
        '    Label2.BackColor = Color.Blue
        'Else
        '    Label2.BackColor = TransparencyKey
        'End If
        'If My.Computer.Keyboard.ScrollLock Then
        '    Label3.BackColor = Color.Blue
        'Else
        '    Label3.BackColor = TransparencyKey
        'End If
        Label1.Visible = My.Computer.Keyboard.NumLock
        Label2.Visible = My.Computer.Keyboard.CapsLock
        Label3.Visible = My.Computer.Keyboard.ScrollLock
    End Sub
    Private Sub Form1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        KeyborardLockMonitor.Controls.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Contains("--resetConfig") Then
            My.Settings.Reset()
            My.Settings.Save()
        End If
        Me.Opacity = My.Settings.opacity / 100
        Me.Location = My.Settings.position
        Me.Show()
        If My.Settings.showTip Then
            MessageBox.Show("對視窗點兩下以開啟設定視窗\n如果不小心把視窗移到看不到的地方，可嘗試在啟動此程式時增加'--resetConfig'參數", "鍵盤鎖定監視器", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Settings.showTip = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMoving And My.Settings.canMove Then
            Dim oMoveToPoint As Point
            ' 以目前滑鼠位置為基礎，找出目標位置  
            oMoveToPoint = Me.PointToScreen(New Point(e.X, e.Y))
            ' 根據開始位置作出調整  
            oMoveToPoint.Offset(Me.oPointClicked.X * -1,
            (Me.oPointClicked.Y +
            SystemInformation.BorderSize.Height) * -1)
            ' 移動視窗  
            Me.Location = oMoveToPoint
            My.Settings.position = Me.Location
            My.Settings.Save()
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        isMoving = False
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        isMoving = True
        oPointClicked = New Point(e.X, e.Y)
    End Sub
End Class
