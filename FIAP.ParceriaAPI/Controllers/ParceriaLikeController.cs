using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FIAP.Parceria.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FIAP.ParceriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParceriaLikeController : ControllerBase
    {
        private IParceriaLikeService _parceriaLikeService;
        public ParceriaLikeController(IParceriaLikeService parceriaLikeService)
        {
            _parceriaLikeService = parceriaLikeService;
        }

        // POST: api/ParceriaLike/5
        [HttpPost("{codigoParceria}")]
        public async Task<IActionResult> Post(int codigoParceria)
        {
            var result = await _parceriaLikeService.InsertLike(codigoParceria);

            if (result)
                return Ok();

            return StatusCode(500);
        }
    }
}
