using projeto_vendas.dao;
using projeto_vendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_vendas.views
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

           // obj.Id = int.Parse(txtcod.Text);
            obj.Nome = txtnome.Text;
            obj.Rg = txtrg.Text;
            obj.Cpf = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.Telefone = txttel.Text;
            obj.Celular = txtcel.Text;
            obj.Cep = txtcep.Text;
            obj.Endereco = txtend.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            obj.Complemento = txtcomp.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcity.Text;
            obj.Estado = cbestado.Text;

            //Criar um objeto da classe clienteDAO e chamar o cadastrar

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            dtgclientes.DataSource = dao.listarClientes();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dtgclientes.DataSource = dao.listarClientes();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonexcluir_Click(object sender, EventArgs e)
        {
            //botao excluir
            Cliente obj = new Cliente();


            // pegar o codigo 
            obj.Id = int.Parse(txtcod.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.excluirCliente(obj);

            dtgclientes.DataSource = dao.listarClientes();
        }

        private void dtgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                //pegar os dados das linhas 

                txtcod.Text = dtgclientes.CurrentRow.Cells[0].Value.ToString();
                txtnome.Text = dtgclientes.CurrentRow.Cells[1].Value.ToString();
                txtrg.Text = dtgclientes.CurrentRow.Cells[2].Value.ToString();
                txtcpf.Text = dtgclientes.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = dtgclientes.CurrentRow.Cells[4].Value.ToString();
                txttel.Text = dtgclientes.CurrentRow.Cells[5].Value.ToString();
                txtcel.Text = dtgclientes.CurrentRow.Cells[6].Value.ToString();
                txtcep.Text = dtgclientes.CurrentRow.Cells[7].Value.ToString();
                txtend.Text = dtgclientes.CurrentRow.Cells[8].Value.ToString();
                txtnumero.Text = dtgclientes.CurrentRow.Cells[9].Value.ToString();
                txtcomp.Text = dtgclientes.CurrentRow.Cells[10].Value.ToString();
                txtbairro.Text = dtgclientes.CurrentRow.Cells[11].Value.ToString();
                txtcity.Text = dtgclientes.CurrentRow.Cells[12].Value.ToString();
                cbestado.Text = dtgclientes.CurrentRow.Cells[13].Value.ToString();

                tabControl1.SelectedTab = tabCadastro;            
        }

        private void buttonalterar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            
            obj.Nome = txtnome.Text;
            obj.Rg = txtrg.Text;
            obj.Cpf = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.Telefone = txttel.Text;
            obj.Celular = txtcel.Text;
            obj.Cep = txtcep.Text;
            obj.Endereco = txtend.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            obj.Complemento = txtcomp.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcity.Text;
            obj.Estado = cbestado.Text;
            //obj.Id = txtcod.Text;

            //Criar um objeto da classe clienteDAO e chamar o alterar

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            // recarregar o datagrid view
            dtgclientes.DataSource = dao.listarClientes();

        }
    }
}

//tabCadastro.SelectedTab = tabClientes;