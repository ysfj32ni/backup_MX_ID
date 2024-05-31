Imports System.Reflection
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient


Module ModSam_std

    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#       Version 1.03
    '#!#M#---------------------------------------------------------------------------------------------------------------


    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#       MAGIX5 BACK-OFFICE 5.1  © M2M 2000
    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#                   Project     : PMXBOMagixBO 5.1
    '#!#M#                   Description : Module Generale de Back-office
    '#!#M#                   Module      : ModSam.bas
    '#!#M#                   Description : Module regoupant les fonctions communes du projet
    '#!#M#
    '#!#M#   Write           Author      :                                    Date :
    '#!#M#
    '#!#M#   Release         Description :
    '#!#M#                   Author      :                                    Date :
    '#!#M#                   Description :
    '#!#M#                   Author      :                                    Date :
    '#!#M#--------------------------------------------------------------------------------------------------------------
    Public Ierr1 As String
    Public EtatIerr1 As Boolean
    Private Const MF_BYPOSITION As Integer = &H400
    'Cette fonction API sert à prendre le menu
    'qui apparaît lors du clic en haut à gauche du form
    '(sous-menus "Restaurer", "Déplacer", "Réduire", "Fermer", ...)
    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
    'Cette fonction API sert à enlever un de ces sous-menus
    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    'Cette fonction API sert à connaître le nombre de sous-menus dans ce même menu
    Private Declare Function GetMenuItemCount Lib "user32" (ByVal hMenu As Integer) As Integer

    Public SQlCodeMatching As String

    Public Signet As Object

    Public Chemin As String
    Public LangueConf As String
    Public ODBCName As String
    Public Language As Short
    Public TramLogin As String

    Public Const BATCH As Short = 0
    Public Const Lang As Short = 1
    Public Const USER As Short = 2
    Public Const PASSWORD As Short = 3

    Public Const BASE As Short = 12


    Public ErrorColor As Integer
    Public MondatoryColor As Integer
    Public UpdateColor As Integer
    Public SearchColor As Integer
    Public NormalColor As Integer

    Public MerchantTypeS As String
    Public PositionR As Byte
    Public PositionS As Byte
    Public StrEtat(5) As String
    Public Quitter As Boolean

    Public First As Boolean

    Public AcquirerBank As Object
    Public WAcquirerBank As Object
    Public WIssuerBank As String

    Public RdoPorteurs As Object
    Public W_TypDebit As String
    Public W_Ok As Boolean
    Public Wv_Date As Date
    Public VarArn As String
    Public FrameCaption As String
    Public W_Matching As String
    Public W_Match As Boolean

    Public Rsn_Type As String
    Public VarDeadLine As Byte
    Public Rsn_SysPay As String
    Public Rsn_Origine As String
    Public Rsn_Code As String
    Public Rsn_MntSrc As String
    Public Rsn_DevSrc As String
    '___________________________________

    Public OKDemande As Byte
    Public RegularisationOK As Byte
    Public RepresentationOK As Byte
    Public DateTraitement As Date
    Public RaisonCopie As String
    Public RaisonReg As String
    Public ValidateAnnul As Boolean


    Public DetailType As String

    '___________________________________
    Public S_Activite As String
    Public Doc_SysPay As String
    Public W_raison As String
    Public W_syspay As String
    Public W_ARN As String
    Public w_montant As String
    Public W_date As String
    Public W_CodPorteur As String
    Public W_NumTrait As String

    Public PageAppel As Short
    Public W_Sens As String
    Public W_Solde As Double
    Public Drv_Dossier As String

    Public FraudConfirm As Byte
    Public FrmMaitFraude As Object

    Public Wt_Date As Date
    '======= Connexion =======
    Public DBaseLocal As Object

    Public DAcquirer(5) As Object
    Public DIssuer(7) As Object
    '-----------------------------------------------------


    Public BRecFrd As Byte
    Public K1 As Object
    Public No_CI As String
    Dim BackColor As String
    Dim ForeColor As String
    Dim BackColorButton As String
    Dim BackColorButtonAct As String
    Dim BackColorButtonAction As String
    Dim BorderColor As String
    Dim ForColorButton As String
    Dim ForColorButtonAct As String
    Dim ForColorButtonAction As String
    Dim BackgroundColor As String
    Dim CaptionBackColor As String
    Dim CaptionForeColor As String
    Dim BackColorLabel As String
    Dim FORCOLORLABEL As String

    Public BackColorLabel2 As String
    Public TempoReco As Object
    Dim val_tmprec As Boolean



#Region "------------------------------ Definition  Structures ------------------"

    Structure TableAccess
        Dim Code As String
        Dim Actif As Boolean
        Dim Create As Boolean
        Dim Creat As Boolean
        Dim Update As Boolean
        Dim Delete As Boolean
        Dim Search As Boolean
        Dim Visible As Boolean
        Dim PageName As Boolean
    End Structure

    Structure Sites
        Dim Version As String
        Dim produit As String
        Dim Carte As Integer
        Dim Pos As Integer
        Dim atm As Integer
        Dim Date_Renamed As String
        Dim Perime As Boolean
        Dim BqDomestic As String
        Dim CodeSite As String
        Dim NSequense As String
        Dim CLuhn As String
        Dim NBreCarte As Integer
        Dim DateFin As String
        Dim MultiDevise As Short
        Dim NbreUser As Short
        Dim NBreBqeDomestique As Integer
    End Structure


#End Region
    Public oAssembly As [Assembly]
    Public sLoad1 As String

    Public ws2 As Object
    Public ws0 As WebReference1.Service1 = New WebReference1.Service1

    Public WebSp As Boolean = False
    Public Const D_SERVER As String = "MxWeb3"
    Public Const D_EXE As String = "Prototype"
    Public sChem_Exe, sChem_SW As String
    Public TestConn As Boolean
    Public Testkh1 As Boolean = False
    Public GroupUser As String
    Public glob As String
    Public AttachFo As Boolean
    Public sError As String
    Public strTrsARN As String
    Public BMCE_TYPECOMPTE As String
    Public VarActivity As Boolean
    Public ValeurSelection As String
    Public IssuerBank As String
    Public Claim_Declarartion As Boolean
    Public ChReasonCode As String
    Public ChReasonCode0 As String
    Public ChargeBackOK As Byte
    Public RaisonChgbk As String
    'Cette fonction API sert à prendre le menu
    'qui apparaît lors du clic en haut à gauche du form
    '(sous-menus "Restaurer", "Déplacer", "Réduire", "Fermer", ...)
    Private Declare Function GetSystemMenu _
       Lib "user32" (ByVal hwnd As Long,
       ByVal bRevert As Long) As Long
    'Cette fonction API sert à enlever un de ces sous-menus
    Private Declare Function RemoveMenu _
        Lib "user32" (ByVal hMenu As Long,
        ByVal nPosition As Long,
        ByVal wFlags As Long) As Long
    'Cette fonction API sert à connaître le nombre de sous-menus dans ce même menu
    Private Declare Function GetMenuItemCount _
        Lib "user32" _
        (ByVal hMenu As Long) As Long
    '----------------------------------------------------------------------------------------------

    Public Axe1 As Byte
    Public W_BinCrt As String
    Public NomClient As String 'RECUPERER LE NOM CLIENT
    Public Def_TtlVille As String 'la valeur par default de la ville
    Public NumCompteBNP As Boolean 'Pour gestion adhésion : vrai si on ne saisie que 9 chiffre pour le n° compte
    Public NumCompteBNP_ETP As Boolean 'Pour gestion reduction : vrai si on ne saisie que 9 chiffre pour le n° compte
    Public w_rdcbanque As String
    Public vControle_Carte As Boolean

    '-----------------------------
    Public Trouve As Boolean
    Public W_Numlance As String

    Public Site As Sites

    Public RdoDroitprod As Object
    Public Rdoreduiport As Object
    Public TempoRec, TempoRec_act, TempoRec_activ As Object
    Public TempoRec1 As Object
    Public RD_AddData As Object





    Public NumSelection As Short
    Public GBanque As Object
    Public GAgence_Name As Object
    Public CodErreur As Boolean
    Public v_CleRib As String
    '-------------------------------
    '--------------------
    Public FODBase As Object
    Public ReportCode As String



   
    Public TableAcces(10) As TableAccess

    
    Public Site1 As Sites

    Structure ArgCrypts
        Dim BATCH As String
        Dim Version As String
        Dim USER As String
        Dim PASSWORD As String
        Dim BATCODNUM As String
        Dim BATCODALP As String
        Dim NUMEXE As String
        Dim TYPREPORT As String
        Dim TYPEXP As String
        Dim TYPMODULE As String
        Dim TYPDEMANDE As String
        Dim Lang As String
        Dim BASE As String
        Dim LANCEDEM As String
        Dim PIDDEM As String
    End Structure

    Structure RepArgCrypts
        Dim RESULT As String
        Dim LANCEREP As String
        Dim PIDREP As String
        Dim NBRUSER As String
        Dim cle As String
    End Structure

    Public ArgCrypt As ArgCrypts
    Public RepArgCrypt As RepArgCrypts

    Public Const BATCODNUM As Short = 4
    Public Const BATCODALP As Short = 5
    Public Const NUMEXE As Short = 6
    Public Const TYPREPORT As Short = 7
    Public Const TYPEXP As Short = 8
    Public Const TYPMODULE As Short = 9
    Public Const TYPDEMANDE As Short = 10
   
    Public Const LANCEDEM As Short = 13
    Public Const PIDDEM As Short = 14

    Public Const RESULT As Short = 100
    Public Const LANCEREP As Short = 101
    Public Const PIDREP As Short = 102
    Public Const NBRUSER As Short = 103
    Public Const cle As Short = 104

    Public Const Ack As Short = 20
    Public Const Nack As Short = 21

    Public Const IDT As Short = 0
    Public Const NCARD As Short = 1
    Public Const UPCODE As Short = 2
    Public Const ACTCODREP As Short = 19
    Public Const FINVAL As Short = 5
    Public Const NUMDDE As Short = 26
    Public Const CODEREPS As Short = 20
    Public Const MSG_NET As Short = 70
    Public Const RRN As Short = 66
    Public Const STAN As Short = 54
    Public Const MSG_TYPE As Short = 0
    Public Const NCARTE As Short = 1
    Public Const MONTANT As Short = 14
    Public Const Devise As Short = 15
    Public Const DAT As Short = 16
    Public Const HEURE As Short = 17
    Public Const ADVREASON As Short = 69
    Public Const Text As Short = 68




    Public reponse As Object
    Public CodRet As Short
    Public sqb_nocour0 As Integer
    Public SqbNocour As Integer
    Public SqbStep As Short
    Public Timeout As Date
    Public Timeout1 As Date
    Public strData As String
    Public Reçoit As Boolean
    Public Trame As String

    Public Envoi_Reception As Boolean
    Public Conn_AdresseIP As String
    Public Conn_PortSvr As String
    Public TempoTime As String
    Public k As Short
    Public L As Short
    Public Err_Trame As Boolean
    Public TimeOutOk As Boolean
    Public TimeOutOk1 As Boolean
    Public MyFile As String
    Public Trame_Out As String
    Public Trame_Ack As Boolean




    Public SQLCode As String
    Public SQLCode1 As String
    Public I As Object
    Public J As Byte
    Public Langue As Object
   
    Public ODBCNameFo As String
    Public MotPasse As String
    Public MotPasseFo As String
    Public W_PidRep As String

    Public SerialNumber As String
    Public ActivationKey As String
    Public BankName As String
    Public OperatorName As String
    Public ChgPassword As Boolean
    Public w_Banque As String
    Public w_devise As String

    Public TypeBD As String

    Public CodeOperatrice As String
    Public CodeOperatriceUser As String
    Public CodeCentre As String
    Public ServerIP As String
    Public CodeOperatriceFo As String
    Public CodeSRV As String
    Public virgule As Short

    '======= Connexion =======
    Public DBase As Object
    Dim P_conSqlServer As SqlConnection
    '=========================
    Public MaxMontant As String

    Public MotPass As Boolean
    Public ConnectServeur As String

    Structure W_Field
        Dim W_Field1 As String
        Dim W_Field2 As String
        Dim W_Field3 As String
        Dim W_Field4 As String
        Dim W_Field5 As String
        Dim W_Field6 As String
        Dim W_Field7 As String
        Dim W_Field8 As String
    End Structure

    Structure ArgSmss
        Dim MSG_TYPE As String
        Dim NCARTE As String
        Dim MONTANT As String
        Dim Devise As String
        Dim ADVREASON As String
        Dim HEURE As String
        Dim DAT As String
        Dim MSG_NET As String
        Dim RRN As String
        Dim STAN As String
        Dim Text As String
    End Structure

    Public TrameEnvoyer As Integer
    Public ArgSms As ArgSmss


    Public SiteD As Sites

    Public Instring As String
    Public NameODBC As String
    Public TempoString As String
    Public Tmpstring As Object
    Public Tmpcarte As String

    Public Numliste As Short
    Public RDOrdoEngine_definst As Object

    '======= Connexion =======
    Public RDO As Object
    Public Decimale As Integer

    '==============
    Public Structure RecordConnexion
        <VBFixedString(16), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=16)> Public AdresseIp As String
        <VBFixedString(4), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=4)> Public PortSvr As String
    End Structure
    Public MyRecordConnexion As RecordConnexion

    Public Val_TypeMessage As String
    Public Val_Repcode As String
    Public Val_Motif As String
    Public lg As Short


    Public TypeBase As String

    Public code As String
    Public libelle As String

    Public codeCI As String
    Public libelleCI As String

    Public dataSource_BO As String
    Public EtatCrypteMagix As String
    Public EtatCrypteBase As String
    Public ErrSearch As Boolean

    Public Xp As Double
    Public Yp As Double

    Public TmpOperatrice As String
    Public TmpType As String
    Public OperType As String
    Public CodeSuperUser As String
    Public index As Integer

    Public Function Connexion() As Integer
        On Error GoTo ErrConnexion
        SQLCode = "SELECT username FROM all_users WHERE username = 'MXSECUR_" & Trim(CodeOperatrice) & "'"
        If TestConn Then
            Dim sErr As String
            TempoRec = ReturnRecordset(SQLCode, , , sErr)

            If TempoRec Is Nothing Then
                If InStr(sErr, "ORA-01017") > 0 Then Return 3
                If InStr(sErr, "ORA-01004") > 0 Then Return 1
                Return -1
            End If
            If Not TempoRec.EOF Then
                MsgBox("Opérateur Affecté à un Autre Site ...!", vbCritical, "MAGIX")
                Connexion = 2
                Exit Function
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
            If Not TempoRec.EOF Then
                MsgBox("Opérateur Affecté à un Autre Site ...!", vbCritical, "MAGIX")
                Connexion = 2
                Exit Function
            End If
        End If
        Licence()
        Connexion = 0
        Exit Function
ErrConnexion:
        Connexion = 1

    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Message()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Message : text a aficcher , Type0 : type de boite de dialogue
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Permet l'affichage des message d'erreurs
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub Message(ByRef Message0 As String, ByRef Type0 As Byte)

        'yesno :4
        'critical :16
        'question :32
        'Exclamation :48
        'information :64
        MsgBox(Message0, Type0, "Magix Système Gestion Cartes")
    End Sub


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Keys()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : key : Touche , Permission :entier ,chaine ...
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Permet le Control de la saisie
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Keys(ByVal Key As Short, ByVal Permission As Byte, Optional ByVal Data As String = "") As Short

        'Permission ::
        '0: Numérique
        '1: Alphanumérique (Ajout)
        '2: Alphanumérique (Recherche)
        '3: Réel
        '4: Phone
        '8: Numérique Décimale
        '9: Numérique Sauf 0
        '10: Alphabétique


        Keys = 0
        If Key = System.Windows.Forms.Keys.Back Or Key = System.Windows.Forms.Keys.Tab Then
            Keys = Key
        Else
            Select Case Permission
                Case 0
                    If Key >= 48 And Key <= 57 Then Keys = Key
                Case 1
                    If Key = 39 Or Key = 124 Or _
                       Key = 233 Or Key = 232 Or _
                       Key = 59 Or _
                       Key = 33 Or Key = 40 Or _
                       Key = 41 Or Key = 93 Or Key = 91 Or _
                       Key = 249 Or Key = 0 Or Key = 176 Or Key = 44 Then
                    Else

                        Keys = Key
                    End If
                Case 2
                    If Key <> 39 And Key <> 124 Then Keys = Key
                Case 3
                    'If (Key <= 48 And Key >= 57) Or Key = virgule Then Keys = Key
                    If (Key >= 48 And Key <= 57) Or Key = virgule Then Keys = Key
                Case 4
                    If (Key <= 48 And Key >= 57) Or Key = 40 Or Key = 41 Or Key = 45 Then Keys = Key
                    'Case 1
                Case 5
                    If Key = 37 Or (Key <= 48 And Key >= 57) Then Keys = Key
                Case 6
                    If Key = 63 Or (Key >= 48 And Key <= 57) Then Keys = Key
                Case 7
                    If Key = 63 Or Key = 37 Or (Key >= 48 And Key <= 57) Then Keys = Key
                Case 8
                    If Key = 44 And InStr(Data, ".") <> 0 Then
                        Exit Function
                    End If
                    If (Key >= 48 And Key <= 57) Or Key = 44 Then Keys = Key
                Case 9
                    If Key = 48 Then
                        Exit Function
                    End If
                    If (Key >= 48 And Key <= 57) Or Key = 44 Then Keys = Key
                Case 10
                    If Key >= 48 And Key <= 57 Then
                        Exit Function
                    ElseIf Key = 39 Or Key = 124 Or _
                        Key = 233 Or Key = 232 Or _
                        Key = 249 Or Key = 0 Or Key = 176 Then
                        Exit Function
                    Else
                        Keys = Key
                    End If

            End Select
        End If
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Generateur()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Generateur(ByRef Chaine As String) As String

        Dim k As Byte
        Dim TempoStr As String

        TempoStr = Chaine
        For k = 1 To Len(Chaine)
            If Mid(TempoStr, k, 1) = "%" Then Mid(TempoStr, k, 1) = "*"
        Next k
        Generateur = TempoStr
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : RechIADate()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Champs : le nom du champs dans la table  ,Valeur : la Valeur : la valeur du champs
    '#!#F#                Output parameters   : La chaine en critere de recherche
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Permet la recherche avec un champs de type Date
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function RechIADate(ByRef Champs As String, ByRef Valeur As String) As String

        Select Case TypeBD
            Case "I"
                RechIADate = " " & Champs & "='" & Format(CDate(Valeur), "MM/dd/yyyy") & "'"
            Case "O"
                RechIADate = " " & Champs & "='" & Format(CDate(Valeur), "dd/MM/yyyy") & "'"
            Case "A"
                RechIADate = " " & Champs & "=#" & Format(CDate(Valeur), "dd/MM/yyyy") & "#"
        End Select
    End Function

   
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : InsertDate()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function InsertDate(ByVal ChampDate As Object) As String

        Select Case TypeBase
            Case "I"
                InsertDate = IIf(IsDBNull(ChampDate), System.DBNull.Value, Format(ChampDate, "MM/DD/YYYY"))
            Case "A", "O"
                InsertDate = IIf(IsDBNull(ChampDate), "", Format(CDate(ChampDate), "dd/MM/yyyy"))
        End Select

    End Function
    Public Function InsertDate2(ByRef ChampDate As DateTimePicker) As String

        Select Case TypeBase
            Case "I"
                If ChampDate.Checked = True Then
                    InsertDate2 = Format(CDate(ChampDate.Value), "MM/DD/YYYY")
                Else
                    InsertDate2 = ""
                End If
            Case "A", "O"
                If ChampDate.Checked = True Then
                    InsertDate2 = Format(CDate(ChampDate.Value), "dd/MM/yyyy")
                Else
                    InsertDate2 = ""
                End If
        End Select
    End Function
    Public Sub DateOK(ByVal chaine As String, ByVal MyObj As DateTimePicker)

        If IsDBNull(chaine) Or Trim(chaine) = "" Then

            MyObj.Checked = False

            'Init_Picker(MyObj)

        Else

            MyObj.Checked = True

            MyObj.Value = chaine

        End If

    End Sub
    Public Sub TimeOK(ByVal chaine As String, ByVal MyObj As DateTimePicker)

        If IsDBNull(chaine) Or Trim(chaine) = "" Then

            MyObj.Checked = False

            'Init_Picker(MyObj)

        Else

            MyObj.Checked = True

            MyObj.Value = Today & " " & chaine

        End If

    End Sub
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Init_Picker()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------
    Public Sub Init_Picker(ByRef picker As DateTimePicker)
        Select Case picker.Format.ToString
            Case "Short"
                picker.Value = GetDate()
            Case "Time"
                picker.Value = GetDate() & " " & GetTime()
        End Select
        picker.Checked = False
        picker.Enabled = False
    End Sub
    'Public Sub Datechecked(ByVal picker As DateTimePicker)

    '    Select Case picker.Format.ToString
    '        Case "Short"
    '            picker.Checked = True
    '            picker.Value = GetDate()
    '            picker.Checked = False
    '        Case "Time"
    '            picker.Checked = True
    '            picker.Value = GetDate() & " " & Format(TimeOfDay, "HH:mm")
    '            picker.Checked = False
    '    End Select
    'End Sub

    Public Sub Datechecked(ByVal picker As DateTimePicker)

        Select Case picker.Format.ToString
            Case "Short"
                picker.Checked = True
                picker.Value = Now
                picker.Checked = False
            Case "Time"
                picker.Checked = True
                picker.Value = Now & " " & Format(TimeOfDay, "HH:mm")
                picker.Checked = False
        End Select
    End Sub

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Fin_mois()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Fin_mois(ByRef mois As Byte, ByRef annee As Short) As String

        Dim MaxDay As Byte
        Dim W_Year As Short
        Dim W_Month As Byte
        W_Year = annee
        W_Month = mois Mod 12
        If W_Month = 0 Then W_Month = 12
        Select Case mois
            Case 1, 3, 5, 7, 8, 10, 12
                MaxDay = 31
            Case 4, 6, 9, 11
                MaxDay = 30
            Case 2
                If annee Mod 4 = 0 Then
                    MaxDay = 29
                Else
                    MaxDay = 28
                End If
            Case 0
                MaxDay = 31
                W_Month = 12
                W_Year = annee - 1
        End Select
        Fin_mois = MaxDay & "/" & W_Month & "/" & W_Year
    End Function
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : EstDate()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function EstDate(ByRef DateIn As String) As Boolean

        Dim Jour As String
        Dim mois As String
        Dim annee As String
        Dim Mois2 As String

        EstDate = False
        If DateIn = "" Then Exit Function
        Jour = Mid(DateIn, 1, 2)
        mois = Mid(DateIn, 4, 2)

        annee = Mid(DateIn, 7, Len(DateIn) - 6)

        If CDbl(annee) Mod 4 > 0 Then
            Mois2 = CStr(28)
        Else
            Mois2 = CStr(29)
        End If
        If CDbl(mois) < 1 Then Exit Function
        If CDbl(mois) > 12 Then Exit Function
        If CDbl(Jour) < 1 Then Exit Function
        If CDbl(Mois2) = 28 And CDbl(Jour) > 28 Then Exit Function
        If CDbl(Mois2) = 29 And CDbl(Jour) > 29 Then Exit Function
        EstDate = True
    End Function
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : FormatCode()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Text:Text a formater ,Longueur : Longueur du champs
    '#!#F#                Output parameters   : La chaine sous format d'un code
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Permet de d'ajouter des 0 à gauche du code saisie
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function FormatCode(ByRef Text As String, ByRef Longueur As Byte) As String
        Dim Num As String
        Num = Trim(Text)
        FormatCode = New String("0", Longueur - Len(Num)) & Num
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : ZeroX()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function ZeroX(ByRef Chaine As String, ByRef Longueur As Byte) As String

        ZeroX = CStr(New String("0", Longueur - Len(Chaine))) & Chaine
    End Function
    Public Function ZeroXR(ByRef Chaine As String, ByRef Longueur As Byte) As String

        ZeroXR = Chaine & CStr(New String("0", Longueur - Len(Chaine)))
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : FormatMontant()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Montant : Montant a formater
    '#!#F#                Output parameters   : la chaine sous format d'un Montant
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Permet d'afficher les montants sous format standard
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function FormatMontant(ByRef MONTANT As Object, Optional ByVal Devise As Object = Nothing) As String 'ByRef Devise As Object) As Object
        Dim NbZero As String
        Dim K As Short

        SQLCode = "SELECT dev_expo FROM devises" & " WHERE dev_codnum ='" & ChaineOK(CStr(Devise)) & "'"

        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                FormatMontant = IIf(IsDBNull(MONTANT), "0", MONTANT)
                Exit Function
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If

        If Not TempoRec.EOF Then
            FormatMontant = Split(CStr(IIf(IsDBNull(MONTANT), 0, MONTANT) * 10 ^ Val(TempoRec.fields("dev_expo").Value)), ".")(0)
        Else
            FormatMontant = IIf(IsDBNull(MONTANT), 0, Val(MONTANT))
        End If

    End Function
    Public Function FormatMontant2(ByVal MONTANT As Object) As String
        FormatMontant2 = IIf(IsDBNull(MONTANT), "0.00", (Format(Trim(MONTANT), "0.00")))
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : NullOK()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Chaine (string): Chaine a Formater
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Convertit La Chaine d'entrée en String sans espaces
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function NullOK(ByVal Chaine0 As Object) As String
        If IsDBNull(Chaine0) Then
            Return ""
        Else
            Return UCase(Trim(Chaine0))
        End If
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : ChaineOK()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Chaine (string):Chaine a Formater
    '#!#F#                Output parameters   :  Une String
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Convertit La Chaine d'entrée en String MAJ sans espaces
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function ChaineOK(ByRef Chaine0 As String) As String

        ChaineOK = UCase(Trim(Chaine0))
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Acces()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub Acces(ByRef NbrPage As Short)

        SQLCode = " SELECT * FROM gv_winmenu WHERE trim(amn_oper)='" & CodeOperatrice & "'" _
        & "  AND amn_langue='" & Trim(Langue) & "'" _
        & " AND amn_type = 'O' "
        SQLCode = SQLCode & "AND amn_code in ("
        For J = 1 To NbrPage
            TableAcces(J).Actif = False
            TableAcces(J).Create = False
            TableAcces(J).Delete = False
            TableAcces(J).Search = False
            TableAcces(J).Update = False
            If J <> NbrPage Then
                SQLCode = SQLCode & "'" & TableAcces(J).Code & "',"
            Else
                SQLCode = SQLCode & "'" & TableAcces(J).Code & "')"
            End If
        Next J
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Sub
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        While Not TempoRec.EOF
            For J = 1 To NbrPage
                If NullOK(TempoRec("amn_code").value) = TableAcces(J).Code Then
                    TableAcces(J).Actif = (NullOK(TempoRec("amn_actif").value) = "Y")
                    TableAcces(J).Create = (NullOK(TempoRec("amn_drtcreat").value) = "Y")
                    TableAcces(J).Delete = (NullOK(TempoRec("amn_drtsuppr").value) = "Y")
                    TableAcces(J).Search = (NullOK(TempoRec("amn_drtcnslt").value) = "Y")
                    TableAcces(J).Update = (NullOK(TempoRec("amn_drtmodif").value) = "Y")
                End If
            Next J
            TempoRec.MoveNext()
        End While

    End Sub


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Licence()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Permet le Control de la Licence d'utilisation
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :       BELABBAS ABDERRAHIM             Date :16/07/01
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Licence() As Object
        Dim VDate As String

        SQLCode = "SELECT * FROM siteconf"

        TempoRec = SQLOpen(SQLCode)

        If TempoRec.EOF Then
            Select Case Trim(Langue)
                Case "A"
                    MsgBox("erroneous licence key")
                Case "F"
                    MsgBox("Clé de licence erronée")
            End Select
            End
        End If

        With TempoRec


            Site1.Version = IIf(Mid(TempoRec("scf_nlicense").Value, 1, 1) <> "", Mid(TempoRec("scf_nlicense").Value, 1, 1), "")
            'Version = 0 ou 1 ou 2
            If Site1.Version <> 0 And Site1.Version <> 1 And Site1.Version <> 2 Then
                Select Case Trim(Langue)
                    Case "A"
                        MsgBox("erroneous licence key")
                    Case "F"
                        MsgBox("Clé de licence erronée")
                End Select
                End
            End If
            '##Produit########################################################
            Site1.produit = IIf(Mid(TempoRec("scf_nlicense").Value, 2, 1) <> "", Mid(TempoRec("scf_nlicense").Value, 2, 1), "")
            ' Produit = 1
            If Site1.produit <> CDbl("1") Then
                'Message Chr(13) & "Fatal Error," & Chr(13) & "Activation key problem ... Please contact software supplier ...!", 16
                Message(Chr(13) & MLangue("1617") & Chr(13) & MLangue("1870") & " ..." & MLangue("1619") & " ...!", 16)
                End
            End If

            '##Code Site########################################################

            Site1.CodeSite = IIf(Mid(TempoRec("scf_nlicense").Value, 3, 2) <> "", Mid(TempoRec("scf_nlicense").Value, 3, 2), "")
            Site1.NBreCarte = IIf(Mid(TempoRec("scf_nlicense").Value, 5, 3) <> "", Val("&H" & Mid(TempoRec("scf_nlicense").Value, 5, 3)) * 5000, "")

            '##Date Fin########################################################
            Select Case Mid(TempoRec("scf_nlicense").Value, 14, 1)
                Case "A"
                    Site1.DateFin = IIf(Mid(TempoRec("scf_nlicense").Value, 12, 3) <> "000", "10/" & Mid(TempoRec("scf_nlicense").Value, 12, 3), "*")
                Case "B"
                    Site1.DateFin = IIf(Mid(TempoRec("scf_nlicense").Value, 12, 3) <> "000", "11/" & Mid(TempoRec("scf_nlicense").Value, 12, 3), "*")
                Case "C"
                    Site1.DateFin = IIf(Mid(TempoRec("scf_nlicense").Value, 12, 3) <> "000", "12/" & Mid(TempoRec("scf_nlicense").Value, 12, 3), "*")
                Case Else
                    Site1.DateFin = IIf(Mid(TempoRec("scf_nlicense").Value, 12, 3) <> "000", Mid(TempoRec("scf_nlicense").Value, 12, 1) & "/" & Mid(TempoRec("scf_nlicense").Value, 13, 2), "*")
            End Select

            If Site1.Version <> 2 Then
                If IIf(Format("01/" & Site1.DateFin, "DD/MM/YY") < Format(GetDate, "DD/MM/YY"), False, True) Then
                    'Message Chr(13) & MLangue("1617") & Chr(13) & MLangue("1870") & " ..." & MLangue("1619") & " ...!", 16
                    Select Case Trim(Langue)
                        Case "A"
                            MsgBox("Periode d'essai de Magix a expiré")
                        Case "F"
                            MsgBox("Probation period of Magix expired")
                    End Select
                    End
                End If
            End If

            '##MultiDevise########################################################

            Site1.MultiDevise = IIf(Mid(TempoRec("scf_nlicense").Value, 17, 1) <> "", Val(Mid(TempoRec("scf_nlicense").Value, 17, 1)), "")
            'MultiDevise = 0 ou 1
            If Site1.MultiDevise <> 0 And Site1.MultiDevise <> 1 Then
                Select Case Trim(Langue)
                    Case "A"
                        MsgBox("erroneous licence key")
                    Case "F"
                        MsgBox("Clé de licence erronée")
                End Select
                End
            End If

            '##NbreUser########################################################

            Site1.NbreUser = IIf(Mid(TempoRec("scf_nlicense").Value, 19, 1) <> "", Val("&H" & Mid(TempoRec("scf_nlicense").Value, 19, 1)) * 5, "")
        End With
    End Function




    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : SelectedBankSerial()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub SelectedBankSerial()

        SQLCode = "SELECT scf_nlicense,scf_kactivat FROM siteconf"
        sError = ""
        TempoRec = ReturnRecordset(SQLCode, , , sError)
        If TempoRec Is Nothing Then
            Message(sError, 16)
            Exit Sub
        End If
        If Not TempoRec.EOF Then
            SerialNumber = NullOK(TempoRec("scf_nlicense").value)
            ActivationKey = NullOK(TempoRec("scf_kactivat").value)
        End If

        SQLCode = "SELECT pac_libelle FROM parcentre"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Sub
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If Not TempoRec.EOF Then
            BankName = NullOK(TempoRec("pac_libelle").value)
        End If

        SQLCode = "SELECT opr_prenom,opr_nom FROM operateur WHERE opr_code ='" & ChaineOK(CodeOperatrice) & "'"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Sub
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If Not TempoRec.EOF Then
            OperatorName = NullOK(TempoRec("opr_prenom").value) & " " & NullOK(TempoRec("opr_nom").value)
        Else
            OperatorName = CodeOperatrice & " " & CodeOperatrice
        End If

    End Sub


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Get_Champs()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Get_Champs(ByRef msg_input As Object, ByRef Longueur As Short, ByRef CODE As String) As String

        Dim Lg_msg As String
        Dim Code_msg As Object

        Get_Champs = ""
        Lg_msg = ""
        Trouve = False
        I = 1
        Do
            Code_msg = Mid(msg_input, I, 3)
            Lg_msg = Mid(msg_input, I + 3, 3)
            If FormatCode(CODE, 3) = Code_msg Then
                Get_Champs = Mid(msg_input, I + 6, CInt(Lg_msg))
                Trouve = True
            Else
                I = I + 6 + Val(Lg_msg)
            End If
        Loop Until Trouve = True Or I > Longueur
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Format_Trame_Date()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Code:code champs,Longueur : Longueur du champs, Valeur : valuer du champs
    '#!#F#                Output parameters   : La trame sous format voulu
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Formate la trame selon le protocole (Code,Longuer,valeur)
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Format_Trame_Date(ByRef CODE As String, ByRef Longueur As String, ByRef Valeur As Object) As String

        Dim var As Byte
        CODE = FormatCode(CODE, 3)
        Longueur = FormatCode(Longueur, 3)
        Format_Trame_Date = CODE & Longueur & Valeur
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Format_Trame()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Code:code champs,Longueur : Longueur du champs, Valeur : valuer du champs
    '#!#F#                Output parameters   : La trame sous format voulu
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Formate la trame selon le protocole (Code,Longuer,valeur)
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Format_Trame(ByRef CODE As String, ByRef Longueur As String, ByRef Valeur As String) As String
        Dim var As Byte

        CODE = FormatCode(CODE, 3)
        Longueur = FormatCode(Longueur, 3)
        var = CByte(Longueur)
        Valeur = FormatCode(Valeur, var)
        Format_Trame = CODE & Longueur & Valeur
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : SetServerDate()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Modifie la date (elle prend la valeur du date du Serrveur)
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub SetServerDate()

        SQLCode = "SELECT to_char(sysdate,'DD/MM/YYYY') FROM dual"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Sub
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If Not TempoRec.EOF Then
            Today = DateValue(TempoRec.Item(0).Value)
        End If
    End Sub


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : SetServerTime()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Modifie l'heure (elle prend la valeur du l'heure du Serrveur)
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub SetServerTime()

        Dim Dt As Short
        Dim StrTime As String

        SQLCode = "SELECT to_char(sysdate,'HH24:MI:SS') as time FROM dual"
        StrTime = CStr(TimeOfDay)
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Sub
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If Not TempoRec.EOF Then
            Dt = Second(System.DateTime.FromOADate(TimeValue(StrTime).ToOADate - TimeOfDay.ToOADate))
            TimeOfDay = System.DateTime.FromOADate(TimeValue(TempoRec.Item(0).Value).ToOADate + TimeSerial(0, 0, Dt + 1).ToOADate)
        End If
    End Sub


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : GetDate()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function GetDate() As Date
        Dim TempoRec As Object
        SQLCode = "SELECT (to_char(sysdate, 'DD/MM/YYYY')) as sDate FROM dual"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                GetDate = Today
                Exit Function
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If Not TempoRec.EOF Then
            GetDate = CDate(DateValue(TempoRec(0).Value.ToString))
        Else : GetDate = Today
        End If

    End Function
    Public Function GetDateTime() As String
        Dim TempoRec As Object
        SQLCode = "SELECT (to_char(sysdate, 'DD/MM/YYYY HH24:mm:ss')) as sDate FROM dual"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                GetDateTime = Now
                Exit Function
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If Not TempoRec.EOF Then
            GetDateTime = (((TempoRec(0).Value.ToString)))
        Else : GetDateTime = Now
        End If

    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : GetTime()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function GetTime() As Date

        Dim Dt As Short
        Dim StrTime As String

        SQLCode = "SELECT to_char(sysdate,'HH24:MI:SS') as time FROM dual"
        StrTime = CStr(TimeOfDay)
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                GetTime = TimeOfDay.Now
                Exit Function
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If Not TempoRec.EOF Then
            Dt = Second(System.DateTime.FromOADate(TimeValue(StrTime).ToOADate - TimeOfDay.ToOADate))
            GetTime = System.DateTime.FromOADate(TimeValue(TempoRec("time").Value).ToOADate + TimeSerial(0, 0, Dt + 1).ToOADate)
        Else : GetTime = TimeOfDay.Now
        End If
    End Function
    Public Sub LoadLangue(ByRef Frm As System.Windows.Forms.Form, Optional ByVal MenuT As System.Windows.Forms.ContextMenu = Nothing)
        '
        Try
            Dim Ctl As System.Windows.Forms.Control
            Dim CtlType As String
            Dim x As String
            Dim Obj As Object

            'Dim mnu As System.Windows.Forms.MainMenu = Frm.MainMenu1

            Dim Ctl1 As System.Windows.Forms.Control
            Dim Ctl2 As System.Windows.Forms.Control
            Dim Ctl3 As System.Windows.Forms.Control
            Dim Ctl4 As System.Windows.Forms.Control
            Dim Ctl5 As System.Windows.Forms.Control
            Dim Ctl6 As System.Windows.Forms.Control
            Dim Ctl7 As System.Windows.Forms.Control
            Dim Ctl8 As System.Windows.Forms.Control

            For Each Ctl In Frm.Controls

                CtlType = TypeName(Ctl)
                langueL(Ctl)
                For Each Ctl1 In Ctl.Controls
                    CtlType = TypeName(Ctl1)
                    langueL(Ctl1)
                    For Each Ctl2 In Ctl1.Controls
                        CtlType = TypeName(Ctl2)
                        langueL(Ctl2)
                        For Each Ctl3 In Ctl2.Controls
                            CtlType = TypeName(Ctl3)
                            langueL(Ctl3)
                            For Each Ctl4 In Ctl3.Controls
                                CtlType = TypeName(Ctl4)
                                langueL(Ctl4)
                                For Each Ctl5 In Ctl4.Controls
                                    CtlType = TypeName(Ctl5)
                                    langueL(Ctl5)
                                    For Each Ctl6 In Ctl5.Controls
                                        CtlType = TypeName(Ctl6)
                                        langueL(Ctl6)
                                        For Each Ctl7 In Ctl6.Controls
                                            CtlType = TypeName(Ctl7)
                                            langueL(Ctl7)
                                            For Each Ctl8 In Ctl7.Controls
                                                CtlType = TypeName(Ctl8)
                                                langueL(Ctl8)
                                            Next
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next

            Next Ctl

            If (Frm.Menu Is Nothing) Then
            Else
                Con_Menu(Frm.Menu)
            End If

            If MenuT Is Nothing Then
            Else
                Con_Menu(MenuT)
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Con_Menu(ByVal mnu As System.Windows.Forms.Menu)
        Dim mnuItem As System.Windows.Forms.MenuItem
        Dim xs As String
        For Each mnuItem In mnu.MenuItems
            xs = mnuItem.Text
            If IsNumeric(mnuItem.Text) Then
                If (mnuItem.Text <> "-") Then
                    mnuItem.Text = MLangue(CInt(mnuItem.Text))
                End If
            End If
            If mnuItem.MenuItems.Count > 0 Then
                Con_Menu(mnuItem)
            End If
        Next
    End Sub


    Public Sub langueL(ByVal Ctl As System.Windows.Forms.Control)
        Try
            Dim CtlType As String
            Dim code As String

            CtlType = TypeName(Ctl)
            Select Case CtlType
                Case "Label"
                    code = Ctl.Tag
                    If Ctl.Tag <> "" Then
                        If Mid(code, 1, 1) = "$" Then
                            code = Mid(code, 2)
                            Ctl.Text = MLangue(code)
                        Else
                            Ctl.Text = MLangue(code) & " :"
                        End If
                    End If
                Case "AGroup", "GroupBox"
                    code = Ctl.Tag
                    If Ctl.Tag <> "" Then
                        If Mid(code, 1, 1) = "$" Then
                            code = Mid(code, 2)
                            Ctl.Text = "    " & MLangue((code))
                        Else
                            Ctl.Text = MLangue((code))
                        End If
                    End If
                Case "CommandButton", "Button"
                    If Ctl.Tag <> "" Then Ctl.Text = MLangue((Ctl.Tag))
                    If IsNumeric(Ctl.Tag) Then Ctl.Text = MLangue((Ctl.Tag))
                Case "OptionButton", "Frame"
                    If Ctl.Tag <> "" Then Ctl.Text = MLangue((Ctl.Tag)) '& " :"
                Case "CheckBox"
                    If Ctl.Tag <> "" Then Ctl.Text = MLangue((Ctl.Tag))
                Case "TabControl"
                    Con_tab(Ctl)
                Case "TBoutton", "SBoutton", "RBoutton"
                    If Ctl.Tag <> "" Then Ctl.Text = MLangue((Ctl.Tag))
                Case "AxToolbar"
                    Con_ToolBar(Ctl)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub Con_tab(ByVal Ctl As Windows.Forms.TabControl)
        Try
            For J = 0 To Ctl.TabCount - 1
                Ctl.TabPages(J).Text = MLangue(Ctl.TabPages(J).Text)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Con_ToolBar(ByVal Ctl As ToolBar)
        Dim Obj As Windows.Forms.Control
        Try

            For Each Obj In Ctl.Controls()
                If Trim(Obj.Tag) <> "" Then Obj.Text = MLangue(Obj.Tag)
            Next Obj
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function MLangue(ByRef Code As String) As String
        Try
            Dim Ctl As System.Windows.Forms.Control
            Dim MCode As String
            Dim Changer As Boolean

            MCode = Trim(Code)

            If Mid(MCode, 1, 1) = "*" Then
                If Language = 2000 Then Changer = True
                MCode = Mid(MCode, 2)
            End If
            If Val(MCode) = 0 Then
                MLangue = MCode
            ElseIf Len(MCode) <= 4 Then
                Dim x As String
                MLangue = rm.GetString(CShort(CDbl(MCode) + Language))
            ElseIf Len(MCode) <= 8 Then
                If Changer Then
                    MLangue = rm.GetString(CShort(CDbl(Mid(MCode, 5, 4)) + Language)) & " " & rm.GetString(CShort(CDbl(Mid(MCode, 1, 4)) + Language))
                Else
                    MLangue = rm.GetString(CShort(CDbl(Mid(MCode, 1, 4)) + Language)) & " " & rm.GetString(CShort(CDbl(Mid(MCode, 5, 4)) + Language))
                End If
            ElseIf Len(MCode) <= 12 Then
                MLangue = rm.GetString(CShort(CDbl(Mid(MCode, 1, 4)) + Language)) & " " & rm.GetString(CShort(CDbl(Mid(MCode, 5, 4)) + Language)) & " " & rm.GetString(CShort(CDbl(Mid(MCode, 9, 4)) + Language))
            End If
        Catch ex As Exception
            MsgBox("MLANGUE(): " & ex.Message)
        End Try
    End Function




    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : ChangeLangue()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub ChangeLangue(ByRef Lang As String)

        Select Case Trim(Lang)
            Case "A"
                Language = 0
                StrEtat(1) = "Add"            'Operations Utilisées
                StrEtat(2) = "Update"
                StrEtat(3) = "Delete"
                StrEtat(4) = "Validate"
                StrEtat(5) = "Search (% : Generator)"
            Case "F"
                Language = 2000
                StrEtat(1) = "Ajout"            'Operations Utilisées
                StrEtat(2) = "Modification"
                StrEtat(3) = "Suppression"
                StrEtat(4) = "Validation"
                StrEtat(5) = "Recherche (% : Générateur)"
        End Select
    End Sub


    '#!#F#                Function            : SQLOpen()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Connection, SqlCode, Connect, DeConnect
    '#!#F#                Output parameters   : Cursseur RdoResultSet
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function SQLOpen(ByRef SQL As String) As Object
        '
        Dim Debut As System.Windows.Forms.Label
        '
Debut:
        On Error Resume Next

        SQLOpen = ReturnRecordset(SQL)

        If Err.Number Then
            'If MsgBox(Error$(Err) & " - " & Err & vbCr & vbCr _
            '& MLangue("1208"), vbYesNo + vbCritical, "MAGIX") = vbYes Then
            Message(ErrorToString(Err.Number) & " - " & Err.Number, 16)
            End

        End If
        '
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : ActionBase(tableacces(page).code,)
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : N° De Page, Etat De La Page, Code Enregistrement
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Enregistre Les Action Faites Par L'Opérateur Sur La Base
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub ActionBase(ByRef CODE As String, ByRef Etat As Byte, ByRef RecordCode As String)

        Dim Menu As String
        Dim Screen As String
        Dim Operation As String
        '
        '
        Menu = CODE
        Screen = CODE
        Select Case Etat
            Case 1
                Operation = "C"
            Case 2
                Operation = "M"
            Case 4
                Operation = "D"
            Case 5
                Operation = "V"
        End Select

        Dim strIPAddress As String
        strIPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(0).ToString()

        SQLCode = " INSERT INTO ACTIONBASE (acb_operateur,acb_menu," _
        & " acb_ecran,acb_date,acb_heure,acb_typoper,acb_codenreg,acb_ip)" _
        & " VALUES ('" & NullOK(CodeOperatrice) & "','" _
        & NullOK(Menu) & "','" & NullOK(Screen) & "',GETDATE(),'" _
        & Format(CDate(TimeOfDay), "HH:mm") & "','" _
        & NullOK(Operation) & "','" & "AGC!" & NullOK(RecordCode) & "','" & strIPAddress & "')"

        executeNonQuery(SQLCode)

    End Sub


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Generer_NumSeq()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Generer_NumSeq(ByRef Type0 As String) As String

        Dim Valeur As Short

        SQLCode = "SELECT * FROM numsequence WHERE nsq_code ='" & Type0 & "'"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Function
            End If
        Else
            TempoRec = SQLOpen(SQLCode)
        End If
        With TempoRec
            If .EOF Then
                Generer_NumSeq = "000000000001"
            Else
                If Val(NullOK(TempoRec("nsq_nocour").value.ToString)) >= Val(NullOK(TempoRec("nsq_nomax").value.ToString)) Then
                    Generer_NumSeq = NullOK(TempoRec("nsq_nomin").value.ToString)
                Else
                    Generer_NumSeq = CStr(Val(NullOK(TempoRec("nsq_nocour").value.ToString)) + 1)
                End If
            End If
        End With
    End Function
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Controle_Carte()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Controle_Carte(ByRef NumeroCarte As String) As Boolean

        Dim w_indice As Short
        Dim w_unite As Short
        Dim w_nchiffre As Short
        Dim w_nbrsaisie As Short
        Dim w_nbrcalcule As Short
        Dim w_nbrresultat As Short
        Dim Trouve As Boolean
        Dim W_NbrChfCarte As Short

        W_NbrChfCarte = Len(NumeroCarte)
        w_indice = W_NbrChfCarte
        For I = 1 To W_NbrChfCarte
            If Mid(NumeroCarte, I, 1) = "?" Then Exit For
        Next I
        W_NbrChfCarte = I - 1


        w_unite = 2
        w_nchiffre = 0
        w_nbrsaisie = 0
        w_nbrcalcule = 0
        w_nbrresultat = 0

        w_indice = W_NbrChfCarte - 1

        vControle_Carte = False

        If w_indice < 2 Then
            Controle_Carte = False
            Exit Function
        End If
        While w_indice > 0

            If Not IsNumeric(Mid(NumeroCarte, W_NbrChfCarte, 1)) Then
                Controle_Carte = False
                vControle_Carte = True
                Exit Function
            End If

            If Not IsNumeric(Mid(NumeroCarte, w_indice, 1)) Then
                Controle_Carte = False
                vControle_Carte = True
                Exit Function
            End If

            w_nchiffre = CShort(Mid(NumeroCarte, w_indice, 1))
            w_nchiffre = w_nchiffre * w_unite
            If w_nchiffre >= 10 Then
                w_nbrcalcule = w_nbrcalcule + w_nchiffre - 9
            Else
                w_nbrcalcule = w_nbrcalcule + w_nchiffre
            End If
            If w_unite = 1 Then
                w_unite = 2
            Else
                w_unite = 1
            End If
            w_indice = w_indice - 1
        End While
        w_nchiffre = CShort(Mid(NumeroCarte, W_NbrChfCarte, 1))
        w_nbrsaisie = w_nbrcalcule \ 10
        w_nbrsaisie = (w_nbrsaisie + 1) * 10
        w_nbrresultat = w_nbrsaisie - w_nbrcalcule
        If w_nbrresultat = 10 Then
            w_nbrresultat = 0
        End If
        If w_nbrresultat <> w_nchiffre Then
            Controle_Carte = False
        Else
            Controle_Carte = True
        End If
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : G_Cotisation_Prp_U()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : num_carte:numero de carte, Fees_code:code frais
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Genere les frais pour porteur
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Function G_Cotisation_Prp_U(ByRef NumCarte As String, ByRef Fees_Code As String) As Object

        '_______________________________

        Dim W_NumOpr As String
        Dim RdoReduicart As Object
        Dim DParCentre As Object
        Dim DTva As Object
        Dim Cpe_Montant As String
        Dim V_Compsetabp_cpe_MntSrc As String
        Dim Quit As Boolean
        '_______________________________

        Dim V_Prpcotisat_Pco_CodBqe As String
        Dim V_Prpcotisat_Pco_Montant As String
        Dim V_Prpcotisat_Pco_Tva As String
        Dim V_Prpcotisat_Pco_RibDeb As String
        Dim V_Prpcotisat_Pco_BqeDeb As String
        Dim V_Prpcotisat_Pco_Date As String
        Dim V_Prpcotisat_Pco_Origine As String
        Dim V_Prpcotisat_Pco_NumOpr As String
        Dim V_Prpcotisat_Pco_Present As String
        Dim V_Prpcotisat_Pco_NumCarte As String
        Dim V_Prpcotisat_Pco_DatVal As String
        '_______________________________

        Dim V_Fraisport_frp_TypCrt As String
        Dim V_Fraisport_frp_Code As String
        Dim V_Fraisport_frp_Taux As String
        Dim V_Fraisport_frp_Fixe As String
        Dim V_Fraisport_frp_Forfait As String
        Dim V_Fraisport_frp_Periode As String
        '_______________________________

        Dim Newday As String
        Dim W_Mnttva As String
        Dim W_Mntprp As String
        Dim W_Mntttl As String
        Dim W_Mntetp As String
        Dim V_TypDebit As String
        '_______________________________
        Dim AZ_Montant As String

        SQLCode = " SELECT prp_numcarte,prp_typcrt,prp_codbqe,prp_syspay,prp_ribport," & " frp_typcrt,frp_code,frp_taux,frp_fixe,frp_forfait,frp_periode" & " FROM porteurs,fraisport" & " WHERE frp_typcrt = prp_typcrt" & " AND frp_code = '" & Trim(Fees_Code) & "'" & " AND prp_numcarte = '" & Trim(NumCarte) & "'" & " AND prp_test = 'N'"
        RdoPorteurs = SQLOpen(SQLCode)
        If RdoPorteurs.EOF Then Exit Function

        SQLCode = "SELECT * FROM parcentre"
        DParCentre = SQLOpen(SQLCode)

        SQLCode = "SELECT * FROM tva"
        DTva = SQLOpen(SQLCode)
        Newday = InsertDate(CStr(GetDate()))
        W_Mntttl = CStr(0)


        SQLCode = "SELECT jop_numopr FROM jonopr" & " WHERE jop_origine ='CTP'"
        TempoRec = SQLOpen(SQLCode)
        If TempoRec.EOF Then
            W_NumOpr = CStr(0)
            SQLCode = "INSERT INTO jonopr (jop_numopr,jop_origine,jop_nomax)" & " VALUES (0,'CTP',9999999999999)"
            SQLExecute((SQLCode)) '
            W_NumOpr = CStr(1)
        Else
            If Val(NullOK(TempoRec("jop_numopr").value.ToString())) > 9999999999999.0# Then W_NumOpr = CStr(0)
            W_NumOpr = CStr(Val(NullOK(TempoRec("jop_numopr").value.ToString())) + 1)
        End If
        If IsDBNull(RdoPorteurs("prp_ribport").Value) Then
            V_Prpcotisat_Pco_Present = "7"
        Else
            V_Prpcotisat_Pco_Present = "0"
        End If
        With RdoPorteurs
            V_Prpcotisat_Pco_NumOpr = "CTP" & FormatCode(W_NumOpr, 13)
            V_Prpcotisat_Pco_CodBqe = NullOK(RdoPorteurs("Prp_CodBqe").value.ToString())
            V_Prpcotisat_Pco_RibDeb = NullOK(RdoPorteurs("prp_ribport").value.ToString())
            V_Prpcotisat_Pco_BqeDeb = NullOK(RdoPorteurs("Prp_CodBqe").value.ToString())
            V_Prpcotisat_Pco_NumCarte = NullOK(RdoPorteurs("Prp_NumCarte").value.ToString())

            V_Prpcotisat_Pco_Origine = NullOK(Fees_Code)

            If Fees_Code = "507" Then
                V_Prpcotisat_Pco_Date = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, 1, GetDate))
            Else
                V_Prpcotisat_Pco_Date = InsertDate(NullOK(GetDate))
            End If

            V_Prpcotisat_Pco_DatVal = Get_Datval_Frais(RdoPorteurs("Prp_TypCrt").Value.ToString(), V_Prpcotisat_Pco_Date)

            W_Mntttl = CStr(Val(NullOK(RdoPorteurs("frp_fixe").value.ToString())))
        End With
        If Val(W_Mntttl) > 0 Then
            W_Mntetp = "0"
            W_Mntprp = W_Mntttl

            SQLCode = " SELECT * FROM reduitcart,etapayeur" & " WHERE ('" & Newday & "' BETWEEN rdc_datdeb AND rdc_datfin)" & " AND rdc_numcarte = '" & NullOK(RdoPorteurs("Prp_NumCarte").value.ToString()) & "'" & " AND rdc_code = '" & Trim(Fees_Code) & "'" & " AND etp_code = rdc_etabp" & " ORDER BY rdc_datdeb"
            If TestConn Then
                sError = ""
                RdoReduicart = ReturnRecordset(SQLCode, , , sError)
                If RdoReduicart Is Nothing Then
                    Message(sError, 16)
                    Exit Function
                End If
            Else
                RdoReduicart = ReturnRecordset(SQLCode)
            End If
            With RdoReduicart
                Quit = False
                While Not .EOF And Not Quit
                    V_Prpcotisat_Pco_Origine = NullOK(RdoPorteurs("frp_code").value.ToString())
                    If CDbl(W_Mntprp) > 0 Then
                        V_Prpcotisat_Pco_RibDeb = NullOK(RdoReduicart("etp_compte").value.ToString())
                        V_Prpcotisat_Pco_BqeDeb = NullOK(RdoReduicart("etp_banque").value.ToString())
                        V_Prpcotisat_Pco_Montant = CStr(CDbl(W_Mntttl) * Val(NullOK(RdoReduicart("rdc_taux").value.ToString())) / 100)
                        If Val(V_Prpcotisat_Pco_Montant) > Val(W_Mntprp) Then V_Prpcotisat_Pco_Montant = W_Mntprp
                        V_Prpcotisat_Pco_Tva = CStr(Val(V_Prpcotisat_Pco_Montant) * Val(DTva("tva_CotiTaux").Value.ToString()) / 100)
                        V_Prpcotisat_Pco_NumOpr = "CTP" & FormatCode(W_NumOpr, 13)

                        SQLCode = "INSERT INTO prpcotisat (pco_codbqe,pco_numcarte,pco_montant," & " pco_tva,pco_ribdeb,pco_bqedeb,pco_date,pco_origine," & " pco_numopr,pco_present)" & " VALUES ('" & V_Prpcotisat_Pco_CodBqe & "','" & NullOK(RdoPorteurs("Prp_NumCarte").value.ToString()) & "'," & Val(V_Prpcotisat_Pco_Montant) & "," & Val(V_Prpcotisat_Pco_Tva) & ",'" & V_Prpcotisat_Pco_RibDeb & "','" & V_Prpcotisat_Pco_BqeDeb & "','" & InsertDate(NullOK(V_Prpcotisat_Pco_Date)) & "','" & Trim(Fees_Code) & "','" & V_Prpcotisat_Pco_NumOpr & "','1')"
                        SQLExecute((SQLCode)) '

                        V_TypDebit = W_TypDebit

                        SQLCode = "INSERT INTO compsetabp (cpe_codetab,cpe_origine,cpe_modregl," & " cpe_bqepor,cpe_bqecpt,cpe_numcpt,cpe_lien,cpe_dattrait," & " cpe_datval,cpe_montant,cpe_devise,cpe_numopr,cpe_present," & " cpe_numcarte,cpe_mntsrc,cpe_tauxred)" & " VALUES('" & NullOK(RdoReduicart("etp_code").value.ToString()) & "','" & Trim(Fees_Code) & "','" & NullOK(RdoReduicart("etp_modregl").value.ToString()) & "','" & NullOK(RdoPorteurs("Prp_CodBqe").value.ToString()) & "','" & NullOK(RdoReduicart("etp_banque").value.ToString()) & "','" & NullOK(RdoReduicart("etp_compte").value.ToString()) & "','" & NullOK(RdoReduicart("etp_lien").value.ToString()) & "','" & InsertDate(NullOK(GetDate)) & "','" & InsertDate(NullOK(V_Prpcotisat_Pco_DatVal)) & "'," & Val(Cpe_Montant) & ",'" & NullOK(RdoReduicart("etp_devise").value.ToString()) & "','" & V_Prpcotisat_Pco_NumOpr & "','0','" & NullOK(RdoPorteurs("Prp_NumCarte").value.ToString()) & "'," & Val(V_Compsetabp_cpe_MntSrc) & "," & Val(RdoReduicart("rdc_taux").value.ToString()) & ")"
                        SQLExecute((SQLCode)) '

                        W_Mntetp = CStr(Val(W_Mntetp) + Val(V_Prpcotisat_Pco_Montant))
                        W_Mntprp = CStr(Val(W_Mntprp) - Val(V_Prpcotisat_Pco_Montant))
                        W_NumOpr = CStr(Val(W_NumOpr) + 1)
                    Else
                        Quit = True
                    End If
                    .MoveNext()
                    V_Prpcotisat_Pco_RibDeb = ""
                    V_Prpcotisat_Pco_BqeDeb = ""
                End While
                If (CDbl(W_Mntprp) > 0) Then
                    V_Prpcotisat_Pco_NumOpr = "CTP" & FormatCode(W_NumOpr, 13)
                    AZ_Montant = CStr(0)
                    If Not DTva.EOF Then
                        AZ_Montant = CStr(Val(V_Prpcotisat_Pco_Montant) * Val(NullOK(DTva("tva_CotiTaux").value.ToString())) / 100)
                    End If
                    SQLCode = "INSERT INTO prpcotisat (pco_codbqe,pco_numcarte,pco_montant," & " pco_tva,pco_ribdeb,pco_bqedeb,pco_date,pco_origine," & " pco_numopr,pco_present)" & " VALUES ('" & Trim(V_Prpcotisat_Pco_CodBqe) & "','" & NullOK(RdoPorteurs("Prp_NumCarte").value.ToString()) & "'," & Val(W_Mntprp) & "," & Replace(AZ_Montant, ",", ".", 1, 1) & ",'" & NullOK(RdoPorteurs("prp_ribport").value.ToString()) & "','" & NullOK(RdoPorteurs("Prp_CodBqe").value.ToString()) & "','" & InsertDate(NullOK(V_Prpcotisat_Pco_Date)) & "','" & Trim(Fees_Code) & "','" & Trim(V_Prpcotisat_Pco_NumOpr) & "','0')"
                    SQLExecute((SQLCode)) '
                End If
            End With
        End If

        SQLCode = "UPDATE jonopr SET jop_numopr = " & Val(W_NumOpr) & " WHERE jop_origine = 'CTP'"
        SQLExecute((SQLCode))

    End Function




    Public Function executeNonQuery(ByVal Sqlcode As String) As Integer

        Try
            Dim p_sqlCommand As New SqlCommand
            Dim result As Integer = 0
            P_conSqlServer = New SqlConnection("Server=" & ServerIP & "; Database=" & dataSource_BO & " ;User Id=" & CodeOperatrice & ";Password=" & MotPasse)
            P_conSqlServer.Open()

            p_sqlCommand = New SqlCommand(Sqlcode, P_conSqlServer)

            result = p_sqlCommand.ExecuteNonQuery

            P_conSqlServer.Close()
            Return result
        Catch ex As Exception
            MsgBox("Erreur d'accès à la base de données")
            Return Nothing
        Finally
            P_conSqlServer.Close()
        End Try


    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Control_Lg_Porteur()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Control_Lg_Porteur(ByRef NumeroCarte As String) As String

        Dim W_NbrChfCarte As Short

        W_NbrChfCarte = Len(NumeroCarte)
        Control_Lg_Porteur = NumeroCarte
        If W_NbrChfCarte < 19 Then
            Control_Lg_Porteur = NumeroCarte & Mid("????????????????????", 1, 19 - W_NbrChfCarte)
        End If
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Exists_Row1()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Exists_Row1(ByRef table As String, ByRef Champs As String, ByRef Valeur As String) As Boolean

        SQLCode = "SELECT * FROM " & Trim(table) & " WHERE " & Trim(Champs) & "='" & Trim(Valeur) & "'"
        TempoRec = SQLOpen(SQLCode)
        Exists_Row1 = Not TempoRec.EOF
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Calcul_Date()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : cal_date : date, nfix_jour: Nombre jour
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Retourne la date valeur des frais
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Function Calcul_Date(ByRef cal_date As Date, ByRef nfix_jour As Short) As String

        Dim chn_date As String

        If DateDiff(Microsoft.VisualBasic.DateInterval.Day, System.DateTime.FromOADate(nfix_jour), GetDate) < 0 Then
            chn_date = Format(nfix_jour, "dd") & "/" & Format(cal_date, "mm") & "/" & Format(cal_date, "yyyy")
        Else
            If CDbl(Format(cal_date, "mm")) < 12 Then
                chn_date = Format(nfix_jour, "dd") & "/" & DateAdd(Microsoft.VisualBasic.DateInterval.Month, CDbl(Format(cal_date, "mm")), System.DateTime.FromOADate(1)) & "/" & Format(cal_date, "yyyy")
            Else
                chn_date = "01" & "/" & Format(cal_date, "mm") & "/" & DateAdd(Microsoft.VisualBasic.DateInterval.DayOfYear, CDbl(Format(cal_date, "yyyy")), System.DateTime.FromOADate(1))
            End If
        End If
        Calcul_Date = chn_date
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Ctrl_Longueur()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Ctrl_Longueur(ByRef Champ As Object, ByRef Longueur As Object) As String

        Champ = Trim(Champ)
        If Len(Champ) < Longueur Then
            Champ = Mid("00000000000000000000000000000000", 1, Longueur - Len(Champ)) & Champ
        End If
        Ctrl_Longueur = Champ
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Ctrl_Suppr()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Ctrl_Suppr(ByRef Col1 As String, ByRef Col2 As String, ByRef NomTable As Object) As Boolean

        Ctrl_Suppr = True
        SQLCode = "SELECT * FROM " & Trim(NomTable) & " WHERE " & Trim(Col2) & " LIKE '" & Trim(Col1) & "'"
        TempoRec = SQLOpen(SQLCode)
        If TempoRec.EOF Then Ctrl_Suppr = False
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Chek_Compte()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : w_numcompte :numero de compte, w_Banque :code banque
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters : Vrai ou Faux
    '#!#F#                Description         : Function pour controler le numero de compte pour IPB
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Function Chek_Compte(ByRef w_numcompte As String, ByRef w_banque As String, ByRef w_CodAgence As String, ByRef w_CleRib As String) As Object

        Dim w_resultat As Boolean
        Dim Y As Short
        Dim Z As Short
        Dim I As Short
        Dim T As Short

        Y = 0
        Z = 0
        w_resultat = True

        SQLCode = "SELECT BQE_ALGACCOUNT FROM banque" & " WHERE bqe_code LIKE '" & ChaineOK(w_banque) & "'"
        TempoRec = SQLOpen(SQLCode)

        If TempoRec.EOF Then
            CodErreur = True
            Chek_Compte = False
            Exit Function
        End If

        Select Case TempoRec("BQE_ALGACCOUNT").Value

            Case "00"
                Chek_Compte = True

            Case "02"

                If Len(Trim(w_numcompte)) <> 16 Then
                    w_resultat = False
                    Exit Function
                End If

                For I = 1 To 6
                    Y = Y + CDbl(Mid(w_numcompte, I, 1)) * (2 ^ (6 - I))
                Next I

                For I = 1 To 10
                    Z = Z + CDbl(Mid(w_numcompte, I + 6, 1)) * (2 ^ (10 - I))
                Next I

                If ((Y Mod 11) <> 0) Then
                    w_resultat = False
                End If

                If ((Z Mod 11) <> 0) Then
                    w_resultat = False
                End If


            Case "04" ' POUR autre client à revoir

            Case "11"
                v_CleRib = CleAlgorithme1(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "12"
                v_CleRib = CleAlgorithme2(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "13"
                v_CleRib = CleAlgorithme3(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "14"
                v_CleRib = CleAlgorithme4(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "15"
                v_CleRib = CleAlgorithme5(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "16"
                v_CleRib = CleAlgorithme6(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "17"
                v_CleRib = CleAlgorithme7(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "18"
                v_CleRib = CleAlgorithme8(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "19"
                v_CleRib = CleAlgorithme9(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "20"
                v_CleRib = CleAlgorithme10(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

            Case "21"
                v_CleRib = CleAlgorithme11(w_CodAgence, w_numcompte)
                If v_CleRib <> w_CleRib Then w_resultat = False

        End Select

        Chek_Compte = w_resultat

    End Function
    '###################################################################################"
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : InterogX()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function InterogX(ByRef Chaine As String, ByRef Longueur As Byte) As String

        Dim Chaine0 As String

        Chaine0 = Trim(Chaine)
        InterogX = Chaine0 & CStr(New String("?", Longueur - Len(Chaine0)))
    End Function
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : CleAlgoritme1()
    '#!#F#                Type                : Public                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : permet de generer une cle suivant l'algorithme 1
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function CleAlgorithme1(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object
        Dim reste As Short

        cle = Mid(siege, 2, 5) & racineordinal

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (reste <= 9) Then
            CleAlgorithme1 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme1 = Trim(Str(reste))
        End If

    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : CleAlgorithme2()
    '#!#F#                Type                : Public                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : permet de generer une cle syuivaval l'algorithme 6
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function CleAlgorithme2(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object
        Dim reste As Short
        Dim ordinal As Object
        Dim racine As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)


        cle = Left(racine, 1) & Left(ordinal, 2) & Mid(siege, 2, 5)
        cle = cle & Right(racine, 5) & Right(ordinal, 1)

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme2 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme2 = Trim(Str(reste))
        End If

    End Function
    Public Function CleAlgorithme3(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        If Left(racine, 1) = "0" Then
            'premier caractère de la racine égal à 0 ----> 7 zéro
            cle = "0000000"
            cle = cle & Mid(siege, 2, 5)
            cle = cle & Right(racine, 5)
        Else
            'premier caractère de la racine égal à 0 ----> 6 zéro
            cle = "000000"
            cle = cle & Mid(siege, 2, 5)
            cle = cle & Right(racine, 5)
        End If

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme3 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme3 = Trim(Str(reste))
        End If

    End Function
    Public Function CleAlgorithme4(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        cle = Left(racine, 1) & Left(ordinal, 1)
        cle = cle & Mid(siege, 2, 5)
        cle = cle & Right(racine, 5) & Right(ordinal, 2)

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme4 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme4 = Trim(Str(reste))
        End If

    End Function
    Public Function CleAlgorithme5(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient
        Dim reste As Integer
        Dim racine, ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        cle = w_Banque & Right(siege, 3)
        cle = cle & "0" & Mid(racine, 2, 6) & ordinal & w_devise

        cle = Val(cle) * 100
        quotient = CDbl(cle) / 97
        quotient = Int(quotient)

        reste = 97 - (cle - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme5 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme5 = Trim(Str(reste))
        End If

    End Function
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : CleAlgorithme6()
    '#!#F#                Type                : Public                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : permet de generer une cle syuivaval l'algorithme 6
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function CleAlgorithme6(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object ', reste As Double
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)


        cle = Mid(siege, 2, 1)
        cle = cle & Left(racine, 1) & Left(ordinal, 2)
        cle = cle & Right(siege, 4)
        cle = cle & Right(racine, 5) & Right(ordinal, 1)

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme6 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme6 = Trim(Str(reste))
        End If

    End Function
    Public Function CleAlgorithme7(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        cle = Left(ordinal, 2)
        cle = cle & Mid(siege, 2, 5)
        cle = cle & racine & Right(ordinal, 1)

        quotient = CDbl(Val(cle)) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If reste = 0 Then
            CleAlgorithme7 = "97"
        ElseIf (0 < reste And reste <= 9) Then
            CleAlgorithme7 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme7 = Trim(Str(reste))
        End If

    End Function
    Public Function CleAlgorithme8(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        cle = Left(racine, 1)
        cle = cle & Mid(siege, 2, 5)
        cle = cle & Right(racine, 5) & ordinal

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme8 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme8 = Trim(Str(reste))
        End If

    End Function
    Public Function CleAlgorithme9(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object ', reste As Double
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        cle = Mid(siege, 2, 1)
        cle = cle & Left(ordinal, 1) & Left(racine, 1)
        cle = cle & Right(siege, 4)
        cle = cle & Right(racine, 5) & Right(ordinal, 2)

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme9 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme9 = Trim(Str(reste))
        End If

    End Function
    Public Function CleAlgorithme10(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object ', reste As Double
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        cle = ordinal & Mid(siege, 2, 5) & racine

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme10 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme10 = Trim(Str(reste))
        End If

    End Function

    Public Function CleAlgorithme11(ByRef siege As String, ByRef racineordinal As String) As String

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 9 caracteres

        Dim cle As String
        Dim quotient As Object ', reste As Double
        Dim reste As Short
        Dim racine As Object
        Dim ordinal As String

        racine = Mid(racineordinal, 1, 6)
        ordinal = Mid(racineordinal, 7, 3)

        cle = "000" & Right(siege, 4)
        cle = cle & Right(racine, 5) & Right(ordinal, 2)

        cle = CStr(Val(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        reste = 97 - (CDbl(cle) - (quotient * 97))

        If (0 <= reste And reste <= 9) Then
            CleAlgorithme11 = "0" & Trim(Str(reste))
        Else
            CleAlgorithme11 = Trim(Str(reste))
        End If

    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Ctrl_LongDroit()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Ctrl_LongDroit(ByRef Champ As String, ByRef longeur As Short, ByRef caractere As String) As String

        Dim lg As Short

        lg = Len(Trim(Champ))
        While lg < longeur
            Champ = Champ & caractere
            lg = lg + 1
        End While
        Ctrl_LongDroit = Champ
    End Function

    Public Function Exists_Row2(ByRef table As String, ByRef Champs1 As String, ByRef Valeur1 As String, ByRef Champs2 As String, ByRef Valeur2 As String) As Boolean

        SQLCode = "SELECT * FROM " & Trim(table) & " WHERE " & Trim(Champs1) & "='" & Trim(Valeur1) & "'" & " AND " & Trim(Champs2) & "='" & Trim(Valeur2) & "'"

        TempoRec = SQLOpen(SQLCode)
        Exists_Row2 = Not TempoRec.EOF
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : CleAlgoritme6()
    '#!#F#                Type                : Public                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : permet de generer une cle syuivaval l'algorithme 6
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function CleAlgoritme6(ByRef siege As String, ByRef ordinalracine As String) As Short

        '  siege sur 6  caracteres mais seulement les 5 dernier qui seront traitées
        '  ordinalracine sur 19 caracteres
        Dim cle As String
        Dim quotient As Object
        Dim reste As Double

        cle = Mid(siege, 2, 1) & Mid(ordinalracine, 4, 1) & Mid(ordinalracine, 1, 2)
        cle = cle & Mid(siege, 3, 4) & Mid(ordinalracine, 5, 5) & Mid(ordinalracine, 3, 1)
        cle = CStr(CDbl(cle) * 100)
        quotient = CDbl(cle) / 97
        quotient = Int(CDbl(quotient))

        CleAlgoritme6 = 97 - (CDbl(cle) - (quotient * 97))

    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Ctrl_Suppr()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------


    Public Function Ctrl_Suppr2(ByRef Col1 As String, ByRef Col2 As String, ByRef Col3 As String, ByRef Col4 As String, ByRef NomTable As Object) As Boolean

        Ctrl_Suppr2 = True
        SQLCode = "SELECT count(*) as SCount FROM " & Trim(NomTable) & " WHERE " & Trim(Col2) & " LIKE '" & Trim(Col1) & "'" & " AND " & Trim(Col4) & " LIKE '" & Trim(Col3) & "'"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Ctrl_Suppr2 = False
                Exit Function
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If

        If TempoRec("SCount").Value.ToString = 0 Then Ctrl_Suppr2 = False
    End Function

    Public Function Ctrl_Suppr3(ByRef Col1 As String, ByRef Col2 As String, ByRef Col3 As String, ByRef Col4 As String, ByRef Col5 As String, ByRef Col6 As String, ByRef NomTable As Object) As Boolean

        Ctrl_Suppr3 = True
        SQLCode = "SELECT * FROM " & Trim(NomTable) & " WHERE " & Trim(Col2) & " LIKE '" & Trim(Col1) & "'" & " AND " & Trim(Col4) & " LIKE '" & Trim(Col3) & "'" & " AND " & Trim(Col6) & " LIKE '" & Trim(Col5) & "'"

        TempoRec = SQLOpen(SQLCode)
        If TempoRec.EOF Then Ctrl_Suppr3 = False

    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : ParameterForm()
    '#!#F#                Type                : Local                                    (Local /Public/Global)
    '#!#F#                Input parameters    :Client,Frm
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

    Public Sub ParameterForm(ByRef Client As String, ByRef Frm As System.Windows.Forms.Form, ByRef FramName As String, ByRef continu As Boolean)

        Dim ctl As System.Windows.Forms.Control
        Dim CtlType As String
        Dim NbControl As Short


        SQLCode = " SELECT * FROM parametres " _
                & " WHERE upper(PRM_CLIENT) = '" & UCase(Client) & "'" _
                & " AND upper(PRM_FORMNAME) ='" & UCase(Frm.Name) & "'" _
                & " AND upper(PRM_FRAMENAME) ='" & UCase(FramName) & "'" _
                & " ORDER BY PRM_TYPE "

        TempoRec = ReturnRecordset(SQLCode)

        If TempoRec.EOF Then Exit Sub

        While Not TempoRec.EOF

            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "TTL_VILLE" Then
                Def_TtlVille = IIf(IsDBNull(TempoRec("PRM_DEFAULT").Value.ToString()), "", TempoRec("PRM_DEFAULT").Value.ToString())
            End If

            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "PC2_NUMCOMPTE" Then
                NumCompteBNP = IIf(TempoRec("PRM_MAXLENGTH").Value.ToString() = 9, True, False)
                If Not continu Then Exit Sub
            End If

            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "ETP_COMPTE" Then
                NumCompteBNP_ETP = IIf(TempoRec("PRM_MAXLENGTH").Value.ToString() = 9, True, False)
            End If

            For Each ctl In Frm.Controls
                CtlType = TypeName(ctl)
                Select Case CtlType

                    '##################### Traitement des TextBox #####################'

                Case "TextBox"
                        If ChaineOK((ctl.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "TEXTBOX" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                If ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N" Then
                                    ctl.Enabled = False
                                Else
                                    ctl.Enabled = True
                                End If
                            End If
                            If Not IsDBNull(TempoRec("PRM_REQUIRED").Value.ToString()) Then
                                ctl.Tag = ChaineOK(TempoRec("PRM_REQUIRED").Value.ToString()) ' "O" OR "N"
                            End If
                        End If


                    Case "Label"
                        If ChaineOK((ctl.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString) = "LABEL" Then
                            If Not IsDBNull(TempoRec("PRM_INDEX").Value.ToString()) Then
                            Else
                                If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                    ctl.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                                End If
                                If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                    ctl.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                                End If
                            End If

                        End If

                        '##################### Traitement des CommandButton #####################'

                    Case "CommandButton"
                        If ChaineOK((ctl.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "COMMANDBUTTON" Then
                            If Not IsDBNull(TempoRec("PRM_INDEX").Value.ToString()) Then
                            Else
                                If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                    ctl.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                                End If
                                If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                    ctl.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                                End If
                            End If
                        End If

                        '##################### Traitement des Autres controles #####################'
                    Case "AGroup"
                        ParameterAGroup(NomClient, Frm, ctl, FramName, continu)
                    Case "Panel"
                        ParameterPanel(NomClient, Frm, ctl, FramName, continu)
                    Case "OptionButton"
                    Case "ComboBox"
                        If ChaineOK((ctl.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "COMBOBOX" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                        End If
                    Case "DateTimePicker"
                        If ChaineOK((ctl.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "DATETIMEPICKER" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                        End If
                    Case "Frame"
                    Case "CheckBox"
                    Case "SSTab"
                    Case "Menu"
                    Case "Toolbar"
                    Case "DBGrid"
                End Select
            Next ctl
            If Not TempoRec.EOF Then TempoRec.MoveNext()

        End While

    End Sub

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : ParameterPanel()
    '#!#F#                Type                : Local                                    (Local /Public/Global)
    '#!#F#                Input parameters    :Client,Frm
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


    Public Sub ParameterPanel(ByRef Client As String, ByRef Frm As System.Windows.Forms.Form, ByRef FPanel As System.Windows.Forms.Panel, ByRef FramName As String, ByRef continu As Boolean)

        Dim ctl1 As System.Windows.Forms.Control
        Dim ctl2 As System.Windows.Forms.Control
        Dim ctl3 As System.Windows.Forms.Control
        Dim ctl4 As System.Windows.Forms.Control
        Dim ctl5 As System.Windows.Forms.Control
        Dim ctl6 As System.Windows.Forms.Control
        Dim ctl7 As System.Windows.Forms.Control

        Dim CtlType As String
        Dim NbControl As Short


        SQLCode = " SELECT * FROM parametres " _
                & " WHERE upper(PRM_CLIENT) = '" & UCase(Client) & "'" _
                & " AND upper(PRM_FORMNAME) ='" & UCase(Frm.Name) & "'" _
                & " AND upper(PRM_FRAMENAME) ='" & UCase(FramName) & "'" _
                & " ORDER BY PRM_TYPE "

        TempoRec = ReturnRecordset(SQLCode)

        If TempoRec.EOF Then Exit Sub

        While Not TempoRec.EOF

            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "TTL_VILLE" Then
                Def_TtlVille = IIf(IsDBNull(TempoRec("PRM_DEFAULT").Value.ToString()), "", TempoRec("PRM_DEFAULT").Value.ToString())
            End If

            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "PC2_NUMCOMPTE" Then
                NumCompteBNP = IIf(TempoRec("PRM_MAXLENGTH").Value.ToString() = 9, True, False)
                If Not continu Then Exit Sub

            End If
            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "ETP_COMPTE" Then
                NumCompteBNP_ETP = IIf(TempoRec("PRM_MAXLENGTH").Value.ToString() = 9, True, False)
            End If

            For Each ctl1 In FPanel.Controls
                CtlType = TypeName(ctl1)
                Select Case CtlType

                    '##################### Traitement des TextBox #####################'

                Case "TextBox"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "TEXTBOX" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                If ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N" Then
                                    ctl1.Enabled = False
                                Else
                                    ctl1.Enabled = True
                                End If
                            End If
                            If Not IsDBNull(TempoRec("PRM_REQUIRED").Value.ToString()) Then
                                ctl1.Tag = ChaineOK(TempoRec("PRM_REQUIRED").Value.ToString()) ' "O" OR "N"
                            End If
                        End If

                        '##################### Traitement des Label #####################'

                    Case "Label"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString) = "LABEL" Then
                            If Not IsDBNull(TempoRec("PRM_INDEX").Value.ToString()) Then
                            Else
                                If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                    ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                                End If
                                If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                    ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                                End If
                            End If

                        End If

                        '##################### Traitement des CommandButton #####################'

                    Case "CommandButton"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "COMMANDBUTTON" Then
                            If Not IsDBNull(TempoRec("PRM_INDEX").Value.ToString()) Then
                            Else
                                If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                    ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                                End If
                                If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                    ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                                End If
                            End If
                        End If

                        '##################### Traitement des Autres controles #####################'
                    Case "AGroup"
                        ParameterAGroup(NomClient, Frm, ctl1, FramName, continu)
                    Case "Panel"
                        ParameterPanel(NomClient, Frm, ctl1, FramName, continu)
                    Case "OptionButton"
                    Case "ComboBox"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "COMBOBOX" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                        End If
                    Case "DateTimePicker"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "DATETIMEPICKER" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                        End If
                    Case "Frame"
                    Case "CheckBox"
                    Case "SSTab"
                    Case "Menu"
                    Case "Toolbar"
                    Case "DBGrid"
                End Select
            Next ctl1

            If Not TempoRec.EOF Then TempoRec.MoveNext()

        End While

    End Sub

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : ParameterAGroup()
    '#!#F#                Type                : Local                                    (Local /Public/Global)
    '#!#F#                Input parameters    :Client,Frm
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


    Public Sub ParameterAGroup(ByRef Client As String, ByRef Frm As System.Windows.Forms.Form, ByRef FAGroup As AGroup, ByRef FramName As String, ByRef continu As Boolean)

        Dim ctl1 As System.Windows.Forms.Control
        Dim ctl2 As System.Windows.Forms.Control
        Dim ctl3 As System.Windows.Forms.Control
        Dim ctl4 As System.Windows.Forms.Control
        Dim ctl5 As System.Windows.Forms.Control
        Dim ctl6 As System.Windows.Forms.Control
        Dim ctl7 As System.Windows.Forms.Control

        Dim CtlType As String
        Dim NbControl As Short


        SQLCode = " SELECT * FROM parametres " _
                & " WHERE upper(PRM_CLIENT) = '" & UCase(Client) & "'" _
                & " AND upper(PRM_FORMNAME) ='" & UCase(Frm.Name) & "'" _
                & " AND upper(PRM_FRAMENAME) ='" & UCase(FramName) & "'" _
                & " ORDER BY PRM_TYPE "

        TempoRec = ReturnRecordset(SQLCode)

        If TempoRec.EOF Then Exit Sub

        While Not TempoRec.EOF

            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "TTL_VILLE" Then
                Def_TtlVille = IIf(IsDBNull(TempoRec("PRM_DEFAULT").Value.ToString()), "", TempoRec("PRM_DEFAULT").Value.ToString())
            End If

            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "PC2_NUMCOMPTE" Then
                NumCompteBNP = IIf(TempoRec("PRM_MAXLENGTH").Value.ToString() = 9, True, False)
                If Not continu Then Exit Sub

            End If
            If ChaineOK(TempoRec("PRM_NAME").Value.ToString()) = "ETP_COMPTE" Then
                NumCompteBNP_ETP = IIf(TempoRec("PRM_MAXLENGTH").Value.ToString() = 9, True, False)
            End If

            For Each ctl1 In FAGroup.Controls
                CtlType = TypeName(ctl1)
                Select Case CtlType

                    '##################### Traitement des TextBox #####################'

                Case "TextBox"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "TEXTBOX" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                If ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N" Then
                                    ctl1.Enabled = False
                                Else
                                    ctl1.Enabled = True
                                End If
                            End If
                            If Not IsDBNull(TempoRec("PRM_REQUIRED").Value.ToString()) Then
                                ctl1.Tag = ChaineOK(TempoRec("PRM_REQUIRED").Value.ToString()) ' "O" OR "N"
                            End If
                        End If

                        '##################### Traitement des Label #####################'

                    Case "Label"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString) = "LABEL" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                            'End If
                        End If

                        '##################### Traitement des CommandButton #####################'

                    Case "CommandButton"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "COMMANDBUTTON" Then
                            If Not IsDBNull(TempoRec("PRM_INDEX").Value.ToString()) Then
                            Else
                                If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                    ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                                End If
                                If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                    ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                                End If
                            End If
                        End If

                    Case "Button"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "BUTTON" Then

                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                        End If
                        '##################### Traitement des Autres controles #####################'
                    Case "AGroup"
                        If Not TempoRec.eof Then
                            If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "AGROUP" Then
                                If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                    ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                                End If
                                If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                    ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                                End If
                            End If
                        Else
                            ParameterAGroup(NomClient, Frm, ctl1, FramName, continu)
                        End If
                    Case "Panel"
                        If Not TempoRec.eof Then
                            If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "PANEL" Then
                                If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                    ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                                End If
                                If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                    ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                                End If
                            End If
                        Else
                            ParameterPanel(NomClient, Frm, ctl1, FramName, continu)
                        End If
                    Case "OptionButton"
                    Case "ComboBox"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "COMBOBOX" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                        End If
                    Case "DateTimePicker"
                        If ChaineOK((ctl1.Name)) = ChaineOK(TempoRec("PRM_NAME").Value.ToString()) And ChaineOK(TempoRec("PRM_TYPE").Value.ToString()) = "DATETIMEPICKER" Then
                            If Not IsDBNull(TempoRec("PRM_VISIBLE").Value.ToString()) Then
                                ctl1.Visible = IIf(ChaineOK(TempoRec("PRM_VISIBLE").Value.ToString()) = "N", False, True)
                            End If
                            If Not IsDBNull(TempoRec("PRM_ENABLED").Value.ToString()) Then
                                ctl1.Enabled = IIf(ChaineOK(TempoRec("PRM_ENABLED").Value.ToString()) = "N", False, True)
                            End If
                        End If
                    Case "Frame"
                    Case "CheckBox"
                    Case "SSTab"
                    Case "Menu"
                    Case "Toolbar"
                    Case "DBGrid"
                End Select
            Next ctl1
            If Not TempoRec.EOF Then TempoRec.MoveNext()

        End While

    End Sub

    Public Function ReturnRecordset1(ByVal sSQL As String, Optional ByRef sXML As String = Nothing) As Object
        Dim ChBase As String
        ChBase = "BO"
        Try
            Dim oRs As Object = oAssembly.CreateInstance("ADODB.RecordsetClass")
            Dim oStr As Object = oAssembly.CreateInstance("ADODB.StreamClass")

            Dim sXML1 As String
            If ChBase = "Fo" Then
                sXML1 = ws2.GETXMLString(sSQL, "mxauto26", "mxauto26", dataSource_BO, EtatCrypteMagix)
            Else
                sXML1 = ws2.GETXMLString(sSQL, CodeOperatrice, MotPasse, dataSource_BO, EtatCrypteMagix)

            End If

            oStr.Open()
            oStr.WriteText(sXML1)
            oStr.Position = 0
            oRs.Open(oStr)
            oStr = Nothing
            If Not IsDBNull(sXML) Then
                sXML = sXML1
            End If
            Return oRs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Public Function ReturnRecordset(ByVal sSQL As String, Optional ByVal ChBase As String = Nothing, Optional ByRef sXML As String = Nothing, Optional ByRef sErr As String = Nothing, Optional ByRef sShema As String = Nothing) As Object
        Try
            Dim oRs As Object = oAssembly.CreateInstance("ADODB.RecordsetClass")
            Dim oStr As Object = oAssembly.CreateInstance("ADODB.StreamClass")
            Dim i_i As Integer
            Dim withShema As Integer = 0
            Dim sTemp As String
            Dim Doc1 As System.Xml.XmlDocument = New System.Xml.XmlDocument

            'test
            oRs.CursorLocation = 3 'adUseClient
            oRs.CursorType = 3 'adOpenStatic
            oRs.LockType = 4 'adLockBatchOptimistic

            'test khalid

            Dim sXML1 As String
            sError = ""
            sErr = ""
            If UCase(ChBase) = "FO" Then
                If sShema Is Nothing Then
                    sXML1 = ws2.GETXMLString_FoAut(sSQL)
                Else
                    If sShema = "" Then
                        sXML1 = ws2.GETXMLString_FoAut(sSQL)
                        withShema = 1
                    Else

                    End If
                End If
            Else
                If sShema Is Nothing Then
                    sXML1 = ws2.GETXMLString(sSQL, CodeOperatrice, MotPasse, dataSource_BO, EtatCrypteMagix)
                Else
                    If sShema = "" Then
                        sXML1 = ws2.GETXMLString(sSQL, CodeOperatrice, MotPasse, dataSource_BO, EtatCrypteMagix)
                        withShema = 1
                    Else
                        withShema = 0
                        sXML1 = ws2.GETXMLString_opt(sSQL, CStr(withShema), CodeOperatrice, MotPasse, dataSource_BO, EtatCrypteMagix)
                    End If
                End If
            End If
            sXML1 = Replace(sXML1, "xml1", "xml")
            'WebSphere
            sError = sXML1
            If Not sShema Is Nothing Then
                If withShema = 0 Then
                    i_i = InStr(sXML1, "<rs:data")
                    sXML1 = Mid(sXML1, 1, i_i - 1) & sShema & Mid(sXML1, i_i)
                Else
                    sTemp = sXML1
                    sTemp = Replace(sTemp, "s:Schema", "s_Schema")
                    Doc1.LoadXml(sTemp)
                    sShema = Doc1.SelectSingleNode("xml/s_Schema").OuterXml()
                    sShema = Replace(sShema, "s_Schema", "s:Schema")
                End If
            End If
            sError = sXML1
            'WebSphere
            If WebSp Then
                sXML1 = ConvertXML1(sXML1)
                If Not sXML1 Is Nothing Then sError = sXML1
            End If

            oStr.Open()
            oStr.WriteText(sXML1)
            oStr.Position = 0
            oRs.Open(oStr)
            oStr = Nothing
            If Not IsDBNull(sXML) Then
                sXML = sXML1
            End If
            Return oRs
        Catch ex As Exception
            'MsgBox(ex.Message)
            If sError = "" Then sError = ex.Message
            sErr = sError
            Message(sErr, 16)
            Return Nothing
        End Try
    End Function
    Public Function GetRecordsetByXML(Optional ByVal sXML As String = Nothing, Optional ByRef sErr As String = Nothing) As Object
        Try
            Dim oRs As Object = oAssembly.CreateInstance("ADODB.RecordsetClass")
            Dim oStr As Object = oAssembly.CreateInstance("ADODB.StreamClass")

            'test
            oRs.CursorLocation = 3 'adUseClient
            oRs.CursorType = 3 'adOpenStatic
            oRs.LockType = 4 'adLockBatchOptimistic


            Dim sXML1 As String
            sError = ""
            sErr = ""
            'WebSphere
            sError = sXML
            sXML1 = ConvertXML1(sXML)
            If Not sXML1 Is Nothing Then sError = sXML1
            oStr.Open()
            oStr.WriteText(sXML1)
            oStr.Position = 0
            oRs.Open(oStr)
            oStr = Nothing
            If Not IsDBNull(sXML) Then
                sXML = sXML1
            End If
            Return oRs
        Catch ex As Exception
            'MsgBox(ex.Message)
            If sError = "" Then sError = ex.Message
            sErr = sError

            Return Nothing
        End Try
    End Function

    Public Function SQLExecute(ByVal sSQL As String, Optional ByVal ChBase As String = Nothing, Optional ByRef sErr As String = Nothing) As String

        Ierr1 = ""
        EtatIerr1 = False

        If UCase(ChBase) = "FO" Then
            Ierr1 = ws2.ExecuteQuerry_FO(sSQL)
        Else
            Ierr1 = ws2.ExecuteQuerry(sSQL, CodeOperatrice, MotPasse, dataSource_BO, EtatCrypteMagix)
        End If
        If Ierr1 = "0" And Ierr1 <> "" Then
            EtatIerr1 = True
            Message(Ierr1, 16)
        End If
    End Function
    Public Function ExecuteMoreQuerry(ByVal sXML_in As String, ByRef sError As String, Optional ByVal Sup As String = Nothing) As String
        Dim sXML_out As String
        Dim sNum, sErr, sReturn As String

        Try
            sXML_in = Replace(sXML_in, "&", "&amp;")
            If Sup Is Nothing Or Sup <> "1" Then
                sXML_out = ws2.ExecuteMoreQuerry(sXML_in, dataSource_BO, EtatCrypteMagix)
            Else
                sXML_out = ws2.ExecuteMoreQuerry(sXML_in, dataSource_BO, EtatCrypteMagix)
                'sXML_out = ws2.ExecuteMoreQuerry_Supp(sXML_in, dataSource_BO, EtatCrypteMagix)
            End If
        Catch e As Exception

            sError = e.Message & Chr(13) & " Veuillez Refaire L’Opération"
            Return "-1"
        End Try

        Dim Doc As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Try
            Doc.LoadXml(sXML_out)
            sReturn = Doc.SelectSingleNode("/Root/return").InnerText
            sErr = Doc.SelectSingleNode("/Root/error").InnerText
            sNum = Doc.SelectSingleNode("/Root/numreq").InnerText
            sReturn = Trim(sReturn)
            If sReturn <> "1" Then
                sError = "Opération Non accomplie (N°:" & sNum & ")" & vbCrLf & Chr(13) & " Veuillez Refaire L’Opération" & Chr(13) '& " Ou Vérifier la Cohérence des données "
                sError = sError & "  " & sErr
            End If
        Catch e As Exception
            sError = e.Message & Chr(13) & " Veuillez Refaire L’Opération"
            Return "-1"
        End Try
        Return sReturn


    End Function

    Public Function GetDataset(ByVal sSQL As String, Optional ByVal sCodeOperatrice As String = Nothing, Optional ByVal sMotPasse As String = Nothing) As System.Data.DataSet

        Dim sXML As String
        Dim sShema As String
        Dim sData As String
        Dim Doc As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim Doc1 As System.Xml.XmlDocument = New System.Xml.XmlDocument

        If (Not WebSp) Then
            Return ws2.RunSQLReturnDataSet(sSQL, CodeOperatrice, MotPasse, dataSource_BO, EtatCrypteMagix)
        Else
            If sCodeOperatrice = "" Or sMotPasse = "" Then
                sCodeOperatrice = CodeOperatrice
                sMotPasse = MotPasse
            End If
            sXML = ws2.GetDataSetString(sSQL, sCodeOperatrice, sMotPasse, dataSource_BO, EtatCrypteMagix)
            Doc1.LoadXml(sXML)
            sShema = Doc1.SelectSingleNode("/xml/Shema").InnerXml()
            sShema = "<?xml version='1.0' encoding='utf-8' ?>" & sShema
            sData = Doc1.SelectSingleNode("/xml/Data").InnerXml()

            Doc.LoadXml(sShema)
            Dim reader As System.Xml.XmlReader
            reader = New System.Xml.XmlNodeReader(Doc)
            Dim datadoc As System.Xml.XmlDataDocument = New System.Xml.XmlDataDocument
            datadoc.DataSet.ReadXmlSchema(reader)
            datadoc.LoadXml(sData)
            Return datadoc.DataSet
        End If

    End Function
    Public Function ReplaceXML(ByVal sXML_in As String) As String
        Dim sXML_out As String
        Dim sNum, sErr, sReturn As String
        sXML_in = Replace(sXML_in, "&", "&amp;")
        sXML_in = Replace(sXML_in, "<", "&lt;")
        sXML_in = Replace(sXML_in, ">", "&gt;")
        'sXML_in = Replace(sXML_in, "'", "''")
        Return sXML_in
    End Function
    Public Function XMLtoDataset(ByVal sXML As String, ByVal sShema As String) As Data.DataSet
        Dim iNum, iNum1 As Integer
        Dim sXML1 As String
        Dim sXML2 As String

        iNum = InStr(sXML, "<s:Schema")
        iNum1 = InStr(sXML, "</s:Schema")
        If iNum > 0 Then

            sXML1 = Mid(sXML, 1, iNum - 1)
            sXML2 = Mid(sXML, iNum1 + 11)
            sXML = sXML1 & sXML2

        End If
        sXML = ConvertXML(sXML)
        Dim Doc As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Doc.LoadXml(sShema)

        Dim reader As System.Xml.XmlReader
        reader = New System.Xml.XmlNodeReader(Doc)
        Dim datadoc As System.Xml.XmlDataDocument = New System.Xml.XmlDataDocument
        datadoc.DataSet.ReadXmlSchema(reader)
        datadoc.LoadXml(sXML)
        Return datadoc.DataSet

    End Function

    Public Function ConvertXML(ByVal sXML As String) As String

        On Error GoTo ExitProc
        Dim sXSL As String
        Dim iNum As Integer
        Dim reader As System.Xml.XmlReader
        Dim reader1 As System.Xml.XmlReader
        Dim Doc As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim DocTest As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim doc1 As System.Xml.XPath.XPathDocument

        Dim oXML As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim oXML1 As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim oXSL As System.Xml.Xsl.XslTransform = New System.Xml.Xsl.XslTransform

        If CBool(Len(sXML)) Then


            sXSL = "<?xml version='1.0'?><xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:s='uuid:BDC6E3F0-6DA3-11d1-A2A3-00AA00C14882' xmlns:dt='uuid:C2F41010-65B3-11d1-A29F-00AA00C14882' xmlns:rs='urn:schemas-microsoft-com:rowset' xmlns:z='#RowsetSchema' version=""1.0"">"
            sXSL = sXSL & "<xsl:output method=""xml""/>"
            sXSL = sXSL & "<xsl:template match=""/""><xsl:apply-templates select=""*""/></xsl:template>"
            sXSL = sXSL & "<xsl:template match=""*""><xsl:element name=""Table"">"
            sXSL = sXSL & "<xsl:apply-templates select=""*""/><xsl:apply-templates select=""@*""/><xsl:value-of select="".""/>"
            sXSL = sXSL & "</xsl:element></xsl:template><xsl:template match=""@*"">"
            sXSL = sXSL & "<xsl:element name=""{ name() }""><xsl:value-of select="".""/>"
            sXSL = sXSL & "</xsl:element></xsl:template></xsl:stylesheet>"


            Dim xslStream As System.IO.MemoryStream = New System.IO.MemoryStream(System.Text.Encoding.GetEncoding(1252).GetBytes(sXSL))
            reader = New System.Xml.XmlTextReader(xslStream)

            Doc.LoadXml(sXSL)
            reader = New System.Xml.XmlNodeReader(Doc)
            oXSL.Load(reader)

            Doc.LoadXml(sXML)
            reader = New System.Xml.XmlNodeReader(Doc)
            doc1 = New System.Xml.XPath.XPathDocument(reader)
            reader1 = oXSL.Transform(doc1, Nothing)
            DocTest.Load(reader1)
            sXML = DocTest.InnerXml
            sXML = Replace(sXML, "<Table><Table>", "<MyTable><MyTable>", 1, 1)
            iNum = InStr(sXML, "</Table></Table></Table>")

            If iNum Then
                sXML = Replace(sXML, "</Table></Table></Table>", "</Table></MyTable></MyTable>", 1, 1)
            Else
                sXML = Replace(sXML, "</Table></Table>", "</MyTable></MyTable>", 1, 1)
            End If

            ConvertXML = sXML

        End If

ExitProc:

        oXML = Nothing
        oXSL = Nothing

    End Function

    Public Function ConvertXML1(ByVal sXML As String) As String

        On Error GoTo ExitProc
        Dim sXSL As String
        Dim iNum As Integer
        Dim reader As System.Xml.XmlReader
        Dim reader1 As System.Xml.XmlReader
        Dim Doc As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim DocTest As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim doc1 As System.Xml.XPath.XPathDocument

        Dim oXML As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim oXML1 As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim oXSL As System.Xml.Xsl.XslTransform = New System.Xml.Xsl.XslTransform

        If CBool(Len(sXML)) Then

            sXSL = "<?xml version='1.0'?><xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:s='uuid:BDC6E3F0-6DA3-11d1-A2A3-00AA00C14882' xmlns:dt='uuid:C2F41010-65B3-11d1-A29F-00AA00C14882' xmlns:rs='urn:schemas-microsoft-com:rowset' xmlns:z='#RowsetSchema' version=""1.0"">"
            sXSL = sXSL & "<xsl:output method=""xml""/>"
            sXSL = sXSL & "<xsl:template match=""/xml""><xml><xsl:copy-of select=""s:Schema""/><xsl:apply-templates select=""rs:data""/></xml></xsl:template>"

            sXSL = sXSL & "<xsl:template match=""rs:data""><rs:data><xsl:apply-templates select=""z:row""/></rs:data></xsl:template>"
            sXSL = sXSL & "<xsl:template match=""z:row""><z:row><xsl:apply-templates select=""*""/></z:row></xsl:template>"
            sXSL = sXSL & "<xsl:template match=""*""><xsl:attribute name=""{ name() }""><xsl:value-of select="".""/></xsl:attribute></xsl:template>"
            sXSL = sXSL & "</xsl:stylesheet>"





            Dim xslStream As System.IO.MemoryStream = New System.IO.MemoryStream(System.Text.Encoding.GetEncoding(1252).GetBytes(sXSL))
            reader = New System.Xml.XmlTextReader(xslStream)

            Doc.LoadXml(sXSL)
            reader = New System.Xml.XmlNodeReader(Doc)
            oXSL.Load(reader)

            Doc.LoadXml(sXML)
            reader = New System.Xml.XmlNodeReader(Doc)
            doc1 = New System.Xml.XPath.XPathDocument(reader)
            reader1 = oXSL.Transform(doc1, Nothing)
            DocTest.Load(reader1)
            sXML = DocTest.InnerXml
            sXML = Replace(sXML, "></z:row>", "/>", 1, -1)
            iNum = InStr(sXML, "</Table></Table></Table>")

            If iNum Then
                sXML = Replace(sXML, "</Table></Table></Table>", "</Table></MyTable></MyTable>", 1, 1)
            Else
                sXML = Replace(sXML, "</Table></Table>", "</MyTable></MyTable>", 1, 1)
            End If

            ConvertXML1 = sXML

        End If

ExitProc:

        oXML = Nothing
        oXSL = Nothing

    End Function

    Public Sub Confirmer(ByRef sSQL As String)

        Dim sSchema As String

        Dim StrCol As String
        Dim Col1, Col2 As String
        Dim dgt As DataGridTableStyle = New DataGridTableStyle
        Dim dgc As DataGridColumnStyle
        Dim RD As DataSet

        sSchema = "<?xml version='1.0' encoding='utf-8' ?> "
        sSchema = sSchema & "<xs:schema id='NewDataSet' xmlns='' xmlns:xs='http://www.w3.org/2001/XMLSchema' xmlns:msdata='urn:schemas-microsoft-com:xml-msdata'>"
        sSchema = sSchema & "<xs:element name='NewDataSet' msdata:IsDataSet='true' msdata:Locale='fr-FR'>"
        sSchema = sSchema & "<xs:complexType>"
        sSchema = sSchema & "<xs:choice maxOccurs='unbounded'>"
        sSchema = sSchema & "<xs:element name='Table'>"
        sSchema = sSchema & "<xs:complexType>"
        sSchema = sSchema & "<xs:sequence>"
        sSchema = sSchema & "<xs:element name='TMP_ETAT' type='xs:string' minOccurs='0' />"
        sSchema = sSchema & "<xs:element name='TMP_PAGENAME' type='xs:string' minOccurs='0' />"
        sSchema = sSchema & "</xs:sequence>"
        sSchema = sSchema & "</xs:complexType>"
        sSchema = sSchema & "</xs:element>"
        sSchema = sSchema & "</xs:choice>"
        sSchema = sSchema & "</xs:complexType>"
        sSchema = sSchema & "</xs:element>"
        sSchema = sSchema & "</xs:schema>"

        RD = XMLtoDataset(sSQL, sSchema)

        StrCol = MLangue("1213")

        Col1 = Trim(Mid(StrCol, 1, 14))
        Col2 = Trim(Mid(StrCol, 15))

        dgc = New DataGridTextBoxColumn
        dgc.MappingName = RD.Tables(0).Columns(0).ColumnName
        dgc.HeaderText = Col2
        dgc.Width = 60
        dgt.GridColumnStyles.Add(dgc)


        dgc = New DataGridTextBoxColumn
        dgc.MappingName = RD.Tables(0).Columns(1).ColumnName
        dgc.HeaderText = Col1
        dgc.Width = 200
        dgt.GridColumnStyles.Add(dgc)

        dgt.MappingName = "Table"

    End Sub

    Public Sub FrmActiver(ByRef CtlP As System.Windows.Forms.GroupBox, ByVal etat As Boolean)
        '
        Try
            Dim Ctl As System.Windows.Forms.Control
            Dim CtlType As String
            Dim x As String
            Dim Obj As Object
            Dim Ctl1 As System.Windows.Forms.Control
            Dim Ctl2 As System.Windows.Forms.Control
            Dim Ctl3 As System.Windows.Forms.Control
            Dim Ctl4 As System.Windows.Forms.Control
            Dim Ctl5 As System.Windows.Forms.Control
            Dim Ctl6 As System.Windows.Forms.Control
            Dim Ctl7 As System.Windows.Forms.Control
            Dim Ctl8 As System.Windows.Forms.Control
            Dim Ctl9 As System.Windows.Forms.Control
            Desactiver(CtlP, etat)
            For Each Ctl In CtlP.Controls
                Desactiver(Ctl, etat)
                For Each Ctl1 In Ctl.Controls
                    Desactiver(Ctl1, etat)
                    For Each Ctl2 In Ctl1.Controls
                        Desactiver(Ctl2, etat)
                        For Each Ctl3 In Ctl2.Controls
                            Desactiver(Ctl3, etat)
                            For Each Ctl4 In Ctl3.Controls
                                Desactiver(Ctl4, etat)
                                For Each Ctl5 In Ctl4.Controls
                                    Desactiver(Ctl5, etat)
                                    For Each Ctl6 In Ctl5.Controls
                                        Desactiver(Ctl6, etat)
                                        For Each Ctl7 In Ctl6.Controls
                                            Desactiver(Ctl7, etat)
                                            For Each Ctl8 In Ctl7.Controls
                                                Desactiver(Ctl8, etat)
                                                For Each Ctl9 In Ctl8.Controls
                                                    Desactiver(Ctl9, etat)
                                                Next
                                            Next
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next Ctl
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Desactiver(ByRef Ctl As Object, ByVal etat As Boolean) '(ByRef Ctl As System.Windows.Forms.Control, ByVal etat As Boolean)
        Dim CtlType As String
        CtlType = TypeName(Ctl)
        Select Case CtlType
            Case "CommandButton"
                Ctl.Enabled = etat
            Case "OptionButton"
                Ctl.Enabled = etat
            Case "TextBox"
                Ctl.ReadOnly = Not etat
                Ctl.Height = 21
            Case "CheckBox"
                'Ctl.Enabled = etat
                Ctl.autocheck = etat
            Case "DateTimePicker"
                Ctl.Enabled = etat
            Case "Button"
                Ctl.Enabled = etat
                Ctl.Height = 21
            Case "RadioButton"
                Ctl.Enabled = etat
                'Ctl.autocheck = etat
            Case "TabControl"
                'Ctl.Enabled = etat
            Case "ComboBox"
                Ctl.Enabled = etat
            Case "AGroup"
                Ctl.Enabled = etat

        End Select
    End Sub

    Public Sub AddParam(ByVal Param As String, ByVal Value As String)
        'Dim paramField As New CrystalDecisions.Shared.ParameterField
        'Dim discreteVal As New CrystalDecisions.Shared.ParameterDiscreteValue
        'paramField.ParameterFieldName = Param
        'discreteVal.Value = Value
        'paramField.CurrentValues.Add(discreteVal)
        'paramField.DefaultValues.Add(discreteVal)
        'paramFields.Add(paramField)
    End Sub

    Public Function gnr_crn(ByRef w_code As String) As String

        Dim Nsq_Nocour As String
        Dim Nsq_Nomax As String

        SQLCode = "SELECT * FROM numsequence" & " WHERE nsq_code ='" & w_code & "'"
        If TestConn Then
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Function
            End If
        Else
            TempoRec = ReturnRecordset(SQLCode)
        End If
        If TempoRec.EOF Then
            SQLCode = "INSERT INTO numsequence (nsq_nocour,nsq_nomax,nsq_nomin," & "nsq_lgno,nsq_code,nsq_typeno)VALUES ('000001','999999','000001'," & "'6','" & w_code & "','I')"
            SQLExecute((SQLCode))
        Else
            Nsq_Nocour = IIf(IsDBNull(TempoRec("Nsq_Nocour").Value), 0, Trim(TempoRec("Nsq_Nocour").Value))
            Nsq_Nomax = IIf(IsDBNull(TempoRec("Nsq_Nomax").Value), 0, Trim(TempoRec("Nsq_Nomax").Value))

            If Nsq_Nocour = Nsq_Nomax Then
                Nsq_Nocour = IIf(IsDBNull(TempoRec("Nsq_Nomin").Value), 0, Trim(TempoRec("Nsq_Nomin").Value))
            Else
                Nsq_Nocour = CStr(Val(Nsq_Nocour) + 1)
            End If
            SQLCode = "UPDATE numsequence SET" & " nsq_nocour='" & Nsq_Nocour & "'" & " WHERE nsq_code ='" & w_code & "'"
            SQLExecute((SQLCode))
        End If
        gnr_crn = Nsq_Nocour
    End Function


    Public Function GetArguments(ByRef commande As String, ByRef url As String) As Integer
        Dim sStr As String
        Dim T() As String
        Dim T1(5) As String
        Dim T2(5) As String
        Dim i As Integer = 0
        Dim MaxArg As Integer

        If System.Environment.GetCommandLineArgs.Length() < 2 Then Return -1
        sStr = System.Environment.GetCommandLineArgs()(1)
        ''sStr = "http://192.20.2.92/Prototype/MXMOFOAdmin.exe?cmd=001001F012001O002007MXMOFO5003007MXMOFO5004028http://192.20.2.92/Prototype005025http://192.20.2.92/MxWeb3101000102000"
        'sStr = "http://192.20.2.92/MxWeb4/MXMOFOAdmin.exe?cmd=ok&url=192.20.2.92"
        If InStr(sStr, "?") = 0 Then Return -1
        T = Split(sStr, "?")
        If InStr(T(1), "&") > 0 Then
            T1 = Split(T(1), "&")
            MaxArg = T1.Length
        Else
            T1(0) = T(1)
            MaxArg = 1
        End If
        While (i < MaxArg)
            T2 = Split(T1(i), "=")
            Select Case T2(0)
                Case "cmd"
                    commande = T2(1)
                Case "url"
                    url = T2(1)
            End Select
            i = i + 1
        End While
        Return 0

    End Function
    Public Function Control_Supp2(ByRef Table As String, ByRef Cod_Var1 As String, ByRef Valeur1 As String, ByRef Cod_Var2 As String, ByRef Valeur2 As String) As Boolean

        Control_Supp2 = False
        SQLCode = " SELECT  " & Cod_Var1 & "," & Cod_Var2 & " FROM " & Table & "" & " WHERE  " & Cod_Var1 & "  LIKE '" & Valeur1 & "'" & " AND  " & Cod_Var2 & "  LIKE '" & Valeur2 & "'"
        sError = ""
        TempoRec = ReturnRecordset(SQLCode, , , sError)
        If TempoRec Is Nothing Then
            Message(sError, 16)
            Exit Function
        End If

        If Not TempoRec.EOF Then Control_Supp2 = True
    End Function
    Public Function Control_Supp(ByRef Table As String, ByRef Cod_Var As String, ByRef valeur As String) As Boolean
        Dim TempoRec As Object
        Control_Supp = False
        SQLCode = " SELECT  " & Cod_Var & " FROM " & Table & "" & " WHERE  " & Cod_Var & "  LIKE '" & valeur & "'"
        'TempoRec = ReturnRecordset(SQLCode) ', rdOpenDynamic, rdConcurRowVer)
        sError = ""
        TempoRec = ReturnRecordset(SQLCode, , , sError)
        If TempoRec Is Nothing Then
            Message(sError, 16)
            Exit Function
        End If

        If Not TempoRec.EOF Then Control_Supp = True
    End Function



    Public Function RechIADateS(ByRef Champs As String, ByRef Valeur1 As String, ByRef Valeur2 As String) As String
        Select Case TypeBase
            Case "O"
                RechIADateS = " " & Champs & " >='" & Format(CDate(Valeur1), "dd/MM/yyyy") & "' AND " & Champs & " <='" & Format(Valeur2, "dd/MM/yyyy") & "'"
            Case "I"
                RechIADateS = " " & Champs & " >='" & Format(CDate(Valeur1), "MM/dd/yyyy") & "' AND " & Champs & " <='" & Format(Valeur2, "MM/dd/yyyy") & "'"
            Case "A"
                RechIADateS = " " & Champs & " >=#" & Format(CDate(Valeur1), "dd/MM/yyyy") & "# AND " & Champs & " <=#" & Format(Valeur2, "dd/MM/yyyy") & "#"
        End Select
    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : RechIAHeure()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function RechIAHeure(ByRef Champs As String, ByRef Valeur As String) As String
        Select Case TypeBase
            Case "I"
                Return " " & Champs & "='" & Format(Valeur, "HH:mm:SS") & "'"
            Case "A", "O"
                Return " " & Champs & "= '" & Format(Valeur, "HH:mm") & "'"
            Case "A"
                Return " " & Champs & "= #" & Format(Valeur, "HH:mm:SS") & "#"
        End Select
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : InsertHeure()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function InsertHeure(ByRef champHeure As String) As Object

        Return Format(CDate(champHeure), "HH:MM:SS")

    End Function
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : InsertTime()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function InsertTime(ByVal ChampTime As Object)

        InsertTime = IIf(IsDBNull(ChampTime), GetTime(), Format(CDate(ChampTime), "HH:MM"))
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : FormatCode()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    : Text:Text a formater ,Longueur : Longueur du champs
    '#!#F#                Output parameters   : La chaine sous format d'un code
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Permet de d'ajouter des 0 à gauche du code saisie
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    '''Public Function FormatCode(ByRef Text As String, ByRef Longueur As Byte) As String

    '''    'Permet de d'ajouter des 0 à gauche du code saisie
    '''    Dim Num As String
    '''    Num = Trim(Text)
    '''    FormatCode = New String("0", Longueur - Len(Num)) & Num
    '''End Function



    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : CardInsert()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function CardInsert(ByRef Chaine As String) As String

        Return Chaine & CStr(New String("?", 19 - Len(Chaine)))

    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : CHStart()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function CHStart(ByRef Chaine0 As Object, ByRef N As Byte) As String

        CHStart = IIf(Len(Chaine0.ToString()) < N, "", Trim(Mid(Chaine0.ToString(), 1, N)))

    End Function


    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : InsertMenuOperateur()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub InsertMenuOperateur(ByRef Code As String)

        SQLCode = " SELECT * FROM winmenu WHERE amn_oper = 'M2MROOT'"

        'TempoRec = ReturnRecordset(SQLCode) ', rdOpenDynamic, rdConcurRowver)
        sError = ""
        TempoRec = ReturnRecordset(SQLCode, , , sError)
        If TempoRec Is Nothing Then
            Message(sError, 16)
            Exit Sub
        End If

        With TempoRec
            If Not .EOF Then
                .MoveFirst()
                While Not .EOF
                    SQLCode = " INSERT INTO winmenu (amn_code,amn_libelle,amn_abrev," & " amn_langue,amn_oper,amn_drtcreat,amn_drtmodif," & " amn_drtsuppr,amn_drtcnslt,amn_actif,amn_type) VALUES ('" & TempoRec("Amn_Code").Value.ToString() & "','" & Replace(TempoRec("AMN_LIBELLE").Value.ToString(), "'", "''") & "','" & TempoRec("AMN_ABREV").Value.ToString() & "','" & TempoRec("AMN_LANGUE").Value.ToString() & "','" & ChaineOK(Code) & "','" & TempoRec("AMN_DRTCREAT").Value.ToString() & "','" & TempoRec("AMN_DRTMODIF").Value.ToString() & "','" & TempoRec("AMN_DRTSUPPR").Value.ToString() & "','" & TempoRec("AMN_DRTCNSLT").Value.ToString() & "','" & TempoRec("Amn_Actif").Value.ToString() & "','O')"

                End While
            End If
        End With
    End Sub

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : DeleteMenuOperateur()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub DeleteMenuOperateur(ByRef Code As String)

        SQLCode = " DELETE FROM winmenu WHERE amn_oper = '" & ChaineOK(Code) & "'"
    End Sub


    Public Sub MigBase()

        SQLCode = " SELECT * FROM winmenu where 1=1"

        sError = ""
        TempoRec = ReturnRecordset(SQLCode, , , sError)
        If TempoRec Is Nothing Then
            Message(sError, 16)
            Exit Sub
        End If

        While Not TempoRec.EOF
            SQLCode = "Insert INTO MXMOFO5.winmenu VALUES ('" & NullOK(TempoRec("Amn_Code").Value.ToString()) & "','" & Replace(Replace(Replace(NullOK(TempoRec("AMN_LIBELLE").Value.ToString()), "é", "e"), "è", "e"), "'", "''") & "','" & NullOK(TempoRec("AMN_ABREV").Value.ToString()) & "','" & NullOK(TempoRec("AMN_LANGUE").Value.ToString()) & "','MXMOFO5','" & NullOK(TempoRec("AMN_DRTCREAT").Value.ToString()) & "','" & NullOK(TempoRec("AMN_DRTMODIF").Value.ToString()) & "','" & NullOK(TempoRec("AMN_DRTSUPPR").Value.ToString()) & "','" & NullOK(TempoRec("AMN_DRTCNSLT").Value.ToString()) & "','" & NullOK(TempoRec("Amn_Actif").Value.ToString()) & "','" & NullOK(TempoRec("AMN_TYPE").Value.ToString()) & "')"
            TempoRec.MoveNext()
        End While
    End Sub


    Public Function RechIADate2(ByRef Champs As String, ByRef Valeur As String) As String

        Select Case TypeBase
            Case "O"
                RechIADate2 = " " & Champs & " <='" & Format(CDate(Valeur), "dd/MM/yyyy") & "'"
            Case "I"
                RechIADate2 = " " & Champs & " <='" & Format(Valeur, "MM/DD/YYYY") & "'"
            Case "A"
                RechIADate2 = " " & Champs & " <= #" & Format(Valeur, "DD/MM/YYYY") & "#"
                If Trim(Champs) = "" Then RechIADate2 = " #" & Format(Valeur, "DD/MM/YYYY") & "#"
        End Select
    End Function
    ''''''''''''''''''''''''''''''''''''''''''''''''
    '''''
    ''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function RechIADate1(ByRef Champs As String, ByRef Valeur As String) As String

        Select Case TypeBase
            Case "O"
                RechIADate1 = " " & Champs & " >='" & Format(CDate(Valeur), "dd/MM/yyyy") & "'"
            Case "I"
                RechIADate1 = " " & Champs & " >='" & Format(Valeur, "MM/DD/YYYY") & "'"
            Case "A"
                RechIADate1 = " " & Champs & " >= #" & Format(Valeur, "DD/MM/YYYY") & "#"
                If Trim(Champs) = "" Then RechIADate1 = " #" & Format(Valeur, "DD/MM/YYYY") & "#"
        End Select
    End Function
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Acces()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Acces1(ByRef Code As String) As TableAccess
        '==================================================
        ' Cette function remplie le tableau TableAcces
        ' par True Or False suivant les droit d'acces
        ' de chaque Operateur " CodeOperatrice "
        '==================================================
        Dim TempoAccess As Object
        Dim TempoAccess1 As Object
        '
        SQLCode = "SELECT * FROM MXMOFO5.winmenu WHERE amn_code = '" & ChaineOK(Code) & "' AND amn_oper = '" & ChaineOK(CodeOperatrice) & "'" & " AND amn_langue = '" & ChaineOK(Langue) & "'"

        TempoAccess = ReturnRecordset(SQLCode)
        If Not TempoAccess.EOF Then
            Acces1.Code = Code
            Acces1.Visible = (NullOK(TempoAccess("Amn_Actif").Value.ToString()) = "Y")
            Acces1.Create = (NullOK(TempoAccess("AMN_DRTCREAT").Value.ToString()) = "Y")
            Acces1.Delete = (NullOK(TempoAccess("AMN_DRTSUPPR").Value.ToString()) = "Y")
            Acces1.Search = (NullOK(TempoAccess("AMN_DRTCNSLT").Value.ToString()) = "Y")
            Acces1.Update = (NullOK(TempoAccess("AMN_DRTMODIF").Value.ToString()) = "Y")
            Acces1.PageName = IIf(IsDBNull(TempoAccess("AMN_LIBELLE").Value.ToString()), "", Trim(TempoAccess("AMN_LIBELLE").Value.ToString()))
        End If

        Acces1.Visible = True
        Acces1.Create = True
        Acces1.Delete = True
        Acces1.Search = True
        Acces1.Update = True

    End Function

    Public Sub Choix_Color(ByVal page As System.Windows.Forms.Form)
        '
        Try
            Dim Ctl As System.Windows.Forms.Control
            Dim CtlType As String
            Dim x As String
            Dim Obj As Object

            Dim CB_F As Color
            Dim CB_M As Color
            Dim CB_C As Color
            Dim C_TB As Color

            CB_F.FromArgb(192, 20, 20)

            Dim Ctl1 As System.Windows.Forms.Control
            Dim Ctl2 As System.Windows.Forms.Control
            Dim Ctl3 As System.Windows.Forms.Control
            Dim Ctl4 As System.Windows.Forms.Control
            Dim Ctl5 As System.Windows.Forms.Control

            page.BackColor = CB_F

            For Each Ctl In page.Controls
                Colorer(Ctl)
                For Each Ctl1 In Ctl.Controls
                    Colorer(Ctl1)
                    For Each Ctl2 In Ctl1.Controls
                        Colorer(Ctl2)
                        For Each Ctl3 In Ctl2.Controls
                            Colorer(Ctl3)
                            For Each Ctl4 In Ctl3.Controls
                                Colorer(Ctl4)
                            Next
                        Next
                    Next
                Next
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Julien_Date()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Function Julien_Date(ByRef V_Date As Date) As String

        Dim V_Day As Short
        Dim V_Month As Short
        Dim V_Year As Short
        Dim I As Short
        Dim Somme As Short
        Dim I_An As Short

        Somme = 0
        V_Day = Microsoft.VisualBasic.DateAndTime.Day(V_Date)
        V_Month = Month(V_Date)
        V_Year = Year(V_Date)
        I_An = V_Year Mod 10


        For I = 1 To V_Month - 1
            If ((I = 1) Or (I = 3) Or (I = 5) Or (I = 7) Or (I = 8) Or (I = 10) Or (I = 12)) Then
                Somme = Somme + 31
            End If
            If ((I = 4) Or (I = 6) Or (I = 9) Or (I = 11)) Then
                Somme = Somme + 30
            End If
            If (I = 2) Then
                If (V_Year Mod 4 = 0) Then
                    Somme = Somme + 29
                Else
                    Somme = Somme + 28
                End If
            End If
        Next I
        Somme = Somme + V_Day
        Julien_Date = FormatCode(Str(I_An) & FormatCode(Str(Somme), 3), 4)

    End Function

    Public Sub Colorer(ByRef Ctl As System.Windows.Forms.Control)
        Dim CtlType As String
        CtlType = TypeName(Ctl)
        Select Case CtlType
            Case "CommandButton"

            Case "OptionButton"

            Case "TextBox"

            Case "CheckBox"

            Case "DateTimePicker"

            Case "Button"

            Case "DataGrid"

            Case "ABoutton"

        End Select
    End Sub

    Function Get_Datval_Frais(ByRef TypeCarte As String, ByRef W_Today As String) As Object

        Dim v_typdebitp_tdb_code As String
        Dim v_typdebitp_tdb_origtrs As String
        Dim v_typdebitp_tdb_syspay As String
        Dim v_typdebitp_tdb_typopr As Object
        Dim v_typdebitp_tdb_typdebit As String
        Dim v_typdebitp_tdb_pdiffgl As String
        Dim v_typdebitp_tdb_pperiod As String
        Dim v_typdebitp_tdb_durnval As String

        Dim RdoTypdebitp As Object
        SQLCode = "SELECT * FROM typdebitp" & " WHERE tdb_code = '" & TypeCarte & "'" & " AND (tdb_origtrs = '" & "D" & "' OR tdb_origtrs = '" & "*" & "')" & " AND (tdb_syspay = '" & RdoPorteurs("Prp_SysPay").Value & "' OR tdb_syspay ='" & " * " & "')" & " AND (tdb_typopr = '" & "F" & "' OR tdb_typopr = '" & " * " & "' )" & " ORDER BY tdb_origtrs DESC, tdb_syspay DESC, tdb_typopr DESC"
        RdoTypdebitp = SQLOpen(SQLCode)
        If RdoTypdebitp.EOF Then v_typdebitp_tdb_typdebit = "I"
        If v_typdebitp_tdb_typdebit = "I" Then
            W_TypDebit = "DI"
            Wv_Date = CDate(W_Today)
        Else
            W_TypDebit = "DD"
            Wt_Date = DateAdd(Microsoft.VisualBasic.DateInterval.Day, IIf(IsDBNull(RdoTypdebitp("tdb_durnval").Value), 0, RdoTypdebitp("tdb_durnval").Value), CDate(W_Today))
            SQLCode = "SELECT ppr_datefin FROM pperiodes" & " WHERE ppr_code = '" & RdoTypdebitp("tdb_pperiod").Value & "'" & " AND  '" & Wt_Date & "' BETWEEN ppr_datedeb AND ppr_datefin"
            TempoRec = SQLOpen(SQLCode)
            If TempoRec.EOF Then
                Wv_Date = InsertDate(NullOK(W_Today))
            Else
                Wv_Date = CDate(Calcul_Date(Wv_Date, TempoRec("tdb_pdiffgl").Value))
            End If
        End If
        Get_Datval_Frais = Wv_Date
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Matching()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub Matching(ByRef TrsNumAut As String, ByRef TrsArn As String)
        If IsDBNull(Trim(TrsNumAut)) Or Trim(TrsNumAut) = "000000" Then
            W_Matching = ""
            W_Match = False
        Else
            SQLCode = " SELECT Count(*) as MaxCount FROM histoauto " _
            & " WHERE hat_arn='" & NullOK(TrsArn) & "'"
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                Exit Sub
            End If

            If Val(TempoRec("MaxCount").Value.ToString()) > 0 Then
                W_Matching = "TRANSACTION MATCHED"
                W_Match = False
            Else
                W_Matching = "TRANSACTION NOT MATCHED"
                W_Match = True
            End If
        End If
    End Sub

    Public Function NullDate(ByRef DTPicker As DateTimePicker, ByRef StrDate As String) As Date

        If Trim(StrDate) <> "" Then
            NullDate = DateValue(StrDate)
            DTPicker.Checked = True
        Else
            NullDate = GetDate()
            DTPicker.Checked = False
        End If
    End Function

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Cal_Cluhn()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         :
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------
    Public Sub FrmColor(ByRef CtlP As System.Windows.Forms.Form)

        '
        Try
            Dim Ctl As System.Windows.Forms.Control
            Dim CtlType As String
            Dim x As String
            Dim Obj As Object
            Dim Ctl1 As System.Windows.Forms.Control
            Dim Ctl2 As System.Windows.Forms.Control
            Dim Ctl3 As System.Windows.Forms.Control
            Dim Ctl4 As System.Windows.Forms.Control
            Dim Ctl5 As System.Windows.Forms.Control
            Dim Ctl6 As System.Windows.Forms.Control
            Dim Ctl7 As System.Windows.Forms.Control
            Dim Ctl8 As System.Windows.Forms.Control
            Dim Ctl9 As System.Windows.Forms.Control
            Dim Color0 As String

            ActColor(CtlP)
            For Each Ctl In CtlP.Controls
                ActColor(Ctl)
                For Each Ctl1 In Ctl.Controls
                    ActColor(Ctl1)
                    For Each Ctl2 In Ctl1.Controls
                        ActColor(Ctl2)
                        For Each Ctl3 In Ctl2.Controls
                            ActColor(Ctl3)
                            For Each Ctl4 In Ctl3.Controls
                                ActColor(Ctl4)
                                For Each Ctl5 In Ctl4.Controls
                                    ActColor(Ctl5)
                                    For Each Ctl6 In Ctl5.Controls
                                        ActColor(Ctl6)
                                        For Each Ctl7 In Ctl6.Controls
                                            ActColor(Ctl7)
                                            For Each Ctl8 In Ctl7.Controls
                                                ActColor(Ctl8)
                                                For Each Ctl9 In Ctl8.Controls
                                                    ActColor(Ctl9)
                                                Next
                                            Next
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next Ctl
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ActColor(ByRef Ctl As Object)
        Dim CtlType As String
        Dim Color01 As String
        CtlType = TypeName(Ctl)

        Select Case CtlType
            Case "CommandButton"

            Case "OptionButton"

            Case "TextBox"

            Case "CheckBox"

            Case "DateTimePicker"

            Case "Button"
                Ctl_control(CtlType)
                If Ctl.text <> "" Then
                    Ctl.BackColor = System.Drawing.Color.FromName(BackColor)
                    Ctl.ForeColor = System.Drawing.Color.White
                End If

            Case "RadioButton"

            Case "TabControl"

            Case "ComboBox"

            Case "AGroup"
                Ctl_control(CtlType)
                Color01 = Ctl.BackColorLabel.ToString
                'Color([SteelBlue])
                If Color01 = "Color [Transparent]" Or Color01 = "Color [Empty]" Then
                    Ctl.FORECOLORLABEL = System.Drawing.Color.FromName(BackColorLabel)
                Else
                    Ctl.BackColorLabel = System.Drawing.Color.FromName(BackColorLabel)
                    Ctl.FORECOLORLABEL = System.Drawing.Color.FromName(FORCOLORLABEL)
                End If

            Case "DataGrid"
                Ctl_control(CtlType)
                Ctl.CaptionBackColor = System.Drawing.Color.FromName(CaptionBackColor)
                Ctl.CAPTIONFORECOLOR = System.Drawing.Color.FromName(CaptionForeColor)
                'Ctl.BackgroundColor = System.Drawing.Color.FromName(BackgroundColor)

            Case "TBoutton"
                Ctl_control(CtlType)
                Ctl.BackColorButtonAction = System.Drawing.Color.FromName(BackColorButtonAction)

                Ctl.BackColorButton = System.Drawing.Color.FromName(BackColorButton)
                Ctl.BackColorButtonAct = System.Drawing.Color.FromName(BackColorButtonAct)
                Ctl.BorderColor = System.Drawing.Color.FromName(BorderColor)
                'Ctl.ForColorButton = System.Drawing.Color.FromName(ForColorButton)
                'Ctl.ForColorButtonAct = System.Drawing.Color.FromName(ForColorButtonAct)
                'Ctl.ForColorButtonAction = System.Drawing.Color.FromName(ForColorButtonAction)




        End Select
    End Sub
    Public Sub Ctl_control(ByRef Control As String)

        If val_tmprec = False Then
            SQLCode = "select * from GV_ParamColor "
            If TestConn Then
                sError = ""
                TempoReco = ReturnRecordset(SQLCode, , , sError)
                If TempoReco Is Nothing Then
                    Message(sError, 16)
                    Exit Sub
                End If

            End If

            TempoReco = ReturnRecordset(SQLCode)
            If TempoReco.EOF Then
                Exit Sub
            Else
                val_tmprec = True
            End If
        End If

        While Not TempoReco.EOF
            If (TempoReco("COL_CTL").value.ToString = Control) Then
                BackColor = TempoReco("BackColor").value.ToString
                ForeColor = TempoReco("ForeColor").value.ToString
                BackColorButton = TempoReco("BackColorButton").value.ToString
                BackColorButtonAct = TempoReco("BackColorButtonAct").value.ToString
                BackColorButtonAction = TempoReco("BackColorButtonAction").value.ToString
                BorderColor = TempoReco("BorderColor").value.ToString
                BackColorLabel = TempoReco("BackColorLabel").value.ToString
                ForColorButton = TempoReco("ForColorButton").value.ToString
                ForColorButtonAct = TempoReco("ForColorButtonAct").value.ToString
                ForColorButtonAction = TempoReco("ForColorButtonAction").value.ToString
                BackgroundColor = TempoReco("BackgroundColor").value.ToString
                CaptionBackColor = TempoReco("CaptionBackColor").value.ToString
                CaptionForeColor = TempoReco("CaptionForeColor").value.ToString
                FORCOLORLABEL = TempoReco("FORCOLORLABEL").value.ToString
                If TempoReco("COL_CTL").value.ToString = "AGroup" Then
                    BackColorLabel2 = TempoReco("BackColorLabel").value.ToString
                End If
                TempoReco.MoveFirst()
                Exit Sub
            End If

            TempoReco.MoveNext()
        End While

        TempoReco.MoveFirst()
    End Sub
    Public Function Cal_Cluhn(ByVal W_Carte As String) As String

        Dim Indice As Byte
        Dim Unite As Byte
        Dim NChiffre As Integer
        Dim NbrCalcule As Integer
        Dim NbrSaisie As Integer
        Dim I As Integer

        Indice = Len(W_Carte)
        Unite = 2
        NbrSaisie = 0
        NbrCalcule = 0
        'Parcours de la Chaine entrée à partir de la fin caractere par caractere.....
        For I = Indice To 1 Step -1
            'Prendre à Chaque itération un caractere de la chaine en question...
            NChiffre = Val(Mid(W_Carte, I, 1))
            'Multiplier le Caractere extrait par Unite....
            NChiffre = NChiffre * Unite
            'si Le resultat de la multiplication est supérieur à 10 alors il faut le retrancher de 10 et l'ajouter à NbrCalcule...
            NbrCalcule = IIf(NChiffre >= 10, NbrCalcule + (NChiffre - 9), NbrCalcule + NChiffre)
            'et Unite bascule vers l'autre etat cad vers 0 si elle est déjà à 1 et vice-versa...
            Unite = IIf(Unite = 2, 1, 2)
        Next I
        'division entiere de la somme obtenue.....
        NbrSaisie = NbrCalcule \ 10
        'MF : c'est clair n'est ce pas!....
        NbrSaisie = (NbrSaisie + 1) * 10
        'enfin la fonction reçoit soit 0, soit NbrSaisie selon le resultat de l'expression ci-dessous.....
        Cal_Cluhn = IIf(NbrSaisie - NbrCalcule = 10, "0", Str(Val(NbrSaisie - NbrCalcule)))
    End Function

#Region "--------------------------------| Redimentionement --------------------"

    Public Sub redim_Object(ByRef ct As Object, ByVal x As Double, ByVal y As Double)

        Dim dgt As DataGridTableStyle
        Dim dgc As DataGridColumnStyle
        Dim i, k As Integer
        Dim xVal, yVal As Integer
        Dim ctl As Control
        Dim NameC As String
        Dim Panel As Object

        Dim x1 As Windows.Forms.TabControl
        Dim tabpag As Windows.Forms.TabPage

        NameC = TypeName(ct)
        If (NameC = "DataGrid") Then
            For Each dgt In ct.TableStyles
                For Each dgc In dgt.GridColumnStyles
                    dgc.Width = dgc.Width * x
                Next
            Next

        ElseIf (NameC = "StatusBar") Then
            For Each Panel In ct.Panels
                Panel.Width = Panel.Width * x
            Next

        ElseIf (NameC = "TabControl") Then
            xVal = CType((ct.ItemSize.Width * x), Integer)
            yVal = CType((ct.ItemSize.Height * y), Integer)
            ct.ItemSize = New Size(xVal, yVal)
        ElseIf (NameC = "AGroup") Then
            'MsgBox("width = " & ct.width & "_ XXX = " & Len(ct.text) * ct.font.size * 1.5 & " _")
            'ct.width = ct.width * x
            Dim label1 As New Label
            label1.AutoSize = True
            label1.Font = ct.font
            label1.Text = ct.text
            'MsgBox("Text = _" & label1.Text & "_ Longeuren px = _" & label1.PreferredWidth & "_")
            'MsgBox(label1.PreferredWidth)
            If ct.largeurgroup > 0 Then ct.largeurgroup = ct.width - (label1.PreferredWidth + 8)
            'ct.largeurgroup = ct.largeurgroup * x
        End If

        i = ct.Controls.Count
        If i > 0 Then
            For Each ctl In ct.Controls
                'If TypeName(ctl) = "RadioButton" Then
                'i = i
                'Else
                redim_Object(ctl, x, y)
                'End If

            Next ctl
        End If

    End Sub

#End Region

End Module