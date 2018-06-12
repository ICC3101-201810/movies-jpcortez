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
            this.Panel = new System.Windows.Forms.Panel();
            this.lista = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.caja = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.welcome.SuspendLayout();
            this.Panel.SuspendLayout();
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
            // Panel
            // 
            this.Panel.Controls.Add(this.lista);
            this.Panel.Controls.Add(this.button6);
            this.Panel.Controls.Add(this.caja);
            this.Panel.Controls.Add(this.button5);
            this.Panel.Controls.Add(this.button4);
            this.Panel.Controls.Add(this.button3);
            this.Panel.Controls.Add(this.button2);
            this.Panel.Controls.Add(this.button1);
            this.Panel.Location = new System.Drawing.Point(221, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(435, 208);
            this.Panel.TabIndex = 1;
            this.Panel.Visible = false;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(19, 96);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(399, 95);
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
            this.caja.AutoCompleteCustomSource.AddRange(new string[] {
            "🔎 Search..."});
            this.caja.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.caja.Location = new System.Drawing.Point(19, 19);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(318, 20);
            this.caja.TabIndex = 5;
            this.caja.Text = "🔎Search...";
            this.caja.Click += new System.EventHandler(this.caja_TextChanged);
            this.caja.TextChanged += new System.EventHandler(this.caja_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(343, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Estudios";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Productores";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Directores";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actores";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Peliculas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1010, 485);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.welcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.welcome.ResumeLayout(false);
            this.welcome.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox caja;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox lista;
    }
}

