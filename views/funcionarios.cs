using projeto_vendas.dao;
using projeto_vendas.model;
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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {

        }

        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            //Botao salvar
            funcionario obj = new funcionario();

            //receber os dados dos campos
            obj.Nome = txtnome.Text;
            obj.Rg = txtrg.Text;
            obj.Cpf = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.Telefone = txttel.Text;
            obj.Celular = txtcel.Text;
            obj.Cep = txtcep.Text;
            obj.Endereco = txtend.Text;
            obj.Numero = int.Parse(txtnumero.Text);
            obj.Complemento = txtcomp.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcity.Text;
            obj.Estado = txtestado.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();

            //criar o objeto funcionarioDAO
            funcionarioDAO dao = new funcionarioDAO();
            dao.cadastrarFuncionario(obj);
        }
    }
}
