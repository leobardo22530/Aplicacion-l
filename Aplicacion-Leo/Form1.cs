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
    public partial class Form1 : Form
    {
        private const string a = "*";

        private char A = char.Parse(a);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form0 f0 = new Form0();
            f0.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("El usuario y contraseña son incorrectos", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBox2.Text != "lb")
                    {
                        MessageBox.Show("El usuario y contraseña son incorrectos", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El usuario es incorrecto", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (textBox2.Text == string.Empty)
                {
                    if (textBox1.Text != "Leobardo")
                    {
                        MessageBox.Show("El usuario y contraseña son incorrectos", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (textBox1.Text != "Leobardo" && textBox2.Text != "lb")
                    {
                        MessageBox.Show("El usuario y contraseña son incorrectos", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text != "Leobardo" && textBox2.Text == "lb")
                    {
                        MessageBox.Show("El usuario es incorrecto", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text == "Leobardo" && textBox2.Text != "lb")
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text == "Leobardo" && textBox2.Text == "lb")
                    {
                        MessageBox.Show("Bienvenido", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 f2 = new Form2();
                        f2.Show();
                        Hide();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = A;
            }
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            Font S = new Font("Times New Roman", 9.75f, FontStyle.Underline);
            label4.Font = S;
            label4.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Font n = new Font("Times New Roman", 9.75f, FontStyle.Regular);
            label4.Font = n;
            label4.ForeColor = Color.White;
        }
    }
}
