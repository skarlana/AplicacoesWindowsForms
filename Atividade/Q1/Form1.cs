namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtCelsius.Text);

            double F = (celsius * 9 / 5) + 32;

            lblResultado.Text = ($"A temperatura digitada convertida para Fahrenheit é: {F}F");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            lblResultado.Text = "";
            txtCelsius.Focus();

        }
    }
}
