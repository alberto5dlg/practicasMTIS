package org.example.www.proveedor1;

import java.sql.SQLException;



public class Proveedor1Skeleton{
        
        public SolicitarPresupuestoResponse solicitarPresupuesto(SolicitarPresupuesto solicitarPresupuesto) throws SQLException
        {
        	SolicitarPresupuestoResponse response = new SolicitarPresupuestoResponse();
        	try { 
        		MySQL db = new MySQL();
	            db.MySQLConnect();
	            String query ="SELECT * FROM articulos WHERE refProd='"+solicitarPresupuesto.getRefProd() +"'";
	            db.comando = db.conexion.createStatement();
	            db.registro = db.comando.executeQuery(query);
	            if(db.registro.next()){ 
	            	float total = solicitarPresupuesto.getNUnidades() * db.registro.getFloat(2);
	            	response.setValor(total);
	            }
        	} catch (SQLException e){
        		throw new SQLException();
        	}
        	return response; 
        }
     
        public ActualizarStockResponse actualizarStock(ActualizarStock actualizarStock) throws SQLException
        {
        	ActualizarStockResponse response = new ActualizarStockResponse();
    		response.setValido(false);
    		int cantidad = 0; 
    		try{
    			MySQL db = new MySQL();
	            db.MySQLConnect();
	            String query = "SELECT * FROM articulos WHERE refProd='"+actualizarStock.getRefProd()+"'";
	            db.comando = db.conexion.createStatement();
	            db.registro = db.comando.executeQuery(query);
	            if(db.registro.next()){
	            	cantidad = db.registro.getInt(3);
	            }
	            int total = cantidad - actualizarStock.getNUnidades();
	            query ="UPDATE articulos SET stock="+total+" WHERE refProd='"+actualizarStock.getRefProd()+"'";
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
    
        public OrdenarCompraResponse ordenarCompra(OrdenarCompra ordenarCompra)
        {
        	OrdenarCompraResponse response = new OrdenarCompraResponse();
        	response.setValido(true);        	
        	return response;      
        }
     
    }
    