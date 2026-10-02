using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;//Importar os elemento do MYSql

namespace cadastro_cliente
{

    internal class DAO // DATA ACCESS OBJECT
    {
        public MySqlConnection conexao;//Armazenar os parâmetros de configuração com o BD
        public int[] codigo;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;
        

        public DAO()
        {
            this.conexao = new MySqlConnection("server=localhost;Database=clienteCinema;Uid=root;password=");
            try
            {
                this.conexao.Open();//Abrir a conexao com o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!!!!!!\n\n" + erro);
            }
        }//fim do construtor

        public string Cadastrar(long CPF, string nome,string email, string telefone, string endereco)                               
        {
            string inserir = $"insert into cliente(codigo,cpf,nome,email,telefone,endereco) values" +
                             $"('','{CPF}', '{nome}','{email}','{telefone}','{endereco}')";

            //Começar a executar no banco
            MySqlCommand sql = new MySqlCommand(inserir, this.conexao);
            string resultado = sql.ExecuteNonQuery() + "Cadastrado!";
            return resultado;
        }

        public void PreencherVetor()
        {
            string consultar;
            consultar = "select * from cliente";

            //Instanciar os vetores

            this.codigo = new int[1000];
            this.cpf = new long[1000];
            this.nome = new string[1000];
            this.telefone = new string[1000];
            this.endereco = new string[1000];


            //Comandos de relação com o banco
            MySqlCommand sql = new MySqlCommand(consultar, this.conexao);

            //Leitura com o banco

            MySqlDataReader leitura = sql.ExecuteReader();

            this.i = 0; //Organizar preenchimento por posição
            this.contador = 0; //Contar quantidade de dados efetivamente no vetor

            //While
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.cpf[i] = Convert.ToInt64(leitura["cpf"]);
                this.nome[i] = leitura["nome"] + "";
                this.telefone[i] = leitura["telefone"] + "";
                this.endereco[i] = leitura["endereco"] + "";

                this.i++;//percorre o vetor
                this.contador++;//conta quantos dados estão no vetor

            }//fim do while

            //Encerrar o comando DAO
            leitura.Close();

        }//fim preencher vetor


        //Método que mostra a quantidade de dados 

        public int QuantidadeDeDados()
        {
            return this.contador;
        }

        public string Atualizar(long CPF, string nomeCampo, string novoDado)
        {
            string query = $"update cliente set {nomeCampo} = '{novoDado}' where cpf = '{CPF}'";
            MySqlCommand sql = new MySqlCommand (query, this.conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }
        public string Excluir(long CPF)
        {
            string query = $"update from cliente where cpf = '{CPF}'";
            MySqlCommand sql = new MySqlCommand (query, this.conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluído!";
            return resultado;
        }


    }//FIM da classe
}//fim do projeto