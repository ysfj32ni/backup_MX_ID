Public Class frmrechavancee
    Inherits System.Windows.Forms.Form

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents ToolsB1 As System.Windows.Forms.Button
    Friend WithEvents AGroup1 As Maquette.AGroup
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ttl_DatCrt As System.Windows.Forms.DateTimePicker
    Public WithEvents Ttl_NomPrenom As System.Windows.Forms.TextBox
    Public WithEvents _Labels_6 As System.Windows.Forms.Label
    Public WithEvents _Labels_0 As System.Windows.Forms.Label
    Friend WithEvents ToolsB2 As System.Windows.Forms.Button
    Friend WithEvents ToolsB3 As System.Windows.Forms.Button
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label2AV As System.Windows.Forms.Label
    Friend WithEvents CTOY_DATNAISSAV As System.Windows.Forms.DateTimePicker
    Public WithEvents Label23AV As System.Windows.Forms.Label
    Public WithEvents CTOY_NOMARAV As System.Windows.Forms.TextBox
    Public WithEvents CTOY_NOMAV As System.Windows.Forms.TextBox
    Public WithEvents Label24AV As System.Windows.Forms.Label
    Public WithEvents CTOY_PRENOMARAV As System.Windows.Forms.TextBox
    Public WithEvents CTOY_PRENOMAV As System.Windows.Forms.TextBox
    Public WithEvents Label11AV As System.Windows.Forms.Label
    Public WithEvents Label13AV As System.Windows.Forms.Label
    Public WithEvents Label15AV As System.Windows.Forms.Label
    Public WithEvents Ttl_NumpermAV As System.Windows.Forms.TextBox
    Public WithEvents PCDS_NUMEROAv As System.Windows.Forms.TextBox
    Public WithEvents PRP_NUMCARTEAV As System.Windows.Forms.TextBox
    Friend WithEvents PCPR_DATDELIVRANCEAv As System.Windows.Forms.DateTimePicker
    Friend WithEvents PCPR_DATVALIDITEAv As System.Windows.Forms.DateTimePicker
    Friend WithEvents idetifie_Agroup As Maquette.AGroup
    Friend WithEvents cdAv As System.Windows.Forms.RadioButton
    Friend WithEvents csAv As System.Windows.Forms.RadioButton
    Friend WithEvents pasAv As System.Windows.Forms.RadioButton
    Friend WithEvents cinAv As System.Windows.Forms.RadioButton
    Public WithEvents PCPR_NCITOYENAV As System.Windows.Forms.TextBox
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents Label54 As System.Windows.Forms.Label
    Public WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents SelectDet_2AV As System.Windows.Forms.Button
    Public WithEvents GVCI_LIBELLEAV As System.Windows.Forms.TextBox
    Public WithEvents PCPR_CODECIAV As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NRav As System.Windows.Forms.RadioButton
    Friend WithEvents CMPav As System.Windows.Forms.RadioButton
    Public WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents PC_An_Dep As System.Windows.Forms.TextBox
    Friend WithEvents CFermer As CButtonLib.CButton
    Friend WithEvents CAgrandir As CButtonLib.CButton
    Friend WithEvents CReduir As CButtonLib.CButton
    Friend WithEvents CmdNo As CButtonLib.CButton
    Friend WithEvents CmdOk As CButtonLib.CButton
    Public WithEvents Label169 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrechavancee))
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Dim DesignerRectTracker2 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim DesignerRectTracker3 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Dim DesignerRectTracker4 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim DesignerRectTracker5 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Dim DesignerRectTracker6 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim DesignerRectTracker7 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Dim DesignerRectTracker8 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim DesignerRectTracker9 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems
        Dim DesignerRectTracker10 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Me.ToolsB1 = New System.Windows.Forms.Button
        Me.ToolsB2 = New System.Windows.Forms.Button
        Me.ToolsB3 = New System.Windows.Forms.Button
        Me.AGroup1 = New Maquette.AGroup
        Me.CmdNo = New CButtonLib.CButton
        Me.CmdOk = New CButtonLib.CButton
        Me.PC_An_Dep = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.SelectDet_2AV = New System.Windows.Forms.Button
        Me.GVCI_LIBELLEAV = New System.Windows.Forms.TextBox
        Me.PCPR_CODECIAV = New System.Windows.Forms.TextBox
        Me.idetifie_Agroup = New Maquette.AGroup
        Me.CMPav = New System.Windows.Forms.RadioButton
        Me.Label59 = New System.Windows.Forms.Label
        Me.NRav = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.cdAv = New System.Windows.Forms.RadioButton
        Me.csAv = New System.Windows.Forms.RadioButton
        Me.pasAv = New System.Windows.Forms.RadioButton
        Me.cinAv = New System.Windows.Forms.RadioButton
        Me.PCPR_NCITOYENAV = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.CTOY_DATNAISSAV = New System.Windows.Forms.DateTimePicker
        Me.CTOY_NOMARAV = New System.Windows.Forms.TextBox
        Me.CTOY_NOMAV = New System.Windows.Forms.TextBox
        Me.Label24AV = New System.Windows.Forms.Label
        Me.CTOY_PRENOMARAV = New System.Windows.Forms.TextBox
        Me.CTOY_PRENOMAV = New System.Windows.Forms.TextBox
        Me.Label11AV = New System.Windows.Forms.Label
        Me.Label13AV = New System.Windows.Forms.Label
        Me.Label15AV = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PCPR_DATDELIVRANCEAv = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PCPR_DATVALIDITEAv = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Ttl_NumpermAV = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PCDS_NUMEROAv = New System.Windows.Forms.TextBox
        Me._Labels_0 = New System.Windows.Forms.Label
        Me.PRP_NUMCARTEAV = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label2AV = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label23AV = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CFermer = New CButtonLib.CButton
        Me.CAgrandir = New CButtonLib.CButton
        Me.CReduir = New CButtonLib.CButton
        Me.Label169 = New System.Windows.Forms.Label
        Me.AGroup1.SuspendLayout()
        Me.idetifie_Agroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolsB1
        '
        Me.ToolsB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToolsB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB1.Image = CType(resources.GetObject("ToolsB1.Image"), System.Drawing.Image)
        Me.ToolsB1.Location = New System.Drawing.Point(-146, 8)
        Me.ToolsB1.Name = "ToolsB1"
        Me.ToolsB1.Size = New System.Drawing.Size(78, 40)
        Me.ToolsB1.TabIndex = 361
        Me.ToolsB1.Tag = ""
        Me.ToolsB1.UseVisualStyleBackColor = False
        '
        'ToolsB2
        '
        Me.ToolsB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToolsB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB2.Image = CType(resources.GetObject("ToolsB2.Image"), System.Drawing.Image)
        Me.ToolsB2.Location = New System.Drawing.Point(-98, 8)
        Me.ToolsB2.Name = "ToolsB2"
        Me.ToolsB2.Size = New System.Drawing.Size(78, 40)
        Me.ToolsB2.TabIndex = 353
        Me.ToolsB2.UseVisualStyleBackColor = False
        '
        'ToolsB3
        '
        Me.ToolsB3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToolsB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB3.Image = CType(resources.GetObject("ToolsB3.Image"), System.Drawing.Image)
        Me.ToolsB3.Location = New System.Drawing.Point(-58, 8)
        Me.ToolsB3.Name = "ToolsB3"
        Me.ToolsB3.Size = New System.Drawing.Size(58, 40)
        Me.ToolsB3.TabIndex = 354
        Me.ToolsB3.UseVisualStyleBackColor = False
        '
        'AGroup1
        '
        Me.AGroup1.BackColorButton = System.Drawing.Color.White
        Me.AGroup1.BackColorLabel = System.Drawing.Color.DimGray
        Me.AGroup1.BorderColor = System.Drawing.Color.Gray
        Me.AGroup1.Controls.Add(Me.CmdNo)
        Me.AGroup1.Controls.Add(Me.CmdOk)
        Me.AGroup1.Controls.Add(Me.PC_An_Dep)
        Me.AGroup1.Controls.Add(Me.Label13)
        Me.AGroup1.Controls.Add(Me.SelectDet_2AV)
        Me.AGroup1.Controls.Add(Me.GVCI_LIBELLEAV)
        Me.AGroup1.Controls.Add(Me.PCPR_CODECIAV)
        Me.AGroup1.Controls.Add(Me.idetifie_Agroup)
        Me.AGroup1.Controls.Add(Me.CTOY_DATNAISSAV)
        Me.AGroup1.Controls.Add(Me.CTOY_NOMARAV)
        Me.AGroup1.Controls.Add(Me.CTOY_NOMAV)
        Me.AGroup1.Controls.Add(Me.Label24AV)
        Me.AGroup1.Controls.Add(Me.CTOY_PRENOMARAV)
        Me.AGroup1.Controls.Add(Me.CTOY_PRENOMAV)
        Me.AGroup1.Controls.Add(Me.Label11AV)
        Me.AGroup1.Controls.Add(Me.Label13AV)
        Me.AGroup1.Controls.Add(Me.Label15AV)
        Me.AGroup1.Controls.Add(Me.Label4)
        Me.AGroup1.Controls.Add(Me.PCPR_DATDELIVRANCEAv)
        Me.AGroup1.Controls.Add(Me.Label8)
        Me.AGroup1.Controls.Add(Me.Label3)
        Me.AGroup1.Controls.Add(Me.PCPR_DATVALIDITEAv)
        Me.AGroup1.Controls.Add(Me.Label6)
        Me.AGroup1.Controls.Add(Me.Label1)
        Me.AGroup1.Controls.Add(Me.Label12)
        Me.AGroup1.Controls.Add(Me.Label9)
        Me.AGroup1.Controls.Add(Me.Ttl_NumpermAV)
        Me.AGroup1.Controls.Add(Me.Label10)
        Me.AGroup1.Controls.Add(Me.PCDS_NUMEROAv)
        Me.AGroup1.Controls.Add(Me._Labels_0)
        Me.AGroup1.Controls.Add(Me.PRP_NUMCARTEAV)
        Me.AGroup1.Controls.Add(Me.Label14)
        Me.AGroup1.Controls.Add(Me.Label2AV)
        Me.AGroup1.Controls.Add(Me.Label7)
        Me.AGroup1.Controls.Add(Me.Label23AV)
        Me.AGroup1.Controls.Add(Me.Label5)
        Me.AGroup1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGroup1.ForeColorLabel = System.Drawing.Color.White
        Me.AGroup1.LargeurGroup = 600
        Me.AGroup1.Location = New System.Drawing.Point(9, 38)
        Me.AGroup1.Name = "AGroup1"
        Me.AGroup1.Size = New System.Drawing.Size(745, 395)
        Me.AGroup1.TabIndex = 365
        Me.AGroup1.TabStop = False
        Me.AGroup1.Text = "Recherche Avancée"
        '
        'CmdNo
        '
        Me.CmdNo.BackColor = System.Drawing.Color.Gainsboro
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdNo.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.CmdNo.ColorFillBlend = CBlendItems1
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdNo.FocusPtTracker = DesignerRectTracker2
        Me.CmdNo.ImageIndex = 0
        Me.CmdNo.Location = New System.Drawing.Point(387, 353)
        Me.CmdNo.Name = "CmdNo"
        Me.CmdNo.Size = New System.Drawing.Size(160, 24)
        Me.CmdNo.TabIndex = 823
        Me.CmdNo.Text = "Annuler"
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.Color.Gainsboro
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdOk.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.CmdOk.ColorFillBlend = CBlendItems2
        Me.CmdOk.FocalPoints.CenterPtX = 0.0!
        Me.CmdOk.FocalPoints.CenterPtY = 1.0!
        Me.CmdOk.FocalPoints.FocusPtX = 0.0!
        Me.CmdOk.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdOk.FocusPtTracker = DesignerRectTracker4
        Me.CmdOk.ImageIndex = 0
        Me.CmdOk.Location = New System.Drawing.Point(197, 353)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(160, 24)
        Me.CmdOk.TabIndex = 822
        Me.CmdOk.Text = "Valider"
        '
        'PC_An_Dep
        '
        Me.PC_An_Dep.AcceptsReturn = True
        Me.PC_An_Dep.BackColor = System.Drawing.Color.White
        Me.PC_An_Dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PC_An_Dep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PC_An_Dep.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.PC_An_Dep.ForeColor = System.Drawing.Color.Black
        Me.PC_An_Dep.Location = New System.Drawing.Point(236, 65)
        Me.PC_An_Dep.MaxLength = 4
        Me.PC_An_Dep.Name = "PC_An_Dep"
        Me.PC_An_Dep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PC_An_Dep.Size = New System.Drawing.Size(112, 21)
        Me.PC_An_Dep.TabIndex = 775
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(96, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(135, 16)
        Me.Label13.TabIndex = 776
        Me.Label13.Tag = "1315"
        Me.Label13.Text = "Année de dépôt :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SelectDet_2AV
        '
        Me.SelectDet_2AV.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SelectDet_2AV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectDet_2AV.ForeColor = System.Drawing.Color.Gray
        Me.SelectDet_2AV.Image = CType(resources.GetObject("SelectDet_2AV.Image"), System.Drawing.Image)
        Me.SelectDet_2AV.Location = New System.Drawing.Point(276, 232)
        Me.SelectDet_2AV.Name = "SelectDet_2AV"
        Me.SelectDet_2AV.Size = New System.Drawing.Size(24, 20)
        Me.SelectDet_2AV.TabIndex = 773
        Me.SelectDet_2AV.UseVisualStyleBackColor = False
        '
        'GVCI_LIBELLEAV
        '
        Me.GVCI_LIBELLEAV.AcceptsReturn = True
        Me.GVCI_LIBELLEAV.BackColor = System.Drawing.Color.White
        Me.GVCI_LIBELLEAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GVCI_LIBELLEAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GVCI_LIBELLEAV.Enabled = False
        Me.GVCI_LIBELLEAV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVCI_LIBELLEAV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GVCI_LIBELLEAV.Location = New System.Drawing.Point(300, 232)
        Me.GVCI_LIBELLEAV.MaxLength = 0
        Me.GVCI_LIBELLEAV.Name = "GVCI_LIBELLEAV"
        Me.GVCI_LIBELLEAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GVCI_LIBELLEAV.Size = New System.Drawing.Size(152, 22)
        Me.GVCI_LIBELLEAV.TabIndex = 774
        '
        'PCPR_CODECIAV
        '
        Me.PCPR_CODECIAV.AcceptsReturn = True
        Me.PCPR_CODECIAV.BackColor = System.Drawing.Color.White
        Me.PCPR_CODECIAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCPR_CODECIAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PCPR_CODECIAV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCPR_CODECIAV.ForeColor = System.Drawing.Color.Black
        Me.PCPR_CODECIAV.Location = New System.Drawing.Point(236, 232)
        Me.PCPR_CODECIAV.MaxLength = 3
        Me.PCPR_CODECIAV.Name = "PCPR_CODECIAV"
        Me.PCPR_CODECIAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PCPR_CODECIAV.Size = New System.Drawing.Size(40, 22)
        Me.PCPR_CODECIAV.TabIndex = 772
        '
        'idetifie_Agroup
        '
        Me.idetifie_Agroup.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.idetifie_Agroup.BackColorLabel = System.Drawing.Color.Transparent
        Me.idetifie_Agroup.BorderColor = System.Drawing.Color.DarkGray
        Me.idetifie_Agroup.Controls.Add(Me.CMPav)
        Me.idetifie_Agroup.Controls.Add(Me.Label59)
        Me.idetifie_Agroup.Controls.Add(Me.NRav)
        Me.idetifie_Agroup.Controls.Add(Me.Label2)
        Me.idetifie_Agroup.Controls.Add(Me.cdAv)
        Me.idetifie_Agroup.Controls.Add(Me.csAv)
        Me.idetifie_Agroup.Controls.Add(Me.pasAv)
        Me.idetifie_Agroup.Controls.Add(Me.cinAv)
        Me.idetifie_Agroup.Controls.Add(Me.PCPR_NCITOYENAV)
        Me.idetifie_Agroup.Controls.Add(Me.Label48)
        Me.idetifie_Agroup.Controls.Add(Me.Label54)
        Me.idetifie_Agroup.Controls.Add(Me.Label55)
        Me.idetifie_Agroup.Controls.Add(Me.Label56)
        Me.idetifie_Agroup.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.idetifie_Agroup.ForeColorLabel = System.Drawing.Color.Transparent
        Me.idetifie_Agroup.LargeurGroup = 0
        Me.idetifie_Agroup.Location = New System.Drawing.Point(235, 288)
        Me.idetifie_Agroup.Name = "idetifie_Agroup"
        Me.idetifie_Agroup.Size = New System.Drawing.Size(477, 40)
        Me.idetifie_Agroup.TabIndex = 771
        Me.idetifie_Agroup.TabStop = False
        '
        'CMPav
        '
        Me.CMPav.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CMPav.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CMPav.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMPav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMPav.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CMPav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMPav.Location = New System.Drawing.Point(280, 13)
        Me.CMPav.Name = "CMPav"
        Me.CMPav.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMPav.Size = New System.Drawing.Size(16, 14)
        Me.CMPav.TabIndex = 484
        Me.CMPav.Tag = ""
        Me.CMPav.UseVisualStyleBackColor = False
        Me.CMPav.Visible = False
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label59.Location = New System.Drawing.Point(296, 13)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(36, 18)
        Me.Label59.TabIndex = 483
        Me.Label59.Tag = ""
        Me.Label59.Text = "CMP"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label59.Visible = False
        '
        'NRav
        '
        Me.NRav.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NRav.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.NRav.Cursor = System.Windows.Forms.Cursors.Default
        Me.NRav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NRav.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NRav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NRav.Location = New System.Drawing.Point(218, 13)
        Me.NRav.Name = "NRav"
        Me.NRav.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NRav.Size = New System.Drawing.Size(16, 14)
        Me.NRav.TabIndex = 482
        Me.NRav.Tag = ""
        Me.NRav.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(234, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 481
        Me.Label2.Tag = ""
        Me.Label2.Text = "Rien"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cdAv
        '
        Me.cdAv.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cdAv.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cdAv.Cursor = System.Windows.Forms.Cursors.Default
        Me.cdAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdAv.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cdAv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cdAv.Location = New System.Drawing.Point(169, 13)
        Me.cdAv.Name = "cdAv"
        Me.cdAv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cdAv.Size = New System.Drawing.Size(16, 14)
        Me.cdAv.TabIndex = 480
        Me.cdAv.Tag = ""
        Me.cdAv.UseVisualStyleBackColor = False
        '
        'csAv
        '
        Me.csAv.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.csAv.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.csAv.Cursor = System.Windows.Forms.Cursors.Default
        Me.csAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.csAv.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.csAv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.csAv.Location = New System.Drawing.Point(113, 13)
        Me.csAv.Name = "csAv"
        Me.csAv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.csAv.Size = New System.Drawing.Size(16, 14)
        Me.csAv.TabIndex = 479
        Me.csAv.Tag = ""
        Me.csAv.UseVisualStyleBackColor = False
        '
        'pasAv
        '
        Me.pasAv.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pasAv.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pasAv.Cursor = System.Windows.Forms.Cursors.Default
        Me.pasAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pasAv.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.pasAv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pasAv.Location = New System.Drawing.Point(65, 13)
        Me.pasAv.Name = "pasAv"
        Me.pasAv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pasAv.Size = New System.Drawing.Size(16, 14)
        Me.pasAv.TabIndex = 478
        Me.pasAv.Tag = ""
        Me.pasAv.UseVisualStyleBackColor = False
        '
        'cinAv
        '
        Me.cinAv.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cinAv.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cinAv.Cursor = System.Windows.Forms.Cursors.Default
        Me.cinAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cinAv.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cinAv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cinAv.Location = New System.Drawing.Point(9, 13)
        Me.cinAv.Name = "cinAv"
        Me.cinAv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cinAv.Size = New System.Drawing.Size(16, 14)
        Me.cinAv.TabIndex = 477
        Me.cinAv.Tag = ""
        Me.cinAv.UseVisualStyleBackColor = False
        '
        'PCPR_NCITOYENAV
        '
        Me.PCPR_NCITOYENAV.AcceptsReturn = True
        Me.PCPR_NCITOYENAV.BackColor = System.Drawing.Color.White
        Me.PCPR_NCITOYENAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCPR_NCITOYENAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PCPR_NCITOYENAV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCPR_NCITOYENAV.ForeColor = System.Drawing.Color.Black
        Me.PCPR_NCITOYENAV.Location = New System.Drawing.Point(344, 10)
        Me.PCPR_NCITOYENAV.MaxLength = 12
        Me.PCPR_NCITOYENAV.Name = "PCPR_NCITOYENAV"
        Me.PCPR_NCITOYENAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PCPR_NCITOYENAV.Size = New System.Drawing.Size(128, 22)
        Me.PCPR_NCITOYENAV.TabIndex = 12
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label48.Location = New System.Drawing.Point(184, 12)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(24, 18)
        Me.Label48.TabIndex = 385
        Me.Label48.Tag = "$1215"
        Me.Label48.Text = "CD"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label54.Location = New System.Drawing.Point(135, 12)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(24, 18)
        Me.Label54.TabIndex = 375
        Me.Label54.Tag = "$1215"
        Me.Label54.Text = "CS"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label55.Location = New System.Drawing.Point(26, 12)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(28, 18)
        Me.Label55.TabIndex = 372
        Me.Label55.Tag = "$1214"
        Me.Label55.Text = "CIN"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label56.Location = New System.Drawing.Point(82, 12)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(24, 18)
        Me.Label56.TabIndex = 373
        Me.Label56.Tag = "$1215"
        Me.Label56.Text = "P"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CTOY_DATNAISSAV
        '
        Me.CTOY_DATNAISSAV.Checked = False
        Me.CTOY_DATNAISSAV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CTOY_DATNAISSAV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CTOY_DATNAISSAV.Location = New System.Drawing.Point(236, 136)
        Me.CTOY_DATNAISSAV.Name = "CTOY_DATNAISSAV"
        Me.CTOY_DATNAISSAV.ShowCheckBox = True
        Me.CTOY_DATNAISSAV.Size = New System.Drawing.Size(113, 21)
        Me.CTOY_DATNAISSAV.TabIndex = 6
        Me.CTOY_DATNAISSAV.Value = New Date(2007, 2, 23, 16, 44, 36, 601)
        '
        'CTOY_NOMARAV
        '
        Me.CTOY_NOMARAV.AcceptsReturn = True
        Me.CTOY_NOMARAV.BackColor = System.Drawing.Color.White
        Me.CTOY_NOMARAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CTOY_NOMARAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CTOY_NOMARAV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTOY_NOMARAV.ForeColor = System.Drawing.Color.Black
        Me.CTOY_NOMARAV.Location = New System.Drawing.Point(528, 184)
        Me.CTOY_NOMARAV.MaxLength = 30
        Me.CTOY_NOMARAV.Name = "CTOY_NOMARAV"
        Me.CTOY_NOMARAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CTOY_NOMARAV.Size = New System.Drawing.Size(144, 20)
        Me.CTOY_NOMARAV.TabIndex = 5
        Me.CTOY_NOMARAV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CTOY_NOMARAV.Visible = False
        '
        'CTOY_NOMAV
        '
        Me.CTOY_NOMAV.AcceptsReturn = True
        Me.CTOY_NOMAV.BackColor = System.Drawing.Color.White
        Me.CTOY_NOMAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CTOY_NOMAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CTOY_NOMAV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTOY_NOMAV.ForeColor = System.Drawing.Color.Black
        Me.CTOY_NOMAV.Location = New System.Drawing.Point(236, 112)
        Me.CTOY_NOMAV.MaxLength = 30
        Me.CTOY_NOMAV.Name = "CTOY_NOMAV"
        Me.CTOY_NOMAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CTOY_NOMAV.Size = New System.Drawing.Size(144, 22)
        Me.CTOY_NOMAV.TabIndex = 4
        '
        'Label24AV
        '
        Me.Label24AV.BackColor = System.Drawing.Color.Transparent
        Me.Label24AV.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24AV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24AV.ForeColor = System.Drawing.Color.Black
        Me.Label24AV.Location = New System.Drawing.Point(392, 112)
        Me.Label24AV.Name = "Label24AV"
        Me.Label24AV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24AV.Size = New System.Drawing.Size(48, 18)
        Me.Label24AV.TabIndex = 484
        Me.Label24AV.Tag = "0629"
        Me.Label24AV.Text = ": النسب"
        Me.Label24AV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CTOY_PRENOMARAV
        '
        Me.CTOY_PRENOMARAV.AcceptsReturn = True
        Me.CTOY_PRENOMARAV.BackColor = System.Drawing.Color.White
        Me.CTOY_PRENOMARAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CTOY_PRENOMARAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CTOY_PRENOMARAV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTOY_PRENOMARAV.ForeColor = System.Drawing.Color.Black
        Me.CTOY_PRENOMARAV.Location = New System.Drawing.Point(528, 160)
        Me.CTOY_PRENOMARAV.MaxLength = 30
        Me.CTOY_PRENOMARAV.Name = "CTOY_PRENOMARAV"
        Me.CTOY_PRENOMARAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CTOY_PRENOMARAV.Size = New System.Drawing.Size(144, 20)
        Me.CTOY_PRENOMARAV.TabIndex = 3
        Me.CTOY_PRENOMARAV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CTOY_PRENOMARAV.Visible = False
        '
        'CTOY_PRENOMAV
        '
        Me.CTOY_PRENOMAV.AcceptsReturn = True
        Me.CTOY_PRENOMAV.BackColor = System.Drawing.Color.White
        Me.CTOY_PRENOMAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CTOY_PRENOMAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CTOY_PRENOMAV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTOY_PRENOMAV.ForeColor = System.Drawing.Color.Black
        Me.CTOY_PRENOMAV.Location = New System.Drawing.Point(236, 88)
        Me.CTOY_PRENOMAV.MaxLength = 30
        Me.CTOY_PRENOMAV.Name = "CTOY_PRENOMAV"
        Me.CTOY_PRENOMAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CTOY_PRENOMAV.Size = New System.Drawing.Size(144, 22)
        Me.CTOY_PRENOMAV.TabIndex = 2
        '
        'Label11AV
        '
        Me.Label11AV.BackColor = System.Drawing.Color.Transparent
        Me.Label11AV.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11AV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11AV.ForeColor = System.Drawing.Color.Black
        Me.Label11AV.Location = New System.Drawing.Point(118, 144)
        Me.Label11AV.Name = "Label11AV"
        Me.Label11AV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11AV.Size = New System.Drawing.Size(115, 16)
        Me.Label11AV.TabIndex = 481
        Me.Label11AV.Tag = "0092"
        Me.Label11AV.Text = "Date de Naissance :"
        Me.Label11AV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13AV
        '
        Me.Label13AV.BackColor = System.Drawing.Color.Transparent
        Me.Label13AV.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13AV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13AV.ForeColor = System.Drawing.Color.Black
        Me.Label13AV.Location = New System.Drawing.Point(162, 88)
        Me.Label13AV.Name = "Label13AV"
        Me.Label13AV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13AV.Size = New System.Drawing.Size(72, 16)
        Me.Label13AV.TabIndex = 479
        Me.Label13AV.Tag = "0629"
        Me.Label13AV.Text = "Prénom :"
        Me.Label13AV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15AV
        '
        Me.Label15AV.BackColor = System.Drawing.Color.Transparent
        Me.Label15AV.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15AV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15AV.ForeColor = System.Drawing.Color.Black
        Me.Label15AV.Location = New System.Drawing.Point(171, 112)
        Me.Label15AV.Name = "Label15AV"
        Me.Label15AV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15AV.Size = New System.Drawing.Size(64, 16)
        Me.Label15AV.TabIndex = 480
        Me.Label15AV.Tag = "0629"
        Me.Label15AV.Text = "Nom :"
        Me.Label15AV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(85, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 478
        Me.Label4.Tag = "0211"
        Me.Label4.Text = "CI de dépôt :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PCPR_DATDELIVRANCEAv
        '
        Me.PCPR_DATDELIVRANCEAv.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.PCPR_DATDELIVRANCEAv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PCPR_DATDELIVRANCEAv.Location = New System.Drawing.Point(236, 184)
        Me.PCPR_DATDELIVRANCEAv.Name = "PCPR_DATDELIVRANCEAv"
        Me.PCPR_DATDELIVRANCEAv.ShowCheckBox = True
        Me.PCPR_DATDELIVRANCEAv.Size = New System.Drawing.Size(113, 21)
        Me.PCPR_DATDELIVRANCEAv.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(90, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 475
        Me.Label8.Tag = "1315"
        Me.Label8.Text = "Date Obtention :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(104, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(128, 18)
        Me.Label3.TabIndex = 474
        Me.Label3.Tag = "0253"
        Me.Label3.Text = "Date Expiration :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PCPR_DATVALIDITEAv
        '
        Me.PCPR_DATVALIDITEAv.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.PCPR_DATVALIDITEAv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PCPR_DATVALIDITEAv.Location = New System.Drawing.Point(236, 208)
        Me.PCPR_DATVALIDITEAv.Name = "PCPR_DATVALIDITEAv"
        Me.PCPR_DATVALIDITEAv.ShowCheckBox = True
        Me.PCPR_DATVALIDITEAv.Size = New System.Drawing.Size(113, 21)
        Me.PCPR_DATVALIDITEAv.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(119, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 463
        Me.Label6.Tag = "0035"
        Me.Label6.Text = "Numéro d'Identité  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(488, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 423
        Me.Label1.Tag = "0211"
        Me.Label1.Text = ": مركز تسجيل السيارات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(350, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(104, 24)
        Me.Label12.TabIndex = 419
        Me.Label12.Tag = "1315"
        Me.Label12.Text = ": تاريخ  الصلاحية"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(333, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 416
        Me.Label9.Tag = "1315"
        Me.Label9.Text = ": تاريخ  التسليم "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Ttl_NumpermAV
        '
        Me.Ttl_NumpermAV.AcceptsReturn = True
        Me.Ttl_NumpermAV.BackColor = System.Drawing.Color.White
        Me.Ttl_NumpermAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ttl_NumpermAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Ttl_NumpermAV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Ttl_NumpermAV.ForeColor = System.Drawing.Color.Black
        Me.Ttl_NumpermAV.Location = New System.Drawing.Point(236, 160)
        Me.Ttl_NumpermAV.MaxLength = 12
        Me.Ttl_NumpermAV.Name = "Ttl_NumpermAV"
        Me.Ttl_NumpermAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ttl_NumpermAV.Size = New System.Drawing.Size(112, 21)
        Me.Ttl_NumpermAV.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(80, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(152, 16)
        Me.Label10.TabIndex = 412
        Me.Label10.Tag = "1315"
        Me.Label10.Text = "Numéro Permis Conduire :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PCDS_NUMEROAv
        '
        Me.PCDS_NUMEROAv.AcceptsReturn = True
        Me.PCDS_NUMEROAv.BackColor = System.Drawing.Color.White
        Me.PCDS_NUMEROAv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCDS_NUMEROAv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PCDS_NUMEROAv.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCDS_NUMEROAv.ForeColor = System.Drawing.Color.Black
        Me.PCDS_NUMEROAv.Location = New System.Drawing.Point(236, 42)
        Me.PCDS_NUMEROAv.MaxLength = 10
        Me.PCDS_NUMEROAv.Name = "PCDS_NUMEROAv"
        Me.PCDS_NUMEROAv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PCDS_NUMEROAv.Size = New System.Drawing.Size(112, 21)
        Me.PCDS_NUMEROAv.TabIndex = 1
        '
        '_Labels_0
        '
        Me._Labels_0.BackColor = System.Drawing.Color.Transparent
        Me._Labels_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Labels_0.Font = New System.Drawing.Font("Arial", 9.0!)
        Me._Labels_0.ForeColor = System.Drawing.Color.Black
        Me._Labels_0.Location = New System.Drawing.Point(98, 46)
        Me._Labels_0.Name = "_Labels_0"
        Me._Labels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Labels_0.Size = New System.Drawing.Size(135, 16)
        Me._Labels_0.TabIndex = 352
        Me._Labels_0.Tag = "1315"
        Me._Labels_0.Text = "Numéro Dossier :"
        Me._Labels_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PRP_NUMCARTEAV
        '
        Me.PRP_NUMCARTEAV.AcceptsReturn = True
        Me.PRP_NUMCARTEAV.BackColor = System.Drawing.Color.White
        Me.PRP_NUMCARTEAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PRP_NUMCARTEAV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PRP_NUMCARTEAV.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.PRP_NUMCARTEAV.ForeColor = System.Drawing.Color.Black
        Me.PRP_NUMCARTEAV.Location = New System.Drawing.Point(236, 256)
        Me.PRP_NUMCARTEAV.MaxLength = 19
        Me.PRP_NUMCARTEAV.Name = "PRP_NUMCARTEAV"
        Me.PRP_NUMCARTEAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PRP_NUMCARTEAV.Size = New System.Drawing.Size(157, 22)
        Me.PRP_NUMCARTEAV.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(134, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(96, 17)
        Me.Label14.TabIndex = 388
        Me.Label14.Tag = "0211"
        Me.Label14.Text = "Numéro Carte :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2AV
        '
        Me.Label2AV.BackColor = System.Drawing.Color.Transparent
        Me.Label2AV.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2AV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2AV.ForeColor = System.Drawing.Color.Black
        Me.Label2AV.Location = New System.Drawing.Point(345, 136)
        Me.Label2AV.Name = "Label2AV"
        Me.Label2AV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2AV.Size = New System.Drawing.Size(92, 24)
        Me.Label2AV.TabIndex = 489
        Me.Label2AV.Tag = "0092"
        Me.Label2AV.Text = ":  تاريخ الولادة"
        Me.Label2AV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(310, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(136, 20)
        Me.Label7.TabIndex = 417
        Me.Label7.Tag = "1315"
        Me.Label7.Text = ": رخصة  السياقة"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23AV
        '
        Me.Label23AV.BackColor = System.Drawing.Color.Transparent
        Me.Label23AV.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23AV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23AV.ForeColor = System.Drawing.Color.Black
        Me.Label23AV.Location = New System.Drawing.Point(392, 88)
        Me.Label23AV.Name = "Label23AV"
        Me.Label23AV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23AV.Size = New System.Drawing.Size(107, 18)
        Me.Label23AV.TabIndex = 487
        Me.Label23AV.Tag = "0629"
        Me.Label23AV.Text = " : الاسم ا لشخصي"
        Me.Label23AV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(336, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 391
        Me.Label5.Tag = "1315"
        Me.Label5.Text = ": رقم الملف"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.CFermer.Location = New System.Drawing.Point(741, 5)
        Me.CFermer.Name = "CFermer"
        Me.CFermer.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CFermer.Size = New System.Drawing.Size(21, 18)
        Me.CFermer.TabIndex = 826
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
        Me.CAgrandir.Location = New System.Drawing.Point(720, 5)
        Me.CAgrandir.Name = "CAgrandir"
        Me.CAgrandir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CAgrandir.Size = New System.Drawing.Size(21, 18)
        Me.CAgrandir.TabIndex = 825
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
        DesignerRectTracker10.IsActive = True
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.FocusPtTracker = DesignerRectTracker10
        Me.CReduir.ForeColor = System.Drawing.Color.Transparent
        Me.CReduir.Image = Global.Maquette.My.Resources.Resources.Reduire
        Me.CReduir.ImageIndex = 0
        Me.CReduir.Location = New System.Drawing.Point(699, 5)
        Me.CReduir.Name = "CReduir"
        Me.CReduir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CReduir.Size = New System.Drawing.Size(21, 18)
        Me.CReduir.TabIndex = 824
        Me.CReduir.Text = ""
        '
        'Label169
        '
        Me.Label169.BackColor = System.Drawing.Color.Transparent
        Me.Label169.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label169.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label169.ForeColor = System.Drawing.Color.White
        Me.Label169.Location = New System.Drawing.Point(17, 436)
        Me.Label169.Name = "Label169"
        Me.Label169.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label169.Size = New System.Drawing.Size(735, 34)
        Me.Label169.TabIndex = 934
        Me.Label169.Tag = "0035"
        Me.Label169.Text = "MX e-gov Version 2015 | Copyright © M2M Group | All rights reserved 2000-2015 I L" & _
            "icence n° 123456"
        Me.Label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmrechavancee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 470)
        Me.Controls.Add(Me.Label169)
        Me.Controls.Add(Me.CFermer)
        Me.Controls.Add(Me.CAgrandir)
        Me.Controls.Add(Me.CReduir)
        Me.Controls.Add(Me.ToolsB1)
        Me.Controls.Add(Me.AGroup1)
        Me.Controls.Add(Me.ToolsB2)
        Me.Controls.Add(Me.ToolsB3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(768, 456)
        Me.Name = "frmrechavancee"
        Me.Text = "Recherche Avancée PC"
        Me.AGroup1.ResumeLayout(False)
        Me.AGroup1.PerformLayout()
        Me.idetifie_Agroup.ResumeLayout(False)
        Me.idetifie_Agroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public ChaineAvance As String = " 1=1"
    Public Etat_av As Byte
    Public ErrSearch As Boolean

    Private Sub CmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNo.Click

        Me.Close()

    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If Not verif_version() Then Exit Sub
        Etat_av = 5
        ChaineAvance = " 1=1"
        If Trim(PCDS_NUMEROAv.Text) <> "" Then ChaineAvance = ChaineAvance & " AND PCDS_NUMERO = '" & ChaineOK((PCDS_NUMEROAv.Text)) & "'"
        If Trim(CTOY_PRENOMAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND CTOY_PRENOM = '" & ChaineOK((CTOY_PRENOMAV.Text)) & "'"
        If Trim(CTOY_NOMAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND CTOY_NOM = '" & ChaineOK((CTOY_NOMAV.Text)) & "'"
        If Trim(CTOY_PRENOMARAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND CTOY_PRENOMAR = '" & ChaineOK((CTOY_PRENOMARAV.Text)) & "'"
        If Trim(CTOY_NOMARAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND CTOY_NOMAR = '" & ChaineOK((CTOY_NOMARAV.Text)) & "'"
        If Trim(CTOY_DATNAISSAV.Checked) <> False Then ChaineAvance = ChaineAvance & " AND CTOY_DATNAISS = '" & FormatDateTime(CTOY_DATNAISSAV.Value, DateFormat.ShortDate) & "'"
        If Trim(PRP_NUMCARTEAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND PRP_NUMCARTE = '" & ChaineOK((PRP_NUMCARTEAV.Text)) & "'"
        If Trim(Ttl_NumpermAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND PCDS_NPC = '" & ChaineOK((Ttl_NumpermAV.Text)) & "'"
        'If Trim(PCPR_NCITOYENAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND PCPR_NCITOYEN = '" & ChaineOK((PCPR_NCITOYENAV.Text)) & "'"
        If Trim(PCPR_DATDELIVRANCEAv.Checked) <> False Then ChaineAvance = ChaineAvance & " AND PCPR_DATDELIVRANCE = '" & FormatDateTime((PCPR_DATDELIVRANCEAv.Value), DateFormat.ShortDate) & "'"
        If Trim(PCPR_DATVALIDITEAv.Checked) <> False Then ChaineAvance = ChaineAvance & " AND PCPR_DATVALIDITE = '" & FormatDateTime((PCPR_DATVALIDITEAv.Value), DateFormat.ShortDate) & "'"
        If Trim(PCPR_CODECIAV.Text) <> "" Then ChaineAvance = ChaineAvance & " AND prp_nsite = '" & ChaineOK((PCPR_CODECIAV.Text)) & "'"
        'JR 24/02/2011 integrer la recherche par anee de depot
        If Trim(PC_An_Dep.Text) <> "" Then ChaineAvance = ChaineAvance & " AND PCDS_ANDEPOT = '" & ChaineOK((PC_An_Dep.Text)) & "'"
        If Trim(PCPR_NCITOYENAV.Text) <> "" Then
            '''If cinAv.Checked = False And pasAv.Checked = False And csAv.Checked = False And cdAv.Checked = False And CMPav.Checked = False And NRav.Checked = False Then
            '''    Message("Veuillez choisir un type d'identité ...!", 64)
            '''    PCPR_NCITOYENAV.Focus()
            '''    ErrSearch = True
            '''    Exit Sub
            '''Else
            'JR 24/02/2011 remplacer PCPR_NCITOYEN par CTOY_NIDENTITE
            ChaineAvance = ChaineAvance & " AND CTOY_NIDENTITE = '" & ChaineOK((PCPR_NCITOYENAV.Text)) & "'"
            '''End If
        End If
        If cinAv.Checked = True Then ChaineAvance = ChaineAvance & " AND CTOY_TYPIDENT = 'C' "
        If pasAv.Checked = True Then ChaineAvance = ChaineAvance & " AND CTOY_TYPIDENT = 'P' "
        If csAv.Checked = True Then ChaineAvance = ChaineAvance & " AND CTOY_TYPIDENT = 'S' "
        If cdAv.Checked = True Then ChaineAvance = ChaineAvance & " AND CTOY_TYPIDENT = 'D' "
        If CMPav.Checked = True Then ChaineAvance = ChaineAvance & " AND CTOY_TYPIDENT = 'M' "
        If NRav.Checked = True Then ChaineAvance = ChaineAvance & " AND CTOY_TYPIDENT IS NULL "
        Frmcartep.ValidateDEnrolement()
        'Me.Close()
    End Sub

    Private Sub frmrechavancee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FrmColor(rechavc)
        Xp = Me.ClientSize.Width
        Yp = Me.ClientSize.Height

        Me.CenterToScreen()
        Init()
    End Sub

    Public Sub Init()
        Try
            Etat_av = 0
            Datechecked(PCPR_DATDELIVRANCEAv)
            Datechecked(PCPR_DATVALIDITEAv)
            Datechecked(CTOY_DATNAISSAV)
            cinAv.Checked = False
            pasAv.Checked = False
            csAv.Checked = False
            cdAv.Checked = False
            PCPR_NCITOYENAV.Text = ""
            CTOY_PRENOMAV.Text = ""
            CTOY_NOMARAV.Text = ""
            CTOY_PRENOMARAV.Text = ""
            CTOY_NOMAV.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SelectDet_2AV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectDet_2AV.Click
        NumSelection = 2000
        lotof = New LotOfSelection
        lotof.ShowDialog()
    End Sub

    Private Sub PCDS_NUMEROAv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCDS_NUMEROAv.TextChanged

    End Sub

    Private Sub PCDS_NUMEROAv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PCDS_NUMEROAv.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_PRENOMAV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTOY_PRENOMAV.TextChanged

    End Sub

    Private Sub CTOY_PRENOMAV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CTOY_PRENOMAV.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCPR_NCITOYENAV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCPR_NCITOYENAV.TextChanged

    End Sub

    Private Sub PCPR_NCITOYENAV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PCPR_NCITOYENAV.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCPR_CODECIAV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PCPR_CODECIAV.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRP_NUMCARTEAV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRP_NUMCARTEAV.TextChanged

    End Sub

    Private Sub PRP_NUMCARTEAV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRP_NUMCARTEAV.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCPR_CODECIAV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCPR_CODECIAV.TextChanged

    End Sub

    Private Sub Ttl_NumpermAV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ttl_NumpermAV.TextChanged

    End Sub

    Private Sub Ttl_NumpermAV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ttl_NumpermAV.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
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

    Private Sub AGroup1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGroup1.Enter

    End Sub
End Class
