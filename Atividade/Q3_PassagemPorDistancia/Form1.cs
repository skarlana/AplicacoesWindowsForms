using System.Configuration;
using System.Drawing;

namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia = Convert.ToDouble(txtDistancia.Text);
            double valor;

            if (distancia <= 200)
            {
                valor = distancia * 0.50;
            }
            else
            {
                valor = distancia * 0.45;
            }

            lblResultado.Text = ($"O preço da passagem será: R${valor}");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDistancia.Clear();
            lblResultado.Text = "";
            txtDistancia.Focus();
        }
    }
}
