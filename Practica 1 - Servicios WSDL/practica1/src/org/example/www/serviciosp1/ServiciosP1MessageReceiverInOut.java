
/**
 * ServiciosP1MessageReceiverInOut.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
        package org.example.www.serviciosp1;

        /**
        *  ServiciosP1MessageReceiverInOut message receiver
        */

        public class ServiciosP1MessageReceiverInOut extends org.apache.axis2.receivers.AbstractInOutMessageReceiver{


        public void invokeBusinessLogic(org.apache.axis2.context.MessageContext msgContext, org.apache.axis2.context.MessageContext newMsgContext)
        throws org.apache.axis2.AxisFault{

        try {

        // get the implementation class for the Web Service
        Object obj = getTheImplementationObject(msgContext);

        ServiciosP1Skeleton skel = (ServiciosP1Skeleton)obj;
        //Out Envelop
        org.apache.axiom.soap.SOAPEnvelope envelope = null;
        //Find the axisOperation that has been set by the Dispatch phase.
        org.apache.axis2.description.AxisOperation op = msgContext.getOperationContext().getAxisOperation();
        if (op == null) {
        throw new org.apache.axis2.AxisFault("Operation is not located, if this is doclit style the SOAP-ACTION should specified via the SOAP Action to use the RawXMLProvider");
        }

        java.lang.String methodName;
        if((op.getName() != null) && ((methodName = org.apache.axis2.util.JavaUtils.xmlNameToJavaIdentifier(op.getName().getLocalPart())) != null)){


        

            if("validarDNI".equals(methodName)){
                
                org.example.www.serviciosp1.ValidarDNIResponse validarDNIResponse21 = null;
	                        org.example.www.serviciosp1.ValidarDNI wrappedParam =
                                                             (org.example.www.serviciosp1.ValidarDNI)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.serviciosp1.ValidarDNI.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               validarDNIResponse21 =
                                                   
                                                   
                                                         skel.validarDNI(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), validarDNIResponse21, false, new javax.xml.namespace.QName("http://www.example.org/serviciosP1/",
                                                    "validarDNI"));
                                    } else 

            if("validarIBAN".equals(methodName)){
                
                org.example.www.serviciosp1.ValidarIBANResponse validarIBANResponse23 = null;
	                        org.example.www.serviciosp1.ValidarIBAN wrappedParam =
                                                             (org.example.www.serviciosp1.ValidarIBAN)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.serviciosp1.ValidarIBAN.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               validarIBANResponse23 =
                                                   
                                                   
                                                         skel.validarIBAN(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), validarIBANResponse23, false, new javax.xml.namespace.QName("http://www.example.org/serviciosP1/",
                                                    "validarIBAN"));
                                    } else 

            if("solicitarPresupuesto".equals(methodName)){
                
                org.example.www.serviciosp1.SolicitarPresupuestoResponse solicitarPresupuestoResponse25 = null;
	                        org.example.www.serviciosp1.SolicitarPresupuesto wrappedParam =
                                                             (org.example.www.serviciosp1.SolicitarPresupuesto)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.serviciosp1.SolicitarPresupuesto.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               solicitarPresupuestoResponse25 =
                                                   
                                                   
                                                         skel.solicitarPresupuesto(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), solicitarPresupuestoResponse25, false, new javax.xml.namespace.QName("http://www.example.org/serviciosP1/",
                                                    "solicitarPresupuesto"));
                                    } else 

            if("generarPresupuesto".equals(methodName)){
                
                org.example.www.serviciosp1.GenerarPresupuestoResponse generarPresupuestoResponse27 = null;
	                        org.example.www.serviciosp1.GenerarPresupuesto wrappedParam =
                                                             (org.example.www.serviciosp1.GenerarPresupuesto)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.serviciosp1.GenerarPresupuesto.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               generarPresupuestoResponse27 =
                                                   
                                                   
                                                         skel.generarPresupuesto(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), generarPresupuestoResponse27, false, new javax.xml.namespace.QName("http://www.example.org/serviciosP1/",
                                                    "generarPresupuesto"));
                                    } else 

            if("consultaCP".equals(methodName)){
                
                org.example.www.serviciosp1.ConsultaCPResponse consultaCPResponse29 = null;
	                        org.example.www.serviciosp1.ConsultaCP wrappedParam =
                                                             (org.example.www.serviciosp1.ConsultaCP)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.serviciosp1.ConsultaCP.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               consultaCPResponse29 =
                                                   
                                                   
                                                         skel.consultaCP(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), consultaCPResponse29, false, new javax.xml.namespace.QName("http://www.example.org/serviciosP1/",
                                                    "consultaCP"));
                                    
            } else {
              throw new java.lang.RuntimeException("method not found");
            }
        

        newMsgContext.setEnvelope(envelope);
        }
        }
        catch (java.lang.Exception e) {
        throw org.apache.axis2.AxisFault.makeFault(e);
        }
        }
        
        //
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.ValidarDNI param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.ValidarDNI.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.ValidarDNIResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.ValidarDNIResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.ValidarIBAN param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.ValidarIBAN.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.ValidarIBANResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.ValidarIBANResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.SolicitarPresupuesto param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.SolicitarPresupuesto.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.SolicitarPresupuestoResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.SolicitarPresupuestoResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.GenerarPresupuesto param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.GenerarPresupuesto.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.GenerarPresupuestoResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.GenerarPresupuestoResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.ConsultaCP param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.ConsultaCP.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.serviciosp1.ConsultaCPResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.serviciosp1.ConsultaCPResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.serviciosp1.ValidarDNIResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.serviciosp1.ValidarDNIResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.serviciosp1.ValidarDNIResponse wrapvalidarDNI(){
                                org.example.www.serviciosp1.ValidarDNIResponse wrappedElement = new org.example.www.serviciosp1.ValidarDNIResponse();
                                return wrappedElement;
                         }
                    
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.serviciosp1.ValidarIBANResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.serviciosp1.ValidarIBANResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.serviciosp1.ValidarIBANResponse wrapvalidarIBAN(){
                                org.example.www.serviciosp1.ValidarIBANResponse wrappedElement = new org.example.www.serviciosp1.ValidarIBANResponse();
                                return wrappedElement;
                         }
                    
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.serviciosp1.SolicitarPresupuestoResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.serviciosp1.SolicitarPresupuestoResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.serviciosp1.SolicitarPresupuestoResponse wrapsolicitarPresupuesto(){
                                org.example.www.serviciosp1.SolicitarPresupuestoResponse wrappedElement = new org.example.www.serviciosp1.SolicitarPresupuestoResponse();
                                return wrappedElement;
                         }
                    
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.serviciosp1.GenerarPresupuestoResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.serviciosp1.GenerarPresupuestoResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.serviciosp1.GenerarPresupuestoResponse wrapgenerarPresupuesto(){
                                org.example.www.serviciosp1.GenerarPresupuestoResponse wrappedElement = new org.example.www.serviciosp1.GenerarPresupuestoResponse();
                                return wrappedElement;
                         }
                    
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.serviciosp1.ConsultaCPResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.serviciosp1.ConsultaCPResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.serviciosp1.ConsultaCPResponse wrapconsultaCP(){
                                org.example.www.serviciosp1.ConsultaCPResponse wrappedElement = new org.example.www.serviciosp1.ConsultaCPResponse();
                                return wrappedElement;
                         }
                    


        /**
        *  get the default envelope
        */
        private org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory){
        return factory.getDefaultEnvelope();
        }


        private  java.lang.Object fromOM(
        org.apache.axiom.om.OMElement param,
        java.lang.Class type,
        java.util.Map extraNamespaces) throws org.apache.axis2.AxisFault{

        try {
        
                if (org.example.www.serviciosp1.ConsultaCP.class.equals(type)){
                
                        return org.example.www.serviciosp1.ConsultaCP.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.ConsultaCPResponse.class.equals(type)){
                
                        return org.example.www.serviciosp1.ConsultaCPResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.GenerarPresupuesto.class.equals(type)){
                
                        return org.example.www.serviciosp1.GenerarPresupuesto.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.GenerarPresupuestoResponse.class.equals(type)){
                
                        return org.example.www.serviciosp1.GenerarPresupuestoResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.SolicitarPresupuesto.class.equals(type)){
                
                        return org.example.www.serviciosp1.SolicitarPresupuesto.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.SolicitarPresupuestoResponse.class.equals(type)){
                
                        return org.example.www.serviciosp1.SolicitarPresupuestoResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.ValidarDNI.class.equals(type)){
                
                        return org.example.www.serviciosp1.ValidarDNI.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.ValidarDNIResponse.class.equals(type)){
                
                        return org.example.www.serviciosp1.ValidarDNIResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.ValidarIBAN.class.equals(type)){
                
                        return org.example.www.serviciosp1.ValidarIBAN.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.serviciosp1.ValidarIBANResponse.class.equals(type)){
                
                        return org.example.www.serviciosp1.ValidarIBANResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
        } catch (java.lang.Exception e) {
        throw org.apache.axis2.AxisFault.makeFault(e);
        }
           return null;
        }



    

        /**
        *  A utility method that copies the namepaces from the SOAPEnvelope
        */
        private java.util.Map getEnvelopeNamespaces(org.apache.axiom.soap.SOAPEnvelope env){
        java.util.Map returnMap = new java.util.HashMap();
        java.util.Iterator namespaceIterator = env.getAllDeclaredNamespaces();
        while (namespaceIterator.hasNext()) {
        org.apache.axiom.om.OMNamespace ns = (org.apache.axiom.om.OMNamespace) namespaceIterator.next();
        returnMap.put(ns.getPrefix(),ns.getNamespaceURI());
        }
        return returnMap;
        }

        private org.apache.axis2.AxisFault createAxisFault(java.lang.Exception e) {
        org.apache.axis2.AxisFault f;
        Throwable cause = e.getCause();
        if (cause != null) {
            f = new org.apache.axis2.AxisFault(e.getMessage(), cause);
        } else {
            f = new org.apache.axis2.AxisFault(e.getMessage());
        }

        return f;
    }

        }//end of class
    