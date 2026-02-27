<?xml version="1.0" encoding="ISO-8859-1"?>
<definitions xmlns:SOAP-ENV="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:SOAP-ENC="http://schemas.xmlsoap.org/soap/encoding/" xmlns:tns="http://www.clickbalance.net/soap/ComprobantesFiscales" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns="http://schemas.xmlsoap.org/wsdl/" targetNamespace="http://www.clickbalance.net/soap/ComprobantesFiscales">
<types>
<xsd:schema targetNamespace="http://www.clickbalance.net/soap/ComprobantesFiscales"
>
 <xsd:import namespace="http://schemas.xmlsoap.org/soap/encoding/" />
 <xsd:import namespace="http://schemas.xmlsoap.org/wsdl/" />
 <xsd:complexType name="respuesta">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="contenido_archivo" type="xsd:string"/>
   <xsd:element name="nombre_archivo" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:string"/>
   <xsd:element name="uuid" type="xsd:string"/>
   <xsd:element name="id" type="xsd:string"/>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="mensaje" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="respuestalistaprecio">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="mensaje" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="respuestaalmancenproducto">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="mensaje" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosreceptor">
  <xsd:all>
   <xsd:element name="idcliente" type="xsd:integer"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="numero_referencia_asociado" type="xsd:string"/>
   <xsd:element name="numero_cliente" type="xsd:integer"/>
   <xsd:element name="email" type="xsd:string"/>
   <xsd:element name="iddireccion" type="xsd:string"/>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="nexterior" type="xsd:string"/>
   <xsd:element name="ninterior" type="xsd:string"/>
   <xsd:element name="colonia" type="xsd:string"/>
   <xsd:element name="localidad" type="xsd:string"/>
   <xsd:element name="municipio" type="xsd:string"/>
   <xsd:element name="estado" type="xsd:string"/>
   <xsd:element name="pais" type="xsd:string"/>
   <xsd:element name="codigopostal" type="xsd:string"/>
   <xsd:element name="sat_regimen_fiscal_cliente" type="xsd:string"/>
   <xsd:element name="iddireccionentrega" type="xsd:string"/>
   <xsd:element name="direccion_entrega" type="tns:direccion_entrega"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="direccion_entrega">
  <xsd:all>
   <xsd:element name="telefono" type="xsd:string"/>
   <xsd:element name="ciudad" type="xsd:string"/>
   <xsd:element name="colonia" type="xsd:string"/>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="registro_fiscal" type="xsd:string"/>
   <xsd:element name="nombre_sucursal" type="xsd:string"/>
   <xsd:element name="numero_exterior" type="xsd:string"/>
   <xsd:element name="numero_interior" type="xsd:string"/>
   <xsd:element name="codigo_postal" type="xsd:string"/>
   <xsd:element name="municipio" type="xsd:string"/>
   <xsd:element name="localidad" type="xsd:string"/>
   <xsd:element name="estado" type="xsd:string"/>
   <xsd:element name="pais" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="InformacionAduana">
  <xsd:all>
   <xsd:element name="numero" type="xsd:string"/>
   <xsd:element name="fecha" type="xsd:date"/>
   <xsd:element name="aduana" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="InformacionAduanera">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:InformacionAduana[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="InstitucionEducativa">
  <xsd:all>
   <xsd:element name="aut_rvoe" type="xsd:string"/>
   <xsd:element name="curp" type="xsd:string"/>
   <xsd:element name="nivel_educativo" type="xsd:string"/>
   <xsd:element name="nombre_alumno" type="xsd:string"/>
   <xsd:element name="rfc_pago" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="InformacionFiscalTercero">
  <xsd:all>
   <xsd:element name="asociado_id" type="xsd:integer"/>
   <xsd:element name="direccion_asociado_id" type="xsd:integer"/>
   <xsd:element name="sat_regimen_fiscal_cliente_tercero" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="Parte">
  <xsd:all>
   <xsd:element name="producto_id" type="xsd:integer"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="cantidad" type="xsd:integer"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="unidad_id" type="xsd:integer"/>
   <xsd:element name="precio" type="xsd:float"/>
   <xsd:element name="importe" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="Retencion">
  <xsd:all>
   <xsd:element name="impuesto_id" type="xsd:integer"/>
   <xsd:element name="importe" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="Traslado">
  <xsd:all>
   <xsd:element name="impuesto_id" type="xsd:integer"/>
   <xsd:element name="tasa_id" type="xsd:integer"/>
   <xsd:element name="importe" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="Partes">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:Parte[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="Retenciones">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:Retencion[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="Traslados">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:Traslado[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="Impuestos">
  <xsd:all>
   <xsd:element name="Retenciones" type="tns:Retenciones"/>
   <xsd:element name="Traslados" type="tns:Traslados"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="InstitucionesEducativas">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:InstitucionEducativa[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="VentaLeyendaFiscal">
  <xsd:all>
   <xsd:element name="disposicion_fiscal" type="xsd:string"/>
   <xsd:element name="norma" type="xsd:string"/>
   <xsd:element name="leyenda" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="VentaLeyendasFiscales">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:VentaLeyendaFiscal[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="ComplementoConcepto">
  <xsd:all>
   <xsd:element name="CuentaTerceros" type="tns:CuentaTerceros"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="CuentaTerceros">
  <xsd:all>
   <xsd:element name="tipo_informacion_fiscal" type="xsd:integer"/>
   <xsd:element name="InformacionFiscalTercero" type="tns:InformacionFiscalTercero"/>
   <xsd:element name="cuenta_predial" type="xsd:string"/>
   <xsd:element name="Partes" type="tns:Partes"/>
   <xsd:element name="InformacionAduanera" type="tns:InformacionAduanera"/>
   <xsd:element name="Impuestos" type="tns:Impuestos"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleconcepto">
  <xsd:all>
   <xsd:element name="idproducto" type="xsd:integer"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="cantidad" type="xsd:decimal"/>
   <xsd:element name="unidad" type="xsd:string"/>
   <xsd:element name="almacen" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="valorunitario" type="xsd:decimal"/>
   <xsd:element name="tasadescuento" type="xsd:decimal"/>
   <xsd:element name="descuento" type="xsd:decimal"/>
   <xsd:element name="tasaieps" type="xsd:decimal"/>
   <xsd:element name="ieps" type="xsd:decimal"/>
   <xsd:element name="tasaiva" type="xsd:decimal"/>
   <xsd:element name="iva" type="xsd:decimal"/>
   <xsd:element name="tasa_retencion_iva" type="xsd:decimal"/>
   <xsd:element name="importe_retencion_iva" type="xsd:decimal"/>
   <xsd:element name="tasa_retencion_isr" type="xsd:decimal"/>
   <xsd:element name="importe_retencion_isr" type="xsd:decimal"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="series" type="xsd:string"/>
   <xsd:element name="InstitucionesEducativas" type="tns:InstitucionesEducativas"/>
   <xsd:element name="InformacionAduanera" type="tns:InformacionAduanera"/>
   <xsd:element name="id_unidad_medida_sat" type="xsd:integer"/>
   <xsd:element name="clave_unidad_medida_sat" type="xsd:string"/>
   <xsd:element name="id_producto_servicio_sat" type="xsd:integer"/>
   <xsd:element name="clave_producto_servicio_sat" type="xsd:string"/>
   <xsd:element name="ComplementoConcepto" type="tns:ComplementoConcepto"/>
   <xsd:element name="unidad_id" type="xsd:integer"/>
   <xsd:element name="codigo_cliente" type="xsd:string"/>
   <xsd:element name="centro_costo_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleconceptopos">
  <xsd:all>
   <xsd:element name="idproducto" type="xsd:integer"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="cantidad" type="xsd:decimal"/>
   <xsd:element name="unidad" type="xsd:string"/>
   <xsd:element name="unidad_id" type="xsd:string"/>
   <xsd:element name="unidad_medida_id" type="xsd:integer"/>
   <xsd:element name="unidad_medida_producto_id" type="xsd:integer"/>
   <xsd:element name="unidad_venta_id" type="xsd:integer"/>
   <xsd:element name="factor_conversion" type="xsd:decimal"/>
   <xsd:element name="almacen" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="valorunitario" type="xsd:decimal"/>
   <xsd:element name="tasadescuento" type="xsd:decimal"/>
   <xsd:element name="descuento" type="xsd:decimal"/>
   <xsd:element name="tasaieps" type="xsd:decimal"/>
   <xsd:element name="ieps" type="xsd:decimal"/>
   <xsd:element name="tasaiva" type="xsd:decimal"/>
   <xsd:element name="iva" type="xsd:decimal"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="series" type="xsd:string"/>
   <xsd:element name="InstitucionesEducativas" type="tns:InstitucionesEducativas"/>
   <xsd:element name="InformacionAduanera" type="tns:InformacionAduanera"/>
   <xsd:element name="caracteristicas" type="xsd:string"/>
   <xsd:element name="centro_costo_id" type="xsd:integer"/>
   <xsd:element name="pos_detalle_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleconceptos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalleconcepto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detalleconceptospos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalleconceptopos[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="impuestolocal">
  <xsd:all>
   <xsd:element name="tipo" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="tasa" type="xsd:decimal"/>
   <xsd:element name="importe" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleimpuestoslocales">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:impuestolocal[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="cartaporte">
  <xsd:all>
   <xsd:element name="folio_guia" type="xsd:integer"/>
   <xsd:element name="cliente_origen" type="xsd:string"/>
   <xsd:element name="nombre_cliente_origen" type="xsd:string"/>
   <xsd:element name="direccion_cliente_origen" type="xsd:string"/>
   <xsd:element name="razon_cliente_origen" type="xsd:string"/>
   <xsd:element name="cliente_destino" type="xsd:string"/>
   <xsd:element name="nombre_cliente_destino" type="xsd:string"/>
   <xsd:element name="direccion_cliente_destino" type="xsd:string"/>
   <xsd:element name="razon_cliente_destino" type="xsd:string"/>
   <xsd:element name="forma_pago" type="xsd:string"/>
   <xsd:element name="flete" type="xsd:decimal"/>
   <xsd:element name="recoleccion" type="xsd:decimal"/>
   <xsd:element name="entrega_domicilio" type="xsd:decimal"/>
   <xsd:element name="seguro" type="xsd:decimal"/>
   <xsd:element name="observacion_seguro" type="xsd:string"/>
   <xsd:element name="carga" type="xsd:decimal"/>
   <xsd:element name="descarga" type="xsd:decimal"/>
   <xsd:element name="subtotal" type="xsd:decimal"/>
   <xsd:element name="iva" type="xsd:decimal"/>
   <xsd:element name="iva_retenido" type="xsd:decimal"/>
   <xsd:element name="total" type="xsd:decimal"/>
   <xsd:element name="valor_declarado" type="xsd:decimal"/>
   <xsd:element name="tipo_embarque" type="xsd:string"/>
   <xsd:element name="cargador" type="xsd:string"/>
   <xsd:element name="documentador" type="xsd:string"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="hora" type="xsd:string"/>
   <xsd:element name="observaciones" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="ventaformadepago">
  <xsd:all>
   <xsd:element name="forma_pago_id" type="xsd:integer"/>
   <xsd:element name="nombre_forma_pago" type="xsd:string"/>
   <xsd:element name="importe" type="xsd:decimal"/>
   <xsd:element name="cuenta_bancaria_id" type="xsd:integer"/>
   <xsd:element name="cuenta_bancaria" type="xsd:string"/>
   <xsd:element name="concepto_movimiento_bancario" type="xsd:string"/>
   <xsd:element name="cuenta_id" type="xsd:integer"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="beneficiario" type="xsd:string"/>
   <xsd:element name="rfc_beneficiario" type="xsd:string"/>
   <xsd:element name="banco_sat_id" type="xsd:integer"/>
   <xsd:element name="banco_sat_extranjero_id" type="xsd:integer"/>
   <xsd:element name="numero_cuenta" type="xsd:string"/>
   <xsd:element name="numero_cheque" type="xsd:integer"/>
   <xsd:element name="banco_sat_destino_id" type="xsd:integer"/>
   <xsd:element name="banco_sat_extranjero_destino_id" type="xsd:integer"/>
   <xsd:element name="numero_cuenta_destino" type="xsd:string"/>
   <xsd:element name="estatus_movimiento_bancario" type="xsd:integer"/>
   <xsd:element name="id_cve_sat" type="xsd:integer"/>
   <xsd:element name="cve_sat" type="xsd:string"/>
   <xsd:element name="moneda_id" type="xsd:integer"/>
   <xsd:element name="tipo_cambio" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="claveproductoservicio">
  <xsd:all>
   <xsd:element name="clave_producto_servicios_id" type="xsd:integer"/>
   <xsd:element name="clave_producto_servicios" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="complemento_a_incluir" type="xsd:integer"/>
   <xsd:element name="fecha_fin_vigencia" type="xsd:string"/>
   <xsd:element name="fecha_inicio_vigencia" type="xsd:string"/>
   <xsd:element name="incluir_ieps_trasladado" type="xsd:integer"/>
   <xsd:element name="incluir_iva_traslado" type="xsd:integer"/>
   <xsd:element name="updated_at" type="xsd:string"/>
   <xsd:element name="created_at" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="unidadmedidasat">
  <xsd:all>
   <xsd:element name="unidad_medida_sat_id" type="xsd:integer"/>
   <xsd:element name="clave_unidad" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="fecha_fin_vigencia" type="xsd:string"/>
   <xsd:element name="fecha_inicio_vigencia" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="simbolo" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="metodopagosat">
  <xsd:all>
   <xsd:element name="metodo_pago_sat_id" type="xsd:integer"/>
   <xsd:element name="cve_sat" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="documentotiporelacion">
  <xsd:all>
   <xsd:element name="tipo_relacion_id" type="xsd:integer"/>
   <xsd:element name="clave_tipo_relacion" type="xsd:string"/>
   <xsd:element name="uuid" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="tiporelacion">
  <xsd:all>
   <xsd:element name="tipo_relacion_id" type="xsd:integer"/>
   <xsd:element name="clave_tipo_relacion" type="xsd:string"/>
   <xsd:element name="descripcion_tipo_relacion" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="usocfdi">
  <xsd:all>
   <xsd:element name="uso_cfdi_id" type="xsd:integer"/>
   <xsd:element name="clave_uso_cfdi" type="xsd:string"/>
   <xsd:element name="descripcion_uso_cfdi" type="xsd:string"/>
   <xsd:element name="tipo_persona" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="impuestodetalle">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="tasa" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="conceptos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:concepto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="formas_pago">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:forma_pago[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="forma_pago">
  <xsd:all>
   <xsd:element name="venta_forma_pago_id" type="xsd:integer"/>
   <xsd:element name="forma_pago_id" type="xsd:integer"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="numero_cuenta" type="xsd:string"/>
   <xsd:element name="importe_forma_pago" type="xsd:float"/>
   <xsd:element name="nombre_forma_pago" type="xsd:string"/>
   <xsd:element name="abreviatura_forma_pago" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="concepto">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="almacen_id" type="xsd:integer"/>
   <xsd:element name="producto_id" type="xsd:integer"/>
   <xsd:element name="unidad_id" type="xsd:integer"/>
   <xsd:element name="series" type="xsd:string"/>
   <xsd:element name="cantidad" type="xsd:integer"/>
   <xsd:element name="cantidad_equivalente" type="xsd:integer"/>
   <xsd:element name="precio_lista" type="xsd:float"/>
   <xsd:element name="precio_neto" type="xsd:float"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="tasa_ieps" type="xsd:float"/>
   <xsd:element name="tasa_iva" type="xsd:float"/>
   <xsd:element name="tasa_descuento" type="xsd:float"/>
   <xsd:element name="importe_ieps" type="xsd:float"/>
   <xsd:element name="importe_iva" type="xsd:float"/>
   <xsd:element name="importe_descuento" type="xsd:float"/>
   <xsd:element name="importe" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="documento">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="folio" type="xsd:integer"/>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="uuid" type="xsd:string"/>
   <xsd:element name="plaza" type="xsd:integer"/>
   <xsd:element name="cadena_original" type="xsd:string"/>
   <xsd:element name="certificado" type="xsd:string"/>
   <xsd:element name="sello_digital" type="xsd:string"/>
   <xsd:element name="codigo_transaccion" type="xsd:string"/>
   <xsd:element name="estatus" type="xsd:integer"/>
   <xsd:element name="estatus_nombre" type="xsd:string"/>
   <xsd:element name="tipo_venta_id" type="xsd:integer"/>
   <xsd:element name="tipo_venta_descripcion" type="xsd:string"/>
   <xsd:element name="moneda_id" type="xsd:integer"/>
   <xsd:element name="moneda_nombre" type="xsd:string"/>
   <xsd:element name="tipo_cambio" type="xsd:float"/>
   <xsd:element name="tipo_pago_id" type="xsd:integer"/>
   <xsd:element name="tipo_pago_nombre" type="xsd:string"/>
   <xsd:element name="total" type="xsd:float"/>
   <xsd:element name="subtotal" type="xsd:float"/>
   <xsd:element name="subtotal_sin_descuento" type="xsd:float"/>
   <xsd:element name="importe_descuento" type="xsd:float"/>
   <xsd:element name="importe_iva" type="xsd:float"/>
   <xsd:element name="importe_ieps" type="xsd:float"/>
   <xsd:element name="importe_retencion_iva" type="xsd:float"/>
   <xsd:element name="importe_retencion_isr" type="xsd:float"/>
   <xsd:element name="saldo" type="xsd:float"/>
   <xsd:element name="agente_asociado_id" type="xsd:integer"/>
   <xsd:element name="cliente_id" type="xsd:integer"/>
   <xsd:element name="nombre_cliente" type="xsd:string"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="direccion_cliente_id" type="xsd:integer"/>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="numero_exterior" type="xsd:string"/>
   <xsd:element name="numero_interior" type="xsd:string"/>
   <xsd:element name="localidad" type="xsd:string"/>
   <xsd:element name="ciudad" type="xsd:string"/>
   <xsd:element name="municipio" type="xsd:string"/>
   <xsd:element name="estado_id" type="xsd:integer"/>
   <xsd:element name="estado" type="xsd:string"/>
   <xsd:element name="pais_id" type="xsd:integer"/>
   <xsd:element name="pais" type="xsd:string"/>
   <xsd:element name="codigo_postal" type="xsd:string"/>
   <xsd:element name="direccion_entrega_cliente_id" type="xsd:integer"/>
   <xsd:element name="fecha" type="xsd:date"/>
   <xsd:element name="fecha_entrega" type="xsd:date"/>
   <xsd:element name="conceptos" type="tns:conceptos"/>
   <xsd:element name="formas_pago" type="tns:formas_pago"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
   <xsd:element name="texto_adicional_6" type="xsd:string"/>
   <xsd:element name="texto_adicional_7" type="xsd:string"/>
   <xsd:element name="texto_adicional_8" type="xsd:string"/>
   <xsd:element name="texto_adicional_9" type="xsd:string"/>
   <xsd:element name="texto_adicional_10" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datos_factura">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos_factura" type="tns:documento"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoproduccion">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos_documento_produccion" type="tns:dato_documento_produccion"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadocentrocosto">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="centrocosto" type="tns:dato_centro_costo"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datos_documento_produccion">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="folio" type="xsd:integer"/>
   <xsd:element name="tipo_documento_produccion_id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="estatus" type="xsd:integer"/>
   <xsd:element name="fecha_creacion" type="xsd:date"/>
   <xsd:element name="fecha_inicio" type="xsd:date"/>
   <xsd:element name="fecha_fin" type="xsd:date"/>
   <xsd:element name="created_at" type="xsd:date"/>
   <xsd:element name="updated_at" type="xsd:date"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="centrocosto">
  <xsd:all>
   <xsd:element name="centro_costo_id" type="xsd:integer"/>
   <xsd:element name="centro_costo_clave" type="xsd:integer"/>
   <xsd:element name="centro_costo_nombre" type="xsd:string"/>
   <xsd:element name="maneja_cuentas_contables" type="xsd:string"/>
   <xsd:element name="cuenta_contable_id" type="xsd:integer"/>
   <xsd:element name="cuenta_contable" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalletiporelacion">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:documentotiporelacion[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listatiporelacion">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:tiporelacion[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listausocfdi">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:usocfdi[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listaimpuestodetalle">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:impuestodetalle[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listametodopagosat">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:metodopagosat[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listaclaveproductoservicio">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:claveproductoservicio[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listaunidadmedidasat">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:unidadmedidasat[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="catalogotiporelacion">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listatiporelacion"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="catalogousocfdi">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listausocfdi"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="catalogoimpuestodetalle">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listaimpuestodetalle"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="catalogounidadmedidasat">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listaunidadmedidasat"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="catalogometodopagosat">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listametodopagosat"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="catalogoclaveproductoservicio">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listaclaveproductoservicio"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleformasdepago">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:ventaformadepago[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="formadepago">
  <xsd:all>
   <xsd:element name="forma_pago_id" type="xsd:integer"/>
   <xsd:element name="nombre_forma_pago" type="xsd:string"/>
   <xsd:element name="requiere_referencia" type="xsd:integer"/>
   <xsd:element name="longitud_minima" type="xsd:integer"/>
   <xsd:element name="tipo" type="xsd:integer"/>
   <xsd:element name="detalle" type="tns:listadoformapagodetalle"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoformapagodetalle">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:formapagodetalle[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="formapagodetalle">
  <xsd:all>
   <xsd:element name="id_detalle" type="xsd:integer"/>
   <xsd:element name="cuenta_bancaria_id" type="xsd:integer"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="cuenta_id" type="xsd:integer"/>
   <xsd:element name="forma_pago_id" type="xsd:integer"/>
   <xsd:element name="plaza_id" type="xsd:integer"/>
   <xsd:element name="predeterminado" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="formasdepago">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:formadepago[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoformasdepago">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:formasdepago"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="factura">
  <xsd:all>
   <xsd:element name="tipodocumento" type="xsd:string"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="fecha_entrega" type="xsd:string"/>
   <xsd:element name="receptor" type="tns:datosreceptor"/>
   <xsd:element name="iddireccionentrega" type="xsd:string"/>
   <xsd:element name="razon_social_comp_id" type="xsd:integer"/>
   <xsd:element name="idagente" type="xsd:integer"/>
   <xsd:element name="tipopago" type="xsd:integer"/>
   <xsd:element name="metodoDePago" type="xsd:string"/>
   <xsd:element name="RefDePago" type="xsd:string"/>
   <xsd:element name="conceptos" type="tns:detalleconceptos"/>
   <xsd:element name="subtotal" type="xsd:decimal"/>
   <xsd:element name="descuento" type="xsd:decimal"/>
   <xsd:element name="ieps" type="xsd:decimal"/>
   <xsd:element name="iva" type="xsd:decimal"/>
   <xsd:element name="isrretenido" type="xsd:decimal"/>
   <xsd:element name="ivaretenido" type="xsd:decimal"/>
   <xsd:element name="implocales" type="tns:detalleimpuestoslocales"/>
   <xsd:element name="total" type="xsd:decimal"/>
   <xsd:element name="idaddenda" type="xsd:integer"/>
   <xsd:element name="addenda" type="xsd:string"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="moneda_id" type="xsd:integer"/>
   <xsd:element name="tipo_cambio" type="xsd:decimal"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
   <xsd:element name="texto_adicional_6" type="xsd:string"/>
   <xsd:element name="texto_adicional_7" type="xsd:string"/>
   <xsd:element name="texto_adicional_8" type="xsd:string"/>
   <xsd:element name="texto_adicional_9" type="xsd:string"/>
   <xsd:element name="texto_adicional_10" type="xsd:string"/>
   <xsd:element name="ventaFormasDePago" type="tns:detalleformasdepago"/>
   <xsd:element name="documentos_relacionados" type="tns:detalletiporelacion"/>
   <xsd:element name="VentaLeyendasFiscales" type="tns:VentaLeyendasFiscales"/>
   <xsd:element name="codigo_transaccion" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:integer"/>
   <xsd:element name="desglose_ieps" type="xsd:integer"/>
   <xsd:element name="sat_uso_cfdi_id" type="xsd:integer"/>
   <xsd:element name="clave_uso_cfdi" type="xsd:string"/>
   <xsd:element name="asignar_folio_siguiente_si_esta_ocupado" type="xsd:integer"/>
   <xsd:element name="comercio_exterior" type="tns:comercio_exterior"/>
   <xsd:element name="nodo_addenda" type="xsd:string"/>
   <xsd:element name="documento_produccion_id" type="xsd:integer"/>
   <xsd:element name="regimen_clave_sat" type="xsd:integer"/>
   <xsd:element name="xml" type="xsd:string"/>
   <xsd:element name="uuid" type="xsd:string"/>
   <xsd:element name="fecha_timbrado" type="xsd:string"/>
   <xsd:element name="sello_sat" type="xsd:string"/>
   <xsd:element name="certificado_sat" type="xsd:string"/>
   <xsd:element name="certificado" type="xsd:string"/>
   <xsd:element name="version_timbre" type="xsd:string"/>
   <xsd:element name="sello_digital" type="xsd:string"/>
   <xsd:element name="cadena_original" type="xsd:string"/>
   <xsd:element name="sat_exportacion" type="xsd:string"/>
   <xsd:element name="carta_porte" type="tns:carta_porte"/>
   <xsd:element name="estatus" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="facturaPos">
  <xsd:all>
   <xsd:element name="tipodocumento" type="xsd:string"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="receptor" type="tns:datosreceptor"/>
   <xsd:element name="iddireccionentrega" type="xsd:string"/>
   <xsd:element name="razon_social_comp_id" type="xsd:integer"/>
   <xsd:element name="idagente" type="xsd:integer"/>
   <xsd:element name="tipopago" type="xsd:integer"/>
   <xsd:element name="metodoDePago" type="xsd:string"/>
   <xsd:element name="RefDePago" type="xsd:string"/>
   <xsd:element name="conceptos" type="tns:detalleconceptospos"/>
   <xsd:element name="subtotal" type="xsd:decimal"/>
   <xsd:element name="descuento" type="xsd:decimal"/>
   <xsd:element name="ieps" type="xsd:decimal"/>
   <xsd:element name="iva" type="xsd:decimal"/>
   <xsd:element name="isrretenido" type="xsd:decimal"/>
   <xsd:element name="ivaretenido" type="xsd:decimal"/>
   <xsd:element name="implocales" type="tns:detalleimpuestoslocales"/>
   <xsd:element name="total" type="xsd:decimal"/>
   <xsd:element name="idaddenda" type="xsd:integer"/>
   <xsd:element name="addenda" type="xsd:string"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="moneda_id" type="xsd:integer"/>
   <xsd:element name="tipo_cambio" type="xsd:decimal"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
   <xsd:element name="texto_adicional_6" type="xsd:string"/>
   <xsd:element name="texto_adicional_7" type="xsd:string"/>
   <xsd:element name="texto_adicional_8" type="xsd:string"/>
   <xsd:element name="texto_adicional_9" type="xsd:string"/>
   <xsd:element name="texto_adicional_10" type="xsd:string"/>
   <xsd:element name="ventaFormasDePago" type="tns:detalleformasdepago"/>
   <xsd:element name="VentaLeyendasFiscales" type="tns:VentaLeyendasFiscales"/>
   <xsd:element name="codigo_transaccion" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="motivo_cancelacion" type="xsd:string"/>
   <xsd:element name="fecha_cancelacion" type="xsd:string"/>
   <xsd:element name="usuario_cancelacion_id" type="xsd:string"/>
   <xsd:element name="desglose_ieps" type="xsd:integer"/>
   <xsd:element name="sat_uso_cfdi_id" type="xsd:integer"/>
   <xsd:element name="asignar_folio_siguiente_si_esta_ocupado" type="xsd:integer"/>
   <xsd:element name="sat_exportacion" type="xsd:string"/>
   <xsd:element name="pos_id" type="xsd:string"/>
   <xsd:element name="pos_version" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoVentasPos">
  <xsd:all>
   <xsd:element name="datos" type="tns:ventasPos"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="ventasPos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:ventaPos[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="ventaPos">
  <xsd:all>
   <xsd:element name="pos_id" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoEstatusVentasPos">
  <xsd:all>
   <xsd:element name="datos" type="tns:estatusVentasPos"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="estatusVentasPos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:estatusVentaPos[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="estatusVentaPos">
  <xsd:all>
   <xsd:element name="pos_id" type="xsd:string"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="resultado" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="asociado">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="numero" type="xsd:integer"/>
   <xsd:element name="regimen" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="apellido_paterno" type="xsd:string"/>
   <xsd:element name="apellido_materno" type="xsd:string"/>
   <xsd:element name="razon_social" type="xsd:string"/>
   <xsd:element name="curp" type="xsd:string"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="nombre_comercial" type="xsd:string"/>
   <xsd:element name="representante_legal" type="xsd:string"/>
   <xsd:element name="agente_cliente" type="xsd:integer"/>
   <xsd:element name="dias_pago_cliente" type="xsd:string"/>
   <xsd:element name="dias_revision_cliente" type="xsd:integer"/>
   <xsd:element name="precio_aplica_cliente" type="xsd:decimal"/>
   <xsd:element name="descuento_cliente" type="xsd:decimal"/>
   <xsd:element name="cuenta_contable_cliente" type="xsd:string"/>
   <xsd:element name="plazo_cliente" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="limite_credito_cliente" type="xsd:decimal"/>
   <xsd:element name="es_cliente" type="xsd:integer"/>
   <xsd:element name="es_proveedor" type="xsd:integer"/>
   <xsd:element name="fecha_actual" type="xsd:string"/>
   <xsd:element name="clasificacion_cliente" type="xsd:string"/>
   <xsd:element name="codigo_barra_empleado" type="xsd:string"/>
   <xsd:element name="bloquear_venta_credito" type="xsd:string"/>
   <xsd:element name="observaciones_estatus" type="xsd:string"/>
   <xsd:element name="sat_uso_cfdi_id" type="xsd:integer"/>
   <xsd:element name="cliente_regimen_fiscal" type="xsd:string"/>
   <xsd:element name="cliente_regimen_fiscal_ids" type="xsd:string"/>
   <xsd:element name="cuenta_contable_gasto_proveedor_id" type="xsd:integer"/>
   <xsd:element name="sat_uso_cfdi_proveedor_id" type="xsd:integer"/>
   <xsd:element name="datos_codigo_qr" type="xsd:string"/>
   <xsd:element name="passwordpv_empleado" type="xsd:string"/>
   <xsd:element name="usuariopv_empleado" type="xsd:string"/>
   <xsd:element name="precio_aplica_adicional_cliente" type="xsd:string"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
   <xsd:element name="forma_pago_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosasociado">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="numero" type="xsd:integer"/>
   <xsd:element name="regimen" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="apellido_paterno" type="xsd:string"/>
   <xsd:element name="apellido_materno" type="xsd:string"/>
   <xsd:element name="razon_social" type="xsd:string"/>
   <xsd:element name="curp" type="xsd:string"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="nombre_comercial" type="xsd:string"/>
   <xsd:element name="representante_legal" type="xsd:string"/>
   <xsd:element name="agente_cliente" type="xsd:integer"/>
   <xsd:element name="dias_pago_cliente" type="xsd:string"/>
   <xsd:element name="dias_revision_cliente" type="xsd:integer"/>
   <xsd:element name="precio_aplica_cliente" type="xsd:decimal"/>
   <xsd:element name="descuento_cliente" type="xsd:decimal"/>
   <xsd:element name="cuenta_contable_cliente" type="xsd:string"/>
   <xsd:element name="plazo_cliente" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="estatus_proveedor" type="xsd:string"/>
   <xsd:element name="estatus_empleado" type="xsd:string"/>
   <xsd:element name="estatus_persona" type="xsd:string"/>
   <xsd:element name="estatus_agente" type="xsd:string"/>
   <xsd:element name="limite_credito_cliente" type="xsd:decimal"/>
   <xsd:element name="es_cliente" type="xsd:integer"/>
   <xsd:element name="es_proveedor" type="xsd:integer"/>
   <xsd:element name="es_agente" type="xsd:integer"/>
   <xsd:element name="es_empleado" type="xsd:integer"/>
   <xsd:element name="es_deudor" type="xsd:integer"/>
   <xsd:element name="es_prospecto" type="xsd:integer"/>
   <xsd:element name="fecha_actual" type="xsd:string"/>
   <xsd:element name="clasificacion_cliente" type="xsd:string"/>
   <xsd:element name="codigo_barra_empleado" type="xsd:string"/>
   <xsd:element name="bloquear_venta_credito" type="xsd:string"/>
   <xsd:element name="observaciones_estatus" type="xsd:string"/>
   <xsd:element name="sat_uso_cfdi_id" type="xsd:integer"/>
   <xsd:element name="cliente_regimen_fiscal" type="xsd:string"/>
   <xsd:element name="cliente_regimen_fiscal_ids" type="xsd:string"/>
   <xsd:element name="cuenta_contable_gasto_proveedor_id" type="xsd:integer"/>
   <xsd:element name="sat_uso_cfdi_proveedor_id" type="xsd:integer"/>
   <xsd:element name="datos_codigo_qr" type="xsd:string"/>
   <xsd:element name="passwordpv_empleado" type="xsd:string"/>
   <xsd:element name="usuariopv_empleado" type="xsd:string"/>
   <xsd:element name="precio_aplica_adicional_cliente" type="xsd:string"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
   <xsd:element name="forma_pago_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="agente">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="asociados">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:asociado[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="datosasociados">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datosasociado[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="dato_documento_produccion">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datos_documento_produccion[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="dato_centro_costo">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:centrocosto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoclientes">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:asociados"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoasociados">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:datosasociados"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="cliente">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="regimen" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="apellido_paterno" type="xsd:string"/>
   <xsd:element name="apellido_materno" type="xsd:string"/>
   <xsd:element name="razon_social" type="xsd:string"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="nombre_comercial" type="xsd:string"/>
   <xsd:element name="representante_legal" type="xsd:string"/>
   <xsd:element name="es_cliente" type="xsd:integer"/>
   <xsd:element name="numero" type="xsd:integer"/>
   <xsd:element name="fecha_alta" type="xsd:date"/>
   <xsd:element name="limite_credito_cliente" type="xsd:decimal"/>
   <xsd:element name="plazo_cliente" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="observaciones_estatus" type="xsd:string"/>
   <xsd:element name="sat_uso_cfdi_id" type="xsd:integer"/>
   <xsd:element name="cliente_regimen_fiscal" type="xsd:string"/>
   <xsd:element name="cuenta_contable_gasto_proveedor_id" type="xsd:integer"/>
   <xsd:element name="sat_uso_cfdi_proveedor_id" type="xsd:integer"/>
   <xsd:element name="datos_codigo_qr" type="xsd:string"/>
   <xsd:element name="passwordpv_empleado" type="xsd:string"/>
   <xsd:element name="usuariopv_empleado" type="xsd:string"/>
   <xsd:element name="precio_aplica_cliente" type="xsd:integer"/>
   <xsd:element name="precio_aplica_adicional_cliente" type="xsd:string"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoproveedores">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:proveedores"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="proveedores">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:proveedor[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="proveedor">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="regimen" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="apellido_paterno" type="xsd:string"/>
   <xsd:element name="apellido_materno" type="xsd:string"/>
   <xsd:element name="razon_social" type="xsd:string"/>
   <xsd:element name="curp" type="xsd:string"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="nombre_comercial" type="xsd:string"/>
   <xsd:element name="representante_legal" type="xsd:string"/>
   <xsd:element name="operacion" type="xsd:integer"/>
   <xsd:element name="es_extranjero" type="xsd:integer"/>
   <xsd:element name="es_cliente" type="xsd:integer"/>
   <xsd:element name="es_proveedor" type="xsd:integer"/>
   <xsd:element name="plazo_proveedor" type="xsd:integer"/>
   <xsd:element name="numero_proveedor" type="xsd:integer"/>
   <xsd:element name="forma_pago_proveedor_id" type="xsd:integer"/>
   <xsd:element name="estatus_proveedor" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="cuenta_bancaria_proveedor" type="xsd:string"/>
   <xsd:element name="fecha_actual" type="xsd:string"/>
   <xsd:element name="observaciones_estatus" type="xsd:string"/>
   <xsd:element name="sat_uso_cfdi_id" type="xsd:integer"/>
   <xsd:element name="cuenta_contable_gasto_proveedor_id" type="xsd:integer"/>
   <xsd:element name="sat_uso_cfdi_proveedor_id" type="xsd:integer"/>
   <xsd:element name="datos_codigo_qr" type="xsd:string"/>
   <xsd:element name="passwordpv_empleado" type="xsd:string"/>
   <xsd:element name="usuariopv_empleado" type="xsd:string"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="agentes">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:agente[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoagentes">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:agentes"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="direccion">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="idasociado" type="xsd:integer"/>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="numero_exterior" type="xsd:string"/>
   <xsd:element name="numero_interior" type="xsd:string"/>
   <xsd:element name="colonia" type="xsd:string"/>
   <xsd:element name="municipio" type="xsd:string"/>
   <xsd:element name="ciudad" type="xsd:string"/>
   <xsd:element name="codigo_postal" type="xsd:string"/>
   <xsd:element name="estado_id" type="xsd:integer"/>
   <xsd:element name="nombre_estado" type="xsd:string"/>
   <xsd:element name="pais" type="xsd:string"/>
   <xsd:element name="es_domicilio_fiscal" type="xsd:integer"/>
   <xsd:element name="es_domicilio_entrega" type="xsd:string"/>
   <xsd:element name="cuenta_contable" type="xsd:string"/>
   <xsd:element name="localidad" type="xsd:string"/>
   <xsd:element name="cuenta_contable_cliente" type="xsd:string"/>
   <xsd:element name="telefono" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="nombre_sucursal" type="xsd:string"/>
   <xsd:element name="plaza" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="direcciones">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:direccion[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadodirecciones">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:direcciones"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="almacen">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:string"/>
   <xsd:element name="plaza" type="xsd:string"/>
   <xsd:element name="tel" type="xsd:string"/>
   <xsd:element name="responsable" type="xsd:string"/>
   <xsd:element name="referencia_responsable" type="xsd:string"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="numero" type="xsd:string"/>
   <xsd:element name="cuentacontable" type="xsd:string"/>
   <xsd:element name="nacionalidad" type="xsd:string"/>
   <xsd:element name="maneja_ubicacion" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="almacenes">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:almacen[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoalmacenes">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:almacenes"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="componente_kit">
  <xsd:all>
   <xsd:element name="producto_id" type="xsd:integer"/>
   <xsd:element name="componente_id" type="xsd:integer"/>
   <xsd:element name="codigo_componente" type="xsd:string"/>
   <xsd:element name="cantidad_componente" type="xsd:decimal"/>
   <xsd:element name="descripcion_componente" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="componentes_kit">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:componente_kit[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadokits">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:componentes_kit"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="unidad_medida">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="abreviatura" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="unidades_medida">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:unidad_medida[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadounidadesmedida">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:unidades_medida"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="serie_producto">
  <xsd:all>
   <xsd:element name="producto_id" type="xsd:integer"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="almacen_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="series_producto">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:serie_producto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoseriesproducto">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:series_producto"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="producto">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="item" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="numero" type="xsd:string"/>
   <xsd:element name="moneda" type="xsd:string"/>
   <xsd:element name="unidad_id" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="ultimo_costo" type="xsd:decimal"/>
   <xsd:element name="precio" type="xsd:decimal"/>
   <xsd:element name="margen" type="xsd:decimal"/>
   <xsd:element name="costo_promedio" type="xsd:decimal"/>
   <xsd:element name="maximo" type="xsd:decimal"/>
   <xsd:element name="minimo" type="xsd:decimal"/>
   <xsd:element name="codigo_barra" type="xsd:string"/>
   <xsd:element name="kit" type="xsd:string"/>
   <xsd:element name="maneja_series" type="xsd:integer"/>
   <xsd:element name="costeo" type="xsd:decimal"/>
   <xsd:element name="caducidad" type="xsd:string"/>
   <xsd:element name="tiempo_reposicion" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="grupo_id" type="xsd:string"/>
   <xsd:element name="tasa_iva" type="xsd:string"/>
   <xsd:element name="tasa_ieps" type="xsd:string"/>
   <xsd:element name="vender" type="xsd:string"/>
   <xsd:element name="permite_reservacion" type="xsd:integer"/>
   <xsd:element name="capacidad_presentacion_ieps" type="xsd:decimal"/>
   <xsd:element name="importe_unidad_ieps" type="xsd:decimal"/>
   <xsd:element name="marca" type="xsd:string"/>
   <xsd:element name="imagen" type="xsd:string"/>
   <xsd:element name="caracteristicas" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="productos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:producto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoproductos">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:productos"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listaprecio">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="listaprecio_id" type="xsd:integer"/>
   <xsd:element name="producto_id" type="xsd:integer"/>
   <xsd:element name="nombre_lista_precio" type="xsd:string"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="importe" type="xsd:decimal"/>
   <xsd:element name="margen" type="xsd:decimal"/>
   <xsd:element name="margen_minimo_incremento" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listaprecios">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:listaprecio[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoprecios">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listaprecios"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listaprecioporplaza">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="empresa_id" type="xsd:integer"/>
   <xsd:element name="plaza_id" type="xsd:integer"/>
   <xsd:element name="listaprecio_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listapreciosporplaza">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:listaprecioporplaza[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadopreciosporplaza">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listapreciosporplaza"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="existencia">
  <xsd:all>
   <xsd:element name="idalmacen" type="xsd:integer"/>
   <xsd:element name="idproducto" type="xsd:integer"/>
   <xsd:element name="existencia" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="existencias">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:existencia[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoexistencias">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:existencias"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="tipoventa">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="es_venta" type="xsd:integer"/>
   <xsd:element name="afecta_cxc" type="xsd:integer"/>
   <xsd:element name="afecta_almacen" type="xsd:integer"/>
   <xsd:element name="almacen_default_id" type="xsd:integer"/>
   <xsd:element name="afecta_contabilidad" type="xsd:integer"/>
   <xsd:element name="sistema_externo" type="xsd:integer"/>
   <xsd:element name="tipo_comprobante" type="xsd:string"/>
   <xsd:element name="documento_donativo" type="xsd:integer"/>
   <xsd:element name="permitir_desglose_ieps" type="xsd:integer"/>
   <xsd:element name="permite_armar_kit_al_vender" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:string"/>
   <xsd:element name="agente_default_id" type="xsd:integer"/>
   <xsd:element name="referencia_agente_default" type="xsd:string"/>
   <xsd:element name="es_entrega_posterior" type="xsd:integer"/>
   <xsd:element name="es_documento_electronico" type="xsd:integer"/>
   <xsd:element name="permitir_equivalencia_predeterminada" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="tiposventa">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:tipoventa[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadotiposventas">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:tiposventa"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="tipocobro">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="abreviatura" type="xsd:string"/>
   <xsd:element name="estatus" type="xsd:integer"/>
   <xsd:element name="afecta_contabilidad" type="xsd:integer"/>
   <xsd:element name="cfd_emitido_sistema_externo" type="xsd:integer"/>
   <xsd:element name="es_comprobante_fiscal_digital" type="xsd:integer"/>
   <xsd:element name="tipo_afectacion" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="tiposcobro">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:tipocobro[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadotiposcobro">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:tiposcobro"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="tiponotacredito">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="abreviatura" type="xsd:string"/>
   <xsd:element name="estatus" type="xsd:integer"/>
   <xsd:element name="tipo" type="xsd:integer"/>
   <xsd:element name="afecta_almacen" type="xsd:integer"/>
   <xsd:element name="afecta_cxc" type="xsd:integer"/>
   <xsd:element name="permite_documento_electronico" type="xsd:integer"/>
   <xsd:element name="afecta_contabilidad" type="xsd:integer"/>
   <xsd:element name="cfd_emitido_sistema_externo" type="xsd:integer"/>
   <xsd:element name="permite_seleccionar_almacen" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="tiposnotacredito">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:tiponotacredito[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadotiposnotacredito">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:tiposnotacredito"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="cuentacontable">
  <xsd:all>
   <xsd:element name="cuenta" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:string"/>
   <xsd:element name="moneda" type="xsd:string"/>
   <xsd:element name="naturaleza" type="xsd:string"/>
   <xsd:element name="agrupador_sat" type="xsd:string"/>
   <xsd:element name="estatus" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="cuentascontables">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:cuentacontable[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadocuentacontable">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:cuentascontables"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="serietipoventa">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="empresa_id" type="xsd:integer"/>
   <xsd:element name="plaza" type="xsd:integer"/>
   <xsd:element name="tipo_venta_id" type="xsd:integer"/>
   <xsd:element name="serie" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="seriestiposventa">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:serietipoventa[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoseriestiposventas">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:seriestiposventa"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datos_cancelacion">
  <xsd:all>
   <xsd:element name="usuario" type="xsd:string"/>
   <xsd:element name="password" type="xsd:string"/>
   <xsd:element name="empresa" type="xsd:integer"/>
   <xsd:element name="plaza" type="xsd:integer"/>
   <xsd:element name="tipoventa" type="xsd:integer"/>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:integer"/>
   <xsd:element name="autoriza_cancelar_sat" type="xsd:integer"/>
   <xsd:element name="documento_id" type="xsd:integer"/>
   <xsd:element name="eliminar_documento" type="xsd:integer"/>
   <xsd:element name="sat_motivo_cancelacion" type="xsd:string"/>
   <xsd:element name="uuid_relacionado_cancelacion" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="serie">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="telefono" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:integer"/>
   <xsd:element name="consecutivo" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="series">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:serie[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoseriesconsecutivos">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:series"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="contacto">
  <xsd:all>
   <xsd:element name="asociado_id" type="xsd:integer"/>
   <xsd:element name="contacto_id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="telefono" type="xsd:string"/>
   <xsd:element name="telefono_movil" type="xsd:string"/>
   <xsd:element name="email" type="xsd:string"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="plaza" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="contactos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:contacto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadocontactos">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:contactos"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosplaza">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="numero" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="iva" type="xsd:decimal"/>
   <xsd:element name="permite_estimulo_fronterizo" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosplazas">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datosplaza[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadodatosplaza">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:datosplazas"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datoslicencia">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="activo" type="xsd:boolean"/>
   <xsd:element name="licencia" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datoslicencias">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datoslicencia[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadodatoslicencia">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:datoslicencias"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosempresa">
  <xsd:all>
   <xsd:element name="razon_social" type="xsd:string"/>
   <xsd:element name="rfc_empresa" type="xsd:string"/>
   <xsd:element name="nombre_comercial" type="xsd:string"/>
   <xsd:element name="domicilio" type="xsd:string"/>
   <xsd:element name="regimen" type="xsd:string"/>
   <xsd:element name="giro" type="xsd:string"/>
   <xsd:element name="telefono" type="xsd:string"/>
   <xsd:element name="logo" type="xsd:string"/>
   <xsd:element name="esquema_cfd" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosempresas">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datosempresa[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadodatosempresa">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:datosempresas"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosgrupoproducto">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="cuenta_id" type="xsd:integer"/>
   <xsd:element name="clave" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:integer"/>
   <xsd:element name="padre_id" type="xsd:integer"/>
   <xsd:element name="ruta_nombres" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosgruposproducto">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datosgrupoproducto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="datosgruposalmacen">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datosgrupoalmacen[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="datosgrupoalmacen">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="permite_venta" type="xsd:integer"/>
   <xsd:element name="permite_compra" type="xsd:integer"/>
   <xsd:element name="permite_inventario" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosempleados">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datosempleado[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="datosempleado">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="regimen" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="apellido_paterno" type="xsd:string"/>
   <xsd:element name="apellido_materno" type="xsd:string"/>
   <xsd:element name="razon_social" type="xsd:string"/>
   <xsd:element name="curp" type="xsd:string"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="nombre_comercial" type="xsd:string"/>
   <xsd:element name="es_extranjero" type="xsd:integer"/>
   <xsd:element name="es_cliente" type="xsd:integer"/>
   <xsd:element name="es_proveedor" type="xsd:integer"/>
   <xsd:element name="es_agente" type="xsd:integer"/>
   <xsd:element name="es_empleado" type="xsd:integer"/>
   <xsd:element name="estatus_empleado" type="xsd:integer"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="texto_adicional_2" type="xsd:string"/>
   <xsd:element name="texto_adicional_3" type="xsd:string"/>
   <xsd:element name="texto_adicional_4" type="xsd:string"/>
   <xsd:element name="texto_adicional_5" type="xsd:string"/>
   <xsd:element name="campo_adicional_01" type="xsd:string"/>
   <xsd:element name="campo_adicional_02" type="xsd:string"/>
   <xsd:element name="campo_adicional_03" type="xsd:string"/>
   <xsd:element name="campo_adicional_04" type="xsd:string"/>
   <xsd:element name="campo_adicional_05" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadogruposproductos">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:datosgruposproducto"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadogrupoalmacen">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:datosgruposalmacen"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoempleados">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:datosempleados"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="venta">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="tipoventa_id" type="xsd:integer"/>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="forma_pago_sat" type="xsd:integer"/>
   <xsd:element name="cliente_asociado_id" type="xsd:integer"/>
   <xsd:element name="subtotal_sin_descuento" type="xsd:decimal"/>
   <xsd:element name="importe_descuento" type="xsd:decimal"/>
   <xsd:element name="subtotal" type="xsd:decimal"/>
   <xsd:element name="importe_ieps" type="xsd:decimal"/>
   <xsd:element name="total" type="xsd:decimal"/>
   <xsd:element name="saldo" type="xsd:decimal"/>
   <xsd:element name="moneda_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="ventas">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:venta[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoventas">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:ventas"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="ventafiltrada">
  <xsd:all>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="id" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:string"/>
   <xsd:element name="tipo_venta" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="rfc" type="xsd:string"/>
   <xsd:element name="subtotal_sin_descuento" type="xsd:decimal"/>
   <xsd:element name="importe_descuento" type="xsd:decimal"/>
   <xsd:element name="subtotal" type="xsd:decimal"/>
   <xsd:element name="importe_iva" type="xsd:decimal"/>
   <xsd:element name="importe_ieps" type="xsd:decimal"/>
   <xsd:element name="total" type="xsd:decimal"/>
   <xsd:element name="moneda_id" type="xsd:integer"/>
   <xsd:element name="tipo_pago" type="xsd:string"/>
   <xsd:element name="fecha_entrega" type="xsd:string"/>
   <xsd:element name="saldo" type="xsd:decimal"/>
   <xsd:element name="estatus" type="xsd:integer"/>
   <xsd:element name="estatus_descripcion" type="xsd:string"/>
   <xsd:element name="codigo_transaccion" type="xsd:string"/>
   <xsd:element name="agente_asociado_id" type="xsd:integer"/>
   <xsd:element name="cliente_asociado_id" type="xsd:integer"/>
   <xsd:element name="fecha_cancelacion" type="xsd:date"/>
   <xsd:element name="conceptos" type="tns:conceptos"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="ventasfiltradas">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:ventafiltrada[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="listadoventasfiltradas">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:ventasfiltradas"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="parametrosReportePedidosVenta">
  <xsd:all>
   <xsd:element name="folio" type="xsd:string"/>
   <xsd:element name="fecha_from" type="xsd:string"/>
   <xsd:element name="fecha_to" type="xsd:string"/>
   <xsd:element name="fecha_entrega_from" type="xsd:string"/>
   <xsd:element name="fecha_entrega_to" type="xsd:string"/>
   <xsd:element name="cliente" type="xsd:string"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="componente" type="xsd:string"/>
   <xsd:element name="documento" type="xsd:string"/>
   <xsd:element name="pedidos_pendientes" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoPedidosVenta">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datosPedidos" type="tns:datosPedidosArreglo"/>
   <xsd:element name="detalladoProductos" type="tns:detalladoProductosArreglo"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="existencias_disponibles">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="detalles_productos" type="tns:detalles_productos"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datosPedidosArreglo">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:datosPedidos[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="datosPedidos">
  <xsd:all>
   <xsd:element name="documento" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:string"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="cliente" type="xsd:string"/>
   <xsd:element name="fecha_entrega" type="xsd:string"/>
   <xsd:element name="detalles" type="tns:detallesPedidoArreglo"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallesPedidoArreglo">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallesPedido[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesPedido">
  <xsd:all>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="unidad" type="xsd:string"/>
   <xsd:element name="cantidad" type="xsd:string"/>
   <xsd:element name="cantidad_por_entregar" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalladoProductosArreglo">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalladoProductos[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detalles_productos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalle_producto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detalladoProductos">
  <xsd:all>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="unidad" type="xsd:string"/>
   <xsd:element name="por_entregar" type="xsd:string"/>
   <xsd:element name="detalles" type="tns:detallesProductosPedidoArreglo"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalle_producto">
  <xsd:all>
   <xsd:element name="producto_id" type="xsd:integer"/>
   <xsd:element name="codigo_producto" type="xsd:string"/>
   <xsd:element name="detalles_existencias" type="tns:detalles_existencias"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallesProductosPedidoArreglo">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallesProductosPedido[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detalles_existencias">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalle_existencia[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesProductosPedido">
  <xsd:all>
   <xsd:element name="existencia" type="xsd:string"/>
   <xsd:element name="cantidad_por_recibir" type="xsd:string"/>
   <xsd:element name="almacen" type="xsd:string"/>
   <xsd:element name="cantidad_por_entregar" type="xsd:string"/>
   <xsd:element name="disponible" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalle_existencia">
  <xsd:all>
   <xsd:element name="almacen_id" type="xsd:string"/>
   <xsd:element name="existencia" type="xsd:integer"/>
   <xsd:element name="cantidad_por_entregar" type="xsd:integer"/>
   <xsd:element name="disponible" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="comercio_exterior">
  <xsd:all>
   <xsd:element name="motivo_traslado" type="xsd:string"/>
   <xsd:element name="tipo_operacion" type="xsd:string"/>
   <xsd:element name="clave_de_pedimento" type="xsd:string"/>
   <xsd:element name="certificado_origen" type="xsd:string"/>
   <xsd:element name="num_certificado_origen" type="xsd:string"/>
   <xsd:element name="numero_exportador_confiable" type="xsd:string"/>
   <xsd:element name="incoterm" type="xsd:string"/>
   <xsd:element name="subdivision" type="xsd:string"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="tipo_cambio_usd" type="xsd:string"/>
   <xsd:element name="total_usd" type="xsd:string"/>
   <xsd:element name="propietarios" type="tns:propietarios"/>
   <xsd:element name="receptor" type="tns:receptor"/>
   <xsd:element name="destinatarios" type="tns:destinatarios"/>
   <xsd:element name="mercancias" type="tns:mercancias"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="carta_porte">
  <xsd:all>
   <xsd:element name="tipo_comprobante" type="xsd:string"/>
   <xsd:element name="transporte_internacional" type="xsd:integer"/>
   <xsd:element name="regimen_aduanero" type="xsd:string"/>
   <xsd:element name="entrada_salida_mercancia" type="xsd:integer"/>
   <xsd:element name="pais_origen_destino" type="xsd:string"/>
   <xsd:element name="via_entrada_salida" type="xsd:string"/>
   <xsd:element name="distancia_total_recorrida" type="xsd:float"/>
   <xsd:element name="registro_istmo" type="xsd:integer"/>
   <xsd:element name="ubicacion_polo_origen" type="xsd:string"/>
   <xsd:element name="ubicacion_polo_destino" type="xsd:string"/>
   <xsd:element name="peso_bruto_total" type="xsd:float"/>
   <xsd:element name="unidad_peso" type="xsd:string"/>
   <xsd:element name="numero_total_mercancias" type="xsd:float"/>
   <xsd:element name="cargo_por_tasacion" type="xsd:float"/>
   <xsd:element name="logistica_inversa_recolecion_devolucion" type="xsd:integer"/>
   <xsd:element name="peso_neto_total" type="xsd:float"/>
   <xsd:element name="ubicaciones" type="tns:detallesubicaciones"/>
   <xsd:element name="mercancias" type="tns:detallesmercancias_carta_porte"/>
   <xsd:element name="autotransportes" type="tns:detallesautotransportes"/>
   <xsd:element name="figuratransporte" type="tns:detallesfiguratransporte"/>
   <xsd:element name="transportemaritimos" type="tns:detallestransportemaritimos"/>
   <xsd:element name="contenedor" type="tns:detallescontenedor"/>
   <xsd:element name="transporteaereos" type="tns:detallestransporteaereos"/>
   <xsd:element name="transporteferroviario" type="tns:detallestransporteferroviario"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="nuevo_producto">
  <xsd:all>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="sat_clave_producto_servicio" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:string"/>
   <xsd:element name="grupo" type="xsd:integer"/>
   <xsd:element name="moneda" type="xsd:integer"/>
   <xsd:element name="unidad_medida" type="xsd:string"/>
   <xsd:element name="tipo_costeo" type="xsd:integer"/>
   <xsd:element name="maneja_series" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:integer"/>
   <xsd:element name="costo_promedio" type="xsd:float"/>
   <xsd:element name="precio" type="xsd:float"/>
   <xsd:element name="ultimo_costo" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="nuevo_grupo_producto">
  <xsd:all>
   <xsd:element name="clave" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:string"/>
   <xsd:element name="cuenta_contable" type="xsd:string"/>
   <xsd:element name="grupo_padre" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="nueva_unidad_medida_producto">
  <xsd:all>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="abreviatura" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:integer"/>
   <xsd:element name="clave_unidad_medida_sat" type="xsd:string"/>
   <xsd:element name="sat_unidad_medida_aduana" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="receptor">
  <xsd:all>
   <xsd:element name="num_reg_id_trib" type="xsd:string"/>
   <xsd:element name="domicilio" type="tns:domicilio"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="destinatario">
  <xsd:all>
   <xsd:element name="num_reg_id_trib" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="domicilios" type="tns:domicilios"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="propietario">
  <xsd:all>
   <xsd:element name="num_reg_id_trib" type="xsd:string"/>
   <xsd:element name="residencia_fiscal" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="mercancias">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:mercancia[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesmercancias_carta_porte">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallemercancia_carta_porte[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesubicaciones">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalleubicacion[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesfiguratransporte">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallefiguratransporte[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallestransportemaritimos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalletransportemaritimo[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallescontenedor">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallecontenedor[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallestransporteaereos">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalletransporteaereo[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallestransporteferroviario">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalletransporteferroviario[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesderechodepaso">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallederechodepaso[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallescarro">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallecarro[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="propietarios">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:propietario[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="destinatarios">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:destinatario[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="domicilios">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:domicilio[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="descripciones_especificas">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:descripcion_especifica[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesguiasidentificacion">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalleguiaidentificacion[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallescantidadtransportada">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallecantidadtransportada[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallespeso">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallepeso[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallespedimento">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detallepedimento[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesautotransportes">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalleautotransporte[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesremolques">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalleremolques[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="detallesremolquesccp">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:detalleremolquesccp[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="descripcion_especifica">
  <xsd:all>
   <xsd:element name="marca" type="xsd:string"/>
   <xsd:element name="modelo" type="xsd:string"/>
   <xsd:element name="sub_modelo" type="xsd:string"/>
   <xsd:element name="numero_serie" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="mercancia">
  <xsd:all>
   <xsd:element name="no_identificacion" type="xsd:string"/>
   <xsd:element name="fraccion_arancelaria" type="xsd:string"/>
   <xsd:element name="cantidad_aduana" type="xsd:string"/>
   <xsd:element name="unidad_aduana" type="xsd:string"/>
   <xsd:element name="valor_unitario_aduana" type="xsd:string"/>
   <xsd:element name="valor_dolares" type="xsd:string"/>
   <xsd:element name="descripciones_especificas" type="tns:descripciones_especificas"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleubicacion">
  <xsd:all>
   <xsd:element name="tipo_ubicacion" type="xsd:string"/>
   <xsd:element name="id_ubicacion" type="xsd:string"/>
   <xsd:element name="remitente_destinatario" type="xsd:integer"/>
   <xsd:element name="direccion" type="xsd:integer"/>
   <xsd:element name="fecha_hora" type="xsd:string"/>
   <xsd:element name="distancia_recorrida" type="xsd:float"/>
   <xsd:element name="numero_estacion" type="xsd:string"/>
   <xsd:element name="navegacion_trafico" type="xsd:integer"/>
   <xsd:element name="tipo_estacion" type="xsd:string"/>
   <xsd:element name="nombre_estacion_extranjera" type="xsd:string"/>
   <xsd:element name="rfc_remitente_destinatario" type="xsd:string"/>
   <xsd:element name="nombre_remitente_destinatario" type="xsd:string"/>
   <xsd:element name="num_reg_id_trib" type="xsd:string"/>
   <xsd:element name="residencia_fiscal" type="xsd:string"/>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="numero_exterior" type="xsd:string"/>
   <xsd:element name="numero_interior" type="xsd:string"/>
   <xsd:element name="colonia" type="xsd:string"/>
   <xsd:element name="localidad" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="municipio" type="xsd:string"/>
   <xsd:element name="estado" type="xsd:string"/>
   <xsd:element name="pais" type="xsd:string"/>
   <xsd:element name="codigo_postal" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallemercancia_carta_porte">
  <xsd:all>
   <xsd:element name="no_identificacion_producto" type="xsd:integer"/>
   <xsd:element name="codigo_transportado" type="xsd:string"/>
   <xsd:element name="descripcion" type="xsd:string"/>
   <xsd:element name="bienes_transportados" type="xsd:string"/>
   <xsd:element name="dimensiones" type="xsd:string"/>
   <xsd:element name="material_peligroso" type="xsd:integer"/>
   <xsd:element name="cve_material_peligroso" type="xsd:string"/>
   <xsd:element name="embalaje" type="xsd:string"/>
   <xsd:element name="peso_en_kg" type="xsd:float"/>
   <xsd:element name="clave_unidad" type="xsd:string"/>
   <xsd:element name="descripcion_unidad" type="xsd:string"/>
   <xsd:element name="valor_mercancia" type="xsd:float"/>
   <xsd:element name="moneda" type="xsd:string"/>
   <xsd:element name="fraccion_arancelaria" type="xsd:string"/>
   <xsd:element name="uuid_comercio_exterior" type="xsd:string"/>
   <xsd:element name="sector_cofepris" type="xsd:string"/>
   <xsd:element name="nombre_ingrediente_activo" type="xsd:string"/>
   <xsd:element name="nom_quimico" type="xsd:string"/>
   <xsd:element name="denominacion_generica_prod" type="xsd:string"/>
   <xsd:element name="denominacion_distintiva_prod" type="xsd:string"/>
   <xsd:element name="fabricante" type="xsd:string"/>
   <xsd:element name="fecha_caducidad" type="xsd:string"/>
   <xsd:element name="lote_medicamento" type="xsd:string"/>
   <xsd:element name="forma_farmaceutica" type="xsd:string"/>
   <xsd:element name="condiciones_esp_transp" type="xsd:string"/>
   <xsd:element name="registro_sanitario_folio_autorizacion" type="xsd:string"/>
   <xsd:element name="permiso_importacion" type="xsd:string"/>
   <xsd:element name="folio_impo_vucem" type="xsd:string"/>
   <xsd:element name="num_cas" type="xsd:string"/>
   <xsd:element name="razon_social_emp_imp" type="xsd:string"/>
   <xsd:element name="num_reg_san_plag_cofepris" type="xsd:string"/>
   <xsd:element name="datos_fabricante" type="xsd:string"/>
   <xsd:element name="datos_formulador" type="xsd:string"/>
   <xsd:element name="datos_maquilador" type="xsd:string"/>
   <xsd:element name="uso_autorizado" type="xsd:string"/>
   <xsd:element name="tipo_materia" type="xsd:string"/>
   <xsd:element name="descripcion_materia" type="xsd:string"/>
   <xsd:element name="pedimentos" type="xsd:string"/>
   <xsd:element name="clave_stcc" type="xsd:integer"/>
   <xsd:element name="guiasidentificacion" type="tns:detallesguiasidentificacion"/>
   <xsd:element name="cantidadtransportada" type="tns:detallescantidadtransportada"/>
   <xsd:element name="peso" type="tns:detallespeso"/>
   <xsd:element name="informacion_aduanera" type="tns:detallespedimento"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleguiaidentificacion">
  <xsd:all>
   <xsd:element name="numero_guia" type="xsd:string"/>
   <xsd:element name="descripcion_guia" type="xsd:string"/>
   <xsd:element name="peso_guia" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallecantidadtransportada">
  <xsd:all>
   <xsd:element name="cantidad" type="xsd:float"/>
   <xsd:element name="id_origen" type="xsd:string"/>
   <xsd:element name="id_destino" type="xsd:string"/>
   <xsd:element name="clave_transporte" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallepeso">
  <xsd:all>
   <xsd:element name="unidad_peso_mercancia" type="xsd:string"/>
   <xsd:element name="peso_bruto" type="xsd:float"/>
   <xsd:element name="peso_neto" type="xsd:float"/>
   <xsd:element name="peso_tara" type="xsd:float"/>
   <xsd:element name="numero_piezas" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallepedimento">
  <xsd:all>
   <xsd:element name="tipo_documento" type="xsd:string"/>
   <xsd:element name="pedimento" type="xsd:string"/>
   <xsd:element name="ident_docu_aduanero" type="xsd:string"/>
   <xsd:element name="rfc_impo" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalletransportemaritimo">
  <xsd:all>
   <xsd:element name="permiso_sct" type="xsd:string"/>
   <xsd:element name="numero_permisosct" type="xsd:string"/>
   <xsd:element name="aseguradora" type="xsd:string"/>
   <xsd:element name="poliza" type="xsd:string"/>
   <xsd:element name="tipo_embarcacion" type="xsd:string"/>
   <xsd:element name="matricula" type="xsd:string"/>
   <xsd:element name="numero_omi" type="xsd:string"/>
   <xsd:element name="anio_embarcacion" type="xsd:integer"/>
   <xsd:element name="nombre_embarcacion" type="xsd:string"/>
   <xsd:element name="nacionalidad_embarcacion" type="xsd:string"/>
   <xsd:element name="unidad_arqueo_bruto" type="xsd:float"/>
   <xsd:element name="tipo_carga" type="xsd:string"/>
   <xsd:element name="numero_certificado_itc" type="xsd:string"/>
   <xsd:element name="eslora" type="xsd:float"/>
   <xsd:element name="manga" type="xsd:float"/>
   <xsd:element name="calado" type="xsd:float"/>
   <xsd:element name="linea_naviera" type="xsd:string"/>
   <xsd:element name="agente_naviero" type="xsd:integer"/>
   <xsd:element name="numero_autorizacion_naviero" type="xsd:string"/>
   <xsd:element name="numero_viaje" type="xsd:string"/>
   <xsd:element name="numero_conocimiento_embarque" type="xsd:string"/>
   <xsd:element name="puntal" type="xsd:decimal"/>
   <xsd:element name="permiso_temp_navegacion" type="xsd:string"/>
   <xsd:element name="remolquesccp" type="tns:detallesremolquesccp"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallecontenedor">
  <xsd:all>
   <xsd:element name="matricula_contenedor" type="xsd:string"/>
   <xsd:element name="tipo_contenedor" type="xsd:string"/>
   <xsd:element name="numero_precinto" type="xsd:string"/>
   <xsd:element name="peso_contenedor_vacio" type="xsd:float"/>
   <xsd:element name="peso_neto_mercancia" type="xsd:float"/>
   <xsd:element name="id_ccp_relacionado" type="xsd:string"/>
   <xsd:element name="placa_vm_ccp" type="xsd:string"/>
   <xsd:element name="fecha_certificacion_ccp" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallederechodepaso">
  <xsd:all>
   <xsd:element name="tipo_derecho_paso" type="xsd:string"/>
   <xsd:element name="kilometraje_pagado" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallecarro">
  <xsd:all>
   <xsd:element name="tipo_carro" type="xsd:string"/>
   <xsd:element name="matricula_carro" type="xsd:string"/>
   <xsd:element name="guia_carro" type="xsd:string"/>
   <xsd:element name="toneladas_netas_carro" type="xsd:float"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalletransporteaereo">
  <xsd:all>
   <xsd:element name="permiso_sct" type="xsd:string"/>
   <xsd:element name="numero_permisosct" type="xsd:string"/>
   <xsd:element name="matricula_aeronave" type="xsd:string"/>
   <xsd:element name="aseguradora_aeronave" type="xsd:string"/>
   <xsd:element name="poliza_aseguradora_aeronave" type="xsd:string"/>
   <xsd:element name="numero_guia" type="xsd:string"/>
   <xsd:element name="lugar_contrato" type="xsd:string"/>
   <xsd:element name="codigo_transportista" type="xsd:string"/>
   <xsd:element name="embarcador" type="xsd:integer"/>
   <xsd:element name="direccion_embarcador" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalletransporteferroviario">
  <xsd:all>
   <xsd:element name="tipo_servicio" type="xsd:string"/>
   <xsd:element name="tipo_trafico" type="xsd:string"/>
   <xsd:element name="aseguradora_ferrea" type="xsd:string"/>
   <xsd:element name="poliza_ferrea" type="xsd:string"/>
   <xsd:element name="derechodepaso" type="tns:detallesderechodepaso"/>
   <xsd:element name="carro" type="tns:detallescarro"/>
   <xsd:element name="contenedor" type="tns:detallescontenedor"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleautotransporte">
  <xsd:all>
   <xsd:element name="permiso_sct" type="xsd:string"/>
   <xsd:element name="numero_permisosct" type="xsd:string"/>
   <xsd:element name="configuracion_vehicular" type="xsd:string"/>
   <xsd:element name="peso_bruto_vehicular" type="xsd:decimal"/>
   <xsd:element name="placa" type="xsd:string"/>
   <xsd:element name="anio_modelo" type="xsd:integer"/>
   <xsd:element name="aseguradora_resp_civil" type="xsd:string"/>
   <xsd:element name="poliza_resp_civil" type="xsd:string"/>
   <xsd:element name="aseguradora_ambiente" type="xsd:string"/>
   <xsd:element name="poliza_ambiente" type="xsd:string"/>
   <xsd:element name="aseguradora_carga" type="xsd:string"/>
   <xsd:element name="poliza_carga" type="xsd:string"/>
   <xsd:element name="prima_seguro" type="xsd:string"/>
   <xsd:element name="remolques" type="tns:detallesremolques"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleremolques">
  <xsd:all>
   <xsd:element name="sub_tipo_remolque" type="xsd:string"/>
   <xsd:element name="placa" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detalleremolquesccp">
  <xsd:all>
   <xsd:element name="sub_tipo_remolque_ccp" type="xsd:string"/>
   <xsd:element name="placa_ccp" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="detallefiguratransporte">
  <xsd:all>
   <xsd:element name="tipo_figura" type="xsd:string"/>
   <xsd:element name="asociado_figura" type="xsd:integer"/>
   <xsd:element name="direccion_asociado_figura" type="xsd:integer"/>
   <xsd:element name="numero_licencia" type="xsd:string"/>
   <xsd:element name="partestransporte" type="xsd:string"/>
   <xsd:element name="rfc_figura" type="xsd:string"/>
   <xsd:element name="nombre_figura" type="xsd:string"/>
   <xsd:element name="num_reg_id_trib_figura" type="xsd:string"/>
   <xsd:element name="residencia_fiscal_figura" type="xsd:string"/>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="numero_exterior" type="xsd:string"/>
   <xsd:element name="numero_interior" type="xsd:string"/>
   <xsd:element name="colonia" type="xsd:string"/>
   <xsd:element name="localidad" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="municipio" type="xsd:string"/>
   <xsd:element name="estado" type="xsd:string"/>
   <xsd:element name="pais" type="xsd:string"/>
   <xsd:element name="codigo_postal" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="domicilio">
  <xsd:all>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="numero_exterior" type="xsd:string"/>
   <xsd:element name="numero_interior" type="xsd:string"/>
   <xsd:element name="colonia" type="xsd:string"/>
   <xsd:element name="localidad" type="xsd:string"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="municipio" type="xsd:string"/>
   <xsd:element name="estado" type="xsd:string"/>
   <xsd:element name="pais" type="xsd:string"/>
   <xsd:element name="codigo_postal" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="estatuscancelacionventa">
  <xsd:all>
   <xsd:element name="id" type="xsd:string"/>
   <xsd:element name="venta_id" type="xsd:integer"/>
   <xsd:element name="estatus_cancelacion_sat" type="xsd:integer"/>
   <xsd:element name="fecha_cancelacion" type="xsd:string"/>
   <xsd:element name="fecha_solicitud_cancelacion" type="xsd:string"/>
   <xsd:element name="fecha_venta" type="xsd:string"/>
   <xsd:element name="total" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoestatuscancelacion">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:estatuscancelacionventa[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="saldocliente">
  <xsd:all>
   <xsd:element name="asociado_id" type="xsd:integer"/>
   <xsd:element name="saldo_actual" type="xsd:decimal"/>
   <xsd:element name="saldo_vencido" type="xsd:decimal"/>
   <xsd:element name="codigo_cliente" type="xsd:string"/>
   <xsd:element name="nombre_cliente" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadosaldocliente">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:saldocliente[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="responsesaldocliente">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listadosaldocliente"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="respuestalistadocancelacion">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listadoestatuscancelacion"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="cobro_cliente">
  <xsd:all>
   <xsd:element name="cliente" type="xsd:string"/>
   <xsd:element name="importe" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadocobrocliente">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:cobro_cliente[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="aplicacioncobro">
  <xsd:all>
   <xsd:element name="buscar_por_codigo" type="xsd:boolean"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="forma_pago_id" type="xsd:integer"/>
   <xsd:element name="referencia" type="xsd:string"/>
   <xsd:element name="plaza" type="xsd:integer"/>
   <xsd:element name="clientes" type="tns:listadocobrocliente"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="documentocaja">
  <xsd:all>
   <xsd:element name="folio" type="xsd:integer"/>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="total" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadodocumentocaja">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:documentocaja[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="cobroaplicado">
  <xsd:all>
   <xsd:element name="cliente_id" type="xsd:integer"/>
   <xsd:element name="codigo_cliente" type="xsd:string"/>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="documentos_caja" type="tns:listadodocumentocaja"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadocobroaplicado">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:cobroaplicado[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="responseaplicacioncobros">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="cobros_aplicados" type="tns:listadocobroaplicado"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="abono_aplicar">
  <xsd:all>
   <xsd:element name="asociado_id" type="xsd:integer"/>
   <xsd:element name="total_abonar" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoabonoaplicar">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:abono_aplicar[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="documentoarchivoadjunto">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="documentosarchivoadjunto">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:documentoarchivoadjunto[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="abonosaplicados">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:abonoaplicado[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="abonoaplicado">
  <xsd:all>
   <xsd:element name="asociado_id" type="xsd:integer"/>
   <xsd:element name="total_abonado" type="xsd:decimal"/>
   <xsd:element name="movimiento_id" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="responseabonosaplicados">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:abonosaplicados"/>
   <xsd:element name="errores" type="tns:listadoerrores"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadoerrores">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="xsd:string[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="saldo_cliente">
  <xsd:all>
   <xsd:element name="asociado_id" type="xsd:integer"/>
   <xsd:element name="saldo_por_pagar" type="xsd:decimal"/>
   <xsd:element name="limite_credito" type="xsd:decimal"/>
   <xsd:element name="plaza" type="xsd:integer"/>
   <xsd:element name="nombre_plaza" type="xsd:string"/>
   <xsd:element name="texto_adicional_1" type="xsd:string"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="apellido_paterno" type="xsd:string"/>
   <xsd:element name="apellido_materno" type="xsd:string"/>
   <xsd:element name="total_ticket" type="xsd:decimal"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="codigo_producto" type="xsd:string"/>
   <xsd:element name="nombre_producto" type="xsd:string"/>
   <xsd:element name="cantidad" type="xsd:decimal"/>
   <xsd:element name="precio" type="xsd:decimal"/>
   <xsd:element name="ticket" type="xsd:string"/>
   <xsd:element name="bloquear_venta_credito" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="listadosaldocreditocliente">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:saldo_cliente[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="responsecreditocliente">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="datos" type="tns:listadosaldocreditocliente"/>
   <xsd:element name="errores" type="tns:listadoerrores"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="productolistaprecio">
  <xsd:all>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="descuento_maximo" type="xsd:decimal"/>
   <xsd:element name="precio" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="productoslistaprecio">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:productolistaprecio[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="lista_precio">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="tipo" type="xsd:integer"/>
   <xsd:element name="productos" type="tns:productoslistaprecio"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="productos_almacen">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:producto_almacen[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="almacen_agregar">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="datos_almacen" type="tns:datos_almacen"/>
   <xsd:element name="reemplazar_productos" type="xsd:integer"/>
   <xsd:element name="productos_almacen" type="tns:productos_almacen"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="datos_almacen">
  <xsd:all>
   <xsd:element name="nombre" type="xsd:string"/>
   <xsd:element name="grupo_almacen" type="xsd:integer"/>
   <xsd:element name="estatus" type="xsd:integer"/>
   <xsd:element name="nacionalidad" type="xsd:integer"/>
   <xsd:element name="cuenta_contable" type="xsd:string"/>
   <xsd:element name="responsable" type="xsd:integer"/>
   <xsd:element name="maneja_ubicacion" type="xsd:integer"/>
   <xsd:element name="plaza" type="xsd:integer"/>
   <xsd:element name="calle" type="xsd:string"/>
   <xsd:element name="numero_exterior" type="xsd:string"/>
   <xsd:element name="colonia" type="xsd:string"/>
   <xsd:element name="codigo_postal" type="xsd:integer"/>
   <xsd:element name="pais" type="xsd:integer"/>
   <xsd:element name="estado" type="xsd:integer"/>
   <xsd:element name="telefono" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="producto_almacen">
  <xsd:all>
   <xsd:element name="tipo_movimiento" type="xsd:integer"/>
   <xsd:element name="codigo" type="xsd:string"/>
   <xsd:element name="ubicacion" type="xsd:string"/>
   <xsd:element name="cantidad_maxima" type="xsd:integer"/>
   <xsd:element name="cantidad_minima" type="xsd:integer"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="productos_ids">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="xsd:int[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="respuestanotacredito">
  <xsd:all>
   <xsd:element name="resultado" type="xsd:integer"/>
   <xsd:element name="xml" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:string"/>
   <xsd:element name="serie" type="xsd:string"/>
   <xsd:element name="uuid" type="xsd:string"/>
   <xsd:element name="id" type="xsd:string"/>
   <xsd:element name="mensaje" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="documentonotacredito">
  <xsd:all>
   <xsd:element name="id" type="xsd:integer"/>
   <xsd:element name="importe" type="xsd:decimal"/>
  </xsd:all>
 </xsd:complexType>
 <xsd:complexType name="documentosnotacredito">
  <xsd:complexContent>
   <xsd:restriction base="SOAP-ENC:Array">
    <xsd:attribute ref="SOAP-ENC:arrayType" wsdl:arrayType="tns:documentonotacredito[]"/>
   </xsd:restriction>
  </xsd:complexContent>
 </xsd:complexType>
 <xsd:complexType name="notacredito">
  <xsd:all>
   <xsd:element name="tiponotacredito" type="xsd:string"/>
   <xsd:element name="folio" type="xsd:integer"/>
   <xsd:element name="asignar_folio_siguiente_si_esta_ocupado" type="xsd:integer"/>
   <xsd:element name="fecha" type="xsd:string"/>
   <xsd:element name="receptor" type="tns:datosreceptor"/>
   <xsd:element name="documentos" type="tns:documentosnotacredito"/>
   <xsd:element name="observaciones" type="xsd:string"/>
   <xsd:element name="moneda_id" type="xsd:integer"/>
   <xsd:element name="tipo_cambio" type="xsd:decimal"/>
   <xsd:element name="xml" type="xsd:string"/>
   <xsd:element name="uuid" type="xsd:string"/>
   <xsd:element name="fecha_timbrado" type="xsd:string"/>
   <xsd:element name="sello_sat" type="xsd:string"/>
   <xsd:element name="certificado_sat" type="xsd:string"/>
   <xsd:element name="certificado" type="xsd:string"/>
   <xsd:element name="version_timbre" type="xsd:string"/>
   <xsd:element name="sello_digital" type="xsd:string"/>
   <xsd:element name="cadena_original" type="xsd:string"/>
   <xsd:element name="sat_exportacion" type="xsd:string"/>
   <xsd:element name="clave_uso_cfdi" type="xsd:string"/>
  </xsd:all>
 </xsd:complexType>
</xsd:schema>
</types>
<message name="getEstatusCancelacionVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getEstatusCancelacionVentaResponse">
  <part name="return" type="tns:respuestalistadocancelacion" /></message>
<message name="getSaldosClienteRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" /></message>
<message name="getSaldosClienteResponse">
  <part name="return" type="tns:responsesaldocliente" /></message>
<message name="setGeneraVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="datosfactura" type="tns:factura" /></message>
<message name="setGeneraVentaResponse">
  <part name="return" type="xsd:string" /></message>
<message name="setTerminarDocumentoVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="id" type="xsd:integer" />
  <part name="rfc" type="xsd:string" /></message>
<message name="setTerminarDocumentoVentaResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setAutenticacionRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="setAutenticacionResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setGeneraDocumentoVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="datosfactura" type="tns:factura" />
  <part name="valida_credito" type="xsd:boolean" /></message>
<message name="setGeneraDocumentoVentaResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setGeneraDocumentoVentaPosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="datosfactura" type="tns:facturaPos" />
  <part name="valida_credito" type="xsd:boolean" /></message>
<message name="setGeneraDocumentoVentaPosResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setGeneraPosVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="datosfactura" type="tns:facturaPos" />
  <part name="valida_credito" type="xsd:boolean" /></message>
<message name="setGeneraPosVentaResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="getEstatusVentaPosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="ventas" type="tns:ventasPos" /></message>
<message name="getEstatusVentaPosResponse">
  <part name="return" type="tns:listadoEstatusVentasPos" /></message>
<message name="setGeneraCartaPorteRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="datosfactura" type="tns:factura" />
  <part name="datoscartaporte" type="tns:cartaporte" /></message>
<message name="setGeneraCartaPorteResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setReenviodeCorreoDocumentoVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="tipoventa" type="xsd:integer" />
  <part name="serie" type="xsd:string" />
  <part name="folio" type="xsd:integer" />
  <part name="email" type="xsd:string" /></message>
<message name="setReenviodeCorreoDocumentoVentaResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="SetCancelaDocumentoVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="tipoventa" type="xsd:integer" />
  <part name="serie" type="xsd:string" />
  <part name="folio" type="xsd:integer" />
  <part name="documento_id" type="xsd:integer" />
  <part name="eliminar_documento" type="xsd:integer" />
  <part name="sat_motivo_cancelacion" type="xsd:string" />
  <part name="uuid_relacionado_cancelacion" type="xsd:string" /></message>
<message name="SetCancelaDocumentoVentaResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="SetCancelaDocumentoVentaCFDRequest">
  <part name="datos_cancelacion" type="tns:datos_cancelacion" /></message>
<message name="SetCancelaDocumentoVentaCFDResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setListaPrecioRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="listaprecio" type="tns:lista_precio" /></message>
<message name="setListaPrecioResponse">
  <part name="return" type="tns:respuestalistaprecio" /></message>
<message name="setAlmacenProductoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="almacen" type="tns:almacen_agregar" /></message>
<message name="setAlmacenProductoResponse">
  <part name="return" type="tns:respuestaalmancenproducto" /></message>
<message name="getComprobantePDFRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="Plaza" type="xsd:integer" />
  <part name="tipoventa" type="xsd:integer" />
  <part name="serie" type="xsd:string" />
  <part name="folio" type="xsd:integer" /></message>
<message name="getComprobantePDFResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="getComprobanteXMLRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="tipoventa" type="xsd:integer" />
  <part name="serie" type="xsd:string" />
  <part name="folio" type="xsd:integer" /></message>
<message name="getComprobanteXMLResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="getReporteMensualCFDRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="anio" type="xsd:integer" />
  <part name="mes" type="xsd:integer" />
  <part name="tiporeporte" type="xsd:string" /></message>
<message name="getReporteMensualCFDResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setGeneraReporteMensualdeCFDRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="anio" type="xsd:integer" />
  <part name="mes" type="xsd:integer" />
  <part name="tiporeporte" type="xsd:string" /></message>
<message name="setGeneraReporteMensualdeCFDResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="getClientesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getClientesResponse">
  <part name="return" type="tns:listadoclientes" /></message>
<message name="getAsociadosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getAsociadosResponse">
  <part name="return" type="tns:listadoasociados" /></message>
<message name="getDocumentoProduccionRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getDocumentoProduccionResponse">
  <part name="return" type="tns:listadoproduccion" /></message>
<message name="getCentroCostoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCentroCostoResponse">
  <part name="return" type="tns:listadocentrocosto" /></message>
<message name="getAgentesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getAgentesResponse">
  <part name="return" type="tns:listadoagentes" /></message>
<message name="getProveedoresRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getProveedoresResponse">
  <part name="return" type="tns:listadoproveedores" /></message>
<message name="getClienteByRfcRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="rfc" type="xsd:string" /></message>
<message name="getClienteByRfcResponse">
  <part name="return" type="tns:listadoclientes" /></message>
<message name="getDireccionesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getDireccionesResponse">
  <part name="return" type="tns:listadodirecciones" /></message>
<message name="getAlmacenesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getAlmacenesResponse">
  <part name="return" type="tns:listadoalmacenes" /></message>
<message name="getUnidadesMedidaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getUnidadesMedidaResponse">
  <part name="return" type="tns:listadounidadesmedida" /></message>
<message name="getSeriesProductoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="almacen_id" type="xsd:integer" />
  <part name="limit" type="xsd:string" /></message>
<message name="getSeriesProductoResponse">
  <part name="return" type="tns:listadoseriesproducto" /></message>
<message name="getComponentesKitsRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="limit" type="xsd:string" /></message>
<message name="getComponentesKitsResponse">
  <part name="return" type="tns:listadokits" /></message>
<message name="getProductosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getProductosResponse">
  <part name="return" type="tns:listadoproductos" /></message>
<message name="getProductosRutaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getProductosRutaResponse">
  <part name="return" type="tns:listadoproductos" /></message>
<message name="getListaPreciosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getListaPreciosResponse">
  <part name="return" type="tns:listadoprecios" /></message>
<message name="getListaPrecioPorPlazaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fechahora" type="xsd:string" /></message>
<message name="getListaPrecioPorPlazaResponse">
  <part name="return" type="tns:listadopreciosporplaza" /></message>
<message name="getExistenciasRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="almacen" type="xsd:string" />
  <part name="producto" type="xsd:string" />
  <part name="productos_ids" type="xsd:string" /></message>
<message name="getExistenciasResponse">
  <part name="return" type="tns:listadoexistencias" /></message>
<message name="getFormasDePagoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getFormasDePagoResponse">
  <part name="return" type="tns:listadoformasdepago" /></message>
<message name="getTipoRelacionRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoRelacionResponse">
  <part name="return" type="tns:catalogotiporelacion" /></message>
<message name="getUsoCfdiRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getUsoCfdiResponse">
  <part name="return" type="tns:catalogousocfdi" /></message>
<message name="getImpuestoDetalleRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="impuesto_id" type="xsd:integer" /></message>
<message name="getImpuestoDetalleResponse">
  <part name="return" type="tns:catalogoimpuestodetalle" /></message>
<message name="getClaveProductoServicioRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="paginado" type="xsd:string" /></message>
<message name="getClaveProductoServicioResponse">
  <part name="return" type="tns:catalogoclaveproductoservicio" /></message>
<message name="getMetodoPagoSatRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getMetodoPagoSatResponse">
  <part name="return" type="tns:catalogometodopagosat" /></message>
<message name="getUnidadMedidaSatRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getUnidadMedidaSatResponse">
  <part name="return" type="tns:catalogounidadmedidasat" /></message>
<message name="getTiposNotaCreditoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getTiposNotaCreditoResponse">
  <part name="return" type="tns:listadotiposnotacredito" /></message>
<message name="getTiposVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getTiposVentaResponse">
  <part name="return" type="tns:listadotiposventas" /></message>
<message name="getSeriesTiposVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getSeriesTiposVentaResponse">
  <part name="return" type="tns:listadoseriestiposventas" /></message>
<message name="getEmpresaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getEmpresaResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getSeriesConsecutivosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getSeriesConsecutivosResponse">
  <part name="return" type="tns:listadoseriesconsecutivos" /></message>
<message name="getContactosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="anio" type="xsd:integer" />
  <part name="mes" type="xsd:integer" />
  <part name="dia" type="xsd:integer" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getContactosResponse">
  <part name="return" type="tns:listadocontactos" /></message>
<message name="getDatosEmpresaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getDatosEmpresaResponse">
  <part name="return" type="tns:listadodatosempresa" /></message>
<message name="getPlazaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getPlazaResponse">
  <part name="return" type="tns:listadodatosplaza" /></message>
<message name="getLicenciaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="licencia" type="xsd:string" /></message>
<message name="getLicenciaResponse">
  <part name="return" type="tns:listadodatoslicencia" /></message>
<message name="getFacturaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa_id" type="xsd:integer" />
  <part name="documento_id" type="xsd:integer" /></message>
<message name="getFacturaResponse">
  <part name="return" type="tns:datos_factura" /></message>
<message name="setLicenciaActivaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="licencia" type="xsd:string" /></message>
<message name="setLicenciaActivaResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getGruposProductosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="ultimo_id" type="xsd:integer" />
  <part name="numero_registros" type="xsd:integer" /></message>
<message name="getGruposProductosResponse">
  <part name="return" type="tns:listadogruposproductos" /></message>
<message name="getGrupoAlmacenRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getGrupoAlmacenResponse">
  <part name="return" type="tns:listadogrupoalmacen" /></message>
<message name="getEmpleadosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getEmpleadosResponse">
  <part name="return" type="tns:listadoempleados" /></message>
<message name="GuardaBitacoraSincronizacionRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="fecha" type="xsd:string" />
  <part name="version" type="xsd:string" />
  <part name="plaza" type="xsd:integer" />
  <part name="licencia" type="xsd:string" /></message>
<message name="GuardaBitacoraSincronizacionResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="venta" type="xsd:integer" /></message>
<message name="getVentaResponse">
  <part name="return" type="tns:listadoventas" /></message>
<message name="getVentaFiltradaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="venta" type="xsd:string" />
  <part name="moneda" type="xsd:string" />
  <part name="nombre" type="xsd:string" />
  <part name="tipoPago" type="xsd:string" />
  <part name="fechainicial" type="xsd:string" />
  <part name="fechafinal" type="xsd:string" />
  <part name="tipoVenta" type="xsd:string" />
  <part name="estatus" type="xsd:string" />
  <part name="rfcCliente" type="xsd:string" />
  <part name="codigoTransaccion" type="xsd:string" />
  <part name="plaza" type="xsd:integer" />
  <part name="cliente_asociado_id" type="xsd:integer" />
  <part name="agente_asociado_id" type="xsd:integer" />
  <part name="fecha_cancelacion_inicial" type="xsd:date" />
  <part name="fecha_cancelacion_final" type="xsd:date" /></message>
<message name="getVentaFiltradaResponse">
  <part name="return" type="tns:listadoventasfiltradas" /></message>
<message name="setProveedoresRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="proveedor" type="tns:proveedor" /></message>
<message name="setProveedoresResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setClientesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="cliente" type="tns:cliente" /></message>
<message name="setClientesResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setDireccionesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="direccion" type="tns:direccion" /></message>
<message name="setDireccionesResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setContactosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="contacto" type="tns:contacto" /></message>
<message name="setContactosResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="obtenerSiguienteProveedorRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="obtenerSiguienteProveedorResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="obtenerSiguienteClienteRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="obtenerSiguienteClienteResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="obtenerPedidosVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="parametros" type="tns:parametrosReportePedidosVenta" /></message>
<message name="obtenerPedidosVentaResponse">
  <part name="return" type="tns:listadoPedidosVenta" /></message>
<message name="getExistenciasDisponiblesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="almacen_id" type="xsd:integer" />
  <part name="productos_ids" type="tns:productos_ids" /></message>
<message name="getExistenciasDisponiblesResponse">
  <part name="return" type="tns:existencias_disponibles" /></message>
<message name="setClientePosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="cliente" type="tns:asociado" /></message>
<message name="setClientePosResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setProductoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="producto" type="tns:nuevo_producto" /></message>
<message name="setProductoResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setGrupoProductoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="grupo_producto" type="tns:nuevo_grupo_producto" /></message>
<message name="setGrupoProductoResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setUnidadMedidaProductoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="unidad_medida_producto" type="tns:nueva_unidad_medida_producto" /></message>
<message name="setUnidadMedidaProductoResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="setCobrosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="cobros" type="tns:aplicacioncobro" /></message>
<message name="setCobrosResponse">
  <part name="return" type="tns:responseaplicacioncobros" /></message>
<message name="setAbonoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="abonos" type="tns:listadoabonoaplicar" /></message>
<message name="setAbonoResponse">
  <part name="return" type="tns:responseabonosaplicados" /></message>
<message name="setAdjuntaArchivoVentaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="documentos" type="tns:documentosarchivoadjunto" />
  <part name="archivo" type="xsd:string" />
  <part name="nombre_archivo" type="xsd:string" /></message>
<message name="setAdjuntaArchivoVentaResponse">
  <part name="return" type="tns:respuesta" /></message>
<message name="getSaldoAsociadoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="asociado" type="xsd:integer" />
  <part name="texto_adicional_1" type="xsd:string" />
  <part name="fecha_inicio" type="xsd:string" />
  <part name="fecha_fin" type="xsd:string" />
  <part name="detalle" type="xsd:string" /></message>
<message name="getSaldoAsociadoResponse">
  <part name="return" type="tns:responsecreditocliente" /></message>
<message name="getPromocionesPosRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="fecha_inicio" type="xsd:string" />
  <part name="fecha_fin" type="xsd:string" /></message>
<message name="getPromocionesPosResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getPaisSatRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getPaisSatResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCveTransporteRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCveTransporteResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getEstacionesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getEstacionesResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoEstacionRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoEstacionResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getClaveUnidadPesoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getClaveUnidadPesoResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getClaveProdServCPRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getClaveProdServCPResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getMaterialPeligrosoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getMaterialPeligrosoResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoEmbalajeRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoEmbalajeResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getFraccionArancelariaSatRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getFraccionArancelariaSatResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoPermisoSCTRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoPermisoSCTResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getConfigAutotransporteRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getConfigAutotransporteResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoRemolqueRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoRemolqueResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoEmbarcacionRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoEmbarcacionResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoCargaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoCargaResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getNumeroAutorizacionNavieroRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getNumeroAutorizacionNavieroResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getContenedorMaritimoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getContenedorMaritimoResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getParteTransporteRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getParteTransporteResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCodigoTransporteAereoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCodigoTransporteAereoResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoServicioRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoServicioResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoTraficoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoTraficoResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoDerechoPasoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoDerechoPasoResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoCarroRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoCarroResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoContenedorRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoContenedorResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getTipoCobroRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoCobroResponse">
  <part name="return" type="tns:listadotiposcobro" /></message>
<message name="getTipoNotaCreditoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getTipoNotaCreditoResponse">
  <part name="return" type="tns:listadotiposnotacredito" /></message>
<message name="getCuentaContableRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCuentaContableResponse">
  <part name="return" type="tns:listadocuentacontable" /></message>
<message name="getCartaPorteRegimenAduaneroRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCartaPorteRegimenAduaneroResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCartaPorteRegistroIstmoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCartaPorteRegistroIstmoResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCartaPorteSectorCOFEPRISRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCartaPorteSectorCOFEPRISResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCartaPorteFormaFarmaceuticaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCartaPorteFormaFarmaceuticaResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCartaPorteCondicionesEspecialesRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCartaPorteCondicionesEspecialesResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCartaPorteTipoMateriaRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCartaPorteTipoMateriaResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="getCartaPorteDocumentoAduaneroRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" /></message>
<message name="getCartaPorteDocumentoAduaneroResponse">
  <part name="return" type="xsd:Array" /></message>
<message name="setNotaCreditoDescuentoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="notacredito" type="tns:notacredito" /></message>
<message name="setNotaCreditoDescuentoResponse">
  <part name="return" type="tns:respuestanotacredito" /></message>
<message name="setCancelaNotaCreditoRequest">
  <part name="usuario" type="xsd:string" />
  <part name="password" type="xsd:string" />
  <part name="empresa" type="xsd:integer" />
  <part name="plaza" type="xsd:integer" />
  <part name="documento_id" type="xsd:integer" />
  <part name="tiponotacredito" type="xsd:integer" />
  <part name="serie" type="xsd:string" />
  <part name="folio" type="xsd:integer" /></message>
<message name="setCancelaNotaCreditoResponse">
  <part name="return" type="tns:respuesta" /></message>
<portType name="ComprobantesFiscalesPortType">
  <operation name="getEstatusCancelacionVenta">
    <documentation>Obtener listado de los estatus de cancelacion de ventas</documentation>
    <input message="tns:getEstatusCancelacionVentaRequest"/>
    <output message="tns:getEstatusCancelacionVentaResponse"/>
  </operation>
  <operation name="getSaldosCliente">
    <documentation>Obtencion de saldos de cliente por plaza</documentation>
    <input message="tns:getSaldosClienteRequest"/>
    <output message="tns:getSaldosClienteResponse"/>
  </operation>
  <operation name="setGeneraVenta">
    <documentation>Volver a mensaje Hola Mundo</documentation>
    <input message="tns:setGeneraVentaRequest"/>
    <output message="tns:setGeneraVentaResponse"/>
  </operation>
  <operation name="setTerminarDocumentoVenta">
    <documentation>Volver a sellar e documento</documentation>
    <input message="tns:setTerminarDocumentoVentaRequest"/>
    <output message="tns:setTerminarDocumentoVentaResponse"/>
  </operation>
  <operation name="setAutenticacion">
    <documentation>Autenticacion de usuario</documentation>
    <input message="tns:setAutenticacionRequest"/>
    <output message="tns:setAutenticacionResponse"/>
  </operation>
  <operation name="setGeneraDocumentoVenta">
    <documentation>Generar CFD</documentation>
    <input message="tns:setGeneraDocumentoVentaRequest"/>
    <output message="tns:setGeneraDocumentoVentaResponse"/>
  </operation>
  <operation name="setGeneraDocumentoVentaPos">
    <documentation>Generar CFD</documentation>
    <input message="tns:setGeneraDocumentoVentaPosRequest"/>
    <output message="tns:setGeneraDocumentoVentaPosResponse"/>
  </operation>
  <operation name="setGeneraPosVenta">
    <documentation>Generar CFD</documentation>
    <input message="tns:setGeneraPosVentaRequest"/>
    <output message="tns:setGeneraPosVentaResponse"/>
  </operation>
  <operation name="getEstatusVentaPos">
    <documentation>Generar CFD</documentation>
    <input message="tns:getEstatusVentaPosRequest"/>
    <output message="tns:getEstatusVentaPosResponse"/>
  </operation>
  <operation name="setGeneraCartaPorte">
    <documentation>Generar Carta Porte</documentation>
    <input message="tns:setGeneraCartaPorteRequest"/>
    <output message="tns:setGeneraCartaPorteResponse"/>
  </operation>
  <operation name="setReenviodeCorreoDocumentoVenta">
    <documentation>Envio de CFD por correo</documentation>
    <input message="tns:setReenviodeCorreoDocumentoVentaRequest"/>
    <output message="tns:setReenviodeCorreoDocumentoVentaResponse"/>
  </operation>
  <operation name="SetCancelaDocumentoVenta">
    <documentation>Cancelar CFD</documentation>
    <input message="tns:SetCancelaDocumentoVentaRequest"/>
    <output message="tns:SetCancelaDocumentoVentaResponse"/>
  </operation>
  <operation name="SetCancelaDocumentoVentaCFD">
    <documentation>Cancelar CFDI</documentation>
    <input message="tns:SetCancelaDocumentoVentaCFDRequest"/>
    <output message="tns:SetCancelaDocumentoVentaCFDResponse"/>
  </operation>
  <operation name="setListaPrecio">
    <documentation>Guardar lista precio</documentation>
    <input message="tns:setListaPrecioRequest"/>
    <output message="tns:setListaPrecioResponse"/>
  </operation>
  <operation name="setAlmacenProducto">
    <documentation>Guardar lista precio</documentation>
    <input message="tns:setAlmacenProductoRequest"/>
    <output message="tns:setAlmacenProductoResponse"/>
  </operation>
  <operation name="getComprobantePDF">
    <documentation>Descargar CFD en format PDF</documentation>
    <input message="tns:getComprobantePDFRequest"/>
    <output message="tns:getComprobantePDFResponse"/>
  </operation>
  <operation name="getComprobanteXML">
    <documentation>Descargar CFD en format XML</documentation>
    <input message="tns:getComprobanteXMLRequest"/>
    <output message="tns:getComprobanteXMLResponse"/>
  </operation>
  <operation name="getReporteMensualCFD">
    <documentation>Descargar Reporte mensual Existente</documentation>
    <input message="tns:getReporteMensualCFDRequest"/>
    <output message="tns:getReporteMensualCFDResponse"/>
  </operation>
  <operation name="setGeneraReporteMensualdeCFD">
    <documentation>Generar Reporte mensual Existente</documentation>
    <input message="tns:setGeneraReporteMensualdeCFDRequest"/>
    <output message="tns:setGeneraReporteMensualdeCFDResponse"/>
  </operation>
  <operation name="getClientes">
    <documentation>Obtener Listado de Clientes</documentation>
    <input message="tns:getClientesRequest"/>
    <output message="tns:getClientesResponse"/>
  </operation>
  <operation name="getAsociados">
    <documentation>Obtener Listado de Asociados</documentation>
    <input message="tns:getAsociadosRequest"/>
    <output message="tns:getAsociadosResponse"/>
  </operation>
  <operation name="getDocumentoProduccion">
    <documentation>Obtener Listado de Documentos de Producción</documentation>
    <input message="tns:getDocumentoProduccionRequest"/>
    <output message="tns:getDocumentoProduccionResponse"/>
  </operation>
  <operation name="getCentroCosto">
    <documentation>Obtener Listado de Centro de Costo por Empresa</documentation>
    <input message="tns:getCentroCostoRequest"/>
    <output message="tns:getCentroCostoResponse"/>
  </operation>
  <operation name="getAgentes">
    <documentation>Obtener Listado de Agentes</documentation>
    <input message="tns:getAgentesRequest"/>
    <output message="tns:getAgentesResponse"/>
  </operation>
  <operation name="getProveedores">
    <documentation>Obtener Listado de Proveedores</documentation>
    <input message="tns:getProveedoresRequest"/>
    <output message="tns:getProveedoresResponse"/>
  </operation>
  <operation name="getClienteByRfc">
    <documentation>Obtener Cliente por rfc</documentation>
    <input message="tns:getClienteByRfcRequest"/>
    <output message="tns:getClienteByRfcResponse"/>
  </operation>
  <operation name="getDirecciones">
    <documentation>Obtener Listado de Direcciones</documentation>
    <input message="tns:getDireccionesRequest"/>
    <output message="tns:getDireccionesResponse"/>
  </operation>
  <operation name="getAlmacenes">
    <documentation>Obtener Listado de Almacenes</documentation>
    <input message="tns:getAlmacenesRequest"/>
    <output message="tns:getAlmacenesResponse"/>
  </operation>
  <operation name="getUnidadesMedida">
    <documentation>Obtener Listado de Productos</documentation>
    <input message="tns:getUnidadesMedidaRequest"/>
    <output message="tns:getUnidadesMedidaResponse"/>
  </operation>
  <operation name="getSeriesProducto">
    <documentation>Obtener Listado de Productos</documentation>
    <input message="tns:getSeriesProductoRequest"/>
    <output message="tns:getSeriesProductoResponse"/>
  </operation>
  <operation name="getComponentesKits">
    <documentation>Obtener Listado de Productos</documentation>
    <input message="tns:getComponentesKitsRequest"/>
    <output message="tns:getComponentesKitsResponse"/>
  </operation>
  <operation name="getProductos">
    <documentation>Obtener Listado de Productos</documentation>
    <input message="tns:getProductosRequest"/>
    <output message="tns:getProductosResponse"/>
  </operation>
  <operation name="getProductosRuta">
    <documentation>Obtener Listado de Productos</documentation>
    <input message="tns:getProductosRutaRequest"/>
    <output message="tns:getProductosRutaResponse"/>
  </operation>
  <operation name="getListaPrecios">
    <documentation>Obtener Listado de Precios</documentation>
    <input message="tns:getListaPreciosRequest"/>
    <output message="tns:getListaPreciosResponse"/>
  </operation>
  <operation name="getListaPrecioPorPlaza">
    <documentation>Obtener Listado de Precios por Plaza</documentation>
    <input message="tns:getListaPrecioPorPlazaRequest"/>
    <output message="tns:getListaPrecioPorPlazaResponse"/>
  </operation>
  <operation name="getExistencias">
    <documentation>Obtener Listado de Existencias por Bodega y Producto</documentation>
    <input message="tns:getExistenciasRequest"/>
    <output message="tns:getExistenciasResponse"/>
  </operation>
  <operation name="getFormasDePago">
    <documentation>Obtener Listado de Formas de Pago de la Empresa</documentation>
    <input message="tns:getFormasDePagoRequest"/>
    <output message="tns:getFormasDePagoResponse"/>
  </operation>
  <operation name="getTipoRelacion">
    <documentation>Obtener catalogo del SAT de Tipo de Relacion</documentation>
    <input message="tns:getTipoRelacionRequest"/>
    <output message="tns:getTipoRelacionResponse"/>
  </operation>
  <operation name="getUsoCfdi">
    <documentation>Obtener catalogo del SAT de uso de CFDI</documentation>
    <input message="tns:getUsoCfdiRequest"/>
    <output message="tns:getUsoCfdiResponse"/>
  </operation>
  <operation name="getImpuestoDetalle">
    <documentation>Obtener catalogo de impuesto detalle</documentation>
    <input message="tns:getImpuestoDetalleRequest"/>
    <output message="tns:getImpuestoDetalleResponse"/>
  </operation>
  <operation name="getClaveProductoServicio">
    <documentation>Obtener catalogo de productos servicios del SAT</documentation>
    <input message="tns:getClaveProductoServicioRequest"/>
    <output message="tns:getClaveProductoServicioResponse"/>
  </operation>
  <operation name="getMetodoPagoSat">
    <documentation>Obtener catalogo de metodos de pago del SAT</documentation>
    <input message="tns:getMetodoPagoSatRequest"/>
    <output message="tns:getMetodoPagoSatResponse"/>
  </operation>
  <operation name="getUnidadMedidaSat">
    <documentation>Obtener catalogo de unidades de medida del SAT</documentation>
    <input message="tns:getUnidadMedidaSatRequest"/>
    <output message="tns:getUnidadMedidaSatResponse"/>
  </operation>
  <operation name="getTiposNotaCredito">
    <documentation>Obtener Listado de Tipos de Nota de Credito</documentation>
    <input message="tns:getTiposNotaCreditoRequest"/>
    <output message="tns:getTiposNotaCreditoResponse"/>
  </operation>
  <operation name="getTiposVenta">
    <documentation>Obtener Listado de Tipos de Venta</documentation>
    <input message="tns:getTiposVentaRequest"/>
    <output message="tns:getTiposVentaResponse"/>
  </operation>
  <operation name="getSeriesTiposVenta">
    <documentation>Obtener Series de los Tipos de Venta</documentation>
    <input message="tns:getSeriesTiposVentaRequest"/>
    <output message="tns:getSeriesTiposVentaResponse"/>
  </operation>
  <operation name="getEmpresa">
    <documentation>Obtener Empresa</documentation>
    <input message="tns:getEmpresaRequest"/>
    <output message="tns:getEmpresaResponse"/>
  </operation>
  <operation name="getSeriesConsecutivos">
    <documentation>obtener series de consecutivo por empresa</documentation>
    <input message="tns:getSeriesConsecutivosRequest"/>
    <output message="tns:getSeriesConsecutivosResponse"/>
  </operation>
  <operation name="getContactos">
    <documentation>obtener todos los contactos de todos los asociados de una empresa</documentation>
    <input message="tns:getContactosRequest"/>
    <output message="tns:getContactosResponse"/>
  </operation>
  <operation name="getDatosEmpresa">
    <documentation>obtener datos de la empresa e imagen base 64</documentation>
    <input message="tns:getDatosEmpresaRequest"/>
    <output message="tns:getDatosEmpresaResponse"/>
  </operation>
  <operation name="getPlaza">
    <documentation>obtener las plazas de la empresa</documentation>
    <input message="tns:getPlazaRequest"/>
    <output message="tns:getPlazaResponse"/>
  </operation>
  <operation name="getLicencia">
    <documentation>valida que exista la licencia y si la licencia esta activa o no</documentation>
    <input message="tns:getLicenciaRequest"/>
    <output message="tns:getLicenciaResponse"/>
  </operation>
  <operation name="getFactura">
    <documentation>Obtener la factura de un documento</documentation>
    <input message="tns:getFacturaRequest"/>
    <output message="tns:getFacturaResponse"/>
  </operation>
  <operation name="setLicenciaActiva">
    <documentation>Activa la licencia cuando se asigna a un POS</documentation>
    <input message="tns:setLicenciaActivaRequest"/>
    <output message="tns:setLicenciaActivaResponse"/>
  </operation>
  <operation name="getGruposProductos">
    <documentation>obtener los grupos de productos de una empresa</documentation>
    <input message="tns:getGruposProductosRequest"/>
    <output message="tns:getGruposProductosResponse"/>
  </operation>
  <operation name="getGrupoAlmacen">
    <documentation>obtener los grupos de almacen de una empresa</documentation>
    <input message="tns:getGrupoAlmacenRequest"/>
    <output message="tns:getGrupoAlmacenResponse"/>
  </operation>
  <operation name="getEmpleados">
    <documentation>obtener los empleados de una empresa</documentation>
    <input message="tns:getEmpleadosRequest"/>
    <output message="tns:getEmpleadosResponse"/>
  </operation>
  <operation name="GuardaBitacoraSincronizacion">
    <documentation>Guarda bitacora de acceso</documentation>
    <input message="tns:GuardaBitacoraSincronizacionRequest"/>
    <output message="tns:GuardaBitacoraSincronizacionResponse"/>
  </operation>
  <operation name="getVenta">
    <documentation>obtener una venta y sus detalles por venta id</documentation>
    <input message="tns:getVentaRequest"/>
    <output message="tns:getVentaResponse"/>
  </operation>
  <operation name="getVentaFiltrada">
    <documentation>obtener una venta y sus detalles por venta id</documentation>
    <input message="tns:getVentaFiltradaRequest"/>
    <output message="tns:getVentaFiltradaResponse"/>
  </operation>
  <operation name="setProveedores">
    <documentation>registro o actualizacion de proveedores</documentation>
    <input message="tns:setProveedoresRequest"/>
    <output message="tns:setProveedoresResponse"/>
  </operation>
  <operation name="setClientes">
    <documentation>registro o actualizacion de lientes</documentation>
    <input message="tns:setClientesRequest"/>
    <output message="tns:setClientesResponse"/>
  </operation>
  <operation name="setDirecciones">
    <documentation>registro o actualizacion de direcciones</documentation>
    <input message="tns:setDireccionesRequest"/>
    <output message="tns:setDireccionesResponse"/>
  </operation>
  <operation name="setContactos">
    <documentation>registro o actualizacion de contactos</documentation>
    <input message="tns:setContactosRequest"/>
    <output message="tns:setContactosResponse"/>
  </operation>
  <operation name="obtenerSiguienteProveedor">
    <documentation>obtiene el siguiente numero de proveedor</documentation>
    <input message="tns:obtenerSiguienteProveedorRequest"/>
    <output message="tns:obtenerSiguienteProveedorResponse"/>
  </operation>
  <operation name="obtenerSiguienteCliente">
    <documentation>obtiene el siguiente numero de cliente</documentation>
    <input message="tns:obtenerSiguienteClienteRequest"/>
    <output message="tns:obtenerSiguienteClienteResponse"/>
  </operation>
  <operation name="obtenerPedidosVenta">
    <documentation>Obtener listado de los datos del reporte Pedidos de Documentos de Venta</documentation>
    <input message="tns:obtenerPedidosVentaRequest"/>
    <output message="tns:obtenerPedidosVentaResponse"/>
  </operation>
  <operation name="getExistenciasDisponibles">
    <documentation>Obtener listado de los estatus de las solicitudes de cancelación de venta</documentation>
    <input message="tns:getExistenciasDisponiblesRequest"/>
    <output message="tns:getExistenciasDisponiblesResponse"/>
  </operation>
  <operation name="setClientePos">
    <documentation>registro o actualizacion de clientes del punto de venta</documentation>
    <input message="tns:setClientePosRequest"/>
    <output message="tns:setClientePosResponse"/>
  </operation>
  <operation name="setProducto">
    <documentation>registro de producto del punto de venta</documentation>
    <input message="tns:setProductoRequest"/>
    <output message="tns:setProductoResponse"/>
  </operation>
  <operation name="setGrupoProducto">
    <documentation>registro de grupo producto del punto de venta</documentation>
    <input message="tns:setGrupoProductoRequest"/>
    <output message="tns:setGrupoProductoResponse"/>
  </operation>
  <operation name="setUnidadMedidaProducto">
    <documentation>registro de unidad medida producto del punto de venta</documentation>
    <input message="tns:setUnidadMedidaProductoRequest"/>
    <output message="tns:setUnidadMedidaProductoResponse"/>
  </operation>
  <operation name="setCobros">
    <documentation>registro de cobros a clientes a sus documentos de venta</documentation>
    <input message="tns:setCobrosRequest"/>
    <output message="tns:setCobrosResponse"/>
  </operation>
  <operation name="setAbono">
    <documentation>registro de cobros a clientes con saldo pendiente en punto de venta</documentation>
    <input message="tns:setAbonoRequest"/>
    <output message="tns:setAbonoResponse"/>
  </operation>
  <operation name="setAdjuntaArchivoVenta">
    <documentation>adjuntar archivo a ventas</documentation>
    <input message="tns:setAdjuntaArchivoVentaRequest"/>
    <output message="tns:setAdjuntaArchivoVentaResponse"/>
  </operation>
  <operation name="getSaldoAsociado">
    <documentation>listado de saldo de ventas a crédito en punto de venta</documentation>
    <input message="tns:getSaldoAsociadoRequest"/>
    <output message="tns:getSaldoAsociadoResponse"/>
  </operation>
  <operation name="getPromocionesPos">
    <documentation>Obtener las promociones aplicables para la venta en POS</documentation>
    <input message="tns:getPromocionesPosRequest"/>
    <output message="tns:getPromocionesPosResponse"/>
  </operation>
  <operation name="getPaisSat">
    <documentation>Obtener catálogo de País publicado en el SAT</documentation>
    <input message="tns:getPaisSatRequest"/>
    <output message="tns:getPaisSatResponse"/>
  </operation>
  <operation name="getCveTransporte">
    <documentation>Obtener catálogo de Claves transporte SAT</documentation>
    <input message="tns:getCveTransporteRequest"/>
    <output message="tns:getCveTransporteResponse"/>
  </operation>
  <operation name="getEstaciones">
    <documentation>Obtener catálogo de Estaciones SAT</documentation>
    <input message="tns:getEstacionesRequest"/>
    <output message="tns:getEstacionesResponse"/>
  </operation>
  <operation name="getTipoEstacion">
    <documentation>Obtener catálogo de Tipo de Estaciones SAT</documentation>
    <input message="tns:getTipoEstacionRequest"/>
    <output message="tns:getTipoEstacionResponse"/>
  </operation>
  <operation name="getClaveUnidadPeso">
    <documentation>Obtener catálogo Claves de Unidad Peso SAT</documentation>
    <input message="tns:getClaveUnidadPesoRequest"/>
    <output message="tns:getClaveUnidadPesoResponse"/>
  </operation>
  <operation name="getClaveProdServCP">
    <documentation>Obtener catálogo Claves Producto Servicio CP SAT</documentation>
    <input message="tns:getClaveProdServCPRequest"/>
    <output message="tns:getClaveProdServCPResponse"/>
  </operation>
  <operation name="getMaterialPeligroso">
    <documentation>Obtener catálogo Claves Material Peligroso SAT</documentation>
    <input message="tns:getMaterialPeligrosoRequest"/>
    <output message="tns:getMaterialPeligrosoResponse"/>
  </operation>
  <operation name="getTipoEmbalaje">
    <documentation>Obtener catálogo Tipo Embalaje SAT</documentation>
    <input message="tns:getTipoEmbalajeRequest"/>
    <output message="tns:getTipoEmbalajeResponse"/>
  </operation>
  <operation name="getFraccionArancelariaSat">
    <documentation>Obtener catálogo Fracción Arancelaria SAT</documentation>
    <input message="tns:getFraccionArancelariaSatRequest"/>
    <output message="tns:getFraccionArancelariaSatResponse"/>
  </operation>
  <operation name="getTipoPermisoSCT">
    <documentation>Obtener catálogo Tipo permiso SCT SAT</documentation>
    <input message="tns:getTipoPermisoSCTRequest"/>
    <output message="tns:getTipoPermisoSCTResponse"/>
  </operation>
  <operation name="getConfigAutotransporte">
    <documentation>Obtener catálogo Configuración Autotransporte SAT</documentation>
    <input message="tns:getConfigAutotransporteRequest"/>
    <output message="tns:getConfigAutotransporteResponse"/>
  </operation>
  <operation name="getTipoRemolque">
    <documentation>Obtener catálogo Tipo Remolques SAT</documentation>
    <input message="tns:getTipoRemolqueRequest"/>
    <output message="tns:getTipoRemolqueResponse"/>
  </operation>
  <operation name="getTipoEmbarcacion">
    <documentation>Obtener catálogo Tipo Embarcación SAT</documentation>
    <input message="tns:getTipoEmbarcacionRequest"/>
    <output message="tns:getTipoEmbarcacionResponse"/>
  </operation>
  <operation name="getTipoCarga">
    <documentation>Obtener catálogo Tipo Carga SAT</documentation>
    <input message="tns:getTipoCargaRequest"/>
    <output message="tns:getTipoCargaResponse"/>
  </operation>
  <operation name="getNumeroAutorizacionNaviero">
    <documentation>Obtener catálogo Número de autorizacion Naviero SAT</documentation>
    <input message="tns:getNumeroAutorizacionNavieroRequest"/>
    <output message="tns:getNumeroAutorizacionNavieroResponse"/>
  </operation>
  <operation name="getContenedorMaritimo">
    <documentation>Obtener catálogo Contenedor Marítimo SAT</documentation>
    <input message="tns:getContenedorMaritimoRequest"/>
    <output message="tns:getContenedorMaritimoResponse"/>
  </operation>
  <operation name="getParteTransporte">
    <documentation>Obtener catálogo Parte del Transporte SAT</documentation>
    <input message="tns:getParteTransporteRequest"/>
    <output message="tns:getParteTransporteResponse"/>
  </operation>
  <operation name="getCodigoTransporteAereo">
    <documentation>Obtener catálogo Código de transporte aereo SAT</documentation>
    <input message="tns:getCodigoTransporteAereoRequest"/>
    <output message="tns:getCodigoTransporteAereoResponse"/>
  </operation>
  <operation name="getTipoServicio">
    <documentation>Obtener catálogo Tipo servicio SAT</documentation>
    <input message="tns:getTipoServicioRequest"/>
    <output message="tns:getTipoServicioResponse"/>
  </operation>
  <operation name="getTipoTrafico">
    <documentation>Obtener catálogo Tipo de tráfico SAT</documentation>
    <input message="tns:getTipoTraficoRequest"/>
    <output message="tns:getTipoTraficoResponse"/>
  </operation>
  <operation name="getTipoDerechoPaso">
    <documentation>Obtener catálogo Tipo derecho de paso SAT</documentation>
    <input message="tns:getTipoDerechoPasoRequest"/>
    <output message="tns:getTipoDerechoPasoResponse"/>
  </operation>
  <operation name="getTipoCarro">
    <documentation>Obtener catálogo Tipo carro SAT</documentation>
    <input message="tns:getTipoCarroRequest"/>
    <output message="tns:getTipoCarroResponse"/>
  </operation>
  <operation name="getTipoContenedor">
    <documentation>Obtener catálogo Tipo Contenedor SAT</documentation>
    <input message="tns:getTipoContenedorRequest"/>
    <output message="tns:getTipoContenedorResponse"/>
  </operation>
  <operation name="getTipoCobro">
    <documentation>Obtener catálogo Tipo de Cobro</documentation>
    <input message="tns:getTipoCobroRequest"/>
    <output message="tns:getTipoCobroResponse"/>
  </operation>
  <operation name="getTipoNotaCredito">
    <documentation>Obtener catálogo Tipo de nota de redito</documentation>
    <input message="tns:getTipoNotaCreditoRequest"/>
    <output message="tns:getTipoNotaCreditoResponse"/>
  </operation>
  <operation name="getCuentaContable">
    <documentation>Obtener catálogo Tipo de nota de redito</documentation>
    <input message="tns:getCuentaContableRequest"/>
    <output message="tns:getCuentaContableResponse"/>
  </operation>
  <operation name="getCartaPorteRegimenAduanero">
    <documentation>Obtener catálogo Régimen Aduanero SAT</documentation>
    <input message="tns:getCartaPorteRegimenAduaneroRequest"/>
    <output message="tns:getCartaPorteRegimenAduaneroResponse"/>
  </operation>
  <operation name="getCartaPorteRegistroIstmo">
    <documentation>Obtener catálogo Registro Istmo SAT</documentation>
    <input message="tns:getCartaPorteRegistroIstmoRequest"/>
    <output message="tns:getCartaPorteRegistroIstmoResponse"/>
  </operation>
  <operation name="getCartaPorteSectorCOFEPRIS">
    <documentation>Obtener catálogo Sector COFEPRIS SAT</documentation>
    <input message="tns:getCartaPorteSectorCOFEPRISRequest"/>
    <output message="tns:getCartaPorteSectorCOFEPRISResponse"/>
  </operation>
  <operation name="getCartaPorteFormaFarmaceutica">
    <documentation>Obtener catálogo Forma Farmaceutica SAT</documentation>
    <input message="tns:getCartaPorteFormaFarmaceuticaRequest"/>
    <output message="tns:getCartaPorteFormaFarmaceuticaResponse"/>
  </operation>
  <operation name="getCartaPorteCondicionesEspeciales">
    <documentation>Obtener catálogo Condiciones Especiales SAT</documentation>
    <input message="tns:getCartaPorteCondicionesEspecialesRequest"/>
    <output message="tns:getCartaPorteCondicionesEspecialesResponse"/>
  </operation>
  <operation name="getCartaPorteTipoMateria">
    <documentation>Obtener catálogo Tipo Material SAT</documentation>
    <input message="tns:getCartaPorteTipoMateriaRequest"/>
    <output message="tns:getCartaPorteTipoMateriaResponse"/>
  </operation>
  <operation name="getCartaPorteDocumentoAduanero">
    <documentation>Obtener catálogo Documento Aduanero SAT</documentation>
    <input message="tns:getCartaPorteDocumentoAduaneroRequest"/>
    <output message="tns:getCartaPorteDocumentoAduaneroResponse"/>
  </operation>
  <operation name="setNotaCreditoDescuento">
    <documentation>Generar Nota de Crédito de Descuento</documentation>
    <input message="tns:setNotaCreditoDescuentoRequest"/>
    <output message="tns:setNotaCreditoDescuentoResponse"/>
  </operation>
  <operation name="setCancelaNotaCredito">
    <documentation>Cancelar Nota de Crédito</documentation>
    <input message="tns:setCancelaNotaCreditoRequest"/>
    <output message="tns:setCancelaNotaCreditoResponse"/>
  </operation>
</portType>
<binding name="ComprobantesFiscalesBinding" type="tns:ComprobantesFiscalesPortType">
  <soap:binding style="rpc" transport="http://schemas.xmlsoap.org/soap/http"/>
  <operation name="getEstatusCancelacionVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getEstatusCancelacionVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getSaldosCliente">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getSaldosCliente" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setGeneraVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setGeneraVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setTerminarDocumentoVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setTerminarDocumentoVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setAutenticacion">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setAutenticacion" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setGeneraDocumentoVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setGeneraDocumentoVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setGeneraDocumentoVentaPos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setGeneraDocumentoVentaPos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setGeneraPosVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setGeneraPosVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getEstatusVentaPos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getEstatusVentaPos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setGeneraCartaPorte">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setGeneraCartaPorte" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setReenviodeCorreoDocumentoVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setReenviodeCorreoDocumentoVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="SetCancelaDocumentoVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/SetCancelaDocumentoVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="SetCancelaDocumentoVentaCFD">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/SetCancelaDocumentoVentaCFD" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setListaPrecio">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setListaPrecio" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setAlmacenProducto">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setAlmacenProducto" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getComprobantePDF">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getComprobantePDF" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getComprobanteXML">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getComprobanteXML" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getReporteMensualCFD">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getReporteMensualCFD" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setGeneraReporteMensualdeCFD">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setGeneraReporteMensualdeCFD" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getClientes">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getClientes" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getAsociados">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getAsociados" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getDocumentoProduccion">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getDocumentoProduccion" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCentroCosto">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCentroCosto" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getAgentes">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getAgentes" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getProveedores">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getProveedores" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getClienteByRfc">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getClienteByRfc" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getDirecciones">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getDirecciones" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getAlmacenes">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getAlmacenes" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getUnidadesMedida">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getUnidadesMedida" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getSeriesProducto">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getSeriesProducto" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getComponentesKits">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getComponentesKits" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getProductos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getProductos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getProductosRuta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getProductosRuta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getListaPrecios">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getListaPrecios" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getListaPrecioPorPlaza">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getListaPrecioPorPlaza" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getExistencias">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getExistencias" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getFormasDePago">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getFormasDePago" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoRelacion">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoRelacion" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getUsoCfdi">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getUsoCfdi" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getImpuestoDetalle">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getImpuestoDetalle" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getClaveProductoServicio">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getClaveProductoServicio" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getMetodoPagoSat">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getMetodoPagoSat" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getUnidadMedidaSat">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getUnidadMedidaSat" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTiposNotaCredito">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTiposNotaCredito" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTiposVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTiposVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getSeriesTiposVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getSeriesTiposVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getEmpresa">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getEmpresa" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getSeriesConsecutivos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getSeriesConsecutivos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getContactos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getContactos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getDatosEmpresa">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getDatosEmpresa" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getPlaza">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getPlaza" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getLicencia">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getLicencia" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getFactura">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getFactura" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setLicenciaActiva">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setLicenciaActiva" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getGruposProductos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getGruposProductos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getGrupoAlmacen">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getGrupoAlmacen" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getEmpleados">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getEmpleados" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="GuardaBitacoraSincronizacion">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/GuardaBitacoraSincronizacion" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getVentaFiltrada">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getVentaFiltrada" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setProveedores">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setProveedores" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setClientes">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setClientes" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setDirecciones">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setDirecciones" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setContactos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setContactos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="obtenerSiguienteProveedor">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/obtenerSiguienteProveedor" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="obtenerSiguienteCliente">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/obtenerSiguienteCliente" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="obtenerPedidosVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/obtenerPedidosVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getExistenciasDisponibles">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getExistenciasDisponibles" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setClientePos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setClientePos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setProducto">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setProducto" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setGrupoProducto">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setGrupoProducto" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setUnidadMedidaProducto">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setUnidadMedidaProducto" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setCobros">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setCobros" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setAbono">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setAbono" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setAdjuntaArchivoVenta">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setAdjuntaArchivoVenta" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getSaldoAsociado">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getSaldoAsociado" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getPromocionesPos">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getPromocionesPos" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getPaisSat">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getPaisSat" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCveTransporte">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCveTransporte" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getEstaciones">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getEstaciones" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoEstacion">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoEstacion" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getClaveUnidadPeso">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getClaveUnidadPeso" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getClaveProdServCP">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getClaveProdServCP" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getMaterialPeligroso">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getMaterialPeligroso" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoEmbalaje">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoEmbalaje" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getFraccionArancelariaSat">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getFraccionArancelariaSat" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoPermisoSCT">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoPermisoSCT" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getConfigAutotransporte">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getConfigAutotransporte" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoRemolque">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoRemolque" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoEmbarcacion">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoEmbarcacion" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoCarga">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoCarga" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getNumeroAutorizacionNaviero">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getNumeroAutorizacionNaviero" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getContenedorMaritimo">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getContenedorMaritimo" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getParteTransporte">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getParteTransporte" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCodigoTransporteAereo">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCodigoTransporteAereo" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoServicio">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoServicio" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoTrafico">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoTrafico" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoDerechoPaso">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoDerechoPaso" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoCarro">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoCarro" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoContenedor">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoContenedor" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoCobro">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoCobro" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getTipoNotaCredito">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getTipoNotaCredito" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCuentaContable">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCuentaContable" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCartaPorteRegimenAduanero">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCartaPorteRegimenAduanero" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCartaPorteRegistroIstmo">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCartaPorteRegistroIstmo" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCartaPorteSectorCOFEPRIS">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCartaPorteSectorCOFEPRIS" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCartaPorteFormaFarmaceutica">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCartaPorteFormaFarmaceutica" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCartaPorteCondicionesEspeciales">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCartaPorteCondicionesEspeciales" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCartaPorteTipoMateria">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCartaPorteTipoMateria" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="getCartaPorteDocumentoAduanero">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/getCartaPorteDocumentoAduanero" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setNotaCreditoDescuento">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setNotaCreditoDescuento" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
  <operation name="setCancelaNotaCredito">
    <soap:operation soapAction="http://www.clickbalance.net/click/wsCFD.php/setCancelaNotaCredito" style="rpc"/>
    <input><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></input>
    <output><soap:body use="encoded" namespace="http://cfd/services" encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"/></output>
  </operation>
</binding>
<service name="ComprobantesFiscales">
  <port name="ComprobantesFiscalesPort" binding="tns:ComprobantesFiscalesBinding">
    <soap:address location="http://www.clickbalance.net/click/wsCFD.php"/>
  </port>
</service>
</definitions>