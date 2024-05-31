Imports System.Reflection
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Module ModSam
    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#       Version 1.11
    '#!#M#---------------------------------------------------------------------------------------------------------------


    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#       MAGIX5 BACK-OFFICE 5.1  © M2M 2000
    '#!#M#---------------------------------------------------------------------------------------------------------------
    '#!#M#                   Project     : MXBOHolder
    '#!#M#                   Description :
    '#!#M#                   Module      : ModSam.bas
    '#!#M#                   Description :
    '#!#M#
    '#!#M#   Write           Author      :                                    Date :
    '#!#M#
    '#!#M#   Release         Description :
    '#!#M#                   Author      :                                    Date :
    '#!#M#                   Description :
    '#!#M#                   Author      :                                    Date :
    '#!#M#--------------------------------------------------------------------------------------------------------------
    'Public rm As System.Resources.ResourceManager = New System.Resources.ResourceManager("maquette.ressources", System.Reflection.Assembly.GetExecutingAssembly())
    Public rm As System.Resources.ResourceManager = New System.Resources.ResourceManager("Maquette.Langue", System.Reflection.Assembly.GetExecutingAssembly()) '.GetExecutingAssembly())
    Public Frmcartep As New Frmcartepermis
    Public lotof As New LotOfSelection
    Public flistedossier As New ListeDossier
    Public lstcvicart As New lstcvicarte
    Public rechavc As New frmrechavancee
    Public ConfirmationS As New Confirmation
    Public listecart As New Listecarte
    Public AccesRightS As New AccesRight
    Public Amn_Code As String
    Public P_Binpath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly.Location)
    Dim P_conSqlServer As SqlConnection

    '#!#F#---------------------------------------------------------------------------------------------------------------
    '#!#F#                Function            : Main()
    '#!#F#                Type                : Global                                   (Local /Public/Global)
    '#!#F#                Input parameters    :
    '#!#F#                Output parameters   :
    '#!#F#                Returned parameters :
    '#!#F#                Description         : Fonction Principale Du Module
    '#!#F#                Caller Modules      :
    '#!#F#
    '#!#F#   Write        Author              :                                       Date :
    '#!#F#   Release      Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#                Description         :
    '#!#F#                Author              :                                       Date :
    '#!#F#--------------------------------------------------------------------------------------------------------------

    Public Sub Main()

        Dim str, sWs, sLoad As String
        Dim T() As String
        Dim sReturn As String
        Dim lg As Integer
        Dim Commande, url As String
        Try
            Axe1 = 1
            WebSp = False
            Langue = "F"
            TypeBase = "O"
            TypeBD = "O"

            'Dim args As String() = System.Environment.GetCommandLineArgs
            'If args.Length < 2 Then
            '    MsgBox("merci de lancer le programme depuis le menu principal")
            '    Exit Sub
            'End If

            'If (args(1) <> "cmd=prnc") Then
            '    MsgBox("merci de lancer le programme depuis le menu principal")
            '    Exit Sub
            'End If
            For Each arg As String In My.Application.CommandLineArgs
                If arg.StartsWith("user=") Then
                    ' Extract the user argument
                    CodeOperatriceUser = arg.Substring(5) ' Remove "user=" prefix
                    ' Exit the loop once the user argument is found
                End If
                If arg.StartsWith("centre=") Then
                    ' Extract the user argument
                    CodeCentre = arg.Substring(7) ' Remove "user=" prefix
                    ' Exit the loop once the user argument is found
                    Exit For
                End If
            Next
            ReadFileConfig()

            Frmcartep = New Frmcartepermis
            
            Application.Run(Frmcartep)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub lisence(ByRef D1 As Object)
        Dim Num_idrej As String

        SQLCode = "select SCF_NLICENSE from gv_siteconf "
        TempoRec = ReturnRecordset(SQLCode, , , sError)

        If TempoRec Is Nothing Then

            ErrSearch = True
        End If
        Num_idrej = NullOK(TempoRec("SCF_NLICENSE").Value.ToString)

        D1.Text = D1.Text & Num_idrej
    End Sub

    Public Function verif_version() As Boolean
        Dim obj As Object
        Dim SQLCodeN As String
        Dim base_Version As String
        SQLCodeN = "select DPE_VERSION,DPE_DATE from GV_DEPLEXE where upper(DPE_NOMEXE)='PMXGOVBOGESTIONPC.ZIP' and DPE_ETAT='T' order by DPE_DATE desc"
        obj = ReturnRecordset(SQLCodeN)
        '' M.O le 25/05/2012 13.1 : Implementation correction  'Gestion Time Out' faite par AATIFI .
        If obj Is Nothing Then
            ErrSearch = True
            Exit Function
        End If

        If obj Is Nothing Then
            Message(sError, 16)
            ErrSearch = True
            Return False
        End If
        If Not obj.EOF Then
            base_Version = obj("DPE_VERSION").Value.ToString
        Else
            Message("Problème de version détecté merci de contacter le support ASSIAQA .", 64)
            Return False
        End If

        If base_Version = Trim(AccesRightS.label_version.Text.Replace("Version", "")) Then
            Return True
        Else
            Message("Problème de version détecté merci de redémarrer l’application. ", 64)
            Return False
        End If

    End Function

    'Public Sub ReadFileConfig()
    '    Dim SReadLine As System.IO.Stream
    '    SReadLine = System.IO.File.OpenRead(P_Binpath & "\" & "consultCFG.cfg")
    '    Dim SrReadLine As System.IO.StreamReader = New StreamReader(SReadLine, System.Text.Encoding.ASCII)
    '    SrReadLine.BaseStream.Seek(0, SeekOrigin.Begin)
    '    ServerIP = SrReadLine.ReadLine()
    '    dataSource_BO = SrReadLine.ReadLine()
    '    CodeOperatrice = SrReadLine.ReadLine()
    '    MotPasse = SrReadLine.ReadLine()
    '    SrReadLine.Close()

    'End Sub
    Public Sub ReadFileConfig()
        Dim SReadLine As System.IO.Stream
        SReadLine = System.IO.File.OpenRead(P_Binpath & "\" & "consultCFG.cfg")
        Dim SrReadLine As System.IO.StreamReader = New StreamReader(SReadLine, System.Text.Encoding.ASCII)
        SrReadLine.BaseStream.Seek(0, SeekOrigin.Begin)
        ServerIP = DecryptStringFromBytes_Aes(Convert.FromBase64String(SrReadLine.ReadLine()), Encoding.UTF8.GetBytes("1A2B3C4D5E6F7890"))
        dataSource_BO = DecryptStringFromBytes_Aes(Convert.FromBase64String(SrReadLine.ReadLine()), Encoding.UTF8.GetBytes("1A2B3C4D5E6F7890"))
        CodeOperatrice = DecryptStringFromBytes_Aes(Convert.FromBase64String(SrReadLine.ReadLine()), Encoding.UTF8.GetBytes("1A2B3C4D5E6F7890"))
        MotPasse = DecryptStringFromBytes_Aes(Convert.FromBase64String(SrReadLine.ReadLine()), Encoding.UTF8.GetBytes("1A2B3C4D5E6F7890"))
        SrReadLine.Close()

    End Sub

    Function DecryptStringFromBytes_Aes(ByVal cipherText As Byte(), ByVal key As Byte()) As String
        ' Check arguments
        If cipherText Is Nothing OrElse cipherText.Length <= 0 Then
            Throw New ArgumentNullException("cipherText")
        End If
        If key Is Nothing OrElse key.Length <= 0 Then
            Throw New ArgumentNullException("key")
        End If

        ' Declare the string to hold the decrypted text
        Dim plaintext As String = Nothing

        ' Create an AES instance with the specified key
        Using aesAlg As New RijndaelManaged()
            aesAlg.Key = key
            aesAlg.Mode = CipherMode.ECB ' Electronic Codebook mode
            aesAlg.Padding = PaddingMode.PKCS7 ' PKCS#7 padding

            ' Create a decryptor to perform the stream transform
            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)

            ' Create the streams used for decryption
            Using msDecrypt As New System.IO.MemoryStream(cipherText)
                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As New System.IO.StreamReader(csDecrypt)
                        ' Read the decrypted bytes from the decrypting stream
                        plaintext = srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using

        ' Return the decrypted string
        Return plaintext
    End Function


    Public Function executeGetTable(ByVal Sqlcode As String) As DataTable

        Try
            Dim myAdapter As New SqlDataAdapter
            Dim datatable As New DataTable
            P_conSqlServer = New SqlConnection("Server=" & ServerIP & "; Database=" & dataSource_BO & " ;User Id=" & CodeOperatrice & ";Password=" & MotPasse)
            P_conSqlServer.Open()

            myAdapter.SelectCommand = New SqlCommand(Sqlcode, P_conSqlServer)
            myAdapter.Fill(datatable)
            P_conSqlServer.Close()
            Return datatable
        Catch ex As Exception
            MsgBox("Erreur d'accès à la base de données")
            Return Nothing
        End Try
    End Function

    Public Function executeGetDataSet(ByVal Sqlcode As String) As DataSet

        Try
            Dim myAdapter As New SqlDataAdapter
            Dim dtset As New DataSet
            P_conSqlServer = New SqlConnection("Server=" & ServerIP & "; Database=" & dataSource_BO & " ;User Id=" & CodeOperatrice & ";Password=" & MotPasse)
            P_conSqlServer.Open()

            myAdapter.SelectCommand = New SqlCommand(Sqlcode, P_conSqlServer)
            myAdapter.Fill(dtset, "MyTable")
            P_conSqlServer.Close()
            Return dtset
        Catch ex As Exception
            MsgBox("Erreur d'accès à la base de données")
            Return Nothing
        End Try
    End Function


    Public Function executeScalar(ByVal Sqlcode As String) As Integer

        Try
            Dim p_sqlCommand As New SqlCommand
            Dim result As Integer = 0
            P_conSqlServer = New SqlConnection("Server=" & ServerIP & "; Database=" & dataSource_BO & " ;User Id=" & CodeOperatrice & ";Password=" & MotPasse)
            P_conSqlServer.Open()

            p_sqlCommand = New SqlCommand(Sqlcode, P_conSqlServer)

            result = CInt(p_sqlCommand.ExecuteScalar)
            P_conSqlServer.Close()
            Return result
        Catch ex As Exception
            MsgBox("Erreur d'accès à la base de données")
            Return Nothing
        Finally
            P_conSqlServer.Close()
        End Try
    End Function


    

End Module