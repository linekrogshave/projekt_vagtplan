using System;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TaskClassController : ControllerBase
    {
        private TaskClassService _service;
        public TaskClassController(TaskClassService service)
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

        [HttpGet("{em}", Name = "TaskClassById")]
        public IActionResult Get(int em)
        {
            try
            {
                var coor = _service.Get(em);

                if (coor == null)
                    return NotFound();
                return Ok(coor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(TaskClass vol)
        {
            try
            {
                var coor = _service.Create(vol);
                return CreatedAtRoute("TaskClassById", vol);
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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
