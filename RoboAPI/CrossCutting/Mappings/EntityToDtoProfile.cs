using AutoMapper;
using RoboAPI.Domain.Dtos.Acao;
using RoboAPI.Domain.Dtos.Robo;
using RoboAPI.Domain.Entities;
using RoboAPI.Domain.Models;

namespace RoboAPI.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            #region Ação
            CreateMap<AcaoDto, AcaoBracoCotoveloEntity>()
               .ReverseMap();

            CreateMap<AcaoDto, AcaoBracoPulsoEntity>()
               .ReverseMap();

            CreateMap<AcaoDto, AcaoCabecaInclinacaoEntity>()
             .ReverseMap();

            CreateMap<AcaoDto, AcaoCabecaRotacaoEntity>()
             .ReverseMap();

            CreateMap<AcaoBracoCotoveloEntity, AcoesDto>().ForMember(dest => dest.TipoAcao, opt => opt.MapFrom((src, dest, destMember, context) => context.Items["TipoAcao"]))
                    .ReverseMap();
            CreateMap<AcaoBracoPulsoEntity, AcoesDto>().ForMember(dest => dest.TipoAcao, opt => opt.MapFrom((src, dest, destMember, context) => context.Items["TipoAcao"]))
                    .ReverseMap();
            CreateMap<AcaoCabecaInclinacaoEntity, AcoesDto>().ForMember(dest => dest.TipoAcao, opt => opt.MapFrom((src, dest, destMember, context) => context.Items["TipoAcao"]))
                    .ReverseMap();
            CreateMap<AcaoCabecaRotacaoEntity, AcoesDto>().ForMember(dest => dest.TipoAcao, opt => opt.MapFrom((src, dest, destMember, context) => context.Items["TipoAcao"]))
                   .ReverseMap();
            #endregion

            #region Robo
            CreateMap<RoboDto, RoboEntity>()
                .ReverseMap();
            CreateMap<RoboUpdateDto, RoboEntity>()
                .ReverseMap();
            CreateMap<RoboCreateDto, RoboEntity>()
                .ReverseMap();
            #endregion
        }
    }
}
