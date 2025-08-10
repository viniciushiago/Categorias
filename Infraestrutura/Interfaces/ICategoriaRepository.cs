using Dominio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<CategoriaResponse>> ListarAsync();
        Task<long> CriarAsync(CriarCategoriaRequest request);
    }
}
