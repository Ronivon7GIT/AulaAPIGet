using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TesteGet.Methodos.Post
{
    public class UsuarioPost
    {
        [DataMember(Name = "nome")]
        public string nome { get; set; }

        [DataMember(Name = "email")]
        public string email { get; set; }

        [DataMember(Name = "password")]
        public string password { get; set; }

        [DataMember(Name = "administrador")]
        public string administrador { get; set; }

        public UsuarioPost() {
            nome = "jorge";
            email = "jorge@hotmail";
            password = "jorge1234";
            administrador = "true";
        }
    }
}
