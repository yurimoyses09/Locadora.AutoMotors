using Locadora.AutoMotors.Application.IRepository;
using Locadora.AutoMotors.Application.IService;
using Locadora.AutoMotors.Domain.Entities;

namespace Locadora.AutoMotors.Application.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> CreateAsync(Cliente cliente) 
            => await _clienteRepository.CreateAsync(cliente);

        public async Task<Cliente> GetByIdAsync(int id) 
            => await _clienteRepository.GetByIdAsync(id);

        public async Task<Cliente> UpdateAsync(Cliente cliente) 
            => await _clienteRepository.UpdateAsync(cliente);
    }
}
