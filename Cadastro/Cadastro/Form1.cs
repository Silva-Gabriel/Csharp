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
            //Cada vez que clica em salvar adiciona 1 aos cliques
            Cliques++;
            string nomeUsuario, sobrenomeUsuario, JogoFav, SerieFav;
            DateTime dataNascimento;
            bool Masculino, Feminino, NoSay;


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
                   
                //Concatenando nome e sobrenome
                string NomeCompleto = nomeUsuario + " " + sobrenomeUsuario;

            //verificando espaços nulos
            if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrWhiteSpace(sobrenomeUsuario) || string.IsNullOrWhiteSpace(JogoFav) || string.IsNullOrWhiteSpace(SerieFav) 
                || string.IsNullOrWhiteSpace(Estado) || Masculino == false && Feminino == false && NoSay == false)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            //Se passar pelo if,todos os campos foram preenchidos corretamente
            else
            {
                MessageBox.Show($"CADASTRO CONCLUÍDO COM SUCESSO!", "Boas-Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);   //Cria uma lista de nomes,pronta para receber string
                List<string> nomes;
                nomes = new List<string>();      //Instanciando a lista
                for (int i = 0; i < 1; i++)
                {
                    nomes.Add(NomeCompleto);    //Adiciona o nome a lista nomes
                }
                List<string> estadoUsuario;
                estadoUsuario = new List<string>();
                foreach (string NewEstado in estadoUsuario)
                {
                    estadoUsuario.Add(Estado);
                }

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine($"Cadastro #{Cliques}: {nomes[i]}-{Estado}");     //Imprime no console o nome e estado dos cadastrados
                }
                //Limpa os campos ao clicar em 'Salvar'
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.ResetText();
                comboBox2.ResetText();
                ComboBox3.ResetText();

                //Limpando os radiosButtons
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;


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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
