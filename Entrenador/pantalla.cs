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
    public partial class pantalla : Form
    {
        public string leyenda { get; set; }
        public string imagen { get; set; }
        public string audio { get; set; }
        public pantalla()
        {
            InitializeComponent();
        }

        private void pantalla_Load(object sender, EventArgs e)
        {
            label1.Text = leyenda;
            timer1.Start();
            try
            {
                axWindowsMediaPlayer1.URL = audio;
                pictureBox1.Image = Image.FromFile(imagen);

            }
            catch (Exception)
            {
                audio = "sonido.mp3";
                imagen = "trabajo.jpg";
                axWindowsMediaPlayer1.URL = audio;
                pictureBox1.Image = Image.FromFile(imagen);
            }
           
            // axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
        }
    }
}
