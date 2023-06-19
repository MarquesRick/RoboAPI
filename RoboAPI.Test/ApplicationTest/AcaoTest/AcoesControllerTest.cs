using Microsoft.AspNetCore.Mvc;
using Moq;
using RoboAPI.Controllers;
using RoboAPI.Domain;
using RoboAPI.Domain.Dtos.Acao;
using RoboAPI.Domain.Interfaces.Services;
using Xunit;

namespace RoboAPI.Test.ApplicationTest.RoboTest
{
    public class AcoesControllerTest
    {
        private AcoesController _controller;

        #region GetAll

        [Fact(DisplayName = "BadRequest GetAllAcoes")]
        public async Task BadRequest_GetAllAcoes()
        {
            var serviceMock = new Mock<IAcaoService>();

            serviceMock.Setup(m => m.GetAll()).ReturnsAsync(
                 new AcoesDto[]
                 {
                 new AcoesDto()
                 {
                    Id = (long)Acoes.Pulso.RotacaoMenos45,
                    Descricao = "Rotação para -45°",
                    DataCriacao = DateTime.UtcNow
                 } }

            );
            _controller = new AcoesController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.GetAll(serviceMock.Object);
            Assert.True(result is BadRequestObjectResult);
        }


        [Fact(DisplayName = "Success GetAll")]
        public async Task Success_GetAll()
        {

            var serviceMock = new Mock<IAcaoService>();

            serviceMock.Setup(m => m.GetAll()).ReturnsAsync(
                 new AcoesDto[]
                 {
                 new AcoesDto()
                 {
                    Id = (long)Acoes.Pulso.RotacaoMenos45,
                    Descricao = "Rotação para -45°",
                    DataCriacao = DateTime.UtcNow
                 } }

            );
            _controller = new AcoesController();
            var result = await _controller.GetAll(serviceMock.Object);
            Assert.True(result is OkObjectResult);
        }

        #endregion

        #region GetAllByType

        [Fact(DisplayName = "BadRequest GetAllByType")]
        public async Task BadRequest_GetAllByType()
        {
            var serviceMock = new Mock<IAcaoService>();

            serviceMock.Setup(m => m.GetAllByType(It.IsAny<long>())).ReturnsAsync(
                new AcaoDto[]
                 {
                 new AcaoDto()
                 {
                    Id = (long)Acoes.Pulso.RotacaoMenos45,
                    Descricao = "Rotação para -45°",
                    DataCriacao = DateTime.UtcNow
                 } }
            );
            _controller = new AcoesController();
            _controller.ModelState.AddModelError("Id", "Formato Inválido");

            var result = await _controller.GetAllByType(serviceMock.Object, It.IsAny<long>());
            Assert.True(result is BadRequestObjectResult);
        }

        [Fact(DisplayName = "Success GetAllByType")]
        public async Task Success_GetAllByType()
        {
            var serviceMock = new Mock<IAcaoService>();

            serviceMock.Setup(m => m.GetAllByType(It.IsAny<long>())).ReturnsAsync(
                new AcaoDto[]
                 {
                 new AcaoDto()
                 {
                    Id = (long)Acoes.Pulso.RotacaoMenos45,
                    Descricao = "Rotação para -45°",
                    DataCriacao = DateTime.UtcNow
                 } }
            );
            _controller = new AcoesController();
            var result = await _controller.GetAllByType(serviceMock.Object, It.IsAny<long>());
            Assert.True(result is OkObjectResult);
        }

        #endregion
    }
}
