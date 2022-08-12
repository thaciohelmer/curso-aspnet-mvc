using Negocio.Models;

namespace Negocio.RepositorioDados
{
    public interface IClienteRepositorio
    {
        Cliente ObterCliente(int id);
    }
}

