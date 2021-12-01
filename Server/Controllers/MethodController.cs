using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;

namespace vagtplanen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MethodController : ControllerBase
    {
        private MethodService _service;
        public MethodController(MethodService service)
        {
            _service = service;
        }


        [HttpGet("login/{un}/{pw}")]
        public async Task<ActionResult> Get(string un, string pw)
        {
            try
            {
                var result = await _service.CheckLogin(un, pw);
                return Ok(result);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("usecoupon/{vol}/{coup}")]
        public async Task UseCoupon(int vol, int coup)
        {
            try
            {
                await _service.UseCoupon(vol, coup);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("buycoupon/{vol}/{coup}")]
        public async Task BuyCoupon(int vol, int coup)
        {
            try
            {
                await _service.BuyCoupon(vol, coup);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("assignshift/{vol}/{shi}")]
        public async Task AssignShift(int vol, int shi)
        {
            try
            {
                await _service.AssignShift(vol, shi);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("deassignshift/{vol}/{shi}")]
        public async Task DeAssignShift(int vol, int shi)
        {
            try
            {
                await _service.DeassignShift(vol, shi);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
    }
}
