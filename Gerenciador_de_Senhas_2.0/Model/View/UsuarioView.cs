using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Senhas_2._0.Model.View
{
   public class UsuarioView
    {

        [Key]
        [Browsable(false)]
        public int CodUsuarioView { get; set; }

        public string Site { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}
