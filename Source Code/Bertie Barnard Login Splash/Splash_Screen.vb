Public Class Splash_Screen
    Inherits System.Windows.Forms.Form
 Public display_file As String
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal displayFile As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        display_file = displayFile
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Decline_Button As System.Windows.Forms.Button
    Friend WithEvents Accept_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Splash_Screen))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Decline_Button = New System.Windows.Forms.Button
        Me.Accept_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Decline_Button)
        Me.Panel1.Controls.Add(Me.Accept_Button)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(64, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 288)
        Me.Panel1.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 64)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(480, 168)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'Decline_Button
        '
        Me.Decline_Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Decline_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Decline_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Decline_Button.Location = New System.Drawing.Point(428, 256)
        Me.Decline_Button.Name = "Decline_Button"
        Me.Decline_Button.Size = New System.Drawing.Size(64, 23)
        Me.Decline_Button.TabIndex = 5
        Me.Decline_Button.Text = "Nee"
        '
        'Accept_Button
        '
        Me.Accept_Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Accept_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Accept_Button.Location = New System.Drawing.Point(356, 256)
        Me.Accept_Button.Name = "Accept_Button"
        Me.Accept_Button.Size = New System.Drawing.Size(64, 23)
        Me.Accept_Button.TabIndex = 4
        Me.Accept_Button.Text = "Ja"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Indien jy die bogenoemde aanvaar, druk 'Ja'. Indien nie, druk 'Nee'."
        '
        'Splash_Screen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "Splash_Screen"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laerskool Bertie Barnard Rekenaarsentrum"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Decline_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Decline_Button.Click
        Try
            Me.Hide()
            Dim ProcID As Integer
            ProcID = Shell("shutdown -l -f", AppWinStyle.NormalFocus, True, 30000)
            Application.Exit()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub Accept_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accept_Button.Click
        Try
            Me.Hide()
            Application.Exit()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub Splash_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RichTextBox1.Text = "Loading Message File from Server..."
            Try
                RichTextBox1.LoadFile(display_file)
                If RichTextBox1.TextLength <= 0 Then
                    RichTextBox1.Text = "Welkom by Laerskool Bertie Barnard Rekenaarsentrum."
                End If
            Catch et As Exception
                RichTextBox1.Text = "Welkom by Laerskool Bertie Barnard Rekenaarsentrum."
            End Try
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub
End Class
