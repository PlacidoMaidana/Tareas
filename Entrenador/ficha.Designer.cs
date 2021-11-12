namespace Entrenador
{
    partial class ficha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTarea = new System.Windows.Forms.TextBox();
            this.textTiempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textImagen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAudio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.butImagen = new System.Windows.Forms.Button();
            this.butAudio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butNuevo
            // 
            this.butNuevo.Location = new System.Drawing.Point(227, 175);
            this.butNuevo.Name = "butNuevo";
            this.butNuevo.Size = new System.Drawing.Size(75, 23);
            this.butNuevo.TabIndex = 0;
            this.butNuevo.Text = "Nuevo";
            this.butNuevo.UseVisualStyleBackColor = true;
            this.butNuevo.Click += new System.EventHandler(this.butNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarea";
            // 
            // textTarea
            // 
            this.textTarea.Location = new System.Drawing.Point(121, 25);
            this.textTarea.Name = "textTarea";
            this.textTarea.Size = new System.Drawing.Size(100, 20);
            this.textTarea.TabIndex = 2;
            this.textTarea.Text = "Tarea";
            // 
            // textTiempo
            // 
            this.textTiempo.Location = new System.Drawing.Point(121, 56);
            this.textTiempo.Name = "textTiempo";
            this.textTiempo.Size = new System.Drawing.Size(100, 20);
            this.textTiempo.TabIndex = 4;
            this.textTiempo.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(121, 87);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 6;
            this.textId.Text = "001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id";
            // 
            // textImagen
            // 
            this.textImagen.Location = new System.Drawing.Point(121, 118);
            this.textImagen.Name = "textImagen";
            this.textImagen.Size = new System.Drawing.Size(100, 20);
            this.textImagen.TabIndex = 8;
            this.textImagen.Text = "imagen.jpg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Imagen";
            // 
            // textAudio
            // 
            this.textAudio.Location = new System.Drawing.Point(121, 149);
            this.textAudio.Name = "textAudio";
            this.textAudio.Size = new System.Drawing.Size(100, 20);
            this.textAudio.TabIndex = 10;
            this.textAudio.Text = "audio.mp3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Audio";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // butImagen
            // 
            this.butImagen.Location = new System.Drawing.Point(227, 119);
            this.butImagen.Name = "butImagen";
            this.butImagen.Size = new System.Drawing.Size(75, 23);
            this.butImagen.TabIndex = 11;
            this.butImagen.Text = "Imagen";
            this.butImagen.UseVisualStyleBackColor = true;
            this.butImagen.Click += new System.EventHandler(this.butImagen_Click);
            // 
            // butAudio
            // 
            this.butAudio.Location = new System.Drawing.Point(227, 146);
            this.butAudio.Name = "butAudio";
            this.butAudio.Size = new System.Drawing.Size(75, 23);
            this.butAudio.TabIndex = 12;
            this.butAudio.Text = "Audio";
            this.butAudio.UseVisualStyleBackColor = true;
            this.butAudio.Click += new System.EventHandler(this.butAudio_Click);
            // 
            // ficha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 224);
            this.Controls.Add(this.butAudio);
            this.Controls.Add(this.butImagen);
            this.Controls.Add(this.textAudio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textImagen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butNuevo);
            this.Name = "ficha";
            this.Text = "ficha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTarea;
        private System.Windows.Forms.TextBox textTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textImagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAudio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button butImagen;
        private System.Windows.Forms.Button butAudio;
    }
}