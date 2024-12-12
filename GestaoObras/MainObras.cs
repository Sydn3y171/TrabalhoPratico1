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
            panelContainer.Dock = DockStyle.Fill; // O painel ocupa todo o espa�o dispon�vel
            this.Controls.Add(panelContainer); // Adiciona o painel ao formul�rio principal
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
        //    // Limpa o painel antes de abrir um novo formul�rio
        //    panelContainer.Controls.Clear();

        //    // Configura o formul�rio filho para se ajustar ao painel
        //    ecrancliente.TopLevel = false; // Define que o formul�rio n�o � de n�vel superior
        //    ecrancliente.FormBorderStyle = FormBorderStyle.None; // Remove bordas do formul�rio
        //    ecrancliente.Dock = DockStyle.Fill; // Faz o formul�rio preencher o painel

        //    // Adiciona o formul�rio ao painel e o exibe
        //    panelContainer.Controls.Add(ecrancliente);
        //    panelContainer.Tag = ecrancliente; // Opcional: salva refer�ncia
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
