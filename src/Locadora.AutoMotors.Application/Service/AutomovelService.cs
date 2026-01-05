using Locadora.AutoMotors.Application.IRepository;
using Locadora.AutoMotors.Application.IService;
using Locadora.AutoMotors.Domain.Entities;

namespace Locadora.AutoMotors.Application.Service
{
    public class AutomovelService : IAutomovelService
    {
        private readonly IAutomovelRepository _repository;

        public AutomovelService(IAutomovelRepository repository)
        {
            _repository = repository;
        }

        public async Task<Automovel> CreateAsync(Automovel automovel) 
            => await _repository.CreateAsync(automovel);

        public async Task<Automovel> GetByIdAsync(int id) 
            => await _repository.GetByIdAsync(id);

        public async Task<Automovel> UpdateAsync(Automovel automovel) 
            => await _repository.UpdateAsync(automovel);
    }
}
