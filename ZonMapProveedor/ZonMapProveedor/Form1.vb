Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1



    Public Property Server As String
    Public Property User As String
    Public Property Password As String
    Public Property BD As String


    Public Property CmnServer As String
    Public Property CmnUser As String
    Public Property CmnPassword As String
    Public Property CmnBD As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SELServidor.ShowDialog()
        If SELServidor.DialogResult = Windows.Forms.DialogResult.OK Then
            Server                  = SELServidor.Server
            User                    = SELServidor.User
            Password                = SELServidor.Password
            BD                      = SELServidor.BD
            lblConn.Text            = String.Join("¬", Server, User, Password, BD)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SrvFrm As New SELServidor()
        SrvFrm.ShowDialog()
        If SrvFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            CmnServer          = SrvFrm.Server
            CmnUser            = SrvFrm.User
            CmnPassword        = SrvFrm.Password
            CmnBD              = SrvFrm.BD
            lblDbCmn.Text      = String.Join("¬", CmnServer, CmnUser, CmnPassword, CmnBD)
        End If
    End Sub

    Private Function CreateLookup(ByVal treeZonExterno1 As TreeView) As Dictionary(Of String, TreeNode)
        Dim retval As New Dictionary(Of String, TreeNode)

        Dim It As New Queue(Of TreeNode)
        For Each basenode As TreeNode In treeZonExterno1.Nodes
            It.Enqueue(basenode)
        Next

        While It.Count > 0
            Dim Nod = It.Dequeue()
            For Each subnodes As TreeNode In Nod.Nodes
                It.Enqueue(subnodes)
            Next
            retval.Add(Nod.Name, Nod)
        End While
        Return retval
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If {CmnBD, CmnPassword, CmnServer, CmnUser}.Any(Function(F) String.IsNullOrEmpty(F)) Then
            MessageBox.Show("Hay que seleccionar el base de datos comun")
            Exit Sub
        End If

        If Not cmbTipoProv.Items.Cast(Of String).Any(Function(f) f = cmbTipoProv.Text) Then
            cmbTipoProv.Items.Add(cmbTipoProv.Text)
        End If

        Using con = New SqlClient.SqlConnection(BDComunString)
            con.Open()
            Using Cmd = New SqlClient.SqlCommand("SELECT * From Tbl_ZoneGenericProvider WHERE ZGP_Prov = @Prov ORDER BY ZGP_Cod1 desc,ZGP_Cod2 desc,ZGP_Cod3 desc,ZGP_Cod4 desc", con)
                Cmd.Parameters.Add(New SqlClient.SqlParameter("@Prov", cmbTipoProv.Text))

                treeZonExterno.BeginUpdate()
                treeZonExterno.Nodes.Clear()


                'Depth, Parent, NodeKey,nodeName
                Dim PostNodes As New List(Of Tuple(Of Integer, String, String, String))

                Using rdr = Cmd.ExecuteReader()
                    While rdr.Read()
                        Dim Parent = If(rdr("ZGP_Cod2") Is DBNull.Value OrElse String.IsNullOrWhiteSpace(rdr("ZGP_Cod2").ToString), Nothing, rdr("ZGP_Cod2"))
                        If Parent Is Nothing Then
                            treeZonExterno.Nodes.Add(rdr("ZGP_Cod1").ToString, rdr("ZGP_Name").ToString & " [" & rdr("ZGP_Cod1").ToString & "]")
                        Else
                            If (rdr("ZGP_Cod4") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(rdr("ZGP_Cod4").ToString)) Then
                                Dim padNod = treeZonExterno.Nodes.Find(rdr("ZGP_Cod3").ToString(), True).FirstOrDefault
                                If padNod IsNot Nothing Then
                                    padNod.Nodes.Add(rdr("ZGP_Cod4").ToString, rdr("ZGP_Name").ToString & " [" & rdr("ZGP_Cod4").ToString & "]")
                                Else
                                    PostNodes.Add(Tuple.Create(4, rdr("ZGP_Cod3").ToString(), rdr("ZGP_Cod4").ToString, rdr("ZGP_Name").ToString))
                                End If
                            ElseIf (rdr("ZGP_Cod3") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(rdr("ZGP_Cod3").ToString)) Then
                                Dim padNod = treeZonExterno.Nodes.Find(rdr("ZGP_Cod2").ToString(), True).FirstOrDefault
                                If padNod IsNot Nothing Then
                                    padNod.Nodes.Add(rdr("ZGP_Cod3").ToString, rdr("ZGP_Name").ToString & " [" & rdr("ZGP_Cod3").ToString & "]")
                                Else
                                    PostNodes.Add(Tuple.Create(3, rdr("ZGP_Cod2").ToString(), rdr("ZGP_Cod3").ToString, rdr("ZGP_Name").ToString))
                                End If
                            Else
                                Dim padNod = treeZonExterno.Nodes.Find(rdr("ZGP_Cod1").ToString(), True).FirstOrDefault
                                If padNod IsNot Nothing Then
                                    padNod.Nodes.Add(rdr("ZGP_Cod2").ToString, rdr("ZGP_Name").ToString & " [" & rdr("ZGP_Cod2").ToString & "]")
                                Else
                                    PostNodes.Add(Tuple.Create(2, rdr("ZGP_Cod1").ToString(), rdr("ZGP_Cod2").ToString, rdr("ZGP_Name").ToString))
                                End If
                            End If

                            'Que nivel estamos?
                        End If
                        'BdCombo.Items.Add(rdr("DATABASE_NAME").ToString)
                    End While
                End Using

                Dim Lookup As Dictionary(Of String, TreeNode) = Nothing
                Try
                    Lookup = CreateLookup(treeZonExterno)
                Catch ex As Exception
                    ' Claves duplicados, good luck!
                End Try
                Dim SB As New System.Text.StringBuilder()
                If PostNodes.Any Then
                    For Each nod In PostNodes.OrderBy(Function(f) f.Item1)
                        'Depth, Parent, NodeKey,nodeName

                        If String.IsNullOrWhiteSpace(nod.Item2) Then
                            Continue For
                            'Cojones!
                        End If
                        Dim pad As TreeNode = Nothing

                        If Lookup IsNot Nothing Then
                            'Dim pad = treeZonExterno.Nodes.Find(nod.Item2, True).FirstOrDefault
                            If Not Lookup.TryGetValue(nod.Item2, pad) Then
                                SB.AppendLine("Padre [" & nod.Item2 & "] No Encontrado, no se puede insertar zona " & nod.Item4 & " [" & nod.Item3 & "]")
                            Else
                                Dim newnode = pad.Nodes.Add(nod.Item3, nod.Item4 & " [" & nod.Item3 & "]")
                                If Not Lookup.ContainsKey(nod.Item3) Then Lookup.Add(nod.Item3, newnode)
                            End If
                        Else
                            pad = treeZonExterno.Nodes.Find(nod.Item2, True).FirstOrDefault
                            If pad Is Nothing Then
                                SB.AppendLine("Padre [" & nod.Item2 & "] No Encontrado, no se puede insertar zona " & nod.Item4 & " [" & nod.Item3 & "]")
                            Else
                                Dim newnode = pad.Nodes.Add(nod.Item3, nod.Item4 & " [" & nod.Item3 & "]")
                                'Lookup.Add(nod.Item3, newnode)
                            End If
                        End If
                        

                        'nod.
                    Next
                End If

                treeZonExterno.Sort()

                txtLog.Clear() : txtLog.Text = SB.ToString()
                treeZonExterno.EndUpdate()

            End Using

        End Using
    End Sub

    Private Sub Form1_Unload(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Using GG = New System.IO.StreamWriter("Opt.Ini", False)
            GG.WriteLine("Loc#" & String.Join("¬", Server, BD, User, Password))
            GG.WriteLine("Cmn#" & String.Join("¬", CmnServer, CmnBD, CmnUser, CmnPassword))
            GG.WriteLine("TIPOS#" & String.Join("¬", cmbTipoProv.Items))
        End Using
    End Sub

    Dim TipoMapping As Dictionary(Of String, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("Opt.Ini") Then

            Using GG = New System.IO.StreamReader("Opt.Ini", False)
                While Not GG.EndOfStream
                    Dim Str = GG.ReadLine()
                    Select Case Str.Substring(0, 3)
                        Case "Loc"
                            Dim Vals     = Str.Split("#"c)(1).Split("¬"c)
                            Server       = Vals(0)
                            BD           = Vals(1)
                            User         = Vals(2)
                            Password     = Vals(3)
                            lblConn.Text = String.Join("¬", Server, User, Password, BD)
                        Case "Cmn"
                            Dim Vals      = Str.Split("#"c)(1).Split("¬"c)
                            CmnServer     = Vals(0)
                            CmnBD         = Vals(1)
                            CmnUser       = Vals(2)
                            CmnPassword   = Vals(3)
                            lblDbCmn.Text = String.Join("¬", CmnServer, CmnUser, CmnPassword, CmnBD)
                        Case "TIPOS"
                            Dim Vals      = Str.Split("#"c)(1).Split("¬"c)
                            cmbTipoProv.Items.Clear()
                            For Each itm In Vals
                                cmbTipoProv.Items.Add(itm)
                            Next
                    End Select
                    'If Str.Substring(0, 3) = "Loc" Then

                    'End If
                    'GG.ReadLine("Loc#" & String.Join("¬", Server, BD, User, Password))
                    'GG.WriteLine("Cmn#" & String.Join("¬", CmnServer, CmnBD, CmnUser, CmnPassword))
                End While
            End Using
        End If
        TipoMapping = New Dictionary(Of String, String)
        If System.IO.File.Exists("Tipo_ColumnaMapeo.xml") Then
            For Each mapeao In XDocument.Load("Tipo_ColumnaMapeo.xml")...<TblZona>
                TipoMapping.Add(mapeao.@Code, mapeao.@Suffix)
            Next
        End If

    End Sub

    ReadOnly Property BDString As String
        Get
            Dim SQLSB = New SqlClient.SqlConnectionStringBuilder()
            SQLSB.DataSource = Server
            SQLSB.UserID = User
            SQLSB.Password = Password
            SQLSB.InitialCatalog = BD
            Return SQLSB.ToString
        End Get
    End Property

    ReadOnly Property BDComunString As String
        Get
            Dim SQLSB = New SqlClient.SqlConnectionStringBuilder()
            SQLSB.DataSource = CmnServer
            SQLSB.UserID = CmnUser
            SQLSB.Password = CmnPassword
            SQLSB.InitialCatalog = CmnBD
            Return SQLSB.ToString
        End Get
    End Property

    Private LastExtCode As String
    Private Sub treeZonExterno_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeZonExterno.AfterSelect
        Dim ZonName = e.Node.Text.Split(","c).FirstOrDefault.Split("["c).First.Replace("'", "''").Trim()  ' RANSOL, SUPUTA, ANDORRA
        LastExtCode = e.Node.Name

        txtCodExtern.Text = LastExtCode

        JnZonBusc.Text = ZonName

    End Sub

    Private Sub JnZonBusc_TextChanged(sender As Object, e As EventArgs) Handles JnZonBusc.TextChanged
        Timer1.Enabled = False
        Timer1.Stop()


        Timer1.Enabled = True
        Timer1.Start()
        ToolStripStatusLabel1.Text = "Updating...."
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Dim ZonName = JnZonBusc.Text
        Dim tipo = cmbTipoProv.Text
        If Not TipoMapping.TryGetValue(tipo, tipo) Then
            tipo = cmbTipoProv.Text
        End If

        ToolStripStatusLabel1.Text = "Updating...."
        Me.Invalidate()

        Using con = New SqlClient.SqlConnection(BDString)
            Try
                con.Open()
            Catch ex As Exception
                Exit Sub
            End Try

            treeZonJuniper.BeginUpdate()
            treeZonJuniper.Nodes.Clear()
            Using cmd = New SqlCommand("Select TOP 20 Id_Zon, Zon_Nombre_ES, Zon_Mostrar" & tipo & ", zon_Zonas" & tipo & " FROM Tbl_Zona WHERE zon_Zonas" & tipo & " = '" & LastExtCode & "'", con)
                Using RDR = cmd.ExecuteReader()
                    While RDR.Read()
                        Dim Key = String.Join("|"c, {RDR("Id_Zon").ToString(), RDR("Zon_Mostrar" & tipo).ToString, RDR("zon_Zonas" & tipo).ToString, tipo})
                        Dim NNode = treeZonJuniper.Nodes.Add(Key, RDR("Zon_Nombre_ES").ToString())
                        NNode.ForeColor = Color.Green
                        NNode.Text &= " [" & RDR("Id_Zon").ToString & "]- " & tipo & ": " & RDR("zon_Zonas" & tipo).ToString

                        'NNode.ForeColor = If(Not String.IsNullOrWhiteSpace(RDR("zon_Zonas" & tipo).ToString), Color.Green, Color.Black)
                    End While
                End Using

            End Using

            Using cmd = New SqlCommand("Select TOP 20 Id_Zon,[Id_ZonPadre], Zon_Nombre_ES, Zon_Mostrar" & tipo & ", zon_Zonas" & tipo & " FROM Tbl_Zona WHERE (zon_Zonas" & tipo & " Is NULL OR zon_Zonas" & tipo & " <> '" & LastExtCode & "') AND " &
                                       "(Zon_Nombre_ES like '%" & ZonName & "%' OR zon_sinonimos LIKE '%" & ZonName & "%')", con)
                Using RDR = cmd.ExecuteReader()
                    While RDR.Read()
                        Dim Key = String.Join("|"c, {RDR("Id_Zon").ToString(), RDR("Zon_Mostrar" & tipo).ToString, RDR("zon_Zonas" & tipo).ToString, tipo})
                        Dim NNode = treeZonJuniper.Nodes.Add(Key, RDR("Zon_Nombre_ES").ToString())
                        If Not String.IsNullOrWhiteSpace(RDR("zon_Zonas" & tipo).ToString) Then
                            NNode.ForeColor = Color.Orange
                            NNode.Text &= " [" & RDR("Id_Zon").ToString & "] - " & tipo & ": " & RDR("zon_Zonas" & tipo).ToString
                        Else
                            Dim PADRE = RDR("Id_ZonPadre").ToString()
                            Dim LocString As New System.Text.StringBuilder()
                            Using con2 = New SqlClient.SqlConnection(BDString)
                                con2.Open()
                                While Not String.IsNullOrWhiteSpace(PADRE)
                                    Using SubRDR = New SqlCommand("SELECT Id_Zon,[Id_ZonPadre], Zon_Nombre_ES From Tbl_Zona WHERE Id_Zon=" & PADRE, con2).ExecuteReader()
                                        If SubRDR.Read() Then
                                            LocString.Append(", ").Append(SubRDR("Zon_Nombre_Es"))
                                            PADRE = SubRDR("Id_ZonPadre").ToString
                                        End If
                                    End Using
                                End While
                            End Using
                            NNode.Text &= LocString.ToString()
                        End If
                        'NNode.ForeColor = If(Not String.IsNullOrWhiteSpace(RDR("zon_Zonas" & tipo).ToString), Color.Green, Color.Black)
                    End While
                End Using
            End Using
            treeZonJuniper.EndUpdate()
        End Using
        ToolStripStatusLabel1.Text = "Done."
    End Sub

    Private Sub treeZonJuniper_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeZonJuniper.AfterSelect
        '''' Dim Key = String.Join("|"c, {RDR("Id_Zon").ToString(), RDR("Zon_Mostrar" & tipo).ToString, RDR("zon_Zonas" & tipo).ToString})
        Dim Vals     = e.Node.Name.Split("|"c)
        Dim IdZon    = Vals(0)
        Dim Mostrar  = Vals(1)
        Dim Externo  = If(String.IsNullOrWhiteSpace(Vals(2)), txtCodExtern.Text, Vals(2))
        Dim tipo     = Vals(3)

        Label3.Text = "Zon_Zonas" & tipo
        Label5.Text = "zon_mostrarZona" & tipo

        cmbCodExterno.Text = Externo
        cmbIdZon.Text      = IdZon
        chkMostrar.Enabled = Not String.IsNullOrWhiteSpace(Mostrar)
        chkMostrar.Checked = Mostrar = "1"

        'Dim ZonName = e.Node.Text.Split(","c).FirstOrDefault.Split("["c).First.Replace("'", "''").Trim()  ' RANSOL, SUPUTA, ANDORRA
        'JuniperZon = e.Node.Name
        'txtCodExtern.Text = LastExtCode
        'JnZonBusc.Text = ZonName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cExt   = cmbCodExterno.Text
        Dim idZon  = cmbIdZon.Text
        Dim Column = Label3.Text

        Using con = New SqlClient.SqlConnection(BDString)
            Try
                con.Open()
            Catch ex As Exception
                Exit Sub
            End Try

            Using SQCmd = New SqlCommand("UPDATE Tbl_Zona SET " & Column & "='" & cExt & "' WHERE id_Zon= " & idZon, con)
                'Dim TEST = ""
                SQCmd.ExecuteNonQuery()
            End Using
            JnZonBusc_TextChanged(sender, e)
            cmbCodExterno.Text = ""
            cmbIdZon.Text      = ""
            Label3.Text        = ""
        End Using
    End Sub
End Class
