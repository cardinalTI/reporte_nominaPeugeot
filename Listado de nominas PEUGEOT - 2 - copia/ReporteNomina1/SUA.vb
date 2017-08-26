Public Class SUA

    ''Instrucciones
    Private m_TISN As Double
    Private m_PdGdRdC As Double
    Private m_ZoAGdT As String

    Public Property ZoAGdT() As String
        Get
            Return Me.m_ZoAGdT
        End Get
        Set(ByVal value As String)
            Me.m_ZoAGdT = value
        End Set
    End Property

    Public Property PdGdRdC() As Double
        Get
            Return Me.m_PdGdRdC
        End Get
        Set(ByVal value As Double)
            Me.m_PdGdRdC = value
        End Set
    End Property

    Public Property TISN() As Double
        Get
            Return Me.m_TISN
        End Get
        Set(ByVal value As Double)
            Me.m_TISN = value
        End Set
    End Property

    '' Fin de Instrucciones

    ''calculo Imss

    Private m_SMG As Double
    Private m_retencionImss As Double
    Private m_retencionISRSueldos As Double
    Private m_subsidioalempleo As Double
    Private m_ingresonetosueldos As Double
    Private m_sueldomensualdeseado As Double
    Private m_asimiladosmensuales As Double
    Private m_honorariosmensuales As Double
    Private m_pagosporfuera As Double
    Private m_totaldeingresos As Double
    Private m_ingresosexentosIMSSxsalarios As Double
    Private m_ingresosexentosimpuestossobrenominas As Double
    Private m_salariobasedecotizacion As Double
    Private m_salariominimoDF As Double
    Private m_excedente35mgdf As Double
    ''patron
    Private m_riesgodetrabajop As Double
    Private m_coutafijap As Double
    Private m_exedentep As Double
    Private m_prestacionesendinerop As Double
    Private m_gastosmedicospensionadosp As Double
    Private m_invalidezyvidap As Double
    Private m_guaderiasp As Double
    Private m_retirop As Double
    Private m_cesantiayvejezp As Double
    Private m_totalpatron As Double

    ''trabajador
    Private m_riesgodetrabajot As Double
    Private m_coutafijat As Double
    Private m_exedentet As Double
    Private m_prestacionesendinerot As Double
    Private m_gastosmedicospensionadost As Double
    Private m_invalidezyvidat As Double
    Private m_guaderiast As Double
    Private m_retirot As Double
    Private m_cesantiayvejezt As Double
    Private m_totaltrabador As Double

    ''patron mas trabajador

    Private m_riesgodetrabajopyt As Double
    Private m_coutafijapyt As Double
    Private m_exedentepyt As Double
    Private m_prestacionesendineropyt As Double
    Private m_gastosmedicospensionadospyt As Double
    Private m_invalidezyvidapyt As Double
    Private m_guaderiaspyt As Double
    Private m_retiropyt As Double
    Private m_cesantiayvejezpyt As Double
    Private m_totalpatronyt As Double

    ''costos sociales

    Private m_mensual As Double
    Private m_bimestral As Double
    Private m_total As Double
    Private m_infonavit As Double
    Private m_impuestosobrenominac As Double
    Private m_totalcostosocial As Double
    Private m_SUA As Double

    Public Property SUA() As Double
        Get
            Return Me.m_SUA
        End Get
        Set(ByVal value As Double)
            Me.m_SUA = value
        End Set
    End Property

    Public Property totalcostosocial() As Double
        Get
            Return Me.m_totalcostosocial
        End Get
        Set(ByVal value As Double)
            Me.m_totalcostosocial = value
        End Set
    End Property

    Public Property impuestosobrenominac() As Double
        Get
            Return Me.m_impuestosobrenominac
        End Get
        Set(ByVal value As Double)
            Me.m_impuestosobrenominac = value
        End Set
    End Property

    Public Property infonavit() As Double
        Get
            Return Me.m_infonavit
        End Get
        Set(ByVal value As Double)
            Me.m_infonavit = value
        End Set
    End Property

    Public Property total() As Double
        Get
            Return Me.m_total
        End Get
        Set(ByVal value As Double)
            Me.m_total = value
        End Set
    End Property

    Public Property bimestral() As Double
        Get
            Return Me.m_bimestral
        End Get
        Set(ByVal value As Double)
            Me.m_bimestral = value
        End Set
    End Property

    Public Property mensual() As Double
        Get
            Return Me.m_mensual
        End Get
        Set(ByVal value As Double)
            Me.m_mensual = value
        End Set
    End Property

    ''patron y trabajador

    Public Property totalpatronyt() As Double
        Get
            Return Me.m_totalpatronyt
        End Get
        Set(ByVal value As Double)
            Me.m_totalpatronyt = value
        End Set
    End Property

    Public Property cesantiayvejezpyt() As Double
        Get
            Return Me.m_cesantiayvejezpyt
        End Get
        Set(ByVal value As Double)
            Me.m_cesantiayvejezpyt = value
        End Set
    End Property

    Public Property retiropyt() As Double
        Get
            Return Me.m_retiropyt
        End Get
        Set(ByVal value As Double)
            Me.m_retiropyt = value
        End Set
    End Property



    Public Property guaderiaspyt() As Double
        Get
            Return Me.m_guaderiaspyt
        End Get
        Set(ByVal value As Double)
            Me.m_guaderiaspyt = value
        End Set
    End Property

    Public Property invalidezyvidapyt() As Double
        Get
            Return Me.m_invalidezyvidapyt
        End Get
        Set(ByVal value As Double)
            Me.m_invalidezyvidapyt = value
        End Set
    End Property

    Public Property gastosmedicospensionadospyt() As Double
        Get
            Return Me.m_gastosmedicospensionadospyt
        End Get
        Set(ByVal value As Double)
            Me.m_gastosmedicospensionadospyt = value
        End Set
    End Property

    Public Property prestacionesendineropyt() As Double
        Get
            Return Me.m_prestacionesendineropyt
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesendineropyt = value
        End Set
    End Property


    Public Property exedentepyt() As Double
        Get
            Return Me.m_exedentepyt
        End Get
        Set(ByVal value As Double)
            Me.m_exedentepyt = value
        End Set
    End Property

    Public Property coutafijapyt() As Double
        Get
            Return Me.m_coutafijapyt
        End Get
        Set(ByVal value As Double)
            Me.m_coutafijapyt = value
        End Set
    End Property

    Public Property riesgodetrabajopyt() As Double
        Get
            Return Me.m_riesgodetrabajopyt
        End Get
        Set(ByVal value As Double)
            Me.m_riesgodetrabajopyt = value
        End Set
    End Property

    ''Fin patron y trabajador


    ''trabajador

    Public Property totaltrabador() As Double
        Get
            Return Me.m_totaltrabador
        End Get
        Set(ByVal value As Double)
            Me.m_totaltrabador = value
        End Set
    End Property

    Public Property cesantiayvejezt() As Double
        Get
            Return Me.m_cesantiayvejezt
        End Get
        Set(ByVal value As Double)
            Me.m_cesantiayvejezt = value
        End Set
    End Property

    Public Property retirot() As Double
        Get
            Return Me.m_retirot
        End Get
        Set(ByVal value As Double)
            Me.m_retirot = value
        End Set
    End Property



    Public Property guaderiast() As Double
        Get
            Return Me.m_guaderiast
        End Get
        Set(ByVal value As Double)
            Me.m_guaderiast = value
        End Set
    End Property

    Public Property invalidezyvidat() As Double
        Get
            Return Me.m_invalidezyvidat
        End Get
        Set(ByVal value As Double)
            Me.m_invalidezyvidat = value
        End Set
    End Property

    Public Property gastosmedicospensionadost() As Double
        Get
            Return Me.m_gastosmedicospensionadost
        End Get
        Set(ByVal value As Double)
            Me.m_gastosmedicospensionadost = value
        End Set
    End Property

    Public Property prestacionesendinerot() As Double
        Get
            Return Me.m_prestacionesendinerot
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesendinerot = value
        End Set
    End Property


    Public Property exedentet() As Double
        Get
            Return Me.m_exedentet
        End Get
        Set(ByVal value As Double)
            Me.m_exedentet = value
        End Set
    End Property

    Public Property coutafijat() As Double
        Get
            Return Me.m_coutafijat
        End Get
        Set(ByVal value As Double)
            Me.m_coutafijat = value
        End Set
    End Property

    Public Property riesgodetrabajot() As Double
        Get
            Return Me.m_riesgodetrabajot
        End Get
        Set(ByVal value As Double)
            Me.m_riesgodetrabajot = value
        End Set
    End Property

    ''Fin trabajador



    ''patron
    Public Property totalpatron() As Double
        Get
            Return Me.m_totalpatron
        End Get
        Set(ByVal value As Double)
            Me.m_totalpatron = value
        End Set
    End Property

    Public Property cesantiayvejezp() As Double
        Get
            Return Me.m_cesantiayvejezp
        End Get
        Set(ByVal value As Double)
            Me.m_cesantiayvejezp = value
        End Set
    End Property

    Public Property retirop() As Double
        Get
            Return Me.m_retirop
        End Get
        Set(ByVal value As Double)
            Me.m_retirop = value
        End Set
    End Property



    Public Property guaderiasp() As Double
        Get
            Return Me.m_guaderiasp
        End Get
        Set(ByVal value As Double)
            Me.m_guaderiasp = value
        End Set
    End Property

    Public Property invalidezyvidap() As Double
        Get
            Return Me.m_invalidezyvidap
        End Get
        Set(ByVal value As Double)
            Me.m_invalidezyvidap = value
        End Set
    End Property

    Public Property gastosmedicospensionadosp() As Double
        Get
            Return Me.m_gastosmedicospensionadosp
        End Get
        Set(ByVal value As Double)
            Me.m_gastosmedicospensionadosp = value
        End Set
    End Property

    Public Property prestacionesendinerop() As Double
        Get
            Return Me.m_prestacionesendinerop
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesendinerop = value
        End Set
    End Property


    Public Property exedentep() As Double
        Get
            Return Me.m_exedentep
        End Get
        Set(ByVal value As Double)
            Me.m_exedentep = value
        End Set
    End Property

    Public Property coutafijap() As Double
        Get
            Return Me.m_coutafijap
        End Get
        Set(ByVal value As Double)
            Me.m_coutafijap = value
        End Set
    End Property

    Public Property riesgodetrabajop() As Double
        Get
            Return Me.m_riesgodetrabajop
        End Get
        Set(ByVal value As Double)
            Me.m_riesgodetrabajop = value
        End Set
    End Property

    ''fin patron 

    Public Property excedente35mgdf() As Double
        Get
            Return Me.m_excedente35mgdf
        End Get
        Set(ByVal value As Double)
            Me.m_excedente35mgdf = value
        End Set
    End Property

    Public Property salariominimoDF() As Double
        Get
            Return Me.m_salariominimoDF
        End Get
        Set(ByVal value As Double)
            Me.m_salariominimoDF = value
        End Set
    End Property

    Public Property salariobasedecotizacion() As Double
        Get
            Return Me.m_salariobasedecotizacion
        End Get
        Set(ByVal value As Double)
            Me.m_salariobasedecotizacion = value
        End Set
    End Property

    Public Property ingresosexentosimpuestossobrenominas() As Double
        Get
            Return Me.m_ingresosexentosimpuestossobrenominas
        End Get
        Set(ByVal value As Double)
            Me.m_ingresosexentosimpuestossobrenominas = value
        End Set
    End Property

    Public Property ingresosexentosIMSSxsalarios() As Double
        Get
            Return Me.m_ingresosexentosIMSSxsalarios
        End Get
        Set(ByVal value As Double)
            Me.m_ingresosexentosIMSSxsalarios = value
        End Set
    End Property

    Public Property totaldeingresos() As Double
        Get
            Return Me.m_totaldeingresos
        End Get
        Set(ByVal value As Double)
            Me.m_totaldeingresos = value
        End Set
    End Property

    Public Property pagosporfuera() As Double
        Get
            Return Me.m_pagosporfuera
        End Get
        Set(ByVal value As Double)
            Me.m_pagosporfuera = value
        End Set
    End Property

    Public Property honorariosmensuales() As Double
        Get
            Return Me.m_honorariosmensuales
        End Get
        Set(ByVal value As Double)
            Me.m_honorariosmensuales = value
        End Set
    End Property

    Public Property asimiladosmensuales() As Double
        Get
            Return Me.m_asimiladosmensuales
        End Get
        Set(ByVal value As Double)
            Me.m_asimiladosmensuales = value
        End Set
    End Property

    Public Property sueldomensualdeseado() As Double
        Get
            Return Me.m_sueldomensualdeseado
        End Get
        Set(ByVal value As Double)
            Me.m_sueldomensualdeseado = value
        End Set
    End Property

    Public Property ingresonetosueldos() As Double
        Get
            Return Me.m_ingresonetosueldos
        End Get
        Set(ByVal value As Double)
            Me.m_ingresonetosueldos = value
        End Set
    End Property

    Public Property subsidioalempleo() As Double
        Get
            Return Me.m_subsidioalempleo
        End Get
        Set(ByVal value As Double)
            Me.m_subsidioalempleo = value
        End Set
    End Property

    Public Property retencionISRSueldos() As Double
        Get
            Return Me.m_retencionISRSueldos
        End Get
        Set(ByVal value As Double)
            Me.m_retencionISRSueldos = value
        End Set
    End Property

    Public Property retencionImss() As Double
        Get
            Return Me.m_retencionImss
        End Get
        Set(ByVal value As Double)
            Me.m_retencionImss = value
        End Set
    End Property

    Public Property SMG() As Double
        Get
            Return Me.m_SMG
        End Get
        Set(ByVal value As Double)
            Me.m_SMG = value
        End Set
    End Property



    ''Fin calculo Imss

    ''tablas
    Private m_riedgodetrabajoBASE As String
    Private m_riedgodetrabajoPATRON As Double
    Private m_riedgodetrabajotrabajador As Double
    Private m_riedgodetrabajototal As Double
    Private m_prestacionesespecieunoBASE As String
    Private m_prestacionesespecieunoPATRON As Double
    Private m_prestacionesespecieunotrabajador As Double
    Private m_prestacionesespecieunototal As Double
    Private m_prestacionesespeciedosBASE As String
    Private m_prestacionesespeciedosPATRON As Double
    Private m_prestacionesespeciedostrabajador As Double
    Private m_prestacionesespeciedostotal As Double
    Private m_prestacionesdineroBASE As String
    Private m_prestacionesdineroPATRON As Double
    Private m_prestacionesdinerotrabajador As Double
    Private m_prestacionesdinerototal As Double
    Private m_gastosmedicospensionadosBASE As String
    Private m_gastosmedicospensionadosPATRON As Double
    Private m_gastosmedicospensionadostrabajador As Double
    Private m_gastosmedicospensionadostotal As Double
    Private m_invalidezyvidaBASE As String
    Private m_invalidezyvidaPATRON As Double
    Private m_invalidezyvidatrabajador As Double
    Private m_invalidezyvidatotal As Double
    Private m_guarderiasyprestacionessocialesBASE As String
    Private m_guarderiasyprestacionessocialesPATRON As Double
    Private m_guarderiasyprestacionessocialestrabajador As Double
    Private m_guarderiasyprestacionessocialestotal As Double
    Private m_retiroBASE As String
    Private m_retiroPATRON As Double
    Private m_retirotrabajador As Double
    Private m_retirototal As Double
    Private m_cesantiayvejezBASE As String
    Private m_cesantiayvejezPATRON As Double
    Private m_cesantiayvejeztrabajador As Double
    Private m_cesantiayvejeztotal As Double
    Private m_sumasBASE As String
    Private m_sumasPATRON As Double
    Private m_sumastrabajador As Double
    Private m_sumastotal As Double

    Public Property sumastotal() As Double
        Get
            Return Me.m_sumastotal
        End Get
        Set(ByVal value As Double)
            Me.m_sumastotal = value
        End Set
    End Property

    Public Property sumastrabajador() As Double
        Get
            Return Me.m_sumastrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_sumastrabajador = value
        End Set
    End Property

    Public Property sumasPATRON() As Double
        Get
            Return Me.m_sumasPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_sumasPATRON = value
        End Set
    End Property

    Public Property sumasBASE() As String
        Get
            Return Me.m_sumasBASE
        End Get
        Set(ByVal value As String)
            Me.m_sumasBASE = value
        End Set
    End Property
    ''
    Public Property cesantiayvejeztotal() As Double
        Get
            Return Me.m_cesantiayvejeztotal
        End Get
        Set(ByVal value As Double)
            Me.m_cesantiayvejeztotal = value
        End Set
    End Property

    Public Property cesantiayvejeztrabajador() As Double
        Get
            Return Me.m_cesantiayvejeztrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_cesantiayvejeztrabajador = value
        End Set
    End Property

    Public Property cesantiayvejezPATRON() As Double
        Get
            Return Me.m_cesantiayvejezPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_cesantiayvejezPATRON = value
        End Set
    End Property

    Public Property cesantiayvejezBASE() As String
        Get
            Return Me.m_cesantiayvejezBASE
        End Get
        Set(ByVal value As String)
            Me.m_cesantiayvejezBASE = value
        End Set
    End Property
    ''
    Public Property retirototal() As Double
        Get
            Return Me.m_retirototal
        End Get
        Set(ByVal value As Double)
            Me.m_retirototal = value
        End Set
    End Property

    Public Property retirotrabajador() As Double
        Get
            Return Me.m_retirotrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_retirotrabajador = value
        End Set
    End Property

    Public Property retiroPATRON() As Double
        Get
            Return Me.m_retiroPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_retiroPATRON = value
        End Set
    End Property

    Public Property retiroBASE() As String
        Get
            Return Me.m_retiroBASE
        End Get
        Set(ByVal value As String)
            Me.m_retiroBASE = value
        End Set
    End Property
    ''
    Public Property guarderiasyprestacionessocialestotal() As Double
        Get
            Return Me.m_guarderiasyprestacionessocialestotal
        End Get
        Set(ByVal value As Double)
            Me.m_guarderiasyprestacionessocialestotal = value
        End Set
    End Property

    Public Property guarderiasyprestacionessocialestrabajador() As Double
        Get
            Return Me.m_guarderiasyprestacionessocialestrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_guarderiasyprestacionessocialestrabajador = value
        End Set
    End Property

    Public Property guarderiasyprestacionessocialesPATRON() As Double
        Get
            Return Me.m_guarderiasyprestacionessocialesPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_guarderiasyprestacionessocialesPATRON = value
        End Set
    End Property

    Public Property guarderiasyprestacionessocialesBASE() As String
        Get
            Return Me.m_guarderiasyprestacionessocialesBASE
        End Get
        Set(ByVal value As String)
            Me.m_guarderiasyprestacionessocialesBASE = value
        End Set
    End Property
    ''
    Public Property invalidezyvidatotal() As Double
        Get
            Return Me.m_invalidezyvidatotal
        End Get
        Set(ByVal value As Double)
            Me.m_invalidezyvidatotal = value
        End Set
    End Property

    Public Property invalidezyvidatrabajador() As Double
        Get
            Return Me.m_invalidezyvidatrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_invalidezyvidatrabajador = value
        End Set
    End Property

    Public Property invalidezyvidaPATRON() As Double
        Get
            Return Me.m_invalidezyvidaPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_invalidezyvidaPATRON = value
        End Set
    End Property

    Public Property invalidezyvidaBASE() As String
        Get
            Return Me.m_invalidezyvidaBASE
        End Get
        Set(ByVal value As String)
            Me.m_invalidezyvidaBASE = value
        End Set
    End Property
    ''

    Public Property gastosmedicospensionadostotal() As Double
        Get
            Return Me.m_gastosmedicospensionadostotal
        End Get
        Set(ByVal value As Double)
            Me.m_gastosmedicospensionadostotal = value
        End Set
    End Property

    Public Property gastosmedicospensionadostrabajador() As Double
        Get
            Return Me.m_gastosmedicospensionadostrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_gastosmedicospensionadostrabajador = value
        End Set
    End Property

    Public Property gastosmedicospensionadosPATRON() As Double
        Get
            Return Me.m_gastosmedicospensionadosPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_gastosmedicospensionadosPATRON = value
        End Set
    End Property

    Public Property gastosmedicospensionadosBASE() As String
        Get
            Return Me.m_gastosmedicospensionadosBASE
        End Get
        Set(ByVal value As String)
            Me.m_gastosmedicospensionadosBASE = value
        End Set
    End Property
    ''
    Public Property prestacionesdinerototal() As Double
        Get
            Return Me.m_prestacionesdinerototal
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesdinerototal = value
        End Set
    End Property

    Public Property prestacionesdinerotrabajador() As Double
        Get
            Return Me.m_prestacionesdinerotrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesdinerotrabajador = value
        End Set
    End Property

    Public Property prestacionesdineroPATRON() As Double
        Get
            Return Me.m_prestacionesdineroPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesdineroPATRON = value
        End Set
    End Property

    Public Property prestacionesdineroBASE() As String
        Get
            Return Me.m_prestacionesdineroBASE
        End Get
        Set(ByVal value As String)
            Me.m_prestacionesdineroBASE = value
        End Set
    End Property
    ''
    Public Property prestacionesespeciedostotal() As Double
        Get
            Return Me.m_prestacionesespeciedostotal
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesespeciedostotal = value
        End Set
    End Property

    Public Property prestacionesespeciedostrabajador() As Double
        Get
            Return Me.m_prestacionesespeciedostrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesespeciedostrabajador = value
        End Set
    End Property

    Public Property prestacionesespeciedosPATRON() As Double
        Get
            Return Me.m_prestacionesespeciedosPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesespeciedosPATRON = value
        End Set
    End Property

    Public Property prestacionesespeciedosBASE() As String
        Get
            Return Me.m_prestacionesespeciedosBASE
        End Get
        Set(ByVal value As String)
            Me.m_prestacionesespeciedosBASE = value
        End Set
    End Property
    ''
    Public Property prestacionesespecieunototal() As Double
        Get
            Return Me.m_prestacionesespecieunototal
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesespecieunototal = value
        End Set
    End Property

    Public Property prestacionesespecieunotrabajador() As Double
        Get
            Return Me.m_prestacionesespecieunotrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesespecieunotrabajador = value
        End Set
    End Property

    Public Property prestacionesespecieunoPATRON() As Double
        Get
            Return Me.m_prestacionesespecieunoPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_prestacionesespecieunoPATRON = value
        End Set
    End Property

    Public Property prestacionesespecieunoBASE() As String
        Get
            Return Me.m_prestacionesespecieunoBASE
        End Get
        Set(ByVal value As String)
            Me.m_prestacionesespecieunoBASE = value
        End Set
    End Property
    ''

    Public Property riedgodetrabajototal() As Double
        Get
            Return Me.m_riedgodetrabajototal
        End Get
        Set(ByVal value As Double)
            Me.m_riedgodetrabajototal = value
        End Set
    End Property

    Public Property riedgodetrabajotrabajador() As Double
        Get
            Return Me.m_riedgodetrabajotrabajador
        End Get
        Set(ByVal value As Double)
            Me.m_riedgodetrabajotrabajador = value
        End Set
    End Property

    Public Property riedgodetrabajoPATRON() As Double
        Get
            Return Me.m_riedgodetrabajoPATRON
        End Get
        Set(ByVal value As Double)
            Me.m_riedgodetrabajoPATRON = value
        End Set
    End Property

    Public Property riedgodetrabajoBASE() As String
        Get
            Return Me.m_riedgodetrabajoBASE
        End Get
        Set(ByVal value As String)
            Me.m_riedgodetrabajoBASE = value
        End Set
    End Property


    ''Fin tablas



End Class
