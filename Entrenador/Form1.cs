using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Entrenador
{
    public partial class Form1 : Form
    {
        Tarea tarea;
        int c, t = 0,fila=0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            
            ficha f = new ficha();
            if (f.ShowDialog() == DialogResult.OK)
            {   tarea = f.t;
                dataGridView1.Rows.Add(tarea.nombre, tarea.tiempo, tarea.id, tarea.imagen, tarea.audio,tarea.tipo,tarea.unidad,tarea.programa);
            }

            dataGridView1.Rows[0].Selected = true;



        }

        private void butQquitar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(i);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un elemento");
                //throw;
            }
               
            
         
        }

        private void butGrabar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
              
                if (saveFileDialog1.FileName!="")
                {
                    using (StreamWriter file = new StreamWriter(saveFileDialog1.FileName))
                    {
                        for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
                        {
                            string t = dataGridView1.Rows[fila].Cells[0].Value.ToString() + ","
                                     + dataGridView1.Rows[fila].Cells[1].Value.ToString() + ","
                                     + dataGridView1.Rows[fila].Cells[2].Value.ToString() + ","
                                     + dataGridView1.Rows[fila].Cells[3].Value.ToString() + ","
                                     + dataGridView1.Rows[fila].Cells[4].Value.ToString() + ","
                                     + dataGridView1.Rows[fila].Cells[5].Value.ToString() + ","
                                     + dataGridView1.Rows[fila].Cells[6].Value.ToString() + ","
                                     + dataGridView1.Rows[fila].Cells[7].Value.ToString() + ",";
                            file.WriteLine(t);
                        }
                    }
                       

                }

            }
            
        }

        private void butEPLER_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows.Add("EXPLORACION", "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3");
            dataGridView1.Rows.Add("PREGUNTAS"  , "5" ,(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("LECTURA"    , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("ESQUEMAS"   , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("LECTURA"    , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("ESQUEMAS"   , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("LECTURA"    , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("ESQUEMAS"   , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("LECTURA"    , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("ESQUEMAS"   , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("REPASO"     , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;
            dataGridView1.Rows.Add("FIN"        , "10",(dataGridView1.Rows.Count*10).ToString("D3"),"Imagen.jpg", "sonido.mp3")  ;


        }

      

        private void butTotal_Click(object sender, EventArgs e)
        {
            int total = 0;

            
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                //total += int.Parse(dataGridView1.Rows[fila].Cells["Tiempo"].Value.ToString());
                   
                    total += int.Parse(item.Cells["Tiempo"].Value.ToString());
                    
                    
                   
                }
                labTotal.Text = total.ToString();
                sobre60.Text = ((float)total / 60).ToString();
            
           
        }

        private void butRutina_Click(object sender, EventArgs e)
        {

            //dataGridView1.Rows.Add("Trabajo" , "10", (dataGridView1.Rows.Count*10).ToString("D3"));
            //dataGridView1.Rows.Add("Descanzo", "5" , (dataGridView1.Rows.Count*10).ToString("D3"));
            //dataGridView1.Rows.Add("Trabajo" , "10", (dataGridView1.Rows.Count*10).ToString("D3"));
            //dataGridView1.Rows.Add("Descanzo", "5" , (dataGridView1.Rows.Count*10).ToString("D3"));
            //dataGridView1.Rows.Add("Trabajo" , "10", (dataGridView1.Rows.Count*10).ToString("D3"));
            //dataGridView1.Rows.Add("Descanzo", "5" , (dataGridView1.Rows.Count * 10).ToString("D3"));
            //dataGridView1.Rows.Add("Descanzo largo", "120", (dataGridView1.Rows.Count * 10).ToString("D3"));

            dataGridView1.Rows.Add("TRABAJO", "10", (dataGridView1.Rows.Count * 10).ToString("D3"), "trabajo.jpg", "trabajo.mp3");
            dataGridView1.Rows.Add("DESCANZO", "5", (dataGridView1.Rows.Count * 10).ToString("D3"), "descanso.jpg", "descanso.mp3");
            dataGridView1.Rows.Add("TRABAJO", "10", (dataGridView1.Rows.Count * 10).ToString("D3"), "trabajo.jpg", "trabajo.mp3");
            dataGridView1.Rows.Add("DESCANZO", "5", (dataGridView1.Rows.Count * 10).ToString("D3"), "descanso.jpg", "descanso.mp3");
            dataGridView1.Rows.Add("TRABAJO", "10", (dataGridView1.Rows.Count * 10).ToString("D3"), "trabajo.jpg", "trabajo.mp3");
            dataGridView1.Rows.Add("DESCANZO", "5", (dataGridView1.Rows.Count * 10).ToString("D3"), "descanso.jpg", "descanso.mp3");
            dataGridView1.Rows.Add("TRABAJO", "10", (dataGridView1.Rows.Count * 10).ToString("D3"), "trabajo.jpg", "trabajo.mp3");
            dataGridView1.Rows.Add("DESCANZO", "5", (dataGridView1.Rows.Count * 10).ToString("D3"), "descanso.jpg", "descanso.mp3");

            dataGridView1.Rows.Add("DescanzoLargo", "20", (dataGridView1.Rows.Count * 10).ToString("D3"), "fin.jpg", "finalizo.mp3");
            


        }

        private void butParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            fila = 0;
            this.c = 0;
            labelCorriendo.Text = "Parado";
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.DefaultCellStyle.BackColor = Color.White;
                item.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void radioSegundos_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void radioMinutos_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
        }

       

        private void butPausar_Click(object sender, EventArgs e)
        {
            labelCorriendo.Text = "Pausado";
            timer1.Stop();
        }

        private void butReanudar_Click(object sender, EventArgs e)
        {
            labelCorriendo.Text = "Corriendo";
            timer1.Start();
        }

        private void butDuplicar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    dataGridView1.Rows.Add(
                        Convert.ToString(row.Cells["Nombre"].Value),
                        Convert.ToString(row.Cells["Tiempo"].Value),
                        Convert.ToString(row.Cells["Ord"].Value),
                        Convert.ToString(row.Cells["Imagen"].Value),
                        Convert.ToString(row.Cells["Audio"].Value),
                        Convert.ToString(row.Cells["Tipo"].Value),
                        Convert.ToString(row.Cells["Unidad"].Value),
                        Convert.ToString(row.Cells["Programa"].Value)
                        );
                    
                }
            }
        }

        private void butDesde_Click(object sender, EventArgs e)
        {
                timer1.Start();
                fila =  dataGridView1.CurrentRow.Index; ;
                this.c = 0;
                dataGridView1.Rows[fila].DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Rows[fila].DefaultCellStyle.ForeColor = Color.White;

                notifyIcon1.ShowBalloonTip(1000, "Tarea", dataGridView1.Rows[fila].Cells[0].Value.ToString(), ToolTipIcon.Info);
                labelTarea.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                pantalla p = new pantalla();
                p.leyenda = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                p.audio = Convert.ToString(dataGridView1.Rows[fila].Cells["Audio"].Value);
                p.imagen = Convert.ToString(dataGridView1.Rows[fila].Cells["Imagen"].Value);
               
                p.Show();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void butLeer_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string FileToRead = openFileDialog1.FileName;
                labRutina.Text = (System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName));


                using (StreamReader ReaderObject = new StreamReader(FileToRead))
                {
                    //dataGridView1.Rows.Clear();
                    string Line;
                    // ReaderObject reads a single line, stores it in Line string variable and then displays it on console
                    while ((Line = ReaderObject.ReadLine()) != null)
                    {
                        string[] T = Line.Split(',');
                        dataGridView1.Rows.Add(T[0], T[1], T[2], T[3], T[4], T[5], T[6], T[7]);
                    }
                    dataGridView1.Rows[0].Selected = true;
                }

            }
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void butBajar_Click(object sender, EventArgs e)
        {
            
            DataGridView dgv = dataGridView1;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex + 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch { }
           

        }

        private void butArriba_Click(object sender, EventArgs e)
        {
           
            DataGridView dgv = dataGridView1;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex - 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch { }
           
        }

        private void butRecalcular_Click(object sender, EventArgs e)
        {
            int tiempo_promedio = 0;

            int cont = this.dataGridView1.SelectedRows.Count;
           
            try
            {
                if (textDisponible.Text != "")
                {
                    int tiempo = int.Parse(textDisponible.Text);
                    tiempo_promedio = (tiempo / cont);
                }
                else
                {

                }



                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    if (row.IsNewRow)
                    {
                        break;

                    }
                    row.Cells["Tiempo"].Value = tiempo_promedio.ToString();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique el formato de las fechas");
            }

        }

        private void butCorrer_Click(object sender, EventArgs e)
        {
            
            try
            {              
                fila = dataGridView1.CurrentRow.Index;               
                this.c = 0;
                try
                {
                    string tipo = Convert.ToString(dataGridView1.Rows[fila].Cells["Tipo"].Value);

                    if (tipo == "Programa")
                    {
                        procesa_Programa();
                    }
                    else
                    {
                        procesa_tarea_sencilla();
                    }

                }
                catch (Exception)
                {
                }


                //dataGridView1.Rows[fila].DefaultCellStyle.BackColor = Color.Green;
                //dataGridView1.Rows[fila].DefaultCellStyle.ForeColor = Color.White;

                //notifyIcon1.ShowBalloonTip(1000, "Esto es un mensaje", dataGridView1.Rows[fila].Cells[0].Value.ToString(), ToolTipIcon.Info);
                //pantalla p = new pantalla();
                //p.leyenda = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                //p.audio = Convert.ToString(dataGridView1.Rows[fila].Cells["Audio"].Value);
                //p.imagen = Convert.ToString(dataGridView1.Rows[fila].Cells["Imagen"].Value);

                //string t = Convert.ToString(dataGridView1.Rows[fila].Cells["Unidad"].Value);
                //unidadTiempo(t);

                //p.Show();
                //labelTarea.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                pantalla p = new pantalla();
                p.leyenda = "No cargaste ningún programa aún";
                //todo poner una imagen
                //poner un audio diferente
                p.Show();
            }
            
        }

       

        private void unidadTiempo(string u) {
            switch (u)
            {
                case "Hora":
                    {
                        timer1.Interval = 3600000;
                        timer1.Start();
                    }
                    break;
                case "Minutos":
                    {
                        timer1.Interval = 60000;
                        timer1.Start();
                    }
                    break;
                case "Segundos":
                    {
                        timer1.Interval = 1000;
                        timer1.Start();
                    }
                    break;
                default:
                    {
                        timer1.Interval = 1000;
                        timer1.Start();
                    }
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.c++;
            ShowInTaskbar = true;
            labelCorriendo.Text = this.c.ToString();
            
           
            notifyIcon1.Text = this.c.ToString();
            if (fila < (dataGridView1.Rows.Count - 2))
            {
                try
                {
                    string tipo = Convert.ToString(dataGridView1.Rows[fila].Cells["Tipo"].Value);

                    if (tipo == "Programa")
                    {
                        t = int.Parse(dataGridView1.Rows[fila].Cells[1].Value.ToString());
                        if (c == t)
                        {
                            this.c = 0;
                            fila++;
                            procesa_Programa();
                        }
                    }
                    else
                    {
                        t = int.Parse(dataGridView1.Rows[fila].Cells[1].Value.ToString());
                        if (c == t)
                        {
                            this.c = 0;
                            fila++;
                            procesa_tarea_sencilla();
                        }
                    }

                    
                }
                catch (Exception)
                {

                    
                }
               

            }
            else {  timer1.Stop(); }
            
        }

        #region tareas
        public void procesa_tarea_sencilla()
        {
            //t = int.Parse(dataGridView1.Rows[fila].Cells[1].Value.ToString());
            //if (c == t)
            //{

                dataGridView1.Rows[fila].DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Rows[fila].DefaultCellStyle.ForeColor = Color.White;
                string ut = Convert.ToString(dataGridView1.Rows[fila].Cells["Unidad"].Value);
                unidadTiempo(ut);

                notifyIcon1.ShowBalloonTip(1000, "Esto es un mensaje", dataGridView1.Rows[fila].Cells[0].Value.ToString(), ToolTipIcon.Info);
                labelTarea.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                pantalla p = new pantalla();
                p.leyenda = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                p.audio = Convert.ToString(dataGridView1.Rows[fila].Cells["Audio"].Value);
                p.imagen = Convert.ToString(dataGridView1.Rows[fila].Cells["Imagen"].Value);

                p.Show();

            //}


        }

        public void procesa_Programa()
        {
           
                dataGridView1.Rows[fila].DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Rows[fila].DefaultCellStyle.ForeColor = Color.White;
                string ut = Convert.ToString(dataGridView1.Rows[fila].Cells["Unidad"].Value);
                unidadTiempo(ut);

                notifyIcon1.ShowBalloonTip(1000, "Esto es un mensaje", dataGridView1.Rows[fila].Cells[0].Value.ToString(), ToolTipIcon.Info);
                labelTarea.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                pantalla p = new pantalla();
                p.leyenda = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                p.audio = Convert.ToString(dataGridView1.Rows[fila].Cells["Audio"].Value);
                p.imagen = Convert.ToString(dataGridView1.Rows[fila].Cells["Imagen"].Value);
                string programa = Convert.ToString(dataGridView1.Rows[fila].Cells["programa"].Value);
                correr_programa(programa);
                p.Show();

           


        }

        public void correr_programa(string programa) 
        {
            try
            {
                axWindowsMediaPlayer1.URL = programa;
            }
            catch (Exception)
            {   programa = "sonido.mp3";               
                axWindowsMediaPlayer1.URL = programa;
              
            }
            // axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        #endregion

    }




}
