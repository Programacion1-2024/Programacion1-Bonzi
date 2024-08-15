using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;

namespace CDatos.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(LibreriaContext context) : base(context) { }
    }
}
