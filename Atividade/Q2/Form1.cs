namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntConverter_Click(object sender, EventArgs e)
        {
            double cotação = Convert.ToDouble(txtCotacao.Text);
            double resultado = cotação * Convert.ToDouble(txtDolares.Text);
            lblResultado.Text = resultado.ToString();
            
        }
    }
}
