Public Class ListeDossier
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
    Public WithEvents Nbr_Records As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents liste As System.Windows.Forms.DataGrid
    Friend WithEvents CFermer As CButtonLib.CButton
    Friend WithEvents CAgrandir As CButtonLib.CButton
    Friend WithEvents CReduir As CButtonLib.CButton
    Friend WithEvents CmdOk As CButtonLib.CButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents AGroup1 As Maquette.AGroup
    'MXAUTOPARAM.ABoutton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeDossier))
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
        Me.Nbr_Records = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.liste = New System.Windows.Forms.DataGrid
        Me.CFermer = New CButtonLib.CButton
        Me.CAgrandir = New CButtonLib.CButton
        Me.CReduir = New CButtonLib.CButton
        Me.AGroup1 = New Maquette.AGroup
        Me.CmdOk = New CButtonLib.CButton
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        CType(Me.liste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AGroup1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nbr_Records
        '
        Me.Nbr_Records.BackColor = System.Drawing.Color.White
        Me.Nbr_Records.Cursor = System.Windows.Forms.Cursors.Default
        Me.Nbr_Records.ForeColor = System.Drawing.Color.Black
        Me.Nbr_Records.Location = New System.Drawing.Point(6, 5)
        Me.Nbr_Records.Name = "Nbr_Records"
        Me.Nbr_Records.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Nbr_Records.Size = New System.Drawing.Size(702, 23)
        Me.Nbr_Records.TabIndex = 4
        Me.Nbr_Records.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'liste
        '
        Me.liste.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.liste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.liste.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.liste.CaptionForeColor = System.Drawing.Color.White
        Me.liste.DataMember = ""
        Me.liste.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.liste.Location = New System.Drawing.Point(6, 32)
        Me.liste.Name = "liste"
        Me.liste.ReadOnly = True
        Me.liste.Size = New System.Drawing.Size(702, 212)
        Me.liste.TabIndex = 0
        '
        'CFermer
        '
        Me.CFermer.BackColor = System.Drawing.Color.Transparent
        Me.CFermer.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.CFermer.ColorFillBlend = CBlendItems1
        Me.CFermer.FocalPoints.CenterPtX = 0.0!
        Me.CFermer.FocalPoints.CenterPtY = 0.0!
        Me.CFermer.FocalPoints.FocusPtX = 0.0!
        Me.CFermer.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.FocusPtTracker = DesignerRectTracker2
        Me.CFermer.Image = Global.Maquette.My.Resources.Resources.Fermer
        Me.CFermer.ImageIndex = 0
        Me.CFermer.Location = New System.Drawing.Point(707, 2)
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
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.CAgrandir.ColorFillBlend = CBlendItems2
        Me.CAgrandir.FocalPoints.CenterPtX = 1.0!
        Me.CAgrandir.FocalPoints.CenterPtY = 0.0!
        Me.CAgrandir.FocalPoints.FocusPtX = 0.0!
        Me.CAgrandir.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.FocusPtTracker = DesignerRectTracker4
        Me.CAgrandir.Image = Global.Maquette.My.Resources.Resources.Agrandir
        Me.CAgrandir.ImageIndex = 0
        Me.CAgrandir.Location = New System.Drawing.Point(686, 2)
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
        DesignerRectTracker5.IsActive = True
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems3.iPoint = New Single() {0.0!, 1.0!}
        Me.CReduir.ColorFillBlend = CBlendItems3
        Me.CReduir.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CReduir.FocalPoints.CenterPtX = 0.05882353!
        Me.CReduir.FocalPoints.CenterPtY = 0.4!
        Me.CReduir.FocalPoints.FocusPtX = 0.0!
        Me.CReduir.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.FocusPtTracker = DesignerRectTracker6
        Me.CReduir.ForeColor = System.Drawing.Color.Transparent
        Me.CReduir.Image = Global.Maquette.My.Resources.Resources.Reduire
        Me.CReduir.ImageIndex = 0
        Me.CReduir.Location = New System.Drawing.Point(665, 2)
        Me.CReduir.Name = "CReduir"
        Me.CReduir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CReduir.Size = New System.Drawing.Size(21, 18)
        Me.CReduir.TabIndex = 824
        Me.CReduir.Text = ""
        '
        'AGroup1
        '
        Me.AGroup1.BackColorButton = System.Drawing.Color.White
        Me.AGroup1.BackColorLabel = System.Drawing.Color.White
        Me.AGroup1.BorderColor = System.Drawing.Color.Gray
        Me.AGroup1.Controls.Add(Me.PictureBox4)
        Me.AGroup1.Controls.Add(Me.CmdOk)
        Me.AGroup1.Controls.Add(Me.liste)
        Me.AGroup1.Controls.Add(Me.Nbr_Records)
        Me.AGroup1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.AGroup1.ForeColorLabel = System.Drawing.Color.White
        Me.AGroup1.LargeurGroup = 0
        Me.AGroup1.Location = New System.Drawing.Point(7, 26)
        Me.AGroup1.Name = "AGroup1"
        Me.AGroup1.Size = New System.Drawing.Size(714, 289)
        Me.AGroup1.TabIndex = 827
        Me.AGroup1.TabStop = False
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.Color.Transparent
        Me.CmdOk.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdOk.CenterPtTracker = DesignerRectTracker7
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0.0!, 1.0!}
        Me.CmdOk.ColorFillBlend = CBlendItems4
        Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdOk.FocalPoints.CenterPtX = 0.53125!
        Me.CmdOk.FocalPoints.CenterPtY = 0.3333333!
        Me.CmdOk.FocalPoints.FocusPtX = 0.0!
        Me.CmdOk.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdOk.FocusPtTracker = DesignerRectTracker8
        Me.CmdOk.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CmdOk.ImageIndex = 0
        Me.CmdOk.Location = New System.Drawing.Point(309, 250)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(96, 24)
        Me.CmdOk.TabIndex = 1056
        Me.CmdOk.Text = "OK"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 246)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(121, 40)
        Me.PictureBox4.TabIndex = 1057
        Me.PictureBox4.TabStop = False
        '
        'ListeDossier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(731, 327)
        Me.Controls.Add(Me.AGroup1)
        Me.Controls.Add(Me.CFermer)
        Me.Controls.Add(Me.CAgrandir)
        Me.Controls.Add(Me.CReduir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(6, 85)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListeDossier"
        Me.Text = " Liste des Dossiers : [Gestion PC]"
        CType(Me.liste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AGroup1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim RD As Object
    Dim sShema_D1 As String
    Dim sXML_BD0 As String

    Private Sub ListInit()
        Try
            Dim Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8 As String
            Dim dgt As DataGridTableStyle = New DataGridTableStyle
            Dim dgc As DataGridColumnStyle
            Me.CenterToScreen()

            Col1 = "Numéro"
            Col2 = "Date Dépôt"
            Col3 = "Etat"
            Col4 = "TYPEOPER"
            Col5 = "An Dépôt"
            Col6 = "Agrément"
            Col7 = "Matricule"
            Col8 = "CAP Moniteur"

            SQLCode = "SELECT PCDS_NUMERO,PCDS_DATEDEPOT,PCDS_ETAT,PCDS_TYPEOPER,PCDS_ANDEPOT,PCDS_AGREMENT,PCDS_MATRICULAE,PCDS_CAPMONITOR" _
                 & " FROM GV_PCDOSSIER " _
                  & " WHERE PCDS_NPC =  '" & Frmcartep.TXT_CODE_MENAGE.Text & "'"

            'Selection.DataSource = Rd
            RD = GetDataset(SQLCode)
            'Selection.DataSource = Rd
            'Selection.DataMember = "MyTable"
            With Me.BindingContext(RD, "mytable")
                Nbr_Records.Text = .Count & " Enregistrement(s) Trouvé(s) "
                If .Count <= 0 Then
                    CmdOK.Enabled = False
                Else
                    CmdOK.Enabled = True
                End If
            End With
            liste.DataSource = RD
            liste.DataMember = "MyTable"
            dgc = New DataGridTextBoxColumn
            dgc.MappingName = RD.Tables(0).Columns(0).ColumnName
            dgc.HeaderText = Col1
            dgc.NullText = " "
            dgc.Width = 140 '60
            dgt.GridColumnStyles.Add(dgc)
            If Col2 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = RD.Tables(0).Columns(1).ColumnName
                dgc.HeaderText = Col2
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
            End If
            If Col3 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = RD.Tables(0).Columns(2).ColumnName
                dgc.HeaderText = Col3
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
            End If
            If Col4 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = RD.Tables(0).Columns(3).ColumnName
                dgc.HeaderText = Col4
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
            End If
            If Col5 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = RD.Tables(0).Columns(4).ColumnName
                dgc.HeaderText = Col5
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
            End If
            If Col6 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = RD.Tables(0).Columns(5).ColumnName
                dgc.HeaderText = Col6
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
            End If
            If Col7 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = RD.Tables(0).Columns(6).ColumnName
                dgc.HeaderText = Col7
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
            End If
            If Col8 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = RD.Tables(0).Columns(7).ColumnName
                dgc.HeaderText = Col8
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
            End If

            liste.TableStyles.Clear()
            dgt.MappingName = "MyTable"
            liste.TableStyles.Add(dgt)
            liste.ResumeLayout()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub liste_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles liste.DoubleClick
        Me.Close()
    End Sub

    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ListeDossier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FrmColor(flistedossier)
        ListInit()
        Me.CenterToScreen()
    End Sub

    Private Sub Cmdcancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdOk.Click
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
