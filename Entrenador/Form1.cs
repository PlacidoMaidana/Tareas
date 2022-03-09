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
        Tarea tarea,tarea2;
        int c, t = 0,fila=0;
        decimal minutos=0;
        List<Tarea> lista_tareas = new List<Tarea>();
        bool fila_existe = false;
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
            axWindowsMediaPlayer1.Ctlcontrols.stop();
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
            axWindowsMediaPlayer1.Ctlcontrols.stop();
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
            this.minutos = ((decimal)this.c/60);
            
            
            ShowInTaskbar = true;
            labelCorriendo.Text = this.c.ToString();
            labelMinutos.Text = string.Format("{0,5:N3}  minutos", (decimal)this.minutos);


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

        private void button1_Click(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentRow.Index;
            get_fila(fila);
            ficha f = new ficha();
            f.t = tarea2;
            if (f.ShowDialog() == DialogResult.OK)
            {
                tarea = f.t;
                Modificar_fila(fila,tarea);
                
            }

            dataGridView1.Rows[0].Selected = true;

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

        private void button2_Click(object sender, EventArgs e)
        {//Blanquea la fila 


            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if (row.IsNewRow)
                {
                    break;

                }
                if (dataGridView1.Rows[fila].DefaultCellStyle.BackColor == Color.White)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;

                }
               // row.Cells["Tiempo"].Value = tiempo_promedio.ToString();

            }




           // fila = dataGridView1.CurrentRow.Index;
           




        }

        public void  resguardar_lista()
        {
            int cont = this.dataGridView1.Rows.Count;
           
            try
            {
                for (int fila = 0; fila < cont; fila++)
                {
                    if (dataGridView1.Rows[fila].IsNewRow)
                    {
                        break;

                    }
                    get_fila(fila);
                    lista_tareas.Add(tarea2);                    
                   
                }

            
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al cargar el programa");
            }

          
        }
        public void mostrar_lista_tareas()
        {
            string text = "";
            foreach (var item in lista_tareas)
            {
                text += item.nombre + "  ";
            }
            MessageBox.Show(text);
        }

        public void mostrar_lista_tareas2()
        {
            string text = "";
            for (int i = 0; i < lista_tareas.Count(); i++)
            {
                text += lista_tareas[i].nombre + "  ";
            }
            
            MessageBox.Show(text);
        }

        public void cargo_primer_parte()
        {
            fila = dataGridView1.CurrentRow.Index;
            bool fila_existe = dataGridView1.Rows[fila].IsNewRow ? false : true;
            dataGridView1.Rows.Clear();

            for (int i = 0; i < lista_tareas.Count(); i++)
            {
                if (i==fila+1 && fila_existe)
                {
                    break;
                }
                dataGridView1.Rows.Add(lista_tareas[i].nombre,
                                       lista_tareas[i].tiempo,
                                       lista_tareas[i].id,
                                       lista_tareas[i].imagen,
                                       lista_tareas[i].audio,
                                       lista_tareas[i].tipo,
                                       lista_tareas[i].unidad,
                                       lista_tareas[i].programa);

            }




        }

        public void cargo_nuevo_programa()
        {
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
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

        public void cargo_segunda_parte()
        {
            for (int i = fila + 1; i < lista_tareas.Count(); i++)
            {                
                dataGridView1.Rows.Add(lista_tareas[i].nombre,
                                       lista_tareas[i].tiempo,
                                       lista_tareas[i].id,
                                       lista_tareas[i].imagen,
                                       lista_tareas[i].audio,
                                       lista_tareas[i].tipo,
                                       lista_tareas[i].unidad,
                                       lista_tareas[i].programa);

            }
        }


        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            int cont = this.dataGridView1.Rows.Count;
            resguardar_lista();
            cargo_primer_parte();
            cargo_nuevo_programa();
            cargo_segunda_parte();
        }

        private void buttonGuardarSeleccion_Click(object sender, EventArgs e)
        {
            //todo
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

        #region ConLaClaseTareas
        public void get_fila(int fila)
        {
           
            tarea2 = new Tarea();
            
            tarea2.nombre =   Convert.ToString(dataGridView1.Rows[fila].Cells["nombre"].Value);
            tarea2.tiempo =   Convert.ToString(dataGridView1.Rows[fila].Cells["tiempo"].Value);
            tarea2.id =       Convert.ToString(dataGridView1.Rows[fila].Cells["Ord"].Value);
            tarea2.imagen =   Convert.ToString(dataGridView1.Rows[fila].Cells["imagen"].Value);
            tarea2.audio =    Convert.ToString(dataGridView1.Rows[fila].Cells["audio"].Value);
            tarea2.tipo =     Convert.ToString(dataGridView1.Rows[fila].Cells["tipo"].Value);
            tarea2.unidad =   Convert.ToString(dataGridView1.Rows[fila].Cells["unidad"].Value);
            tarea2.programa = Convert.ToString(dataGridView1.Rows[fila].Cells["programa"].Value);
        }

        public void Modificar_fila(int fila,Tarea tarea)
        {
            dataGridView1.Rows[fila].Cells["nombre"].Value     =tarea.nombre;
            dataGridView1.Rows[fila].Cells["tiempo"].Value     = tarea.tiempo;
            dataGridView1.Rows[fila].Cells["Ord"].Value        = tarea.id;
            dataGridView1.Rows[fila].Cells["imagen"].Value     = tarea.imagen;
            dataGridView1.Rows[fila].Cells["audio"].Value      = tarea.audio;
            dataGridView1.Rows[fila].Cells["tipo"].Value       = tarea.tipo;
            dataGridView1.Rows[fila].Cells["unidad"].Value     = tarea.unidad;
            dataGridView1.Rows[fila].Cells["programa"].Value   = tarea.programa;


        }

        #endregion

    }




}
