Option Strict Off
Option Explicit On 
Imports VB = Microsoft.VisualBasic
Friend Class AccesRight
    Inherits System.Windows.Forms.Form
#Region "Code généré par le Concepteur Windows Form "
    Public Sub New()
        MyBase.New()
        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()
    End Sub
    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    'Public WithEvents Tools As AxComctlLib.AxToolbar
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    'Public WithEvents StatusBar As AxComctlLib.AxStatusBar
    'Public WithEvents TreeView1 As AxComctlLib.AxTreeView
    'Public WithEvents ImageListView As AxComctlLib.AxImageList
    'Public WithEvents ImageListMenu As AxComctlLib.AxImageList
    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Il peut être modifié à l'aide du Concepteur Windows Form.
    'Ne pas le modifier à l'aide de l'éditeur de code.
    Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label_version As System.Windows.Forms.Label
    Friend WithEvents _CMenu_1 As System.Windows.Forms.Button
    Friend WithEvents CButton3 As CButtonLib.CButton
    Friend WithEvents CButton2 As CButtonLib.CButton
    Friend WithEvents CFermer As CButtonLib.CButton
    Friend WithEvents CAgrandir As CButtonLib.CButton
    Public WithEvents Label169 As System.Windows.Forms.Label
    Friend WithEvents CReduir As CButtonLib.CButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccesRight))
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker2 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker3 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker4 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker5 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker6 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker7 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker8 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker9 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker10 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusBar = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel2 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel3 = New System.Windows.Forms.StatusBarPanel()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._CMenu_1 = New System.Windows.Forms.Button()
        Me.label_version = New System.Windows.Forms.Label()
        Me.CButton3 = New CButtonLib.CButton()
        Me.CButton2 = New CButtonLib.CButton()
        Me.CFermer = New CButtonLib.CButton()
        Me.CAgrandir = New CButtonLib.CButton()
        Me.CReduir = New CButtonLib.CButton()
        Me.Label169 = New System.Windows.Forms.Label()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'StatusBar
        '
        Me.StatusBar.Location = New System.Drawing.Point(0, 696)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.Panel2, Me.Panel3})
        Me.StatusBar.ShowPanels = True
        Me.StatusBar.Size = New System.Drawing.Size(1030, 1)
        Me.StatusBar.TabIndex = 36
        Me.StatusBar.Visible = False
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 490
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Width = 520
        '
        'Panel3
        '
        Me.Panel3.Name = "Panel3"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me._CMenu_1)
        Me.Panel1.Location = New System.Drawing.Point(53, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 477)
        Me.Panel1.TabIndex = 347
        '
        '_CMenu_1
        '
        Me._CMenu_1.BackColor = System.Drawing.Color.Transparent
        Me._CMenu_1.BackgroundImage = CType(resources.GetObject("_CMenu_1.BackgroundImage"), System.Drawing.Image)
        Me._CMenu_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me._CMenu_1.FlatAppearance.BorderSize = 0
        Me._CMenu_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._CMenu_1.ForeColor = System.Drawing.Color.White
        Me._CMenu_1.Location = New System.Drawing.Point(325, 198)
        Me._CMenu_1.Name = "_CMenu_1"
        Me._CMenu_1.Size = New System.Drawing.Size(253, 56)
        Me._CMenu_1.TabIndex = 359
        Me._CMenu_1.UseVisualStyleBackColor = False
        '
        'label_version
        '
        Me.label_version.BackColor = System.Drawing.Color.Transparent
        Me.label_version.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_version.ForeColor = System.Drawing.Color.White
        Me.label_version.Location = New System.Drawing.Point(965, 679)
        Me.label_version.Name = "label_version"
        Me.label_version.Size = New System.Drawing.Size(61, 14)
        Me.label_version.TabIndex = 362
        Me.label_version.Text = "Version 1.8"
        Me.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CButton3
        '
        Me.CButton3.BackColor = System.Drawing.Color.Transparent
        Me.CButton3.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CButton3.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.CButton3.ColorFillBlend = CBlendItems1
        Me.CButton3.FocalPoints.CenterPtX = 0.0!
        Me.CButton3.FocalPoints.CenterPtY = 0.0!
        Me.CButton3.FocalPoints.FocusPtX = 0.0!
        Me.CButton3.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CButton3.FocusPtTracker = DesignerRectTracker2
        Me.CButton3.ImageIndex = 0
        Me.CButton3.Location = New System.Drawing.Point(1088, 11)
        Me.CButton3.Name = "CButton3"
        Me.CButton3.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CButton3.Size = New System.Drawing.Size(17, 20)
        Me.CButton3.TabIndex = 816
        Me.CButton3.Text = ""
        '
        'CButton2
        '
        Me.CButton2.BackColor = System.Drawing.Color.Transparent
        Me.CButton2.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CButton2.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.CButton2.ColorFillBlend = CBlendItems2
        Me.CButton2.FocalPoints.CenterPtX = 1.0!
        Me.CButton2.FocalPoints.CenterPtY = 0.0!
        Me.CButton2.FocalPoints.FocusPtX = 0.0!
        Me.CButton2.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CButton2.FocusPtTracker = DesignerRectTracker4
        Me.CButton2.ImageIndex = 0
        Me.CButton2.Location = New System.Drawing.Point(1069, 11)
        Me.CButton2.Name = "CButton2"
        Me.CButton2.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CButton2.Size = New System.Drawing.Size(17, 20)
        Me.CButton2.TabIndex = 815
        Me.CButton2.Text = ""
        '
        'CFermer
        '
        Me.CFermer.BackColor = System.Drawing.Color.Transparent
        Me.CFermer.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems3.iPoint = New Single() {0.0!, 1.0!}
        Me.CFermer.ColorFillBlend = CBlendItems3
        Me.CFermer.FocalPoints.CenterPtX = 0.0!
        Me.CFermer.FocalPoints.CenterPtY = 0.0!
        Me.CFermer.FocalPoints.FocusPtX = 0.0!
        Me.CFermer.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.FocusPtTracker = DesignerRectTracker6
        Me.CFermer.Image = Global.Maquette.My.Resources.Resources.Fermer
        Me.CFermer.ImageIndex = 0
        Me.CFermer.Location = New System.Drawing.Point(997, 9)
        Me.CFermer.Name = "CFermer"
        Me.CFermer.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CFermer.Size = New System.Drawing.Size(21, 18)
        Me.CFermer.TabIndex = 823
        Me.CFermer.Text = ""
        '
        'CAgrandir
        '
        Me.CAgrandir.BackColor = System.Drawing.Color.Transparent
        Me.CAgrandir.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.CenterPtTracker = DesignerRectTracker7
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems4.iPoint = New Single() {0.0!, 1.0!}
        Me.CAgrandir.ColorFillBlend = CBlendItems4
        Me.CAgrandir.FocalPoints.CenterPtX = 1.0!
        Me.CAgrandir.FocalPoints.CenterPtY = 0.0!
        Me.CAgrandir.FocalPoints.FocusPtX = 0.0!
        Me.CAgrandir.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.FocusPtTracker = DesignerRectTracker8
        Me.CAgrandir.Image = Global.Maquette.My.Resources.Resources.Agrandir
        Me.CAgrandir.ImageIndex = 0
        Me.CAgrandir.Location = New System.Drawing.Point(976, 9)
        Me.CAgrandir.Name = "CAgrandir"
        Me.CAgrandir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CAgrandir.Size = New System.Drawing.Size(21, 18)
        Me.CAgrandir.TabIndex = 822
        Me.CAgrandir.Text = ""
        '
        'CReduir
        '
        Me.CReduir.BackColor = System.Drawing.Color.Transparent
        Me.CReduir.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker9.IsActive = True
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.CenterPtTracker = DesignerRectTracker9
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems5.iPoint = New Single() {0.0!, 1.0!}
        Me.CReduir.ColorFillBlend = CBlendItems5
        Me.CReduir.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CReduir.FocalPoints.CenterPtX = 0.05882353!
        Me.CReduir.FocalPoints.CenterPtY = 0.4!
        Me.CReduir.FocalPoints.FocusPtX = 0.0!
        Me.CReduir.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.FocusPtTracker = DesignerRectTracker10
        Me.CReduir.ForeColor = System.Drawing.Color.Transparent
        Me.CReduir.Image = Global.Maquette.My.Resources.Resources.Reduire
        Me.CReduir.ImageIndex = 0
        Me.CReduir.Location = New System.Drawing.Point(955, 9)
        Me.CReduir.Name = "CReduir"
        Me.CReduir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CReduir.Size = New System.Drawing.Size(21, 18)
        Me.CReduir.TabIndex = 821
        Me.CReduir.Text = ""
        '
        'Label169
        '
        Me.Label169.BackColor = System.Drawing.Color.Transparent
        Me.Label169.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label169.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.5!)
        Me.Label169.ForeColor = System.Drawing.Color.White
        Me.Label169.Location = New System.Drawing.Point(38, 632)
        Me.Label169.Name = "Label169"
        Me.Label169.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label169.Size = New System.Drawing.Size(954, 34)
        Me.Label169.TabIndex = 824
        Me.Label169.Tag = "0035"
        Me.Label169.Text = "MX e-gov Version 2015 | Copyright © M2M Group | All rights reserved 2000-2015 I L" & _
            "icence n° 123456"
        Me.Label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccesRight
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1030, 697)
        Me.Controls.Add(Me.Label169)
        Me.Controls.Add(Me.CFermer)
        Me.Controls.Add(Me.CAgrandir)
        Me.Controls.Add(Me.CReduir)
        Me.Controls.Add(Me.label_version)
        Me.Controls.Add(Me.CButton3)
        Me.Controls.Add(Me.CButton2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(238, 172)
        Me.MaximizeBox = False
        Me.Name = "AccesRight"
        Me.Text = "Gestion Catre Grise"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Dim TempoRecGrp As Object 'RDO.rdoResultset

    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#       MAGIX5 BACK-OFFICE 5.1  © M2M 2000
    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#                   Project     : PMXBOAdministration
    '#!#M#                   Description : Module d'administration du Back-office
    '#!#M#                   Form        : AccesRight.frm
    '#!#M#                   Description : Forme des droit d'acces
    '#!#M#
    '#!#M#   Write           Author      :                                    Date :
    '#!#M#
    '#!#M#   Release         Description :
    '#!#M#                   Author      :                                    Date :
    '#!#M#                   Description :
    '#!#M#                   Author      :                                    Date :
    '#!#M#--------------------------------------------------------------------------------------------------------------
    Dim i0 As Integer
    Dim i1 As Integer
    Dim i2 As Integer
    Dim i3 As Integer
    Dim i4 As Integer
    Dim i5 As Integer
    Dim i6 As Integer
    Dim i7 As Integer
    Dim i8 As Integer
    Dim i9 As Integer
    Dim i10 As Integer

    Dim DReports As Object 'RDO.rdoResultset
    Dim ReportChaine As String


    Dim FirstLoad As Boolean

    Public Xp As Double
    Public Yp As Double
    Dim CMenu(4) As Object
    Dim Axe1 As Byte









    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Form_Load()
    '#!#F#                Type                : Local                                    (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :  Chargement des parametres par defaut de la forme
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------




    Private Sub AccesRight_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim sWebSp As String

        Dim Dt As Short
        Dim lg As String


        Me.CenterToScreen()
        Xp = Me.ClientSize.Width
        Yp = Me.ClientSize.Height
        Axe1 = 1

        Select Case Trim(Langue)
            Case "A"
                Text = "MAGIX  Version E-Gov 9i       (C)opyright M2M Banking Systems 1993-2007"
            Case "F"
                Text = "MAGIX Système Gestion Cartes Version 9i       (C)opyright M2M Systèmes Bancaires 1993-2007"
        End Select

        FirstLoad = True
        _CMenu_1.Enabled = True

        FirstLoad = False
        StatusBar.Panels(1).Text = Today & " . OP: " & CodeOperatrice
        StatusBar.Panels(2).Text = Format(TimeOfDay, "HH:mm")

    End Sub



    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick

        StatusBar.Panels.Item(2).Text = Format(TimeOfDay, "HH:mm")
    End Sub

    Private Sub AccesRight_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        Dim sX, sY As Integer
        Dim j As Integer
        Dim ctl As Control

        On Error Resume Next

        sX = Me.ClientSize.Width
        sY = Me.ClientSize.Height
        If (sX = 0 Or sY = 0) Then Exit Sub
        Xp = sX / Xp
        Yp = sY / Yp
        For Each ctl In Me.Controls

            ctl.Scale(Xp, Yp)

            redim_Object(ctl, Xp, Yp)
        Next
        Xp = Me.ClientSize.Width
        Yp = Me.ClientSize.Height
    End Sub


    Private Sub RBoutton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _CMenu_1.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Frmcartep = New Frmcartepermis
        Frmcartep.ShowDialog()
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
  

    Private Sub ToolsB11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim version As New Help
        version.ShowDialog()
    End Sub

    Private Sub CButton4_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Close()
    End Sub

    Private Sub CAgrandir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CAgrandir.MouseLeave
        CAgrandir.Image = My.Resources.Agrandir
    End Sub

    Private Sub CButton2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CAgrandir.MouseMove
        CAgrandir.Image = My.Resources.Agrandir_Actif
    End Sub

    Private Sub CReduir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CReduir.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CReduir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CReduir.MouseLeave
        CReduir.Image = My.Resources.Reduire
    End Sub

    Private Sub CReduir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CReduir.MouseMove
        CReduir.Image = My.Resources.Reduire_Actif
    End Sub

    Private Sub CFermer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFermer.Click
        Me.Close()
    End Sub

    Private Sub CFermer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFermer.MouseLeave
        CFermer.Image = My.Resources.Fermer
    End Sub

    Private Sub CFermer_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CFermer.MouseMove
        CFermer.Image = My.Resources.Fermer_Actif
    End Sub

End Class