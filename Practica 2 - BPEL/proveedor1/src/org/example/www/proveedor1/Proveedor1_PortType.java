/**
 * Proveedor1_PortType.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.example.www.proveedor1;

public interface Proveedor1_PortType extends java.rmi.Remote {
    public float solicitarPresupuesto(int nUnidades, java.lang.String refProd) throws java.rmi.RemoteException;
    public boolean ordenarCompra(int nUnidades, java.lang.String refProd) throws java.rmi.RemoteException;
    public boolean actualizarStock(int nUnidades, java.lang.String refProd) throws java.rmi.RemoteException;
}
