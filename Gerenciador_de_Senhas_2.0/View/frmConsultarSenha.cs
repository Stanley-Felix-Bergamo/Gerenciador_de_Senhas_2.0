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
    public partial class frmConsultarSenha : Form
    {
        private List<UsuarioView> Lista = new List<UsuarioView>();
        private UsuarioController controller = new UsuarioController();


        public frmConsultarSenha()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarSenha_Shown(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch
            {
                MessageBox.Show("Houve um erro ao Buscar a Lista", "Opa...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Buscar()
        {
            Lista = controller.Listando();
            Grade(Lista);
        }
        private void Grade(List<UsuarioView> Lista)
        {
            Grid.DataSource = Lista;

            Grid.Columns[nameof(UsuarioView.Site)].DisplayIndex = 0;
            Grid.Columns[nameof(UsuarioView.Site)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Grid.Columns[nameof(UsuarioView.Login)].DisplayIndex = 1;
            Grid.Columns[nameof(UsuarioView.Login)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Grid.Columns[nameof(UsuarioView.Senha)].DisplayIndex = 2;
            Grid.Columns[nameof(UsuarioView.Senha)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Grid
               .GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    //  Adicione a seleção à área de transferência.
                    Clipboard.SetDataObject(
                        this.Grid.GetClipboardContent());
                    // Substitua o conteúdo da caixa de texto pelo texto da área de transferência.
                    this.Grid.Text = Clipboard.GetText();
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    this.Grid.Text =
                        "A área de transferência não pôde ser acessada. ";
                }
            }
        }
        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new frmPergunta();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                try
                {
                    if (Grid.CurrentRow == null)
                    {
                        MessageBox.Show("Desculpa, Não há nada selecionado !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        var view = (UsuarioView)Grid.CurrentRow.DataBoundItem;
                        controller.Apagar(view);
                        MessageBox.Show("Apagado !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Buscar();
                    }
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var x = (UsuarioView)Grid.CurrentRow.DataBoundItem;
                var Editando = new frmEditando(x);
                Editando.ShowDialog();
                if (Editando.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Editado !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }                
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}
