package p4mule;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.Reader;

import org.mule.api.transformer.TransformerException;

import org.mule.transformer.AbstractTransformer;

public class lectorJson extends AbstractTransformer {

	@Override
	protected Object doTransform(Object src, String enc) throws TransformerException {
		
		String jsonFinal = "";
		String cadena;
        FileReader f;
		try {
			f = new FileReader("resultadoAPI.json");
			BufferedReader b = new BufferedReader(f);
	        while((cadena = b.readLine())!=null) {
	            jsonFinal = jsonFinal + cadena;
	        }
	        b.close();
		} catch (Exception e) {
			e.printStackTrace();       
		}
		return jsonFinal;
	}

}
