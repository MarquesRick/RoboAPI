using Microsoft.AspNetCore.Mvc;
using Moq;
using RoboAPI.Controllers;
using RoboAPI.Domain;
using RoboAPI.Domain.Dtos.Acao;
using RoboAPI.Domain.Dtos.Robo;
using RoboAPI.Domain.Interfaces.Services;
using Xunit;

namespace RoboAPI.Test.ApplicationTest.RoboTest
{
    public class RoboServiceTest
    {
        private RoboController _controller;

        #region GetById

        [Fact(DisplayName = "BadRequest GetById")]
        public async Task BadRequest_GetById()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.GetById(It.IsAny<long>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.GetById(serviceMock.Object, It.IsAny<long>());
            Assert.True(result is BadRequestObjectResult);
        }


        [Fact(DisplayName = "Success GetById")]
        public async Task Success_GetById()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.GetById(It.IsAny<long>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 1,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();
            var result = await _controller.GetById(serviceMock.Object, It.IsAny<long>());
            Assert.True(result is OkObjectResult);
        }

        #endregion


        #region GetAll

        [Fact(DisplayName = "BadRequest GetAll")]
        public async Task BadRequest_GetAll()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.GetAll()).ReturnsAsync(
                 new RoboDto[]
                 {
                 new RoboDto()
                  {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 } }
            );
            _controller = new RoboController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.GetAll(serviceMock.Object);
            Assert.True(result is BadRequestObjectResult);
        }


        [Fact(DisplayName = "Success GetAll")]
        public async Task Success_GetAll()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.GetAll()).ReturnsAsync(
                 new RoboDto[]
                 {
                 new RoboDto()
                  {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 } }
            );
            _controller = new RoboController();

            var result = await _controller.GetAll(serviceMock.Object);
            Assert.True(result is OkObjectResult);
        }
        #endregion

        #region GetReset

        [Fact(DisplayName = "BadRequest GetReset")]
        public async Task BadRequest_GetReset()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.Reset(It.IsAny<long>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.GetReset(serviceMock.Object, It.IsAny<long>());
            Assert.True(result is BadRequestObjectResult);
        }

        [Fact(DisplayName = "Success GetReset")]
        public async Task Success_GetReset()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.Reset(It.IsAny<long>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();
            var result = await _controller.GetReset(serviceMock.Object, It.IsAny<long>());
            Assert.True(result is OkObjectResult);
        }

        #endregion

        #region UpdateRobo
        [Fact(DisplayName = "BadRequest UpdateRobo")]
        public async Task BadRequest_UpdateRobo()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.Update(It.IsAny<RoboUpdateDto>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.Put(serviceMock.Object, It.IsAny<RoboUpdateDto>());
            Assert.True(result is BadRequestObjectResult);
            Assert.False(_controller.ModelState.IsValid);
        }

        [Fact(DisplayName = "Success UpdateRobo")]
        public async Task Success_UpdateRobo()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.Update(It.IsAny<RoboUpdateDto>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();

            var result = await _controller.Put(serviceMock.Object, It.IsAny<RoboUpdateDto>());

            Assert.True(result is OkObjectResult);

            RoboDto? resultValue = ((OkObjectResult)result).Value as RoboDto;
            Assert.NotNull(resultValue);
        }
        #endregion

        #region CreateRobo
        [Fact(DisplayName = "BadRequest CreateRobo")]
        public async Task BadRequest_CreateRobo()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.Post(It.IsAny<RoboCreateDto>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.Post(serviceMock.Object, It.IsAny<RoboCreateDto>());
            Assert.True(result is BadRequestObjectResult);
            Assert.False(_controller.ModelState.IsValid);
        }

        [Fact(DisplayName = "Success CreateRobo")]
        public async Task Success_CreateRobo()
        {
            var serviceMock = new Mock<IRoboService>();

            serviceMock.Setup(m => m.Post(It.IsAny<RoboCreateDto>())).ReturnsAsync(
                 new RoboDto
                 {
                     Id = 0,
                     CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                     CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                     PulsoDireito = (long)Acoes.Pulso.Repouso,
                     PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                     CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                     CabecaRotacao = (long)Acoes.Rotacao.Repouso,
                     DataAtualizacao = DateTime.UtcNow,
                 }
            );
            _controller = new RoboController();

            Mock<IUrlHelper> url = new Mock<IUrlHelper>();
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:3333");
            _controller.Url = url.Object;

            var roboCreateDto = new RoboCreateDto
            {
                CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                PulsoDireito = (long)Acoes.Pulso.Repouso,
                PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                CabecaRotacao = (long)Acoes.Rotacao.Repouso,
            };

            var result = await _controller.Post(serviceMock.Object, roboCreateDto);
            Assert.True(result is CreatedResult);

            var resultValue = ((CreatedResult)result).Value as RoboDto;
            Assert.NotNull(resultValue);
        }
        #endregion

        #region DeleteRobo
        [Fact(DisplayName = "BadRequest Delete")]
        public async Task BadRequest_Delete()
        {
            var serviceMock = new Mock<IRoboService>();
            serviceMock.Setup(m => m.Delete(It.IsAny<long>()))
                       .ReturnsAsync(false);

            _controller = new RoboController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.Delete(serviceMock.Object, default(long));
            Assert.True(result is BadRequestObjectResult);
            Assert.False(_controller.ModelState.IsValid);
        }

        [Fact(DisplayName = "Success Delete")]
        public async Task Success_Delete()
        {
            var serviceMock = new Mock<IRoboService>();
            serviceMock.Setup(m => m.Delete(It.IsAny<long>()))
                       .ReturnsAsync(true);

            _controller = new RoboController();

            var result = await _controller.Delete(serviceMock.Object, It.IsAny<long>());
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value;
            Assert.NotNull(resultValue);
            Assert.True((Boolean)resultValue);
        }

        #endregion
    }
}
