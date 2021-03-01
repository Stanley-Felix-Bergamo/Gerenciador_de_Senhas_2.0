using Gerenciador_de_Senhas_2._0.Controller;
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
    public partial class frmEditando : Form
    {
        private UsuarioController Controller = new UsuarioController();
        private UsuarioView View;
        public frmEditando()
        {
            InitializeComponent();
        }
        public frmEditando(UsuarioView x) : this()
        {
            this.View = x;
            x.Login = txtLogin.Text;
            x.Senha = txtLogin.Text;
            x.Site = txtSite.Text;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            View.Site = txtSite.Text;
            View.Senha = txtSenha.Text;
            View.Login = txtLogin.Text;
            Controller.Editar(View);
        }
    }
}
