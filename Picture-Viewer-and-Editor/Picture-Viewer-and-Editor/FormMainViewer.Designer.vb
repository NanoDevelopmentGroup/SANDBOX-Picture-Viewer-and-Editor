<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainViewer))
        Me.TableLayoutPanel_MainViewer = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel_ButtonDock = New System.Windows.Forms.TableLayoutPanel()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Open = New System.Windows.Forms.Button()
        Me.PictureBox_Main = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel_MainViewer.SuspendLayout()
        Me.TableLayoutPanel_ButtonDock.SuspendLayout()
        CType(Me.PictureBox_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel_MainViewer
        '
        Me.TableLayoutPanel_MainViewer.AutoSize = True
        Me.TableLayoutPanel_MainViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_MainViewer.ColumnCount = 1
        Me.TableLayoutPanel_MainViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_MainViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_MainViewer.Controls.Add(Me.TableLayoutPanel_ButtonDock, 0, 1)
        Me.TableLayoutPanel_MainViewer.Controls.Add(Me.PictureBox_Main, 0, 0)
        Me.TableLayoutPanel_MainViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_MainViewer.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_MainViewer.Name = "TableLayoutPanel_MainViewer"
        Me.TableLayoutPanel_MainViewer.RowCount = 2
        Me.TableLayoutPanel_MainViewer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_MainViewer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel_MainViewer.Size = New System.Drawing.Size(784, 411)
        Me.TableLayoutPanel_MainViewer.TabIndex = 0
        '
        'TableLayoutPanel_ButtonDock
        '
        Me.TableLayoutPanel_ButtonDock.ColumnCount = 4
        Me.TableLayoutPanel_ButtonDock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_ButtonDock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_ButtonDock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_ButtonDock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_ButtonDock.Controls.Add(Me.Button_Close, 1, 0)
        Me.TableLayoutPanel_ButtonDock.Controls.Add(Me.Button_Open, 0, 0)
        Me.TableLayoutPanel_ButtonDock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_ButtonDock.Location = New System.Drawing.Point(3, 374)
        Me.TableLayoutPanel_ButtonDock.Name = "TableLayoutPanel_ButtonDock"
        Me.TableLayoutPanel_ButtonDock.RowCount = 1
        Me.TableLayoutPanel_ButtonDock.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_ButtonDock.Size = New System.Drawing.Size(778, 34)
        Me.TableLayoutPanel_ButtonDock.TabIndex = 0
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.Location = New System.Drawing.Point(241, 3)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(100, 28)
        Me.Button_Close.TabIndex = 2
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Open
        '
        Me.Button_Open.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button_Open.Location = New System.Drawing.Point(47, 3)
        Me.Button_Open.Name = "Button_Open"
        Me.Button_Open.Size = New System.Drawing.Size(100, 28)
        Me.Button_Open.TabIndex = 1
        Me.Button_Open.Text = "Open"
        Me.Button_Open.UseVisualStyleBackColor = True
        '
        'PictureBox_Main
        '
        Me.PictureBox_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Main.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox_Main.Name = "PictureBox_Main"
        Me.PictureBox_Main.Size = New System.Drawing.Size(778, 365)
        Me.PictureBox_Main.TabIndex = 1
        Me.PictureBox_Main.TabStop = False
        '
        'FormMainViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.TableLayoutPanel_MainViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMainViewer"
        Me.Text = "[NDG] SANDBOX: Picture Viewer and Editor"
        Me.TableLayoutPanel_MainViewer.ResumeLayout(False)
        Me.TableLayoutPanel_ButtonDock.ResumeLayout(False)
        CType(Me.PictureBox_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel_MainViewer As TableLayoutPanel
    Friend WithEvents TableLayoutPanel_ButtonDock As TableLayoutPanel
    Friend WithEvents Button_Open As Button
    Friend WithEvents Button_Close As Button
    Friend WithEvents PictureBox_Main As PictureBox
End Class
