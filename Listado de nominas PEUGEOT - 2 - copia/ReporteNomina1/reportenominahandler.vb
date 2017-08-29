Imports System.Data.Odbc
Public Class reportenominahandler
    Private m_con As String
    Private m_ConnODBC As OdbcConnection
    Public Sub New(ByVal conexion As String)
        Me.m_con = conexion
    End Sub

    Public Function ObtenCalculosNomina(ByVal fechai As Date, ByVal empresa As String) As ArrayList

        Dim año, mes, dia As String
        Dim inicial As String
        'Dim final As String

        año = fechai.Year.ToString
        mes = fechai.Month.ToString
        dia = fechai.Day.ToString

        If mes.Length = 1 Then
            mes = "0" & mes
        End If

        'año2 = fechaf.Year.ToString
        'mes2 = fechaf.Month.ToString
        'dia2 = fechaf.Day.ToString

        'If mes2.Length = 1 Then
        '    mes2 = "0" & mes2
        'End If

        inicial = "'" + mes + "-" + dia + "-" + año + "'"
        'final = "'" + mes2 + "-" + dia2 + "-" + año2 + "'"

        'Dim tr As FbTransaction
        Dim trODBC As OdbcTransaction
        Try
            Dim cadenaODBC As String

            cadenaODBC = Me.m_con

            Dim OdbcDr As OdbcDataReader
            Dim arreDatos As New ArrayList
            Dim strQuery As New System.Text.StringBuilder()
            'Me.m_conn.Open()
            Me.m_ConnODBC = New OdbcConnection(cadenaODBC)
            Me.m_ConnODBC.Open()
            trODBC = Me.m_ConnODBC.BeginTransaction(IsolationLevel.Serializable)
            Dim commODBC As New OdbcCommand("", Me.m_ConnODBC, trODBC)
            With strQuery
                .Remove(0, .Length)
                '.Append("select distinct (dn.nombre) as departamento,pn.nombre as puesto,emp.numero as empleado, ")
                '.Append("emp.rfc as RFC,emp.reg_imss as NSS,emp.curp as CURP, ")
                '.Append("emp.fecha_ingreso as FECHA_ALTA,emp.nombre_completo as NOMBRE_EMPLEADO, ")
                '.Append("emp.salario_diario as SALARIO_DIARIO_ACTUAL,emp.salario_integ as SDI, ")
                '.Append("pgn.dias_cot as DIAS_LABORADOS,pgn.dias_trab as trabajados_reales ,PGN.faltas as FALTAS,cpe.cuota as OTRO_INGRESO_EXENTO, ")
                '.Append("cpe2.cuota as PRIMA_VACACIONAL, ")
                '.Append("cpe3.cuota as DIA_FESTIVO ")
                '.Append(",cpe4.cuota as PRIMA_DOMINICAL,cpe5.cuota as BONOS,cpe6.cuota as HORAS_EXTRA, ")
                '.Append("cpe7.cuota as SUBSIDIO_PARA_EL_EMPLEO,cpe8.cuota as IMSS, ")
                '.Append("CPE9.cuota as DESCUENTO_INFONAVIT,cpe10.cuota as AJUSTE_DIFERENCIACREDINFONAVIT, ")
                '.Append("pgn.faltas_dec as DESCUENTO_FALTAS,pgn.dias_incap as DIAS_INCAPACIDADGENERAL, ")
                '.Append("cpe11.cuota as OTROS_DESCUENTOS,pgn.base_impto_estatal as ISN,pgn.total_reten as impuestoretenido, ")
                '.Append("inc1.dias as RIESGOTRABAJO,inc2.dias as MATERNIDAD ")
                '.Append("from empleados emp ")
                '.Append("inner join deptos_no dn ")
                '.Append("on emp.depto_no_id = dn.depto_no_id ")
                '.Append("inner join puestos_no pn ")
                '.Append("on emp.puesto_no_id = pn.puesto_no_id ")
                '.Append("inner join pagos_nomina pgn ")
                '.Append("on emp.empleado_id =pgn.empleado_id ")
                '.Append("inner join pagos_nomina_det pnd ")
                '.Append("on pgn.pago_nomina_id = pnd.pago_nomina_id ")
                '.Append("left join conceptos_no cpn ")
                '.Append("on pnd.concepto_no_id = cpn.concepto_no_id ")
                '.Append("left join conceptos_emp cpe ")
                '.Append("on cpn.concepto_no_id = cpe.concepto_no_id AND cpn.concepto_no_id  = 8986 ")
                '.Append("left join conceptos_emp cpe2 ")
                '.Append("on cpn.concepto_no_id = cpe2.concepto_no_id AND cpn.concepto_no_id  = 2173 ")
                '.Append("left join conceptos_emp cpe3 ")
                '.Append("on cpn.concepto_no_id = cpe3.concepto_no_id AND cpn.concepto_no_id  =  2176 ")
                '.Append("left join conceptos_emp cpe4 ")
                '.Append("on cpn.concepto_no_id = cpe4.concepto_no_id AND cpn.concepto_no_id  =  10319 ")
                '.Append("left join conceptos_emp cpe5 ")
                '.Append("on cpn.concepto_no_id = cpe5.concepto_no_id AND cpn.concepto_no_id  =  2175 ")
                '.Append("left join conceptos_emp cpe6 ")
                '.Append("on cpn.concepto_no_id = cpe6.concepto_no_id AND cpn.concepto_no_id  =  107 ")
                '.Append("left join conceptos_emp cpe7 ")
                '.Append("on cpn.concepto_no_id = cpe7.concepto_no_id AND cpn.concepto_no_id  =  156 ")
                '.Append("left join conceptos_emp cpe8 ")
                '.Append("on cpn.concepto_no_id = cpe8.concepto_no_id AND cpn.concepto_no_id  =  116 ")
                '.Append("left join conceptos_emp cpe9 ")
                '.Append("on cpn.concepto_no_id = cpe9.concepto_no_id AND cpn.concepto_no_id  =   10316 ")
                '.Append("left join conceptos_emp cpe10 ")
                '.Append("on cpn.concepto_no_id = cpe10.concepto_no_id AND cpn.concepto_no_id  =   10317 ")
                '.Append("left join conceptos_emp cpe11 ")
                '.Append("on cpn.concepto_no_id = cpe11.concepto_no_id AND cpn.concepto_no_id  =   8987 ")
                '.Append("left join incapacidades inc1 ")
                '.Append("on emp.empleado_id  = inc1.empleado_id and inc1.ramo = 'R' ")
                '.Append("left join incapacidades inc2 ")
                '.Append("on emp.empleado_id = inc2.empleado_id and inc2.ramo = 'M' ")
                '.Append("where  pgn.fecha = " & inicial)
                .Append(" with Conceptos as(select d.cuota,p.pago_nomina_id,e.empleado_id,d.concepto_no_id,d.importe,p.total_percep_exen,p.total_percep_no_acum from pagos_nomina p ")
                .Append("inner join pagos_nomina_det d ")
                .Append("on p.pago_nomina_id = d.pago_nomina_id ")
                .Append("inner join empleados e ")
                .Append("on p.empleado_id = e.empleado_id) ")
                .Append("select distinct  (dn.nombre) as departamento,pn.nombre as puesto,emp.numero as empleado,emp.grupo_pago_elect_id as banco ,emp.num_ctaban_pago_elect as cuenta, ")
                .Append("emp.rfc as RFC,emp.reg_imss as NSS,emp.curp as CURP, ")
                .Append("emp.fecha_ingreso as FECHA_ALTA,emp.nombre_completo as NOMBRE_EMPLEADO, ")
                .Append("emp.salario_diario as SALARIO_DIARIO_ACTUAL,emp.salario_integ as SDI, ")
                .Append("pgn.dias_cot as DIAS_LABORADOS,pgn.dias_trab as trabajados_reales ,PGN.faltas as FALTAS,pgn.dias_incap as DIAS_INCAPACIDADGENERAL,inc1.dias as RIESGOTRABAJO,inc2.dias as MATERNIDAD,pgn.total_reten as impuestoretenido, ")
                .Append("c1.cuota as PRIMA_VACACIONAL, ")
                .Append("c2.cuota as  OTRO_INGRESO_EXENTO, ")
                .Append("c3.importe as dia_festivo, ")
                .Append("c4.importe as prima_dominical, ")
                .Append(" c5.importe as bonos, ")
                .Append("c6.cuota as horas_extra, ")
                .Append("c7.importe as SUBSIDIO_PARA_EL_EMPLEO, ")
                .Append("c8.importe as IMSS, ")
                .Append("c9.cuota as descuento_infonavit, ")
                .Append("c10.cuota as AJUSTE_DIFERENCIACREDINFONAVIT, ")
                .Append("c11.cuota as otros_descuentos,pgn.faltas_dec as DESCUENTO_FALTAS,pgn.base_impto_estatal as ISN, ")
                .Append("c12.importe as ISR, ")
                .Append("c13.importe as Pension_Alimenticia, ")
                .Append("c14.importe as Descanso_laborado, ")
                .Append("c15.importe as Descanso_laborado1, ")
                .Append("c16.importe as ISR_ANUAL, ")
                .Append("c17.importe as Descuento_fonacot, ")
                .Append("fpago.nombre AS NOMBRE ")
                .Append("from empleados emp ")
                .Append("inner join deptos_no dn ")
                .Append("on emp.depto_no_id = dn.depto_no_id ")
                .Append("inner join puestos_no pn ")
                .Append("on emp.puesto_no_id = pn.puesto_no_id ")
                .Append("inner join pagos_nomina pgn ")
                .Append("on emp.empleado_id =pgn.empleado_id ")
                .Append("inner join pagos_nomina_det pnd ")
                .Append("on pgn.pago_nomina_id = pnd.pago_nomina_id ")
                .Append("left join Conceptos c1")
                .Append(" on pgn.pago_nomina_id = c1.pago_nomina_id and emp.empleado_id = c1.empleado_id ")
                .Append("and c1.concepto_no_id = 9761 ")
                .Append("left join Conceptos c2 ")
                .Append("on pgn.pago_nomina_id = c2.pago_nomina_id and emp.empleado_id = c2.empleado_id ")
                .Append("and c2.concepto_no_id = 8986 ")
                .Append("left join Conceptos c3 ")
                .Append(" on pgn.pago_nomina_id = c3.pago_nomina_id and emp.empleado_id = c3.empleado_id ")
                .Append("and c3.concepto_no_id = 2176  ")
                .Append("left join Conceptos c4 ")
                .Append("on pgn.pago_nomina_id = c4.pago_nomina_id and emp.empleado_id = c4.empleado_id ")
                .Append("and c4.concepto_no_id = 2106 ")
                .Append("left join Conceptos c5 ")
                .Append("on pgn.pago_nomina_id = c5.pago_nomina_id and emp.empleado_id = c5.empleado_id ")
                .Append("and c5.concepto_no_id = 2175 ")
                .Append("left join Conceptos c6 ")
                .Append("on pgn.pago_nomina_id = c6.pago_nomina_id and emp.empleado_id = c6.empleado_id ")
                .Append("and c6.concepto_no_id = 107 ")
                .Append("left join Conceptos c7 ")
                .Append("on pgn.pago_nomina_id = c7.pago_nomina_id and emp.empleado_id = c7.empleado_id ")
                .Append("and c7.concepto_no_id = 156 ")
                .Append("left join Conceptos c8 ")
                .Append("on pgn.pago_nomina_id = c8.pago_nomina_id and emp.empleado_id = c8.empleado_id ")
                .Append("and c8.concepto_no_id = 116 ")
                .Append("left join Conceptos c9 ")
                .Append("on pgn.pago_nomina_id = c9.pago_nomina_id and emp.empleado_id = c9.empleado_id ")
                .Append("and c9.concepto_no_id = 10316 ")
                .Append("left join Conceptos c10 ")
                .Append("on pgn.pago_nomina_id = c10.pago_nomina_id and emp.empleado_id = c10.empleado_id ")
                .Append("and c10.concepto_no_id = 10317 ")
                .Append("left join Conceptos c11 ")
                .Append("on pgn.pago_nomina_id = c11.pago_nomina_id and emp.empleado_id = c11.empleado_id ")
                .Append("and c11.concepto_no_id = 8987 ")
                .Append("left join Conceptos c12 ")
                .Append("on pgn.pago_nomina_id = c12.pago_nomina_id and emp.empleado_id = c12.empleado_id ")
                .Append("and c12.concepto_no_id = 115 ")
                .Append("left join Conceptos c13 ")
                .Append("on pgn.pago_nomina_id = c13.pago_nomina_id and emp.empleado_id = c13.empleado_id ")
                .Append("and c13.concepto_no_id = 163 ")
                .Append("left join Conceptos c14 ")
                .Append("on pgn.pago_nomina_id = c14.pago_nomina_id and emp.empleado_id = c14.empleado_id ")
                .Append("and c14.concepto_no_id = 11239 ")
                .Append("left join Conceptos c15 ")
                .Append("on pgn.pago_nomina_id = c15.pago_nomina_id and emp.empleado_id = c15.empleado_id ")
                .Append("and c15.concepto_no_id = 11240 ")
                .Append("left join Conceptos c16 ")
                .Append("on pgn.pago_nomina_id = c16.pago_nomina_id and emp.empleado_id = c16.empleado_id ")
                .Append("and c16.concepto_no_id = 12860 ")
                .Append("left join Conceptos c17 ")
                .Append("on pgn.pago_nomina_id = c17.pago_nomina_id and emp.empleado_id = c17.empleado_id ")
                .Append("and c17.concepto_no_id = 11160 ")
                .Append("left join incapacidades inc1 ")
                .Append("on emp.empleado_id  = inc1.empleado_id and inc1.ramo = 'R' ")
                .Append("left join incapacidades inc2 ")
                .Append("on emp.empleado_id = inc2.empleado_id and inc2.ramo = 'M' ")
                .Append("inner join nominas nom ")
                .Append("on nom.nomina_id = pgn.nomina_id ")
                .Append("left join FRECUENCIAS_PAGO fpago ")
                .Append("on fpago.frepag_id = nom.frepag_id ")
                .Append("where  pgn.fecha = " & inicial)





            End With
            'comm.CommandText = strQuery.ToString
            commODBC.CommandText = strQuery.ToString
            'dr = com.ExecuteReader()
            OdbcDr = commODBC.ExecuteReader()
            While OdbcDr.Read()
                Dim c As New reportenomina
                Dim s As New SUA

                ''julio

                If empresa = "FOLDUR" Then
                    If OdbcDr("banco") Is DBNull.Value Then
                        c.banco = "N/A"
                    Else
                        If OdbcDr("banco") = 7516 Then
                            c.banco = "BANCOMER"
                        End If

                        If OdbcDr("banco") = 13479 Then
                            c.banco = "SANTANDER"
                        End If

                    End If


                    If OdbcDr("cuenta") Is DBNull.Value Then
                        c.cuenta = 0
                    Else
                        c.cuenta = OdbcDr("cuenta")
                    End If
                End If



                ''julio

                If OdbcDr("NOMBRE") Is DBNull.Value Then
                    c.centro = "N/A"
                Else
                    c.centro = OdbcDr("NOMBRE")
                End If



                If OdbcDr("departamento") Is DBNull.Value Then
                    c.departartamento = "N/A"
                Else
                    c.departartamento = OdbcDr("departamento")
                End If
                If OdbcDr("puesto") Is DBNull.Value Then
                    c.puesto = "N/A"
                Else
                    c.puesto = OdbcDr("puesto")
                End If
                If OdbcDr("empleado") Is DBNull.Value Then
                    c.empleado = "N/A"
                Else
                    c.empleado = OdbcDr("empleado")
                End If
                If OdbcDr("RFC") Is DBNull.Value Then
                    c.rfc = "N/A"
                Else
                    c.rfc = OdbcDr("RFC")
                End If
                If OdbcDr("NSS") Is DBNull.Value Then
                    c.nss = "N/A"
                Else
                    c.nss = OdbcDr("NSS")
                End If
                If OdbcDr("CURP") Is DBNull.Value Then
                    c.curp = "N/A"
                Else
                    c.curp = OdbcDr("CURP")
                End If
                If OdbcDr("FECHA_ALTA") Is DBNull.Value Then
                    c.fecha_alta = "S/A"
                Else
                    c.fecha_alta = OdbcDr("FECHA_ALTA")
                End If
                If OdbcDr("NOMBRE_EMPLEADO") Is DBNull.Value Then
                    c.nombre = "N/A"
                Else
                    c.nombre = OdbcDr("NOMBRE_EMPLEADO")
                End If
                If OdbcDr("SALARIO_DIARIO_ACTUAL") Is DBNull.Value Then
                    c.sueldodiario = 0
                Else
                    c.sueldodiario = OdbcDr("SALARIO_DIARIO_ACTUAL")
                End If
                If OdbcDr("SDI") Is DBNull.Value Then
                    c.sdi = "N/A"
                Else
                    c.sdi = OdbcDr("SDI")
                End If
                If OdbcDr("DIAS_LABORADOS") Is DBNull.Value Then
                    c.dias_laborados = 0
                Else
                    c.dias_laborados = OdbcDr("DIAS_LABORADOS")
                End If


                If OdbcDr("FALTAS") Is DBNull.Value Then
                    c.dias_faltas = 0
                Else
                    Dim substringfaltas As String = OdbcDr("FALTAS").Substring(0, 2)
                    c.dias_faltas = substringfaltas
                End If


                If OdbcDr("trabajados_reales") Is DBNull.Value Then
                    c.dias_laboradosreales = 0
                Else
                    c.dias_laboradosreales = OdbcDr("trabajados_reales")
                End If



                c.descuentop_aldia = (2 - (((12 - c.sueldodiario) * 2) / 12)) * c.dias_faltas


                c.faltas = c.sueldodiario * c.dias_faltas
                If OdbcDr("DIAS_INCAPACIDADGENERAL") Is DBNull.Value Then
                    c.diasIncEnfGral = 0
                Else
                    c.diasIncEnfGral = OdbcDr("DIAS_INCAPACIDADGENERAL")
                End If

                If OdbcDr("MATERNIDAD") Is DBNull.Value Then
                    c.diasmaternidad = 0
                Else
                    c.diasmaternidad = OdbcDr("MATERNIDAD")
                End If
                If OdbcDr("RIESGOTRABAJO") Is DBNull.Value Then
                    c.diasIncTrayecto = 0
                Else
                    c.diasIncTrayecto = OdbcDr("RIESGOTRABAJO")
                End If
                c.sueldo = c.dias_laborados * c.sueldodiario
                c.OtrosIngresosGravados = 0
                If OdbcDr("OTRO_INGRESO_EXENTO") Is DBNull.Value Then
                    c.OtrosIngresosExento = 0
                Else
                    c.OtrosIngresosExento = OdbcDr("OTRO_INGRESO_EXENTO")
                End If

                If OdbcDr("PRIMA_VACACIONAL") Is DBNull.Value Then
                    c.primaVacacional = 0
                Else
                    c.primaVacacional = OdbcDr("PRIMA_VACACIONAL")
                End If


                If OdbcDr("DIA_FESTIVO") Is DBNull.Value Then
                    c.diaFestivo = 0
                Else
                    c.diaFestivo = OdbcDr("DIA_FESTIVO")
                End If

                If OdbcDr("PRIMA_DOMINICAL") Is DBNull.Value Then
                    c.primaDominical = 0
                Else
                    c.primaDominical = OdbcDr("PRIMA_DOMINICAL")
                End If


                If OdbcDr("BONOS") Is DBNull.Value Then
                    c.Bonos = 0
                Else
                    c.Bonos = OdbcDr("BONOS")
                End If

                If OdbcDr("HORAS_EXTRA") Is DBNull.Value Then
                    c.horasExtra = 0
                Else
                    c.horasExtra = OdbcDr("HORAS_EXTRA")
                End If

                If OdbcDr("SUBSIDIO_PARA_EL_EMPLEO") Is DBNull.Value Then
                    c.sudsidioapraelempleopagado = 0
                Else
                    c.sudsidioapraelempleopagado = OdbcDr("SUBSIDIO_PARA_EL_EMPLEO")
                End If


                c.totalpercepciones = c.sueldo + c.OtrosIngresosGravados + c.OtrosIngresosExento + c.primaVacacional + c.diaFestivo + c.primaDominical + c.Bonos + c.horasExtra + c.sudsidioapraelempleopagado

                If OdbcDr("ISR") Is DBNull.Value Then

                    c.impuestoretenido = 0
                Else

                    c.impuestoretenido = OdbcDr("ISR")
                End If

                If OdbcDr("ISR_ANUAL") Is DBNull.Value Then

                    c.ISR_ANUAL = 0
                Else

                    c.ISR_ANUAL = OdbcDr("ISR_ANUAL")
                End If


                If OdbcDr("Descuento_fonacot") Is DBNull.Value Then

                    c.Descuento_fonacot = 0
                Else

                    c.Descuento_fonacot = OdbcDr("Descuento_fonacot")
                End If

                If OdbcDr("Pension_Alimenticia") Is DBNull.Value Then

                    c.pension_alimenticia = 0
                Else

                    c.pension_alimenticia = OdbcDr("Pension_Alimenticia")
                End If

                ''desanso

                If OdbcDr("Descanso_laborado") Is DBNull.Value Then

                    c.Descanso_laborado = 0
                Else

                    c.Descanso_laborado = OdbcDr("Descanso_laborado")
                End If

                If OdbcDr("Descanso_laborado1") Is DBNull.Value Then

                    c.Descanso_laborado1 = 0
                Else

                    c.Descanso_laborado1 = OdbcDr("Descanso_laborado1")
                End If



                If OdbcDr("IMSS") Is DBNull.Value Then
                    c.imss = 0
                Else
                    c.imss = OdbcDr("IMSS")
                End If

                If OdbcDr("DESCUENTO_INFONAVIT") Is DBNull.Value Then
                    c.DescCreditoInfonavit = 0
                Else
                    c.DescCreditoInfonavit = OdbcDr("DESCUENTO_INFONAVIT")
                End If
                If OdbcDr("AJUSTE_DIFERENCIACREDINFONAVIT") Is DBNull.Value Then
                    c.AjusteDifInfonavit = 0
                Else
                    c.AjusteDifInfonavit = OdbcDr("AJUSTE_DIFERENCIACREDINFONAVIT")
                End If
                If OdbcDr("OTROS_DESCUENTOS") Is DBNull.Value Then
                    c.otrosdescuentos = 0
                Else
                    c.otrosdescuentos = OdbcDr("OTROS_DESCUENTOS")
                End If


                If OdbcDr("DESCUENTO_FALTAS") Is DBNull.Value Then
                    c.descuentofaltas = 0
                Else
                    c.descuentofaltas = c.descuentop_aldia + c.faltas

                End If

                c.totaldeducciones = c.Descuento_fonacot + c.pension_alimenticia + c.impuestoretenido + c.imss + c.DescCreditoInfonavit + c.AjusteDifInfonavit + c.otrosdescuentos + c.descuentofaltas
                c.netopagar = c.totalpercepciones - c.totaldeducciones
                If OdbcDr("ISN") Is DBNull.Value Then
                    'c.isn = 0 * 0.03
                    c.isn = (c.sueldo + c.OtrosIngresosExento + c.primaVacacional + c.diaFestivo + c.Descanso_laborado + c.primaDominical + c.Bonos + c.horasExtra) * 0.03
                Else
                    c.isn = (c.sueldo + c.OtrosIngresosExento + c.primaVacacional + c.diaFestivo + c.Descanso_laborado + c.primaDominical + c.Bonos + c.horasExtra) * 0.03
                End If
                c.sua = 0
                c.cargasocial = c.isn + c.sua
                c.sueldomensual = c.sueldodiario * 30.42
                ''calculo de vacaciones
                Dim fecha_1 As Date
                fecha_1 = c.fecha_alta

                Dim fecha_2 As Date = Date.Now

                Dim fecha_3 As Long = DateDiff(DateInterval.Day, fecha_1, fecha_2)

                ''cero años

                If fecha_3 < 365 Then
                    c.vacaciones = (c.sueldomensual / 30.4 * 6) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + +c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad)
                End If

                ''un año
                If fecha_3 > 365 And fecha_3 <= 730 Then
                    c.vacaciones = (c.sueldomensual / 30.4 * 6) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + +c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad)
                End If

                ''dos años
                If fecha_3 > 731 And fecha_3 <= 1095 Then
                    c.vacaciones = (c.sueldomensual / 30.4 * 8) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + +c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad)
                End If

                ''tres años

                If fecha_3 > 1096 And fecha_3 < 1460 Then
                    c.vacaciones = (c.sueldomensual / 30.4 * 10) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + +c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad)
                End If

                ''cuatro años
                If fecha_3 > 1461 And fecha_3 < 1825 Then
                    c.vacaciones = (c.sueldomensual / 30.4 * 12) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + +c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad)
                End If


                c.vacaciones = (c.sueldomensual / 30.4 * 8) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + +c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad)
                c.primavacacional2 = (c.sueldomensual / 30.4 * 8) / 12 * (0.25) / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasmaternidad + c.diasIncTrayecto)
                c.aguinaldo = (c.sueldomensual / 30.4 * 15) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasmaternidad + c.diasIncTrayecto)
                c.totalpasivolaboral = c.vacaciones + c.primavacacional2 + c.aguinaldo

                ''sua
                Dim factorIntegracion As Double
                Dim salariominimodf As Double
                Dim sueldomensual2 As Double
                Dim izquierda As String = "Costo de Administración"
                Dim tiponomina As Int16
                Dim baseimpuestonomina As Int16

                If c.empleado = 100206 Or c.empleado = 100207 Or
                    c.empleado = 100969 Or c.empleado = 100970 Or c.empleado = 101160 Or c.empleado = 101189 Or c.empleado = 101470 Or c.empleado = 101475 Or c.empleado = 101479 Or c.empleado = 101484 Or c.empleado = 101848 Or c.empleado = 101849 Or c.empleado = 101850 Or c.empleado = 101862 Or c.empleado = 101863 Or c.empleado = 101947 Or c.empleado = 101948 Or c.empleado = 101950 Or c.empleado = 101953 Or c.empleado = 102056 Or c.empleado = 102058 Or c.empleado = 102059 Or c.empleado = 102062 Or c.empleado = 102064 Or c.empleado = 102065 Or c.empleado = 102067 Or c.empleado = 102068 Or c.empleado = 102171 Or c.empleado = 102172 Or c.empleado = 102173 Or c.empleado = 102174 Or c.empleado = 102175 Or c.empleado = 102176 Or c.empleado = 102177 Or c.empleado = 102178 Or c.empleado = 102179 Or c.empleado = 102292 Or c.empleado = 102293 Or c.empleado = 102294 Or c.empleado = 102295 Or c.empleado = 102296 Or c.empleado = 102297 Or c.empleado = 102299 Or c.empleado = 102300 Or c.empleado = 102302 Or c.empleado = 102303 Or c.empleado = 102304 Or c.empleado = 102305 Or c.empleado = 102306 Or c.empleado = 102307 Or c.empleado = 102309 Or c.empleado = 102456 Then

                    factorIntegracion = c.sdi / c.sueldodiario
                    salariominimodf = 75.49
                    sueldomensual2 = c.dias_laborados * c.sueldodiario
                    s.SMG = c.sueldodiario / salariominimodf
                    s.ingresosexentosIMSSxsalarios = 0
                    If ((sueldomensual2 - s.ingresosexentosIMSSxsalarios) / c.dias_laborados) * factorIntegracion > salariominimodf * 25 Then
                        s.salariobasedecotizacion = salariominimodf * 25 * c.dias_laborados
                    Else
                        s.salariobasedecotizacion = ((sueldomensual2 - s.ingresosexentosIMSSxsalarios) * factorIntegracion)
                    End If

                    If s.salariobasedecotizacion > 0 Then
                        s.salariominimoDF = (salariominimodf * c.dias_laborados)
                    Else
                        s.salariominimoDF = 0
                    End If

                    If s.salariobasedecotizacion - (s.salariominimoDF * 3) > 0 Then
                        s.excedente35mgdf = s.salariobasedecotizacion - (s.salariominimoDF * 3)
                    Else
                        s.excedente35mgdf = 0
                    End If

                    s.riesgodetrabajop = (s.salariobasedecotizacion * 0.5) / 100
                    izquierda = "Costo de Administración"
                    If izquierda = "PRECAUCIÓN" Then
                        s.coutafijap = s.salariominimoDF * 20.4 * 2.7
                    Else
                        s.coutafijap = s.salariominimoDF * 20.4 / 100
                    End If

                    s.exedentep = s.excedente35mgdf * 1.1 / 100

                    s.prestacionesendinerop = s.salariobasedecotizacion * 0.7 / 100

                    s.gastosmedicospensionadosp = s.salariobasedecotizacion * 1.05 / 100

                    s.invalidezyvidap = s.salariobasedecotizacion * 1.75 / 100

                    s.guaderiasp = s.salariobasedecotizacion * 1 / 100

                    s.retirop = (s.salariobasedecotizacion * 2 / 100)

                    s.cesantiayvejezp = s.salariobasedecotizacion * 3.15 / 100

                    s.totalpatron = s.riesgodetrabajop + s.coutafijap + s.exedentep + s.prestacionesendinerop + s.gastosmedicospensionadosp + s.invalidezyvidap + s.guaderiasp + s.retirop + s.cesantiayvejezp

                    ''trabajador

                    s.exedentet = s.excedente35mgdf * 0.4 / 100

                    s.prestacionesendinerot = s.salariobasedecotizacion * 0.25 / 100

                    s.gastosmedicospensionadost = s.salariobasedecotizacion * 0.375 / 100

                    s.invalidezyvidat = s.salariobasedecotizacion * 0.625 / 100

                    If izquierda = "PRECAUCIÓN" Then
                        s.cesantiayvejezt = (s.salariobasedecotizacion * 1.125 / 100) * 2.7
                    Else
                        s.cesantiayvejezt = s.salariobasedecotizacion * 1.125 / 100
                    End If

                    s.totaltrabador = s.exedentet + s.prestacionesendinerot + s.gastosmedicospensionadost + s.invalidezyvidat + s.cesantiayvejezt

                    s.riesgodetrabajopyt = s.riesgodetrabajop

                    s.coutafijapyt = s.coutafijap

                    s.exedentepyt = s.exedentep + s.exedentet

                    s.prestacionesendineropyt = s.prestacionesendinerop + s.prestacionesendinerot

                    s.gastosmedicospensionadospyt = s.gastosmedicospensionadosp + s.gastosmedicospensionadost

                    s.invalidezyvidapyt = s.invalidezyvidap + s.invalidezyvidat

                    s.guaderiaspyt = s.guaderiasp

                    s.retiropyt = s.retirop

                    s.cesantiayvejezpyt = s.cesantiayvejezp + s.cesantiayvejezt

                    s.totalpatronyt = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt + s.retiropyt + s.cesantiayvejezpyt

                    s.mensual = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt

                    s.bimestral = s.retiropyt + s.cesantiayvejezpyt

                    tiponomina = 1

                    If tiponomina = 1 Then
                        s.total = s.mensual + s.bimestral
                    Else

                    End If


                    If tiponomina = 1 Then
                        s.infonavit = s.salariobasedecotizacion * 5 / 100
                    Else
                        s.infonavit = 0
                    End If

                    baseimpuestonomina = 1
                    s.ingresosexentosimpuestossobrenominas = 0
                    s.asimiladosmensuales = 0

                    If baseimpuestonomina = 1 Then
                        s.impuestosobrenominac = ((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) * 3 / 100
                    Else
                        s.impuestosobrenominac = (((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) + s.asimiladosmensuales) * 3 / 100
                    End If

                    s.totalcostosocial = s.total + s.infonavit + s.impuestosobrenominac

                    s.SUA = s.totalcostosocial - s.impuestosobrenominac

                    c.sua = s.SUA

                Else



                    factorIntegracion = c.sdi / c.sueldo
                    salariominimodf = 75.49
                    sueldomensual2 = c.dias_laborados * c.sueldodiario
                    s.SMG = c.sueldodiario / salariominimodf
                    s.ingresosexentosIMSSxsalarios = 0
                    If ((sueldomensual2 - s.ingresosexentosIMSSxsalarios) / c.dias_laborados) * factorIntegracion > salariominimodf * 25 Then
                        s.salariobasedecotizacion = salariominimodf * 25 * c.dias_laborados
                    Else
                        s.salariobasedecotizacion = ((sueldomensual2 - s.ingresosexentosIMSSxsalarios) * factorIntegracion)
                    End If

                    If s.salariobasedecotizacion > 0 Then
                        s.salariominimoDF = (salariominimodf * c.dias_laborados)
                    Else
                        s.salariominimoDF = 0
                    End If

                    If s.salariobasedecotizacion - (s.salariominimoDF * 3) > 0 Then
                        s.excedente35mgdf = s.salariobasedecotizacion - (s.salariominimoDF * 3)
                    Else
                        s.excedente35mgdf = 0
                    End If

                    s.riesgodetrabajop = (s.salariobasedecotizacion * 0.52891) / 100
                    izquierda = "Costo de Administración"
                    If izquierda = "PRECAUCIÓN" Then
                        s.coutafijap = s.salariominimoDF * 20.4 * 2.7
                    Else
                        s.coutafijap = s.salariominimoDF * 20.4 / 100
                    End If

                    s.exedentep = s.excedente35mgdf * 1.1 / 100

                    s.prestacionesendinerop = s.salariobasedecotizacion * 0.7 / 100

                    s.gastosmedicospensionadosp = s.salariobasedecotizacion * 1.05 / 100

                    s.invalidezyvidap = s.salariobasedecotizacion * 1.75 / 100

                    s.guaderiasp = s.salariobasedecotizacion * 1 / 100

                    s.retirop = (s.salariobasedecotizacion * 2 / 100)

                    s.cesantiayvejezp = s.salariobasedecotizacion * 3.15 / 100

                    s.totalpatron = s.riesgodetrabajop + s.coutafijap + s.exedentep + s.prestacionesendinerop + s.gastosmedicospensionadosp + s.invalidezyvidap + s.guaderiasp + s.retirop + s.cesantiayvejezp

                    ''trabajador

                    s.exedentet = s.excedente35mgdf * 0.4 / 100

                    s.prestacionesendinerot = s.salariobasedecotizacion * 0.25 / 100

                    s.gastosmedicospensionadost = s.salariobasedecotizacion * 0.375 / 100

                    s.invalidezyvidat = s.salariobasedecotizacion * 0.625 / 100

                    If izquierda = "PRECAUCIÓN" Then
                        s.cesantiayvejezt = (s.salariobasedecotizacion * 1.125 / 100) * 2.7
                    Else
                        s.cesantiayvejezt = s.salariobasedecotizacion * 1.125 / 100
                    End If

                    s.totaltrabador = s.exedentet + s.prestacionesendinerot + s.gastosmedicospensionadost + s.invalidezyvidat + s.cesantiayvejezt

                    s.riesgodetrabajopyt = s.riesgodetrabajop

                    s.coutafijapyt = s.coutafijap

                    s.exedentepyt = s.exedentep + s.exedentet

                    s.prestacionesendineropyt = s.prestacionesendinerop + s.prestacionesendinerot

                    s.gastosmedicospensionadospyt = s.gastosmedicospensionadosp + s.gastosmedicospensionadost

                    s.invalidezyvidapyt = s.invalidezyvidap + s.invalidezyvidat

                    s.guaderiaspyt = s.guaderiasp

                    s.retiropyt = s.retirop

                    s.cesantiayvejezpyt = s.cesantiayvejezp + s.cesantiayvejezt

                    s.totalpatronyt = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt + s.retiropyt + s.cesantiayvejezpyt

                    s.mensual = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt

                    s.bimestral = s.retiropyt + s.cesantiayvejezpyt

                    tiponomina = 1

                    If tiponomina = 1 Then
                        s.total = s.mensual + s.bimestral
                    Else

                    End If


                    If tiponomina = 1 Then
                        s.infonavit = s.salariobasedecotizacion * 5 / 100
                    Else
                        s.infonavit = 0
                    End If

                    baseimpuestonomina = 1
                    s.ingresosexentosimpuestossobrenominas = 0
                    s.asimiladosmensuales = 0

                    If baseimpuestonomina = 1 Then
                        s.impuestosobrenominac = ((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) * 3 / 100
                    Else
                        s.impuestosobrenominac = (((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) + s.asimiladosmensuales) * 3 / 100
                    End If

                    s.totalcostosocial = s.total + s.infonavit + s.impuestosobrenominac

                    s.SUA = s.totalcostosocial - s.impuestosobrenominac

                    c.sua = s.SUA

                End If

                ''fin sua

                arreDatos.Add(c)
            End While
            'Me.m_conn.Close()
            Me.m_ConnODBC.Close()
            Return arreDatos
        Catch ex As Exception
            Try
                trODBC.Rollback()
            Catch ex1 As Exception
                MsgBox(ex.Message)
            End Try
        Finally
            Try
                Me.m_ConnODBC.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Try
    End Function

    ''peugeot

    Public Function ObtenCalculosNominap(ByVal fechai As Date, ByVal empresa As String) As ArrayList

        Dim año, mes, dia As String
        Dim inicial As String
        'Dim final As String

        año = fechai.Year.ToString
        mes = fechai.Month.ToString
        dia = fechai.Day.ToString

        If mes.Length = 1 Then
            mes = "0" & mes
        End If


        inicial = "'" + mes + "-" + dia + "-" + año + "'"

        Dim trODBC As OdbcTransaction
        Try
            Dim cadenaODBC As String

            cadenaODBC = Me.m_con

            Dim OdbcDr As OdbcDataReader
            Dim arreDatos As New ArrayList
            Dim strQuery As New System.Text.StringBuilder()
            'Me.m_conn.Open()
            Me.m_ConnODBC = New OdbcConnection(cadenaODBC)
            Me.m_ConnODBC.Open()
            trODBC = Me.m_ConnODBC.BeginTransaction(IsolationLevel.Serializable)
            Dim commODBC As New OdbcCommand("", Me.m_ConnODBC, trODBC)
            With strQuery
                .Remove(0, .Length)


                .Append(" with Conceptos as(select d.cuota,p.pago_nomina_id,e.empleado_id,d.concepto_no_id,d.importe,p.total_percep_exen,p.total_percep_no_acum from pagos_nomina p ")
                .Append("inner join pagos_nomina_det d ")
                .Append("on p.pago_nomina_id = d.pago_nomina_id ")
                .Append("inner join empleados e ")
                .Append("on p.empleado_id = e.empleado_id) ")
                .Append("select distinct  (dn.nombre) as departamento,pn.nombre as puesto,emp.numero as empleado,emp.grupo_pago_elect_id as banco ,emp.num_ctaban_pago_elect as cuenta, ")
                .Append("emp.rfc as RFC,emp.reg_imss as NSS,emp.curp as CURP, ")
                .Append("emp.fecha_ingreso as FECHA_ALTA,emp.nombre_completo as NOMBRE_EMPLEADO, ")
                .Append("emp.salario_diario as SALARIO_DIARIO_ACTUAL,emp.salario_integ as SDI, ")
                .Append("pgn.dias_cot as DIAS_LABORADOS,pgn.dias_trab as trabajados_reales,PGN.faltas as FALTAS,pgn.dias_incap as DIAS_INCAPACIDADGENERAL,inc1.dias as RIESGOTRABAJO,inc2.dias as MATERNIDAD,pgn.total_reten as impuestoretenido, ")
                .Append("c1.importe as FONDODEAHORRO, ")
                .Append("c2.importe as valesdedespensa, ")
                .Append("c3.cuota as subsidioalempleo, ")
                .Append("c4.importe as imss, ")
                .Append("c5.importe as isr, ")
                .Append("C6.cuota as PRIMAVACACIONAL, ")

                .Append("c7.cuota as diafestivo, ")
                .Append("c8.importe as primadominical, ")
                .Append("c9.importe as bonos, ")

                .Append("c10.importe as horasextras, ")
                .Append("c11.cuota as aguinaldo15P, ")
                .Append("c12.cuota as aguinaldo30P, ")
                .Append("c13.importe as primav25P, ")
                .Append("c14.importe as primav70P, ")
                .Append("c15.cuota as vales10P, ")
                .Append("c16.cuota as fondo13P, ")
                .Append("c17.importe as otrosingresos, ")

                .Append("fpago.nombre AS NOMBRE ")
                .Append("from empleados emp ")
                .Append("inner join deptos_no dn ")
                .Append("on emp.depto_no_id = dn.depto_no_id ")
                .Append("inner join puestos_no pn ")
                .Append("on emp.puesto_no_id = pn.puesto_no_id ")
                .Append("inner join pagos_nomina pgn ")
                .Append("on emp.empleado_id =pgn.empleado_id ")
                .Append("inner join pagos_nomina_det pnd ")
                .Append("on pgn.pago_nomina_id = pnd.pago_nomina_id ")
                .Append("left join Conceptos c1 ")
                .Append(" on pgn.pago_nomina_id = c1.pago_nomina_id and emp.empleado_id = c1.empleado_id ")
                .Append("and c1.concepto_no_id = 644 ")
                .Append("left join Conceptos c2 ")
                .Append(" on pgn.pago_nomina_id = c2.pago_nomina_id and emp.empleado_id = c2.empleado_id ")
                .Append("and c2.concepto_no_id = 643 ")
                .Append("left join Conceptos c3 ")
                .Append(" on pgn.pago_nomina_id = c3.pago_nomina_id and emp.empleado_id = c3.empleado_id ")
                .Append("and c3.concepto_no_id = 156 ")
                .Append("left join Conceptos c4 ")
                .Append(" on pgn.pago_nomina_id = c4.pago_nomina_id and emp.empleado_id = c4.empleado_id ")
                .Append("and c4.concepto_no_id = 116 ")
                .Append("left join Conceptos c5 ")
                .Append(" on pgn.pago_nomina_id = c5.pago_nomina_id and emp.empleado_id = c5.empleado_id ")
                .Append("and c5.concepto_no_id = 115 ")
                .Append("left join Conceptos c6 ")
                .Append(" on pgn.pago_nomina_id = c6.pago_nomina_id and emp.empleado_id = c6.empleado_id ")
                .Append("and c6.concepto_no_id = 111 ")


                .Append("left join Conceptos c7 ")
                .Append(" on pgn.pago_nomina_id = c7.pago_nomina_id and emp.empleado_id = c7.empleado_id ")
                .Append("and c7.concepto_no_id = 647 ")

                .Append("left join Conceptos c8 ")
                .Append(" on pgn.pago_nomina_id = c8.pago_nomina_id and emp.empleado_id = c8.empleado_id ")
                .Append("and c8.concepto_no_id = 646 ")

                .Append("left join Conceptos c9 ")
                .Append(" on pgn.pago_nomina_id = c9.pago_nomina_id and emp.empleado_id = c9.empleado_id ")
                .Append("and c9.concepto_no_id = 648 ")
                .Append("left join Conceptos c10 ")
                .Append(" on pgn.pago_nomina_id = c10.pago_nomina_id and emp.empleado_id = c10.empleado_id ")
                .Append("and c10.concepto_no_id = 107 ")

                .Append("left join Conceptos c11 ")
                .Append(" on pgn.pago_nomina_id = c11.pago_nomina_id and emp.empleado_id = c11.empleado_id ")
                .Append("and c11.concepto_no_id = 746 ")
                .Append("left join Conceptos c12 ")
                .Append(" on pgn.pago_nomina_id = c12.pago_nomina_id and emp.empleado_id = c12.empleado_id ")
                .Append("and c12.concepto_no_id = 110 ")
                .Append("left join Conceptos c13 ")
                .Append(" on pgn.pago_nomina_id = c13.pago_nomina_id and emp.empleado_id = c13.empleado_id ")
                .Append("and c13.concepto_no_id = 745 ")
                .Append("left join Conceptos c14 ")
                .Append(" on pgn.pago_nomina_id = c14.pago_nomina_id and emp.empleado_id = c14.empleado_id ")
                .Append("and c14.concepto_no_id = 737 ")
                .Append("left join Conceptos c15 ")
                .Append(" on pgn.pago_nomina_id = c15.pago_nomina_id and emp.empleado_id = c15.empleado_id ")
                .Append("and c15.concepto_no_id = 643 ")
                .Append("left join Conceptos c16 ")
                .Append(" on pgn.pago_nomina_id = c16.pago_nomina_id and emp.empleado_id = c16.empleado_id ")
                .Append("and c16.concepto_no_id = 644 ")
                .Append("left join Conceptos c17 ")
                .Append(" on pgn.pago_nomina_id = c17.pago_nomina_id and emp.empleado_id = c17.empleado_id ")
                .Append("and c17.concepto_no_id = 747 ")


                .Append("left join incapacidades inc1 ")
                .Append("on emp.empleado_id  = inc1.empleado_id and inc1.ramo = 'R' ")
                .Append("left join incapacidades inc2 ")
                .Append("on emp.empleado_id = inc2.empleado_id and inc2.ramo = 'M' ")
                .Append("inner join nominas nom ")
                .Append("on nom.nomina_id = pgn.nomina_id ")
                .Append("left join FRECUENCIAS_PAGO fpago ")
                .Append("on fpago.frepag_id = nom.frepag_id ")
                .Append("where  pgn.fecha = " & inicial)





            End With
            'comm.CommandText = strQuery.ToString
            commODBC.CommandText = strQuery.ToString
            'dr = com.ExecuteReader()
            OdbcDr = commODBC.ExecuteReader()
            While OdbcDr.Read()
                Dim c As New reportenomina
                Dim s As New SUA

                ''julio

                If empresa = "FOLDUR" Then
                    If OdbcDr("banco") Is DBNull.Value Then
                        c.banco = "N/A"
                    Else
                        If OdbcDr("banco") = 7516 Then
                            c.banco = "BANCOMER"
                        End If

                        If OdbcDr("banco") = 13479 Then
                            c.banco = "SANTANDER"
                        End If

                    End If

                End If

                ''peugeot
                If empresa = "PEUGEOT" Then
                    If OdbcDr("banco") Is DBNull.Value Then
                        c.banco = "N/A"
                    Else
                        If OdbcDr("banco") = 671 Then
                            c.banco = "BANORTE"
                        End If

                        If OdbcDr("banco") = 680 Then
                            c.banco = "BANCOMER"
                        End If

                        If OdbcDr("banco") = 688 Then
                            c.banco = "BANAMEX"
                        End If

                        If OdbcDr("banco") = 696 Then
                            c.banco = "SCOTIABANK"
                        End If

                        If OdbcDr("banco") = 704 Then
                            c.banco = "SANTANDER"
                        End If

                        If OdbcDr("banco") = 712 Then
                            c.banco = "HSBC"
                        End If



                    End If

                End If
                'peugeot

                If OdbcDr("cuenta") Is DBNull.Value Then
                    c.cuenta = 0
                Else
                    c.cuenta = OdbcDr("cuenta")
                End If

                ''datos

                If OdbcDr("empleado") Is DBNull.Value Then
                    c.noempleado = 0
                Else
                    c.noempleado = OdbcDr("empleado")
                End If

                'If OdbcDr("PRIMAVACACIONAL") Is DBNull.Value Then
                '    c.PRIMAVP = 0
                'Else
                '    c.PRIMAVP = OdbcDr("PRIMAVACACIONAL")
                'End If

                If OdbcDr("SDI") Is DBNull.Value Then
                    c.salariodiarioI = 0
                Else
                    c.salariodiarioI = OdbcDr("SDI")
                End If

                If OdbcDr("NOMBRE_EMPLEADO") Is DBNull.Value Then
                    c.NOMBREP = "N/A"
                Else
                    c.NOMBREP = OdbcDr("NOMBRE_EMPLEADO")


                End If


                If OdbcDr("otrosingresos") Is DBNull.Value Then
                    c.otrosingP = 0
                Else
                    c.otrosingP = OdbcDr("otrosingresos")
                End If

                If OdbcDr("SALARIO_DIARIO_ACTUAL") Is DBNull.Value Then
                    c.CUOTADIARIAP = 0
                Else
                    c.CUOTADIARIAP = OdbcDr("SALARIO_DIARIO_ACTUAL")
                End If

                If OdbcDr("DIAS_LABORADOS") Is DBNull.Value Then
                    c.dias_laborados = 0
                Else
                    c.dias_laborados = OdbcDr("DIAS_LABORADOS")
                End If

                If OdbcDr("trabajados_reales") Is DBNull.Value Then
                    c.diasP = 0
                Else
                    c.diasP = OdbcDr("trabajados_reales")
                End If

                c.sueldoP = c.diasP * c.CUOTADIARIAP



                If OdbcDr("FONDODEAHORRO") Is DBNull.Value Then
                    c.fondodeahorroP = 0
                Else
                    c.fondodeahorroP = OdbcDr("FONDODEAHORRO")
                End If


                If OdbcDr("valesdedespensa") Is DBNull.Value Then
                    c.valesdedespensaP = 0
                Else
                    c.valesdedespensaP = OdbcDr("valesdedespensa")
                End If


                If OdbcDr("subsidioalempleo") Is DBNull.Value Then
                    c.subsidioalempleoP = 0
                Else
                    c.subsidioalempleoP = OdbcDr("subsidioalempleo")
                End If

                c.totalpercepcionesP = c.sueldoP + c.fondodeahorroP + c.valesdedespensaP + c.subsidioalempleoP


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' deducciones

                If OdbcDr("imss") Is DBNull.Value Then
                    c.retencionimssP = 0
                Else
                    c.retencionimssP = OdbcDr("imss")
                End If

                If OdbcDr("isr") Is DBNull.Value Then
                    c.retencionisrP = 0
                Else
                    c.retencionisrP = OdbcDr("isr")
                End If

                If OdbcDr("valesdedespensa") Is DBNull.Value Then
                    c.valesdedespensadP = 0
                Else
                    c.valesdedespensadP = OdbcDr("valesdedespensa")
                End If

                If OdbcDr("FONDODEAHORRO") Is DBNull.Value Then
                    c.fondodeahorroemp = 0
                Else
                    c.fondodeahorroemp = OdbcDr("FONDODEAHORRO")
                End If

                If OdbcDr("FONDODEAHORRO") Is DBNull.Value Then
                    c.fondodeahorropaP = 0
                Else
                    c.fondodeahorropaP = OdbcDr("FONDODEAHORRO")
                End If

                c.amortizacionP = 0

                c.totaldP = c.retencionimssP + c.retencionisrP + c.fondodeahorroemp + c.fondodeahorropaP + c.amortizacionP

                'c.totaldP = c.retencionimssP + c.retencionisrP + c.valesdedespensadP + c.fondodeahorroemp + c.fondodeahorropaP + c.amortizacionP

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' prestaciones
                If c.noempleado = 610616 Or c.noempleado = 610618 Or c.noempleado = 610616 Or c.noempleado = 610604 Or c.noempleado = 610626 Or c.noempleado = 610627 Or c.noempleado = 610628 Or c.noempleado = 610629 Or c.noempleado = 610630 Or c.noempleado = 610631 Or c.noempleado = 610632 Then
                    c.aguinaldo15P = ((c.CUOTADIARIAP * 15) / 12)
                    c.aguinaldo30P = 0
                Else
                    c.aguinaldo30P = ((c.CUOTADIARIAP * 30) / 12)
                    c.aguinaldo15P = 0
                End If


                '' prima vacacional con 25%

                If c.noempleado = 610618 Or c.noempleado = 610615 Or c.noempleado = 610604 Or c.noempleado = 610626 Or c.noempleado = 610627 Or c.noempleado = 610628 Or c.noempleado = 610630 Or c.noempleado = 610631 Or c.noempleado = 610632 Then
                    c.primav25P = (((c.CUOTADIARIAP * 6) * 0.25) / 12)

                    c.primav70P = 0
                End If

                If c.noempleado = 610616 Or c.noempleado = 610629 Then
                    c.primav25P = (((c.CUOTADIARIAP * 10) * 0.25) / 12)

                    c.primav70P = 0
                End If


                ''fin prima vacacional con 25%


                ''prima vacacional con 70 %

                If c.noempleado = 610610 Or c.noempleado = 610625 Or c.noempleado = 610607 Or c.noempleado = 610619 Or c.noempleado = 610608 Then
                    c.primav70P = (((c.CUOTADIARIAP * 13) * 0.7) / 12)
                    c.primav25P = 0
                End If

                If c.noempleado = 610609 Or c.noempleado = 610606 Or c.noempleado = 610620 Or c.empleado = 610621 Or c.empleado = 610601 Or c.noempleado = 610602 Then
                    c.primav70P = (((c.CUOTADIARIAP * 11) * 0.7) / 12)
                    c.primav25P = 0
                End If

                If c.noempleado = 610624 Or c.noempleado = 610612 Or c.noempleado = 610617 Or c.noempleado = 610614 Or c.empleado = 610622 Or c.empleado = 610603 Or c.empleado = 610611 Or c.noempleado = 610605 Then
                    c.primav70P = (((c.CUOTADIARIAP * 10) * 0.7) / 12)
                    c.primav25P = 0
                End If

                If c.noempleado = 610613 Then
                    c.primav70P = (((c.CUOTADIARIAP * 6) * 0.25) / 12)

                    c.primav25P = 0
                End If





                If OdbcDr("valesdedespensa") Is DBNull.Value Then
                    c.vales10P = 0
                Else
                    c.vales10P = OdbcDr("valesdedespensa")
                End If
                If OdbcDr("FONDODEAHORRO") Is DBNull.Value Then
                    c.fondo13P = 0
                Else
                    c.fondo13P = OdbcDr("FONDODEAHORRO")
                End If


                c.totalpresP = c.aguinaldo15P + c.aguinaldo30P + c.primav25P + c.primav70P + c.vales10P + c.fondo13P


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' costo social imss

                Dim factorIntegracion As Double
                Dim salariominimodf As Double
                Dim sueldomensual2 As Double
                Dim izquierda As String = "Costo de Administración"
                Dim tiponomina As Int16
                Dim baseimpuestonomina As Int16
                factorIntegracion = c.salariodiarioI / c.CUOTADIARIAP

                salariominimodf = 75.49
                sueldomensual2 = c.diasP * c.CUOTADIARIAP
                s.SMG = c.CUOTADIARIAP / salariominimodf
                s.ingresosexentosIMSSxsalarios = 0
                If ((sueldomensual2 - s.ingresosexentosIMSSxsalarios) / c.diasP) * factorIntegracion > salariominimodf * 25 Then
                    s.salariobasedecotizacion = salariominimodf * 25 * c.dias_laborados
                Else
                    s.salariobasedecotizacion = ((sueldomensual2 - s.ingresosexentosIMSSxsalarios) * factorIntegracion)
                End If

                If s.salariobasedecotizacion > 0 Then
                    s.salariominimoDF = (salariominimodf * c.diasP)
                Else
                    s.salariominimoDF = 0
                End If

                If s.salariobasedecotizacion - (s.salariominimoDF * 3) > 0 Then
                    s.excedente35mgdf = s.salariobasedecotizacion - (s.salariominimoDF * 3)
                Else
                    s.excedente35mgdf = 0
                End If

                s.riesgodetrabajop = (s.salariobasedecotizacion * 0.54355) / 100
                izquierda = "Costo de Administración"
                If izquierda = "PRECAUCIÓN" Then
                    s.coutafijap = s.salariominimoDF * 20.4 * 2.7
                Else
                    s.coutafijap = s.salariominimoDF * 20.4 / 100
                End If

                s.exedentep = s.excedente35mgdf * 1.1 / 100
                ''revisado
                s.prestacionesendinerop = s.salariobasedecotizacion * 0.7 / 100

                s.gastosmedicospensionadosp = s.salariobasedecotizacion * 1.05 / 100

                s.invalidezyvidap = s.salariobasedecotizacion * 1.75 / 100

                s.guaderiasp = s.salariobasedecotizacion * 1 / 100

                s.retirop = (s.salariobasedecotizacion * 2 / 100)

                s.cesantiayvejezp = s.salariobasedecotizacion * 3.15 / 100

                s.totalpatron = s.riesgodetrabajop + s.coutafijap + s.exedentep + s.prestacionesendinerop + s.gastosmedicospensionadosp + s.invalidezyvidap + s.guaderiasp + s.retirop + s.cesantiayvejezp

                ''trabajador

                s.exedentet = s.excedente35mgdf * 0.4 / 100

                s.prestacionesendinerot = s.salariobasedecotizacion * 0.25 / 100

                s.gastosmedicospensionadost = s.salariobasedecotizacion * 0.375 / 100

                s.invalidezyvidat = s.salariobasedecotizacion * 0.625 / 100

                If izquierda = "PRECAUCIÓN" Then
                    s.cesantiayvejezt = (s.salariobasedecotizacion * 1.125 / 100) * 2.7
                Else
                    s.cesantiayvejezt = s.salariobasedecotizacion * 1.125 / 100
                End If

                s.totaltrabador = s.exedentet + s.prestacionesendinerot + s.gastosmedicospensionadost + s.invalidezyvidat + s.cesantiayvejezt

                s.riesgodetrabajopyt = s.riesgodetrabajop

                s.coutafijapyt = s.coutafijap

                s.exedentepyt = s.exedentep + s.exedentet

                s.prestacionesendineropyt = s.prestacionesendinerop + s.prestacionesendinerot

                s.gastosmedicospensionadospyt = s.gastosmedicospensionadosp + s.gastosmedicospensionadost

                s.invalidezyvidapyt = s.invalidezyvidap + s.invalidezyvidat

                s.guaderiaspyt = s.guaderiasp

                s.retiropyt = s.retirop

                s.cesantiayvejezpyt = s.cesantiayvejezp + s.cesantiayvejezt

                s.totalpatronyt = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt + s.retiropyt + s.cesantiayvejezpyt

                s.mensual = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt

                s.bimestral = s.retiropyt + s.cesantiayvejezpyt

                tiponomina = 1

                If tiponomina = 1 Then
                    s.total = s.mensual + s.bimestral
                Else

                End If


                If tiponomina = 1 Then
                    s.infonavit = s.salariobasedecotizacion * 5 / 100
                Else
                    s.infonavit = 0
                End If

                baseimpuestonomina = 1
                s.ingresosexentosimpuestossobrenominas = 0
                s.asimiladosmensuales = 0

                If baseimpuestonomina = 1 Then
                    s.impuestosobrenominac = ((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) * 3 / 100
                Else
                    s.impuestosobrenominac = (((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) + s.asimiladosmensuales) * 3 / 100
                End If

                c.costosimssP = s.total + s.infonavit + s.impuestosobrenominac

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''costosocial ISN

                c.costosisnP = ((c.sueldoP + c.otrosingP + c.vales10P + c.fondo13P) * 3 / 100)
                'If OdbcDr("horasextras") Is DBNull.Value Then
                '    c.horasextrasP = 0
                'Else
                '    c.horasextrasP = OdbcDr("horasextras")
                'End If

                'If OdbcDr("bonos") Is DBNull.Value Then
                '    c.bonosP = 0
                'Else
                '    c.bonosP = OdbcDr("bonos")
                'End If

                'If OdbcDr("diafestivo") Is DBNull.Value Then
                '    c.diafP = 0
                'Else
                '    c.diafP = OdbcDr("diafestivo")
                'End If

                'If OdbcDr("primadominical") Is DBNull.Value Then
                '    c.diafP = 0
                'Else
                '    c.diafP = OdbcDr("primadominical")
                'End If
                ''isn



                'c.costosisnP = c.sueldoP + c.PRIMAVP + c.diafP + c.PRIMAdP + c.bonosP + c.horasextrasP



                c.totalimpuesto = c.costosimssP - c.costosisnP

                c.costopatronalP = (c.sueldoP + c.totalpresP + c.totalimpuesto + c.costosisnP)
                c.comisionP = (c.costopatronalP * 0.14)
                c.subtP = (c.costopatronalP + c.comisionP)

                c.ivaP = (c.subtP * 0.16)

                c.totalP = (c.subtP + c.ivaP)



                arreDatos.Add(c)
            End While
            'Me.m_conn.Close()
            Me.m_ConnODBC.Close()
            Return arreDatos
        Catch ex As Exception
            Try
                trODBC.Rollback()
            Catch ex1 As Exception
                MsgBox(ex.Message)
            End Try
        Finally
            Try
                Me.m_ConnODBC.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Try
    End Function

    ''Empleados

    Public Function ObtenCalculosEmpleado(ByVal empresa As String, ByVal tipo As String) As ArrayList


        'Dim tr As FbTransaction
        Dim trODBC As OdbcTransaction
        Try
            Dim cadenaODBC As String

            cadenaODBC = Me.m_con

            Dim OdbcDr As OdbcDataReader
            Dim arreDatos As New ArrayList
            Dim strQuery As New System.Text.StringBuilder()
            'Me.m_conn.Open()
            Me.m_ConnODBC = New OdbcConnection(cadenaODBC)
            Me.m_ConnODBC.Open()
            trODBC = Me.m_ConnODBC.BeginTransaction(IsolationLevel.Serializable)
            Dim commODBC As New OdbcCommand("", Me.m_ConnODBC, trODBC)
            With strQuery
                .Remove(0, .Length)
                .Append("Select frec.nombre As frecuencia_pago, depto.nombre As departamento, claves.clave As clave_departamento, puesto.nombre As puesto_nombre, clavesp.clave As clave_puesto, ")
                .Append("em.numero As numero_empleado, em.rfc As RFC, em.reg_imss As NSS, em.curp As CURP, em.fecha_ingreso As fecha_alta, inci.fecha As fecha_baja, inci.tipo, em.nombre_completo As nombre, ")
                .Append("em.salario_diario As salario_diario, em.salario_integ As SDI, em.num_ctaban_pago_elect As cuenta_bancaria, em.grupo_pago_elect_id As banco, em.PCTJE_INTEG as porcentaje_integracion ")
                .Append("from empleados em ")
                .Append("inner join frecuencias_pago frec ")
                .Append("on em.frepag_id = frec.frepag_id ")
                .Append("inner join deptos_no depto ")
                .Append("on em.depto_no_id = depto.depto_no_id ")
                .Append("inner join claves_cat_sec claves ")
                .Append("on depto.depto_no_id = claves.elem_id ")
                .Append("inner join puestos_no puesto ")
                .Append("on em.puesto_no_id = puesto.puesto_no_id ")
                .Append("inner join claves_cat_sec clavesp ")
                .Append("on puesto.puesto_no_id =clavesp.elem_id ")
                .Append("inner join incidencias inci ")
                .Append("on em.empleado_id =  inci.empleado_id ")

                If tipo = "Baja" Then
                    .Append(" where em.estatus = 'B'  and inci.tipo = 'B' ")
                End If

                If tipo = "Activo" Then

                    .Append(" where em.estatus = 'A'  and inci.tipo = 'I' ")
                End If






            End With
            'comm.CommandText = strQuery.ToString
            commODBC.CommandText = strQuery.ToString
            'dr = com.ExecuteReader()
            OdbcDr = commODBC.ExecuteReader()
            While OdbcDr.Read()
                Dim c As New reportenomina
                Dim s As New SUA

                ''julio

                If empresa = "FOLDUR" Then

                    If OdbcDr("banco") Is DBNull.Value Then
                        c.bancoe = "N/A"
                    Else
                        If OdbcDr("banco") = 7516 Then
                            c.bancoe = "BANCOMER"
                        End If

                        If OdbcDr("banco") = 13479 Then
                            c.bancoe = "SANTANDER"
                        End If

                    End If


                End If


                If empresa <> "FOLDUR" Then
                    If OdbcDr("banco") Is DBNull.Value Then
                        c.bancoe = "N/A"
                    Else
                        If OdbcDr("banco") = 7516 Then
                            c.bancoe = "BANCOMER"
                        End If

                        If OdbcDr("banco") = 13479 Then
                            c.bancoe = "SANTANDER"
                        End If

                    End If
                End If


                If OdbcDr("cuenta_bancaria") Is DBNull.Value Then
                    c.cuentabancaria = 0
                Else
                    c.cuentabancaria = OdbcDr("cuenta_bancaria")
                End If


                ''porcentaje

                If OdbcDr("porcentaje_integracion") Is DBNull.Value Then
                    c.factorintegracion = "N/A"
                Else
                    c.factorintegracion = OdbcDr("porcentaje_integracion") / 100
                End If

                    If OdbcDr("frecuencia_pago") Is DBNull.Value Then
                        c.frecuenciae = "N/A"
                    Else
                        c.frecuenciae = OdbcDr("frecuencia_pago")
                    End If


                    If OdbcDr("departamento") Is DBNull.Value Then
                        c.nombredeptoe = "N/A"
                    Else
                        c.nombredeptoe = OdbcDr("departamento")
                    End If

                    If OdbcDr("clave_departamento") Is DBNull.Value Then
                        c.clavedepto = "N/A"
                    Else
                        c.clavedepto = OdbcDr("clave_departamento")
                    End If



                    If OdbcDr("puesto_nombre") Is DBNull.Value Then
                        c.nombrepuesto = "N/A"
                    Else
                        c.nombrepuesto = OdbcDr("puesto_nombre")
                    End If


                    If OdbcDr("clave_puesto") Is DBNull.Value Then
                        c.clavepuesto = "N/A"
                    Else
                        c.clavepuesto = OdbcDr("clave_puesto")
                    End If

                    If OdbcDr("numero_empleado") Is DBNull.Value Then
                        c.noempleado = "N/A"
                    Else
                        c.noempleado = OdbcDr("numero_empleado")
                    End If


                    If OdbcDr("RFC") Is DBNull.Value Then
                        c.rfce = "N/A"
                    Else
                        c.rfce = OdbcDr("RFC")
                    End If


                    If OdbcDr("NSS") Is DBNull.Value Then
                        c.nsse = "N/A"
                    Else
                        c.nsse = OdbcDr("NSS")
                    End If


                    If OdbcDr("CURP") Is DBNull.Value Then
                        c.curpe = "N/A"
                    Else
                        c.curpe = OdbcDr("CURP")
                    End If


                    If OdbcDr("fecha_alta") Is DBNull.Value Then
                        c.fechaalta = "N/A"
                    Else
                        c.fechaalta = OdbcDr("fecha_alta")
                    End If

                    If OdbcDr("fecha_baja") Is DBNull.Value Then
                        c.fechabaja = "N/A"
                    End If

                    If tipo = "Baja" Then
                        c.fechabaja = OdbcDr("fecha_baja")
                    End If

                    If tipo = "Activo" Then
                        c.fechabaja = "N/A"
                    End If

                    If OdbcDr("nombre") Is DBNull.Value Then
                        c.nomempleado = "N/A"
                    Else
                        c.nomempleado = OdbcDr("nombre")
                    End If

                  

                    If OdbcDr("salario_diario") Is DBNull.Value Then
                        c.salariodiario = "N/A"
                    Else
                        c.salariodiario = OdbcDr("salario_diario")
                    End If

                    If OdbcDr("SDI") Is DBNull.Value Then
                        c.salariodiarioI = "N/A"
                    Else
                        c.salariodiarioI = OdbcDr("SDI")
                    End If



                    ''fin 


                    arreDatos.Add(c)
            End While
            'Me.m_conn.Close()
            Me.m_ConnODBC.Close()
            Return arreDatos
        Catch ex As Exception
            Try
                trODBC.Rollback()
            Catch ex1 As Exception
                MsgBox(ex.Message)
            End Try
        Finally
            Try
                Me.m_ConnODBC.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Try
    End Function

End Class
