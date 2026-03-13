namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double cotacao = Convert.ToDouble(txtCotacao.Text);
            double dolar = Convert.ToDouble(txtDolares.Text);

            double Real = dolar * cotacao;

            lblResultado.Text = ($"O valor convertido é R${Real}");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCotacao.Clear();
            txtDolares.Clear();
            lblResultado.Text = "";
            txtCotacao.Focus();
        }
    }
}
