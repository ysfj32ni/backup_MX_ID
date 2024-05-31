<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActivation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DesignerRectTracker5 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActivation))
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Dim DesignerRectTracker6 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Dim DesignerRectTracker2 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Me.Pn1 = New System.Windows.Forms.Panel
        Me.Frm_ETAT = New Maquette.AGroup
        Me.txt_carte = New System.Windows.Forms.TextBox
        Me.dtpkr_activation = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label121 = New System.Windows.Forms.Label
        Me.cmdOK = New CButtonLib.CButton
        Me.cmdCancel = New CButtonLib.CButton
        Me.Pn1.SuspendLayout()
        Me.Frm_ETAT.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pn1
        '
        Me.Pn1.BackColor = System.Drawing.Color.White
        Me.Pn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pn1.Controls.Add(Me.Frm_ETAT)
        Me.Pn1.Controls.Add(Me.cmdOK)
        Me.Pn1.Controls.Add(Me.cmdCancel)
        Me.Pn1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pn1.Location = New System.Drawing.Point(12, 28)
        Me.Pn1.Name = "Pn1"
        Me.Pn1.Size = New System.Drawing.Size(479, 195)
        Me.Pn1.TabIndex = 0
        '
        'Frm_ETAT
        '
        Me.Frm_ETAT.BackColorButton = System.Drawing.Color.White
        Me.Frm_ETAT.BackColorLabel = System.Drawing.Color.Transparent
        Me.Frm_ETAT.BorderColor = System.Drawing.Color.DarkGray
        Me.Frm_ETAT.Controls.Add(Me.txt_carte)
        Me.Frm_ETAT.Controls.Add(Me.dtpkr_activation)
        Me.Frm_ETAT.Controls.Add(Me.Label1)
        Me.Frm_ETAT.Controls.Add(Me.Label121)
        Me.Frm_ETAT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Frm_ETAT.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Frm_ETAT.LargeurGroup = 0
        Me.Frm_ETAT.Location = New System.Drawing.Point(18, 8)
        Me.Frm_ETAT.Name = "Frm_ETAT"
        Me.Frm_ETAT.Size = New System.Drawing.Size(441, 127)
        Me.Frm_ETAT.TabIndex = 919
        Me.Frm_ETAT.TabStop = False
        '
        'txt_carte
        '
        Me.txt_carte.AcceptsReturn = True
        Me.txt_carte.BackColor = System.Drawing.Color.White
        Me.txt_carte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_carte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_carte.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_carte.ForeColor = System.Drawing.Color.Black
        Me.txt_carte.Location = New System.Drawing.Point(202, 39)
        Me.txt_carte.MaxLength = 30
        Me.txt_carte.Name = "txt_carte"
        Me.txt_carte.ReadOnly = True
        Me.txt_carte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_carte.Size = New System.Drawing.Size(188, 21)
        Me.txt_carte.TabIndex = 911
        '
        'dtpkr_activation
        '
        Me.dtpkr_activation.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dtpkr_activation.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpkr_activation.Location = New System.Drawing.Point(202, 66)
        Me.dtpkr_activation.Name = "dtpkr_activation"
        Me.dtpkr_activation.ShowCheckBox = True
        Me.dtpkr_activation.Size = New System.Drawing.Size(108, 21)
        Me.dtpkr_activation.TabIndex = 918
        Me.dtpkr_activation.Value = New Date(2007, 2, 23, 16, 44, 36, 601)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(95, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 912
        Me.Label1.Tag = "0629"
        Me.Label1.Text = "Date d'activation :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label121
        '
        Me.Label121.BackColor = System.Drawing.Color.Transparent
        Me.Label121.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label121.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label121.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label121.Location = New System.Drawing.Point(95, 39)
        Me.Label121.Name = "Label121"
        Me.Label121.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label121.Size = New System.Drawing.Size(105, 16)
        Me.Label121.TabIndex = 912
        Me.Label121.Tag = "0629"
        Me.Label121.Text = "Numéro de carte :"
        Me.Label121.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdOK
        '
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdOK.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdOK.ColorFillBlend = CBlendItems3
        Me.cmdOK.Corners.All = CType(16, Short)
        Me.cmdOK.Corners.LowerLeft = CType(16, Short)
        Me.cmdOK.Corners.LowerRight = CType(16, Short)
        Me.cmdOK.Corners.UpperLeft = CType(16, Short)
        Me.cmdOK.Corners.UpperRight = CType(16, Short)
        Me.cmdOK.FocalPoints.CenterPtX = 1.0!
        Me.cmdOK.FocalPoints.CenterPtY = 0.4642857!
        Me.cmdOK.FocalPoints.FocusPtX = 0.0!
        Me.cmdOK.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdOK.FocusPtTracker = DesignerRectTracker6
        Me.cmdOK.ImageIndex = 0
        Me.cmdOK.Location = New System.Drawing.Point(241, 148)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(107, 29)
        Me.cmdOK.TabIndex = 917
        Me.cmdOK.Text = "OK"
        '
        'cmdCancel
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCancel.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdCancel.ColorFillBlend = CBlendItems1
        Me.cmdCancel.Corners.All = CType(16, Short)
        Me.cmdCancel.Corners.LowerLeft = CType(16, Short)
        Me.cmdCancel.Corners.LowerRight = CType(16, Short)
        Me.cmdCancel.Corners.UpperLeft = CType(16, Short)
        Me.cmdCancel.Corners.UpperRight = CType(16, Short)
        Me.cmdCancel.FocalPoints.CenterPtX = 0.4672897!
        Me.cmdCancel.FocalPoints.CenterPtY = 0.6551724!
        Me.cmdCancel.FocalPoints.FocusPtX = 0.0!
        Me.cmdCancel.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCancel.FocusPtTracker = DesignerRectTracker2
        Me.cmdCancel.ImageIndex = 0
        Me.cmdCancel.Location = New System.Drawing.Point(128, 148)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(107, 29)
        Me.cmdCancel.TabIndex = 917
        Me.cmdCancel.Text = "Annuler"
        '
        'FrmActivation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(501, 243)
        Me.Controls.Add(Me.Pn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmActivation"
        Me.Text = "ACtivation Permis"
        Me.Pn1.ResumeLayout(False)
        Me.Frm_ETAT.ResumeLayout(False)
        Me.Frm_ETAT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pn1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As CButtonLib.CButton
    Public WithEvents Label121 As System.Windows.Forms.Label
    Public WithEvents txt_carte As System.Windows.Forms.TextBox
    Friend WithEvents dtpkr_activation As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdOK As CButtonLib.CButton
    Friend WithEvents Frm_ETAT As Maquette.AGroup
    Public WithEvents Label1 As System.Windows.Forms.Label
End Class
