using Gerenciador_de_Senhas_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Senhas_2._0.Controller
{
    public class UsuarioController:DataBase.DbGerenciador
    {
        private DataBase.DbGerenciador Contexto;

        public UsuarioController() => Contexto = new DataBase.DbGerenciador();

        public void Salvar(Usuario usuario)
        {
            Contexto.usuarios.Add(usuario);
            Contexto.SaveChanges();
        }
    }
}
