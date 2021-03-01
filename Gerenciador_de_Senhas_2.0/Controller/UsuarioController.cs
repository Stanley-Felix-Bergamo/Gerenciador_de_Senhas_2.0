using Gerenciador_de_Senhas_2._0.Model;
using Gerenciador_de_Senhas_2._0.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Senhas_2._0.Controller
{
    public class UsuarioController : DataBase.DbGerenciador
    {
        private DataBase.DbGerenciador Contexto;

        public UsuarioController() => Contexto = new DataBase.DbGerenciador();

        public void Salvar(Usuario usuario)
        {
            Contexto.usuarios.Add(usuario);
            Contexto.SaveChanges();
        }
        public List<UsuarioView> Listando()
        {
            var Lista = Contexto.usuarios.ToList().Select(obj => new UsuarioView()
            {
                CodUsuarioView = obj.CodUsuario,
                Login = obj.Login,
                Senha = obj.Senha,
                Site = obj.Site,
            }).ToList();
            return Lista;
        }
        public void Apagar(UsuarioView view)
        {
            var Apagar = Contexto.usuarios.Where(x => x.CodUsuario == view.CodUsuarioView).FirstOrDefault();
            Contexto.usuarios.Remove(Apagar);
            Contexto.SaveChanges();
        }
        public void Editar(UsuarioView view)
        {
            var x = Contexto.usuarios.Where(obj => obj.CodUsuario == view.CodUsuarioView).FirstOrDefault();
            x.Site = view.Site;
            x.Senha = view.Senha;
            x.Login = view.Login;
            Contexto.Entry(x).State = System.Data.Entity.EntityState.Modified;
            Contexto.SaveChanges();
        }
    }
}
