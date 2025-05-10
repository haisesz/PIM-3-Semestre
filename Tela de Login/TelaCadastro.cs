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
    public partial class TelaCadastro: Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtEmailCad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 64 && tecla != 08 && tecla != 46)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente letras e números",
                                "Ops", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtEmailCad.Focus();
            }
        }
    }
}
