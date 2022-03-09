using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarStringAleatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GerarStringAleatoria(int tamanho)
        {
            Random random = new Random();
            const string dicionario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            var resultado = new string(
                Enumerable.Repeat(dicionario, tamanho)
              .Select(s => s[random.Next(s.Length)])
              .ToArray());
            
            btnCopiar.Enabled = true;
            
            return resultado;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int quantidade = (int)nudQuantidade.Value;
            lblResultado.Text = GerarStringAleatoria(quantidade);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text != "-")
            {
                Clipboard.SetText(lblResultado.Text);
                MessageBox.Show("Copiado para a área de transferência:" + Environment.NewLine
                    + lblResultado.Text, this.Text);
            }
        }
    }
}
