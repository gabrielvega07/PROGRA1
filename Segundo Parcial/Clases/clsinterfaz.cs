using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Parcial.Clases
{
    class clsinterfaz
    {

        public string[,] Clasificar(string[,] matriz, string seccion)
        {

            throw new NotImplementedException();
            //string contenidoArchivo;

            //using (StreamReader reader = new StreamReader(seccion))
            //{
            //    contenidoArchivo = reader.ReadToEnd();
            //}

            //return contenidoArchivo;
        }
        public string notamayor(string[,] matriz)
        {
            throw new NotImplementedException();
        }
        public string notamayor(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }
        public int generalseccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }
        public int porparcial(string[,] matriz, int columna_parcial, string seccion)
        {

            int Acumula = 0;
            int Prome;
            int TotalFilas = matriz.GetLength(0);
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                Acumula = Acumula + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            Prome = Acumula / (TotalFilas - 1);
            return Prome;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {

            int Acumula = 0;
            int Prome;
            int TotalFilas = matriz.GetLength(0);
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                Acumula = Acumula + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            Prome = Acumula / (TotalFilas - 1);
            return Prome;
        }
    }
}
