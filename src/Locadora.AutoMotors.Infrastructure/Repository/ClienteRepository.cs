using Locadora.AutoMotors.Application.IRepository;
using Locadora.AutoMotors.Domain.Entities;
using Locadora.AutoMotors.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Locadora.AutoMotors.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _appContext;

        public ClienteRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<Cliente> CreateAsync(Cliente obj)
        {
            await _appContext.Clientes.AddAsync(obj);
            await _appContext.SaveChangesAsync();

            return obj;
        }

        public Task<int> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            var entry = await _appContext.Clientes.FirstOrDefaultAsync(x => x.Id == id);

            if (entry == null) 
                return null;

            return entry;
        }

        public async Task<Cliente> UpdateAsync(Cliente entity)
        {
            var exist = await _appContext.Clientes.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (exist is null)
                return null;

            _appContext.Entry(exist).CurrentValues.SetValues(entity);
            await _appContext.SaveChangesAsync();

            return exist;
        }
    }
}
