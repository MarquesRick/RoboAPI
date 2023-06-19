using Microsoft.AspNetCore.Mvc;
using RoboAPI.Domain.Dtos.Robo;
using RoboAPI.Domain.Interfaces.Services;
using RoboAPI.Service.Util;
using System.Net;

namespace RoboAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoboController : ControllerBase
    {
        [HttpGet]
        [Route("GetById/{id}", Name = "GetById")]
        public async Task<ActionResult> GetById([FromServices] IRoboService roboService, long id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await roboService.GetById(id);
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
        [Route("GetAll", Name = "GetAll")]
        public async Task<ActionResult> GetAll([FromServices] IRoboService roboService)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await roboService.GetAll();
                if (result == null)
                    return Ok(Enumerable.Empty<RoboDto>());

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("GetReset/{id}", Name = "GetReset")]
        public async Task<ActionResult> GetReset([FromServices] IRoboService roboService, long id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await roboService.Reset(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (CustomValidationException ex)
            {
                ModelState.AddModelError(ex.Titulo, ex.MensagemErro);
                return ValidationProblem(ModelState);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateRobo", Name = "UpdateRobo")]
        public async Task<ActionResult> Put([FromServices] IRoboService roboService, [FromBody] RoboUpdateDto robo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await roboService.Update(robo);
                if (result != null) 
                    return Ok(result);

                return BadRequest();
            }
            catch (CustomValidationException ex)
            {
                ModelState.AddModelError(ex.Titulo, ex.MensagemErro);
                return ValidationProblem(ModelState);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("CreateRobo", Name = "CreateRobo")]
        public async Task<ActionResult> Post([FromServices] IRoboService roboService, [FromBody] RoboCreateDto robo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await roboService.Post(robo);
                if (result != null)
                    return Created(new Uri(Url.Link("GetById", new { id = result.Id })), result);

                return BadRequest();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteRobo/{id}", Name = "DeleteRobo")]
        public async Task<ActionResult> Delete([FromServices] IRoboService roboService, long id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                return Ok(await roboService.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}