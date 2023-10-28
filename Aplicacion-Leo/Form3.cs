﻿using System;
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
    public partial class Form3 : Form
    {
        int c2 = 0;

        private int n = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nm = "♦";
            string ap = "♦";
            string eq = "♦";
            string ed = "♦";
            string nj = "♦";
            string tp = "♦";
            string ts = "♦";
            string tt = "♦";

            int n2 = 0;

            if (textBox1.Text == string.Empty)
            {
                nm = "Nombre";
                n2++;
            }
            if (textBox2.Text == string.Empty)
            {
                eq = "Equipo";
                n2++;
            }
            if (textBox3.Text == string.Empty)
            {
                ed = "Edad";
                n2++;
            }
            else
            {
                try
                {
                    int edd = int.Parse(textBox3.Text);
                    if (edd <= 0)
                    {
                        ed = "La edad debe ser positiva y mayor a cero";
                        n2++;
                    }
                }
                catch
                {
                    ed = "La edad debe ser un numero entero";
                    n2++;
                }
            }
            if (textBox8.Text == string.Empty)
            {
                ap = "Apellido";
                n2++;
            }
            if (textBox4.Text == string.Empty)
            {
                nj = "Numero de Jugador";
                n2++;
            }
            else
            {
                try
                {
                    float tl = float.Parse(textBox4.Text);
                    if (tl <= 0)
                    {
                        nj = "El numero de jugador debe ser positiva y mayor a cero";
                        n2++;
                    }
                }
                catch
                {
                    nj = "El numero de jugador debe ser un numero entero";
                    n2++;
                }
            }
            if (comboBox1.Text == string.Empty)
            {
                tp = "Talla Playera";
                n2++;
            }
            if (comboBox2.Text == string.Empty)
            {
                ts = "Talla Short";
                n2++;
            }
            if (comboBox3.Text == string.Empty)
            {
                tt = "Talla Tenis";
                n2++;
            }

            if (n2 != 0)
            {
                MessageBox.Show("Rellena los siguientes apartados" + "\n" + nm + "\n" + ap + "\n" + ed + "\n" + eq + "\n" + nj + "\n" + tp + "\n" + ts + "\n" + tt, "Sistema de verificacion de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (c2 == 0)
                {

                    //colocar el codigo
                    int n = dataGridView1.Rows.Add();

                    // colocamos la información 
                    dataGridView1.Rows[n].Cells[1].Value = textBox8.Text;
                    dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[n].Cells[5].Value = comboBox1.Text;
                    dataGridView1.Rows[n].Cells[7].Value = comboBox3.Text;
                    dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
                    dataGridView1.Rows[n].Cells[3].Value = textBox2.Text;
                    dataGridView1.Rows[n].Cells[4].Value = textBox4.Text;
                    dataGridView1.Rows[n].Cells[6].Value = comboBox2.Text;

                    //limpiamos los txt 
                    textBox8.Text = "";
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    comboBox3.Text = "";
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    comboBox2.Text = "";
                    //limpiamos los txt 

                }
                else
                {
                    int r2 = dataGridView1.SelectedRows.Count - 1;

                    dataGridView1.Rows[r2].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[r2].Cells[1].Value = textBox8.Text;
                    dataGridView1.Rows[r2].Cells[2].Value = textBox3.Text;
                    dataGridView1.Rows[r2].Cells[3].Value = textBox2.Text;
                    dataGridView1.Rows[r2].Cells[4].Value = textBox4.Text;
                    dataGridView1.Rows[r2].Cells[5].Value = comboBox1.Text;
                    dataGridView1.Rows[r2].Cells[6].Value = comboBox2.Text;
                    dataGridView1.Rows[r2].Cells[7].Value = comboBox3.Text;

                    //limpiamos los txt 
                    textBox1.Text = "";
                    textBox8.Text = "";
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    //limpiamos los txt 

                    c2 = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecciona un renglon valido", "Editor ALMACEN DE VIDEOJUEGOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBox8.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    comboBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                    c2 = 1;
                }
                catch
                {
                    MessageBox.Show("Datos invalidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (n != -1)
                {
                    dataGridView1.Rows.RemoveAt(n);
                }
            }
            catch
            {
                MessageBox.Show("No existe este renglon", "Verificacion de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
}
