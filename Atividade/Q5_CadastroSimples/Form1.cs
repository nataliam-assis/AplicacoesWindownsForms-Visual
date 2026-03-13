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
            Pessoa NovoCadastro = new Pessoa();
            NovoCadastro.Nome = txtNome.Text;
            NovoCadastro.Idade = Convert.ToInt32(txtIdade.Text);

            Repositorio.PessoaCadastrada.Add(NovoCadastro);

            lstPessoas.Items.Add($"Nome: {NovoCadastro.Nome} Idade: {NovoCadastro.Idade}");
            
            
        }
    }
}
