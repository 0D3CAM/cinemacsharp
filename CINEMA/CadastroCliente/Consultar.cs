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
    public partial class Consultar : Form
    {
        DAO bd;
        public Consultar()
        {
            InitializeComponent();
            bd = new DAO();

            //Configurar grid
            ConfigurarGrid();
            NomeDados();
            bd.PreencherVetor();//Método de consulta da DAO
            AdicionarLinhas();//Preencher grid
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do data grid view

        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "CPF";
            dataGridView1.Columns[2].Name = "Nome";
            dataGridView1.Columns[3].Name = "Telefone";
            dataGridView1.Columns[4].Name = "Endereço";

        }

        public void AdicionarLinhas()
        {
           for (int i = 0; i < bd.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.codigo[i], bd.cpf[i], bd.nome[i], bd.telefone[i], bd.endereco[i]);
            }// fim do for
        }

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;// nao pode add linhas
            dataGridView1.AllowUserToDeleteRows = false;// nao pode apagar linhas
            dataGridView1.AllowUserToResizeRows = false;// nao pode redimensionar linhas
            dataGridView1.AllowUserToResizeColumns = false;// nao pode redimensionar colunas
            dataGridView1.ColumnCount = 5;//Qtde colunas
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }
    }//fim da classe
}