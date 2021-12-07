using System;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private TeamService _service;
        public TeamController(TeamService service)
        {
            _service = service;
        }


        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var list = _service.Get();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("{em}", Name = "TeamById")]
        public IActionResult Get(string em)
        {
            try
            {
                var t = _service.Get(em);

                if (t == null)
                    return NotFound();
                return Ok(t);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(Team obj)
        {
            try
            {
                var t = _service.Create(obj);
                return CreatedAtRoute("TeamById", obj);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPut]
        public IActionResult Update(Team obj)
        {
            try
            {
                var t = _service.Update(obj);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
