using AutoMapper;
using RoboAPI.Domain;
using RoboAPI.Domain.Dtos.Acao;
using RoboAPI.Domain.Entities;
using RoboAPI.Domain.Interfaces;
using RoboAPI.Domain.Interfaces.Services;
using RoboAPI.Domain.Models;

namespace RoboAPI.Service.Services
{
    public class AcaoService : IAcaoService
    {
        private IRepository<AcaoBracoCotoveloEntity> _repositoryCotovelo;
        private IRepository<AcaoBracoPulsoEntity> _repositoryPulso;
        private IRepository<AcaoCabecaInclinacaoEntity> _repositoryInclinacao;
        private IRepository<AcaoCabecaRotacaoEntity> _repositoryRotacao;
        private readonly IMapper _mapper;

        public AcaoService(IRepository<AcaoBracoCotoveloEntity> repositoryCotovelo, 
            IRepository<AcaoBracoPulsoEntity> repositoryPulso, 
            IRepository<AcaoCabecaInclinacaoEntity> repositoryInclinacao,
            IRepository<AcaoCabecaRotacaoEntity> repositoryRotacao,
            IMapper mapper)
        {
            _repositoryCotovelo = repositoryCotovelo;
            _repositoryPulso = repositoryPulso;
            _repositoryInclinacao = repositoryInclinacao;
            _repositoryRotacao = repositoryRotacao;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AcaoDto>> GetAllByType(long type)
        {
            return type switch
            {
                (long)Acoes.TipoAcao.Cotovelo => _mapper.Map<IEnumerable<AcaoDto>>(await _repositoryCotovelo.GetAllAsync()),
                (long)Acoes.TipoAcao.Pulso => _mapper.Map<IEnumerable<AcaoDto>>(await _repositoryPulso.GetAllAsync()),
                (long)Acoes.TipoAcao.Inclinacao => _mapper.Map<IEnumerable<AcaoDto>>(await _repositoryInclinacao.GetAllAsync()),
                (long)Acoes.TipoAcao.Rotacao => _mapper.Map<IEnumerable<AcaoDto>>(await _repositoryRotacao.GetAllAsync()),
                _ => Enumerable.Empty<AcaoDto>(),
            };
        }

        public async Task<IEnumerable<AcoesDto>> GetAll()
        {
            var listAcoes = new List<AcoesDto>();
            listAcoes.AddRange(_mapper.Map<IEnumerable<AcoesDto>>(await _repositoryCotovelo.GetAllAsync(), opt => opt.Items["TipoAcao"] = (long)Acoes.TipoAcao.Cotovelo));
            listAcoes.AddRange(_mapper.Map<IEnumerable<AcoesDto>>(await _repositoryPulso.GetAllAsync(), opt => opt.Items["TipoAcao"] = (long)Acoes.TipoAcao.Pulso));
            listAcoes.AddRange(_mapper.Map<IEnumerable<AcoesDto>>(await _repositoryInclinacao.GetAllAsync(), opt => opt.Items["TipoAcao"] = (long)Acoes.TipoAcao.Inclinacao));
            listAcoes.AddRange(_mapper.Map<IEnumerable<AcoesDto>>(await _repositoryRotacao.GetAllAsync(), opt => opt.Items["TipoAcao"] = (long)Acoes.TipoAcao.Rotacao));
            return listAcoes;
        }
    }
}
