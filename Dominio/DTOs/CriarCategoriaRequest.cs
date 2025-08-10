using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTOs
{
    public class CriarCategoriaRequest
    {
        public string Nome { get; set; }
        public TipoCategoria Tipo { get; set; }
        public bool Ativo { get; set; }
    }
}
