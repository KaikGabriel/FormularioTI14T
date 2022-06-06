using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PessoaTI14T
{
    class DAOPessoa
    {
        public string dados;
        public MySqlConnection conexao;
        public string comando;
        public string resultado;
        public DAOPessoa()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=turma14;Uid=root;password=");
            try
            {
                conexao.Open();//Tentando conectar ao BD
                MessageBox.Show("Conectado com Sucesso!");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);//Mensagem de erro
                conexao.Close();//Fechando a conexão com o BD
            }
        }//Fim DAOPessoa

        public void Inserir(long cpf,string nome, string telefone, string endereco)
        {
            try
            {
                //Preparar os dados para inserir no BD
                dados = "('','" + cpf + "','" + nome + "','" + telefone + "','" + endereco + "')";
                comando = "Insert into pessoaTI14T(codigo, cpf, nome, telefone, endereco) values " + dados;

                //Executar o comando na base de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + " linha(s) afetada(s)!");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//Fim do método inserir

    }//Fim classe
}//Fim do projeto
