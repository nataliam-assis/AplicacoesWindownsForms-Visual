using System.Windows.Forms;

namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;

        private void btnGerar_Click(object sender, EventArgs e)
        {

            int tabuadaUser = Convert.ToInt32(txtNumero.Text);

            for (int i = 0; i <= 10; i++)
            {
                lstTabuada.Items.Add($"{i} x {tabuadaUser} = {i * tabuadaUser}");
            }
        }
    }
}
