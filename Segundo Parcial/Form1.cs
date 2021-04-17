using Segundo_Parcial.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial
{
    public partial class Form1 : Form
    {

        private string[] ArregloNotas;

        public static object Items { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            clsArchivo ar = new clsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();



            ofd.Title = "Porga, selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Progra 1";
            ofd.Filter = "Archivo plnao (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string Resultado = ar.leerTodoArchivo(archivo);
                textBox1.Text = Resultado;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Archivo_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            string[,] Arreglodosdomenciones = new string[ArregloNotas.Length, 6];

            int numerolinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosunitarios = linea.Split(';');
                
                numerolinea++;

                resultado.Items.Add($"{datosunitarios[clsColumna.nombre]} nota: { datosunitarios[clsColumna.parcial1]}");
            }
            //foreach(string linea in ArregloNotas)
            //{
            //    string[] datosUnitarios = linea.Split(';');
            //    resultado.Items.Add(datosUnitarios[1]);
            //}
        }
    }

    
}
