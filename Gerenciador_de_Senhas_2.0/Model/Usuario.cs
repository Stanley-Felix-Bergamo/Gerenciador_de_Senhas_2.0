using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Senhas_2._0.Model
{
    public class Usuario
    {

        [Key]
        [Browsable(false)]
        public int CodUsuario { get; set; }

        public string Site { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


    }
}
