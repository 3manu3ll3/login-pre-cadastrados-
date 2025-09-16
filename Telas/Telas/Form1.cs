namespace Telas
{
    public partial class Form1 : Form
    {
        const int tamanho = 5;
        string[] login = new string[tamanho];
        string[] senha = new string[tamanho];
        string[] nome = new string[tamanho];
        
        public Form1()
        {
            InitializeComponent();
            nome[0] = "Emanuellson";
            login[0] = "aaa";
            senha[0] = "aaahhh";

            nome[1] = "Carol";
            login[1] = "som";
            senha[1] = "choro";

            nome[2] = "Carleti";
            login[2] = "comI";
            senha[2] = "pqSim";

            nome[3] = "Priscila";
            login[3] = "pai";
            senha[3] = "nao";

            nome[4] = "teste";
            login[4] = "teste";
            senha[4] = "teste";

        }

        private void chkExibir_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !chkExibir.Checked;


        }
        bool flag = true;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tamanho; i++)
            {
                if (txtLogin.Text == login[i] && txtSenha.Text == senha[i])
                {
                    Form2 F2 = new Form2(nome[i]);
                    F2.ShowDialog();
                    this.Hide();
                    flag = false;
                }

            }
            if (flag) 
            {
                    MessageBox.Show("Login ou senha incorretos!", "ERRO", MessageBoxButtons.OK);

            }


        }
    }
}
