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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // tela cliente
        {

        }

        private void label1_Click(object sender, EventArgs e) //TituloPagina
        {

        }

        private void Opcao_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Mostrar a tela
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Atualizar att = new Atualizar();
            att.ShowDialog();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultar consul = new Consultar();
            consul.ShowDialog();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Excluir exclu = new Excluir();
            exclu.ShowDialog();
        }
    }
}
