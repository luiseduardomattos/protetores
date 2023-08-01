using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace protetores
{
    public partial class Protetores : Form
    {
       

        public Protetores()
        {
            InitializeComponent();
        }

        private void Protetores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost:81, 127.0.0.1;username=root;database=adotapet1;password=");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO protetores (Nome, Email, Cpf, Telefone, Endereço, Bairro, Cidade, Estado, Senha) VALUES (@Nome, @Email, @Cpf, @Telefone, @Endereço, @Bairro, @Cidade, @Estado, @Senha);", conn);
            conn.Open();
            // INSERT (cnpj) VALUES (@CNPJ).

            cmd.Parameters.AddWithValue("@Nome", textBoxNome.Text);
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
            }

            cmd.Parameters.AddWithValue("@Email", Email.Text);
            if (Email.Text == "")
            {
                MessageBox.Show("Por favor, insira um Email no campo!");
                Email.Focus();
                return;
            }

            cmd.Parameters.AddWithValue("@Cpf", Cpf.Text);
            if (Cpf.Text == "")
            {
                MessageBox.Show("Por favor, insira um Cnpj ou Cpf campo!");
                Cpf.Focus();
                return;
            }

            cmd.Parameters.AddWithValue("@Telefone", textBoxTelefone.Text);
            if (textBoxTelefone.Text == "")
            {
                MessageBox.Show("Por favor, insira um Telefone no campo!");
                textBoxTelefone.Focus();
                return;
            }

            cmd.Parameters.AddWithValue("@Endereço", textBoxEndereco.Text);
            if (textBoxEndereco.Text == "")
            {
                MessageBox.Show("Por favor, insira um Endereço no campo!");
                textBoxEndereco.Focus();
                return;
            }

            cmd.Parameters.AddWithValue("@Bairro", textBoxBairro.Text);
            if (textBoxBairro.Text == "")
            { 
            MessageBox.Show("Por favor, insira um Bairro no campo!");
            textBoxBairro.Focus();
            return;
            }

            cmd.Parameters.AddWithValue("@Cidade", textBoxCidade.Text);
            if (textBoxCidade.Text == "")
            {
                MessageBox.Show("Por favor, insira uma Cidade no campo!");
                textBoxCidade.Focus();
                return;
            }

            cmd.Parameters.AddWithValue("@Estado", textBoxEstado.Text);
            if (textBoxEstado.Text == "")
            {
                MessageBox.Show("Por favor, insira um Estado no campo!");
                textBoxEstado.Focus();
                return;
            }

            cmd.Parameters.AddWithValue("@Senha", textBoxSenha.Text);
            if (textBoxSenha.Text == "")
            {
                MessageBox.Show("Por favor, insira uma Senha no campo!");
                textBoxSenha.Focus();
                return;
            }        



            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowAffected > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
                
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            Email.Clear();
            Cpf.Clear();
            textBoxTelefone.Clear();
            textBoxEndereco.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxEstado.Clear();
            textBoxSenha.Clear();

        }
    }
}



        
    

