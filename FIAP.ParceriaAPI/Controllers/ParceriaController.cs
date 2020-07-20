using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FIAP.Parceria.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FIAP.ParceriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParceriaController : ControllerBase
    {
        private IParceriaService _parceriaService;
        public ParceriaController(IParceriaService parceriaService)
        {
            _parceriaService = parceriaService;
        }

        // GET: api/Parceria
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _parceriaService.GetParcerias();

            return Ok(result);
        }

        // GET: api/Parceria/5
        [HttpGet("{codigo}")]
        public async Task<IActionResult> Get(int codigo)
        {
            var result = await _parceriaService.GetParceria(codigo);

            return Ok(result);
        }

        // POST: api/Parceria
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Parceria.Models.Parceria payload)
        {
            var result = await _parceriaService.InsertParceria(payload);

            if (result)
                return Ok();

            return StatusCode(500);
        }

        // PUT: api/Parceria/5
        [HttpPut("{codigo}")]
        public async Task<IActionResult> Put(int codigo, [FromBody] Parceria.Models.Parceria payload)
        {
            payload.Codigo = codigo;
            var result = await _parceriaService.UpdateParceria(payload);

            if (result)
                return Ok();

            return StatusCode(500);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{codigo}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            var result = await _parceriaService.DeleteParceria(codigo);

            if (result)
                return Ok();

            return StatusCode(500);
        }
    
        [Route("PesquisaParceria")]
        [HttpGet]
        public async Task<IActionResult> PesquisaParceria(string pesquisa)
        {
            return Ok();
        }


    
    }
}
