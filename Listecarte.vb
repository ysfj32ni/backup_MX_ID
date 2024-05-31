Public Class Listecarte
    Inherits System.Windows.Forms.Form
    Dim sXML_GLN As String
    Dim sXML_GLN0 As String
    Dim sShema_GLN As String
    Dim sShema_GLN0 As String
    Dim RD As Object
    Friend WithEvents CFermer As CButtonLib.CButton
    Friend WithEvents CAgrandir As CButtonLib.CButton
    Friend WithEvents CReduir As CButtonLib.CButton
    Friend WithEvents Cmdcancel As CButtonLib.CButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Dim ErrSearch As Boolean

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
    Friend WithEvents AGroup6 As Maquette.AGroup
    Friend WithEvents _DBGrid1_1 As System.Windows.Forms.DataGrid
    Public WithEvents Nbr_Records As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listecarte))
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
        Me.AGroup6 = New Maquette.AGroup()
        Me.Cmdcancel = New CButtonLib.CButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me._DBGrid1_1 = New System.Windows.Forms.DataGrid()
        Me.Nbr_Records = New System.Windows.Forms.Label()
        Me.CFermer = New CButtonLib.CButton()
        Me.CAgrandir = New CButtonLib.CButton()
        Me.CReduir = New CButtonLib.CButton()
        Me.AGroup6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DBGrid1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AGroup6
        '
        Me.AGroup6.BackColorButton = System.Drawing.Color.White
        Me.AGroup6.BackColorLabel = System.Drawing.Color.Transparent
        Me.AGroup6.BorderColor = System.Drawing.Color.Gray
        Me.AGroup6.Controls.Add(Me.Cmdcancel)
        Me.AGroup6.Controls.Add(Me.PictureBox4)
        Me.AGroup6.Controls.Add(Me._DBGrid1_1)
        Me.AGroup6.Controls.Add(Me.Nbr_Records)
        Me.AGroup6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGroup6.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AGroup6.LargeurGroup = 0
        Me.AGroup6.Location = New System.Drawing.Point(8, 29)
        Me.AGroup6.Name = "AGroup6"
        Me.AGroup6.Size = New System.Drawing.Size(620, 320)
        Me.AGroup6.TabIndex = 541
        Me.AGroup6.TabStop = False
        '
        'Cmdcancel
        '
        Me.Cmdcancel.BackColor = System.Drawing.Color.Transparent
        Me.Cmdcancel.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Cmdcancel.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.Cmdcancel.ColorFillBlend = CBlendItems1
        Me.Cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmdcancel.FocalPoints.CenterPtX = 0.5416667!
        Me.Cmdcancel.FocalPoints.CenterPtY = 0.4166667!
        Me.Cmdcancel.FocalPoints.FocusPtX = 0!
        Me.Cmdcancel.FocalPoints.FocusPtY = 0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Cmdcancel.FocusPtTracker = DesignerRectTracker2
        Me.Cmdcancel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Cmdcancel.ImageIndex = 0
        Me.Cmdcancel.Location = New System.Drawing.Point(248, 266)
        Me.Cmdcancel.Name = "Cmdcancel"
        Me.Cmdcancel.Size = New System.Drawing.Size(96, 24)
        Me.Cmdcancel.TabIndex = 1055
        Me.Cmdcancel.Text = "OK"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(20, 266)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(131, 48)
        Me.PictureBox4.TabIndex = 1054
        Me.PictureBox4.TabStop = False
        '
        '_DBGrid1_1
        '
        Me._DBGrid1_1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._DBGrid1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._DBGrid1_1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(229, Byte), Integer))
        Me._DBGrid1_1.CaptionText = "Historique Carte"
        Me._DBGrid1_1.DataMember = ""
        Me._DBGrid1_1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me._DBGrid1_1.Location = New System.Drawing.Point(20, 31)
        Me._DBGrid1_1.Name = "_DBGrid1_1"
        Me._DBGrid1_1.ReadOnly = True
        Me._DBGrid1_1.Size = New System.Drawing.Size(578, 224)
        Me._DBGrid1_1.TabIndex = 451
        '
        'Nbr_Records
        '
        Me.Nbr_Records.BackColor = System.Drawing.Color.White
        Me.Nbr_Records.Cursor = System.Windows.Forms.Cursors.Default
        Me.Nbr_Records.ForeColor = System.Drawing.Color.Black
        Me.Nbr_Records.Location = New System.Drawing.Point(3, 5)
        Me.Nbr_Records.Name = "Nbr_Records"
        Me.Nbr_Records.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Nbr_Records.Size = New System.Drawing.Size(693, 23)
        Me.Nbr_Records.TabIndex = 542
        Me.Nbr_Records.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CFermer
        '
        Me.CFermer.BackColor = System.Drawing.Color.Transparent
        Me.CFermer.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems2.iPoint = New Single() {0!, 1.0!}
        Me.CFermer.ColorFillBlend = CBlendItems2
        Me.CFermer.FocalPoints.CenterPtX = 0!
        Me.CFermer.FocalPoints.CenterPtY = 0!
        Me.CFermer.FocalPoints.FocusPtX = 0!
        Me.CFermer.FocalPoints.FocusPtY = 0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.FocusPtTracker = DesignerRectTracker4
        Me.CFermer.Image = Global.Maquette.My.Resources.Resources.Fermer
        Me.CFermer.ImageIndex = 0
        Me.CFermer.Location = New System.Drawing.Point(606, 5)
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
        DesignerRectTracker5.IsActive = True
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems3.iPoint = New Single() {0!, 1.0!}
        Me.CAgrandir.ColorFillBlend = CBlendItems3
        Me.CAgrandir.FocalPoints.CenterPtX = 1.0!
        Me.CAgrandir.FocalPoints.CenterPtY = 0!
        Me.CAgrandir.FocalPoints.FocusPtX = 0!
        Me.CAgrandir.FocalPoints.FocusPtY = 0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.FocusPtTracker = DesignerRectTracker6
        Me.CAgrandir.Image = Global.Maquette.My.Resources.Resources.Agrandir
        Me.CAgrandir.ImageIndex = 0
        Me.CAgrandir.Location = New System.Drawing.Point(585, 5)
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
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.CenterPtTracker = DesignerRectTracker7
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems4.iPoint = New Single() {0!, 1.0!}
        Me.CReduir.ColorFillBlend = CBlendItems4
        Me.CReduir.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CReduir.FocalPoints.CenterPtX = 0.05882353!
        Me.CReduir.FocalPoints.CenterPtY = 0.4!
        Me.CReduir.FocalPoints.FocusPtX = 0!
        Me.CReduir.FocalPoints.FocusPtY = 0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.FocusPtTracker = DesignerRectTracker8
        Me.CReduir.ForeColor = System.Drawing.Color.Transparent
        Me.CReduir.Image = Global.Maquette.My.Resources.Resources.Reduire
        Me.CReduir.ImageIndex = 0
        Me.CReduir.Location = New System.Drawing.Point(564, 5)
        Me.CReduir.Name = "CReduir"
        Me.CReduir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CReduir.Size = New System.Drawing.Size(21, 18)
        Me.CReduir.TabIndex = 824
        Me.CReduir.Text = ""
        '
        'Listecarte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 361)
        Me.Controls.Add(Me.CFermer)
        Me.Controls.Add(Me.CAgrandir)
        Me.Controls.Add(Me.CReduir)
        Me.Controls.Add(Me.AGroup6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Listecarte"
        Me.Text = "Historique Cartes"
        Me.AGroup6.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DBGrid1_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Listecarte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'FrmColor(listecart)
        _DBGrid1_0_Init()
    End Sub
   
    Private Sub _DBGrid1_0_Init()

        Dim ds As DataSet
        Dim dgt As DataGridTableStyle = New DataGridTableStyle
        Dim dgc As DataGridColumnStyle

        sShema_GLN0 = "<?xml version='1.0' encoding='utf-8' ?> "
        sShema_GLN0 = sShema_GLN0 & "<xs:schema id='NewDataSet' xmlns='' xmlns:xs='http://www.w3.org/2001/XMLSchema' xmlns:msdata='urn:schemas-microsoft-com:xml-msdata'>"
        sShema_GLN0 = sShema_GLN0 & "<xs:element name='NewDataSet' msdata:IsDataSet='true' msdata:Locale='fr-FR'>"
        sShema_GLN0 = sShema_GLN0 & "<xs:complexType>"
        sShema_GLN0 = sShema_GLN0 & "<xs:choice maxOccurs='unbounded'>"
        sShema_GLN0 = sShema_GLN0 & "<xs:element name='Table'>"
        sShema_GLN0 = sShema_GLN0 & "<xs:complexType>"
        sShema_GLN0 = sShema_GLN0 & "<xs:sequence>"

        sShema_GLN0 = sShema_GLN0 & "<xs:element name='NUM_CARTE' type='xs:string' minOccurs='0' />"
        sShema_GLN0 = sShema_GLN0 & "<xs:element name='CVC_LIBELLE' type='xs:string' minOccurs='0' />"
        sShema_GLN0 = sShema_GLN0 & "<xs:element name='HPR_DATE' type='xs:string' minOccurs='0' />"
        sShema_GLN0 = sShema_GLN0 & "<xs:element name='HPR_TIME' type='xs:string' minOccurs='0' />"

        sShema_GLN0 = sShema_GLN0 & "</xs:sequence>"
        sShema_GLN0 = sShema_GLN0 & "</xs:complexType>"
        sShema_GLN0 = sShema_GLN0 & "</xs:element>"
        sShema_GLN0 = sShema_GLN0 & "</xs:choice>"
        sShema_GLN0 = sShema_GLN0 & "</xs:complexType>"
        sShema_GLN0 = sShema_GLN0 & "</xs:element>"
        sShema_GLN0 = sShema_GLN0 & "</xs:schema>"

        SQLCode = "select crt.NUM_CARTE,c.CVC_LIBELLE,HPR_DATE,HPR_TIME from carte as crt,HISTPERSO as h, CYCVICARTE as c " _
                              & " where crt.ETAT_PRD= c.CVC_CODE and crt.NUM_CARTE = h.HPR_NUMCARTE " _
                              & " AND CODE_ENROLEMENT  =  '" & ChaineOK(Frmcartep.TXT_CODE_MENAGE.Text) & "' order by h.HPR_DATE desc"

        sError = ""

        RD = executeGetDataSet(SQLCode)
        With Me.BindingContext(RD, "mytable")
            Nbr_Records.Text = .Count & " Enregistrement(s) Trouvé(s) "
            If .Count <= 0 Then
                CmdCancel.Enabled = False
            Else
                CmdCancel.Enabled = True
            End If
        End With

        _DBGrid1_1.DataSource = RD
        _DBGrid1_1.DataMember = "MyTable"

        dgc = New DataGridTextBoxColumn
        dgc.MappingName = RD.Tables(0).Columns(0).ColumnName
        dgc.HeaderText = "N° Carte"  'MLangue("1923") '"Comment" 'RD.Tables(0).Columns(1).ColumnName.ToString() 'MLangue("0172")
        dgc.Width = 120
        dgc.NullText = ""
        dgt.GridColumnStyles.Add(dgc)

        dgc = New DataGridTextBoxColumn
        dgc.MappingName = RD.Tables(0).Columns(1).ColumnName
        dgc.HeaderText = "Etat"  'MLangue("1923") '"Comment" 'RD.Tables(0).Columns(1).ColumnName.ToString() 'MLangue("0172")
        dgc.Width = 120
        dgc.NullText = ""
        dgt.GridColumnStyles.Add(dgc)

        dgc = New DataGridTextBoxColumn
        dgc.MappingName = RD.Tables(0).Columns(2).ColumnName
        dgc.HeaderText = "Date" '"Wording" 'RD.Tables(0).Columns(1).ColumnName.ToString() 'MLangue("0172")
        dgc.Width = 120
        dgc.NullText = ""
        dgt.GridColumnStyles.Add(dgc)

        dgc = New DataGridTextBoxColumn
        dgc.MappingName = RD.Tables(0).Columns(3).ColumnName
        dgc.HeaderText = "Heure" '"Commentaire" 'RD.Tables(0).Columns(1).ColumnName.ToString() 'MLangue("0172")
        dgc.Width = 120
        dgc.NullText = ""
        dgt.GridColumnStyles.Add(dgc)









        _DBGrid1_1.TableStyles.Clear()
        dgt.MappingName = "MyTable"
        _DBGrid1_1.TableStyles.Add(dgt)
        _DBGrid1_1.ResumeLayout()

    End Sub
    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Listecarte_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub CmdOK_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Cmdcancel.ClickButtonArea
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

    Private Sub CReduir_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CReduir.ClickButtonArea

    End Sub
End Class
