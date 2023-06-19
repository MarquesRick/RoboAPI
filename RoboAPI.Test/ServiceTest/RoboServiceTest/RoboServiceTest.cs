using Moq;
using RoboAPI.Domain.Dtos.Robo;
using RoboAPI.Domain.Interfaces.Services;
using Xunit;

namespace RoboAPI.Test.ServiceTest.RoboServiceTest
{
    public class RoboServiceTest : RobosTest
    {
        private IRoboService _service;
        private Mock<IRoboService> _serviceMock;

        #region GetById

        [Fact(DisplayName = "Service GetById")]
        public async Task Service_GetById()
        {
            _serviceMock = new Mock<IRoboService>();
            _serviceMock.Setup(m => m.GetById(Id)).ReturnsAsync(roboDto);
            _service = _serviceMock.Object;

            var result = await _service.GetById(Id);
            Assert.NotNull(result);
        }
        #endregion

        #region Reset 
        [Fact(DisplayName = "Service Reset")]
        public async Task Service_Reset()
        {
            _serviceMock = new Mock<IRoboService>();
            _serviceMock.Setup(m => m.Reset(Id)).ReturnsAsync(roboDto);
            _service = _serviceMock.Object;

            var result = await _service.Reset(Id);
            Assert.NotNull(result);

            Assert.True(result.Id == Id);

            _serviceMock = new Mock<IRoboService>();
            _serviceMock.Setup(m => m.Reset(It.IsAny<long>())).Returns(Task.FromResult((RoboDto)null));
            _service = _serviceMock.Object;

            var _record = await _service.Reset(Id);
            Assert.Null(_record);
        }
        #endregion

        #region Update
        [Fact(DisplayName = "Service Update")]
        public async Task Service_Update()
        {
            _serviceMock = new Mock<IRoboService>();
            _serviceMock.Setup(m => m.Update(roboUpdateDto)).ReturnsAsync(roboDto);
            _service = _serviceMock.Object;

            var result = await _service.Update(roboUpdateDto);

            Assert.NotNull(result);
            Assert.True(result.Id == Id);

            _serviceMock = new Mock<IRoboService>();
            _serviceMock.Setup(m => m.Update(roboUpdateDto)).ReturnsAsync(roboDto);
            _service = _serviceMock.Object;

            var record = await _service.Update(roboUpdateDto);
            Assert.NotNull(record);
        }
        #endregion

    }
}
