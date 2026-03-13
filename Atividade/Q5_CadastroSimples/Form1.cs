namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Repositorio repositorio = new Repositorio();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            Pessoa novaPessoa = new Pessoa();

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            novaPessoa.Nome = txtNome.Text;
            novaPessoa.Idade = txtIdade.Text;

            Repositorio.PessoaCadastrada.Add(novaPessoa);

            lboxPessoas.Items.Add($"{novaPessoa.Nome} | {novaPessoa.Idade}");

           
        }
    }
}
