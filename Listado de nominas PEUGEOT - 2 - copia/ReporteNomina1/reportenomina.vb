Public Class reportenomina

    Private m_centro As String
    Public Property centro() As String
        Get
            Return Me.m_centro
        End Get
        Set(ByVal value As String)
            Me.m_centro = value
        End Set
    End Property
    Private m_departamento As String
    Public Property departartamento() As String
        Get
            Return Me.m_departamento
        End Get
        Set(ByVal value As String)
            Me.m_departamento = value
        End Set
    End Property
    Private m_puesto As String
    Public Property puesto() As String
        Get
            Return Me.m_puesto
        End Get
        Set(ByVal value As String)
            Me.m_puesto = value
        End Set
    End Property
    Private m_empleado As String
    Public Property empleado() As String
        Get
            Return Me.m_empleado
        End Get
        Set(ByVal value As String)
            Me.m_empleado = value
        End Set
    End Property
    Private m_rfc As String
    Public Property rfc() As String
        Get
            Return Me.m_rfc
        End Get
        Set(ByVal value As String)
            Me.m_rfc = value
        End Set
    End Property
    Private m_nss As String
    Public Property nss() As String
        Get
            Return Me.m_nss
        End Get
        Set(ByVal value As String)
            Me.m_nss = value
        End Set
    End Property
    Private m_curp As String
    Public Property curp() As String
        Get
            Return Me.m_curp
        End Get
        Set(ByVal value As String)
            Me.m_curp = value
        End Set
    End Property
    Private m_fecha_alta As String
    Public Property fecha_alta() As String
        Get
            Return Me.m_fecha_alta
        End Get
        Set(ByVal value As String)
            Me.m_fecha_alta = value
        End Set
    End Property
    Private m_nombre As String
    Public Property nombre() As String
        Get
            Return Me.m_nombre
        End Get
        Set(ByVal value As String)
            Me.m_nombre = value
        End Set
    End Property
    Private m_sueldodiario As Double
    Public Property sueldodiario() As Double
        Get
            Return Me.m_sueldodiario
        End Get
        Set(ByVal value As Double)
            Me.m_sueldodiario = value
        End Set
    End Property
    Private m_sdi As Double
    Public Property sdi() As Double
        Get
            Return Me.m_sdi
        End Get
        Set(ByVal value As Double)
            Me.m_sdi = value
        End Set
    End Property
    Private m_dias_laborados As Double
    Public Property dias_laborados() As Double
        Get
            Return Me.m_dias_laborados
        End Get
        Set(ByVal value As Double)
            Me.m_dias_laborados = value
        End Set
    End Property
    Private m_dias_laboradosreales As Double
    Public Property dias_laboradosreales() As Double
        Get
            Return Me.m_dias_laboradosreales
        End Get
        Set(ByVal value As Double)
            Me.m_dias_laboradosreales = value
        End Set
    End Property
    Private m_dias_faltas As Integer
    Public Property dias_faltas() As Integer
        Get
            Return Me.m_dias_faltas
        End Get
        Set(ByVal value As Integer)
            Me.m_dias_faltas = value
        End Set
    End Property
    Private m_descuentop_aldia As Double
    Public Property descuentop_aldia() As Double
        Get
            Return Me.m_descuentop_aldia
        End Get
        Set(ByVal value As Double)
            Me.m_descuentop_aldia = value
        End Set
    End Property
    Private m_faltas As Double
    Public Property faltas() As Double
        Get
            Return Me.m_faltas
        End Get
        Set(ByVal value As Double)
            Me.m_faltas = value
        End Set
    End Property
    Private m_diasIncEnfGral As Integer
    Public Property diasIncEnfGral() As Integer
        Get
            Return Me.m_diasIncEnfGral
        End Get
        Set(ByVal value As Integer)
            Me.m_diasIncEnfGral = value
        End Set
    End Property
    Private m_diasmaternidad As Integer
    Public Property diasmaternidad() As Integer
        Get
            Return Me.m_diasmaternidad
        End Get
        Set(ByVal value As Integer)
            Me.m_diasmaternidad = value
        End Set
    End Property
    Private m_diasIncTrayecto As Integer
    Public Property diasIncTrayecto() As Integer
        Get
            Return Me.m_diasIncTrayecto
        End Get
        Set(ByVal value As Integer)
            Me.m_diasIncTrayecto = value
        End Set
    End Property
    Private m_sueldo As Double
    Public Property sueldo() As Double
        Get
            Return Me.m_sueldo
        End Get
        Set(ByVal value As Double)
            Me.m_sueldo = value
        End Set
    End Property
    Private m_OtrosIngresosGravados As Double
    Public Property OtrosIngresosGravados() As Double
        Get
            Return Me.m_OtrosIngresosGravados
        End Get
        Set(ByVal value As Double)
            Me.m_OtrosIngresosGravados = value
        End Set
    End Property
    Private m_OtrosIngresosExento As Double
    Public Property OtrosIngresosExento() As Double
        Get
            Return Me.m_OtrosIngresosExento
        End Get
        Set(ByVal value As Double)
            Me.m_OtrosIngresosExento = value
        End Set
    End Property
    Private m_primaVacacional As Double
    Public Property primaVacacional() As Double
        Get
            Return Me.m_primaVacacional
        End Get
        Set(ByVal value As Double)
            Me.m_primaVacacional = value
        End Set
    End Property
    Private m_diaFestivo As Double
    Public Property diaFestivo() As Double
        Get
            Return Me.m_diaFestivo
        End Get
        Set(ByVal value As Double)
            Me.m_diaFestivo = value
        End Set
    End Property
    Private m_primaDominical As Double
    Public Property primaDominical() As Double
        Get
            Return Me.m_primaDominical
        End Get
        Set(ByVal value As Double)
            Me.m_primaDominical = value
        End Set
    End Property
    Private m_Bonos As Double
    Public Property Bonos() As Double
        Get
            Return Me.m_Bonos
        End Get
        Set(ByVal value As Double)
            Me.m_Bonos = value
        End Set
    End Property
    Private m_horasExtra As Double
    Public Property horasExtra() As Double
        Get
            Return Me.m_horasExtra
        End Get
        Set(ByVal value As Double)
            Me.m_horasExtra = value
        End Set
    End Property
    Private m_sudsidioapraelempleopagado As Double
    Public Property sudsidioapraelempleopagado() As Double
        Get
            Return Me.m_sudsidioapraelempleopagado
        End Get
        Set(ByVal value As Double)
            Me.m_sudsidioapraelempleopagado = value
        End Set
    End Property
    Private m_totalpercepciones As Double
    Public Property totalpercepciones() As Double
        Get
            Return Me.m_totalpercepciones
        End Get
        Set(ByVal value As Double)
            Me.m_totalpercepciones = value
        End Set
    End Property
    Private m_impuestoretenido As Double
    Public Property impuestoretenido() As Double
        Get
            Return Me.m_impuestoretenido
        End Get
        Set(ByVal value As Double)
            Me.m_impuestoretenido = value
        End Set
    End Property

    Private m_pension_alimenticia As Double
    Public Property pension_alimenticia() As Double
        Get
            Return Me.m_pension_alimenticia
        End Get
        Set(ByVal value As Double)
            Me.m_pension_alimenticia = value
        End Set
    End Property


    Private m_Descanso_laborado As Double
    Public Property Descanso_laborado() As Double
        Get
            Return Me.m_Descanso_laborado
        End Get
        Set(ByVal value As Double)
            Me.m_Descanso_laborado = value
        End Set
    End Property
    Private m_Descanso_laborado1 As Double
    Public Property Descanso_laborado1() As Double
        Get
            Return Me.m_Descanso_laborado1
        End Get
        Set(ByVal value As Double)
            Me.m_Descanso_laborado1 = value
        End Set
    End Property


    Private m_ISR_ANUAL As Double
    Public Property ISR_ANUAL() As Double
        Get
            Return Me.m_ISR_ANUAL
        End Get
        Set(ByVal value As Double)
            Me.m_ISR_ANUAL = value
        End Set
    End Property

    Private m_Descuento_fonacot As Double
    Public Property Descuento_fonacot() As Double
        Get
            Return Me.m_Descuento_fonacot
        End Get
        Set(ByVal value As Double)
            Me.m_Descuento_fonacot = value
        End Set
    End Property




    Private m_imss As Double
    Public Property imss() As Double
        Get
            Return Me.m_imss
        End Get
        Set(ByVal value As Double)
            Me.m_imss = value
        End Set
    End Property
    Private m_DescCreditoInfonavit As Double
    Public Property DescCreditoInfonavit() As Double
        Get
            Return Me.m_DescCreditoInfonavit
        End Get
        Set(ByVal value As Double)
            Me.m_DescCreditoInfonavit = value
        End Set
    End Property
    Private m_AjusteDifInfonavit As Double
    Public Property AjusteDifInfonavit() As Double
        Get
            Return Me.m_AjusteDifInfonavit
        End Get
        Set(ByVal value As Double)
            Me.m_AjusteDifInfonavit = value
        End Set
    End Property
    Private m_otrosdescuentos As Double
    Public Property otrosdescuentos() As Double
        Get
            Return Me.m_otrosdescuentos
        End Get
        Set(ByVal value As Double)
            Me.m_otrosdescuentos = value
        End Set
    End Property

    Private m_descuentofaltas As Double
    Public Property descuentofaltas() As Double
        Get
            Return Me.m_descuentofaltas
        End Get
        Set(ByVal value As Double)
            Me.m_descuentofaltas = value
        End Set
    End Property
    Private m_totaldeducciones As Double
    Public Property totaldeducciones() As Double
        Get
            Return Me.m_totaldeducciones
        End Get
        Set(ByVal value As Double)
            Me.m_totaldeducciones = value
        End Set
    End Property
    Private m_netopagar As Double
    Public Property netopagar() As Double
        Get
            Return Me.m_netopagar
        End Get
        Set(ByVal value As Double)
            Me.m_netopagar = value
        End Set
    End Property
    Private m_isn As Double
    Public Property isn() As Double
        Get
            Return Me.m_isn
        End Get
        Set(ByVal value As Double)
            Me.m_isn = value
        End Set
    End Property
    Private m_sua As Double
    Public Property sua() As Double
        Get
            Return Me.m_sua
        End Get
        Set(ByVal value As Double)
            Me.m_sua = value
        End Set
    End Property
    Private m_cargasocial As Double
    Public Property cargasocial() As Double
        Get
            Return Me.m_cargasocial
        End Get
        Set(ByVal value As Double)
            Me.m_cargasocial = value
        End Set
    End Property

    Private m_sueldomensual As Double
    Public Property sueldomensual() As Double
        Get
            Return Me.m_sueldomensual
        End Get
        Set(ByVal value As Double)
            Me.m_sueldomensual = value
        End Set
    End Property

    Private m_vacaciones As Double
    Public Property vacaciones() As Double
        Get
            Return Me.m_vacaciones
        End Get
        Set(ByVal value As Double)
            Me.m_vacaciones = value
        End Set
    End Property
    Private m_primavacacional2 As Double
    Public Property primavacacional2() As Double
        Get
            Return Me.m_primavacacional2
        End Get
        Set(ByVal value As Double)
            Me.m_primavacacional2 = value
        End Set
    End Property
    Private m_aguinaldo As Double
    Public Property aguinaldo() As Double
        Get
            Return Me.m_aguinaldo
        End Get
        Set(ByVal value As Double)
            Me.m_aguinaldo = value
        End Set
    End Property
    Private m_totalpasivolaboral As Double
    Public Property totalpasivolaboral() As Double
        Get
            Return Me.m_totalpasivolaboral
        End Get
        Set(ByVal value As Double)
            Me.m_totalpasivolaboral = value
        End Set
    End Property



    ''julio

    Private m_cuenta As String
    Public Property cuenta() As String
        Get
            Return Me.m_cuenta
        End Get
        Set(ByVal value As String)
            Me.m_cuenta = value
        End Set
    End Property

    Private m_banco As String
    Public Property banco() As String
        Get
            Return Me.m_banco
        End Get
        Set(ByVal value As String)
            Me.m_banco = value
        End Set
    End Property

    Private m_clabe As Double
    Public Property clabe() As Double
        Get
            Return Me.m_clabe
        End Get
        Set(ByVal value As Double)
            Me.m_clabe = value
        End Set
    End Property



    ''julio

    ''agosto

    Private m_bancoe As String
    Public Property bancoe() As String
        Get
            Return Me.m_bancoe
        End Get
        Set(ByVal value As String)
            Me.m_bancoe = value
        End Set
    End Property


    Private m_cuentabancaria As Double
    Public Property cuentabancaria() As Double
        Get
            Return Me.m_cuentabancaria
        End Get
        Set(ByVal value As Double)
            Me.m_cuentabancaria = value
        End Set
    End Property

    Private m_frecuenciae As String
    Public Property frecuenciae() As String
        Get
            Return Me.m_frecuenciae
        End Get
        Set(ByVal value As String)
            Me.m_frecuenciae = value
        End Set
    End Property

    Private m_clavedepto As String
    Public Property clavedepto() As String
        Get
            Return Me.m_clavedepto
        End Get
        Set(ByVal value As String)
            Me.m_clavedepto = value
        End Set
    End Property

    Private m_nombredepto As String
    Public Property nombredeptoe() As String
        Get
            Return Me.m_nombredepto
        End Get
        Set(ByVal value As String)
            Me.m_nombredepto = value
        End Set
    End Property

    Private m_clavepuesto As String
    Public Property clavepuesto() As String
        Get
            Return Me.m_clavepuesto
        End Get
        Set(ByVal value As String)
            Me.m_clavepuesto = value
        End Set
    End Property

    Private m_nombrepuesto As String
    Public Property nombrepuesto() As String
        Get
            Return Me.m_nombrepuesto
        End Get
        Set(ByVal value As String)
            Me.m_nombrepuesto = value
        End Set
    End Property

    Private m_noempleado As String
    Public Property noempleado() As String
        Get
            Return Me.m_noempleado
        End Get
        Set(ByVal value As String)
            Me.m_noempleado = value
        End Set
    End Property

    Private m_rfce As String
    Public Property rfce() As String
        Get
            Return Me.m_rfce
        End Get
        Set(ByVal value As String)
            Me.m_rfce = value
        End Set
    End Property

    Private m_nsse As String
    Public Property nsse() As String
        Get
            Return Me.m_nsse
        End Get
        Set(ByVal value As String)
            Me.m_nsse = value
        End Set
    End Property

    Private m_curpe As String
    Public Property curpe() As String
        Get
            Return Me.m_curpe
        End Get
        Set(ByVal value As String)
            Me.m_curpe = value
        End Set
    End Property

    Private m_fechaalta As String
    Public Property fechaalta() As String
        Get
            Return Me.m_fechaalta
        End Get
        Set(ByVal value As String)
            Me.m_fechaalta = value
        End Set
    End Property

    Private m_fechabaja As String
    Public Property fechabaja() As String
        Get
            Return Me.m_fechabaja
        End Get
        Set(ByVal value As String)
            Me.m_fechabaja = value
        End Set
    End Property


    Private m_nomempleado As String
    Public Property nomempleado() As String
        Get
            Return Me.m_nomempleado
        End Get
        Set(ByVal value As String)
            Me.m_nomempleado = value
        End Set
    End Property

    Private m_factorintegracion As String
    Public Property factorintegracion() As String
        Get
            Return Me.m_factorintegracion
        End Get
        Set(ByVal value As String)
            Me.m_factorintegracion = value
        End Set
    End Property

    Private m_salariodiario As String
    Public Property salariodiario() As String
        Get
            Return Me.m_salariodiario
        End Get
        Set(ByVal value As String)
            Me.m_salariodiario = value
        End Set
    End Property

    Private m_salariodiarioI As String


    Public Property salariodiarioI() As String
        Get
            Return m_salariodiarioI
        End Get
        Set(ByVal value As String)
            Me.m_salariodiarioI = value
        End Set
    End Property


    ''PEUGEOT


    Private m_PRIMAdP As Double

    Public Property PRIMAdP() As Double
        Get
            Return m_PRIMAdP
        End Get
        Set(ByVal value As Double)
            Me.m_PRIMAdP = value
        End Set
    End Property


    Private m_PRIMAvP As Double

    Public Property PRIMAVP() As Double
        Get
            Return m_PRIMAVP
        End Get
        Set(ByVal value As Double)
            Me.m_PRIMAVP = value
        End Set
    End Property
    Private m_NOMBREP As String

    Public Property NOMBREP() As String
        Get
            Return m_NOMBREP
        End Get
        Set(ByVal value As String)
            Me.m_NOMBREP = value
        End Set
    End Property

    Private m_CUOTADIARIAP As Double

    Public Property CUOTADIARIAP() As Double
        Get
            Return m_CUOTADIARIAP
        End Get
        Set(ByVal value As Double)
            Me.m_CUOTADIARIAP = value
        End Set
    End Property


    Private m_diasp As Double
    Public Property diasP() As Double
        Get
            Return m_diasp
        End Get
        Set(ByVal value As Double)
            Me.m_diasp = value
        End Set
    End Property

    Private m_sueldop As Double
    Public Property sueldoP() As Double
        Get
            Return m_sueldop
        End Get
        Set(ByVal value As Double)
            Me.m_sueldop = value
        End Set
    End Property

    Private m_fondodeahorrop As Double
    Public Property fondodeahorroP() As Double
        Get
            Return m_fondodeahorrop
        End Get
        Set(ByVal value As Double)
            Me.m_fondodeahorrop = value
        End Set
    End Property

    Private m_valesdedespensap As Double
    Public Property valesdedespensaP() As Double
        Get
            Return m_valesdedespensap
        End Get
        Set(ByVal value As Double)
            Me.m_valesdedespensap = value
        End Set
    End Property

    Private m_subsidioalempleop As Double
    Public Property subsidioalempleoP() As Double
        Get
            Return m_subsidioalempleop
        End Get
        Set(ByVal value As Double)
            Me.m_subsidioalempleop = value
        End Set
    End Property

    Private m_totalpercepcionesp As Double
    Public Property totalpercepcionesP() As Double
        Get
            Return m_totalpercepcionesp
        End Get
        Set(ByVal value As Double)
            Me.m_totalpercepcionesp = value
        End Set
    End Property

    Private m_retencionimssp As Double
    Public Property retencionimssP() As Double
        Get
            Return m_retencionimssp
        End Get
        Set(ByVal value As Double)
            Me.m_retencionimssp = value
        End Set
    End Property

    Private m_retencionisrp As Double
    Public Property retencionisrP() As Double
        Get
            Return m_retencionisrp
        End Get
        Set(ByVal value As Double)
            Me.m_retencionisrp = value
        End Set
    End Property

    Private m_valesdedespensadp As Double
    Public Property valesdedespensadP() As Double
        Get
            Return m_valesdedespensadp
        End Get
        Set(ByVal value As Double)
            Me.m_valesdedespensadp = value
        End Set
    End Property


    Private m_fondodeahorroemp As Double
    Public Property fondodeahorroemp() As Double
        Get
            Return m_fondodeahorroemp
        End Get
        Set(ByVal value As Double)
            Me.m_fondodeahorroemp = value
        End Set
    End Property

    Private m_fondodeahorropap As Double
    Public Property fondodeahorropaP() As Double
        Get
            Return m_fondodeahorropap
        End Get
        Set(ByVal value As Double)
            Me.m_fondodeahorropap = value
        End Set
    End Property

    Private m_amortizacionp As Double
    Public Property amortizacionP() As Double
        Get
            Return m_amortizacionp
        End Get
        Set(ByVal value As Double)
            Me.m_amortizacionp = value
        End Set
    End Property

    Private m_totaldp As Double
    Public Property totaldP() As Double
        Get
            Return m_totaldp
        End Get
        Set(ByVal value As Double)
            Me.m_totaldp = value
        End Set
    End Property

    Private m_ingresonetop As Double
    Public Property ingresonetoP() As Double
        Get
            Return m_ingresonetop
        End Get
        Set(ByVal value As Double)
            Me.m_ingresonetop = value
        End Set
    End Property

    Private m_aguinaldo15p As Double
    Public Property aguinaldo15P() As Double
        Get
            Return m_aguinaldo15p
        End Get
        Set(ByVal value As Double)
            Me.m_aguinaldo15p = value
        End Set
    End Property

    Private m_aguinaldo30p As Double
    Public Property aguinaldo30P() As Double
        Get
            Return m_aguinaldo30p
        End Get
        Set(ByVal value As Double)
            Me.m_aguinaldo30p = value
        End Set
    End Property

    Private m_primav25p As Double
    Public Property primav25P() As Double
        Get
            Return m_primav25p
        End Get
        Set(ByVal value As Double)
            Me.m_primav25p = value
        End Set
    End Property


    Private m_primav70p As Double
    Public Property primav70P() As Double
        Get
            Return m_primav70p
        End Get
        Set(ByVal value As Double)
            Me.m_primav70p = value
        End Set
    End Property

    Private m_vales10p As Double
    Public Property vales10P() As Double
        Get
            Return m_vales10p
        End Get
        Set(ByVal value As Double)
            Me.m_vales10p = value
        End Set
    End Property
    Private m_fondo13p As Double
    Public Property fondo13P() As Double
        Get
            Return m_fondo13p
        End Get
        Set(ByVal value As Double)
            Me.m_fondo13p = value
        End Set
    End Property

    Private m_totalpresp As Double
    Public Property totalpresP() As Double
        Get
            Return m_totalpresp
        End Get
        Set(ByVal value As Double)
            Me.m_totalpresp = value
        End Set
    End Property

    Private m_costosimssp As Double
    Public Property costosimssP() As Double
        Get
            Return m_costosimssp
        End Get
        Set(ByVal value As Double)
            Me.m_costosimssp = value
        End Set
    End Property

    Private m_costosisnp As Double
    Public Property costosisnP() As Double
        Get
            Return m_costosisnp
        End Get
        Set(ByVal value As Double)
            Me.m_costosisnp = value
        End Set
    End Property

    Private m_totalimpuesto As Double
    Public Property totalimpuesto() As Double
        Get
            Return m_totalimpuesto
        End Get
        Set(ByVal value As Double)
            Me.m_totalimpuesto = value
        End Set
    End Property


    Private m_costopatronalp As Double
    Public Property costopatronalP() As Double
        Get
            Return m_costopatronalp
        End Get
        Set(ByVal value As Double)
            Me.m_costopatronalp = value
        End Set
    End Property

    Private m_comisionp As Double
    Public Property comisionP() As Double
        Get
            Return m_comisionp
        End Get
        Set(ByVal value As Double)
            Me.m_comisionp = value
        End Set
    End Property

    Private m_subtp As Double
    Public Property subtP() As Double
        Get
            Return m_subtp
        End Get
        Set(ByVal value As Double)
            Me.m_subtp = value
        End Set
    End Property

    Private m_ivap As Double
    Public Property ivaP() As Double
        Get
            Return m_ivap
        End Get
        Set(ByVal value As Double)
            Me.m_ivap = value
        End Set
    End Property


    Private m_totalp As Double
    Public Property totalP() As Double
        Get
            Return m_totalp
        End Get
        Set(ByVal value As Double)
            Me.m_totalp = value
        End Set
    End Property
    Private m_bancop As Double
    Public Property bancoP() As Double
        Get
            Return m_bancop
        End Get
        Set(ByVal value As Double)
            Me.m_bancop = value
        End Set
    End Property
    Private m_cuentap As Double
    Public Property cuentaP() As Double
        Get
            Return m_cuentap
        End Get
        Set(ByVal value As Double)
            Me.m_cuentap = value
        End Set
    End Property

    Private m_otrosingp As Double
    Public Property otrosingP() As Double
        Get
            Return m_otrosingp
        End Get
        Set(ByVal value As Double)
            Me.m_otrosingp = value
        End Set
    End Property


    Private m_diafp As Double
    Public Property diafP() As Double
        Get
            Return m_diafp
        End Get
        Set(ByVal value As Double)
            Me.m_diafp = value
        End Set
    End Property

    Private m_descansolp As Double
    Public Property descansolP() As Double
        Get
            Return m_descansolp
        End Get
        Set(ByVal value As Double)
            Me.m_descansolp = value
        End Set
    End Property

    Private m_bonosp As Double
    Public Property bonosP() As Double
        Get
            Return m_bonosp
        End Get
        Set(ByVal value As Double)
            Me.m_bonosp = value
        End Set
    End Property

    Private m_horasextrasp As Double
    Public Property horasextrasP() As Double
        Get
            Return m_horasextrasp
        End Get
        Set(ByVal value As Double)
            Me.m_clabep = value
        End Set
    End Property

    Private m_clabep As String
    Public Property clabeP() As String
        Get
            Return m_clabep
        End Get
        Set(ByVal value As String)
            Me.m_clabep = value
        End Set
    End Property

    ''prestaciones






    ''PEUGEOT






End Class
