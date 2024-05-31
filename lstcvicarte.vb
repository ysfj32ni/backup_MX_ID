Public Class lstcvicarte
    Inherits System.Windows.Forms.Form
    Dim RD As Object
    Dim sShema_D1 As String
    Friend WithEvents AGroup1 As Maquette.AGroup
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdOk As CButtonLib.CButton
    Public WithEvents Nbr_Records As System.Windows.Forms.Label
    Friend WithEvents CFermer As CButtonLib.CButton
    Friend WithEvents CAgrandir As CButtonLib.CButton
    Friend WithEvents CReduir As CButtonLib.CButton
    Friend WithEvents dgvhisto As System.Windows.Forms.DataGridView
    Friend WithEvents libelle_cycle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_operation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents heure_operation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observation As System.Windows.Forms.DataGridViewTextBoxColumn
    Dim sXML_BD0 As String

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
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstcvicarte))
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CFermer = New CButtonLib.CButton()
        Me.CAgrandir = New CButtonLib.CButton()
        Me.CReduir = New CButtonLib.CButton()
        Me.AGroup1 = New Maquette.AGroup()
        Me.dgvhisto = New System.Windows.Forms.DataGridView()
        Me.libelle_cycle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_operation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.heure_operation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CmdOk = New CButtonLib.CButton()
        Me.Nbr_Records = New System.Windows.Forms.Label()
        Me.AGroup1.SuspendLayout()
        CType(Me.dgvhisto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CFermer
        '
        Me.CFermer.BackColor = System.Drawing.Color.Transparent
        Me.CFermer.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.CFermer.ColorFillBlend = CBlendItems1
        Me.CFermer.FocalPoints.CenterPtX = 0!
        Me.CFermer.FocalPoints.CenterPtY = 0!
        Me.CFermer.FocalPoints.FocusPtX = 0!
        Me.CFermer.FocalPoints.FocusPtY = 0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.FocusPtTracker = DesignerRectTracker2
        Me.CFermer.Image = Global.Maquette.My.Resources.Resources.Fermer
        Me.CFermer.ImageIndex = 0
        Me.CFermer.Location = New System.Drawing.Point(709, 0)
        Me.CFermer.Name = "CFermer"
        Me.CFermer.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CFermer.Size = New System.Drawing.Size(21, 18)
        Me.CFermer.TabIndex = 831
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
        CBlendItems2.iPoint = New Single() {0!, 1.0!}
        Me.CAgrandir.ColorFillBlend = CBlendItems2
        Me.CAgrandir.FocalPoints.CenterPtX = 1.0!
        Me.CAgrandir.FocalPoints.CenterPtY = 0!
        Me.CAgrandir.FocalPoints.FocusPtX = 0!
        Me.CAgrandir.FocalPoints.FocusPtY = 0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.FocusPtTracker = DesignerRectTracker4
        Me.CAgrandir.Image = Global.Maquette.My.Resources.Resources.Agrandir
        Me.CAgrandir.ImageIndex = 0
        Me.CAgrandir.Location = New System.Drawing.Point(688, 0)
        Me.CAgrandir.Name = "CAgrandir"
        Me.CAgrandir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CAgrandir.Size = New System.Drawing.Size(21, 18)
        Me.CAgrandir.TabIndex = 830
        Me.CAgrandir.Text = ""
        '
        'CReduir
        '
        Me.CReduir.BackColor = System.Drawing.Color.Transparent
        Me.CReduir.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems3.iPoint = New Single() {0!, 1.0!}
        Me.CReduir.ColorFillBlend = CBlendItems3
        Me.CReduir.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CReduir.FocalPoints.CenterPtX = 0.05882353!
        Me.CReduir.FocalPoints.CenterPtY = 0.4!
        Me.CReduir.FocalPoints.FocusPtX = 0!
        Me.CReduir.FocalPoints.FocusPtY = 0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.FocusPtTracker = DesignerRectTracker6
        Me.CReduir.ForeColor = System.Drawing.Color.Transparent
        Me.CReduir.Image = Global.Maquette.My.Resources.Resources.Reduire
        Me.CReduir.ImageIndex = 0
        Me.CReduir.Location = New System.Drawing.Point(667, 0)
        Me.CReduir.Name = "CReduir"
        Me.CReduir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CReduir.Size = New System.Drawing.Size(21, 18)
        Me.CReduir.TabIndex = 829
        Me.CReduir.Text = ""
        '
        'AGroup1
        '
        Me.AGroup1.BackColorButton = System.Drawing.Color.White
        Me.AGroup1.BackColorLabel = System.Drawing.Color.White
        Me.AGroup1.BorderColor = System.Drawing.Color.Gray
        Me.AGroup1.Controls.Add(Me.dgvhisto)
        Me.AGroup1.Controls.Add(Me.PictureBox4)
        Me.AGroup1.Controls.Add(Me.CmdOk)
        Me.AGroup1.Controls.Add(Me.Nbr_Records)
        Me.AGroup1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.AGroup1.ForeColorLabel = System.Drawing.Color.White
        Me.AGroup1.LargeurGroup = 0
        Me.AGroup1.Location = New System.Drawing.Point(7, 24)
        Me.AGroup1.Name = "AGroup1"
        Me.AGroup1.Size = New System.Drawing.Size(714, 289)
        Me.AGroup1.TabIndex = 828
        Me.AGroup1.TabStop = False
        '
        'dgvhisto
        '
        Me.dgvhisto.AllowUserToAddRows = False
        Me.dgvhisto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhisto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.libelle_cycle, Me.date_operation, Me.heure_operation, Me.observation})
        Me.dgvhisto.Location = New System.Drawing.Point(67, 5)
        Me.dgvhisto.Name = "dgvhisto"
        Me.dgvhisto.Size = New System.Drawing.Size(614, 239)
        Me.dgvhisto.TabIndex = 1058
        '
        'libelle_cycle
        '
        Me.libelle_cycle.DataPropertyName = "CVC_LIBELLE"
        Me.libelle_cycle.HeaderText = "Etat carte"
        Me.libelle_cycle.Name = "libelle_cycle"
        Me.libelle_cycle.ReadOnly = True
        Me.libelle_cycle.Width = 180
        '
        'date_operation
        '
        Me.date_operation.DataPropertyName = "HPR_DATE"
        Me.date_operation.HeaderText = "Date opération"
        Me.date_operation.Name = "date_operation"
        Me.date_operation.ReadOnly = True
        Me.date_operation.Width = 130
        '
        'heure_operation
        '
        Me.heure_operation.DataPropertyName = "HPR_TIME"
        Me.heure_operation.HeaderText = "Heure d'opération"
        Me.heure_operation.Name = "heure_operation"
        Me.heure_operation.ReadOnly = True
        Me.heure_operation.Width = 130
        '
        'observation
        '
        Me.observation.DataPropertyName = "HPR_OBSERVATION"
        Me.observation.HeaderText = "Observation"
        Me.observation.Name = "observation"
        Me.observation.ReadOnly = True
        Me.observation.Width = 130
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 241)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(131, 45)
        Me.PictureBox4.TabIndex = 1057
        Me.PictureBox4.TabStop = False
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.Color.Transparent
        Me.CmdOk.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdOk.CenterPtTracker = DesignerRectTracker7
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0!, 1.0!}
        Me.CmdOk.ColorFillBlend = CBlendItems4
        Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdOk.FocalPoints.CenterPtX = 0.53125!
        Me.CmdOk.FocalPoints.CenterPtY = 0.3333333!
        Me.CmdOk.FocalPoints.FocusPtX = 0!
        Me.CmdOk.FocalPoints.FocusPtY = 0!
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
        'lstcvicarte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(731, 327)
        Me.Controls.Add(Me.CFermer)
        Me.Controls.Add(Me.CAgrandir)
        Me.Controls.Add(Me.CReduir)
        Me.Controls.Add(Me.AGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "lstcvicarte"
        Me.Text = "Cycle Vie Carte : [Gestion PC]"
        Me.AGroup1.ResumeLayout(False)
        CType(Me.dgvhisto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub lstcvicarte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FrmColor(lstcvicart)
        Me.CenterToScreen()
        ListInit()
    End Sub
    Private Sub ListInit()
        Try
            


            SQLCode = "SELECT HPR_ETAT,CVC_LIBELLE,HPR_DATE,HPR_TIME,HPR_OBSERVATION" _
                         & " FROM HISTPERSO,cycvicarte " _
                         & " WHERE HPR_NUMCARTE =  '" & ChaineOK(Frmcartep.TXT_NUMCARTE.Text) & "' " _
                         & " AND hpr_Etat = cvc_code " _
                         & " ORDER BY HPR_DATE ASC ,HPR_TIME ASC"

            Dim dtbl As DataTable = executeGetTable(SQLCode)

            If dtbl Is Nothing Then
                Exit Sub
            End If


            dgvhisto.AutoGenerateColumns = False
            dgvhisto.DataSource = dtbl

           
            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub CmdOk_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdOk.Click
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
