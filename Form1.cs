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

        private static string GerarStringAleatoria(int tamanho)
        {
            Random random = new Random();
            const string dicionario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            var resultado = new string(
                Enumerable.Repeat(dicionario, tamanho)
              .Select(s => s[random.Next(s.Length)])
              .ToArray());

            return resultado;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var rand = new Random(10);
            lblResultado.Text = GerarStringAleatoria(8);
        }
    }
}
