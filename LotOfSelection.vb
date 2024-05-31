Public Class LotOfSelection
    Inherits System.Windows.Forms.Form
    Dim Rd As DataSet

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
    Public WithEvents Label1 As System.Windows.Forms.Label
    ' PMXBOCardProd.ABoutton
    'PMXBOCardProd.ABoutton
    Friend WithEvents Selection As System.Windows.Forms.DataGrid
    Friend WithEvents CmdCancel As CButtonLib.CButton
    Friend WithEvents CmdOk As CButtonLib.CButton
    Friend WithEvents FrmMaster_0 As AGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LotOfSelection))
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker2 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker3 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker4 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Me.FrmMaster_0 = New Maquette.AGroup()
        Me.Selection = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdCancel = New CButtonLib.CButton()
        Me.CmdOk = New CButtonLib.CButton()
        Me.FrmMaster_0.SuspendLayout()
        CType(Me.Selection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FrmMaster_0
        '
        Me.FrmMaster_0.BackColorButton = System.Drawing.Color.White
        Me.FrmMaster_0.BackColorLabel = System.Drawing.Color.White
        Me.FrmMaster_0.BorderColor = System.Drawing.Color.DimGray
        Me.FrmMaster_0.Controls.Add(Me.Selection)
        Me.FrmMaster_0.Controls.Add(Me.Label1)
        Me.FrmMaster_0.Controls.Add(Me.CmdCancel)
        Me.FrmMaster_0.Controls.Add(Me.CmdOk)
        Me.FrmMaster_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrmMaster_0.ForeColorLabel = System.Drawing.Color.White
        Me.FrmMaster_0.LargeurGroup = 0
        Me.FrmMaster_0.Location = New System.Drawing.Point(0, 27)
        Me.FrmMaster_0.Name = "FrmMaster_0"
        Me.FrmMaster_0.Size = New System.Drawing.Size(420, 295)
        Me.FrmMaster_0.TabIndex = 22
        Me.FrmMaster_0.TabStop = False
        '
        'Selection
        '
        Me.Selection.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Selection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Selection.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Selection.CaptionForeColor = System.Drawing.Color.White
        Me.Selection.DataMember = ""
        Me.Selection.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Selection.LinkColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Selection.Location = New System.Drawing.Point(38, 43)
        Me.Selection.Name = "Selection"
        Me.Selection.ReadOnly = True
        Me.Selection.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Selection.Size = New System.Drawing.Size(346, 192)
        Me.Selection.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(311, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.CmdCancel.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdCancel.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.CmdCancel.ColorFillBlend = CBlendItems1
        Me.CmdCancel.FocalPoints.CenterPtX = 0.5208333!
        Me.CmdCancel.FocalPoints.CenterPtY = 0.3333333!
        Me.CmdCancel.FocalPoints.FocusPtX = 0.0!
        Me.CmdCancel.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdCancel.FocusPtTracker = DesignerRectTracker2
        Me.CmdCancel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CmdCancel.ImageIndex = 0
        Me.CmdCancel.Location = New System.Drawing.Point(246, 248)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(96, 24)
        Me.CmdCancel.TabIndex = 4
        Me.CmdCancel.Text = "Annuler"
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.Color.Transparent
        Me.CmdOk.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdOk.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.CmdOk.ColorFillBlend = CBlendItems2
        Me.CmdOk.FocalPoints.CenterPtX = 0.59375!
        Me.CmdOk.FocalPoints.CenterPtY = 1.0!
        Me.CmdOk.FocalPoints.FocusPtX = 0.0!
        Me.CmdOk.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CmdOk.FocusPtTracker = DesignerRectTracker4
        Me.CmdOk.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CmdOk.ImageIndex = 0
        Me.CmdOk.Location = New System.Drawing.Point(81, 248)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(96, 24)
        Me.CmdOk.TabIndex = 3
        Me.CmdOk.Text = "OK"
        '
        'LotOfSelection
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(420, 333)
        Me.Controls.Add(Me.FrmMaster_0)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LotOfSelection"
        Me.Text = "Selection"
        Me.TransparencyKey = System.Drawing.Color.OliveDrab
        Me.FrmMaster_0.ResumeLayout(False)
        CType(Me.Selection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LotOfSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Try
            Dim Col1, Col2 As String
            Dim dgt As DataGridTableStyle = New DataGridTableStyle
            Dim dgc As DataGridColumnStyle
            Me.CenterToScreen()
            Col1 = "Code"
            Col2 = "Libellé"



            Select Case NumSelection
                Case 20
                    SQLCode = "select code_district as code,libelle_district as libelle from district " _
                        & " WHERE  code_sprefecture='" & Frmcartep.TXT_CODE_SOUS_PREFECTURE.Text & "'"
                Case 21
                    SQLCode = "select code as code, libelle as libelle from Departement " _
                        & " WHERE  code_institution='" & Frmcartep.TXT_CODE_PREFECTURE.Text & "'"
                Case 22
                    SQLCode = "select code  as code,libelle  as libelle from institution "
                Case 23
                    SQLCode = "select code as code, libelle as libelle from fonction "
            End Select



            'Selection.DataSource = Rd

            Rd = executeGetDataSet(SQLCode)
            'Selection.DataSource = Rd
            'Selection.DataMember = "MyTable"
            'With Me.BindingContext(Rd, "mytable")
            '    Label1.Text = .Count & " Enregistrement(s) Trouvé(s) "
            '    If .Count <= 0 Then
            '        CmdOk.Enabled = False
            '    Else
            '        CmdOk.Enabled = True
            '    End If
            'End With
            Selection.DataSource = Rd
            Selection.DataMember = "MyTable"
            dgc = New DataGridTextBoxColumn
            dgc.MappingName = Rd.Tables(0).Columns(0).ColumnName
            dgc.HeaderText = Col1
            dgc.NullText = " "
            dgc.Width = 140 '60
            dgt.GridColumnStyles.Add(dgc)
            dgt.ReadOnly = True

            If Col2 <> "" Then
                dgc = New DataGridTextBoxColumn
                dgc.MappingName = Rd.Tables(0).Columns(1).ColumnName
                dgc.HeaderText = Col2
                dgc.NullText = " "
                dgc.Width = 100 '200
                dgt.GridColumnStyles.Add(dgc)
                dgt.ReadOnly = True
            End If

            Selection.TableStyles.Clear()
            dgt.MappingName = "MyTable"
            Selection.TableStyles.Add(dgt)
            Selection.ResumeLayout()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Valid_Sel()
        Select Case NumSelection
            Case 20
                Frmcartep.TXT_LIB_DISTRICT.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 1))
                Frmcartep.TXT_CODE_DISTRICT.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 0))
            Case 21
                Frmcartep.TXT_LIB_SOUS_PREFECTURE.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 1))
                Frmcartep.TXT_CODE_SOUS_PREFECTURE.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 0))
                Frmcartep.TXT_CODE_DISTRICT.Text = ""
                Frmcartep.TXT_LIB_DISTRICT.Text = ""
            Case 22
                Frmcartep.TXT_LIB_PREFECTURE.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 1))
                Frmcartep.TXT_CODE_PREFECTURE.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 0))
                Frmcartep.TXT_CODE_SOUS_PREFECTURE.Text = ""
                Frmcartep.TXT_LIB_SOUS_PREFECTURE.Text = ""
                Frmcartep.TXT_CODE_DISTRICT.Text = ""
                Frmcartep.TXT_LIB_DISTRICT.Text = ""
            Case 23
                Frmcartep.TXT_LIB_REGION.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 1))
                Frmcartep.TXT_CODE_REGION.Text = NullOK(Selection.Item(Selection.CurrentCell.RowNumber, 0))
                Frmcartep.TXT_LIB_PREFECTURE.Text = ""
                Frmcartep.TXT_CODE_PREFECTURE.Text = ""
                Frmcartep.TXT_CODE_SOUS_PREFECTURE.Text = ""
                Frmcartep.TXT_LIB_SOUS_PREFECTURE.Text = ""
                Frmcartep.TXT_CODE_DISTRICT.Text = ""
                Frmcartep.TXT_LIB_DISTRICT.Text = ""
        End Select
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Valid_Sel()
    End Sub

    Private Sub Selection_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Selection.DoubleClick
        Valid_Sel()
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
    
End Class
