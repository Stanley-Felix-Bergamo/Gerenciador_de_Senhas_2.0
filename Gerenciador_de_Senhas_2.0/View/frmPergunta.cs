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
    public partial class frmPergunta : Form
    {
        public frmPergunta()
        {
            InitializeComponent();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
