Namespace Example
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
			Me.userControlReplaceHelper1 = New Example.RibbonHeaderControlHelper()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.toggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.toggleSwitch2 = New DevExpress.XtraEditors.ToggleSwitch()
			DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ribbonControl1.SuspendLayout()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.toggleSwitch2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.Controls.Add(Me.pictureBox1)
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 2
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemToggleSwitch1})
			Me.ribbonControl1.Size = New System.Drawing.Size(987, 144)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
			Me.pictureBox1.Image = My.Resources.customer_16x16
			Me.pictureBox1.Location = New System.Drawing.Point(867, 4)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(26, 20)
			Me.pictureBox1.TabIndex = 6
			Me.pictureBox1.TabStop = False
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' repositoryItemToggleSwitch1
			' 
			Me.repositoryItemToggleSwitch1.AutoHeight = False
			Me.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1"
			Me.repositoryItemToggleSwitch1.OffText = "Off"
			Me.repositoryItemToggleSwitch1.OnText = "On"
			' 
			' userControlReplaceHelper1
			' 
			Me.userControlReplaceHelper1.HeaderControl = Me.pictureBox1
			Me.userControlReplaceHelper1.RibbonControl = Me.ribbonControl1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.AllowFocus = False
			Me.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.simpleButton1.Appearance.Options.UseBackColor = True
			Me.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
			Me.simpleButton1.Image = My.Resources.customer_16x16
			Me.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.simpleButton1.Location = New System.Drawing.Point(466, 323)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(30, 25)
			Me.simpleButton1.TabIndex = 7
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' toggleSwitch1
			' 
			Me.toggleSwitch1.Location = New System.Drawing.Point(92, 144)
			Me.toggleSwitch1.MenuManager = Me.ribbonControl1
			Me.toggleSwitch1.Name = "toggleSwitch1"
			Me.toggleSwitch1.Properties.OffText = "Off"
			Me.toggleSwitch1.Properties.OnText = "On"
			Me.toggleSwitch1.Size = New System.Drawing.Size(103, 24)
			Me.toggleSwitch1.TabIndex = 9
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 150)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(74, 13)
			Me.labelControl1.TabIndex = 10
			Me.labelControl1.Text = "AllowFormGlass"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 190)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(53, 13)
			Me.labelControl2.TabIndex = 13
			Me.labelControl2.Text = "Use Button"
			' 
			' toggleSwitch2
			' 
			Me.toggleSwitch2.Location = New System.Drawing.Point(92, 185)
			Me.toggleSwitch2.MenuManager = Me.ribbonControl1
			Me.toggleSwitch2.Name = "toggleSwitch2"
			Me.toggleSwitch2.Properties.OffText = "Off"
			Me.toggleSwitch2.Properties.OnText = "On"
			Me.toggleSwitch2.Size = New System.Drawing.Size(103, 24)
			Me.toggleSwitch2.TabIndex = 12
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.toggleSwitch2.Toggled += new System.EventHandler(this.toggleSwitch2_Toggled);
			' 
			' Form1
			' 
			Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(987, 525)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.toggleSwitch2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.toggleSwitch1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Form1"
			DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ribbonControl1.ResumeLayout(False)
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.toggleSwitch2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private userControlReplaceHelper1 As RibbonHeaderControlHelper
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private repositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
		Private WithEvents toggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents toggleSwitch2 As DevExpress.XtraEditors.ToggleSwitch
	End Class
End Namespace

