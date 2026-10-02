using cadastro_cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Cadastrar : Form
    {
        DAO bd;//chamando a classe DAO

        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();//instanciando a variavel bd e abrindo a conexao com o banco
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            

        }

        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",", "");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        public void LimparTela()
        {
            maskedTextBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox2.Text = "";
            textBox4.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //BOTAO CONFIRMAR
        {
            try
            {
                string cpf = RemoverFormatacaoCPF(maskedTextBox1.Text);
                string nome = textBox2.Text;
                string email = textBox1.Text;
                string telefone = maskedTextBox2.Text;
                string endereco = textBox4.Text;


                #region dados cadastro
                //long CPF, string nome,string email, string telefone, string endereco, long cartaoCodigo
                #endregion

                //Cadastro no Banco
                MessageBox.Show(bd.Cadastrar(Convert.ToInt64(cpf),nome,email,endereco,telefone));
               
            


                //Limpar tela 
                LimparTela();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n \n" + erro);
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
