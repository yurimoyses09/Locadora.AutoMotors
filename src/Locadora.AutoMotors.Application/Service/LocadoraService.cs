using Locadora.AutoMotors.Application.IRepository;
using Locadora.AutoMotors.Application.IService;

namespace Locadora.AutoMotors.Application.Service
{
    public class LocadoraService : ILocadoraService
    {
        private readonly ILocadoraRepository _repository;

        public LocadoraService(ILocadoraRepository repository)
        {
            _repository = repository;
        }

        public async Task<Domain.Entities.Locadora> CreateAsync(Domain.Entities.Locadora locadora)
            => await _repository.CreateAsync(locadora);

        public async Task<Domain.Entities.Locadora> GetByIdAsync(int id)
            => await _repository.GetByIdAsync(id);

        public async Task<Domain.Entities.Locadora> UpdateAsync(Domain.Entities.Locadora locadora)
            => await _repository.UpdateAsync(locadora);
    }
}
