namespace GestaoObras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // Inicializa e configura o painel
            panelContainer = new Panel();
            panelContainer.Name = "panelContainer";
            panelContainer.Dock = DockStyle.Fill; // O painel ocupa todo o espaço disponível
            this.Controls.Add(panelContainer); // Adiciona o painel ao formulário principal
        }


        #region toolstrip
        private void ClientesButton_Click(object sender, EventArgs e)
        {
            ClienteForm ecraCliente = new ClienteForm();
            ecraCliente.Show();

        }

        private Panel panelContainer;


        //private void AbrirFormNoPanel(Form ecrancliente)
        //{
        //    // Limpa o painel antes de abrir um novo formulário
        //    panelContainer.Controls.Clear();

        //    // Configura o formulário filho para se ajustar ao painel
        //    ecrancliente.TopLevel = false; // Define que o formulário não é de nível superior
        //    ecrancliente.FormBorderStyle = FormBorderStyle.None; // Remove bordas do formulário
        //    ecrancliente.Dock = DockStyle.Fill; // Faz o formulário preencher o painel

        //    // Adiciona o formulário ao painel e o exibe
        //    panelContainer.Controls.Add(ecrancliente);
        //    panelContainer.Tag = ecrancliente; // Opcional: salva referência
        //    ecrancliente.Show();
        //}

        #endregion

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Armazem_Click(object sender, EventArgs e)
        {
            ArmazemForm ecraArmazem = new ArmazemForm();
            ecraArmazem.Show();
        }
    }
}
