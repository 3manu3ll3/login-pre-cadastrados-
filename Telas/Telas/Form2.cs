using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class Form2 : Form
    {
        public Form2(string nome)
        {
            InitializeComponent();
            lblLolgon.Text = nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarEscolha(); // Método a ser execultado 
        }

        public void verificarEscolha()
        {
            string[] escolhas = new string[3];

            if (chkCorrer.Checked)
            {
                escolhas[0] = chkCorrer.Text;
            }
            if (chkNadar.Checked)
            {
                escolhas[1] = chkNadar.Text;
            }
            if (chkPedalar.Checked)
            {
                escolhas[2] = chkPedalar.Text;
            }

            //lblResultado.Text = escolhas[0]+ "\n" + escolhas[1] + "\n" + escolhas[2];[
            lblResultado.Text = string.Join("\n", escolhas);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form43 F3 = new Form43();
            F3.ShowDialog();
        }
    }
}
