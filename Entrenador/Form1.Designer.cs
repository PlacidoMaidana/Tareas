namespace Entrenador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labRutina = new System.Windows.Forms.Label();
            this.textDisponible = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butRecalcular = new System.Windows.Forms.Button();
            this.butArriba = new System.Windows.Forms.Button();
            this.butBajar = new System.Windows.Forms.Button();
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
            this.labelMinutos = new System.Windows.Forms.Label();
            this.buttonGuardarSeleccion = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
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
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tiempo,
            this.Ord,
            this.Imagen,
            this.Audio,
            this.Tipo,
            this.Unidad,
            this.Programa});
            this.dataGridView1.Location = new System.Drawing.Point(16, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(654, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle7;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.MinimumWidth = 6;
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Width = 60;
            // 
            // Ord
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Ord.DefaultCellStyle = dataGridViewCellStyle8;
            this.Ord.HeaderText = "Ord";
            this.Ord.MinimumWidth = 2;
            this.Ord.Name = "Ord";
            this.Ord.Visible = false;
            this.Ord.Width = 30;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.Width = 125;
            // 
            // Audio
            // 
            this.Audio.HeaderText = "Audio";
            this.Audio.MinimumWidth = 6;
            this.Audio.Name = "Audio";
            this.Audio.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.MinimumWidth = 6;
            this.Unidad.Name = "Unidad";
            this.Unidad.Width = 125;
            // 
            // Programa
            // 
            this.Programa.HeaderText = "Programa";
            this.Programa.MinimumWidth = 6;
            this.Programa.Name = "Programa";
            this.Programa.Width = 125;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(794, 376);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(133, 44);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // butEPLER
            // 
            this.butEPLER.Location = new System.Drawing.Point(933, 22);
            this.butEPLER.Margin = new System.Windows.Forms.Padding(4);
            this.butEPLER.Name = "butEPLER";
            this.butEPLER.Size = new System.Drawing.Size(100, 28);
            this.butEPLER.TabIndex = 9;
            this.butEPLER.Text = "EPLER";
            this.butEPLER.UseVisualStyleBackColor = true;
            this.butEPLER.Click += new System.EventHandler(this.butEPLER_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tiempo total:";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(970, 366);
            this.labTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(48, 17);
            this.labTotal.TabIndex = 13;
            this.labTotal.Text = "********";
            // 
            // butRutina
            // 
            this.butRutina.Location = new System.Drawing.Point(933, 58);
            this.butRutina.Margin = new System.Windows.Forms.Padding(4);
            this.butRutina.Name = "butRutina";
            this.butRutina.Size = new System.Drawing.Size(100, 28);
            this.butRutina.TabIndex = 14;
            this.butRutina.Text = "RUTINA";
            this.butRutina.UseVisualStyleBackColor = true;
            this.butRutina.Click += new System.EventHandler(this.butRutina_Click);
            // 
            // radioSegundos
            // 
            this.radioSegundos.AutoSize = true;
            this.radioSegundos.Location = new System.Drawing.Point(925, 137);
            this.radioSegundos.Margin = new System.Windows.Forms.Padding(4);
            this.radioSegundos.Name = "radioSegundos";
            this.radioSegundos.Size = new System.Drawing.Size(93, 21);
            this.radioSegundos.TabIndex = 16;
            this.radioSegundos.TabStop = true;
            this.radioSegundos.Text = "Segundos";
            this.radioSegundos.UseVisualStyleBackColor = true;
            this.radioSegundos.CheckedChanged += new System.EventHandler(this.radioSegundos_CheckedChanged);
            // 
            // radioMinutos
            // 
            this.radioMinutos.AutoSize = true;
            this.radioMinutos.Location = new System.Drawing.Point(925, 170);
            this.radioMinutos.Margin = new System.Windows.Forms.Padding(4);
            this.radioMinutos.Name = "radioMinutos";
            this.radioMinutos.Size = new System.Drawing.Size(78, 21);
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
            this.labelCorriendo.Location = new System.Drawing.Point(695, 527);
            this.labelCorriendo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorriendo.Name = "labelCorriendo";
            this.labelCorriendo.Size = new System.Drawing.Size(76, 25);
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
            this.labelTarea.Location = new System.Drawing.Point(695, 487);
            this.labelTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(76, 25);
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
            this.sobre60.Location = new System.Drawing.Point(970, 391);
            this.sobre60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sobre60.Name = "sobre60";
            this.sobre60.Size = new System.Drawing.Size(48, 17);
            this.sobre60.TabIndex = 28;
            this.sobre60.Text = "********";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total/60:";
            // 
            // labRutina
            // 
            this.labRutina.AutoSize = true;
            this.labRutina.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRutina.Location = new System.Drawing.Point(29, 22);
            this.labRutina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRutina.Name = "labRutina";
            this.labRutina.Size = new System.Drawing.Size(53, 29);
            this.labRutina.TabIndex = 29;
            this.labRutina.Text = "*****";
            // 
            // textDisponible
            // 
            this.textDisponible.Location = new System.Drawing.Point(916, 272);
            this.textDisponible.Margin = new System.Windows.Forms.Padding(4);
            this.textDisponible.Name = "textDisponible";
            this.textDisponible.Size = new System.Drawing.Size(116, 22);
            this.textDisponible.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tiempo disponible:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Entrenador.Properties.Resources.Application_Side_Expand;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(691, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 53);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Entrenador.Properties.Resources.note_task_comment_message_edit_write_108613;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(689, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 53);
            this.button1.TabIndex = 35;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butRecalcular
            // 
            this.butRecalcular.FlatAppearance.BorderSize = 0;
            this.butRecalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRecalcular.Image = global::Entrenador.Properties.Resources.list_992;
            this.butRecalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRecalcular.Location = new System.Drawing.Point(794, 300);
            this.butRecalcular.Margin = new System.Windows.Forms.Padding(4);
            this.butRecalcular.Name = "butRecalcular";
            this.butRecalcular.Size = new System.Drawing.Size(129, 53);
            this.butRecalcular.TabIndex = 34;
            this.butRecalcular.Text = "Recalcular";
            this.butRecalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butRecalcular.UseVisualStyleBackColor = true;
            this.butRecalcular.Click += new System.EventHandler(this.butRecalcular_Click);
            // 
            // butArriba
            // 
            this.butArriba.FlatAppearance.BorderSize = 0;
            this.butArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butArriba.Image = global::Entrenador.Properties.Resources.arrow_up_bold_box_outline_icon_139943;
            this.butArriba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butArriba.Location = new System.Drawing.Point(689, 355);
            this.butArriba.Margin = new System.Windows.Forms.Padding(4);
            this.butArriba.Name = "butArriba";
            this.butArriba.Size = new System.Drawing.Size(67, 41);
            this.butArriba.TabIndex = 31;
            this.butArriba.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butArriba.UseVisualStyleBackColor = true;
            this.butArriba.Click += new System.EventHandler(this.butArriba_Click);
            // 
            // butBajar
            // 
            this.butBajar.FlatAppearance.BorderSize = 0;
            this.butBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBajar.Image = global::Entrenador.Properties.Resources.arrow_down_bold_box_outline_icon_139963;
            this.butBajar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBajar.Location = new System.Drawing.Point(689, 387);
            this.butBajar.Margin = new System.Windows.Forms.Padding(4);
            this.butBajar.Name = "butBajar";
            this.butBajar.Size = new System.Drawing.Size(67, 41);
            this.butBajar.TabIndex = 30;
            this.butBajar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butBajar.UseVisualStyleBackColor = true;
            this.butBajar.Click += new System.EventHandler(this.butBajar_Click);
            // 
            // butLimpiar
            // 
            this.butLimpiar.Image = global::Entrenador.Properties.Resources.Brushes;
            this.butLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLimpiar.Location = new System.Drawing.Point(377, 50);
            this.butLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(106, 65);
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
            this.butLeer.Location = new System.Drawing.Point(20, 50);
            this.butLeer.Margin = new System.Windows.Forms.Padding(4);
            this.butLeer.Name = "butLeer";
            this.butLeer.Size = new System.Drawing.Size(106, 65);
            this.butLeer.TabIndex = 24;
            this.butLeer.Text = "Cargar";
            this.butLeer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butLeer.UseVisualStyleBackColor = true;
            this.butLeer.Click += new System.EventHandler(this.butLeer_Click);
            // 
            // butDesde
            // 
            this.butDesde.FlatAppearance.BorderSize = 0;
            this.butDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDesde.Image = global::Entrenador.Properties.Resources._1486348818_forward_arrows_arrow_front_go_blue_80478;
            this.butDesde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDesde.Location = new System.Drawing.Point(938, 213);
            this.butDesde.Margin = new System.Windows.Forms.Padding(4);
            this.butDesde.Name = "butDesde";
            this.butDesde.Size = new System.Drawing.Size(41, 46);
            this.butDesde.TabIndex = 22;
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
            this.butDuplicar.Location = new System.Drawing.Point(678, 288);
            this.butDuplicar.Margin = new System.Windows.Forms.Padding(4);
            this.butDuplicar.Name = "butDuplicar";
            this.butDuplicar.Size = new System.Drawing.Size(77, 53);
            this.butDuplicar.TabIndex = 20;
            this.butDuplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDuplicar.UseVisualStyleBackColor = true;
            this.butDuplicar.Click += new System.EventHandler(this.butDuplicar_Click);
            // 
            // butReanudar
            // 
            this.butReanudar.FlatAppearance.BorderSize = 0;
            this.butReanudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReanudar.Image = global::Entrenador.Properties.Resources._1486348813_music_forward_front_next_arrow_blue_80474;
            this.butReanudar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butReanudar.Location = new System.Drawing.Point(886, 213);
            this.butReanudar.Margin = new System.Windows.Forms.Padding(4);
            this.butReanudar.Name = "butReanudar";
            this.butReanudar.Size = new System.Drawing.Size(41, 46);
            this.butReanudar.TabIndex = 19;
            this.butReanudar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butReanudar.UseVisualStyleBackColor = true;
            this.butReanudar.Click += new System.EventHandler(this.butReanudar_Click);
            // 
            // butPausar
            // 
            this.butPausar.FlatAppearance.BorderSize = 0;
            this.butPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPausar.Image = global::Entrenador.Properties.Resources._1486348820_music_pause_stop_control_play_blue_80477;
            this.butPausar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPausar.Location = new System.Drawing.Point(833, 213);
            this.butPausar.Margin = new System.Windows.Forms.Padding(4);
            this.butPausar.Name = "butPausar";
            this.butPausar.Size = new System.Drawing.Size(41, 46);
            this.butPausar.TabIndex = 18;
            this.butPausar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butPausar.UseVisualStyleBackColor = true;
            this.butPausar.Click += new System.EventHandler(this.butPausar_Click);
            // 
            // butParar
            // 
            this.butParar.FlatAppearance.BorderSize = 0;
            this.butParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butParar.Image = global::Entrenador.Properties.Resources._1486348809_music_square_stop_play_pause_blue_80470;
            this.butParar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butParar.Location = new System.Drawing.Point(992, 213);
            this.butParar.Margin = new System.Windows.Forms.Padding(4);
            this.butParar.Name = "butParar";
            this.butParar.Size = new System.Drawing.Size(41, 46);
            this.butParar.TabIndex = 15;
            this.butParar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butParar.UseVisualStyleBackColor = true;
            this.butParar.Click += new System.EventHandler(this.butParar_Click);
            // 
            // butTotal
            // 
            this.butTotal.FlatAppearance.BorderSize = 0;
            this.butTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTotal.Image = global::Entrenador.Properties.Resources.sum_icon_151075;
            this.butTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTotal.Location = new System.Drawing.Point(796, 358);
            this.butTotal.Margin = new System.Windows.Forms.Padding(4);
            this.butTotal.Name = "butTotal";
            this.butTotal.Size = new System.Drawing.Size(77, 53);
            this.butTotal.TabIndex = 11;
            this.butTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butTotal.UseVisualStyleBackColor = true;
            this.butTotal.Click += new System.EventHandler(this.butTotal_Click);
            // 
            // butGrabar
            // 
            this.butGrabar.Image = global::Entrenador.Properties.Resources.Shleves;
            this.butGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butGrabar.Location = new System.Drawing.Point(258, 50);
            this.butGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.butGrabar.Name = "butGrabar";
            this.butGrabar.Size = new System.Drawing.Size(106, 65);
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
            this.butQquitar.Location = new System.Drawing.Point(678, 229);
            this.butQquitar.Margin = new System.Windows.Forms.Padding(4);
            this.butQquitar.Name = "butQquitar";
            this.butQquitar.Size = new System.Drawing.Size(77, 53);
            this.butQquitar.TabIndex = 3;
            this.butQquitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butQquitar.UseVisualStyleBackColor = false;
            this.butQquitar.Click += new System.EventHandler(this.butQquitar_Click);
            // 
            // butCorrer
            // 
            this.butCorrer.FlatAppearance.BorderSize = 0;
            this.butCorrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCorrer.Image = global::Entrenador.Properties.Resources._1486348822_music_play_pause_control_go_arrow_blue_80476;
            this.butCorrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCorrer.Location = new System.Drawing.Point(780, 213);
            this.butCorrer.Margin = new System.Windows.Forms.Padding(4);
            this.butCorrer.Name = "butCorrer";
            this.butCorrer.Size = new System.Drawing.Size(41, 46);
            this.butCorrer.TabIndex = 2;
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
            this.butNuevo.Location = new System.Drawing.Point(679, 63);
            this.butNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.butNuevo.Name = "butNuevo";
            this.butNuevo.Size = new System.Drawing.Size(77, 53);
            this.butNuevo.TabIndex = 1;
            this.butNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butNuevo.UseVisualStyleBackColor = true;
            this.butNuevo.Click += new System.EventHandler(this.butNuevo_Click);
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutos.Location = new System.Drawing.Point(895, 527);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(68, 25);
            this.labelMinutos.TabIndex = 37;
            this.labelMinutos.Text = "*******";
            // 
            // buttonGuardarSeleccion
            // 
            this.buttonGuardarSeleccion.Image = global::Entrenador.Properties.Resources.Shleves;
            this.buttonGuardarSeleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarSeleccion.Location = new System.Drawing.Point(496, 50);
            this.buttonGuardarSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarSeleccion.Name = "buttonGuardarSeleccion";
            this.buttonGuardarSeleccion.Size = new System.Drawing.Size(151, 65);
            this.buttonGuardarSeleccion.TabIndex = 38;
            this.buttonGuardarSeleccion.Text = "Guardar seleccionado";
            this.buttonGuardarSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarSeleccion.UseVisualStyleBackColor = true;
            this.buttonGuardarSeleccion.Click += new System.EventHandler(this.buttonGuardarSeleccion_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Image = global::Entrenador.Properties.Resources.Binoculars;
            this.buttonInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInsertar.Location = new System.Drawing.Point(139, 50);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(106, 65);
            this.buttonInsertar.TabIndex = 39;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 681);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonGuardarSeleccion);
            this.Controls.Add(this.labelMinutos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butRecalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDisponible);
            this.Controls.Add(this.butArriba);
            this.Controls.Add(this.butBajar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label labRutina;
        private System.Windows.Forms.Button butBajar;
        private System.Windows.Forms.Button butArriba;
        private System.Windows.Forms.TextBox textDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRecalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.Button buttonGuardarSeleccion;
        private System.Windows.Forms.Button buttonInsertar;
    }
}

