using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class ClienteLogic : IClienteLogic
    {
        private IClienteRepository _ClienteRepository;

        public ClienteLogic(IClienteRepository ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }
        public void AltaCliente(Cliente clienteNuevo)
        {
            Cliente cliente = new Cliente();
            cliente.EsSocio = clienteNuevo.EsSocio;
            if (string.IsNullOrEmpty(clienteNuevo.EsSocio))
            {
                throw new ArgumentException("No válido");
            }
            _AutorRepository.Create(autor);
            _AutorRepository.Save();
        }
    }
}
