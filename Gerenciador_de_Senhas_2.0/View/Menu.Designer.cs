
namespace Gerenciador_de_Senhas_2._0
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripCriarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripConsultarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.Painel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCriarSenha,
            this.ToolStripConsultarSenha,
            this.ToolStripLogin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripCriarSenha
            // 
            this.toolStripCriarSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCriarSenha.Name = "toolStripCriarSenha";
            this.toolStripCriarSenha.Size = new System.Drawing.Size(87, 21);
            this.toolStripCriarSenha.Text = "Criar Senha";
            this.toolStripCriarSenha.Click += new System.EventHandler(this.toolStripCriarSenha_Click);
            // 
            // ToolStripConsultarSenha
            // 
            this.ToolStripConsultarSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ToolStripConsultarSenha.Name = "ToolStripConsultarSenha";
            this.ToolStripConsultarSenha.Size = new System.Drawing.Size(114, 21);
            this.ToolStripConsultarSenha.Text = "Consultar Senha";
            this.ToolStripConsultarSenha.Click += new System.EventHandler(this.ToolStripConsultarSenha_Click);
            // 
            // ToolStripLogin
            // 
            this.ToolStripLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ToolStripLogin.Name = "ToolStripLogin";
            this.ToolStripLogin.Size = new System.Drawing.Size(72, 21);
            this.ToolStripLogin.Text = "Conectar";
            this.ToolStripLogin.Click += new System.EventHandler(this.ToolStripLogin_Click);
            // 
            // Painel
            // 
            this.Painel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel.Location = new System.Drawing.Point(0, 25);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(800, 425);
            this.Painel.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Painel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripCriarSenha;
        private System.Windows.Forms.ToolStripMenuItem ToolStripConsultarSenha;
        private System.Windows.Forms.ToolStripMenuItem ToolStripLogin;
        private System.Windows.Forms.Panel Painel;
    }
}

