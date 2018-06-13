namespace UltimoLab
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
            this.welcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.caja = new System.Windows.Forms.TextBox();
            this.bEstudios = new System.Windows.Forms.Button();
            this.bProductores = new System.Windows.Forms.Button();
            this.bDirectores = new System.Windows.Forms.Button();
            this.bActores = new System.Windows.Forms.Button();
            this.bPelis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFechaAp = new System.Windows.Forms.Label();
            this.labelDireccionEstudio = new System.Windows.Forms.Label();
            this.labelNombreEstudio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listaq = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcome.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Controls.Add(this.label1);
            this.welcome.Location = new System.Drawing.Point(0, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(200, 100);
            this.welcome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido!";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.lista);
            this.panel.Controls.Add(this.button6);
            this.panel.Controls.Add(this.caja);
            this.panel.Controls.Add(this.bEstudios);
            this.panel.Controls.Add(this.bProductores);
            this.panel.Controls.Add(this.bDirectores);
            this.panel.Controls.Add(this.bActores);
            this.panel.Controls.Add(this.bPelis);
            this.panel.Location = new System.Drawing.Point(252, 221);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(435, 198);
            this.panel.TabIndex = 1;
            this.panel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(19, 86);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(399, 95);
            this.lista.Sorted = true;
            this.lista.TabIndex = 7;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(343, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 20);
            this.button6.TabIndex = 6;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // caja
            // 
            this.caja.AcceptsReturn = true;
            this.caja.AutoCompleteCustomSource.AddRange(new string[] {
            "🔎 Search..."});
            this.caja.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.caja.Location = new System.Drawing.Point(19, 19);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(318, 20);
            this.caja.TabIndex = 5;
            this.caja.Text = "🔎 Search...";
            this.caja.Click += new System.EventHandler(this.caja_TextChanged);
            this.caja.TextChanged += new System.EventHandler(this.caja_TextChanged);
            // 
            // bEstudios
            // 
            this.bEstudios.Location = new System.Drawing.Point(343, 57);
            this.bEstudios.Name = "bEstudios";
            this.bEstudios.Size = new System.Drawing.Size(75, 23);
            this.bEstudios.TabIndex = 4;
            this.bEstudios.Text = "Estudios";
            this.bEstudios.UseVisualStyleBackColor = true;
            this.bEstudios.Click += new System.EventHandler(this.bEstudios_Click);
            // 
            // bProductores
            // 
            this.bProductores.Location = new System.Drawing.Point(262, 57);
            this.bProductores.Name = "bProductores";
            this.bProductores.Size = new System.Drawing.Size(75, 23);
            this.bProductores.TabIndex = 3;
            this.bProductores.Text = "Productores";
            this.bProductores.UseVisualStyleBackColor = true;
            // 
            // bDirectores
            // 
            this.bDirectores.Location = new System.Drawing.Point(181, 57);
            this.bDirectores.Name = "bDirectores";
            this.bDirectores.Size = new System.Drawing.Size(75, 23);
            this.bDirectores.TabIndex = 2;
            this.bDirectores.Text = "Directores";
            this.bDirectores.UseVisualStyleBackColor = true;
            // 
            // bActores
            // 
            this.bActores.Location = new System.Drawing.Point(100, 57);
            this.bActores.Name = "bActores";
            this.bActores.Size = new System.Drawing.Size(75, 23);
            this.bActores.TabIndex = 1;
            this.bActores.Text = "Actores";
            this.bActores.UseVisualStyleBackColor = true;
            this.bActores.Click += new System.EventHandler(this.bActores_Click);
            // 
            // bPelis
            // 
            this.bPelis.Location = new System.Drawing.Point(19, 57);
            this.bPelis.Name = "bPelis";
            this.bPelis.Size = new System.Drawing.Size(75, 23);
            this.bPelis.TabIndex = 0;
            this.bPelis.Text = "Peliculas";
            this.bPelis.UseVisualStyleBackColor = true;
            this.bPelis.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelFechaAp);
            this.panel1.Controls.Add(this.labelDireccionEstudio);
            this.panel1.Controls.Add(this.labelNombreEstudio);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listaq);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 198);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelFechaAp
            // 
            this.labelFechaAp.AutoSize = true;
            this.labelFechaAp.Location = new System.Drawing.Point(16, 146);
            this.labelFechaAp.Name = "labelFechaAp";
            this.labelFechaAp.Size = new System.Drawing.Size(0, 13);
            this.labelFechaAp.TabIndex = 11;
            // 
            // labelDireccionEstudio
            // 
            this.labelDireccionEstudio.AutoSize = true;
            this.labelDireccionEstudio.Location = new System.Drawing.Point(16, 133);
            this.labelDireccionEstudio.Name = "labelDireccionEstudio";
            this.labelDireccionEstudio.Size = new System.Drawing.Size(0, 13);
            this.labelDireccionEstudio.TabIndex = 10;
            // 
            // labelNombreEstudio
            // 
            this.labelNombreEstudio.AutoSize = true;
            this.labelNombreEstudio.Location = new System.Drawing.Point(16, 120);
            this.labelNombreEstudio.Name = "labelNombreEstudio";
            this.labelNombreEstudio.Size = new System.Drawing.Size(0, 13);
            this.labelNombreEstudio.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listaq
            // 
            this.listaq.FormattingEnabled = true;
            this.listaq.Location = new System.Drawing.Point(12, 19);
            this.listaq.Name = "listaq";
            this.listaq.Size = new System.Drawing.Size(399, 95);
            this.listaq.Sorted = true;
            this.listaq.TabIndex = 7;
            this.listaq.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(689, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.welcome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.welcome.ResumeLayout(false);
            this.welcome.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox caja;
        private System.Windows.Forms.Button bEstudios;
        private System.Windows.Forms.Button bProductores;
        private System.Windows.Forms.Button bDirectores;
        private System.Windows.Forms.Button bActores;
        private System.Windows.Forms.Button bPelis;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listaq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNombreEstudio;
        private System.Windows.Forms.Label labelDireccionEstudio;
        private System.Windows.Forms.Label labelFechaAp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

