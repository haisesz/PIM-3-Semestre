using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_Login
{
    public partial class Chamados_Historico: Form
    {
        public Chamados_Historico()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnFecharCham_Click(object sender, EventArgs e)
        {
            var TelaLogin = new Login();
            TelaLogin.Show();

            this.Close();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamado enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
