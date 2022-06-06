using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaTI14T
{
    public partial class Form1 : Form
    {
        DAOPessoa pessoa;
        public Form1()
        {
            InitializeComponent();
            pessoa = new DAOPessoa();//Abrindo a conexão com o BD
        }//Fim do método Construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//MaskedTextbox CPF

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Textbox código

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //int codigo = Convert.ToInt32(textBox1.Text);//Coletando o dado do campo código
                MessageBox.Show(maskedTextBox1.Text);
                string tratamentoCPF = maskedTextBox1.Text.Replace(",", "");
                tratamentoCPF = tratamentoCPF.Replace("-", "");
                long cpf = Convert.ToInt64(tratamentoCPF);//Coletando o dado do campo CPF
                string nome = textBox2.Text;//Coletando o dado do campo Nome
                string telefone = maskedTextBox2.Text;//Coletando o dado do campo Telefone
                string endereco = textBox4.Text;//Coletando o dado do campo Endereço

                //Chamar o método Inserir que foi criado na DAOPessoa

                pessoa.Inserir(cpf, nome, telefone, endereco);//Com isso, vou Inserir no banco os dados do meu formulário
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }//Fim do botão Cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {

        }//Fim do botão Consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }//Fim do botão Atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {

        }//Fim do botão Excluir

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }//TextBox Nome

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//MaskedTextBox Telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Textbox Endereço

        private void label1_Click(object sender, EventArgs e)
        {

        }//Label Pessoa
    }//Fim da classe
}//Fim do projeto
