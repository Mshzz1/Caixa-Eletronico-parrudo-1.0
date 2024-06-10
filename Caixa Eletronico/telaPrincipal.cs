using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void entrardeposito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntrarSaque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntarTransferencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerExtrato_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void voltarFrmInicial_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
