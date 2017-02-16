
/**
 * ServiciosP1Skeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
    package org.example.www.serviciosp1;

import java.math.BigInteger;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.time.LocalDate;
import java.util.Date;

import javax.swing.JOptionPane;

import com.mysql.jdbc.jdbc2.optional.MysqlDataSource;

/**
     *  ServiciosP1Skeleton java skeleton for the axisService
     */
    public class ServiciosP1Skeleton{
    	
    	  //Comprobamos el SoapKey
          private boolean comprobarSoapKey(String soapKey) throws SQLException
          {
        	  try {
	        	  MySQL db = new MySQL();
	              db.MySQLConnect();
	              String query = "SELECT * FROM soapkey";
	              db.comando = db.conexion.createStatement();
	              db.registro = db.comando.executeQuery(query);
	              db.registro.next();
	              String soapkey = db.registro.getString(1);
	              
	              if (soapkey.equals(soapKey))
	              {
	            	  return true;
	              }
        	  } catch (SQLException e){ 
        		  throw new SQLException(); 
        	  }
        	  return false;
          }
          
          //Validar DNI
          public org.example.www.serviciosp1.ValidarDNIResponse validarDNI ( org.example.www.serviciosp1.ValidarDNI validarDNI) throws SQLException
      {
    	  ValidarDNIResponse valido = new ValidarDNIResponse();
    	  String dni = validarDNI.getDni();
    	  boolean esValido = false;
          int i = 0, caracterASCII = 0, miDNI = 0, resto = 0;
          char letra = ' ';
          char[] asignacionLetra = {'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X','B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};
    	  
          if(!comprobarSoapKey(validarDNI.getSoapKey()))
          {
        	  valido.setValido(false);
        	  return valido;
          }
          
          if(dni.length() == 9 && Character.isLetter(dni.charAt(8))) {
   
              do {
                  caracterASCII = dni.codePointAt(i);
                  esValido = (caracterASCII > 47 && caracterASCII < 58);
                  i++;
              } 
              while(i < dni.length() - 1 && esValido);     
          }
   
          if(esValido) {
              letra = Character.toUpperCase(dni.charAt(8));
              miDNI = Integer.parseInt(dni.substring(0,8));
              resto = miDNI % 23;
              esValido = (letra == asignacionLetra[resto]);
          }
         
          valido.setValido(esValido);
          return valido;
      	
      }
 
          //Validar IBAN
          public org.example.www.serviciosp1.ValidarIBANResponse validarIBAN (org.example.www.serviciosp1.ValidarIBAN validarIBAN) throws SQLException
    {
        	String cuenta = validarIBAN.getIban();
        	boolean esValido = false;
     		int i = 2, caracterASCII = 0, resto = 0, dc = 0;
     		String cadenaDc = "";
     		BigInteger cuentaNumero = new BigInteger("0"); 
     		BigInteger modo = new BigInteger("97");
     		ValidarIBANResponse valido = new ValidarIBANResponse();
     		
     		if(!comprobarSoapKey(validarIBAN.getSoapKey()))
  	        {
  	        	  valido.setValido(false);
  	        	  return valido;
  	        }
          

     		if(cuenta.length() == 24 && cuenta.substring(0,1).toUpperCase().equals("E") 
     			&& cuenta.substring(1,2).toUpperCase().equals("S")) {

     			do {
     				caracterASCII = cuenta.codePointAt(i);
     				esValido = (caracterASCII > 47 && caracterASCII < 58);
     				i++;
     			}
     			while(i < cuenta.length() && esValido); 
     		
     		
     			if(esValido) {
     				cuentaNumero = new BigInteger(cuenta.substring(4,24) + "142800");
     				resto = cuentaNumero.mod(modo).intValue();
     				dc = 98 - resto;
     				cadenaDc = String.valueOf(dc);
     			}	
     			
     			if(dc < 10) {
     				cadenaDc = "0" + cadenaDc;
     			} 

     			// Comparamos los caracteres 2 y 3 de la cuenta (dígito de control IBAN) con cadenaDc
     			if(cuenta.substring(2,4).equals(cadenaDc)) {
     				esValido = true;
     			} else {
     				esValido = false;
     			}
     		}
     		
     		
     		valido.setValido(esValido);
     		return valido;
    }
 
          //Solicitar Presupuesto
          public org.example.www.serviciosp1.SolicitarPresupuestoResponse solicitarPresupuesto(org.example.www.serviciosp1.SolicitarPresupuesto solicitarPresupuesto) throws SQLException
          {   
        	  SolicitarPresupuestoResponse response = new SolicitarPresupuestoResponse();
        	  float precioPieza = 0;
        	  boolean disp = false; 
        	  Date fechaDisp = new Date(0);
        	  String refPieza = solicitarPresupuesto.getRefPieza();
        	  int idProveedor = solicitarPresupuesto.getIdProveedor();
        	  
        	  if(!comprobarSoapKey(solicitarPresupuesto.getSoapKey()))
        	  {
        		  response.setDispPieza(disp);
        		  response.setFechaDispPieza(fechaDisp);
        		  response.setPrecioPieza(precioPieza);        		  
            	  return response;
        	  }
        	  
        	  try {
        		  MySQL db = new MySQL();
	              db.MySQLConnect();
	              String query = "SELECT * FROM producto where refPieza="+refPieza+" and idProveedor="+idProveedor;
	              db.comando = db.conexion.createStatement();
	              db.registro = db.comando.executeQuery(query);
	              if(db.registro.next()) {
		               precioPieza = db.registro.getFloat(4);
		               if(db.registro.getInt(5)>0)
			            	  disp = true;
		               fechaDisp = db.registro.getDate(3);
	              }
	              response.setPrecioPieza(precioPieza);
	              response.setDispPieza(disp);
	              response.setFechaDispPieza(fechaDisp);
	              return response; 
     
        	  } catch (SQLException e){
        		  throw new SQLException();
        	  }        	         	  
          }
      
          //generarPresuspuesto
          public org.example.www.serviciosp1.GenerarPresupuestoResponse generarPresupuesto(org.example.www.serviciosp1.GenerarPresupuesto p) throws SQLException
          {
        	  GenerarPresupuestoResponse response = new GenerarPresupuestoResponse();
        	  int idPresupuesto = 0; 
        	  boolean generado = false; 
        	  java.sql.Date fecha = new java.sql.Date(p.getFechaPresupuesto().getTime());  
        	  
        	  if(!comprobarSoapKey(p.getSoapKey()))
        	  {
        		  response.setIdPresupuesto(idPresupuesto);
        		  response.setPresupuestoGenerado(generado);
            	  return response;
        	  } 
        	  
        	  try {
        		  MySQL db = new MySQL();
	              db.MySQLConnect();
	              db.comando = db.conexion.createStatement(); 
	              String query = "INSERT INTO presupuestos (idCliente, refProducto, cantidadProd, fechaPresupuesto)"
	              		+ "VALUES ("+ p.getIdCliente()+",'"+ p.getReferenciaProd()+"',"+p.getCantidadProd()+",'"+fecha+"')";
	              int i = db.comando.executeUpdate(query);
	              
	              if(i != 0) {
	            	  db.registro = db.comando.executeQuery("SELECT idPresupuesto FROM presupuestos ORDER BY idPresupuesto DESC");
	            	  db.registro.next();
	            	  idPresupuesto = db.registro.getInt(1);
	            	  generado = true;
	              }
        		  response.setIdPresupuesto(idPresupuesto);
        		  response.setPresupuestoGenerado(generado);
        		  return response; 
        	  } catch(SQLException e) {
        		  JOptionPane.showMessageDialog(null, e.getMessage());
        		  throw new SQLException();
        	  }
          }
 
    
          //Consultar Codigo Postal
          public org.example.www.serviciosp1.ConsultaCPResponse consultaCP(org.example.www.serviciosp1.ConsultaCP consultaCP) throws SQLException
          {
        	  ConsultaCPResponse response = new ConsultaCPResponse();
        	  String codp = consultaCP.getCodp();
        	  String poblacion="No existe en la BBDD!"; 
        	  String provincia="No existe en la BBDD!";
        	  
        	  if(!comprobarSoapKey(consultaCP.getSoapKey()))
              {
        		  response.setCodPos("Error soapKey Incorrecto!");
        		  response.setPoblacion("Error!");
        		  response.setProvincia("Error!");
            	  return response;
              }
        	  
        	  try {
	        	  MySQL db = new MySQL();
	              db.MySQLConnect();
	              String query = "SELECT * FROM codigopostal where codigoPostal='"+codp+"'";
	              db.comando = db.conexion.createStatement();
	              db.registro = db.comando.executeQuery(query);
	              if(db.registro.next()){
		              db.registro.next();
		              provincia = db.registro.getString(1);
		              poblacion = db.registro.getString(2);
	              }
	              
        	  } catch (SQLException e){
        		  throw new SQLException();
        	  }
        	  
        	  response.setCodPos(codp);
        	  response.setPoblacion(poblacion);
        	  response.setProvincia(provincia);
        	  return response;
          }
     
    }
    