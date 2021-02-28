﻿using Gerenciador_de_Senhas_2._0.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Senhas_2._0
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            toolStripCriarSenha.Visible = false;
            ToolStripConsultarSenha.Visible = false;
            ToolStripLogin.Visible = true;
            ToolStripLogout.Visible = false;
        }
        public static void LoadForm(Form frm, Panel pnl)//função para o botão funcionar//Carrega o Formulario
        {
            try
            {
                pnl.Controls.Clear();

                frm.TopLevel = false;

                frm.Visible = true;

                frm.FormBorderStyle = FormBorderStyle.None;

                frm.Dock = DockStyle.Fill;


                pnl.Controls.Add(frm);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validação de Senha
        public static bool ValidaSenha(string senha)
        {

            if (senha == "36372512")
            {
                return true;
            }
            MessageBox.Show("Senha Invalida !", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }
        #endregion


        private void ToolStripLogin_Click(object sender, EventArgs e)
        {
            var x = new frmLogar();

            x.ShowDialog();



            if (x.DialogResult == DialogResult.OK)
            {

                string Senha = x.Senha;


                if (ValidaSenha(Senha) == true)
                {


                    toolStripCriarSenha.Visible = true;
                    ToolStripConsultarSenha.Visible = true;
                    ToolStripLogin.Visible = false;
                    ToolStripLogout.Visible = true;

                    MessageBox.Show("Bem Vindo !", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
