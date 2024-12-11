using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoObras.models;
using System.Data.SqlClient;
using GestaoObras.models.Singleton;

namespace GestaoObras
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {

            UsernameTextBox.Clear();
            PasswordTextBox.Clear();

            UsernameTextBox.Focus();

        }


        #region Login Button
        private void Loginbutton_Click(object sender, EventArgs e)
        {

            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                
                if (ValidarLogin(username, password))
                {
                    
                    MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    Form1 principalForm = new Form1();
                    principalForm.Show();

                    
                    this.Hide();
                }
                else
                {
                    // Exibir mensagem de erro
                    MessageBox.Show("Nome de utilizador ou password incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Exibir mensagem caso os campos estejam vazios
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarLogin(string username, string password)
        {
            try
            {
                // Log para verificar o nome de utilizador recebido
                Console.WriteLine($"Tentativa de login com: {username}");

                // Obter a instância do Singleton
                BDSingleton DB = BDSingleton.Instancia;

                // Query SQL para buscar o hash da senha baseado no nome de utilizador
                string query = "SELECT PasswordHash FROM Login WHERE Username = @Username";

                // Configurar o parâmetro
                SqlParameter[] parametros = {
            new SqlParameter("@Username", username) // Substituirá @Username na query
        };

                // Executar a consulta e obter os resultados
                DataTable resultado = DB.ConsultaTabela(query, parametros);

                // Log para verificar o número de resultados encontrados
                Console.WriteLine($"Número de resultados encontrados: {resultado.Rows.Count}");

                if (resultado.Rows.Count > 0)
                {
                    // Obter o hash da senha armazenado no banco de dados
                    string storedHash = resultado.Rows[0]["PasswordHash"].ToString();

                    // Log para verificar o hash retornado
                    Console.WriteLine($"Hash encontrado no banco: {storedHash}");

                    // Verificar a senha usando BCrypt
                    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHash);

                    // Log para verificar se a senha é válida
                    Console.WriteLine($"Senha válida: {isPasswordValid}");

                    return isPasswordValid;
                }
                else
                {
                    // Caso o utilizador não seja encontrado
                    Console.WriteLine("Nome de utilizador não encontrado.");
                    MessageBox.Show("Nome de utilizador não encontrado.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Log e mensagem em caso de erro
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornar falso caso ocorra algum problema
            return false;
        }

        #endregion

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é a tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Simula o clique do botão Login
                Loginbutton.PerformClick();
            }
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();

            registerForm.ShowDialog();
        }
    }
}
