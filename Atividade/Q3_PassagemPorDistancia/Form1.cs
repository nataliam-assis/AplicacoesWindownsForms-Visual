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

            if (distancia < 200)
            {
                lblResultado.Text = Convert.ToString(distancia * 0.50);
            }
            else
            {
                lblResultado.Text = Convert.ToString(distancia * 0.45);
            }
        }
    }
}
