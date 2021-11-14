using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrenador
{
    public partial class ficha : Form
    {
        public Tarea t { get; set; }
        public ficha()
        {
            InitializeComponent();
            t = new Tarea();
        }

        private void butImagen_Click(object sender, EventArgs e)
        {
            
             openFileDialog1.Filter = "imagen (*.jpg)|*.jpg|All files (*.*)|*.*";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textImagen.Text= openFileDialog1.FileName.ToString();
                   // t.imagen = openFileDialog1.FileName;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una imagen");
            }
           
        }

        public void cargar_valores()
        {
            t.nombre = textTarea.Text;
            t.tiempo = textTiempo.Text;
            t.id = textId.Text;
            t.imagen = textImagen.Text;
            t.audio = textAudio.Text;
            t.tipo =  comboTipo.Text;
            t.unidad = comboUnidades.Text;
            t.programa = textPrograma.Text;
        }   

        private void butNuevo_Click(object sender, EventArgs e)
        {
            this.cargar_valores();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void butAudio_Click(object sender, EventArgs e)
        {
            
            openFileDialog2.Filter = "audio (*.mp3)|*.mp3|All files (*.*)|*.*";
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    textAudio.Text = openFileDialog2.FileName.ToString();
                    // t.imagen = openFileDialog1.FileName;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una imagen");
            }
        }

        private void butPrograma_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "programa (*.csv)|*.csv|All files (*.*)|*.*";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textPrograma.Text = openFileDialog1.FileName.ToString();
                   
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un programa");
            }
        }
    }
}
