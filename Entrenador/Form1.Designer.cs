﻿namespace Entrenador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.butEPLER = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.butRutina = new System.Windows.Forms.Button();
            this.radioSegundos = new System.Windows.Forms.RadioButton();
            this.radioMinutos = new System.Windows.Forms.RadioButton();
            this.labelCorriendo = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelTarea = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sobre60 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butLeer = new System.Windows.Forms.Button();
            this.butDesde = new System.Windows.Forms.Button();
            this.butDuplicar = new System.Windows.Forms.Button();
            this.butReanudar = new System.Windows.Forms.Button();
            this.butPausar = new System.Windows.Forms.Button();
            this.butParar = new System.Windows.Forms.Button();
            this.butTotal = new System.Windows.Forms.Button();
            this.butGrabar = new System.Windows.Forms.Button();
            this.butQquitar = new System.Windows.Forms.Button();
            this.butCorrer = new System.Windows.Forms.Button();
            this.butNuevo = new System.Windows.Forms.Button();
            this.labRutina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tiempo,
            this.Ord,
            this.Imagen,
            this.Audio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // Ord
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Ord.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ord.HeaderText = "Ord";
            this.Ord.MinimumWidth = 2;
            this.Ord.Name = "Ord";
            this.Ord.Width = 30;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            // 
            // Audio
            // 
            this.Audio.HeaderText = "Audio";
            this.Audio.Name = "Audio";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(585, 406);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(133, 44);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // butEPLER
            // 
            this.butEPLER.Location = new System.Drawing.Point(570, 18);
            this.butEPLER.Name = "butEPLER";
            this.butEPLER.Size = new System.Drawing.Size(75, 23);
            this.butEPLER.TabIndex = 9;
            this.butEPLER.Text = "EPLER";
            this.butEPLER.UseVisualStyleBackColor = true;
            this.butEPLER.Click += new System.EventHandler(this.butEPLER_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tiempo total:";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(603, 318);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(39, 13);
            this.labTotal.TabIndex = 13;
            this.labTotal.Text = "********";
            // 
            // butRutina
            // 
            this.butRutina.Location = new System.Drawing.Point(570, 47);
            this.butRutina.Name = "butRutina";
            this.butRutina.Size = new System.Drawing.Size(75, 23);
            this.butRutina.TabIndex = 14;
            this.butRutina.Text = "RUTINA";
            this.butRutina.UseVisualStyleBackColor = true;
            this.butRutina.Click += new System.EventHandler(this.butRutina_Click);
            // 
            // radioSegundos
            // 
            this.radioSegundos.AutoSize = true;
            this.radioSegundos.Location = new System.Drawing.Point(564, 111);
            this.radioSegundos.Name = "radioSegundos";
            this.radioSegundos.Size = new System.Drawing.Size(73, 17);
            this.radioSegundos.TabIndex = 16;
            this.radioSegundos.TabStop = true;
            this.radioSegundos.Text = "Segundos";
            this.radioSegundos.UseVisualStyleBackColor = true;
            this.radioSegundos.CheckedChanged += new System.EventHandler(this.radioSegundos_CheckedChanged);
            // 
            // radioMinutos
            // 
            this.radioMinutos.AutoSize = true;
            this.radioMinutos.Location = new System.Drawing.Point(564, 138);
            this.radioMinutos.Name = "radioMinutos";
            this.radioMinutos.Size = new System.Drawing.Size(62, 17);
            this.radioMinutos.TabIndex = 17;
            this.radioMinutos.TabStop = true;
            this.radioMinutos.Text = "Minutos";
            this.radioMinutos.UseVisualStyleBackColor = true;
            this.radioMinutos.CheckedChanged += new System.EventHandler(this.radioMinutos_CheckedChanged);
            // 
            // labelCorriendo
            // 
            this.labelCorriendo.AutoSize = true;
            this.labelCorriendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorriendo.Location = new System.Drawing.Point(404, 437);
            this.labelCorriendo.Name = "labelCorriendo";
            this.labelCorriendo.Size = new System.Drawing.Size(57, 20);
            this.labelCorriendo.TabIndex = 21;
            this.labelCorriendo.Text = "********";
            this.labelCorriendo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // labelTarea
            // 
            this.labelTarea.AutoSize = true;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(404, 406);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(57, 20);
            this.labelTarea.TabIndex = 23;
            this.labelTarea.Text = "********";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sobre60
            // 
            this.sobre60.AutoSize = true;
            this.sobre60.Location = new System.Drawing.Point(603, 339);
            this.sobre60.Name = "sobre60";
            this.sobre60.Size = new System.Drawing.Size(39, 13);
            this.sobre60.TabIndex = 28;
            this.sobre60.Text = "********";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total/60:";
            // 
            // butLimpiar
            // 
            this.butLimpiar.Image = global::Entrenador.Properties.Resources.Brushes;
            this.butLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLimpiar.Location = new System.Drawing.Point(251, 40);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(116, 54);
            this.butLimpiar.TabIndex = 26;
            this.butLimpiar.Text = "Limpiar";
            this.butLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butLeer
            // 
            this.butLeer.Image = global::Entrenador.Properties.Resources.Binoculars;
            this.butLeer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLeer.Location = new System.Drawing.Point(15, 40);
            this.butLeer.Name = "butLeer";
            this.butLeer.Size = new System.Drawing.Size(116, 54);
            this.butLeer.TabIndex = 24;
            this.butLeer.Text = "Buscar";
            this.butLeer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butLeer.UseVisualStyleBackColor = true;
            this.butLeer.Click += new System.EventHandler(this.butLeer_Click);
            // 
            // butDesde
            // 
            this.butDesde.Image = global::Entrenador.Properties.Resources.Player_Ff;
            this.butDesde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDesde.Location = new System.Drawing.Point(407, 206);
            this.butDesde.Name = "butDesde";
            this.butDesde.Size = new System.Drawing.Size(116, 54);
            this.butDesde.TabIndex = 22;
            this.butDesde.Text = "Desde";
            this.butDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDesde.UseVisualStyleBackColor = true;
            this.butDesde.Click += new System.EventHandler(this.butDesde_Click);
            // 
            // butDuplicar
            // 
            this.butDuplicar.FlatAppearance.BorderSize = 0;
            this.butDuplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDuplicar.Image = global::Entrenador.Properties.Resources.Blueprint2;
            this.butDuplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDuplicar.Location = new System.Drawing.Point(407, 101);
            this.butDuplicar.Name = "butDuplicar";
            this.butDuplicar.Size = new System.Drawing.Size(116, 54);
            this.butDuplicar.TabIndex = 20;
            this.butDuplicar.Text = "Duplicar";
            this.butDuplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDuplicar.UseVisualStyleBackColor = true;
            this.butDuplicar.Click += new System.EventHandler(this.butDuplicar_Click);
            // 
            // butReanudar
            // 
            this.butReanudar.Image = global::Entrenador.Properties.Resources.Player_Play;
            this.butReanudar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butReanudar.Location = new System.Drawing.Point(529, 255);
            this.butReanudar.Name = "butReanudar";
            this.butReanudar.Size = new System.Drawing.Size(116, 54);
            this.butReanudar.TabIndex = 19;
            this.butReanudar.Text = "Reanudar";
            this.butReanudar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butReanudar.UseVisualStyleBackColor = true;
            this.butReanudar.Click += new System.EventHandler(this.butReanudar_Click);
            // 
            // butPausar
            // 
            this.butPausar.Image = global::Entrenador.Properties.Resources.Player_Pause;
            this.butPausar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPausar.Location = new System.Drawing.Point(407, 255);
            this.butPausar.Name = "butPausar";
            this.butPausar.Size = new System.Drawing.Size(116, 54);
            this.butPausar.TabIndex = 18;
            this.butPausar.Text = "Pausa";
            this.butPausar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butPausar.UseVisualStyleBackColor = true;
            this.butPausar.Click += new System.EventHandler(this.butPausar_Click);
            // 
            // butParar
            // 
            this.butParar.Image = global::Entrenador.Properties.Resources.Player_Stop;
            this.butParar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butParar.Location = new System.Drawing.Point(529, 206);
            this.butParar.Name = "butParar";
            this.butParar.Size = new System.Drawing.Size(116, 54);
            this.butParar.TabIndex = 15;
            this.butParar.Text = "Parar";
            this.butParar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butParar.UseVisualStyleBackColor = true;
            this.butParar.Click += new System.EventHandler(this.butParar_Click);
            // 
            // butTotal
            // 
            this.butTotal.Image = global::Entrenador.Properties.Resources.Calculator_Operations;
            this.butTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTotal.Location = new System.Drawing.Point(407, 307);
            this.butTotal.Name = "butTotal";
            this.butTotal.Size = new System.Drawing.Size(116, 54);
            this.butTotal.TabIndex = 11;
            this.butTotal.Text = "Total";
            this.butTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butTotal.UseVisualStyleBackColor = true;
            this.butTotal.Click += new System.EventHandler(this.butTotal_Click);
            // 
            // butGrabar
            // 
            this.butGrabar.Image = global::Entrenador.Properties.Resources.Shleves;
            this.butGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butGrabar.Location = new System.Drawing.Point(133, 40);
            this.butGrabar.Name = "butGrabar";
            this.butGrabar.Size = new System.Drawing.Size(116, 54);
            this.butGrabar.TabIndex = 7;
            this.butGrabar.Text = "Guardar";
            this.butGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butGrabar.UseVisualStyleBackColor = true;
            this.butGrabar.Click += new System.EventHandler(this.butGrabar_Click);
            // 
            // butQquitar
            // 
            this.butQquitar.BackColor = System.Drawing.Color.Transparent;
            this.butQquitar.FlatAppearance.BorderSize = 0;
            this.butQquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQquitar.Image = global::Entrenador.Properties.Resources.Orb_Minus;
            this.butQquitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQquitar.Location = new System.Drawing.Point(407, 48);
            this.butQquitar.Name = "butQquitar";
            this.butQquitar.Size = new System.Drawing.Size(116, 54);
            this.butQquitar.TabIndex = 3;
            this.butQquitar.Text = "Quitar";
            this.butQquitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butQquitar.UseVisualStyleBackColor = false;
            this.butQquitar.Click += new System.EventHandler(this.butQquitar_Click);
            // 
            // butCorrer
            // 
            this.butCorrer.Image = global::Entrenador.Properties.Resources.Player_Play;
            this.butCorrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCorrer.Location = new System.Drawing.Point(407, 153);
            this.butCorrer.Name = "butCorrer";
            this.butCorrer.Size = new System.Drawing.Size(116, 54);
            this.butCorrer.TabIndex = 2;
            this.butCorrer.Text = "Correr";
            this.butCorrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCorrer.UseVisualStyleBackColor = true;
            this.butCorrer.Click += new System.EventHandler(this.butCorrer_Click);
            // 
            // butNuevo
            // 
            this.butNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNuevo.FlatAppearance.BorderSize = 0;
            this.butNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNuevo.ForeColor = System.Drawing.Color.Black;
            this.butNuevo.Image = global::Entrenador.Properties.Resources.Orb_Plus;
            this.butNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butNuevo.Location = new System.Drawing.Point(407, -1);
            this.butNuevo.Name = "butNuevo";
            this.butNuevo.Size = new System.Drawing.Size(116, 54);
            this.butNuevo.TabIndex = 1;
            this.butNuevo.Text = "Nuevo";
            this.butNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butNuevo.UseVisualStyleBackColor = true;
            this.butNuevo.Click += new System.EventHandler(this.butNuevo_Click);
            // 
            // labRutina
            // 
            this.labRutina.AutoSize = true;
            this.labRutina.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRutina.Location = new System.Drawing.Point(22, 18);
            this.labRutina.Name = "labRutina";
            this.labRutina.Size = new System.Drawing.Size(40, 23);
            this.labRutina.TabIndex = 29;
            this.labRutina.Text = "*****";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 553);
            this.Controls.Add(this.labRutina);
            this.Controls.Add(this.sobre60);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.butLeer);
            this.Controls.Add(this.labelTarea);
            this.Controls.Add(this.butDesde);
            this.Controls.Add(this.labelCorriendo);
            this.Controls.Add(this.butDuplicar);
            this.Controls.Add(this.butReanudar);
            this.Controls.Add(this.butPausar);
            this.Controls.Add(this.radioMinutos);
            this.Controls.Add(this.radioSegundos);
            this.Controls.Add(this.butParar);
            this.Controls.Add(this.butRutina);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butTotal);
            this.Controls.Add(this.butEPLER);
            this.Controls.Add(this.butGrabar);
            this.Controls.Add(this.butQquitar);
            this.Controls.Add(this.butCorrer);
            this.Controls.Add(this.butNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Entrenador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butNuevo;
        private System.Windows.Forms.Button butCorrer;
        private System.Windows.Forms.Button butQquitar;
        private System.Windows.Forms.Button butGrabar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button butEPLER;
        private System.Windows.Forms.Button butTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button butRutina;
        private System.Windows.Forms.Button butParar;
        private System.Windows.Forms.RadioButton radioSegundos;
        private System.Windows.Forms.RadioButton radioMinutos;
        private System.Windows.Forms.Button butPausar;
        private System.Windows.Forms.Button butReanudar;
        private System.Windows.Forms.Button butDuplicar;
        private System.Windows.Forms.Label labelCorriendo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button butDesde;
        private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.Button butLeer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button butLimpiar;
        private System.Windows.Forms.Label sobre60;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audio;
        private System.Windows.Forms.Label labRutina;
    }
}

