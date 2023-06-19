using Moq;
using RoboAPI.Domain.Dtos.Robo;
using RoboAPI.Domain.Interfaces.Services;
using RoboAPI.Test.ServiceTest.AcaoServiceTest;
using Xunit;

namespace RoboAPI.Test.ServiceTest.RoboServiceTest
{
    public class AcaoServiceTest : AcoesTest
    {
        private IAcaoService _service;
        private Mock<IAcaoService> _serviceMock;

        #region GetAll

        [Fact(DisplayName = "Service GetAllByType")]
        public async Task Service_GetAllByType()
        {
            _serviceMock = new Mock<IAcaoService>();
            _serviceMock.Setup(m => m.GetAllByType(Id)).ReturnsAsync(listaAcaoDto);
            _service = _serviceMock.Object;

            var result = await _service.GetAllByType(Id);
            Assert.NotNull(result);
        }
        #endregion
    }
}
