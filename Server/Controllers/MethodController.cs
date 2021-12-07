using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;
using vagtplanen.Shared.Models;

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
        [HttpPost("usecoupon/{vol}")]
        public async Task UseCoupon(int vol, Coupon c)
        {
            try
            {
                await _service.UseCoupon(vol, c);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("buycoupon/{vol}")]
        public async Task BuyCoupon(int vol, Coupon c)
        {
            try
            {
                await _service.BuyCoupon(vol, c);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("assignshift")]
        public async Task AssignShift(Shift s)
        {
            try
            {
                await _service.AssignShift(s);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("deassignshift")]
        public async Task DeAssignShift(Shift s)
        {
            try
            {
                await _service.DeassignShift(s);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("assignteamtask")]
        public async Task AssignTeamTask(TeamTask tt)
        {
            try
            {
                await _service.AssignTeamtask(tt);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("deassignteamtask")]
        public async Task DeAssignTeamTask(TeamTask tt)
        {
            try
            {
                await _service.AssignTeamtask(tt);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("lockshift")]
        public async Task LockShift(Shift s)
        {
            try
            {
                await _service.LockShift(s);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("locktask")]
        public async Task LockTask (TaskClass t)
        {
            try
            {
                await _service.LockTask(t);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
        [HttpPost("lockteamtask")]
        public async Task LockTask(TeamTask tt)
        {
            try
            {
                await _service.LockTeamtask(tt);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("assignskill/{vol}")]
        public async Task AssignSkill(int vol, Skill s)
        {
            try
            {
                await _service.AssignSkill(vol, s);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }

        [HttpPost("deassignskill/{vol}")]
        public async Task DeAssignSkill(int vol, Skill s)
        {
            try
            {
                await _service.DeAssignSkill(vol, s);
            }
            catch (Exception ex)
            {
                //log error
                StatusCode(500, ex.Message);
            }
        }
    }
}
