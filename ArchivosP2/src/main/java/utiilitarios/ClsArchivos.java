/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package utiilitarios;

import java.io.*;
import java.util.logging.Level;
import java.util.logging.Logger;
/**
 *
 * @author USUARIOTC
 */
public class ClsArchivos {
    private static void crearArchivo(String nombreArchivo){
        PrintWriter salida = null;
        try {
            File archivo = new File(nombreArchivo);
            salida = new PrintWriter(archivo);
            salida.close();
        } catch (FileNotFoundException ex) {
            System.out.println(System.out); 
        } finally {
            salida.close();
        }
    
    }
    
    public void escribirArchivo(String nombreArchivo){
        File archivo = new File(nombreArchivo);
        try {
            PrintWriter salida = new PrintWriter(archivo);
            String contenido = "Hola Jutiapa\nesta es una pureba de archivo de texto";
            salida.println(contenido);
            salida.println();
            salida.println(" --- EOF --- ");
            salida.close();
            System.out.println("El archivo se escribio bien");
        } catch (FileNotFoundException ex) {
            ex.printStackTrace(System.out);
        }
    }
    
    public void leerArchivo(String nombreArchivo) throws IOException{
        File archivo = new File(nombreArchivo);
        try {
            BufferedReader entrada = new BufferedReader(new FileReader(archivo));
            String lectura = entrada.readLine();
            int numeroLinea = 0;
            
            
            while(lectura != null){
                    numeroLinea++;
                System.out.println("Linea = " + numeroLinea + ".-" + lectura);
                lectura=entrada.readLine();
            }
            
            entrada.close();
        } catch (FileNotFoundException ex) {
            System.out.println("Lo lamento el archivo esta en uso");
            ex.printStackTrace(System.out);
        }
    }
}
