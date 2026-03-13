namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            for (int i = 0; i <= 10; i++)
            {
                lboxTabuada.Items.Add($"{numero} x {i} = {numero * i}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lboxTabuada.Items.Clear();
            txtNumero.Focus();
        }
    }
}
