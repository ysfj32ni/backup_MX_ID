Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Frmcartepermis
    Inherits System.Windows.Forms.Form
    Public frmform1 As Form
    Public frmform2 As Form
    Dim page = 0
    Public WithEvents tooltip1 As System.Windows.Forms.ToolTip
    Friend WithEvents informationdossier As System.Windows.Forms.ToolTip
    Dim Dcarte As DataTable
    Dim Ddossier As Object
    Dim DpermisEnrolment As DataTable
    Dim nais As Boolean
    Dim TempoRec As DataTable
    Dim Dcin As Object
    Dim Etat As Byte
    Dim RecCount As Short
    Dim codecyt As String
    Dim file1 As Object
    
    Dim sXML_BD0 As String
    Dim sShema_D2A As String
    Dim sShema_D1 As String
    Dim I As Byte
    Dim RD As DataSet
    Dim EtatTools As Boolean
    Dim xp As Double
    Dim yp As Double
    Dim PreviousTab As Short
    Dim Chr_Code As String
    Dim ErrSearch As Boolean
    Public Chaine As String


    Dim DataGrid(1) As System.Windows.Forms.DataGrid
    Friend WithEvents CFermer As CButtonLib.CButton
    Friend WithEvents CAgrandir As CButtonLib.CButton
    Friend WithEvents CReduir As CButtonLib.CButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents dateoper As System.Windows.Forms.Label
    Friend WithEvents timeoper As System.Windows.Forms.Label
    Friend WithEvents enregistrement As System.Windows.Forms.Label
    Friend WithEvents operation1 As System.Windows.Forms.Label
    Public WithEvents Label169 As System.Windows.Forms.Label
    Friend WithEvents Bn3 As CButtonLib.CButton
    Friend WithEvents Pn3 As System.Windows.Forms.Panel
    Friend WithEvents _FrmSaisie_3 As Maquette.AGroup
    Public WithEvents TXT_DET_CODEENROLEMENT As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListDossierOK As CButtonLib.CButton
    Dim FrmSaisie(8) As Maquette.AGroup
    Friend WithEvents Bn4 As CButtonLib.CButton
    Friend WithEvents BTN_SOUS_PREFECTURE As System.Windows.Forms.Button
    Friend WithEvents BTN_PREFECTURE As System.Windows.Forms.Button
    Friend WithEvents BTN_REGION As System.Windows.Forms.Button
    Public WithEvents TXT_LIB_SOUS_PREFECTURE As System.Windows.Forms.TextBox
    Public WithEvents TXT_LIB_PREFECTURE As System.Windows.Forms.TextBox
    Public WithEvents TXT_CODE_SOUS_PREFECTURE As System.Windows.Forms.TextBox
    Public WithEvents TXT_CODE_PREFECTURE As System.Windows.Forms.TextBox
    Public WithEvents TXT_LIB_REGION As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents TXT_CODE_REGION As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_7 As System.Windows.Forms.TextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_6 As System.Windows.Forms.TextBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_5 As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_4 As System.Windows.Forms.TextBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_3 As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_2 As System.Windows.Forms.TextBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_1 As System.Windows.Forms.TextBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents TXT_GEO_2 As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents TXT_GEO_1 As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_10 As System.Windows.Forms.TextBox
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_9 As System.Windows.Forms.TextBox
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents TXT_NOTE_8 As System.Windows.Forms.TextBox
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents TXT_CODEMEMBRE As System.Windows.Forms.TextBox
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents grpTypeMenage As Maquette.AGroup
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents rdbx_P As System.Windows.Forms.RadioButton
    Public WithEvents rdbx_S As System.Windows.Forms.RadioButton
    Friend WithEvents Panel6 As Panel
    Public WithEvents TextBox2 As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents TextBox1 As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents TXT_CIN As TextBox
    Public WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Dim IndexRow As Integer

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
    'System.Windows.Forms.GroupBox
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Toolsb13 As System.Windows.Forms.Button
    Friend WithEvents ToolsB8 As System.Windows.Forms.Button
    Friend WithEvents ToolsB9 As System.Windows.Forms.Button
    Friend WithEvents ToolsB10 As System.Windows.Forms.Button
    Friend WithEvents ToolsB7 As System.Windows.Forms.Button
    Friend WithEvents ToolsB4 As System.Windows.Forms.Button
    Friend WithEvents ToolsB3 As System.Windows.Forms.Button
    Friend WithEvents ToolsB2 As System.Windows.Forms.Button
    Friend WithEvents ToolsB11 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents FrmMaster As Maquette.AGroup
    Public WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents grpSexe As Maquette.AGroup
    Public WithEvents Label65 As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents rdbx_F As System.Windows.Forms.RadioButton
    Public WithEvents rdbx_M As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SelectDet_2 As System.Windows.Forms.Button
    Public WithEvents TXT_LIB_DISTRICT As System.Windows.Forms.TextBox
    Public WithEvents TXT_CODE_DISTRICT As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TXT_CODE_MENAGE As System.Windows.Forms.TextBox
    Friend WithEvents DT_DATNAISS As System.Windows.Forms.DateTimePicker
    Public WithEvents TXT_NOM As System.Windows.Forms.TextBox
    Public WithEvents TXT_PRENOM As System.Windows.Forms.TextBox
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents _Labels_1 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _Labels_99 As System.Windows.Forms.Label
    Friend WithEvents Pn4 As System.Windows.Forms.Panel
    Friend WithEvents _FrmSaisie_5 As Maquette.AGroup
    Public WithEvents Button14 As System.Windows.Forms.Button
    Public WithEvents TXT_CODPROFIL0 As System.Windows.Forms.TextBox
    Public WithEvents TXT_CODPROFIL As System.Windows.Forms.TextBox
    Public WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents AGroup24 As Maquette.AGroup
    Public WithEvents TXT_NumLot As System.Windows.Forms.TextBox
    Public WithEvents _Labels_40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Public WithEvents Label109 As System.Windows.Forms.Label
    Public WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AGroup25 As Maquette.AGroup
    Public WithEvents TXT_ETATPRD As System.Windows.Forms.TextBox
    Public WithEvents Label126 As System.Windows.Forms.Label
    Public WithEvents TXT_ETAT As System.Windows.Forms.TextBox
    Public WithEvents Label133 As System.Windows.Forms.Label
    Public WithEvents TXT_TYPECARTE As System.Windows.Forms.TextBox
    Public WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents Label135 As System.Windows.Forms.Label
    Public WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker22 As System.Windows.Forms.DateTimePicker
    Public WithEvents TXT_NUMCARTE As System.Windows.Forms.TextBox
    Public WithEvents Cmdnumcart As System.Windows.Forms.Button
    Public WithEvents Button24 As System.Windows.Forms.Button
    Public WithEvents TXT_CODINST0 As System.Windows.Forms.TextBox
    Public WithEvents TXT_CODINST As System.Windows.Forms.TextBox
    Public WithEvents Label102 As System.Windows.Forms.Label
    Public WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents CYC_carte As CButtonLib.CButton
    Public WithEvents Button22 As CButtonLib.CButton
    Friend WithEvents Button23 As CButtonLib.CButton
    Public WithEvents Label131 As System.Windows.Forms.Label
    Public WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents DT_DATMES As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_DATCRT As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_activation As CButtonLib.CButton
    Public WithEvents TextBox69 As System.Windows.Forms.TextBox
    Public WithEvents TextBox81 As System.Windows.Forms.TextBox
    Public WithEvents Label127 As System.Windows.Forms.Label
    Public WithEvents Label128 As System.Windows.Forms.Label
    Public WithEvents TextBox82 As System.Windows.Forms.TextBox
    Public WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker29 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents AGroup30 As Maquette.AGroup
    Public WithEvents TextBox88 As System.Windows.Forms.TextBox
    Public WithEvents Label141 As System.Windows.Forms.Label
    Public WithEvents TextBox89 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Public WithEvents Label142 As System.Windows.Forms.Label
    Public WithEvents Label143 As System.Windows.Forms.Label
    Public WithEvents TextBox90 As System.Windows.Forms.TextBox
    Public WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker30 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents AGroup31 As Maquette.AGroup
    Public WithEvents TextBox91 As System.Windows.Forms.TextBox
    Public WithEvents Label146 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker31 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents AGroup32 As Maquette.AGroup
    Public WithEvents TextBox92 As System.Windows.Forms.TextBox
    Public WithEvents TextBox93 As System.Windows.Forms.TextBox
    Public WithEvents Label148 As System.Windows.Forms.Label
    Public WithEvents Label149 As System.Windows.Forms.Label
    Public WithEvents TextBox94 As System.Windows.Forms.TextBox
    Public WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker32 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents AGroup34 As Maquette.AGroup
    Public WithEvents TextBox20 As System.Windows.Forms.TextBox
    Public WithEvents TextBox95 As System.Windows.Forms.TextBox
    Public WithEvents Label152 As System.Windows.Forms.Label
    Public WithEvents Label153 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Public WithEvents TextBox96 As System.Windows.Forms.TextBox
    Public WithEvents Label154 As System.Windows.Forms.Label
    Public WithEvents Label155 As System.Windows.Forms.Label
    Public WithEvents TextBox97 As System.Windows.Forms.TextBox
    Public WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker33 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label157 As System.Windows.Forms.Label
    Friend WithEvents AGroup35 As Maquette.AGroup
    Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel4 As System.Windows.Forms.StatusBarPanel
    Public WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Public WithEvents MOpertations As System.Windows.Forms.MenuItem
    Public WithEvents MSearch As System.Windows.Forms.MenuItem
    Public WithEvents Separt As System.Windows.Forms.MenuItem
    Public WithEvents MValidate As System.Windows.Forms.MenuItem
    Public WithEvents MCancel As System.Windows.Forms.MenuItem
    Public WithEvents MRecords As System.Windows.Forms.MenuItem
    Public WithEvents MFirst As System.Windows.Forms.MenuItem
    Public WithEvents MPrevious As System.Windows.Forms.MenuItem
    Public WithEvents MNext As System.Windows.Forms.MenuItem
    Public WithEvents MLast As System.Windows.Forms.MenuItem
    Public WithEvents MClose1 As System.Windows.Forms.MenuItem
    Public WithEvents MClose As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcartepermis))
        Dim DesignerRectTracker7 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker8 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker9 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker10 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker11 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker12 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker15 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker16 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker17 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems9 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker18 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker21 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems11 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker22 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker1 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker2 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker3 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker4 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker5 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker6 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim DesignerRectTracker19 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Dim CBlendItems10 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim DesignerRectTracker20 As CButtonLib.DesignerRectTracker = New CButtonLib.DesignerRectTracker()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox81 = New System.Windows.Forms.TextBox()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.TextBox82 = New System.Windows.Forms.TextBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.DateTimePicker29 = New System.Windows.Forms.DateTimePicker()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.TextBox88 = New System.Windows.Forms.TextBox()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.TextBox89 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.TextBox90 = New System.Windows.Forms.TextBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.DateTimePicker30 = New System.Windows.Forms.DateTimePicker()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.TextBox91 = New System.Windows.Forms.TextBox()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.DateTimePicker31 = New System.Windows.Forms.DateTimePicker()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.TextBox92 = New System.Windows.Forms.TextBox()
        Me.TextBox93 = New System.Windows.Forms.TextBox()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.TextBox94 = New System.Windows.Forms.TextBox()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.DateTimePicker32 = New System.Windows.Forms.DateTimePicker()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox95 = New System.Windows.Forms.TextBox()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox96 = New System.Windows.Forms.TextBox()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.TextBox97 = New System.Windows.Forms.TextBox()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.DateTimePicker33 = New System.Windows.Forms.DateTimePicker()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.StatusBar = New System.Windows.Forms.StatusBar()
        Me.Panel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel2 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel3 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel4 = New System.Windows.Forms.StatusBarPanel()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MOpertations = New System.Windows.Forms.MenuItem()
        Me.MSearch = New System.Windows.Forms.MenuItem()
        Me.Separt = New System.Windows.Forms.MenuItem()
        Me.MValidate = New System.Windows.Forms.MenuItem()
        Me.MCancel = New System.Windows.Forms.MenuItem()
        Me.MRecords = New System.Windows.Forms.MenuItem()
        Me.MFirst = New System.Windows.Forms.MenuItem()
        Me.MPrevious = New System.Windows.Forms.MenuItem()
        Me.MNext = New System.Windows.Forms.MenuItem()
        Me.MLast = New System.Windows.Forms.MenuItem()
        Me.MClose1 = New System.Windows.Forms.MenuItem()
        Me.MClose = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Toolsb13 = New System.Windows.Forms.Button()
        Me.ToolsB8 = New System.Windows.Forms.Button()
        Me.ToolsB9 = New System.Windows.Forms.Button()
        Me.ToolsB10 = New System.Windows.Forms.Button()
        Me.ToolsB7 = New System.Windows.Forms.Button()
        Me.ToolsB4 = New System.Windows.Forms.Button()
        Me.ToolsB3 = New System.Windows.Forms.Button()
        Me.ToolsB2 = New System.Windows.Forms.Button()
        Me.ToolsB11 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Pn4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Bn4 = New CButtonLib.CButton()
        Me.Bn3 = New CButtonLib.CButton()
        Me.Pn3 = New System.Windows.Forms.Panel()
        Me.CFermer = New CButtonLib.CButton()
        Me.CAgrandir = New CButtonLib.CButton()
        Me.CReduir = New CButtonLib.CButton()
        Me.dateoper = New System.Windows.Forms.Label()
        Me.timeoper = New System.Windows.Forms.Label()
        Me.enregistrement = New System.Windows.Forms.Label()
        Me.operation1 = New System.Windows.Forms.Label()
        Me.Label169 = New System.Windows.Forms.Label()
        Me._FrmSaisie_5 = New Maquette.AGroup()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.TXT_CODPROFIL0 = New System.Windows.Forms.TextBox()
        Me.TXT_CODPROFIL = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.AGroup24 = New Maquette.AGroup()
        Me.TXT_NumLot = New System.Windows.Forms.TextBox()
        Me._Labels_40 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.DateTimePicker12 = New System.Windows.Forms.DateTimePicker()
        Me.AGroup25 = New Maquette.AGroup()
        Me.TXT_ETATPRD = New System.Windows.Forms.TextBox()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.TXT_ETAT = New System.Windows.Forms.TextBox()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.TXT_TYPECARTE = New System.Windows.Forms.TextBox()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.DateTimePicker22 = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NUMCARTE = New System.Windows.Forms.TextBox()
        Me.Cmdnumcart = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.TXT_CODINST0 = New System.Windows.Forms.TextBox()
        Me.TXT_CODINST = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.btn_activation = New CButtonLib.CButton()
        Me.CYC_carte = New CButtonLib.CButton()
        Me.Button22 = New CButtonLib.CButton()
        Me.Button23 = New CButtonLib.CButton()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.DT_DATMES = New System.Windows.Forms.DateTimePicker()
        Me.DT_DATCRT = New System.Windows.Forms.DateTimePicker()
        Me.FrmMaster = New Maquette.AGroup()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BTN_SOUS_PREFECTURE = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BTN_PREFECTURE = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_REGION = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_LIB_SOUS_PREFECTURE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_LIB_PREFECTURE = New System.Windows.Forms.TextBox()
        Me.TXT_CODE_REGION = New System.Windows.Forms.TextBox()
        Me.TXT_CODE_SOUS_PREFECTURE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_CODE_PREFECTURE = New System.Windows.Forms.TextBox()
        Me.TXT_LIB_REGION = New System.Windows.Forms.TextBox()
        Me.TXT_CIN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.grpSexe = New Maquette.AGroup()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.rdbx_F = New System.Windows.Forms.RadioButton()
        Me.rdbx_M = New System.Windows.Forms.RadioButton()
        Me.SelectDet_2 = New System.Windows.Forms.Button()
        Me.TXT_LIB_DISTRICT = New System.Windows.Forms.TextBox()
        Me.TXT_CODE_DISTRICT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CODE_MENAGE = New System.Windows.Forms.TextBox()
        Me.DT_DATNAISS = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.TXT_PRENOM = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me._Labels_1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Labels_99 = New System.Windows.Forms.Label()
        Me._FrmSaisie_3 = New Maquette.AGroup()
        Me.TXT_CODEMEMBRE = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.grpTypeMenage = New Maquette.AGroup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.rdbx_P = New System.Windows.Forms.RadioButton()
        Me.rdbx_S = New System.Windows.Forms.RadioButton()
        Me.TXT_GEO_2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_GEO_1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_10 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_9 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_8 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_7 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_6 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_5 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_4 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_3 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXT_DET_CODEENROLEMENT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListDossierOK = New CButtonLib.CButton()
        Me.AGroup30 = New Maquette.AGroup()
        Me.AGroup31 = New Maquette.AGroup()
        Me.AGroup32 = New Maquette.AGroup()
        Me.AGroup34 = New Maquette.AGroup()
        Me.AGroup35 = New Maquette.AGroup()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Pn4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn3.SuspendLayout()
        Me._FrmSaisie_5.SuspendLayout()
        Me.AGroup24.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.AGroup25.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.FrmMaster.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSexe.SuspendLayout()
        Me._FrmSaisie_3.SuspendLayout()
        Me.grpTypeMenage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox69
        '
        Me.TextBox69.AcceptsReturn = True
        Me.TextBox69.BackColor = System.Drawing.Color.White
        Me.TextBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox69.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox69.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox69.ForeColor = System.Drawing.Color.Black
        Me.TextBox69.Location = New System.Drawing.Point(384, 56)
        Me.TextBox69.MaxLength = 12
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox69.Size = New System.Drawing.Size(128, 21)
        Me.TextBox69.TabIndex = 377
        '
        'TextBox81
        '
        Me.TextBox81.AcceptsReturn = True
        Me.TextBox81.BackColor = System.Drawing.Color.White
        Me.TextBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox81.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox81.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox81.ForeColor = System.Drawing.Color.Black
        Me.TextBox81.Location = New System.Drawing.Point(344, 32)
        Me.TextBox81.MaxLength = 12
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox81.Size = New System.Drawing.Size(168, 21)
        Me.TextBox81.TabIndex = 376
        '
        'Label127
        '
        Me.Label127.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label127.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label127.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label127.ForeColor = System.Drawing.Color.Black
        Me.Label127.Location = New System.Drawing.Point(280, 56)
        Me.Label127.Name = "Label127"
        Me.Label127.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label127.Size = New System.Drawing.Size(88, 16)
        Me.Label127.TabIndex = 375
        Me.Label127.Tag = "0629"
        Me.Label127.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label128
        '
        Me.Label128.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label128.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label128.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label128.ForeColor = System.Drawing.Color.Black
        Me.Label128.Location = New System.Drawing.Point(240, 32)
        Me.Label128.Name = "Label128"
        Me.Label128.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label128.Size = New System.Drawing.Size(88, 16)
        Me.Label128.TabIndex = 374
        Me.Label128.Tag = "0629"
        Me.Label128.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox82
        '
        Me.TextBox82.AcceptsReturn = True
        Me.TextBox82.BackColor = System.Drawing.Color.White
        Me.TextBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox82.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox82.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox82.ForeColor = System.Drawing.Color.Black
        Me.TextBox82.Location = New System.Drawing.Point(96, 56)
        Me.TextBox82.MaxLength = 12
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox82.Size = New System.Drawing.Size(160, 21)
        Me.TextBox82.TabIndex = 369
        '
        'Label129
        '
        Me.Label129.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label129.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label129.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label129.ForeColor = System.Drawing.Color.Black
        Me.Label129.Location = New System.Drawing.Point(16, 56)
        Me.Label129.Name = "Label129"
        Me.Label129.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label129.Size = New System.Drawing.Size(64, 16)
        Me.Label129.TabIndex = 356
        Me.Label129.Tag = "0629"
        Me.Label129.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker29
        '
        Me.DateTimePicker29.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DateTimePicker29.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker29.Location = New System.Drawing.Point(96, 32)
        Me.DateTimePicker29.Name = "DateTimePicker29"
        Me.DateTimePicker29.ShowCheckBox = True
        Me.DateTimePicker29.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker29.TabIndex = 368
        Me.DateTimePicker29.Value = New Date(2007, 3, 16, 15, 46, 20, 624)
        '
        'Label130
        '
        Me.Label130.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label130.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label130.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label130.ForeColor = System.Drawing.Color.Black
        Me.Label130.Location = New System.Drawing.Point(16, 32)
        Me.Label130.Name = "Label130"
        Me.Label130.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label130.Size = New System.Drawing.Size(64, 16)
        Me.Label130.TabIndex = 355
        Me.Label130.Tag = "0629"
        Me.Label130.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox88
        '
        Me.TextBox88.AcceptsReturn = True
        Me.TextBox88.BackColor = System.Drawing.Color.White
        Me.TextBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox88.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox88.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox88.ForeColor = System.Drawing.Color.Black
        Me.TextBox88.Location = New System.Drawing.Point(320, 32)
        Me.TextBox88.MaxLength = 12
        Me.TextBox88.Name = "TextBox88"
        Me.TextBox88.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox88.Size = New System.Drawing.Size(128, 21)
        Me.TextBox88.TabIndex = 379
        '
        'Label141
        '
        Me.Label141.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label141.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label141.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label141.ForeColor = System.Drawing.Color.Black
        Me.Label141.Location = New System.Drawing.Point(24, 80)
        Me.Label141.Name = "Label141"
        Me.Label141.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label141.Size = New System.Drawing.Size(64, 16)
        Me.Label141.TabIndex = 378
        Me.Label141.Tag = "0629"
        Me.Label141.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox89
        '
        Me.TextBox89.AcceptsReturn = True
        Me.TextBox89.BackColor = System.Drawing.Color.White
        Me.TextBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox89.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox89.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox89.ForeColor = System.Drawing.Color.Black
        Me.TextBox89.Location = New System.Drawing.Point(320, 56)
        Me.TextBox89.MaxLength = 12
        Me.TextBox89.Name = "TextBox89"
        Me.TextBox89.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox89.Size = New System.Drawing.Size(128, 21)
        Me.TextBox89.TabIndex = 377
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(104, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox1.TabIndex = 376
        '
        'Label142
        '
        Me.Label142.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label142.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label142.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label142.ForeColor = System.Drawing.Color.Black
        Me.Label142.Location = New System.Drawing.Point(224, 56)
        Me.Label142.Name = "Label142"
        Me.Label142.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label142.Size = New System.Drawing.Size(88, 16)
        Me.Label142.TabIndex = 375
        Me.Label142.Tag = "0629"
        Me.Label142.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label143
        '
        Me.Label143.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label143.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label143.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label143.ForeColor = System.Drawing.Color.Black
        Me.Label143.Location = New System.Drawing.Point(232, 32)
        Me.Label143.Name = "Label143"
        Me.Label143.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label143.Size = New System.Drawing.Size(80, 16)
        Me.Label143.TabIndex = 374
        Me.Label143.Tag = "0629"
        Me.Label143.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox90
        '
        Me.TextBox90.AcceptsReturn = True
        Me.TextBox90.BackColor = System.Drawing.Color.White
        Me.TextBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox90.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox90.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox90.ForeColor = System.Drawing.Color.Black
        Me.TextBox90.Location = New System.Drawing.Point(104, 56)
        Me.TextBox90.MaxLength = 12
        Me.TextBox90.Name = "TextBox90"
        Me.TextBox90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox90.Size = New System.Drawing.Size(120, 21)
        Me.TextBox90.TabIndex = 369
        '
        'Label144
        '
        Me.Label144.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label144.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label144.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label144.ForeColor = System.Drawing.Color.Black
        Me.Label144.Location = New System.Drawing.Point(24, 56)
        Me.Label144.Name = "Label144"
        Me.Label144.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label144.Size = New System.Drawing.Size(64, 16)
        Me.Label144.TabIndex = 356
        Me.Label144.Tag = "0629"
        Me.Label144.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker30
        '
        Me.DateTimePicker30.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DateTimePicker30.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker30.Location = New System.Drawing.Point(104, 32)
        Me.DateTimePicker30.Name = "DateTimePicker30"
        Me.DateTimePicker30.ShowCheckBox = True
        Me.DateTimePicker30.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker30.TabIndex = 368
        Me.DateTimePicker30.Value = New Date(2007, 3, 16, 15, 46, 21, 109)
        '
        'Label145
        '
        Me.Label145.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label145.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label145.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label145.ForeColor = System.Drawing.Color.Black
        Me.Label145.Location = New System.Drawing.Point(24, 32)
        Me.Label145.Name = "Label145"
        Me.Label145.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label145.Size = New System.Drawing.Size(64, 16)
        Me.Label145.TabIndex = 355
        Me.Label145.Tag = "0629"
        Me.Label145.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox91
        '
        Me.TextBox91.AcceptsReturn = True
        Me.TextBox91.BackColor = System.Drawing.Color.White
        Me.TextBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox91.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox91.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox91.ForeColor = System.Drawing.Color.Black
        Me.TextBox91.Location = New System.Drawing.Point(96, 56)
        Me.TextBox91.MaxLength = 12
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox91.Size = New System.Drawing.Size(224, 21)
        Me.TextBox91.TabIndex = 369
        '
        'Label146
        '
        Me.Label146.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label146.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label146.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label146.ForeColor = System.Drawing.Color.Black
        Me.Label146.Location = New System.Drawing.Point(16, 64)
        Me.Label146.Name = "Label146"
        Me.Label146.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label146.Size = New System.Drawing.Size(64, 16)
        Me.Label146.TabIndex = 356
        Me.Label146.Tag = "0629"
        Me.Label146.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker31
        '
        Me.DateTimePicker31.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DateTimePicker31.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker31.Location = New System.Drawing.Point(96, 32)
        Me.DateTimePicker31.Name = "DateTimePicker31"
        Me.DateTimePicker31.ShowCheckBox = True
        Me.DateTimePicker31.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker31.TabIndex = 368
        Me.DateTimePicker31.Value = New Date(2007, 3, 16, 15, 46, 21, 265)
        '
        'Label147
        '
        Me.Label147.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label147.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label147.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label147.ForeColor = System.Drawing.Color.Black
        Me.Label147.Location = New System.Drawing.Point(16, 32)
        Me.Label147.Name = "Label147"
        Me.Label147.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label147.Size = New System.Drawing.Size(64, 16)
        Me.Label147.TabIndex = 355
        Me.Label147.Tag = "0629"
        Me.Label147.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox92
        '
        Me.TextBox92.AcceptsReturn = True
        Me.TextBox92.BackColor = System.Drawing.Color.White
        Me.TextBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox92.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox92.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox92.ForeColor = System.Drawing.Color.Black
        Me.TextBox92.Location = New System.Drawing.Point(360, 56)
        Me.TextBox92.MaxLength = 12
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox92.Size = New System.Drawing.Size(128, 21)
        Me.TextBox92.TabIndex = 373
        '
        'TextBox93
        '
        Me.TextBox93.AcceptsReturn = True
        Me.TextBox93.BackColor = System.Drawing.Color.White
        Me.TextBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox93.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox93.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox93.ForeColor = System.Drawing.Color.Black
        Me.TextBox93.Location = New System.Drawing.Point(320, 32)
        Me.TextBox93.MaxLength = 12
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox93.Size = New System.Drawing.Size(168, 21)
        Me.TextBox93.TabIndex = 372
        '
        'Label148
        '
        Me.Label148.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label148.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label148.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label148.ForeColor = System.Drawing.Color.Black
        Me.Label148.Location = New System.Drawing.Point(256, 56)
        Me.Label148.Name = "Label148"
        Me.Label148.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label148.Size = New System.Drawing.Size(88, 16)
        Me.Label148.TabIndex = 371
        Me.Label148.Tag = "0629"
        Me.Label148.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label149
        '
        Me.Label149.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label149.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label149.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label149.ForeColor = System.Drawing.Color.Black
        Me.Label149.Location = New System.Drawing.Point(216, 32)
        Me.Label149.Name = "Label149"
        Me.Label149.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label149.Size = New System.Drawing.Size(88, 16)
        Me.Label149.TabIndex = 370
        Me.Label149.Tag = "0629"
        Me.Label149.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox94
        '
        Me.TextBox94.AcceptsReturn = True
        Me.TextBox94.BackColor = System.Drawing.Color.White
        Me.TextBox94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox94.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox94.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox94.ForeColor = System.Drawing.Color.Black
        Me.TextBox94.Location = New System.Drawing.Point(96, 56)
        Me.TextBox94.MaxLength = 12
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox94.Size = New System.Drawing.Size(152, 21)
        Me.TextBox94.TabIndex = 369
        '
        'Label150
        '
        Me.Label150.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label150.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label150.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label150.ForeColor = System.Drawing.Color.Black
        Me.Label150.Location = New System.Drawing.Point(24, 56)
        Me.Label150.Name = "Label150"
        Me.Label150.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label150.Size = New System.Drawing.Size(64, 16)
        Me.Label150.TabIndex = 356
        Me.Label150.Tag = "0629"
        Me.Label150.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker32
        '
        Me.DateTimePicker32.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DateTimePicker32.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker32.Location = New System.Drawing.Point(96, 32)
        Me.DateTimePicker32.Name = "DateTimePicker32"
        Me.DateTimePicker32.ShowCheckBox = True
        Me.DateTimePicker32.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker32.TabIndex = 368
        Me.DateTimePicker32.Value = New Date(2007, 3, 16, 15, 46, 21, 593)
        '
        'Label151
        '
        Me.Label151.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label151.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label151.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label151.ForeColor = System.Drawing.Color.Black
        Me.Label151.Location = New System.Drawing.Point(24, 32)
        Me.Label151.Name = "Label151"
        Me.Label151.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label151.Size = New System.Drawing.Size(64, 16)
        Me.Label151.TabIndex = 355
        Me.Label151.Tag = "0629"
        Me.Label151.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox20
        '
        Me.TextBox20.AcceptsReturn = True
        Me.TextBox20.BackColor = System.Drawing.Color.White
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.ForeColor = System.Drawing.Color.Black
        Me.TextBox20.Location = New System.Drawing.Point(328, 32)
        Me.TextBox20.MaxLength = 12
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox20.Size = New System.Drawing.Size(128, 21)
        Me.TextBox20.TabIndex = 383
        '
        'TextBox95
        '
        Me.TextBox95.AcceptsReturn = True
        Me.TextBox95.BackColor = System.Drawing.Color.White
        Me.TextBox95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox95.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox95.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox95.ForeColor = System.Drawing.Color.Black
        Me.TextBox95.Location = New System.Drawing.Point(328, 80)
        Me.TextBox95.MaxLength = 12
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox95.Size = New System.Drawing.Size(128, 21)
        Me.TextBox95.TabIndex = 382
        '
        'Label152
        '
        Me.Label152.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label152.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label152.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label152.ForeColor = System.Drawing.Color.Black
        Me.Label152.Location = New System.Drawing.Point(256, 80)
        Me.Label152.Name = "Label152"
        Me.Label152.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label152.Size = New System.Drawing.Size(64, 16)
        Me.Label152.TabIndex = 381
        Me.Label152.Tag = "0629"
        Me.Label152.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label153
        '
        Me.Label153.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label153.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label153.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label153.ForeColor = System.Drawing.Color.Black
        Me.Label153.Location = New System.Drawing.Point(8, 80)
        Me.Label153.Name = "Label153"
        Me.Label153.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label153.Size = New System.Drawing.Size(64, 16)
        Me.Label153.TabIndex = 380
        Me.Label153.Tag = "0629"
        Me.Label153.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(88, 80)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox2.TabIndex = 379
        '
        'TextBox96
        '
        Me.TextBox96.AcceptsReturn = True
        Me.TextBox96.BackColor = System.Drawing.Color.White
        Me.TextBox96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox96.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox96.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox96.ForeColor = System.Drawing.Color.Black
        Me.TextBox96.Location = New System.Drawing.Point(328, 56)
        Me.TextBox96.MaxLength = 12
        Me.TextBox96.Name = "TextBox96"
        Me.TextBox96.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox96.Size = New System.Drawing.Size(128, 21)
        Me.TextBox96.TabIndex = 373
        '
        'Label154
        '
        Me.Label154.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label154.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label154.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label154.ForeColor = System.Drawing.Color.Black
        Me.Label154.Location = New System.Drawing.Point(232, 56)
        Me.Label154.Name = "Label154"
        Me.Label154.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label154.Size = New System.Drawing.Size(88, 16)
        Me.Label154.TabIndex = 371
        Me.Label154.Tag = "0629"
        Me.Label154.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label155
        '
        Me.Label155.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label155.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label155.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label155.ForeColor = System.Drawing.Color.Black
        Me.Label155.Location = New System.Drawing.Point(240, 32)
        Me.Label155.Name = "Label155"
        Me.Label155.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label155.Size = New System.Drawing.Size(80, 16)
        Me.Label155.TabIndex = 370
        Me.Label155.Tag = "0629"
        Me.Label155.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox97
        '
        Me.TextBox97.AcceptsReturn = True
        Me.TextBox97.BackColor = System.Drawing.Color.White
        Me.TextBox97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox97.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox97.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox97.ForeColor = System.Drawing.Color.Black
        Me.TextBox97.Location = New System.Drawing.Point(88, 56)
        Me.TextBox97.MaxLength = 12
        Me.TextBox97.Name = "TextBox97"
        Me.TextBox97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox97.Size = New System.Drawing.Size(144, 21)
        Me.TextBox97.TabIndex = 369
        '
        'Label156
        '
        Me.Label156.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label156.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label156.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label156.ForeColor = System.Drawing.Color.Black
        Me.Label156.Location = New System.Drawing.Point(8, 56)
        Me.Label156.Name = "Label156"
        Me.Label156.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label156.Size = New System.Drawing.Size(64, 16)
        Me.Label156.TabIndex = 356
        Me.Label156.Tag = "0629"
        Me.Label156.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker33
        '
        Me.DateTimePicker33.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DateTimePicker33.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker33.Location = New System.Drawing.Point(88, 32)
        Me.DateTimePicker33.Name = "DateTimePicker33"
        Me.DateTimePicker33.ShowCheckBox = True
        Me.DateTimePicker33.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker33.TabIndex = 368
        Me.DateTimePicker33.Value = New Date(2007, 3, 16, 15, 46, 22, 30)
        '
        'Label157
        '
        Me.Label157.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label157.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label157.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label157.ForeColor = System.Drawing.Color.Black
        Me.Label157.Location = New System.Drawing.Point(8, 32)
        Me.Label157.Name = "Label157"
        Me.Label157.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label157.Size = New System.Drawing.Size(64, 16)
        Me.Label157.TabIndex = 355
        Me.Label157.Tag = "0629"
        Me.Label157.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StatusBar
        '
        Me.StatusBar.Location = New System.Drawing.Point(0, 699)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.Panel1, Me.Panel2, Me.Panel3, Me.Panel4})
        Me.StatusBar.ShowPanels = True
        Me.StatusBar.Size = New System.Drawing.Size(1058, 1)
        Me.StatusBar.TabIndex = 450
        Me.StatusBar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Width = 320
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Width = 400
        '
        'Panel3
        '
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Width = 220
        '
        'Panel4
        '
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Width = 96
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MOpertations, Me.MRecords, Me.MClose1, Me.MenuItem1})
        '
        'MOpertations
        '
        Me.MOpertations.Index = 0
        Me.MOpertations.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MSearch, Me.Separt, Me.MValidate, Me.MCancel})
        Me.MOpertations.Text = "Opérations"
        Me.MOpertations.Visible = False
        '
        'MSearch
        '
        Me.MSearch.Index = 0
        Me.MSearch.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MSearch.Text = "Chercher"
        '
        'Separt
        '
        Me.Separt.Index = 1
        Me.Separt.Text = "-"
        '
        'MValidate
        '
        Me.MValidate.Index = 2
        Me.MValidate.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.MValidate.Text = "Valider"
        '
        'MCancel
        '
        Me.MCancel.Index = 3
        Me.MCancel.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MCancel.Text = "Annuler"
        '
        'MRecords
        '
        Me.MRecords.Index = 1
        Me.MRecords.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MFirst, Me.MPrevious, Me.MNext, Me.MLast})
        Me.MRecords.Text = "Enregistrements"
        Me.MRecords.Visible = False
        '
        'MFirst
        '
        Me.MFirst.Index = 0
        Me.MFirst.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MFirst.Text = "Premier"
        '
        'MPrevious
        '
        Me.MPrevious.Index = 1
        Me.MPrevious.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MPrevious.Text = "Précedent"
        '
        'MNext
        '
        Me.MNext.Index = 2
        Me.MNext.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MNext.Text = "Suivant"
        '
        'MLast
        '
        Me.MLast.Index = 3
        Me.MLast.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MLast.Text = "Dernier"
        '
        'MClose1
        '
        Me.MClose1.Index = 2
        Me.MClose1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MClose})
        Me.MClose1.Text = "Fermer"
        Me.MClose1.Visible = False
        '
        'MClose
        '
        Me.MClose.Index = 0
        Me.MClose.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MClose.Text = "Fermer"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "Version"
        Me.MenuItem1.Visible = False
        '
        'Toolsb13
        '
        Me.Toolsb13.BackColor = System.Drawing.Color.White
        Me.Toolsb13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Toolsb13.FlatAppearance.BorderSize = 0
        Me.Toolsb13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Toolsb13.Image = CType(resources.GetObject("Toolsb13.Image"), System.Drawing.Image)
        Me.Toolsb13.Location = New System.Drawing.Point(935, 563)
        Me.Toolsb13.Name = "Toolsb13"
        Me.Toolsb13.Size = New System.Drawing.Size(44, 41)
        Me.Toolsb13.TabIndex = 799
        Me.ToolTip2.SetToolTip(Me.Toolsb13, "Recherche Avancée")
        Me.Toolsb13.UseVisualStyleBackColor = False
        Me.Toolsb13.Visible = False
        '
        'ToolsB8
        '
        Me.ToolsB8.BackColor = System.Drawing.Color.White
        Me.ToolsB8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB8.FlatAppearance.BorderSize = 0
        Me.ToolsB8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB8.Image = CType(resources.GetObject("ToolsB8.Image"), System.Drawing.Image)
        Me.ToolsB8.Location = New System.Drawing.Point(803, 563)
        Me.ToolsB8.Name = "ToolsB8"
        Me.ToolsB8.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB8.TabIndex = 796
        Me.ToolTip2.SetToolTip(Me.ToolsB8, "Précédent")
        Me.ToolsB8.UseVisualStyleBackColor = False
        '
        'ToolsB9
        '
        Me.ToolsB9.BackColor = System.Drawing.Color.White
        Me.ToolsB9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB9.FlatAppearance.BorderSize = 0
        Me.ToolsB9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB9.Image = CType(resources.GetObject("ToolsB9.Image"), System.Drawing.Image)
        Me.ToolsB9.Location = New System.Drawing.Point(847, 563)
        Me.ToolsB9.Name = "ToolsB9"
        Me.ToolsB9.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB9.TabIndex = 797
        Me.ToolTip2.SetToolTip(Me.ToolsB9, "Suivant")
        Me.ToolsB9.UseVisualStyleBackColor = False
        '
        'ToolsB10
        '
        Me.ToolsB10.BackColor = System.Drawing.Color.White
        Me.ToolsB10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB10.FlatAppearance.BorderSize = 0
        Me.ToolsB10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB10.Image = CType(resources.GetObject("ToolsB10.Image"), System.Drawing.Image)
        Me.ToolsB10.Location = New System.Drawing.Point(891, 563)
        Me.ToolsB10.Name = "ToolsB10"
        Me.ToolsB10.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB10.TabIndex = 798
        Me.ToolTip2.SetToolTip(Me.ToolsB10, "Dernier")
        Me.ToolsB10.UseVisualStyleBackColor = False
        '
        'ToolsB7
        '
        Me.ToolsB7.BackColor = System.Drawing.Color.White
        Me.ToolsB7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB7.FlatAppearance.BorderSize = 0
        Me.ToolsB7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB7.Image = CType(resources.GetObject("ToolsB7.Image"), System.Drawing.Image)
        Me.ToolsB7.Location = New System.Drawing.Point(759, 563)
        Me.ToolsB7.Name = "ToolsB7"
        Me.ToolsB7.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB7.TabIndex = 795
        Me.ToolTip2.SetToolTip(Me.ToolsB7, "Premier")
        Me.ToolsB7.UseVisualStyleBackColor = False
        '
        'ToolsB4
        '
        Me.ToolsB4.BackColor = System.Drawing.Color.White
        Me.ToolsB4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB4.FlatAppearance.BorderSize = 0
        Me.ToolsB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB4.Image = CType(resources.GetObject("ToolsB4.Image"), System.Drawing.Image)
        Me.ToolsB4.Location = New System.Drawing.Point(715, 563)
        Me.ToolsB4.Name = "ToolsB4"
        Me.ToolsB4.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB4.TabIndex = 794
        Me.ToolTip2.SetToolTip(Me.ToolsB4, "Annuler")
        Me.ToolsB4.UseVisualStyleBackColor = False
        '
        'ToolsB3
        '
        Me.ToolsB3.BackColor = System.Drawing.Color.White
        Me.ToolsB3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB3.FlatAppearance.BorderSize = 0
        Me.ToolsB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB3.Image = CType(resources.GetObject("ToolsB3.Image"), System.Drawing.Image)
        Me.ToolsB3.Location = New System.Drawing.Point(671, 563)
        Me.ToolsB3.Name = "ToolsB3"
        Me.ToolsB3.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB3.TabIndex = 793
        Me.ToolTip2.SetToolTip(Me.ToolsB3, "Valider")
        Me.ToolsB3.UseVisualStyleBackColor = False
        '
        'ToolsB2
        '
        Me.ToolsB2.BackColor = System.Drawing.Color.White
        Me.ToolsB2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB2.FlatAppearance.BorderSize = 0
        Me.ToolsB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB2.Image = CType(resources.GetObject("ToolsB2.Image"), System.Drawing.Image)
        Me.ToolsB2.Location = New System.Drawing.Point(627, 563)
        Me.ToolsB2.Name = "ToolsB2"
        Me.ToolsB2.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB2.TabIndex = 792
        Me.ToolTip2.SetToolTip(Me.ToolsB2, "Chercher")
        Me.ToolsB2.UseVisualStyleBackColor = False
        '
        'ToolsB11
        '
        Me.ToolsB11.BackColor = System.Drawing.Color.White
        Me.ToolsB11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsB11.FlatAppearance.BorderSize = 0
        Me.ToolsB11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsB11.Image = CType(resources.GetObject("ToolsB11.Image"), System.Drawing.Image)
        Me.ToolsB11.Location = New System.Drawing.Point(979, 563)
        Me.ToolsB11.Name = "ToolsB11"
        Me.ToolsB11.Size = New System.Drawing.Size(44, 41)
        Me.ToolsB11.TabIndex = 800
        Me.ToolTip2.SetToolTip(Me.ToolsB11, "Fermer")
        Me.ToolsB11.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = -1
        Me.MenuItem5.Text = ""
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Pn4)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Controls.Add(Me.Toolsb13)
        Me.Panel5.Controls.Add(Me.ToolsB8)
        Me.Panel5.Controls.Add(Me.ToolsB9)
        Me.Panel5.Controls.Add(Me.ToolsB10)
        Me.Panel5.Controls.Add(Me.ToolsB7)
        Me.Panel5.Controls.Add(Me.ToolsB4)
        Me.Panel5.Controls.Add(Me.ToolsB3)
        Me.Panel5.Controls.Add(Me.ToolsB2)
        Me.Panel5.Controls.Add(Me.ToolsB11)
        Me.Panel5.Controls.Add(Me.Bn4)
        Me.Panel5.Controls.Add(Me.Bn3)
        Me.Panel5.Controls.Add(Me.FrmMaster)
        Me.Panel5.Controls.Add(Me.Pn3)
        Me.Panel5.Location = New System.Drawing.Point(10, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1038, 626)
        Me.Panel5.TabIndex = 803
        '
        'Pn4
        '
        Me.Pn4.BackColor = System.Drawing.Color.White
        Me.Pn4.Controls.Add(Me._FrmSaisie_5)
        Me.Pn4.Location = New System.Drawing.Point(19, 264)
        Me.Pn4.Name = "Pn4"
        Me.Pn4.Size = New System.Drawing.Size(1001, 286)
        Me.Pn4.TabIndex = 805
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(16, 565)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(136, 53)
        Me.PictureBox4.TabIndex = 1051
        Me.PictureBox4.TabStop = False
        '
        'Bn4
        '
        Me.Bn4.BorderColor = System.Drawing.Color.Gray
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Bn4.CenterPtTracker = DesignerRectTracker7
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0!, 0.003584229!, 1.0!}
        Me.Bn4.ColorFillBlend = CBlendItems4
        Me.Bn4.Corners.All = CType(-1, Short)
        Me.Bn4.Corners.LowerLeft = CType(0, Short)
        Me.Bn4.Corners.LowerRight = CType(0, Short)
        Me.Bn4.Corners.UpperLeft = CType(3, Short)
        Me.Bn4.Corners.UpperRight = CType(3, Short)
        Me.Bn4.Cursor = System.Windows.Forms.Cursors.Hand
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Bn4.FocusPtTracker = DesignerRectTracker8
        Me.Bn4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn4.ImageIndex = 0
        Me.Bn4.Location = New System.Drawing.Point(19, 243)
        Me.Bn4.Name = "Bn4"
        Me.Bn4.Size = New System.Drawing.Size(1001, 20)
        Me.Bn4.TabIndex = 459
        Me.Bn4.Text = "Carte"
        '
        'Bn3
        '
        Me.Bn3.BorderColor = System.Drawing.Color.Gray
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Bn3.CenterPtTracker = DesignerRectTracker9
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems5.iPoint = New Single() {0!, 0.003584229!, 1.0!}
        Me.Bn3.ColorFillBlend = CBlendItems5
        Me.Bn3.Corners.All = CType(-1, Short)
        Me.Bn3.Corners.LowerLeft = CType(0, Short)
        Me.Bn3.Corners.LowerRight = CType(0, Short)
        Me.Bn3.Corners.UpperLeft = CType(3, Short)
        Me.Bn3.Corners.UpperRight = CType(3, Short)
        Me.Bn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bn3.FocalPoints.CenterPtX = 0.472441!
        Me.Bn3.FocalPoints.CenterPtY = 0.45!
        Me.Bn3.FocalPoints.FocusPtX = 0!
        Me.Bn3.FocalPoints.FocusPtY = 0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Bn3.FocusPtTracker = DesignerRectTracker10
        Me.Bn3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn3.ImageIndex = 0
        Me.Bn3.Location = New System.Drawing.Point(19, 243)
        Me.Bn3.Name = "Bn3"
        Me.Bn3.Size = New System.Drawing.Size(498, 20)
        Me.Bn3.TabIndex = 458
        Me.Bn3.Text = "Enrolement"
        '
        'Pn3
        '
        Me.Pn3.BackColor = System.Drawing.Color.White
        Me.Pn3.Controls.Add(Me._FrmSaisie_3)
        Me.Pn3.Location = New System.Drawing.Point(19, 264)
        Me.Pn3.Name = "Pn3"
        Me.Pn3.Size = New System.Drawing.Size(1001, 286)
        Me.Pn3.TabIndex = 808
        '
        'CFermer
        '
        Me.CFermer.BackColor = System.Drawing.Color.Transparent
        Me.CFermer.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.CenterPtTracker = DesignerRectTracker11
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems6.iPoint = New Single() {0!, 1.0!}
        Me.CFermer.ColorFillBlend = CBlendItems6
        Me.CFermer.FocalPoints.CenterPtX = 0!
        Me.CFermer.FocalPoints.CenterPtY = 0!
        Me.CFermer.FocalPoints.FocusPtX = 0!
        Me.CFermer.FocalPoints.FocusPtY = 0!
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CFermer.FocusPtTracker = DesignerRectTracker12
        Me.CFermer.Image = Global.Maquette.My.Resources.Resources.Fermer
        Me.CFermer.ImageIndex = 0
        Me.CFermer.Location = New System.Drawing.Point(1032, 8)
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
        DesignerRectTracker15.IsActive = False
        DesignerRectTracker15.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker15.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.CenterPtTracker = DesignerRectTracker15
        CBlendItems8.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems8.iPoint = New Single() {0!, 1.0!}
        Me.CAgrandir.ColorFillBlend = CBlendItems8
        Me.CAgrandir.FocalPoints.CenterPtX = 1.0!
        Me.CAgrandir.FocalPoints.CenterPtY = 0!
        Me.CAgrandir.FocalPoints.FocusPtX = 0!
        Me.CAgrandir.FocalPoints.FocusPtY = 0!
        DesignerRectTracker16.IsActive = False
        DesignerRectTracker16.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker16.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CAgrandir.FocusPtTracker = DesignerRectTracker16
        Me.CAgrandir.Image = Global.Maquette.My.Resources.Resources.Agrandir
        Me.CAgrandir.ImageIndex = 0
        Me.CAgrandir.Location = New System.Drawing.Point(1011, 8)
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
        DesignerRectTracker17.IsActive = True
        DesignerRectTracker17.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker17.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.CenterPtTracker = DesignerRectTracker17
        CBlendItems9.iColor = New System.Drawing.Color() {System.Drawing.Color.Transparent, System.Drawing.Color.Transparent}
        CBlendItems9.iPoint = New Single() {0!, 1.0!}
        Me.CReduir.ColorFillBlend = CBlendItems9
        Me.CReduir.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CReduir.FocalPoints.CenterPtX = 0.05882353!
        Me.CReduir.FocalPoints.CenterPtY = 0.4!
        Me.CReduir.FocalPoints.FocusPtX = 0!
        Me.CReduir.FocalPoints.FocusPtY = 0!
        DesignerRectTracker18.IsActive = False
        DesignerRectTracker18.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker18.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CReduir.FocusPtTracker = DesignerRectTracker18
        Me.CReduir.ForeColor = System.Drawing.Color.Transparent
        Me.CReduir.Image = Global.Maquette.My.Resources.Resources.Reduire
        Me.CReduir.ImageIndex = 0
        Me.CReduir.Location = New System.Drawing.Point(990, 8)
        Me.CReduir.Name = "CReduir"
        Me.CReduir.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.CReduir.Size = New System.Drawing.Size(21, 18)
        Me.CReduir.TabIndex = 824
        Me.CReduir.Text = ""
        '
        'dateoper
        '
        Me.dateoper.BackColor = System.Drawing.Color.Transparent
        Me.dateoper.Location = New System.Drawing.Point(780, 42)
        Me.dateoper.Name = "dateoper"
        Me.dateoper.Size = New System.Drawing.Size(225, 13)
        Me.dateoper.TabIndex = 830
        '
        'timeoper
        '
        Me.timeoper.BackColor = System.Drawing.Color.Transparent
        Me.timeoper.Location = New System.Drawing.Point(1005, 42)
        Me.timeoper.Name = "timeoper"
        Me.timeoper.Size = New System.Drawing.Size(43, 12)
        Me.timeoper.TabIndex = 829
        '
        'enregistrement
        '
        Me.enregistrement.BackColor = System.Drawing.Color.Transparent
        Me.enregistrement.Location = New System.Drawing.Point(366, 41)
        Me.enregistrement.Name = "enregistrement"
        Me.enregistrement.Size = New System.Drawing.Size(188, 13)
        Me.enregistrement.TabIndex = 828
        '
        'operation1
        '
        Me.operation1.BackColor = System.Drawing.Color.Transparent
        Me.operation1.Location = New System.Drawing.Point(7, 39)
        Me.operation1.Name = "operation1"
        Me.operation1.Size = New System.Drawing.Size(111, 16)
        Me.operation1.TabIndex = 827
        '
        'Label169
        '
        Me.Label169.BackColor = System.Drawing.Color.Transparent
        Me.Label169.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label169.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label169.ForeColor = System.Drawing.Color.White
        Me.Label169.Location = New System.Drawing.Point(75, 778)
        Me.Label169.Name = "Label169"
        Me.Label169.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label169.Size = New System.Drawing.Size(909, 34)
        Me.Label169.TabIndex = 831
        Me.Label169.Tag = "0035"
        Me.Label169.Text = "MX e-gov Version 2015 | Copyright © M2M Group | All rights reserved 2000-2015 I L" &
    "icence n° 123456"
        Me.Label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_FrmSaisie_5
        '
        Me._FrmSaisie_5.BackColorButton = System.Drawing.Color.White
        Me._FrmSaisie_5.BackColorLabel = System.Drawing.Color.Transparent
        Me._FrmSaisie_5.BorderColor = System.Drawing.Color.Gray
        Me._FrmSaisie_5.Controls.Add(Me.Button14)
        Me._FrmSaisie_5.Controls.Add(Me.TXT_CODPROFIL0)
        Me._FrmSaisie_5.Controls.Add(Me.TXT_CODPROFIL)
        Me._FrmSaisie_5.Controls.Add(Me.Label52)
        Me._FrmSaisie_5.Controls.Add(Me.AGroup24)
        Me._FrmSaisie_5.Controls.Add(Me.AGroup25)
        Me._FrmSaisie_5.Controls.Add(Me.TXT_NUMCARTE)
        Me._FrmSaisie_5.Controls.Add(Me.Cmdnumcart)
        Me._FrmSaisie_5.Controls.Add(Me.Button24)
        Me._FrmSaisie_5.Controls.Add(Me.TXT_CODINST0)
        Me._FrmSaisie_5.Controls.Add(Me.TXT_CODINST)
        Me._FrmSaisie_5.Controls.Add(Me.Label102)
        Me._FrmSaisie_5.Controls.Add(Me.Label107)
        Me._FrmSaisie_5.Controls.Add(Me.btn_activation)
        Me._FrmSaisie_5.Controls.Add(Me.CYC_carte)
        Me._FrmSaisie_5.Controls.Add(Me.Button22)
        Me._FrmSaisie_5.Controls.Add(Me.Button23)
        Me._FrmSaisie_5.Controls.Add(Me.Label131)
        Me._FrmSaisie_5.Controls.Add(Me.Label132)
        Me._FrmSaisie_5.Controls.Add(Me.DT_DATMES)
        Me._FrmSaisie_5.Controls.Add(Me.DT_DATCRT)
        Me._FrmSaisie_5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmSaisie_5.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._FrmSaisie_5.LargeurGroup = 0
        Me._FrmSaisie_5.Location = New System.Drawing.Point(3, 3)
        Me._FrmSaisie_5.Name = "_FrmSaisie_5"
        Me._FrmSaisie_5.Size = New System.Drawing.Size(994, 278)
        Me._FrmSaisie_5.TabIndex = 542
        Me._FrmSaisie_5.TabStop = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.Location = New System.Drawing.Point(178, 121)
        Me.Button14.Name = "Button14"
        Me.Button14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button14.Size = New System.Drawing.Size(24, 22)
        Me.Button14.TabIndex = 546
        Me.Button14.UseVisualStyleBackColor = False
        '
        'TXT_CODPROFIL0
        '
        Me.TXT_CODPROFIL0.AcceptsReturn = True
        Me.TXT_CODPROFIL0.BackColor = System.Drawing.Color.White
        Me.TXT_CODPROFIL0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODPROFIL0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODPROFIL0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODPROFIL0.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODPROFIL0.Location = New System.Drawing.Point(202, 121)
        Me.TXT_CODPROFIL0.MaxLength = 12
        Me.TXT_CODPROFIL0.Name = "TXT_CODPROFIL0"
        Me.TXT_CODPROFIL0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODPROFIL0.Size = New System.Drawing.Size(328, 21)
        Me.TXT_CODPROFIL0.TabIndex = 545
        '
        'TXT_CODPROFIL
        '
        Me.TXT_CODPROFIL.AcceptsReturn = True
        Me.TXT_CODPROFIL.BackColor = System.Drawing.Color.White
        Me.TXT_CODPROFIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODPROFIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODPROFIL.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TXT_CODPROFIL.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODPROFIL.Location = New System.Drawing.Point(130, 121)
        Me.TXT_CODPROFIL.MaxLength = 4
        Me.TXT_CODPROFIL.Name = "TXT_CODPROFIL"
        Me.TXT_CODPROFIL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODPROFIL.Size = New System.Drawing.Size(48, 22)
        Me.TXT_CODPROFIL.TabIndex = 544
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(48, 123)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(80, 17)
        Me.Label52.TabIndex = 543
        Me.Label52.Tag = "0211"
        Me.Label52.Text = "Profil Carte :"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AGroup24
        '
        Me.AGroup24.BackColorButton = System.Drawing.Color.White
        Me.AGroup24.BackColorLabel = System.Drawing.Color.White
        Me.AGroup24.BorderColor = System.Drawing.Color.Gray
        Me.AGroup24.Controls.Add(Me.TXT_NumLot)
        Me.AGroup24.Controls.Add(Me._Labels_40)
        Me.AGroup24.Controls.Add(Me.GroupBox6)
        Me.AGroup24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGroup24.ForeColorLabel = System.Drawing.Color.DarkGray
        Me.AGroup24.LargeurGroup = 0
        Me.AGroup24.Location = New System.Drawing.Point(730, 48)
        Me.AGroup24.Name = "AGroup24"
        Me.AGroup24.Size = New System.Drawing.Size(227, 90)
        Me.AGroup24.TabIndex = 542
        Me.AGroup24.TabStop = False
        Me.AGroup24.Visible = False
        '
        'TXT_NumLot
        '
        Me.TXT_NumLot.AcceptsReturn = True
        Me.TXT_NumLot.BackColor = System.Drawing.Color.White
        Me.TXT_NumLot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NumLot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NumLot.Enabled = False
        Me.TXT_NumLot.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NumLot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NumLot.Location = New System.Drawing.Point(88, 40)
        Me.TXT_NumLot.MaxLength = 12
        Me.TXT_NumLot.Name = "TXT_NumLot"
        Me.TXT_NumLot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NumLot.Size = New System.Drawing.Size(120, 22)
        Me.TXT_NumLot.TabIndex = 539
        '
        '_Labels_40
        '
        Me._Labels_40.BackColor = System.Drawing.Color.Transparent
        Me._Labels_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._Labels_40.Font = New System.Drawing.Font("Arial", 9.0!)
        Me._Labels_40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._Labels_40.Location = New System.Drawing.Point(24, 43)
        Me._Labels_40.Name = "_Labels_40"
        Me._Labels_40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Labels_40.Size = New System.Drawing.Size(64, 17)
        Me._Labels_40.TabIndex = 541
        Me._Labels_40.Tag = "1365"
        Me._Labels_40.Text = "N° Lot :"
        Me._Labels_40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Label109)
        Me.GroupBox6.Controls.Add(Me.Label125)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker12)
        Me.GroupBox6.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.GroupBox6.Location = New System.Drawing.Point(104, 232)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(328, 96)
        Me.GroupBox6.TabIndex = 415
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Durr?e"
        '
        'Label109
        '
        Me.Label109.BackColor = System.Drawing.Color.Transparent
        Me.Label109.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label109.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label109.ForeColor = System.Drawing.Color.Black
        Me.Label109.Location = New System.Drawing.Point(184, 24)
        Me.Label109.Name = "Label109"
        Me.Label109.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label109.Size = New System.Drawing.Size(24, 17)
        Me.Label109.TabIndex = 411
        Me.Label109.Tag = "0211"
        Me.Label109.Text = "Au  :"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label125
        '
        Me.Label125.BackColor = System.Drawing.Color.Transparent
        Me.Label125.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label125.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label125.ForeColor = System.Drawing.Color.Black
        Me.Label125.Location = New System.Drawing.Point(8, 24)
        Me.Label125.Name = "Label125"
        Me.Label125.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label125.Size = New System.Drawing.Size(64, 17)
        Me.Label125.TabIndex = 410
        Me.Label125.Tag = "0211"
        Me.Label125.Text = "A Partir de  :"
        Me.Label125.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker12
        '
        Me.DateTimePicker12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DateTimePicker12.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker12.Location = New System.Drawing.Point(168, 88)
        Me.DateTimePicker12.Name = "DateTimePicker12"
        Me.DateTimePicker12.ShowCheckBox = True
        Me.DateTimePicker12.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker12.TabIndex = 416
        '
        'AGroup25
        '
        Me.AGroup25.BackColorButton = System.Drawing.Color.White
        Me.AGroup25.BackColorLabel = System.Drawing.Color.White
        Me.AGroup25.BorderColor = System.Drawing.Color.Gray
        Me.AGroup25.Controls.Add(Me.TXT_ETATPRD)
        Me.AGroup25.Controls.Add(Me.Label126)
        Me.AGroup25.Controls.Add(Me.TXT_ETAT)
        Me.AGroup25.Controls.Add(Me.Label133)
        Me.AGroup25.Controls.Add(Me.TXT_TYPECARTE)
        Me.AGroup25.Controls.Add(Me.Label134)
        Me.AGroup25.Controls.Add(Me.GroupBox3)
        Me.AGroup25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGroup25.ForeColorLabel = System.Drawing.Color.DarkGray
        Me.AGroup25.LargeurGroup = 0
        Me.AGroup25.Location = New System.Drawing.Point(730, 141)
        Me.AGroup25.Name = "AGroup25"
        Me.AGroup25.Size = New System.Drawing.Size(227, 89)
        Me.AGroup25.TabIndex = 541
        Me.AGroup25.TabStop = False
        '
        'TXT_ETATPRD
        '
        Me.TXT_ETATPRD.AcceptsReturn = True
        Me.TXT_ETATPRD.BackColor = System.Drawing.Color.White
        Me.TXT_ETATPRD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ETATPRD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ETATPRD.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TXT_ETATPRD.ForeColor = System.Drawing.Color.Black
        Me.TXT_ETATPRD.Location = New System.Drawing.Point(119, 18)
        Me.TXT_ETATPRD.MaxLength = 2
        Me.TXT_ETATPRD.Name = "TXT_ETATPRD"
        Me.TXT_ETATPRD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_ETATPRD.Size = New System.Drawing.Size(41, 22)
        Me.TXT_ETATPRD.TabIndex = 549
        '
        'Label126
        '
        Me.Label126.BackColor = System.Drawing.Color.Transparent
        Me.Label126.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label126.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label126.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label126.Location = New System.Drawing.Point(6, 21)
        Me.Label126.Name = "Label126"
        Me.Label126.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label126.Size = New System.Drawing.Size(112, 17)
        Me.Label126.TabIndex = 548
        Me.Label126.Tag = "0211"
        Me.Label126.Text = "Etat Production :"
        Me.Label126.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_ETAT
        '
        Me.TXT_ETAT.AcceptsReturn = True
        Me.TXT_ETAT.BackColor = System.Drawing.Color.White
        Me.TXT_ETAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ETAT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ETAT.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TXT_ETAT.ForeColor = System.Drawing.Color.Black
        Me.TXT_ETAT.Location = New System.Drawing.Point(119, 39)
        Me.TXT_ETAT.MaxLength = 2
        Me.TXT_ETAT.Name = "TXT_ETAT"
        Me.TXT_ETAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_ETAT.Size = New System.Drawing.Size(41, 22)
        Me.TXT_ETAT.TabIndex = 547
        '
        'Label133
        '
        Me.Label133.BackColor = System.Drawing.Color.Transparent
        Me.Label133.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label133.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label133.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label133.Location = New System.Drawing.Point(22, 42)
        Me.Label133.Name = "Label133"
        Me.Label133.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label133.Size = New System.Drawing.Size(96, 17)
        Me.Label133.TabIndex = 546
        Me.Label133.Tag = "0211"
        Me.Label133.Text = "Etat de Carte :"
        Me.Label133.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_TYPECARTE
        '
        Me.TXT_TYPECARTE.AcceptsReturn = True
        Me.TXT_TYPECARTE.BackColor = System.Drawing.Color.White
        Me.TXT_TYPECARTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_TYPECARTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TYPECARTE.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TXT_TYPECARTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_TYPECARTE.Location = New System.Drawing.Point(119, 60)
        Me.TXT_TYPECARTE.MaxLength = 4
        Me.TXT_TYPECARTE.Name = "TXT_TYPECARTE"
        Me.TXT_TYPECARTE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_TYPECARTE.Size = New System.Drawing.Size(41, 22)
        Me.TXT_TYPECARTE.TabIndex = 545
        '
        'Label134
        '
        Me.Label134.BackColor = System.Drawing.Color.Transparent
        Me.Label134.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label134.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label134.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label134.Location = New System.Drawing.Point(22, 63)
        Me.Label134.Name = "Label134"
        Me.Label134.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label134.Size = New System.Drawing.Size(96, 17)
        Me.Label134.TabIndex = 544
        Me.Label134.Tag = "0211"
        Me.Label134.Text = "Type de Carte :"
        Me.Label134.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label135)
        Me.GroupBox3.Controls.Add(Me.Label136)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker22)
        Me.GroupBox3.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.GroupBox3.Location = New System.Drawing.Point(104, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 96)
        Me.GroupBox3.TabIndex = 415
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Durr?e"
        '
        'Label135
        '
        Me.Label135.BackColor = System.Drawing.Color.Transparent
        Me.Label135.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label135.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label135.ForeColor = System.Drawing.Color.Black
        Me.Label135.Location = New System.Drawing.Point(184, 24)
        Me.Label135.Name = "Label135"
        Me.Label135.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label135.Size = New System.Drawing.Size(24, 17)
        Me.Label135.TabIndex = 411
        Me.Label135.Tag = "0211"
        Me.Label135.Text = "Au  :"
        Me.Label135.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label136
        '
        Me.Label136.BackColor = System.Drawing.Color.Transparent
        Me.Label136.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label136.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label136.ForeColor = System.Drawing.Color.Black
        Me.Label136.Location = New System.Drawing.Point(8, 24)
        Me.Label136.Name = "Label136"
        Me.Label136.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label136.Size = New System.Drawing.Size(64, 17)
        Me.Label136.TabIndex = 410
        Me.Label136.Tag = "0211"
        Me.Label136.Text = "A Partir de  :"
        Me.Label136.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker22
        '
        Me.DateTimePicker22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DateTimePicker22.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker22.Location = New System.Drawing.Point(168, 88)
        Me.DateTimePicker22.Name = "DateTimePicker22"
        Me.DateTimePicker22.ShowCheckBox = True
        Me.DateTimePicker22.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker22.TabIndex = 416
        '
        'TXT_NUMCARTE
        '
        Me.TXT_NUMCARTE.AcceptsReturn = True
        Me.TXT_NUMCARTE.BackColor = System.Drawing.SystemColors.Window
        Me.TXT_NUMCARTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NUMCARTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NUMCARTE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NUMCARTE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NUMCARTE.Location = New System.Drawing.Point(130, 71)
        Me.TXT_NUMCARTE.MaxLength = 19
        Me.TXT_NUMCARTE.Name = "TXT_NUMCARTE"
        Me.TXT_NUMCARTE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NUMCARTE.Size = New System.Drawing.Size(150, 22)
        Me.TXT_NUMCARTE.TabIndex = 530
        '
        'Cmdnumcart
        '
        Me.Cmdnumcart.BackColor = System.Drawing.SystemColors.Control
        Me.Cmdnumcart.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmdnumcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmdnumcart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmdnumcart.Image = CType(resources.GetObject("Cmdnumcart.Image"), System.Drawing.Image)
        Me.Cmdnumcart.Location = New System.Drawing.Point(282, 71)
        Me.Cmdnumcart.Name = "Cmdnumcart"
        Me.Cmdnumcart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmdnumcart.Size = New System.Drawing.Size(28, 22)
        Me.Cmdnumcart.TabIndex = 531
        Me.Cmdnumcart.Tag = "0625"
        Me.Cmdnumcart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmdnumcart.UseVisualStyleBackColor = False
        Me.Cmdnumcart.Visible = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button24.Image = CType(resources.GetObject("Button24.Image"), System.Drawing.Image)
        Me.Button24.Location = New System.Drawing.Point(178, 99)
        Me.Button24.Name = "Button24"
        Me.Button24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button24.Size = New System.Drawing.Size(24, 22)
        Me.Button24.TabIndex = 525
        Me.Button24.UseVisualStyleBackColor = False
        '
        'TXT_CODINST0
        '
        Me.TXT_CODINST0.AcceptsReturn = True
        Me.TXT_CODINST0.BackColor = System.Drawing.Color.White
        Me.TXT_CODINST0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODINST0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODINST0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODINST0.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODINST0.Location = New System.Drawing.Point(202, 99)
        Me.TXT_CODINST0.MaxLength = 12
        Me.TXT_CODINST0.Name = "TXT_CODINST0"
        Me.TXT_CODINST0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODINST0.Size = New System.Drawing.Size(328, 21)
        Me.TXT_CODINST0.TabIndex = 524
        '
        'TXT_CODINST
        '
        Me.TXT_CODINST.AcceptsReturn = True
        Me.TXT_CODINST.BackColor = System.Drawing.Color.White
        Me.TXT_CODINST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODINST.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODINST.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TXT_CODINST.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODINST.Location = New System.Drawing.Point(130, 99)
        Me.TXT_CODINST.MaxLength = 5
        Me.TXT_CODINST.Name = "TXT_CODINST"
        Me.TXT_CODINST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODINST.Size = New System.Drawing.Size(48, 22)
        Me.TXT_CODINST.TabIndex = 523
        '
        'Label102
        '
        Me.Label102.BackColor = System.Drawing.Color.Transparent
        Me.Label102.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label102.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label102.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label102.Location = New System.Drawing.Point(48, 101)
        Me.Label102.Name = "Label102"
        Me.Label102.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label102.Size = New System.Drawing.Size(80, 17)
        Me.Label102.TabIndex = 522
        Me.Label102.Tag = "0211"
        Me.Label102.Text = "Emetteur :"
        Me.Label102.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label107
        '
        Me.Label107.BackColor = System.Drawing.Color.Transparent
        Me.Label107.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label107.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label107.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label107.Location = New System.Drawing.Point(32, 75)
        Me.Label107.Name = "Label107"
        Me.Label107.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label107.Size = New System.Drawing.Size(96, 17)
        Me.Label107.TabIndex = 520
        Me.Label107.Tag = "0211"
        Me.Label107.Text = "Numéro Carte :"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_activation
        '
        Me.btn_activation.BackColor = System.Drawing.Color.Transparent
        Me.btn_activation.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker21.IsActive = False
        DesignerRectTracker21.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker21.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btn_activation.CenterPtTracker = DesignerRectTracker21
        CBlendItems11.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems11.iPoint = New Single() {0!, 1.0!}
        Me.btn_activation.ColorFillBlend = CBlendItems11
        Me.btn_activation.FocalPoints.CenterPtX = 0.525!
        Me.btn_activation.FocalPoints.CenterPtY = 0.6!
        Me.btn_activation.FocalPoints.FocusPtX = 0!
        Me.btn_activation.FocalPoints.FocusPtY = 0!
        DesignerRectTracker22.IsActive = False
        DesignerRectTracker22.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker22.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btn_activation.FocusPtTracker = DesignerRectTracker22
        Me.btn_activation.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activation.ImageIndex = 0
        Me.btn_activation.Location = New System.Drawing.Point(35, 245)
        Me.btn_activation.Name = "btn_activation"
        Me.btn_activation.Size = New System.Drawing.Size(160, 25)
        Me.btn_activation.TabIndex = 508
        Me.btn_activation.Text = "Activation"
        Me.btn_activation.Visible = False
        '
        'CYC_carte
        '
        Me.CYC_carte.BackColor = System.Drawing.Color.Transparent
        Me.CYC_carte.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CYC_carte.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.CYC_carte.ColorFillBlend = CBlendItems1
        Me.CYC_carte.FocalPoints.CenterPtX = 0.525!
        Me.CYC_carte.FocalPoints.CenterPtY = 0.52!
        Me.CYC_carte.FocalPoints.FocusPtX = 0!
        Me.CYC_carte.FocalPoints.FocusPtY = 0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.CYC_carte.FocusPtTracker = DesignerRectTracker2
        Me.CYC_carte.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CYC_carte.ImageIndex = 0
        Me.CYC_carte.Location = New System.Drawing.Point(829, 245)
        Me.CYC_carte.Name = "CYC_carte"
        Me.CYC_carte.Size = New System.Drawing.Size(160, 25)
        Me.CYC_carte.TabIndex = 508
        Me.CYC_carte.Text = "Cycle de Vie"
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.Transparent
        Me.Button22.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Button22.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0!, 1.0!}
        Me.Button22.ColorFillBlend = CBlendItems2
        DesignerRectTracker4.IsActive = True
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Button22.FocusPtTracker = DesignerRectTracker4
        Me.Button22.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ImageIndex = 0
        Me.Button22.Location = New System.Drawing.Point(666, 246)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(160, 24)
        Me.Button22.TabIndex = 505
        Me.Button22.Text = "Historique Cartes"
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.Transparent
        Me.Button23.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Button23.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0!, 1.0!}
        Me.Button23.ColorFillBlend = CBlendItems3
        Me.Button23.Enabled = False
        Me.Button23.FocalPoints.CenterPtX = 0.50625!
        Me.Button23.FocalPoints.CenterPtY = 0.5416667!
        Me.Button23.FocalPoints.FocusPtX = 0!
        Me.Button23.FocalPoints.FocusPtY = 0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.Button23.FocusPtTracker = DesignerRectTracker6
        Me.Button23.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ImageIndex = 0
        Me.Button23.Location = New System.Drawing.Point(503, 246)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(160, 24)
        Me.Button23.TabIndex = 504
        Me.Button23.Text = "Applications Carte"
        Me.Button23.Visible = False
        '
        'Label131
        '
        Me.Label131.BackColor = System.Drawing.Color.Transparent
        Me.Label131.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label131.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label131.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label131.Location = New System.Drawing.Point(263, 147)
        Me.Label131.Name = "Label131"
        Me.Label131.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label131.Size = New System.Drawing.Size(129, 17)
        Me.Label131.TabIndex = 494
        Me.Label131.Tag = "0211"
        Me.Label131.Text = "Date Mise en Service :"
        Me.Label131.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label132
        '
        Me.Label132.BackColor = System.Drawing.Color.Transparent
        Me.Label132.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label132.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label132.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label132.Location = New System.Drawing.Point(32, 147)
        Me.Label132.Name = "Label132"
        Me.Label132.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label132.Size = New System.Drawing.Size(96, 17)
        Me.Label132.TabIndex = 493
        Me.Label132.Tag = "0211"
        Me.Label132.Text = "Date Création : "
        Me.Label132.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DT_DATMES
        '
        Me.DT_DATMES.Checked = False
        Me.DT_DATMES.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DT_DATMES.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_DATMES.Location = New System.Drawing.Point(392, 145)
        Me.DT_DATMES.Name = "DT_DATMES"
        Me.DT_DATMES.ShowCheckBox = True
        Me.DT_DATMES.Size = New System.Drawing.Size(138, 21)
        Me.DT_DATMES.TabIndex = 492
        '
        'DT_DATCRT
        '
        Me.DT_DATCRT.Checked = False
        Me.DT_DATCRT.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DT_DATCRT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_DATCRT.Location = New System.Drawing.Point(130, 144)
        Me.DT_DATCRT.Name = "DT_DATCRT"
        Me.DT_DATCRT.ShowCheckBox = True
        Me.DT_DATCRT.Size = New System.Drawing.Size(131, 21)
        Me.DT_DATCRT.TabIndex = 491
        '
        'FrmMaster
        '
        Me.FrmMaster.BackColorButton = System.Drawing.Color.White
        Me.FrmMaster.BackColorLabel = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FrmMaster.BorderColor = System.Drawing.Color.Gray
        Me.FrmMaster.Controls.Add(Me.Panel6)
        Me.FrmMaster.Controls.Add(Me.TXT_CIN)
        Me.FrmMaster.Controls.Add(Me.Label3)
        Me.FrmMaster.Controls.Add(Me.Label67)
        Me.FrmMaster.Controls.Add(Me.grpSexe)
        Me.FrmMaster.Controls.Add(Me.SelectDet_2)
        Me.FrmMaster.Controls.Add(Me.TXT_LIB_DISTRICT)
        Me.FrmMaster.Controls.Add(Me.TXT_CODE_DISTRICT)
        Me.FrmMaster.Controls.Add(Me.Label4)
        Me.FrmMaster.Controls.Add(Me.TXT_CODE_MENAGE)
        Me.FrmMaster.Controls.Add(Me.DT_DATNAISS)
        Me.FrmMaster.Controls.Add(Me.TXT_NOM)
        Me.FrmMaster.Controls.Add(Me.TXT_PRENOM)
        Me.FrmMaster.Controls.Add(Me.Label30)
        Me.FrmMaster.Controls.Add(Me._Labels_1)
        Me.FrmMaster.Controls.Add(Me.Label1)
        Me.FrmMaster.Controls.Add(Me._Labels_99)
        Me.FrmMaster.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrmMaster.ForeColorLabel = System.Drawing.Color.White
        Me.FrmMaster.LargeurGroup = 700
        Me.FrmMaster.Location = New System.Drawing.Point(16, 2)
        Me.FrmMaster.Name = "FrmMaster"
        Me.FrmMaster.Size = New System.Drawing.Size(1007, 235)
        Me.FrmMaster.TabIndex = 424
        Me.FrmMaster.TabStop = False
        Me.FrmMaster.Text = "Recherche"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.BTN_SOUS_PREFECTURE)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.BTN_PREFECTURE)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.BTN_REGION)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.TXT_LIB_SOUS_PREFECTURE)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.TXT_LIB_PREFECTURE)
        Me.Panel6.Controls.Add(Me.TXT_CODE_REGION)
        Me.Panel6.Controls.Add(Me.TXT_CODE_SOUS_PREFECTURE)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.TXT_CODE_PREFECTURE)
        Me.Panel6.Controls.Add(Me.TXT_LIB_REGION)
        Me.Panel6.Location = New System.Drawing.Point(357, 27)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(628, 202)
        Me.Panel6.TabIndex = 736
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(386, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 743
        Me.PictureBox2.TabStop = False
        '
        'BTN_SOUS_PREFECTURE
        '
        Me.BTN_SOUS_PREFECTURE.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BTN_SOUS_PREFECTURE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SOUS_PREFECTURE.ForeColor = System.Drawing.Color.Gray
        Me.BTN_SOUS_PREFECTURE.Image = CType(resources.GetObject("BTN_SOUS_PREFECTURE.Image"), System.Drawing.Image)
        Me.BTN_SOUS_PREFECTURE.Location = New System.Drawing.Point(172, 121)
        Me.BTN_SOUS_PREFECTURE.Name = "BTN_SOUS_PREFECTURE"
        Me.BTN_SOUS_PREFECTURE.Size = New System.Drawing.Size(24, 22)
        Me.BTN_SOUS_PREFECTURE.TabIndex = 727
        Me.BTN_SOUS_PREFECTURE.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(113, 39)
        Me.TextBox2.MaxLength = 30
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(144, 22)
        Me.TextBox2.TabIndex = 741
        '
        'BTN_PREFECTURE
        '
        Me.BTN_PREFECTURE.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BTN_PREFECTURE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PREFECTURE.ForeColor = System.Drawing.Color.Gray
        Me.BTN_PREFECTURE.Image = CType(resources.GetObject("BTN_PREFECTURE.Image"), System.Drawing.Image)
        Me.BTN_PREFECTURE.Location = New System.Drawing.Point(172, 93)
        Me.BTN_PREFECTURE.Name = "BTN_PREFECTURE"
        Me.BTN_PREFECTURE.Size = New System.Drawing.Size(24, 22)
        Me.BTN_PREFECTURE.TabIndex = 728
        Me.BTN_PREFECTURE.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(30, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 742
        Me.Label7.Tag = "0629"
        Me.Label7.Text = "E-Mail :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BTN_REGION
        '
        Me.BTN_REGION.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BTN_REGION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REGION.ForeColor = System.Drawing.Color.Gray
        Me.BTN_REGION.Image = CType(resources.GetObject("BTN_REGION.Image"), System.Drawing.Image)
        Me.BTN_REGION.Location = New System.Drawing.Point(172, 65)
        Me.BTN_REGION.Name = "BTN_REGION"
        Me.BTN_REGION.Size = New System.Drawing.Size(24, 22)
        Me.BTN_REGION.TabIndex = 729
        Me.BTN_REGION.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(447, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 471
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(113, 13)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(144, 22)
        Me.TextBox1.TabIndex = 739
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(30, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 740
        Me.Label5.Tag = "0629"
        Me.Label5.Text = "Téléphone :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_LIB_SOUS_PREFECTURE
        '
        Me.TXT_LIB_SOUS_PREFECTURE.AcceptsReturn = True
        Me.TXT_LIB_SOUS_PREFECTURE.BackColor = System.Drawing.Color.White
        Me.TXT_LIB_SOUS_PREFECTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_LIB_SOUS_PREFECTURE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_LIB_SOUS_PREFECTURE.Enabled = False
        Me.TXT_LIB_SOUS_PREFECTURE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LIB_SOUS_PREFECTURE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_LIB_SOUS_PREFECTURE.Location = New System.Drawing.Point(196, 121)
        Me.TXT_LIB_SOUS_PREFECTURE.MaxLength = 0
        Me.TXT_LIB_SOUS_PREFECTURE.Multiline = True
        Me.TXT_LIB_SOUS_PREFECTURE.Name = "TXT_LIB_SOUS_PREFECTURE"
        Me.TXT_LIB_SOUS_PREFECTURE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_LIB_SOUS_PREFECTURE.Size = New System.Drawing.Size(152, 22)
        Me.TXT_LIB_SOUS_PREFECTURE.TabIndex = 734
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(39, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 731
        Me.Label11.Tag = "0629"
        Me.Label11.Text = "Fonction :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(39, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 732
        Me.Label12.Tag = "0629"
        Me.Label12.Text = "Institution :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_LIB_PREFECTURE
        '
        Me.TXT_LIB_PREFECTURE.AcceptsReturn = True
        Me.TXT_LIB_PREFECTURE.BackColor = System.Drawing.Color.White
        Me.TXT_LIB_PREFECTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_LIB_PREFECTURE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_LIB_PREFECTURE.Enabled = False
        Me.TXT_LIB_PREFECTURE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LIB_PREFECTURE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_LIB_PREFECTURE.Location = New System.Drawing.Point(196, 93)
        Me.TXT_LIB_PREFECTURE.MaxLength = 0
        Me.TXT_LIB_PREFECTURE.Multiline = True
        Me.TXT_LIB_PREFECTURE.Name = "TXT_LIB_PREFECTURE"
        Me.TXT_LIB_PREFECTURE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_LIB_PREFECTURE.Size = New System.Drawing.Size(152, 22)
        Me.TXT_LIB_PREFECTURE.TabIndex = 733
        '
        'TXT_CODE_REGION
        '
        Me.TXT_CODE_REGION.AcceptsReturn = True
        Me.TXT_CODE_REGION.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_REGION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODE_REGION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODE_REGION.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE_REGION.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODE_REGION.Location = New System.Drawing.Point(111, 65)
        Me.TXT_CODE_REGION.MaxLength = 3
        Me.TXT_CODE_REGION.Multiline = True
        Me.TXT_CODE_REGION.Name = "TXT_CODE_REGION"
        Me.TXT_CODE_REGION.ReadOnly = True
        Me.TXT_CODE_REGION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODE_REGION.Size = New System.Drawing.Size(61, 22)
        Me.TXT_CODE_REGION.TabIndex = 725
        '
        'TXT_CODE_SOUS_PREFECTURE
        '
        Me.TXT_CODE_SOUS_PREFECTURE.AcceptsReturn = True
        Me.TXT_CODE_SOUS_PREFECTURE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_SOUS_PREFECTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODE_SOUS_PREFECTURE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODE_SOUS_PREFECTURE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE_SOUS_PREFECTURE.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODE_SOUS_PREFECTURE.Location = New System.Drawing.Point(111, 121)
        Me.TXT_CODE_SOUS_PREFECTURE.MaxLength = 3
        Me.TXT_CODE_SOUS_PREFECTURE.Multiline = True
        Me.TXT_CODE_SOUS_PREFECTURE.Name = "TXT_CODE_SOUS_PREFECTURE"
        Me.TXT_CODE_SOUS_PREFECTURE.ReadOnly = True
        Me.TXT_CODE_SOUS_PREFECTURE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODE_SOUS_PREFECTURE.Size = New System.Drawing.Size(61, 22)
        Me.TXT_CODE_SOUS_PREFECTURE.TabIndex = 726
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(20, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(91, 16)
        Me.Label13.TabIndex = 730
        Me.Label13.Tag = "0629"
        Me.Label13.Text = "Département :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_CODE_PREFECTURE
        '
        Me.TXT_CODE_PREFECTURE.AcceptsReturn = True
        Me.TXT_CODE_PREFECTURE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_PREFECTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODE_PREFECTURE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODE_PREFECTURE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE_PREFECTURE.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODE_PREFECTURE.Location = New System.Drawing.Point(111, 93)
        Me.TXT_CODE_PREFECTURE.MaxLength = 3
        Me.TXT_CODE_PREFECTURE.Multiline = True
        Me.TXT_CODE_PREFECTURE.Name = "TXT_CODE_PREFECTURE"
        Me.TXT_CODE_PREFECTURE.ReadOnly = True
        Me.TXT_CODE_PREFECTURE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODE_PREFECTURE.Size = New System.Drawing.Size(61, 22)
        Me.TXT_CODE_PREFECTURE.TabIndex = 724
        '
        'TXT_LIB_REGION
        '
        Me.TXT_LIB_REGION.AcceptsReturn = True
        Me.TXT_LIB_REGION.BackColor = System.Drawing.Color.White
        Me.TXT_LIB_REGION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_LIB_REGION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_LIB_REGION.Enabled = False
        Me.TXT_LIB_REGION.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LIB_REGION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_LIB_REGION.Location = New System.Drawing.Point(196, 65)
        Me.TXT_LIB_REGION.MaxLength = 0
        Me.TXT_LIB_REGION.Multiline = True
        Me.TXT_LIB_REGION.Name = "TXT_LIB_REGION"
        Me.TXT_LIB_REGION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_LIB_REGION.Size = New System.Drawing.Size(152, 22)
        Me.TXT_LIB_REGION.TabIndex = 735
        '
        'TXT_CIN
        '
        Me.TXT_CIN.AcceptsReturn = True
        Me.TXT_CIN.BackColor = System.Drawing.Color.White
        Me.TXT_CIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CIN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CIN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CIN.ForeColor = System.Drawing.Color.Black
        Me.TXT_CIN.Location = New System.Drawing.Point(123, 170)
        Me.TXT_CIN.MaxLength = 30
        Me.TXT_CIN.Name = "TXT_CIN"
        Me.TXT_CIN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CIN.Size = New System.Drawing.Size(144, 22)
        Me.TXT_CIN.TabIndex = 737
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(40, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 738
        Me.Label3.Tag = "0629"
        Me.Label3.Text = "N° d'identité :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label67.Location = New System.Drawing.Point(8, 117)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(115, 19)
        Me.Label67.TabIndex = 723
        Me.Label67.Tag = "0629"
        Me.Label67.Text = "Sexe :"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpSexe
        '
        Me.grpSexe.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.grpSexe.BackColorLabel = System.Drawing.Color.Transparent
        Me.grpSexe.BorderColor = System.Drawing.Color.Gray
        Me.grpSexe.Controls.Add(Me.Label65)
        Me.grpSexe.Controls.Add(Me.Label66)
        Me.grpSexe.Controls.Add(Me.rdbx_F)
        Me.grpSexe.Controls.Add(Me.rdbx_M)
        Me.grpSexe.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpSexe.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.grpSexe.LargeurGroup = 0
        Me.grpSexe.Location = New System.Drawing.Point(123, 112)
        Me.grpSexe.Name = "grpSexe"
        Me.grpSexe.Size = New System.Drawing.Size(211, 26)
        Me.grpSexe.TabIndex = 722
        Me.grpSexe.TabStop = False
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label65.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label65.Location = New System.Drawing.Point(24, 4)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(91, 18)
        Me.Label65.TabIndex = 372
        Me.Label65.Tag = "$1214"
        Me.Label65.Text = "Féminin"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label66.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label66.Location = New System.Drawing.Point(133, 4)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(78, 18)
        Me.Label66.TabIndex = 373
        Me.Label66.Tag = "$1215"
        Me.Label66.Text = "Masculin"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdbx_F
        '
        Me.rdbx_F.BackColor = System.Drawing.Color.Transparent
        Me.rdbx_F.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbx_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbx_F.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rdbx_F.Location = New System.Drawing.Point(8, 5)
        Me.rdbx_F.Name = "rdbx_F"
        Me.rdbx_F.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdbx_F.Size = New System.Drawing.Size(13, 16)
        Me.rdbx_F.TabIndex = 744
        Me.rdbx_F.TabStop = True
        Me.rdbx_F.Tag = ""
        Me.rdbx_F.UseVisualStyleBackColor = False
        '
        'rdbx_M
        '
        Me.rdbx_M.BackColor = System.Drawing.Color.Transparent
        Me.rdbx_M.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbx_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbx_M.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rdbx_M.Location = New System.Drawing.Point(117, 6)
        Me.rdbx_M.Name = "rdbx_M"
        Me.rdbx_M.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdbx_M.Size = New System.Drawing.Size(13, 16)
        Me.rdbx_M.TabIndex = 745
        Me.rdbx_M.TabStop = True
        Me.rdbx_M.Tag = ""
        Me.rdbx_M.UseVisualStyleBackColor = False
        '
        'SelectDet_2
        '
        Me.SelectDet_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SelectDet_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectDet_2.ForeColor = System.Drawing.Color.Gray
        Me.SelectDet_2.Image = CType(resources.GetObject("SelectDet_2.Image"), System.Drawing.Image)
        Me.SelectDet_2.Location = New System.Drawing.Point(689, 128)
        Me.SelectDet_2.Name = "SelectDet_2"
        Me.SelectDet_2.Size = New System.Drawing.Size(24, 22)
        Me.SelectDet_2.TabIndex = 17
        Me.SelectDet_2.UseVisualStyleBackColor = False
        Me.SelectDet_2.Visible = False
        '
        'TXT_LIB_DISTRICT
        '
        Me.TXT_LIB_DISTRICT.AcceptsReturn = True
        Me.TXT_LIB_DISTRICT.BackColor = System.Drawing.Color.White
        Me.TXT_LIB_DISTRICT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_LIB_DISTRICT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_LIB_DISTRICT.Enabled = False
        Me.TXT_LIB_DISTRICT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LIB_DISTRICT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_LIB_DISTRICT.Location = New System.Drawing.Point(713, 128)
        Me.TXT_LIB_DISTRICT.MaxLength = 0
        Me.TXT_LIB_DISTRICT.Multiline = True
        Me.TXT_LIB_DISTRICT.Name = "TXT_LIB_DISTRICT"
        Me.TXT_LIB_DISTRICT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_LIB_DISTRICT.Size = New System.Drawing.Size(152, 22)
        Me.TXT_LIB_DISTRICT.TabIndex = 469
        Me.TXT_LIB_DISTRICT.Visible = False
        '
        'TXT_CODE_DISTRICT
        '
        Me.TXT_CODE_DISTRICT.AcceptsReturn = True
        Me.TXT_CODE_DISTRICT.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_DISTRICT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODE_DISTRICT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODE_DISTRICT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE_DISTRICT.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODE_DISTRICT.Location = New System.Drawing.Point(628, 128)
        Me.TXT_CODE_DISTRICT.MaxLength = 3
        Me.TXT_CODE_DISTRICT.Multiline = True
        Me.TXT_CODE_DISTRICT.Name = "TXT_CODE_DISTRICT"
        Me.TXT_CODE_DISTRICT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODE_DISTRICT.Size = New System.Drawing.Size(61, 22)
        Me.TXT_CODE_DISTRICT.TabIndex = 16
        Me.TXT_CODE_DISTRICT.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(556, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 463
        Me.Label4.Tag = "0629"
        Me.Label4.Text = "District :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label4.Visible = False
        '
        'TXT_CODE_MENAGE
        '
        Me.TXT_CODE_MENAGE.AcceptsReturn = True
        Me.TXT_CODE_MENAGE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_MENAGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODE_MENAGE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODE_MENAGE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE_MENAGE.ForeColor = System.Drawing.Color.Black
        Me.TXT_CODE_MENAGE.Location = New System.Drawing.Point(123, 143)
        Me.TXT_CODE_MENAGE.MaxLength = 12
        Me.TXT_CODE_MENAGE.Name = "TXT_CODE_MENAGE"
        Me.TXT_CODE_MENAGE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODE_MENAGE.Size = New System.Drawing.Size(144, 21)
        Me.TXT_CODE_MENAGE.TabIndex = 20
        '
        'DT_DATNAISS
        '
        Me.DT_DATNAISS.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DT_DATNAISS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_DATNAISS.Location = New System.Drawing.Point(123, 85)
        Me.DT_DATNAISS.Name = "DT_DATNAISS"
        Me.DT_DATNAISS.ShowCheckBox = True
        Me.DT_DATNAISS.Size = New System.Drawing.Size(144, 21)
        Me.DT_DATNAISS.TabIndex = 15
        Me.DT_DATNAISS.Value = New Date(2007, 2, 23, 16, 44, 36, 601)
        '
        'TXT_NOM
        '
        Me.TXT_NOM.AcceptsReturn = True
        Me.TXT_NOM.BackColor = System.Drawing.Color.White
        Me.TXT_NOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOM.ForeColor = System.Drawing.Color.Black
        Me.TXT_NOM.Location = New System.Drawing.Point(123, 61)
        Me.TXT_NOM.MaxLength = 30
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOM.Size = New System.Drawing.Size(144, 22)
        Me.TXT_NOM.TabIndex = 13
        '
        'TXT_PRENOM
        '
        Me.TXT_PRENOM.AcceptsReturn = True
        Me.TXT_PRENOM.BackColor = System.Drawing.Color.White
        Me.TXT_PRENOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PRENOM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PRENOM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRENOM.ForeColor = System.Drawing.Color.Black
        Me.TXT_PRENOM.Location = New System.Drawing.Point(123, 36)
        Me.TXT_PRENOM.MaxLength = 30
        Me.TXT_PRENOM.Name = "TXT_PRENOM"
        Me.TXT_PRENOM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_PRENOM.Size = New System.Drawing.Size(144, 22)
        Me.TXT_PRENOM.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(22, 145)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(101, 16)
        Me.Label30.TabIndex = 427
        Me.Label30.Tag = "1315"
        Me.Label30.Text = "Code Matricule :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Labels_1
        '
        Me._Labels_1.BackColor = System.Drawing.Color.White
        Me._Labels_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Labels_1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me._Labels_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._Labels_1.Location = New System.Drawing.Point(8, 90)
        Me._Labels_1.Name = "_Labels_1"
        Me._Labels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Labels_1.Size = New System.Drawing.Size(115, 16)
        Me._Labels_1.TabIndex = 425
        Me._Labels_1.Tag = "0092"
        Me._Labels_1.Text = "Date Naissance :"
        Me._Labels_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 371
        Me.Label1.Tag = "0629"
        Me.Label1.Text = "Prénom :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Labels_99
        '
        Me._Labels_99.BackColor = System.Drawing.Color.White
        Me._Labels_99.Cursor = System.Windows.Forms.Cursors.Default
        Me._Labels_99.Font = New System.Drawing.Font("Arial", 9.0!)
        Me._Labels_99.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._Labels_99.Location = New System.Drawing.Point(59, 65)
        Me._Labels_99.Name = "_Labels_99"
        Me._Labels_99.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Labels_99.Size = New System.Drawing.Size(64, 16)
        Me._Labels_99.TabIndex = 424
        Me._Labels_99.Tag = "0629"
        Me._Labels_99.Text = "Nom :"
        Me._Labels_99.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_FrmSaisie_3
        '
        Me._FrmSaisie_3.BackColorButton = System.Drawing.Color.White
        Me._FrmSaisie_3.BackColorLabel = System.Drawing.Color.Transparent
        Me._FrmSaisie_3.BorderColor = System.Drawing.Color.Gray
        Me._FrmSaisie_3.Controls.Add(Me.TXT_CODEMEMBRE)
        Me._FrmSaisie_3.Controls.Add(Me.Label32)
        Me._FrmSaisie_3.Controls.Add(Me.Label31)
        Me._FrmSaisie_3.Controls.Add(Me.grpTypeMenage)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_GEO_2)
        Me._FrmSaisie_3.Controls.Add(Me.Label14)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_GEO_1)
        Me._FrmSaisie_3.Controls.Add(Me.Label15)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_10)
        Me._FrmSaisie_3.Controls.Add(Me.Label28)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_9)
        Me._FrmSaisie_3.Controls.Add(Me.Label27)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_8)
        Me._FrmSaisie_3.Controls.Add(Me.Label26)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_7)
        Me._FrmSaisie_3.Controls.Add(Me.Label22)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_6)
        Me._FrmSaisie_3.Controls.Add(Me.Label21)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_5)
        Me._FrmSaisie_3.Controls.Add(Me.Label20)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_4)
        Me._FrmSaisie_3.Controls.Add(Me.Label19)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_3)
        Me._FrmSaisie_3.Controls.Add(Me.Label16)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_2)
        Me._FrmSaisie_3.Controls.Add(Me.Label17)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_NOTE_1)
        Me._FrmSaisie_3.Controls.Add(Me.Label18)
        Me._FrmSaisie_3.Controls.Add(Me.TXT_DET_CODEENROLEMENT)
        Me._FrmSaisie_3.Controls.Add(Me.Label6)
        Me._FrmSaisie_3.Controls.Add(Me.ListDossierOK)
        Me._FrmSaisie_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmSaisie_3.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._FrmSaisie_3.LargeurGroup = 0
        Me._FrmSaisie_3.Location = New System.Drawing.Point(4, 34)
        Me._FrmSaisie_3.Name = "_FrmSaisie_3"
        Me._FrmSaisie_3.Size = New System.Drawing.Size(991, 320)
        Me._FrmSaisie_3.TabIndex = 539
        Me._FrmSaisie_3.TabStop = False
        '
        'TXT_CODEMEMBRE
        '
        Me.TXT_CODEMEMBRE.AcceptsReturn = True
        Me.TXT_CODEMEMBRE.BackColor = System.Drawing.Color.White
        Me.TXT_CODEMEMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODEMEMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CODEMEMBRE.Enabled = False
        Me.TXT_CODEMEMBRE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_CODEMEMBRE.Location = New System.Drawing.Point(183, 21)
        Me.TXT_CODEMEMBRE.MaxLength = 4
        Me.TXT_CODEMEMBRE.Name = "TXT_CODEMEMBRE"
        Me.TXT_CODEMEMBRE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODEMEMBRE.Size = New System.Drawing.Size(128, 22)
        Me.TXT_CODEMEMBRE.TabIndex = 757
        Me.TXT_CODEMEMBRE.Visible = False
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(31, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(150, 16)
        Me.Label32.TabIndex = 756
        Me.Label32.Tag = "0092"
        Me.Label32.Text = "Code membre ménage :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label32.Visible = False
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(68, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(115, 19)
        Me.Label31.TabIndex = 755
        Me.Label31.Tag = "0629"
        Me.Label31.Text = "Type Menage :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label31.Visible = False
        '
        'grpTypeMenage
        '
        Me.grpTypeMenage.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.grpTypeMenage.BackColorLabel = System.Drawing.Color.Transparent
        Me.grpTypeMenage.BorderColor = System.Drawing.Color.Gray
        Me.grpTypeMenage.Controls.Add(Me.Label2)
        Me.grpTypeMenage.Controls.Add(Me.Label29)
        Me.grpTypeMenage.Controls.Add(Me.rdbx_P)
        Me.grpTypeMenage.Controls.Add(Me.rdbx_S)
        Me.grpTypeMenage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpTypeMenage.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.grpTypeMenage.LargeurGroup = 0
        Me.grpTypeMenage.Location = New System.Drawing.Point(183, 45)
        Me.grpTypeMenage.Name = "grpTypeMenage"
        Me.grpTypeMenage.Size = New System.Drawing.Size(312, 26)
        Me.grpTypeMenage.TabIndex = 754
        Me.grpTypeMenage.TabStop = False
        Me.grpTypeMenage.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(24, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(120, 18)
        Me.Label2.TabIndex = 372
        Me.Label2.Tag = "$1214"
        Me.Label2.Text = "Principal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(184, 4)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(104, 18)
        Me.Label29.TabIndex = 373
        Me.Label29.Tag = "$1215"
        Me.Label29.Text = "Secondaire"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdbx_P
        '
        Me.rdbx_P.BackColor = System.Drawing.Color.Transparent
        Me.rdbx_P.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbx_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbx_P.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rdbx_P.Location = New System.Drawing.Point(8, 5)
        Me.rdbx_P.Name = "rdbx_P"
        Me.rdbx_P.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdbx_P.Size = New System.Drawing.Size(13, 16)
        Me.rdbx_P.TabIndex = 744
        Me.rdbx_P.TabStop = True
        Me.rdbx_P.Tag = ""
        Me.rdbx_P.UseVisualStyleBackColor = False
        '
        'rdbx_S
        '
        Me.rdbx_S.BackColor = System.Drawing.Color.Transparent
        Me.rdbx_S.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbx_S.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbx_S.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rdbx_S.Location = New System.Drawing.Point(168, 6)
        Me.rdbx_S.Name = "rdbx_S"
        Me.rdbx_S.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdbx_S.Size = New System.Drawing.Size(13, 16)
        Me.rdbx_S.TabIndex = 745
        Me.rdbx_S.TabStop = True
        Me.rdbx_S.Tag = ""
        Me.rdbx_S.UseVisualStyleBackColor = False
        '
        'TXT_GEO_2
        '
        Me.TXT_GEO_2.AcceptsReturn = True
        Me.TXT_GEO_2.BackColor = System.Drawing.Color.White
        Me.TXT_GEO_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_GEO_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_GEO_2.Enabled = False
        Me.TXT_GEO_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_GEO_2.Location = New System.Drawing.Point(630, 243)
        Me.TXT_GEO_2.MaxLength = 4
        Me.TXT_GEO_2.Name = "TXT_GEO_2"
        Me.TXT_GEO_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_GEO_2.Size = New System.Drawing.Size(128, 22)
        Me.TXT_GEO_2.TabIndex = 749
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(445, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(183, 16)
        Me.Label14.TabIndex = 747
        Me.Label14.Tag = "0092"
        Me.Label14.Text = "Géolocalistion Y  :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_GEO_1
        '
        Me.TXT_GEO_1.AcceptsReturn = True
        Me.TXT_GEO_1.BackColor = System.Drawing.Color.White
        Me.TXT_GEO_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_GEO_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_GEO_1.Enabled = False
        Me.TXT_GEO_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_GEO_1.Location = New System.Drawing.Point(630, 213)
        Me.TXT_GEO_1.MaxLength = 4
        Me.TXT_GEO_1.Name = "TXT_GEO_1"
        Me.TXT_GEO_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_GEO_1.Size = New System.Drawing.Size(128, 22)
        Me.TXT_GEO_1.TabIndex = 751
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(473, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(155, 16)
        Me.Label15.TabIndex = 744
        Me.Label15.Tag = "0092"
        Me.Label15.Text = "Géolocalistion X  :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_10
        '
        Me.TXT_NOTE_10.AcceptsReturn = True
        Me.TXT_NOTE_10.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_10.Enabled = False
        Me.TXT_NOTE_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_10.Location = New System.Drawing.Point(630, 184)
        Me.TXT_NOTE_10.MaxLength = 4
        Me.TXT_NOTE_10.Name = "TXT_NOTE_10"
        Me.TXT_NOTE_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_10.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_10.TabIndex = 752
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(565, 187)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(65, 16)
        Me.Label28.TabIndex = 745
        Me.Label28.Tag = "0092"
        Me.Label28.Text = "Note 10  :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_9
        '
        Me.TXT_NOTE_9.AcceptsReturn = True
        Me.TXT_NOTE_9.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_9.Enabled = False
        Me.TXT_NOTE_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_9.Location = New System.Drawing.Point(630, 154)
        Me.TXT_NOTE_9.MaxLength = 4
        Me.TXT_NOTE_9.Name = "TXT_NOTE_9"
        Me.TXT_NOTE_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_9.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_9.TabIndex = 753
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(565, 157)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(65, 16)
        Me.Label27.TabIndex = 746
        Me.Label27.Tag = "0092"
        Me.Label27.Text = "Note 9  :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_8
        '
        Me.TXT_NOTE_8.AcceptsReturn = True
        Me.TXT_NOTE_8.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_8.Enabled = False
        Me.TXT_NOTE_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_8.Location = New System.Drawing.Point(630, 124)
        Me.TXT_NOTE_8.MaxLength = 4
        Me.TXT_NOTE_8.Name = "TXT_NOTE_8"
        Me.TXT_NOTE_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_8.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_8.TabIndex = 750
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(565, 127)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 748
        Me.Label26.Tag = "0092"
        Me.Label26.Text = "Note 8  :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_7
        '
        Me.TXT_NOTE_7.AcceptsReturn = True
        Me.TXT_NOTE_7.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_7.Enabled = False
        Me.TXT_NOTE_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_7.Location = New System.Drawing.Point(630, 93)
        Me.TXT_NOTE_7.MaxLength = 4
        Me.TXT_NOTE_7.Name = "TXT_NOTE_7"
        Me.TXT_NOTE_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_7.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_7.TabIndex = 739
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(563, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(65, 16)
        Me.Label22.TabIndex = 734
        Me.Label22.Tag = "0092"
        Me.Label22.Text = "Note 7  :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_6
        '
        Me.TXT_NOTE_6.AcceptsReturn = True
        Me.TXT_NOTE_6.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_6.Enabled = False
        Me.TXT_NOTE_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_6.Location = New System.Drawing.Point(183, 255)
        Me.TXT_NOTE_6.MaxLength = 4
        Me.TXT_NOTE_6.Name = "TXT_NOTE_6"
        Me.TXT_NOTE_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_6.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_6.TabIndex = 741
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(116, 258)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(65, 16)
        Me.Label21.TabIndex = 736
        Me.Label21.Tag = "0092"
        Me.Label21.Text = "Note 6  :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_5
        '
        Me.TXT_NOTE_5.AcceptsReturn = True
        Me.TXT_NOTE_5.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_5.Enabled = False
        Me.TXT_NOTE_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_5.Location = New System.Drawing.Point(183, 225)
        Me.TXT_NOTE_5.MaxLength = 4
        Me.TXT_NOTE_5.Name = "TXT_NOTE_5"
        Me.TXT_NOTE_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_5.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_5.TabIndex = 740
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(116, 228)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 730
        Me.Label20.Tag = "0092"
        Me.Label20.Text = "Note 5  :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_4
        '
        Me.TXT_NOTE_4.AcceptsReturn = True
        Me.TXT_NOTE_4.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_4.Enabled = False
        Me.TXT_NOTE_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_4.Location = New System.Drawing.Point(183, 195)
        Me.TXT_NOTE_4.MaxLength = 4
        Me.TXT_NOTE_4.Name = "TXT_NOTE_4"
        Me.TXT_NOTE_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_4.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_4.TabIndex = 743
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(116, 198)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(65, 16)
        Me.Label19.TabIndex = 732
        Me.Label19.Tag = "0092"
        Me.Label19.Text = "Note 4  :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_3
        '
        Me.TXT_NOTE_3.AcceptsReturn = True
        Me.TXT_NOTE_3.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_3.Enabled = False
        Me.TXT_NOTE_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_3.Location = New System.Drawing.Point(183, 165)
        Me.TXT_NOTE_3.MaxLength = 4
        Me.TXT_NOTE_3.Name = "TXT_NOTE_3"
        Me.TXT_NOTE_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_3.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_3.TabIndex = 742
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(116, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(65, 16)
        Me.Label16.TabIndex = 731
        Me.Label16.Tag = "0092"
        Me.Label16.Text = "Note 3  :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_2
        '
        Me.TXT_NOTE_2.AcceptsReturn = True
        Me.TXT_NOTE_2.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_2.Enabled = False
        Me.TXT_NOTE_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_2.Location = New System.Drawing.Point(183, 135)
        Me.TXT_NOTE_2.MaxLength = 4
        Me.TXT_NOTE_2.Name = "TXT_NOTE_2"
        Me.TXT_NOTE_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_2.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_2.TabIndex = 738
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(116, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(65, 16)
        Me.Label17.TabIndex = 733
        Me.Label17.Tag = "0092"
        Me.Label17.Text = "Note 2  :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_NOTE_1
        '
        Me.TXT_NOTE_1.AcceptsReturn = True
        Me.TXT_NOTE_1.BackColor = System.Drawing.Color.White
        Me.TXT_NOTE_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOTE_1.Enabled = False
        Me.TXT_NOTE_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_NOTE_1.Location = New System.Drawing.Point(183, 105)
        Me.TXT_NOTE_1.MaxLength = 4
        Me.TXT_NOTE_1.Name = "TXT_NOTE_1"
        Me.TXT_NOTE_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NOTE_1.Size = New System.Drawing.Size(128, 22)
        Me.TXT_NOTE_1.TabIndex = 737
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(116, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(65, 16)
        Me.Label18.TabIndex = 735
        Me.Label18.Tag = "0092"
        Me.Label18.Text = "Note 1  :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_DET_CODEENROLEMENT
        '
        Me.TXT_DET_CODEENROLEMENT.AcceptsReturn = True
        Me.TXT_DET_CODEENROLEMENT.BackColor = System.Drawing.Color.White
        Me.TXT_DET_CODEENROLEMENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_DET_CODEENROLEMENT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DET_CODEENROLEMENT.Enabled = False
        Me.TXT_DET_CODEENROLEMENT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_DET_CODEENROLEMENT.Location = New System.Drawing.Point(183, 77)
        Me.TXT_DET_CODEENROLEMENT.MaxLength = 4
        Me.TXT_DET_CODEENROLEMENT.Name = "TXT_DET_CODEENROLEMENT"
        Me.TXT_DET_CODEENROLEMENT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_DET_CODEENROLEMENT.Size = New System.Drawing.Size(128, 22)
        Me.TXT_DET_CODEENROLEMENT.TabIndex = 563
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(44, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(137, 16)
        Me.Label6.TabIndex = 562
        Me.Label6.Tag = "0092"
        Me.Label6.Text = "Code Enrolement  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListDossierOK
        '
        Me.ListDossierOK.BackColor = System.Drawing.Color.Transparent
        Me.ListDossierOK.BorderColor = System.Drawing.Color.Transparent
        DesignerRectTracker19.IsActive = False
        DesignerRectTracker19.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker19.TrackerRectangle"), System.Drawing.RectangleF)
        Me.ListDossierOK.CenterPtTracker = DesignerRectTracker19
        CBlendItems10.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(173, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(171, Byte), Integer))}
        CBlendItems10.iPoint = New Single() {0!, 1.0!}
        Me.ListDossierOK.ColorFillBlend = CBlendItems10
        DesignerRectTracker20.IsActive = False
        DesignerRectTracker20.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker20.TrackerRectangle"), System.Drawing.RectangleF)
        Me.ListDossierOK.FocusPtTracker = DesignerRectTracker20
        Me.ListDossierOK.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDossierOK.ImageIndex = 0
        Me.ListDossierOK.Location = New System.Drawing.Point(750, 32)
        Me.ListDossierOK.Name = "ListDossierOK"
        Me.ListDossierOK.Size = New System.Drawing.Size(234, 24)
        Me.ListDossierOK.TabIndex = 550
        Me.ListDossierOK.Text = "Historique Enrolement"
        Me.ListDossierOK.Visible = False
        '
        'AGroup30
        '
        Me.AGroup30.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.AGroup30.BackColorLabel = System.Drawing.Color.Transparent
        Me.AGroup30.BorderColor = System.Drawing.Color.Gray
        Me.AGroup30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AGroup30.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.AGroup30.LargeurGroup = 0
        Me.AGroup30.Location = New System.Drawing.Point(464, 24)
        Me.AGroup30.Name = "AGroup30"
        Me.AGroup30.Size = New System.Drawing.Size(520, 112)
        Me.AGroup30.TabIndex = 7
        Me.AGroup30.TabStop = False
        '
        'AGroup31
        '
        Me.AGroup31.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.AGroup31.BackColorLabel = System.Drawing.Color.Transparent
        Me.AGroup31.BorderColor = System.Drawing.Color.Gray
        Me.AGroup31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AGroup31.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.AGroup31.LargeurGroup = 0
        Me.AGroup31.Location = New System.Drawing.Point(8, 24)
        Me.AGroup31.Name = "AGroup31"
        Me.AGroup31.Size = New System.Drawing.Size(456, 112)
        Me.AGroup31.TabIndex = 6
        Me.AGroup31.TabStop = False
        '
        'AGroup32
        '
        Me.AGroup32.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.AGroup32.BackColorLabel = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AGroup32.BorderColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AGroup32.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGroup32.ForeColorLabel = System.Drawing.Color.White
        Me.AGroup32.LargeurGroup = 0
        Me.AGroup32.Location = New System.Drawing.Point(8, -264)
        Me.AGroup32.Name = "AGroup32"
        Me.AGroup32.Size = New System.Drawing.Size(464, 264)
        Me.AGroup32.TabIndex = 4
        Me.AGroup32.TabStop = False
        '
        'AGroup34
        '
        Me.AGroup34.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.AGroup34.BackColorLabel = System.Drawing.Color.Transparent
        Me.AGroup34.BorderColor = System.Drawing.Color.Gray
        Me.AGroup34.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AGroup34.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.AGroup34.LargeurGroup = 0
        Me.AGroup34.Location = New System.Drawing.Point(472, 22)
        Me.AGroup34.Name = "AGroup34"
        Me.AGroup34.Size = New System.Drawing.Size(496, 89)
        Me.AGroup34.TabIndex = 1
        Me.AGroup34.TabStop = False
        '
        'AGroup35
        '
        Me.AGroup35.BackColorButton = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.AGroup35.BackColorLabel = System.Drawing.Color.Transparent
        Me.AGroup35.BorderColor = System.Drawing.Color.Gray
        Me.AGroup35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AGroup35.ForeColorLabel = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.AGroup35.LargeurGroup = 0
        Me.AGroup35.Location = New System.Drawing.Point(8, 22)
        Me.AGroup35.Name = "AGroup35"
        Me.AGroup35.Size = New System.Drawing.Size(464, 106)
        Me.AGroup35.TabIndex = 0
        Me.AGroup35.TabStop = False
        '
        'Frmcartepermis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1058, 700)
        Me.Controls.Add(Me.Label169)
        Me.Controls.Add(Me.dateoper)
        Me.Controls.Add(Me.timeoper)
        Me.Controls.Add(Me.enregistrement)
        Me.Controls.Add(Me.operation1)
        Me.Controls.Add(Me.CFermer)
        Me.Controls.Add(Me.CAgrandir)
        Me.Controls.Add(Me.CReduir)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.StatusBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Frmcartepermis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion Permis de Conduire"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Pn4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn3.ResumeLayout(False)
        Me._FrmSaisie_5.ResumeLayout(False)
        Me._FrmSaisie_5.PerformLayout()
        Me.AGroup24.ResumeLayout(False)
        Me.AGroup24.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.AGroup25.ResumeLayout(False)
        Me.AGroup25.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.FrmMaster.ResumeLayout(False)
        Me.FrmMaster.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSexe.ResumeLayout(False)
        Me._FrmSaisie_3.ResumeLayout(False)
        Me._FrmSaisie_3.PerformLayout()
        Me.grpTypeMenage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitCTL()
        FrmSaisie(0) = _FrmSaisie_3
        FrmSaisie(1) = _FrmSaisie_5


    End Sub

    Private Sub masquer()
        Select Case Etat
            '########################################

            Case 0

                ToolsB2.Enabled = True
                ToolsB3.Enabled = False
                ToolsB4.Enabled = False
                ToolsB7.Enabled = False
                ToolsB8.Enabled = False
                ToolsB9.Enabled = False
                ToolsB10.Enabled = False
                ToolsB11.Enabled = True
                Toolsb13.Enabled = True


                MSearch.Enabled = True
                MValidate.Enabled = False
                MCancel.Enabled = False
                MFirst.Enabled = False
                MPrevious.Enabled = False
                MNext.Enabled = False
                MLast.Enabled = False

            Case 1, 2, 5


                ToolsB2.Enabled = False
                ToolsB3.Enabled = True
                ToolsB4.Enabled = True

                ToolsB7.Enabled = False
                ToolsB8.Enabled = False
                ToolsB9.Enabled = False
                ToolsB10.Enabled = False
                ToolsB11.Enabled = True
                Toolsb13.Enabled = True

                MSearch.Enabled = False
                MValidate.Enabled = True
                MCancel.Enabled = True
                MFirst.Enabled = False
                MPrevious.Enabled = False
                MNext.Enabled = False
                MLast.Enabled = False

                '########################################
            Case 4

                ToolsB2.Enabled = True
                ToolsB3.Enabled = False
                ToolsB4.Enabled = False
                ToolsB7.Enabled = False
                ToolsB8.Enabled = False
                ToolsB9.Enabled = False
                ToolsB10.Enabled = False
                ToolsB11.Enabled = True
                Toolsb13.Enabled = True

                MSearch.Enabled = True
                MValidate.Enabled = False
                MCancel.Enabled = False
                MFirst.Enabled = False
                MPrevious.Enabled = False
                MNext.Enabled = False
                MLast.Enabled = False

                MaskPointors()


        End Select

        '########################################

        ' SQLCode = "select * from WINMENU where AMN_OPER = '" & CodeOperatrice & "' and AMN_CODE = '0000000003'"
        SQLCode = "select * from WINMENU where AMN_OPER = 'OGHARAMI' and AMN_CODE = '0000000003'"

        TempoRec = executeGetTable(SQLCode)

        If TempoRec Is Nothing Then
            Exit Sub
        End If

        'If TempoRec.Rows(0)("AMN_DRTMODIF") = "N" Then
        '    editBtn.Enabled = False
        'End If
        'If TempoRec.Rows(0)("AMN_DRTSUPPR") = "N" Then
        '    toolsb6.Enabled = False
        'End If
        'If TempoRec.Rows(0)("AMN_DRTCREAT") = "N" Then
        '    ToolsB1.Enabled = False
        'End If
        If TempoRec.Rows(0)("AMN_DRTCNSLT") = "N" Then
            ToolsB3.Enabled = False
            ToolsB2.Enabled = False
        End If

    End Sub
    Private Sub MaskPointors()

        Dim Position As Double

        Position = IndexRow

        If Position <> 0 Then
            ToolsB7.Enabled = True
            ToolsB8.Enabled = True
            MFirst.Enabled = True
            MPrevious.Enabled = True
        Else
            ToolsB7.Enabled = False
            ToolsB8.Enabled = False
            MFirst.Enabled = False
            MPrevious.Enabled = False
        End If
        If Position <> RecCount - 1 Then
            ToolsB9.Enabled = True
            ToolsB10.Enabled = True
            MNext.Enabled = True
            MLast.Enabled = True
        Else
            ToolsB9.Enabled = False
            ToolsB10.Enabled = False
            MLast.Enabled = False
            MNext.Enabled = False
        End If
    End Sub
    Private Sub MaskFrm()

        Select Case Etat
            Case 0 'Init
                FrmActiver(FrmMaster, False)
                CYC_carte.Enabled = False
                Button22.Enabled = False
                Button23.Enabled = False
                ListDossierOK.Enabled = False

                For I = 0 To 1
                    FrmActiver(FrmSaisie(I), False)
                Next I

            Case 2, 5 'Update,Search
                FrmActiver(FrmMaster, True)
                CYC_carte.Enabled = False
                Button22.Enabled = False
                Button23.Enabled = False
                ListDossierOK.Enabled = False
            Case 4 'Validate
                FrmActiver(FrmMaster, False)
                'For I = 0 To 1
                '    DataGrid(I).Enabled = True
                'Next I
                CYC_carte.Enabled = True
                Button22.Enabled = True
                ListDossierOK.Enabled = True

        End Select
    End Sub
    Private Sub Init()
        Try

            TXT_CODE_DISTRICT.Text = ""
            TXT_CODE_SOUS_PREFECTURE.Text = ""
            TXT_CODE_PREFECTURE.Text = ""
            TXT_CODE_REGION.Text = ""

            TXT_CODE_MENAGE.Text = ""
            TXT_CIN.Text = ""
            PictureBox1.Image = Nothing

            TXT_LIB_DISTRICT.Text = ""
            TXT_LIB_SOUS_PREFECTURE.Text = ""
            TXT_LIB_PREFECTURE.Text = ""
            TXT_LIB_REGION.Text = ""

            TXT_PRENOM.Text = ""
            TXT_NOM.Text = ""




            Init_dossier()
            Datechecked(DT_DATNAISS)
            Datechecked(DT_DATCRT)
            Datechecked(DT_DATMES)


            TXT_NUMCARTE.Text = ""
            TXT_CODINST.Text = ""
            TXT_CODPROFIL.Text = ""
            TXT_NumLot.Text = ""
            TXT_TYPECARTE.Text = ""
            TXT_CODINST0.Text = ""
            TXT_CODPROFIL0.Text = ""
            TXT_ETATPRD.Text = ""
            TXT_ETAT.Text = ""
            TXT_TYPECARTE.Text = ""


            TXT_NOTE_1.Text = ""
            TXT_NOTE_2.Text = ""
            TXT_NOTE_3.Text = ""
            TXT_NOTE_4.Text = ""
            TXT_NOTE_5.Text = ""
            TXT_NOTE_6.Text = ""
            TXT_NOTE_7.Text = ""
            TXT_NOTE_8.Text = ""
            TXT_NOTE_9.Text = ""
            TXT_NOTE_10.Text = ""

            TXT_GEO_1.Text = ""
            TXT_GEO_2.Text = ""

            rdbx_P.Checked = False
            rdbx_S.Checked = False

            rdbx_F.Checked = False
            rdbx_M.Checked = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MaskMaster(ByRef Search As Boolean)

        TXT_CODE_DISTRICT.Enabled = Search
        TXT_CODE_MENAGE.Enabled = Search
        TXT_CIN.Enabled = Search
        TXT_CODEMEMBRE.Enabled = Search
        TXT_CODE_SOUS_PREFECTURE.Enabled = Search
        TXT_CODE_PREFECTURE.Enabled = Search
        TXT_CODE_REGION.Enabled = Search
        DT_DATNAISS.Enabled = Search
        TXT_PRENOM.Enabled = Search
        TXT_NOM.Enabled = Search

        TXT_CODEMEMBRE.Enabled = Search
        grpSexe.Enabled = Search
        grpTypeMenage.Enabled = Search

        TXT_LIB_DISTRICT.Enabled = False
        TXT_LIB_SOUS_PREFECTURE.Enabled = False
        TXT_LIB_PREFECTURE.Enabled = False
        TXT_LIB_REGION.Enabled = False

        TXT_PRENOM.Enabled = Search
        TXT_NOM.Enabled = Search
        TXT_NUMCARTE.Enabled = Search
        TXT_CODINST.Enabled = Search
        DT_DATMES.Enabled = Search
        DT_DATCRT.Enabled = Search
        TXT_CODPROFIL.Enabled = Search
        TXT_NumLot.Enabled = Search
        TXT_TYPECARTE.Enabled = Search
        TXT_CODINST0.Enabled = False
        TXT_CODPROFIL0.Enabled = False
        TXT_ETATPRD.Enabled = Search
        TXT_ETAT.Enabled = Search
        TXT_TYPECARTE.Enabled = Search
    End Sub


    Private Sub Frmcartepermis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        xp = Me.ClientSize.Width
        yp = Me.ClientSize.Height
        InitCTL()
        EtatTools = True
        Etat = 0
        Init()
        MaskFrm()
        MaskMaster(False)
        masquer()
        Me.Text = "Consultation Ménage"
        page = 0
        tooltip1 = New System.Windows.Forms.ToolTip

        tooltip1.SetToolTip(ToolsB2, "chercher")

        Pn4.Visible = True
        Pn3.Visible = False

        CYC_carte.Enabled = False
        Button22.Enabled = False
        Bn3.Visible = False
        Button23.Enabled = False
        ListDossierOK.Enabled = False

        Me.CenterToScreen()
        dateoper.Text = Format(Today, "dd/MM/yyyy") & " . OP: " & CodeOperatriceUser & ".     CENTRE : " & CodeCentre
        timeoper.Text = Format(TimeOfDay, "HH:mm")

    End Sub

    Private Sub TBoutton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn3.Click, Bn4.Click
        Static PreviousTab As Short
        Select Case sender.name.ToString()
            Case "Bn3"
                PreviousTab = 4
                Pn4.Visible = False
                Pn3.Visible = True
            Case "Bn4"
                PreviousTab = 5
                Pn4.Visible = True
                Pn3.Visible = False
        End Select
        page = PreviousTab
    End Sub


    Private Sub ToolsB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB2.Click
        CSearch()
    End Sub

    Private Sub Init_dossier()
        TXT_CODE_MENAGE.Text = ""
        TXT_CIN.Text = ""
        TXT_DET_CODEENROLEMENT.Text = ""
        TXT_CODEMEMBRE.Text = ""
    End Sub


    Private Sub CSearch()
        Init()
        Etat = 5
        masquer()
        MaskFrm()
        MaskMaster((True))
        TXT_CODE_MENAGE.Focus()
        rechavc = New frmrechavancee
        rechavc.Init()
        operation1.Text = MLangue("Chercher")
    End Sub

    Private Sub toolsb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB3.Click
        CValidate()
    End Sub
    Private Sub CValidate()
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        ValidateDEnrolement()
        If Not ErrSearch Then
            If Etat = 2 Then MaskPointors()
            Etat = 4
            masquer()
            MaskFrm()
            MaskMaster(False)
            Verrouillage(6)
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    ''''M.O le 28/01/2010 001.001.254/  ajouter le rownum =1 et order by PRP_DATCRT desc 
    ''''001.001.255 : regression 001.001.254
    Public Sub ValidateDEnrolement()
        Dim Chaine As String
        Dim poss As Integer
        Dim icount As Integer
        nais = False
        Chaine = " 1=1"
        ErrSearch = False
        Try
            If Etat = 5 Or rechavc.Etat_av = 5 Then

                If Etat = 5 Then
                    If Trim(TXT_CODE_MENAGE.Text) <> "" Then Chaine = Chaine & " AND crt.CODE_ENROLEMENT = '" & ChaineOK((TXT_CODE_MENAGE.Text)) & "'"
                    'If Trim(TXT_DET_CODEENROLEMENT.Text) <> "" Then Chaine = Chaine & " AND CODE_ENROLEMENT = '" & ChaineOK((TXT_DET_CODEENROLEMENT.Text)) & "'"
                    If Trim(TXT_CODEMEMBRE.Text) <> "" Then Chaine = Chaine & " AND CODE_MEMBRE_MENAG = '" & ChaineOK((TXT_CODEMEMBRE.Text)) & "'"
                    If Trim(TXT_CIN.Text) <> "" Then Chaine = Chaine & " AND CIN = '" & ChaineOK((TXT_CIN.Text)) & "'"

                    If Trim(DT_DATNAISS.Checked) <> False Then Chaine = Chaine & " AND crt.DATE_NAISSANCE = '" & FormatDateTime(DT_DATNAISS.Value, DateFormat.ShortDate) & "'"
                    If Trim(TXT_PRENOM.Text) <> "" Then Chaine = Chaine & " AND crt.PRENOM = '" & ChaineOK((TXT_PRENOM.Text)) & "'"
                    If Trim(TXT_NOM.Text) <> "" Then Chaine = Chaine & " AND crt.NOM = '" & ChaineOK((TXT_NOM.Text)) & "'"

                    If rdbx_M.Checked = True Then Chaine = Chaine & " AND crt.SEXE = 'M'"
                    If rdbx_F.Checked = True Then Chaine = Chaine & " AND crt.SEXE = 'F'"
                    If rdbx_P.Checked = True Then Chaine = Chaine & " AND TYPE_MENAG = 'P'"
                    If rdbx_S.Checked = True Then Chaine = Chaine & " AND TYPE_MENAG = 'S'"

                    If Trim(TXT_CODE_DISTRICT.Text) <> "" Then Chaine = Chaine & " AND crt.DISTRICT = '" & ChaineOK((TXT_CODE_DISTRICT.Text)) & "'"
                    If Trim(TXT_CODE_SOUS_PREFECTURE.Text) <> "" Then Chaine = Chaine & " AND crt.code_departement = '" & ChaineOK((TXT_CODE_SOUS_PREFECTURE.Text)) & "'"
                    If Trim(TXT_CODE_PREFECTURE.Text) <> "" Then Chaine = Chaine & " AND crt.code_institution = '" & ChaineOK((TXT_CODE_PREFECTURE.Text)) & "'"
                    If Trim(TXT_CODE_REGION.Text) <> "" Then Chaine = Chaine & " AND crt.code_fonction = '" & ChaineOK((TXT_CODE_REGION.Text)) & "'"

                End If


                'If Chaine = " 1=1" Then
                '    MsgBox("Veuillez saisir des critères ...", 64)
                '    ErrSearch = True
                '    Exit Sub
                'End If

                SQLCode = "SELECT COUNT(*) as ICount FROM ENROLEMENT,CARTE crt" _
                        & " WHERE" & Chaine _
                        & " AND TYPECARTE='MN' " _
                        & " AND FLAGHIST='N'"


                icount = executeScalar(SQLCode)

                If icount = 1000 Then
                    MsgBox("Sélectionnez avec plus de critères ...", 64)
                    ErrSearch = True
                    Exit Sub
                End If

                If icount = 0 Then
                    MsgBox("Pas d'enregistrement ...", 64)
                    ErrSearch = True
                    Exit Sub
                End If


            End If

            SQLCode = "SELECT ENROLEMENT.*,f.libelle as libfonct,d.libelle as libdept,i.libelle as libinst,(select HPR_DATE from HISTPERSO where HPR_NUMCARTE = crt.NUM_CARTE and ETAT = '17') as DT_MISEPROD FROM ENROLEMENT,CARTE crt,Fonction f,Departement d,Institution i" _
                        & " WHERE" & Chaine _
                        & " and ENR_CENTRE ='" & CodeCentre & "'" _
                        & " and crt.code_fonction = f.code and crt.code_institution = i.code and crt.code_departement = d.code " _
                        & " and TYPECARTE='MN' and crt.CODE_ENROLEMENT = ENROLEMENT.CODE_ENROLEMENT " _
                        & " and FLAGHIST='N'" _
                        & " ORDER BY CODE_ENROLEMENT  "



            Chr_Code = SQLCode
            sError = ""
            DpermisEnrolment = executeGetTable(SQLCode)
            If DpermisEnrolment Is Nothing Then
                'Message(sError, 16)
                ErrSearch = True
                Exit Sub
            End If


            RecCount = DpermisEnrolment.Rows.Count

            If RecCount = 0 Then
                Message("Pas d'enregistrement(s) ...!", 64)
                ErrSearch = True
                Exit Sub
            End If

            IndexRow = 0

            Dpermis_Reposition()

            Call ActionBase("0000000003", 5, CodeOperatrice)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dpermis_Reposition()
        MaskPointors()
        DEnrolement_Remplir()
        Refresh_RD_carte()
    End Sub

    Private Sub DEnrolement_Remplir()
        With DpermisEnrolment
            If DpermisEnrolment.Rows.Count = 0 Then
                Init()
            Else
                '
                TXT_CODE_MENAGE.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("CODE_ENROLEMENT"))
                TXT_CODEMEMBRE.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("CODE_MEMBRE_MENAG"))
                TXT_CODE_DISTRICT.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("DISTRICT"))
                DateOK(DpermisEnrolment.Rows(IndexRow)("DATE_NAISSANCE"), DT_DATNAISS)
                TXT_DET_CODEENROLEMENT.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("CODE_ENROLEMENT"))
                DateOK(NullOK(DpermisEnrolment.Rows(IndexRow)("DT_MISEPROD")), DT_DATMES)
                TXT_CIN.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("CIN"))
                'news
                TextBox1.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("Tel"))
                TextBox2.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("Mail"))
                TXT_LIB_REGION.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("libfonct"))
                TXT_LIB_PREFECTURE.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("libinst"))
                TXT_LIB_SOUS_PREFECTURE.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("libdept"))
                TXT_CODE_REGION.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("code_fonction"))
                TXT_CODE_PREFECTURE.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("code_institution"))
                TXT_CODE_SOUS_PREFECTURE.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("code_departement"))
                ',f.libelle as libfonct,d.libelle as libdept,i.libelle as libinst
                TXT_PRENOM.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("PRENOM"))
                TXT_NOM.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOM"))

                PictureBox1.Image = ByteArray2Image(DpermisEnrolment.Rows(IndexRow)("PHOTO"))
                PictureBox2.Image = ByteArray2Image(DpermisEnrolment.Rows(IndexRow)("sign_pad"))



                TXT_NOTE_1.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_1"))
                TXT_NOTE_2.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_2"))
                TXT_NOTE_3.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_3"))
                TXT_NOTE_4.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_4"))
                TXT_NOTE_5.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_5"))
                TXT_NOTE_6.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_6"))
                TXT_NOTE_7.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_7"))
                TXT_NOTE_8.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_8"))
                TXT_NOTE_9.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_9"))
                TXT_NOTE_10.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("NOTE_FP_10"))

                TXT_GEO_1.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("GEO_LOCA_X"))
                TXT_GEO_2.Text = NullOK(DpermisEnrolment.Rows(IndexRow)("GEO_LOCA_Y"))


                If (NullOK(DpermisEnrolment.Rows(IndexRow)("SEXE")) = "M") Then rdbx_M.Checked = True
                If (NullOK(DpermisEnrolment.Rows(IndexRow)("SEXE")) = "F") Then rdbx_F.Checked = True

                If (NullOK(DpermisEnrolment.Rows(IndexRow)("TYPE_MENAG")) = "P") Then rdbx_P.Checked = True
                If (NullOK(DpermisEnrolment.Rows(IndexRow)("TYPE_MENAG")) = "S") Then rdbx_S.Checked = True




                enregistrement.Text = "Enregistrement" & " " & IndexRow + 1 & "/" & RecCount

            End If
        End With

    End Sub

    Private Sub Refresh_RD_carte()
        Dim Suivant As System.Windows.Forms.Label
        SQLCode = "SELECT * FROM carte " _
                  & " WHERE  CODE_ENROLEMENT='" & TXT_DET_CODEENROLEMENT.Text & "' and TYPECARTE='MN'" _
                  & " AND FLAGHIST = 'N'"

        Dcarte = executeGetTable(SQLCode)

        Dcarte_Reposition()


    End Sub


    Private Sub Dcarte_Reposition()

        If (Dcarte Is Nothing Or Dcarte.Rows.Count = 0) Then
            TXT_NUMCARTE.Text = ""
            TXT_CODINST.Text = ""
            TXT_CODPROFIL.Text = ""
            TXT_CODINST0.Text = ""
            TXT_CODPROFIL0.Text = ""

            Datechecked(DT_DATCRT)

            TXT_NumLot.Text = ""

            TXT_ETAT.Text = ""
            TXT_TYPECARTE.Text = ""
            TXT_ETATPRD.Text = ""
        Else
            With Dcarte.Rows(0)
                TXT_NUMCARTE.Text = NullOK(.Item("NUM_CARTE"))
                TXT_CODINST.Text = NullOK(.Item("CODINST"))
                TXT_CODPROFIL.Text = NullOK(.Item("CODPROFIL"))
                DateOK(NullOK(.Item("date_creation")), DT_DATCRT)
                TXT_NumLot.Text = NullOK(.Item("NUM_LOT"))
                TXT_ETAT.Text = NullOK(.Item("ETAT"))
                TXT_TYPECARTE.Text = NullOK(.Item("TYPECARTE"))
                TXT_ETATPRD.Text = NullOK(.Item("etat_prd"))

                'SQLCode = "SELECT INST_LIBELLE FROM INSTITUTION " _
                '                     & "where INST_CODE='" & ChaineOK(TXT_CODINST.Text) & "' "
                'TempoRec = executeGetTable(SQLCode)

                'If (TempoRec Is Nothing Or TempoRec.Rows.Count = 0) Then
                '    TXT_CODINST0.Text = ""
                'Else
                '    TXT_CODINST0.Text = NullOK(TempoRec.Rows(0)("INST_LIBELLE"))
                'End If

                SQLCode = "SELECT LIBELLE FROM PROFCARTE " _
                                   & "where CODE='" & ChaineOK(TXT_CODPROFIL.Text) & "' "

                TempoRec = executeGetTable(SQLCode)

                If (TempoRec Is Nothing Or TempoRec.Rows.Count = 0) Then
                    TXT_CODPROFIL0.Text = ""
                Else
                    TXT_CODPROFIL0.Text = NullOK(TempoRec.Rows(0)("LIBELLE"))
                End If
            End With

        End If


    End Sub

    Private Sub ToolsB10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB9.Click
        CNext()
    End Sub
    Private Sub CNext()
        If IndexRow <> RecCount - 1 Then
            IndexRow = IndexRow + 1
            Dpermis_Reposition()
        End If
    End Sub

    Private Sub ToolsB9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB8.Click
        CPrevious()
    End Sub
    Private Sub CPrevious()

        If IndexRow <> 0 Then
            IndexRow = IndexRow - 1
            Dpermis_Reposition()
        End If

    End Sub
    Private Sub CLast()


        If IndexRow <> RecCount - 1 Then
            IndexRow = RecCount - 1
            Dpermis_Reposition()
        End If


    End Sub
    Private Sub CFirst()

        With DpermisEnrolment
            If IndexRow <> 0 Then
                IndexRow = 0
                Dpermis_Reposition()
            End If
        End With
    End Sub


    Private Sub ToolsB8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB7.Click
        CFirst()
    End Sub

    Private Sub ToolsB11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB10.Click
        CLast()
    End Sub
    Private Sub ToolsB4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB4.Click
        CCancel()
    End Sub
    Private Sub CCancel()
        enregistrement.Text = ""
        operation1.Text = ""
        If Etat = 2 Then
            Dpermis_Reposition()
            Etat = 4
            GoTo Fin
        End If
        Etat = 0
        Init()
        Init_dossier()
Fin:
        masquer()
        MaskFrm()
        MaskMaster(False)
        Verrouillage((5))
    End Sub




    Public Shared Function Image2ByteArray(ByVal img As Image) As Byte()
        Try
            Dim mstImage As MemoryStream = New MemoryStream
            img.Save(mstImage, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim bytImage As Byte() = mstImage.GetBuffer
            Return bytImage
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Function ByteArray2Image(ByVal BArray As Byte()) As Image
        Try
            Dim mstImage As MemoryStream = New MemoryStream(BArray)
            Dim img As Image = Image.FromStream(mstImage)
            Return img
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Sub Verrouillage(ByRef operation As Byte)

        Dim I As Short
        Select Case operation
            Case 0 'Init
                'cmdadd(page).Enabled = False
                For I = 0 To 5
                    'If Not TableAcces(1).Create Then cmdadd(I).Enabled = False
                Next I

            Case 4, 5 ' Validate, Cancel
                If Etat = 1 Then
                    FrmActiver(FrmMaster, True)
                Else
                    FrmActiver(FrmMaster, False)
                End If
                operation1.Text = ""
                Refresh_RD_carte()

                EtatTools = True

            Case 6 ' ValidateMaster
                If Etat = 1 Then
                    FrmActiver(FrmMaster, True)
                Else
                    FrmActiver(FrmMaster, False)
                End If
                operation1.Text = ""
                _FrmSaisie_5.Enabled = True
                CYC_carte.Enabled = True
                Button22.Enabled = True

                _FrmSaisie_3.Enabled = True
                ListDossierOK.Enabled = True

                Refresh_RD_carte()

                EtatTools = True

        End Select
    End Sub


    Private Sub ToolsB11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsB11.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectDet_2.Click
        NumSelection = 20
        lotof = New LotOfSelection
        lotof.ShowDialog()
    End Sub
    Private Sub BTN_REGION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_REGION.Click
        NumSelection = 23
        lotof = New LotOfSelection
        lotof.ShowDialog()
    End Sub

    Private Sub BTN_SOUS_PREFECTURE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SOUS_PREFECTURE.Click
        NumSelection = 21
        lotof = New LotOfSelection
        lotof.ShowDialog()
    End Sub

    Private Sub BTN_PREFECTURE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PREFECTURE.Click
        NumSelection = 22
        lotof = New LotOfSelection
        lotof.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListDossierOK.Click
        'Dim flistedossier = New ListeDossier
        flistedossier.ShowDialog()
    End Sub



    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CYC_carte.Click
        'Dim lstcvicart = New lstcvicarte
        lstcvicart.ShowDialog()
    End Sub



    Private Sub Frmcartepermis_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim sX, sY As Integer
        Dim j As Integer
        Dim ctl As Control
        On Error Resume Next
        sX = Me.ClientSize.Width
        sY = Me.ClientSize.Height
        If (sX = 0 Or sY = 0) Then Exit Sub
        xp = sX / xp
        yp = sY / yp
        For Each ctl In Me.Controls
            ctl.Scale(xp, yp)
            redim_Object(ctl, xp, yp)
        Next
        xp = Me.ClientSize.Width
        yp = Me.ClientSize.Height
    End Sub

    Private Sub MAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '''CAdd()
    End Sub

    Private Sub MSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSearch.Click
        CSearch()
    End Sub


    Private Sub MValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MValidate.Click
        CValidate()
    End Sub

    Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
        CCancel()
    End Sub

    Private Sub MFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFirst.Click
        CFirst()
    End Sub

    Private Sub MPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrevious.Click
        CPrevious()
    End Sub

    Private Sub MNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNext.Click
        CNext()
    End Sub

    Private Sub MLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MLast.Click
        CLast()
    End Sub

    Private Sub MClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MClose1.Click
        Me.Close()
    End Sub

    Private Sub MClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MClose.Click
        Me.Close()
    End Sub

    Private Sub Toolsb12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Toolsb13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toolsb13.Click
        If Not verif_version() Then Exit Sub
        CCancel()
        rechavc = New frmrechavancee
        rechavc.ShowDialog()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click

        listecart.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timeoper.Text = Format(TimeOfDay, "HH:mm")
    End Sub

    Private Sub CTOY_PRENOM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.TextChanged

    End Sub

    Private Sub CTOY_PRENOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PRENOM.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_PRENOMAR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_PRENOMAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_NOM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NOM.TextChanged

    End Sub

    Private Sub CTOY_NOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NOM.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_NOMAR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_NOMAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub PCPR_CODECI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODE_DISTRICT.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCPR_PROVINCE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PCPR_PROVINCE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCPR_NCITOYEN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PCPR_NCITOYEN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCPR_NPC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODE_MENAGE.TextChanged

    End Sub

    Private Sub PCPR_NPC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODE_MENAGE.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_PROFESSION_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_PROFESSION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_VILLE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_VILLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_PAYS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_PAYS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_NATIONALITE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_NATIONALITE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_NBVMILITAIRE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_NBVMILITAIRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_CODPOSTAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_CODPOSTAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_ADRESS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CTOY_ADRESS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_ADRESSAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_LIEUNAISS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ctoy_lieunaissar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CODE_VIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CODE_VIP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_MAIL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_NOMMERE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_NOMPERE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_TELFIXE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTOY_TELGSM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_NUMERO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PCDS_NUMERO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_NUMSIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_TYPEOPER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_ANDEPOT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DET_CODEENROLEMENT.TextChanged

    End Sub

    Private Sub PCDS_ANDEPOT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DET_CODEENROLEMENT.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_ETAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PCDS_ETAT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CERT_VDROIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CERT_VGAUCHE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CERT_RESTRICTION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CERT_MEDECIN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_CAPMONITOR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PCDS_CAPMONITOR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_AGREMENT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PCDS_AGREMENT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCAE_RAISOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PCAE_RAISOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCAE_ADRESSEPRO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCAE_CODECI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCAE_CODEPRO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCAE_FAX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCAE_NOMPRO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCAE_TEL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_MATRICULAE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCDS_MATRICULAEP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_CptRefab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Prp_CptRefab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_CptCotis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_CptRecal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_CptReleve_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRP_CODINST_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODINST.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRP_CODPROFIL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODPROFIL.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRP_ETAT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ETAT.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRP_ETATLSN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRP_ETATPRD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ETATPRD.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_Nordr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_NoSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRP_NUMCARTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NUMCARTE.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_NumLot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NumLot.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Prp_repcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EXCD_NEXAMEN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EXCD_NEXAMEN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EXCD_NDOSSIER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EXCD_NDOSSIER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EXCD_DATDOSS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EXCD_DATDOSS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 0)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EXCD_CINORALE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EXCD_CINPRAT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EXCD_OBSERV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EXCD_OBSERVP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = Keys(KeyAscii, 1)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim version As New Help
        version.ShowDialog()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim version As New Help
        version.ShowDialog()
    End Sub

    Private Sub Button4_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub btn_activation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_activation.Click
        'SQLCode = " SELECT  to_number(PRP_NUMOF) as lot,PRP_NUMDOSS,to_char(PRP_ANDEPOT) as PRP_ANDEPOT,PRP_NSITE,PRP_CODCI FROM gv_carte " _
        '                                                 & " WHERE prp_numcarte = replace( '" & ChaineOK(TXT_NUMCARTE.Text) & "',' ','')"

        'sError = ""
        'TempoRec = ReturnRecordset(SQLCode, , , sError)
        'If TempoRec Is Nothing Then
        '    ErrSearch = True
        '    Exit Sub
        'End If

        'If Not TempoRec.eof Then

        '    SQLCode = " SELECT * FROM GV_ReceptionLot " _
        '                                           & " WHERE RCL_NUM_LOT= '" & NullOK(TempoRec("LOT").Value.ToString) & "' AND RCL_TYPE_ENREG='RLO' and ETAT in('N','T')"
        '    sError = ""
        '    TempoRec = ReturnRecordset(SQLCode, , , sError)
        '    If TempoRec Is Nothing Then
        '        ErrSearch = True
        '        Exit Sub
        '    End If
        '    If TempoRec.Eof Then
        '        MsgBox("Lot de cette carte non réceptionné...!", 64)
        '        ErrSearch = True
        '        Exit Sub
        '    End If
        'End If

        'Dim oFrmActivation As New FrmActivation
        'SQLCode = " SELECT * FROM GV_ReceptionLot " _
        '                                        & " WHERE RCL_SERIE_CARTE= '" & ChaineOK(TXT_NUMCARTE.Text).Replace(" ", "") & "' AND RCL_TYPE_ENREG='CAC'"
        'sError = ""
        'TempoRec = ReturnRecordset(SQLCode, , , sError)
        'If TempoRec Is Nothing Then
        '    ErrSearch = True
        '    Exit Sub
        'End If
        'If Not TempoRec.EOF Then
        '    DateOK(NullOK(TempoRec("RCL_DATE_OPPERATION").Value.ToString), oFrmActivation.dtpkr_activation)
        '    oFrmActivation.cmdOK.Enabled = False
        'End If
        'oFrmActivation.txt_carte.Text = ChaineOK(TXT_NUMCARTE.Text)
        'oFrmActivation.ShowDialog()
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

    Private Sub CYC_carte_ClickButtonArea(Sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button23_ClickButtonArea(Sender As Object, e As MouseEventArgs)

    End Sub
End Class
