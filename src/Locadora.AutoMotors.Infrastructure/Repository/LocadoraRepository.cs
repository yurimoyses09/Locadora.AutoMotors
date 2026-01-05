using Locadora.AutoMotors.Application.IRepository;
using Locadora.AutoMotors.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Locadora.AutoMotors.Infrastructure.Repository
{
    public class LocadoraRepository : ILocadoraRepository
    {
        private readonly AppDbContext _context;

        public LocadoraRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Locadora> CreateAsync(Domain.Entities.Locadora obj)
        {
            await _context.Locadoras.AddAsync(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var entity = await _context.Automoveis.FirstOrDefaultAsync(x => x.Id == id);
            if (entity is not null)
            {
                _context.Automoveis.Remove(entity);
                _context.SaveChanges();

                return entity.Id;
            }

            return 0;
        }

        public Task<IEnumerable<Domain.Entities.Locadora>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.Entities.Locadora> GetByIdAsync(int id)
        {
            var entity = await _context.Locadoras.FirstOrDefaultAsync(x =>x.Id == id);

            if (entity is not null)
                return entity;
            return
                null;
        }

        public async Task<Domain.Entities.Locadora> UpdateAsync(Domain.Entities.Locadora obj)
        {
            var exist = await _context.Locadoras.FirstOrDefaultAsync(x => x.Id == obj.Id);

            if (exist is null)
                return null;

            _context.Entry(exist).CurrentValues.SetValues(obj);
            await _context.SaveChangesAsync();

            return exist;
        }
    }
}
