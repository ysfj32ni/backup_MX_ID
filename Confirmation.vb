Option Strict Off
Option Explicit On
Friend Class Confirmation
	Inherits System.Windows.Forms.Form
#Region "Code généré par le Concepteur Windows Form "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'Pour le formulaire de démarrage, la première instance créée est l'instance par défaut.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
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
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label1 As System.Windows.Forms.Label
	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Il peut être modifié à l'aide du Concepteur Windows Form.
	'Ne pas le modifier à l'aide de l'éditeur de code.
    Public WithEvents CmdYes As System.Windows.Forms.Button
    Public WithEvents CmdNo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Confirmation))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.CmdYes = New System.Windows.Forms.Button
        Me.CmdNo = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.List1 = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.Transparent
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(6, 27)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(218, 29)
        Me.Frame3.TabIndex = 7
        Me.Frame3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Tag = "1213"
        Me.Label4.Text = "Page Name             Operation"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(244, Byte), CType(244, Byte), CType(244, Byte))
        Me.Frame2.Controls.Add(Me.CmdYes)
        Me.Frame2.Controls.Add(Me.CmdNo)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 170)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(217, 48)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        '
        'CmdYes
        '
        Me.CmdYes.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(21, Byte), CType(8, Byte))
        Me.CmdYes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdYes.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CmdYes.ForeColor = System.Drawing.Color.White
        Me.CmdYes.Location = New System.Drawing.Point(15, 12)
        Me.CmdYes.Name = "CmdYes"
        Me.CmdYes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdYes.Size = New System.Drawing.Size(88, 28)
        Me.CmdYes.TabIndex = 21
        Me.CmdYes.Text = "&Yes"
        '
        'CmdNo
        '
        Me.CmdNo.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(21, Byte), CType(8, Byte))
        Me.CmdNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CmdNo.ForeColor = System.Drawing.Color.White
        Me.CmdNo.Location = New System.Drawing.Point(111, 12)
        Me.CmdNo.Name = "CmdNo"
        Me.CmdNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdNo.Size = New System.Drawing.Size(88, 28)
        Me.CmdNo.TabIndex = 22
        Me.CmdNo.Text = "&No"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(244, Byte), CType(244, Byte), CType(244, Byte))
        Me.Frame1.Controls.Add(Me.List1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 49)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(219, 95)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.Location = New System.Drawing.Point(3, 10)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(213, 56)
        Me.List1.Sorted = True
        Me.List1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(11, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(205, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Tag = "1208"
        Me.Label1.Text = "Are You Sure To Exit ?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Tag = "1206"
        Me.Label2.Text = "Pages Still Opened !"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Confirmation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(232, 223)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(328, 123)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Confirmation"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Confirmation"
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Prise en charge de la mise à niveau "
	Private Shared m_vb6FormDefInstance As Confirmation
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Confirmation
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Confirmation()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	'#!#M#---------------------------------------------------------------------------------------------------------------
	'#!#M#       MAGIX5 BACK-OFFICE 5.1  © M2M 2000
	'#!#M#---------------------------------------------------------------------------------------------------------------
	'#!#M#                   Project     : PMXBOEccf
	'#!#M#                   Description : Projet De consultation des tables Europay
	'#!#M#                   Form        : Confirmation.frm
	'#!#M#                   Description : Forme de Confimration avant fermeture pour les operations Ajout et Modification
	'#!#M#
	'#!#M#   Write           Author      :                                    Date :
	'#!#M#
	'#!#M#   Release         Description :
	'#!#M#                   Author      :                                    Date :
	'#!#M#                   Description :
	'#!#M#                   Author      :                                    Date :
	'#!#M#--------------------------------------------------------------------------------------------------------------
	
	
    Private Sub CmdNo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdNo.Click

        Quitter = False
        Me.Close()
    End Sub

    Private Sub CmdYes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdYes.Click

        Quitter = True
        Me.Close()
    End Sub


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

    Private Sub Confirmation_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        FrmColor(ConfirmationS)
        Me.CenterToScreen()
        LoadLangue(Me)
    End Sub

End Class