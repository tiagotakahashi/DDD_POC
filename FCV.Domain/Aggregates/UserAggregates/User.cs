using System;

namespace FCV.Domain.Aggregates.UserAggregates
{
    public class User: EntityBase
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime LastAccess { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}
