using Locadora.AutoMotors.Domain.Entities;

namespace Locadora.AutoMotors.Application.IService
{
    public interface ILocadoraService
    {
        Task<Domain.Entities.Locadora> CreateAsync(Domain.Entities.Locadora locadora);
        Task<Domain.Entities.Locadora> UpdateAsync(Domain.Entities.Locadora locadora);
        Task<Domain.Entities.Locadora> GetByIdAsync(int id);
    }
}
