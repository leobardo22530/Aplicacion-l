using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Leo
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nm = "♦";
            string ap = "♦";
            string ed = "♦";
            string añ = "♦";
            string rd = "♦";
            string rt = "♦";
            string gn = "♦";
            string lg = "♦";

            int n = 0;
            int r = 0;

            if (textBox1.Text == string.Empty)
            {
                nm = "Nombre";
                n++;
            }
            if (textBox2.Text == string.Empty)
            {
                ap = "Apellido";
                n++;
            }
            if (textBox4.Text == string.Empty)
            {
                ed = "Edad";
                n++;
            }
            else
            {
                try
                {
                    int edd =int.Parse(textBox4.Text);
                    if(edd <= 0)
                    {
                        ed = "La edad debe ser positiva y mayor a cero";
                        n++;
                    }
                }
                catch
                {
                    ed = "La edad debe ser un numero entero";
                    n++;
                }
            }
            if (textBox3.Text == string.Empty)
            {
                añ = "Años de servicio";
                n++;
            }
            else
            {
                try
                {
                    int ad = int.Parse(textBox3.Text);
                    if (ad <= 0)
                    {
                        añ = "Los años deben ser positivos y mayores a cero";
                        n++;
                    }
                }
                catch
                {
                    añ = "Los años deben ser un numero entero";
                    n++;
                }
            }
            if (CB1.Text == string.Empty)
            {
                rd = "Residencia";
                n++;
            }
            if (CB2.Text == string.Empty)
            {
                rt = "Retiro";
                n++;
            }
            if (LIB1.Text == string.Empty)
            {
                lg = "Liga";
                n++;
            }
            if(radioButton1.Checked|| radioButton2.Checked|| radioButton3.Checked)
            {
                r = 1;
            }
            else
            {
                gn = "Genero";
            }

            if (n == 0 && r == 1)
            {
                MessageBox.Show("Bienvenido", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Rellena los siguientes apartados" + "\n" + nm + "\n" + ap + "\n" + ed + "\n" + añ + "\n" + rd + "\n" + rt + "\n" + gn + "\n" + lg, "Sistema de verificacion de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
