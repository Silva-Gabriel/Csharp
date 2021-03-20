using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario,sobrenomeUsuario,JogoFav,SerieFav;
            DateTime dataNascimento;
            bool Masculino,Feminino,NoSay;


            nomeUsuario = textBox1.Text;
            sobrenomeUsuario = textBox2.Text;
            dataNascimento = dateTimePicker1.Value;
            JogoFav = comboBox1.Text;
            Masculino = radioButton1.Checked;
            Feminino = radioButton1.Checked;
            NoSay = radioButton1.Checked;
            SerieFav = comboBox2.Text;


            if (Masculino == true)
            {
                MessageBox.Show($"Olá, {nomeUsuario} {sobrenomeUsuario}\n{dataNascimento}\nMasculino", "Boas-Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Feminino == true)
            {
                MessageBox.Show($"Olá, {nomeUsuario} {sobrenomeUsuario}\n{dataNascimento}\nFeminino", "Boas-Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show($"Olá, {nomeUsuario} {sobrenomeUsuario} Seja bem vindo\nSeus dados:\nPrefiro não dizer\nJogo favorito: {JogoFav}\nSérie Favorita: {SerieFav}", "Boas-Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show($"Data de nascimento: {dataNascimento}\n");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
