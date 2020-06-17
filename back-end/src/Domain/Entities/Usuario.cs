using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public bool Ativo { get; set; }
        public Guid PerfilId { get; set; }
        public Perfil Perfil { get; set; }
    }
}
