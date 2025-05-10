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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text.Equals("Anderson@gmail.com") && txtSenha.Text.Equals("123"))
                {
                    var chamados = new Chamados_Historico();
                    chamados.Show();

                    this.Visible = false;   
                }else
                {
                    MessageBox.Show("Senha ou Email Incorretos","Ops", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                    txtEmail.Focus();
                    txtSenha.Text = "";
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Ops",ex.Message,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar; 

            if(!char.IsLetterOrDigit(e.KeyChar) && tecla != 64 && tecla != 08 && tecla != 46)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente letras e números", 
                                "Ops", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);

                txtEmail.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cadastrar = new TelaCadastro();
            cadastrar.Show();

            this.Visible = false;
        }
    }
}
