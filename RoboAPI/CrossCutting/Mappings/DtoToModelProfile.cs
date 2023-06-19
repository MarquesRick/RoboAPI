using AutoMapper;
using RoboAPI.Domain.Dtos.Acao;
using RoboAPI.Domain.Dtos.Robo;
using RoboAPI.Domain.Models;

namespace RoboAPI.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {

        public DtoToModelProfile()
        {

            #region Ação
            CreateMap<AcaoBracoCotoveloModel, AcaoDto>()
                    .ReverseMap();
            CreateMap<AcaoBracoPulsoModel, AcaoDto>()
                    .ReverseMap();
            CreateMap<AcaoCabecaInclinacaoModel, AcaoDto>()
                    .ReverseMap();
            CreateMap<AcaoCabecaRotacaoModel, AcaoDto>()
                    .ReverseMap();
            #endregion

            #region Robo
            CreateMap<RoboModel, RoboDto>()
                   .ReverseMap();

            CreateMap<RoboModel, RoboUpdateDto>()
                   .ReverseMap();

            CreateMap<RoboModel, RoboCreateDto>()
                   .ReverseMap();
            #endregion
        }

    }
}
