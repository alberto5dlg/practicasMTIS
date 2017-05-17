    package org.example.www.gestionalmacen;

import java.sql.SQLException;

public class GestionAlmacenSkeleton{
    	
    	
        
    	public org.example.www.gestionalmacen.ComprobarStockResponse comprobarStock(org.example.www.gestionalmacen.ComprobarStock comprobarStock) throws SQLException
        {
    		ComprobarStockResponse response = new ComprobarStockResponse();
    		response.setExiste(false);
    		try{
    			MySQL db = new MySQL();
	            db.MySQLConnect();
	            String query ="SELECT * FROM productos WHERE refProd='"+comprobarStock.getRefProd() +"'";
	            db.comando = db.conexion.createStatement();
	            db.registro = db.comando.executeQuery(query);
	            if(db.registro.next()){ 
	            	if(comprobarStock.getNUnidades() <= db.registro.getInt(2))
	            		response.setExiste(true);
	            }
    			
    		} catch (SQLException e){
      		  throw new SQLException();
      	  }
            return response; 
        }
     
    	public org.example.www.gestionalmacen.ActualizarStockResponse actualizarStock(org.example.www.gestionalmacen.ActualizarStock actualizarStock) throws SQLException
        {
    		ActualizarStockResponse response = new ActualizarStockResponse();
    		response.setValido(false);
    		int cantidad = 0; 
    		try{
    			MySQL db = new MySQL();
	            db.MySQLConnect();
	            String query = "SELECT * FROM productos WHERE refProd='"+actualizarStock.getRefProd()+"'";
	            db.comando = db.conexion.createStatement();
	            db.registro = db.comando.executeQuery(query);
	            if(db.registro.next()){
	            	cantidad = db.registro.getInt(2);
	            }
	            int total = cantidad - actualizarStock.getNUnidades();
	            query ="UPDATE productos SET cantidad="+total+" WHERE refProd='"+actualizarStock.getRefProd()+"'";
	            int i = db.comando.executeUpdate(query);
	            if(i != 0) {
	            	response.setValido(true); 
	            }
    		} catch (SQLException e){
    			System.out.println(e.getMessage());
      		  throw new SQLException();
      	  }
    		
            return response; 
        }
     
    }
    