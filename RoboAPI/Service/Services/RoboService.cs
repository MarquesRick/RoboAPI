using AutoMapper;
using RoboAPI.Domain;
using RoboAPI.Domain.Dtos.Robo;
using RoboAPI.Domain.Entities;
using RoboAPI.Domain.Interfaces;
using RoboAPI.Domain.Interfaces.Services;
using RoboAPI.Domain.Models;
using RoboAPI.Service.Util;

namespace RoboAPI.Service.Services
{
    public class RoboService : IRoboService
    {
        private IRepository<RoboEntity> _repositoryRobo;
        private readonly IMapper _mapper;

        public RoboService(IRepository<RoboEntity> repositoryRobo, IMapper mapper)
        {
            _repositoryRobo = repositoryRobo;
            _mapper = mapper;
        }

        public async Task<RoboDto> GetById(long id) => _mapper.Map<RoboDto>(await _repositoryRobo.GetByIdAsync(id));

        public async Task<IEnumerable<RoboDto>> GetAll() => _mapper.Map<IEnumerable<RoboDto>>(await _repositoryRobo.GetAllAsync());

        public async Task<RoboDto> Update(RoboUpdateDto robo)
        {
            ValidarMovimentosObrigatorios(robo);
            var roboEstadoAnterior = _mapper.Map<RoboDto>(await _repositoryRobo.GetByIdAsync(robo.Id)) ?? throw new CustomValidationException() { Titulo = "Validacao", MensagemErro = "Robô não encontrado" };
            ValidarMovimentos(robo, roboEstadoAnterior);
            var model = _mapper.Map<RoboModel>(robo);
            var entity = _mapper.Map<RoboEntity>(model);
            var result = await _repositoryRobo.UpdateAsync(entity);
            return _mapper.Map<RoboDto>(result);
        }

        public async Task<RoboDto> Reset(long id)
        {
            var robo = _mapper.Map<RoboDto>(await _repositoryRobo.GetByIdAsync(id)) ?? throw new CustomValidationException() { Titulo = "Validacao", MensagemErro = "Robô não encontrado" };
            robo.CotoveloDireito = (long)Acoes.Cotovelo.Repouso;
            robo.CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso;
            robo.PulsoDireito = (long)Acoes.Pulso.Repouso;
            robo.PulsoEsquerdo = (long)Acoes.Pulso.Repouso;
            robo.CabecaInclinacao = (long)Acoes.Inclinacao.Repouso;
            robo.CabecaRotacao = (long)Acoes.Rotacao.Repouso;
            robo.DataAtualizacao = DateTime.UtcNow;

            var model = _mapper.Map<RoboModel>(robo);
            var entity = _mapper.Map<RoboEntity>(model);
            var result = await _repositoryRobo.UpdateAsync(entity);
            return _mapper.Map<RoboDto>(result);
        }

        public async Task<RoboDto> Post(RoboCreateDto robo)
        {
            var model = _mapper.Map<RoboModel>(robo);
            var entity = _mapper.Map<RoboEntity>(model);
            var result = await _repositoryRobo.InsertAsync(entity);
            
            return _mapper.Map<RoboDto>(result);
        }

        public async Task<bool> Delete(long id) => await _repositoryRobo.DeleteAsync(id);
  

        #region Métodos Privados
        private static void ValidarMovimentos(RoboUpdateDto robo, RoboDto roboAnterior)
        {
            var mensagem = new List<string>();

            if(!(roboAnterior.CotoveloEsquerdo == robo.CotoveloEsquerdo 
                || roboAnterior.CotoveloEsquerdo == robo.CotoveloEsquerdo + 1 
                || roboAnterior.CotoveloEsquerdo == robo.CotoveloEsquerdo - 1))
                mensagem.Add("Necessário que selecione um estado de progressão anterior ou posterior ao que o Cotovelo Esquerdo do robô se encontra no momento.");

            if (!(roboAnterior.CotoveloDireito == robo.CotoveloDireito
                || roboAnterior.CotoveloDireito == robo.CotoveloDireito + 1
                || roboAnterior.CotoveloDireito == robo.CotoveloDireito - 1))
                mensagem.Add("Necessário que selecione um estado de progressão anterior ou posterior ao que o Cotovelo Direito do robô se encontra no momento.");

            if (!(roboAnterior.PulsoEsquerdo == robo.PulsoEsquerdo
                || roboAnterior.PulsoEsquerdo == robo.PulsoEsquerdo + 1
                || roboAnterior.PulsoEsquerdo == robo.PulsoEsquerdo - 1))
                mensagem.Add("Necessário que selecione um estado de progressão anterior ou posterior ao que o Pulso Esquerdo do robô se encontra no momento.");

            if (!(roboAnterior.PulsoDireito == robo.PulsoDireito
                || roboAnterior.PulsoDireito == robo.PulsoDireito + 1
                || roboAnterior.PulsoDireito == robo.PulsoDireito - 1))
                mensagem.Add("Necessário que selecione um estado de progressão anterior ou posterior ao que o Pulso direito do robô se encontra no momento.");

            if (!(roboAnterior.CabecaRotacao == robo.CabecaRotacao
               || roboAnterior.CabecaRotacao == robo.CabecaRotacao + 1
               || roboAnterior.CabecaRotacao == robo.CabecaRotacao - 1))
                mensagem.Add("Necessário que selecione um estado de progressão anterior ou posterior ao que a Rotação da Cabeça do robô se encontra no momento.");

            if (!(roboAnterior.CabecaInclinacao == robo.CabecaInclinacao
               || roboAnterior.CabecaInclinacao == robo.CabecaInclinacao + 1
               || roboAnterior.CabecaInclinacao == robo.CabecaInclinacao - 1))
                mensagem.Add("Necessário que selecione um estado de progressão anterior ou posterior ao que a Inclinação da Cabeça do robô se encontra no momento.");

            if (mensagem.Count > 0) throw new CustomValidationException() { Titulo = "Validacao", MensagemErro = string.Join(" | ", mensagem) };
        }
        private static void ValidarMovimentosObrigatorios(RoboUpdateDto robo)
        {
            var mensagem = new List<string>();

            if(robo.CotoveloEsquerdo != (long)Acoes.Cotovelo.FortementeContraido && robo.PulsoEsquerdo != (long)Acoes.Pulso.Repouso)
                mensagem.Add("Necessário que o Cotovelo Esquerdo esteja Fortemente Contraído para conseguir movimentar o Pulso Esquerdo do robô.");

            if (robo.CotoveloDireito != (long)Acoes.Cotovelo.FortementeContraido && robo.PulsoDireito != (long)Acoes.Pulso.Repouso)
                mensagem.Add("Necessário que o Cotovelo Direito esteja Fortemente Contraído para conseguir movimentar o Pulso Direito do robô.");

            if(robo.CabecaInclinacao == (long)Acoes.Inclinacao.ParaBaixo && robo.CabecaRotacao != (long)Acoes.Rotacao.Repouso)
                mensagem.Add("Necessário que a Inclinação da Cabeça não esteja Para Baixo para conseguir rotacionar a cabeça do robô.");
            
            if (mensagem.Count > 0) throw new CustomValidationException() { Titulo = "Validacao", MensagemErro = string.Join(" | ", mensagem) };
        }
        #endregion
    }
}
