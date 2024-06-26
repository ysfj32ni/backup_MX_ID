
Public Class FrmActivation
    Public NumCarte, DATESRV_NOW, Return_SQLExecute As String
    Private Temporec_ref As Object
    Dim date_finR, date_debutR As String
    Private Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Not verif_version() Then Exit Sub
        If MessageBox.Show("Êtes-vous sûre de vouloir activer la carte ?", "Magix E-Gov", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            MessageBox.Show("Il faut passer par l'activation de la carte ...!", "Magix E-Gov", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        NumCarte = Replace(txt_carte.Text, " ", "")
        Dim Err As String
        Dim RD_vefir As Object
        Dim VAL_CI As String

        If dtpkr_activation.Checked = False Then
            Message("Date Activation Invalid ...!", 64)
            dtpkr_activation.Focus()
            Exit Sub
        End If


        SQLCode = "SELECT  to_char(sysdate,'DD/MM/YYYY') as DATESRV_NOW from dual "

        TempoRec = ReturnRecordset(SQLCode)
        If TempoRec Is Nothing Then
            ErrSearch = True
            Exit Sub
        End If

        DATESRV_NOW = NullOK(TempoRec("DATESRV_NOW").value.ToString())



        SQLCode = "select * from GV_ReceptionLot where RCL_TYPE_ENREG='CDE' and RCL_SERIE_CARTE='" & NumCarte & "'"

        RD_vefir = ReturnRecordset(SQLCode)
        If RD_vefir Is Nothing Then
            ErrSearch = True
            Exit Sub
        End If
        If Not RD_vefir.Eof Then

            Message("Cette Carte est déclarée comme une Carte à détruire...!", 64)
            ErrSearch = True
            Exit Sub
        End If

        SQLCode = "SELECT COUNT(*) as ICount FROM gv_cartlstnoire where CLN_NUMCARTE='" & NumCarte & "' "
        sError = ""
        TempoRec = ReturnRecordset(SQLCode, , , sError)
        If TempoRec Is Nothing Then
            ErrSearch = True
            Exit Sub
        End If
        If Not TempoRec.Eof Then
            If Val(TempoRec("ICount").Value.ToString) >= 1 Then
                Message("Cette carte est en opposition et elle doit être retournée pour destruction...!", 64)

                SQLCode = "select SEQ_REFLOT.nextval as REFLOT  from dual"
                TempoRec = ReturnRecordset(SQLCode)
                If TempoRec Is Nothing Then
                    ErrSearch = True
                    Exit Sub
                End If

                SQLCode = " SELECT GVCI_CODE,GVCI_LIBELLE FROM  GV_CENTREIMMATRICUL,gv_parcentre " _
                        & " WHERE PAC_CODE =GVCI_CODE"
                TempoRec = ReturnRecordset(SQLCode)
                If TempoRec Is Nothing Then
                    ErrSearch = True
                    Exit Sub
                End If
                If TempoRec.EOF Then
                    VAL_CI = ""
                Else
                    VAL_CI = NullOK(TempoRec("GVCI_CODE").Value.ToString)
                End If

                SQLCode = "INSERT INTO GV_ReceptionLot( " _
                                                          & " RCL_TYPE_ENREG,RCL_REF_ENREG,RCL_CODE_CENTRE,RCL_SERIE_CARTE,RCL_CODE_MOTIF,ETAT,RCL_DATE_ENV,DATE_IMPORT,RCL_DATE_OPPERATION,RCL_TYPECARTE,RCL_ETAT_ENV,RCL_CODE_SITE) VALUES(" _
                                                          & " 'CDE','" & ZeroX(NullOK(TempoRec("REFLOT").Value.ToString), 10) & "','" & ChaineOK(VAL_CI) & "','" & ChaineOK(NumCarte) & "'," _
                                                          & " '06','N','" & CDate(DATESRV_NOW) & "','" & CDate(DATESRV_NOW) & "','" & CDate(DATESRV_NOW) & "','PC','N','" & ChaineOK(VAL_CI) & "')"

                Return_SQLExecute = SQLExecute(SQLCode)
                If Return_SQLExecute <> "1" Then
                    ErrSearch = True
                    Exit Sub
                End If
                Me.Close()
                Exit Sub

            End If
        End If


        SQLCode = " SELECT  to_number(PRP_NUMOF) as lot,PRP_NUMDOSS,to_char(PRP_ANDEPOT) as PRP_ANDEPOT,PRP_NSITE,PRP_CODCI FROM gv_carte " _
                                             & " WHERE prp_numcarte = replace( '" & ChaineOK(NumCarte) & "',' ','') and PRP_TYPECARTE='PC' "

        sError = ""
        TempoRec_act = ReturnRecordset(SQLCode, , , sError)

        If TempoRec_act Is Nothing Then
            ErrSearch = True
            Exit Sub
        End If

        If Not TempoRec_act.eof Then

            SQLCode = " SELECT ETAT FROM GV_ReceptionLot " _
                                                   & " WHERE RCL_NUM_LOT= '" & NullOK(TempoRec_act("LOT").Value.ToString) & "' AND RCL_TYPE_ENREG='RLO' "
            sError = ""
            TempoRec = ReturnRecordset(SQLCode, , , sError)
            If TempoRec Is Nothing Then
                Message(sError, 16)
                ErrSearch = True
                Exit Sub
            End If
            If TempoRec.Eof Then
                MsgBox("Lot de cette carte non réceptionné...!", 64)
                ErrSearch = True
                Exit Sub
            ElseIf NullOK(TempoRec("ETAT").Value.ToString) = "X" Then
                MsgBox("Lot de cette carte non encore clotûrer...!", 64)
                ErrSearch = True
                Exit Sub
            End If
        Else
            MsgBox("Carte permis inexistante dans la base ...!", 64)
            ErrSearch = True
            Exit Sub
        End If


        SQLCode = " SELECT * FROM GV_ReceptionLot " _
                                                 & " WHERE RCL_SERIE_CARTE= '" & NumCarte & "' AND RCL_TYPE_ENREG='CAC'"
        sError = ""
        TempoRec_activ = ReturnRecordset(SQLCode, , , sError)
        If TempoRec_activ Is Nothing Then
            ErrSearch = True
            Exit Sub
        End If
        If TempoRec_activ.Eof Then

            SQLCode = "select SEQ_REFLOT.nextval as REFLOT  from dual"
            Temporec_ref = ReturnRecordset(SQLCode)
            If Temporec_ref Is Nothing Then
                ErrSearch = True
                Exit Sub
            End If
            SQLCode = "INSERT INTO GV_ReceptionLot( " _
                      & " RCL_TYPE_ENREG,RCL_REF_ENREG,RCL_SERIE_CARTE,ETAT,RCL_DATE_ENV,DATE_IMPORT,RCL_DATE_OPPERATION,RCL_TYPECARTE, " _
                      & " RCL_ETAT_ENV,RCL_CODE_CENTRE,RCL_CODE_SITE,RCL_ANNEE_DEPO,RCL_NUM_DOSS) VALUES(" _
                      & " 'CAC','" & ZeroX(NullOK(Temporec_ref("REFLOT").Value.ToString), 10) & "','" & NumCarte & "','N', " _
                      & " '" & InsertDate(dtpkr_activation.Value) & "','" & InsertDate(dtpkr_activation.Value) & "', " _
                      & " '" & InsertDate(dtpkr_activation.Value) & "','PC','N', " _
                      & " '" & NullOK(TempoRec_act("PRP_CODCI").Value.ToString) & "','" & NullOK(TempoRec_act("PRP_NSITE").Value.ToString) & "', " _
                      & " '" & NullOK(TempoRec_act("PRP_ANDEPOT").Value.ToString) & "','" & NullOK(TempoRec_act("PRP_NUMDOSS").Value.ToString) & "')"

            Return_SQLExecute = SQLExecute(SQLCode)
            If Return_SQLExecute <> "1" Then
                ErrSearch = True
                Exit Sub
            End If

        End If

        Call ActionBase(TableAcces(1).Code, 7, NumCarte)


        Message("La carte a été Activée avec succée...!", 64)


        date_finR = GetDateTime()
        ACTIVITE_TRACE("AC", "", ChaineOK(NumCarte), date_debutR, date_finR)
        Me.Close()

    End Sub

    Private Sub FrmActivation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        date_debutR = GetDateTime()
        dtpkr_activation.Value = GetDate()
        dtpkr_activation.Checked = False
        Me.CenterToScreen()
    End Sub
    Public Sub ACTIVITE_TRACE(ByVal typetrace As String, ByVal numlot As String, ByVal numCarte As String, ByVal datedebut As String, ByVal datefin As String)
        Select Case typetrace
            Case "RC"
                Dim code_acti As String = getCodeACtivite()
                SQLCode = "insert into GV_ACTIVITE(ACT_ID,ACT_CODEAG,ACT_OPRCODE,ACT_TYPEOPER,ACT_ID_LOT,ACT_ETAPE,ACT_DEB_RECEP,ACT_FIN_RECEP,ACT_INSER)" _
                & "values( '" & code_acti & "',(select pac_code from gv_parcentre),'" & CodeOperatrice & "','D','" & numlot & "','RC',TO_DATE ('" & datedebut & "','DD/MM/YYYY HH24:mi:ss'),TO_DATE ('" & datefin & "','DD/MM/YYYY HH24:mi:ss'),sysdate)"
            Case "CL"
                SQLCode = " update GV_ACTIVITE set ACT_ETAPE='CL',ACT_CLOT_LOT=TO_DATE ('" & datefin & "','DD/MM/YYYY HH24:mi:ss') where ACT_ID_LOT='" & numlot & "'"
            Case "SP"
                Dim code_acti As String = getCodeACtivite()
                SQLCode = "insert into GV_ACTIVITE(ACT_ID,ACT_CODEAG,ACT_OPRCODE,ACT_TYPEOPER,ACT_ID_CARTE,ACT_ETAPE,ACT_DEB_SUPL,ACT_FIN_SUPL,ACT_INSER)" _
                & "values( '" & code_acti & "',(select pac_code from gv_parcentre),'" & CodeOperatrice & "','D','" & numCarte & "','SP',TO_DATE ('" & datedebut & "','DD/MM/YYYY HH24:mi:ss'),TO_DATE ('" & datefin & "','DD/MM/YYYY HH24:mi:ss'),sysdate)"
            Case "MA"
                Dim code_acti As String = getCodeACtivite()
                SQLCode = "insert into GV_ACTIVITE(ACT_ID,ACT_CODEAG,ACT_OPRCODE,ACT_TYPEOPER,ACT_ID_CARTE,ACT_ETAPE,ACT_DEB_MANQ,ACT_FIN_MANQ,ACT_INSER)" _
                & "values( '" & code_acti & "',(select pac_code from gv_parcentre),'" & CodeOperatrice & "','D','" & numCarte & "','MA',TO_DATE ('" & datedebut & "','DD/MM/YYYY HH24:mi:ss'),TO_DATE ('" & datefin & "','DD/MM/YYYY HH24:mi:ss'),sysdate)"
            Case "AC"
                'jrhanim 07/02/2014 remplacer date début manquant par activé
                Dim code_acti As String = getCodeACtivite()
                SQLCode = "insert into GV_ACTIVITE(ACT_ID,ACT_CODEAG,ACT_OPRCODE,ACT_TYPEOPER,ACT_ID_CARTE,ACT_ETAPE,ACT_DEB_ACTIV,ACT_FIN_ACTIV,ACT_INSER)" _
                & "values( '" & code_acti & "',(select pac_code from gv_parcentre),'" & CodeOperatrice & "','D','" & numCarte & "','AC',TO_DATE ('" & datedebut & "','DD/MM/YYYY HH24:mi:ss'),TO_DATE ('" & datefin & "','DD/MM/YYYY HH24:mi:ss'),sysdate)"
            Case "DS"
                Dim code_acti As String = getCodeACtivite()
                SQLCode = "insert into GV_ACTIVITE(ACT_ID,ACT_CODEAG,ACT_OPRCODE,ACT_TYPEOPER,ACT_ID_CARTE,ACT_ETAPE,ACT_DEB_DEST,ACT_FIN_DEST,ACT_INSER)" _
                & "values( '" & code_acti & "',(select pac_code from gv_parcentre),'" & CodeOperatrice & "','D','" & numCarte & "','DS',TO_DATE ('" & datedebut & "','DD/MM/YYYY HH24:mi:ss'),TO_DATE ('" & datefin & "','DD/MM/YYYY HH24:mi:ss'),sysdate)"

        End Select

        Return_SQLExecute = SQLExecute(SQLCode)
        If Return_SQLExecute <> "1" Then
            ErrSearch = True
            Exit Sub
        End If
    End Sub
    Public Function getCodeACtivite() As String
        Dim anneeseq As String
        Dim anneeencour As String
        SQLCode = "select ANNESEQUENCE from GV_ANNESEQUENCE where TYPTITRE='AC'"
        TempoRec = ReturnRecordset(SQLCode)
        If TempoRec Is Nothing Then
            ErrSearch = True
            Exit Function
        End If
        If Not TempoRec.EOF Then
            anneeseq = NullOK(TempoRec("ANNESEQUENCE").Value.ToString)
            anneeencour = Mid(Today, 7, 4)
            If CInt(anneeencour) > CInt(anneeseq) Then
                SQLCode = "update GV_ANNESEQUENCE set ANNESEQUENCE='" & ChaineOK(anneeencour) & "' where TYPTITRE='AC'"
                Return_SQLExecute = SQLExecute(SQLCode)
                If Return_SQLExecute <> "1" Then
                    ErrSearch = True
                    Exit Function
                End If

                SQLCode = "DROP  SEQUENCE IDACTIVITE_PC"
                Return_SQLExecute = SQLExecute(SQLCode)
                If Return_SQLExecute <> "1" Then
                    ErrSearch = True
                    Exit Function
                End If

                SQLCode = "CREATE SEQUENCE IDACTIVITE_PC START WITH 1 INCREMENT BY 1 MAXVALUE 99999999 NOCYCLE NOCACHE ORDER"
                Return_SQLExecute = SQLExecute(SQLCode)
                If Return_SQLExecute <> "1" Then
                    ErrSearch = True
                    Exit Function
                End If
            End If

            SQLCode = "select IDACTIVITE_PC.nextval as numdossier  from dual"
            TempoRec = ReturnRecordset(SQLCode)
            If TempoRec Is Nothing Then
                ErrSearch = True
                Exit Function
            End If
            If Not TempoRec.EOF Then
                getCodeACtivite = NullOK(TempoRec("numdossier").Value.ToString)
                getCodeACtivite = ZeroX(getCodeACtivite, 8)
                getCodeACtivite = Mid(anneeencour, 3, 2) & getCodeACtivite

                SQLCode = "select pac_code from gv_parcentre"
                TempoRec = ReturnRecordset(SQLCode, , , sError)
                If TempoRec Is Nothing Then
                    ErrSearch = True
                    Exit Function
                End If
                getCodeACtivite = ZeroX(NullOK(TempoRec("PAC_CODE").Value.ToString), 2) & getCodeACtivite
            End If
        End If
    End Function

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdOK.ClickButtonArea

    End Sub
End Class