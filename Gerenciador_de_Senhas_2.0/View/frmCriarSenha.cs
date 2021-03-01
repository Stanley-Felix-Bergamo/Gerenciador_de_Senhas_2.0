using Gerenciador_de_Senhas_2._0.Controller;
using Gerenciador_de_Senhas_2._0.Model;
using Gerenciador_de_Senhas_2._0.Model.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Senhas_2._0.View
{
    public partial class frmCriarSenha : Form
    {
        private UsuarioController controller = new UsuarioController();
        private Usuario Usuario = new Usuario();

        public frmCriarSenha()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario.Site = txtSite.Text;
            Usuario.Senha = txtSenha.Text;
            Usuario.Login = txtLogin.Text;
            controller.Salvar(Usuario);
            MessageBox.Show("Salvo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }
        private void Limpar()
        {
            txtSite.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtLogin.Text = string.Empty;
        }
    }
}
