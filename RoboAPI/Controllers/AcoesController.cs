using Microsoft.AspNetCore.Mvc;
using RoboAPI.Domain.Dtos.Acao;
using RoboAPI.Domain.Interfaces.Services;
using System.Net;

namespace RoboAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcoesController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllAcoes", Name = "GetAllAcoes")]
        public async Task<ActionResult> GetAll([FromServices] IAcaoService acaoService)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await acaoService.GetAll();
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("GetAllByType/{type}", Name = "GetAllByType")]
        public async Task<ActionResult> GetAllByType([FromServices] IAcaoService acaoService, long type)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await acaoService.GetAllByType(type);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}