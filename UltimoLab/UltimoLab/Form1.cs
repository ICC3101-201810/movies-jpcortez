using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace UltimoLab
{
    public partial class Form1 : Form
    {
        BaseDeDatos bdd = new BaseDeDatos();
        public Form1()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open("bdd.txt", FileMode.Open);
                bdd = (BaseDeDatos)bf.Deserialize(fs);
                fs.Close();
            }
            catch
            {

            }
            InitializeComponent();
            Panel.Location = new Point(0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            welcome.Hide();
            Panel.Show();
        }

        private void caja_TextChanged(object sender, EventArgs e)
        {
            caja.Clear();
            caja.ForeColor = Color.Black;       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bdd.Serializar();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
