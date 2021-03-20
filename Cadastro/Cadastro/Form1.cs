using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Cliques = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Cliques++;
            string nomeUsuario, sobrenomeUsuario, JogoFav, SerieFav;
            DateTime dataNascimento;
            bool Masculino, Feminino, NoSay;

            int.TryParse(quantidadeCadastros.Text, out var Cadastro);

                //Armazenando os dados
                nomeUsuario = textBox1.Text;
                sobrenomeUsuario = textBox2.Text;
                dataNascimento = dateTimePicker1.Value;
                JogoFav = comboBox1.Text;
                Masculino = radioButton1.Checked;
                Feminino = radioButton2.Checked;
                NoSay = radioButton3.Checked;
                SerieFav = comboBox2.Text;
                string Estado = ComboBox3.Text;
      
                string NomeCompleto = nomeUsuario + " " + sobrenomeUsuario;

                //validando espaços nulos
                if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrWhiteSpace(sobrenomeUsuario)
                    || string.IsNullOrWhiteSpace(JogoFav) || string.IsNullOrWhiteSpace(SerieFav)|| string.IsNullOrWhiteSpace(Estado) && Masculino == true || Feminino == true || NoSay == true)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (Masculino == false && Feminino == false && NoSay == false)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            if (Masculino == true || Feminino == true || NoSay == true)
            {
                MessageBox.Show($"CADASTRO CONCLUÍDO COM SUCESSO!", "Boas-Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<string> nomes;
                nomes = new List<string>();
                for (int i = 0; i < 1; i++)
                {
                    nomes.Add(NomeCompleto);
                }
                List<string> estadoUsuario;
                estadoUsuario = new List<string>();
                foreach (string NewEstado in estadoUsuario)
                {
                    estadoUsuario.Add(Estado);
                }

                for (int i = 0; i < nomes.Count; i++)
                {
                    Console.WriteLine($"Cadastro #{Cliques}: {nomes[i]}-{Estado}");
                }
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.ResetText();
                comboBox2.ResetText();
                ComboBox3.ResetText();
            }

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
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void quantidadeCadastros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
