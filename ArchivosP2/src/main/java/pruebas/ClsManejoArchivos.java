/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebas;

/**
 *
 * @author USUARIOTC
 */
import java.io.IOException;
import utiilitarios.ClsArchivos;
//import static utiilitarios.ClsArchivos.*;
public class ClsManejoArchivos {
    
    
    public  static void main (String[] args) throws IOException{
            String nombreArchivo = "C:\\Users\\USUARIOTC\\OneDrive\\Escritorio\\PROGRA 2\\Archivos\\ArchivoTest.txt";
            var ar = new ClsArchivos();
            //ar.crearArchivo(nombreArchivo);
            //ar.escribirArchivo(nombreArchivo);    
            ar.leerArchivo(nombreArchivo);
    }
}
