using Dominio.DTOs;
using Dominio.Entities;
using Infraestrutura.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoriaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<long> CriarAsync(CriarCategoriaRequest request)
        {
            var categoria = new Categoria
            {
                Nome = request.Nome,
                Ativo = request.Ativo,
                Tipo = request.Tipo,
            };

            _appDbContext.Categorias.Add(categoria);
            await _appDbContext.SaveChangesAsync();

            return categoria.Id;
        }
        public async Task<IEnumerable<CategoriaResponse>> ListarAsync()
        {
            return await _appDbContext.Categorias
                .Select(x => new CategoriaResponse
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Ativo = x.Ativo,
                    Tipo = x.Tipo,
                }).ToListAsync();
        }
    }
}
