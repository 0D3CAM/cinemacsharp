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
    public partial class Excluir : Form
    {
        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }//fim do construtor

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();//fecha janela
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                long cpf = Convert.ToInt64(maskedTextBox1.Text);
                MessageBox.Show(bd.Excluir(cpf));

                //Limpar o Campo
                maskedTextBox1.Text = "";
            }
            catch(Exception erro) 
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        }//Botão excluir
    }
}
