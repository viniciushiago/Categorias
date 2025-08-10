using Aplicacao.Interfaces;
using Dominio.DTOs;
using Dominio.Entities;
using Infraestrutura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }
        public async Task<long> CriarAsync(CriarCategoriaRequest request)
        {
            if (!Enum.IsDefined(typeof(TipoCategoria), request.Tipo))
            {
                throw new ArgumentException("O tipo da categoria é inválido.");
            }
                

            return await _repository.CriarAsync(request);
        }

        public async Task<IEnumerable<CategoriaResponse>> ListarAsync()
        {
            return await _repository.ListarAsync();
        }
    }
}
