Imports Microsoft.Office.Interop

Public Class Form1
    Public conexionemp As String
    Dim r As Excel.Range
    Private cCalculos As reportenominahandler
    Private arreNominas As New ArrayList
    Private arreCalculos As New ArrayList

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelPE.Visible = False

    End Sub

    Private Sub MuestraCalculos()

        Dim fechasi = DateTimePicker1.Value
        'Dim fechasf = DateTimePicker2.Value

        Dim año, mes, dia As String
        Dim inicial1 As String
        Dim final1 As String

        año = fechasi.Year.ToString
        mes = fechasi.Month.ToString
        dia = fechasi.Day.ToString

        If mes.Length = 1 Then
            mes = "0" & mes
        End If

        Dim nombrem As String
        nombrem = MonthName(mes)

        'año2 = fechasf.Year.ToString
        'mes2 = fechasf.Month.ToString
        'dia2 = fechasf.Day.ToString

        'If mes2.Length = 1 Then
        '    mes2 = "0" & mes2
        'End If

        'Dim nombrem2 As String
        'nombrem2 = MonthName(mes2)
        inicial1 = dia + "/" + nombrem + "/" + año
        'final1 = dia2 + "/" + nombrem2 + "/" + año2
        Try
            Me.DataGridView1.Rows.Clear()
            Me.arreCalculos = Me.cCalculos.ObtenCalculosNomina(fechasi, cbxempresa.Text)
            For i As Integer = 0 To Me.arreCalculos.Count - 1
                With CType(Me.arreCalculos(i), reportenomina)
                    Me.DataGridView1.Rows.Add()
                    Me.DataGridView1.Rows(i).Cells(0).Value = .centro
                    Me.DataGridView1.Rows(i).Cells(1).Value = .departartamento
                    Me.DataGridView1.Rows(i).Cells(2).Value = .puesto
                    Me.DataGridView1.Rows(i).Cells(3).Value = .empleado
                    Me.DataGridView1.Rows(i).Cells(4).Value = .rfc
                    Me.DataGridView1.Rows(i).Cells(5).Value = .nss
                    Me.DataGridView1.Rows(i).Cells(6).Value = .curp
                    Me.DataGridView1.Rows(i).Cells(7).Value = .fecha_alta
                    Me.DataGridView1.Rows(i).Cells(8).Value = .nombre
                    Me.DataGridView1.Rows(i).Cells(10).Value = .sueldodiario
                    Me.DataGridView1.Rows(i).Cells(11).Value = .sdi
                    Me.DataGridView1.Rows(i).Cells(12).Value = .dias_laborados
                    Me.DataGridView1.Rows(i).Cells(13).Value = .dias_laboradosreales
                    Me.DataGridView1.Rows(i).Cells(14).Value = .dias_faltas
                    Me.DataGridView1.Rows(i).Cells(17).Value = .descuentop_aldia
                    Me.DataGridView1.Rows(i).Cells(18).Value = .faltas
                    Me.DataGridView1.Rows(i).Cells(19).Value = .diasIncEnfGral
                    Me.DataGridView1.Rows(i).Cells(20).Value = .diasmaternidad
                    Me.DataGridView1.Rows(i).Cells(21).Value = .diasIncTrayecto
                    Me.DataGridView1.Rows(i).Cells(22).Value = .sueldo
                    Me.DataGridView1.Rows(i).Cells(23).Value = .OtrosIngresosGravados
                    Me.DataGridView1.Rows(i).Cells(24).Value = .OtrosIngresosExento
                    Me.DataGridView1.Rows(i).Cells(25).Value = .primaVacacional
                    Me.DataGridView1.Rows(i).Cells(26).Value = .diaFestivo
                    Me.DataGridView1.Rows(i).Cells(27).Value = .Descanso_laborado + .Descanso_laborado1
                    Me.DataGridView1.Rows(i).Cells(28).Value = .primaDominical
                    Me.DataGridView1.Rows(i).Cells(29).Value = .Bonos
                    Me.DataGridView1.Rows(i).Cells(30).Value = .horasExtra
                    Me.DataGridView1.Rows(i).Cells(31).Value = .sudsidioapraelempleopagado
                    Me.DataGridView1.Rows(i).Cells(32).Value = .totalpercepciones
                    Me.DataGridView1.Rows(i).Cells(33).Value = .impuestoretenido
                    Me.DataGridView1.Rows(i).Cells(34).Value = .ISR_ANUAL
                    Me.DataGridView1.Rows(i).Cells(35).Value = .imss
                    Me.DataGridView1.Rows(i).Cells(36).Value = .DescCreditoInfonavit
                    Me.DataGridView1.Rows(i).Cells(37).Value = .AjusteDifInfonavit
                    Me.DataGridView1.Rows(i).Cells(38).Value = .Descuento_fonacot
                    Me.DataGridView1.Rows(i).Cells(39).Value = .otrosdescuentos
                    Me.DataGridView1.Rows(i).Cells(40).Value = .pension_alimenticia
                    Me.DataGridView1.Rows(i).Cells(41).Value = .descuentofaltas
                    Me.DataGridView1.Rows(i).Cells(42).Value = .totaldeducciones
                    Me.DataGridView1.Rows(i).Cells(43).Value = .netopagar
                    Me.DataGridView1.Rows(i).Cells(44).Value = .isn
                    Me.DataGridView1.Rows(i).Cells(45).Value = .sua
                    Me.DataGridView1.Rows(i).Cells(46).Value = .cargasocial
                    Me.DataGridView1.Rows(i).Cells(47).Value = .cuenta
                    Me.DataGridView1.Rows(i).Cells(48).Value = .banco
                    Me.DataGridView1.Rows(i).Cells(49).Value = .clabe
                    Me.DataGridView1.Rows(i).Cells(50).Value = .sueldomensual
                    Me.DataGridView1.Rows(i).Cells(51).Value = .vacaciones
                    Me.DataGridView1.Rows(i).Cells(52).Value = .primavacacional2
                    Me.DataGridView1.Rows(i).Cells(53).Value = .aguinaldo
                    Me.DataGridView1.Rows(i).Cells(54).Value = .totalpasivolaboral



                End With
            Next
        Catch ex As Exception
            MsgBox("Error No Controlado: " & ex.Message, MsgBoxStyle.Critical, "Sistema")
        End Try
    End Sub


    ''PEUGEOT

    Private Sub MuestraCalculosP()

        Dim fechasi = DateTimePicker1.Value
        'Dim fechasf = DateTimePicker2.Value

        Dim año, mes, dia As String
        Dim inicial1 As String
        Dim final1 As String

        año = fechasi.Year.ToString
        mes = fechasi.Month.ToString
        dia = fechasi.Day.ToString

        If mes.Length = 1 Then
            mes = "0" & mes
        End If

        Dim nombrem As String
        nombrem = MonthName(mes)

        'año2 = fechasf.Year.ToString
        'mes2 = fechasf.Month.ToString
        'dia2 = fechasf.Day.ToString

        'If mes2.Length = 1 Then
        '    mes2 = "0" & mes2
        'End If

        'Dim nombrem2 As String
        'nombrem2 = MonthName(mes2)
        inicial1 = dia + "/" + nombrem + "/" + año
        'final1 = dia2 + "/" + nombrem2 + "/" + año2
        Try
            Me.DGVPE.Rows.Clear()
            Me.arreCalculos = Me.cCalculos.ObtenCalculosNominap(fechasi, cbxempresa.Text)
            For i As Integer = 0 To Me.arreCalculos.Count - 1
                With CType(Me.arreCalculos(i), reportenomina)
                    Me.DGVPE.Rows.Add()
                    Me.DGVPE.Rows(i).Cells(0).Value = .NOMBREP
                    Me.DGVPE.Rows(i).Cells(1).Value = .CUOTADIARIAP
                    Me.DGVPE.Rows(i).Cells(2).Value = .diasP
                    Me.DGVPE.Rows(i).Cells(3).Value = .sueldoP
                    Me.DGVPE.Rows(i).Cells(4).Value = .otrosingP
                    Me.DGVPE.Rows(i).Cells(5).Value = .fondodeahorroP
                    Me.DGVPE.Rows(i).Cells(6).Value = " "
                    Me.DGVPE.Rows(i).Cells(7).Value = .valesdedespensaP
                    Me.DGVPE.Rows(i).Cells(8).Value = .subsidioalempleoP
                    Me.DGVPE.Rows(i).Cells(9).Value = .totalpercepcionesP
                    Me.DGVPE.Rows(i).Cells(10).Value = .retencionimssP
                    Me.DGVPE.Rows(i).Cells(11).Value = .retencionisrP
                    Me.DGVPE.Rows(i).Cells(12).Value = .valesdedespensadP
                    Me.DGVPE.Rows(i).Cells(13).Value = .fondodeahorroemp
                    Me.DGVPE.Rows(i).Cells(14).Value = .fondodeahorropaP
                    Me.DGVPE.Rows(i).Cells(15).Value = .amortizacionP
                    Me.DGVPE.Rows(i).Cells(16).Value = .totaldP
                    Me.DGVPE.Rows(i).Cells(17).Value = .ingresonetoP
                    Me.DGVPE.Rows(i).Cells(18).Value = " "
                    Me.DGVPE.Rows(i).Cells(19).Value = .aguinaldo15P
                    Me.DGVPE.Rows(i).Cells(20).Value = .aguinaldo30P
                    Me.DGVPE.Rows(i).Cells(21).Value = .primav25P
                    Me.DGVPE.Rows(i).Cells(22).Value = .primav70P
                    Me.DGVPE.Rows(i).Cells(23).Value = .vales10P
                    Me.DGVPE.Rows(i).Cells(24).Value = .fondo13P
                    Me.DGVPE.Rows(i).Cells(25).Value = .totalpresP
                    Me.DGVPE.Rows(i).Cells(26).Value = " "
                    Me.DGVPE.Rows(i).Cells(27).Value = .totalimpuesto
                    Me.DGVPE.Rows(i).Cells(28).Value = .costosisnP
                    Me.DGVPE.Rows(i).Cells(29).Value = " "
                    Me.DGVPE.Rows(i).Cells(30).Value = .costopatronalP
                    Me.DGVPE.Rows(i).Cells(31).Value = .comisionP
                    Me.DGVPE.Rows(i).Cells(32).Value = " "
                    Me.DGVPE.Rows(i).Cells(33).Value = .subtP
                    Me.DGVPE.Rows(i).Cells(34).Value = .ivaP
                    Me.DGVPE.Rows(i).Cells(35).Value = .totalP
                    Me.DGVPE.Rows(i).Cells(36).Value = " "
                    Me.DGVPE.Rows(i).Cells(37).Value = .banco
                    Me.DGVPE.Rows(i).Cells(38).Value = .cuenta
                    Me.DGVPE.Rows(i).Cells(39).Value = .clabeP


                End With
            Next
        Catch ex As Exception
            MsgBox("Error No Controlado: " & ex.Message, MsgBoxStyle.Critical, "Sistema")
        End Try
    End Sub

    ''PEUGEOT


    Private Sub MuestraCalculosemp()


        Try
            Me.DataGridView2.Rows.Clear()
            Me.arreCalculos = Me.cCalculos.ObtenCalculosEmpleado(ComboBox1.Text, ComboBox2.Text)
            For i As Integer = 0 To Me.arreCalculos.Count - 1
                With CType(Me.arreCalculos(i), reportenomina)
                    Me.DataGridView2.Rows.Add()
                    Me.DataGridView2.Rows(i).Cells(0).Value = .frecuenciae
                    Me.DataGridView2.Rows(i).Cells(1).Value = .clavedepto
                    Me.DataGridView2.Rows(i).Cells(2).Value = .nombredeptoe
                    Me.DataGridView2.Rows(i).Cells(3).Value = .clavepuesto
                    Me.DataGridView2.Rows(i).Cells(4).Value = .nombrepuesto
                    Me.DataGridView2.Rows(i).Cells(5).Value = .noempleado
                    Me.DataGridView2.Rows(i).Cells(6).Value = .rfce
                    Me.DataGridView2.Rows(i).Cells(7).Value = .nsse
                    Me.DataGridView2.Rows(i).Cells(8).Value = .curpe
                    Me.DataGridView2.Rows(i).Cells(9).Value = .fechaalta
                    Me.DataGridView2.Rows(i).Cells(10).Value = .fechabaja
                    Me.DataGridView2.Rows(i).Cells(11).Value = .nomempleado
                    Me.DataGridView2.Rows(i).Cells(12).Value = .factorintegracion
                    Me.DataGridView2.Rows(i).Cells(13).Value = .salariodiario
                    Me.DataGridView2.Rows(i).Cells(14).Value = .salariodiarioI
                    Me.DataGridView2.Rows(i).Cells(15).Value = .cuentabancaria
                    Me.DataGridView2.Rows(i).Cells(16).Value = .bancoe


                End With
            Next
        Catch ex As Exception
            MsgBox("Error No Controlado: " & ex.Message, MsgBoxStyle.Critical, "Sistema")
        End Try
    End Sub


    Private Sub btnNomina_Click(sender As System.Object, e As System.EventArgs) Handles btnNomina.Click
        If conexionemp = "PEUGEOT" Then

            Me.MuestraCalculosp()
        Else
            Me.MuestraCalculos()
        End If




    End Sub



    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click

        If cbxempresa.Text = "PEUGEOT" Then

            '    Call GridAExcel(DataGridView1)

            Dim m_Excel As New Excel.Application
3:          m_Excel.Cursor = Excel.XlMousePointer.xlWait
4:          m_Excel.Visible = True
5:          Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
6:          Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
7:          With objHojaExcel
8:              .Visible = Excel.XlSheetVisibility.xlSheetVisible
9:              .Activate()
10:         'Encabezado  
11:             .Range("A1:L1").Merge()
12:             .Range("A1:L1").Value = "Revisión de Nomina"
13:             .Range("A1:L1").Font.Bold = True
14:             .Range("A1:L1").Font.Size = 15
15:         'Copete  
16:
20:
21:             Const primeraLetra As Char = "A"
22:             Const primerNumero As Short = 3
23:             Dim Letra As Char, UltimaLetra As Char
24:             Dim Numero As Integer, UltimoNumero As Integer
25:             Dim cod_letra As Byte = Asc(primeraLetra) - 1
26:             Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
27:             Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
28:         'Establecer formatos de las columnas de la hija de cálculo  
29:             Dim strColumna As String = ""
30:             Dim LetraIzq As String = ""
31:             Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
32:             Letra = primeraLetra
33:             Numero = primerNumero
34:             Dim objCelda As Excel.Range
35:             For Each c As DataGridViewColumn In DGVPE.Columns
36:                 If c.Visible Then
37:                     If Letra = "Z" Then
38:                         Letra = primeraLetra
39:                         cod_letra = Asc(primeraLetra)
40:                         cod_LetraIzq += 1
41:                         LetraIzq = Chr(cod_LetraIzq)
42:                     Else
43:                         cod_letra += 1
44:                         Letra = Chr(cod_letra)
45:                     End If
46:                     strColumna = LetraIzq + Letra + Numero.ToString
47:                     objCelda = .Range(strColumna, Type.Missing)
48:                     objCelda.Value = c.HeaderText
49:                     objCelda.EntireColumn.Font.Size = 8
50:                 'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
51:                     If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
52:                         objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
53:                     End If
54:                 End If
55:             Next
56:
57:             Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
58:             objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
59:             UltimaLetra = Letra
60:             Dim UltimaLetraIzq As String = LetraIzq
61:
62:         'CARGA DE DATOS  
63:             Dim i As Integer = Numero + 1
64:
65:             For Each reg As DataGridViewRow In DGVPE.Rows
66:                 LetraIzq = ""
67:                 cod_LetraIzq = Asc(primeraLetra) - 1
68:                 Letra = primeraLetra
69:                 cod_letra = Asc(primeraLetra) - 1
70:                 For Each c As DataGridViewColumn In DGVPE.Columns
71:                     If c.Visible Then
72:                         If Letra = "Z" Then
73:                             Letra = primeraLetra
74:                             cod_letra = Asc(primeraLetra)
75:                             cod_LetraIzq += 1
76:                             LetraIzq = Chr(cod_LetraIzq)
77:                         Else
78:                             cod_letra += 1
79:                             Letra = Chr(cod_letra)
80:                         End If
81:                         strColumna = LetraIzq + Letra
82:                     ' acá debería realizarse la carga  
83:                         .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
84:                     '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
85:                     '.Range(strColumna + i, strColumna + i).In()  
86:
87:                     End If
88:                 Next
89:                 Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
90:                 objRangoReg.Rows.BorderAround()
91:                 objRangoReg.Select()
92:                 i += 1
93:             Next
94:             UltimoNumero = i
95:
96:         'Dibujar las líneas de las columnas  
97:             LetraIzq = ""
98:             cod_LetraIzq = Asc("A")
99:             cod_letra = Asc(primeraLetra)
100:            Letra = primeraLetra
101:            For Each c As DataGridViewColumn In DGVPE.Columns
102:                If c.Visible Then
103:                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
104:                    objCelda.BorderAround()
105:                    If Letra = "Z" Then
106:                        Letra = primeraLetra
107:                        cod_letra = Asc(primeraLetra)
108:                        LetraIzq = Chr(cod_LetraIzq)
109:                        cod_LetraIzq += 1
110:                    Else
111:                        cod_letra += 1
112:                        Letra = Chr(cod_letra)
113:                    End If
114:                End If
115:            Next
116:
117:        'Dibujar el border exterior grueso  
118:            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
119:            objRango.Select()
120:            objRango.Columns.AutoFit()
121:            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
122:        End With
123:
124:        m_Excel.Cursor = Excel.XlMousePointer.xlDefault


        Else

            '    Call GridAExcel(DataGridView1)

            Dim m_Excel As New Excel.Application
            m_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                'Encabezado  
                .Range("A1:L1").Merge()
                .Range("A1:L1").Value = "Revisión de Nomina"
                .Range("A1:L1").Font.Bold = True
                .Range("A1:L1").Font.Size = 15
                'Copete  


                Const primeraLetra As Char = "A"
                Const primerNumero As Short = 3
                Dim Letra As Char, UltimaLetra As Char
                Dim Numero As Integer, UltimoNumero As Integer
                Dim cod_letra As Byte = Asc(primeraLetra) - 1
                Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
                'Establecer formatos de las columnas de la hija de cálculo  
                Dim strColumna As String = ""
                Dim LetraIzq As String = ""
                Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
                Letra = primeraLetra
                Numero = primerNumero
                Dim objCelda As Excel.Range
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra + Numero.ToString
                        objCelda = .Range(strColumna, Type.Missing)
                        objCelda.Value = c.HeaderText
                        objCelda.EntireColumn.Font.Size = 8
                        'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                        If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                            objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                        End If
                    End If
                Next

                Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
                objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
                UltimaLetra = Letra
                Dim UltimaLetraIzq As String = LetraIzq

                'CARGA DE DATOS  
                Dim i As Integer = Numero + 1

                For Each reg As DataGridViewRow In DataGridView1.Rows
                    LetraIzq = ""
                    cod_LetraIzq = Asc(primeraLetra) - 1
                    Letra = primeraLetra
                    cod_letra = Asc(primeraLetra) - 1
                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        If c.Visible Then
                            If Letra = "Z" Then
                                Letra = primeraLetra
                                cod_letra = Asc(primeraLetra)
                                cod_LetraIzq += 1
                                LetraIzq = Chr(cod_LetraIzq)
                            Else
                                cod_letra += 1
                                Letra = Chr(cod_letra)
                            End If
                            strColumna = LetraIzq + Letra
                            ' acá debería realizarse la carga  
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                            '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                            '.Range(strColumna + i, strColumna + i).In()  

                        End If
                    Next
                    Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                    objRangoReg.Rows.BorderAround()
                    objRangoReg.Select()
                    i += 1
                Next
                UltimoNumero = i

                'Dibujar las líneas de las columnas  
                LetraIzq = ""
                cod_LetraIzq = Asc("A")
                cod_letra = Asc(primeraLetra)
                Letra = primeraLetra
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                        objCelda.BorderAround()
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            LetraIzq = Chr(cod_LetraIzq)
                            cod_LetraIzq += 1
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                    End If
                Next

                'Dibujar el border exterior grueso  
                Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
                objRango.Select()
                objRango.Columns.AutoFit()
                objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            End With

            m_Excel.Cursor = Excel.XlMousePointer.xlDefault

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        conexionemp = cbxempresa.Text


        If conexionemp = "FOLDUR" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" &
                ";PWD=ata8244;DBNAME=192.168.2.83" &
                    ":C:\microsip datos\NEXTEL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False


        End If

        If conexionemp = "CONISAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\GRUPO CONISAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False
        End If

        If conexionemp = "IT TELECOM" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\IT RESOURCES TELECOM SA DE CV.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False
        End If


        ''MORGET POR PERIODO

        If conexionemp = "MORGET SEMANAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\1 MORGET SEMANAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False
        End If

        If conexionemp = "MORGET CATORCENAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\2 MORGET CATORCENAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False
        End If


        If conexionemp = "MORGET QUINCENAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\3 MORGET QUINCENAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False
        End If


        If conexionemp = "MORGET MENSUAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\4 MORGET MENSUAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False
        End If

        ''MORGET POR PERIODO

        If conexionemp = "WIPSI" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" &
                ";PWD=ata8244;DBNAME=192.168.2.83" &
                    ":C:\microsip datos\WIPSI A C.FDB"


            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = False
        End If

        If conexionemp = "PEUGEOT" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" &
                ";PWD=ata8244;DBNAME=192.168.2.83" &
                    ":C:\microsip datos\ITI  PEUGEOT.FDB"


            Me.cCalculos = New reportenominahandler(conexion)

            PanelPE.Visible = True
        End If
        MessageBox.Show("Sincronizacion Correcta")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        conexionemp = ComboBox1.Text


        If conexionemp = "FOLDUR" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\NEXTEL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)

        End If

        If conexionemp = "GRUPO CONISAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\GRUPO CONISAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "IT TELECOM" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\IT RESOURCES TELECOM SA DE CV.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If


        ''MORGET POR PERIODO

        If conexionemp = "MORGET SEMANAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\1 MORGET SEMANAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "MORGET CATORCENAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\2 MORGET CATORCENAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If


        If conexionemp = "MORGET QUINCENAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\3 MORGET QUINCENAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If


        If conexionemp = "MORGET MENSUAL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\4 MORGET MENSUAL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        ''MORGET POR PERIODO

        If conexionemp = "WIPSI" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\WIPSI A C.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If


        ''AGOSTO

        If conexionemp = "NUBULA" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\NUBULA SA DE CV.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "INFORMATION THECNOLOGY INDUSTRIES" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\INFORMATION THECNOLOGY.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "MORGET" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\MORGET.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "MORGET INTERNA" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\5 MORGET INTERNA.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "AICEL" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\AICEL.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "CONSORCIO ATERAP SA DE CV" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\CONSORCIO ATERAP SA DE CV.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "CROTEC SA DE CV" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\CROTEC SA DE CV.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "PEPSAT SA DE CV" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\PEPSAT SA DE CV.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If

        If conexionemp = "UPHETILOLI 2" Then

            Dim conexion As String = "DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA" & _
                ";PWD=ata8244;DBNAME=192.168.2.83" & _
                    ":C:\microsip datos\UPHETILOLI 2.FDB.FDB"

            Me.cCalculos = New reportenominahandler(conexion)
        End If


        ''AGOSTO
        MessageBox.Show("Sincronizacion Correcta")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        '    Call GridAExcel(DataGridView2)

        Dim m_Excel As New Excel.Application
3:      m_Excel.Cursor = Excel.XlMousePointer.xlWait
4:      m_Excel.Visible = True
5:      Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
6:      Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
7:      With objHojaExcel
8:          .Visible = Excel.XlSheetVisibility.xlSheetVisible
9:          .Activate()
10:         'Encabezado  
11:         .Range("A1:L1").Merge()
12:         .Range("A1:L1").Value = "Reporte de Empleados"
13:         .Range("A1:L1").Font.Bold = True
14:         .Range("A1:L1").Font.Size = 15
15:         'Copete  
16:
20:
21:         Const primeraLetra As Char = "A"
22:         Const primerNumero As Short = 3
23:         Dim Letra As Char, UltimaLetra As Char
24:         Dim Numero As Integer, UltimoNumero As Integer
25:         Dim cod_letra As Byte = Asc(primeraLetra) - 1
26:         Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
27:         Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
28:         'Establecer formatos de las columnas de la hija de cálculo  
29:         Dim strColumna As String = ""
30:         Dim LetraIzq As String = ""
31:         Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
32:         Letra = primeraLetra
33:         Numero = primerNumero
34:         Dim objCelda As Excel.Range
35:         For Each c As DataGridViewColumn In DataGridView2.Columns
36:             If c.Visible Then
37:                 If Letra = "Z" Then
38:                     Letra = primeraLetra
39:                     cod_letra = Asc(primeraLetra)
40:                     cod_LetraIzq += 1
41:                     LetraIzq = Chr(cod_LetraIzq)
42:                 Else
43:                     cod_letra += 1
44:                     Letra = Chr(cod_letra)
45:                 End If
46:                 strColumna = LetraIzq + Letra + Numero.ToString
47:                 objCelda = .Range(strColumna, Type.Missing)
48:                 objCelda.Value = c.HeaderText
49:                 objCelda.EntireColumn.Font.Size = 8
50:                 'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
51:                 If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
52:                     objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
53:                 End If
54:             End If
55:         Next
56:
57:         Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
58:         objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
59:         UltimaLetra = Letra
60:         Dim UltimaLetraIzq As String = LetraIzq
61:
62:         'CARGA DE DATOS  
63:         Dim i As Integer = Numero + 1
64:
65:         For Each reg As DataGridViewRow In DataGridView2.Rows
66:             LetraIzq = ""
67:             cod_LetraIzq = Asc(primeraLetra) - 1
68:             Letra = primeraLetra
69:             cod_letra = Asc(primeraLetra) - 1
70:             For Each c As DataGridViewColumn In DataGridView2.Columns
71:                 If c.Visible Then
72:                     If Letra = "Z" Then
73:                         Letra = primeraLetra
74:                         cod_letra = Asc(primeraLetra)
75:                         cod_LetraIzq += 1
76:                         LetraIzq = Chr(cod_LetraIzq)
77:                     Else
78:                         cod_letra += 1
79:                         Letra = Chr(cod_letra)
80:                     End If
81:                     strColumna = LetraIzq + Letra
82:                     ' acá debería realizarse la carga  
83:                     .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
84:                     '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
85:                     '.Range(strColumna + i, strColumna + i).In()  
86:
87:                 End If
88:             Next
89:             Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
90:             objRangoReg.Rows.BorderAround()
91:             objRangoReg.Select()
92:             i += 1
93:         Next
94:         UltimoNumero = i
95:
96:         'Dibujar las líneas de las columnas  
97:         LetraIzq = ""
98:         cod_LetraIzq = Asc("A")
99:         cod_letra = Asc(primeraLetra)
100:        Letra = primeraLetra
101:        For Each c As DataGridViewColumn In DataGridView2.Columns
102:            If c.Visible Then
103:                objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
104:                objCelda.BorderAround()
105:                If Letra = "Z" Then
106:                    Letra = primeraLetra
107:                    cod_letra = Asc(primeraLetra)
108:                    LetraIzq = Chr(cod_LetraIzq)
109:                    cod_LetraIzq += 1
110:                Else
111:                    cod_letra += 1
112:                    Letra = Chr(cod_letra)
113:                End If
114:            End If
115:        Next
116:
117:        'Dibujar el border exterior grueso  
118:        Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
119:        objRango.Select()
120:        objRango.Columns.AutoFit()
121:        objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
122:    End With
123:
124:    m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MuestraCalculosemp()
    End Sub
End Class
