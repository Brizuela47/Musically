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
                pictureBox4.Image = Properties.Resources.pause;



            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            r.URL = Rutas[listBox1.SelectedIndex];
            lblCancion.Text = Archivos[listBox1.SelectedIndex];
        }

        public void ActualizarDatos()
        {
            if (r.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mTrackPos.Maximum=(int)r.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (r.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if(r.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mTrackPos.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatos();
            mTrackPos.Value = (int)r.Ctlcontrols.currentPosition;
            mTrackVolumen.Value = r.settings.volume;
        }

        private void r_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatos();
        }

        private void mTrackVolumen_ValueChanged(object sender, decimal value)
        {
            r.settings.volume = mTrackVolumen.Value;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    r.Ctlcontrols.pause();
                    pictureBox4.Image = Properties.Resources.play;
                    Play = false;
                break;
                case false:
                    r.Ctlcontrols.play();
                    pictureBox4.Image = Properties.Resources.pause;
                    Play = true;
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            r.Ctlcontrols.stop();
        }
    }
}
