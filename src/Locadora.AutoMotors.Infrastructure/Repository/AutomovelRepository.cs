using Locadora.AutoMotors.Application.IRepository;
using Locadora.AutoMotors.Domain.Entities;
using Locadora.AutoMotors.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Locadora.AutoMotors.Infrastructure.Repository
{
    public class AutomovelRepository : IAutomovelRepository
    {
        private readonly AppDbContext _context;

        public AutomovelRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Automovel> CreateAsync(Automovel obj)
        {
            await _context.Automoveis.AddAsync(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var item = await _context.Automoveis.FirstOrDefaultAsync(x => x.Id == id);

            _context.Automoveis.Remove(item);
            return await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Automovel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Automovel> GetByIdAsync(int id)
        {
            var obj = await _context.Automoveis.FirstOrDefaultAsync(x => x.Id == id);

            if (obj == null)
                return null;

            return obj;
        }

        public Task<Automovel> UpdateAsync(Automovel entity)
        {
            throw new NotImplementedException();
        }
    }
}
