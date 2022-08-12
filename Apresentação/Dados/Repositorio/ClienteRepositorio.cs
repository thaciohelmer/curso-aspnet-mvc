using AutoMapper;
using Dados.Models;
using Negocio.Models;
using Negocio.RepositorioDados;

namespace Dados.Repositório
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly IMapper _mapper;

        public ClienteRepositorio(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Cliente ObterCliente(int id)
        {
            ClienteDataModel clienteDM = new ClienteDataModel();

            // Lógica de acesso a dados

            return _mapper.Map<Cliente>(clienteDM);
        }
    }
}
