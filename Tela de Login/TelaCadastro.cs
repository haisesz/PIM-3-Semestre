using System;
using System.Windows.Forms;
using Npgsql;

namespace Tela_de_Login
{
    public partial class TelaCadastro : Form
    {
        private string conexaoString = "Host=localhost;Port=5432;Database=pim;User ID=postgres;Password=belofode";

        public TelaCadastro()
        {
            InitializeComponent();
            
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmailCad.Text))
            {
                MessageBox.Show("O campo Email é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailCad.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenhaCad.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaCad.Focus();
                return;
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um Departamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkedListBox1.Focus();
                return;
            }
        }

        private int ObterIdDepartamento(string departamento)
        {
            switch (departamento.ToLower())
            {
                case "rh":
                    return 1;
                case "produção":
                    return 2;
                case "gerência":
                    return 3;
                default:
                    return 0;
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmailCad.Clear();
            txtSenhaCad.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            txtNome.Focus();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarCadastro_Click(object sender, EventArgs e)
        {
            var TelaLogin = new Login();
                TelaLogin.Show();

            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
           
        }
    }
}