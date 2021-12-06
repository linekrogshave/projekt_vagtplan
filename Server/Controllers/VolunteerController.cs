using System;
using Microsoft.AspNetCore.Mvc;
using vagtplanen.Server.Services;

namespace vagtplanen.Server.Controllers
{
    //Data i dennne controller routes til "....../api/volunteer"
    [Route("api/[controller]")]
    [ApiController]

    //Nedarver fra ControllerBase
    //Standard Klasse for at lave controllers
    public class VolunteerController : ControllerBase
    {
        //Genererer tom VolunteerService
        private VolunteerService _service;
        public VolunteerController(VolunteerService service)
        {
            //Gemmer service til tidligere tomme public VolunteerService
            //Herinde ligger forretningslogik og connection til database
            _service = service;
        }


        //Method til at hente alle volunteers til .../api/volunteer
        [HttpGet]
        public ActionResult Get()
        {
            //Forsøger
            try
            {
                //Kører 'Get()' metoden fra Service-laget
                //Gemmer alle volunteers som IEnumerable<Volunteer> i 'list'
                //Returnerer listen af alle volunteres med et Status 200 OK reponse
                var list = _service.Get();
                return Ok(list);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }

        //Method til at hente alle volunteer til og fra .../api/volunteer/@email
        [HttpGet("{em}", Name = "VolunteerById")]
        public IActionResult Get(string em)
        {
            //Forsøger
            try
            {
                //Kører 'Get(string un)' metoden fra Service - laget
                //Gemmer den volunteer som har email magen til em fra input i 'coor'
                //Returnerer listen af alle volunteres med et Status 200 OK reponse
                var coor = _service.Get(em);

                //Hvis 'coor' ikke kan findes i metoden returneres Status 404
                if (coor == null)
                    return NotFound();
                return Ok(coor);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }

        //Method til at hente post volunteer til databasse gennnemm .../api/volunteer
        [HttpPost]
        public IActionResult Create(Volunteer vol)
        {
            //Forsøger
            try
            {
                //Kører 'Create()' metoden fra Service - laget
                //Gemmer samme objekt som fra input i 'coor'
                //Returnerer objektet et Status 201 Created response
                var coor = _service.Create(vol);
                return CreatedAtRoute("VolunteerById", vol);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }

        //Method til at hente put volunteer i databasse gennnemm .../api/volunteer
        [HttpPut]
        public IActionResult Update(Volunteer vol)
        {
            //Forsøger
            try
            {
                // Kører 'Update()' metoden fra Service - laget
                //Gemmer samme objekt som fra input i 'coor'
                //Returnerer objektet et Status 200 OK reponse
                var coor = _service.Update(vol);
                return Ok(coor);
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }

        //Method til at hente delete volunteer i databasse gennnemm .../api/volunteer/@id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Forsøger
            try
            {
                //Kører Delete method fra Service-laget og bruger 'id' som parameter
                //Når kørt, returneres en "NoContentResult" fra ControllerBase klassen
                //Melder: 204 No Content
                _service.Delete(id);
                return NoContent();
            }
            //Hvis fejl
            catch (Exception ex)
            {
                //Returnerer Status 500 for fejl og skriver meddelelsen for fejlen
                return StatusCode(500, ex.Message);
            }
        }
    }
}
