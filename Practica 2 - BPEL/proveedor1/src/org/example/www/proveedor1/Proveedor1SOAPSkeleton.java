/**
 * Proveedor1SOAPSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.example.www.proveedor1;

public class Proveedor1SOAPSkeleton implements org.example.www.proveedor1.Proveedor1_PortType, org.apache.axis.wsdl.Skeleton {
    private org.example.www.proveedor1.Proveedor1_PortType impl;
    private static java.util.Map _myOperations = new java.util.Hashtable();
    private static java.util.Collection _myOperationsList = new java.util.ArrayList();

    /**
    * Returns List of OperationDesc objects with this name
    */
    public static java.util.List getOperationDescByName(java.lang.String methodName) {
        return (java.util.List)_myOperations.get(methodName);
    }

    /**
    * Returns Collection of OperationDescs
    */
    public static java.util.Collection getOperationDescs() {
        return _myOperationsList;
    }

    static {
        org.apache.axis.description.OperationDesc _oper;
        org.apache.axis.description.FaultDesc _fault;
        org.apache.axis.description.ParameterDesc [] _params;
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "nUnidades"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "refProd"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("solicitarPresupuesto", _params, new javax.xml.namespace.QName("", "valor"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "float"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://www.example.org/proveedor1/", "SolicitarPresupuesto"));
        _oper.setSoapAction("http://www.example.org/proveedor1/SolicitarPresupuesto");
        _myOperationsList.add(_oper);
        if (_myOperations.get("solicitarPresupuesto") == null) {
            _myOperations.put("solicitarPresupuesto", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("solicitarPresupuesto")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "nUnidades"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "refProd"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("ordenarCompra", _params, new javax.xml.namespace.QName("", "valido"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://www.example.org/proveedor1/", "OrdenarCompra"));
        _oper.setSoapAction("http://www.example.org/proveedor1/OrdenarCompra");
        _myOperationsList.add(_oper);
        if (_myOperations.get("ordenarCompra") == null) {
            _myOperations.put("ordenarCompra", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("ordenarCompra")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "nUnidades"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "refProd"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("actualizarStock", _params, new javax.xml.namespace.QName("", "valido"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://www.example.org/proveedor1/", "ActualizarStock"));
        _oper.setSoapAction("http://www.example.org/proveedor1/ActualizarStock");
        _myOperationsList.add(_oper);
        if (_myOperations.get("actualizarStock") == null) {
            _myOperations.put("actualizarStock", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("actualizarStock")).add(_oper);
    }

    public Proveedor1SOAPSkeleton() {
        this.impl = new org.example.www.proveedor1.Proveedor1SOAPImpl();
    }

    public Proveedor1SOAPSkeleton(org.example.www.proveedor1.Proveedor1_PortType impl) {
        this.impl = impl;
    }
    public float solicitarPresupuesto(int nUnidades, java.lang.String refProd) throws java.rmi.RemoteException
    {
        float ret = impl.solicitarPresupuesto(nUnidades, refProd);
        return ret;
    }

    public boolean ordenarCompra(int nUnidades, java.lang.String refProd) throws java.rmi.RemoteException
    {
        boolean ret = impl.ordenarCompra(nUnidades, refProd);
        return ret;
    }

    public boolean actualizarStock(int nUnidades, java.lang.String refProd) throws java.rmi.RemoteException
    {
        boolean ret = impl.actualizarStock(nUnidades, refProd);
        return ret;
    }

}
