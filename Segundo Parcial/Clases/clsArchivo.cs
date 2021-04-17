using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Segundo_Parcial.Clases
{
    class clsArchivo
    {
        public string[] leerArchivo(string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo);
            return Lineas;
        }

        public string leerTodoArchivo(string archivo)
        {
            string contenidoArchivo;

            using (StreamReader reader = new StreamReader(archivo))
            {
                contenidoArchivo = reader.ReadToEnd();
            }

            return contenidoArchivo;

        }

        
    }
}
