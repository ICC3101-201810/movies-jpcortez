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
        //Estudio estudio = new Estudio("hola", "sada", "sada");
        //Director d = new Director("ell", "director", "sd", "hola men");
        //Actor a = new Actor("the", "actor", "sdf", ":3");
        //Productor p = new Productor("musicologo", "xd", "lwek", "kjkhjk");
        BaseDeDatos bdd = new BaseDeDatos();

        public Form1()
        {
            //Pelicula peli = new Pelicula("SAD", "ayer", "olakase", d, 10);
            //PeliculaActor pa = new PeliculaActor(peli, a);
            //PeliculaProductor pp = new PeliculaProductor(peli, p);
            //bdd.estudio.Add(estudio);
            //bdd.actores.Add(a);
            //bdd.directores.Add(d);
            //bdd.productores.Add(p);
            //bdd.pelicula.Add(peli);
            //bdd.peliact.Add(pa);
            //bdd.peliprod.Add(pp);

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
            panel.Location = new Point(0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            welcome.Hide();
            panel.Show();
            timer1.Stop();
        }

        private void caja_TextChanged(object sender, EventArgs e)
        {
            List<string> lnombres = new List<string>();

            if (caja.Text == "🔎 Search...")
            {
                caja.Clear();
            }
            caja.ForeColor = Color.Black;
            if (caja.Text.Length < 3)
            {
                lnombres.Clear();
                lista.DataSource = lnombres;
                lista.ClearSelected();
                lista.Refresh();
                List<string> nada = new List<string>();
                nada.Add("");
                label2.ForeColor = Color.Red;
                label2.Text = "Ingrese al menos 3 caracteres";
            }
            else
            {
                label2.Text = " ";
                IEnumerable<Object> lest = from obj in bdd.estudio
                                           where obj.nombre.ToLower().Contains(caja.Text.ToLower())
                                           select obj;
                IEnumerable<Object> lpel = from obj in bdd.pelicula
                                           where obj.nombre.ToLower().Contains(caja.Text.ToLower())
                                           select obj;
                IEnumerable<Object> lact = from obj in bdd.actores
                                           where obj.nombre.ToLower().Contains(caja.Text.ToLower())
                                           select obj;
                IEnumerable<Object> lprod = from obj in bdd.productores
                                            where obj.nombre.ToLower().Contains(caja.Text.ToLower())
                                            select obj;
                IEnumerable<Object> ldir = from obj in bdd.directores
                                           where obj.nombre.ToLower().Contains(caja.Text.ToLower())
                                           select obj;
                foreach (Estudio a in lest)
                {
                    lnombres.Add(a.nombre);
                }
                foreach (Pelicula a in lpel)
                {
                    lnombres.Add(a.nombre);
                }
                foreach (Actor a in lact)
                {
                    lnombres.Add(a.nombre);
                }
                foreach (Productor a in lprod)
                {
                    lnombres.Add(a.nombre);
                }
                foreach (Actor a in ldir)
                {
                    lnombres.Add(a.nombre);
                }
                lista.DataSource = lnombres;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bdd.Serializar();
            this.Close();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel1.Show();
            listaq.DataSource = bdd.NombresPeli();
            labelNombreEstudio.Text = "Nombre: " + listaq.SelectedItem.ToString();
            labelDireccionEstudio.Text = "Director: " + bdd.GetPeli(listaq.SelectedItem.ToString()).director.nombre + bdd.GetPeli(listaq.SelectedItem.ToString()).director.apellido;
            labelFechaAp.Text = "Fecha estreno: " + bdd.GetPeli(listaq.SelectedItem.ToString()).fechaEstreno;
            label3.Text = "Presupuesto: " + bdd.GetPeli(listaq.SelectedItem.ToString()).presupuesto.ToString();
            label4.Text = "Descripción: " + bdd.GetPeli(listaq.SelectedItem.ToString()).descripcion;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> vacio = new List<string>();
            vacio.Add("hola");
            vacio.Clear();
            listaq.DataSource = vacio;
            listaq.Refresh();
            label5.Text = "";
            panel1.Hide();
            panel.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bEstudios_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel1.Show();
            listaq.DataSource = bdd.NombresEstudio();
            labelNombreEstudio.Text = "Nombre: " + listaq.SelectedItem.ToString();
            labelDireccionEstudio.Text = "Dirección: " + bdd.GetEstudio(listaq.SelectedItem.ToString()).direccion;
            labelFechaAp.Text = "Fecha apertura: " + bdd.GetEstudio(listaq.SelectedItem.ToString()).fechaAp;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bActores_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel1.Show();
            listaq.DataSource = bdd.NombresActores();
            labelNombreEstudio.Text = "Nombre: " + listaq.SelectedItem.ToString();
            labelDireccionEstudio.Text = "Fecha nacimiento: " + bdd.GetActor(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]).fechaN;
            //labelFechaAp.Text = "Fecha estreno: " + bdd.GetPeli(listaq.SelectedItem.ToString()).fechaEstreno;
            //label3.Text = "Presupuesto: " + bdd.GetPeli(listaq.SelectedItem.ToString()).presupuesto.ToString();
            label4.Text = "Biografía: " + bdd.GetActor(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]).bio;
            string qq = "Ha participado en: \n";
            foreach (PeliculaActor pa in bdd.peliact)
            {
                if (pa.actor == bdd.GetActor(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]))
                {
                    qq += pa.pelicula.nombre+"\n";
                }
            }
            label5.Text = qq;
        }

        private void bDirectores_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel1.Show();
            listaq.DataSource = bdd.NombresDir();
            labelNombreEstudio.Text = "Nombre: " + listaq.SelectedItem.ToString();
            labelDireccionEstudio.Text = "Fecha nacimiento: " + bdd.GetDirector(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]).fechaN;
            //labelFechaAp.Text = "Fecha estreno: " + bdd.GetPeli(listaq.SelectedItem.ToString()).fechaEstreno;
            //label3.Text = "Presupuesto: " + bdd.GetPeli(listaq.SelectedItem.ToString()).presupuesto.ToString();
            label4.Text = "Biografía: " + bdd.GetDirector(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]).bio;
        }

        private void bProductores_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel1.Show();
            listaq.DataSource = bdd.NombresProd();
            labelNombreEstudio.Text = "Nombre: " + listaq.SelectedItem.ToString();
            labelDireccionEstudio.Text = "Fecha nacimiento: " + bdd.GetProductor(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]).fechaN;
            //labelFechaAp.Text = "Fecha estreno: " + bdd.GetPeli(listaq.SelectedItem.ToString()).fechaEstreno;
            //label3.Text = "Presupuesto: " + bdd.GetPeli(listaq.SelectedItem.ToString()).presupuesto.ToString();
            label4.Text = "Biografía: " + bdd.GetProductor(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]).bio;
            string qq = "Ha participado en: \n";
            foreach (PeliculaProductor pa in bdd.peliprod)
            {
                if (pa.productor == bdd.GetProductor(listaq.SelectedItem.ToString().Split(' ')[0], listaq.SelectedItem.ToString().Split(' ')[1]))
                {
                    qq += pa.pelicula.nombre + "\n";
                }
            }
            label5.Text = qq;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
