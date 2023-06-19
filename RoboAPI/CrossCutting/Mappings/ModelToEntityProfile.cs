using AutoMapper;
using RoboAPI.Domain.Entities;
using RoboAPI.Domain.Models;

namespace RoboAPI.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            #region Ação
            CreateMap<AcaoBracoCotoveloModel, AcaoBracoCotoveloEntity>()
               .ReverseMap();
            CreateMap<AcaoBracoPulsoModel, AcaoBracoPulsoEntity>()
               .ReverseMap();
            CreateMap<AcaoCabecaInclinacaoModel, AcaoCabecaInclinacaoEntity>()
               .ReverseMap();
            CreateMap<AcaoCabecaRotacaoModel, AcaoCabecaRotacaoEntity>()
               .ReverseMap();
            #endregion

            #region Robo
            CreateMap<RoboModel, RoboEntity>()
                   .ReverseMap();
            #endregion
        }
    }
}
