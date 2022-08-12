using AutoMapper;
using LocadoraDeCarros.Models.ModeloDados;
using Negocio.Models;
using Dados.Models;

namespace LocadoraDeCarros.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ClienteModel, ClienteViewModel>().ReverseMap();

            CreateMap<Cliente, ClienteDataModel>().ReverseMap();
        }
    }
}
