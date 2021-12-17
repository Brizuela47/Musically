using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musically
{
    public partial class Form1 : Form
    {
        bool Play = false; /// Variable bool,guarda false,true
        string[] Archivos; //array donde se depositan todos los archivos encontrados
        string[] Rutas; //array
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        private void r_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog Carpeta = new OpenFileDialog();///muestra el sistema operativo de windows cuando deseas seleccionar un archivo.

            Carpeta.Multiselect = true; //Permite seleccionar varios archivos almismo tiempo :)

            if (Carpeta.ShowDialog() == DialogResult.OK) //Si se mostro el openfiledialog y si le dieron elboton okay
            {

                Archivos = Carpeta.SafeFileNames; //se almacena todo los archivos
                Rutas = Carpeta.FileNames; //Guarda ruta de los archivos

                foreach (var Archivos in Archivos)//ciclo foreach par leer cada uno de los archivos que se adjuntn
                {


                    listBox1.Items.Add(Archivos); //se crea una lista de acuerdo a los archivos encontrados

                }
                r.URL = Rutas[0];//La ruta del archivo inicial
                listBox1.SelectedIndex = 0; //selecciona 



            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            r.URL = Rutas[listBox1.SelectedIndex];
        }
    }
}
