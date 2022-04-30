using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoRobotica.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRobotica.webAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SpeechController : ControllerBase
    {
        private readonly ISpeechRepository _speechRepository;

        public SpeechController(ISpeechRepository context)
        {
            _speechRepository = context;
        }

        [HttpPost]
        public IActionResult ConversaoTextoPFala(string texto)
        {
            try
            {
                _speechRepository.TexttoSpeech(texto);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
            return StatusCode(201);
        }
    }
}
