using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Gerenciador_de_Senhas_2._0.Model;

namespace Gerenciador_de_Senhas_2._0.DataBase
{
    public class DbGerenciador : DbContext
    {
        public DbGerenciador() : base("GerenciadorSenha2.0") { }


        public DbSet<Usuario> usuarios { get; set; }

    }
}
