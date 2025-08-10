using Dominio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaResponse>> ListarAsync();
        Task<long> CriarAsync(CriarCategoriaRequest request);
    }
}
