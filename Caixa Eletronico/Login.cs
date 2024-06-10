using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Caixa_Eletronico
{
    public partial class Login : Form
    {
        public List<Conta> contas;

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            string co = InserirConta.Text;
            
            Conta CE = Singleton.Instance.BuscarConta(co);

            if(CE != null ) { 
                this.Close();

            }
            else
            {
                MessageBox.Show("Conta não encontrada, cadastre-a ou verifique se não houve algum erro de digitação.");
            }
    }

        private void InserirConta_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
