using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FIAP.Core.Infra.Interface;
using FIAP.Parceria.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FIAP.Portal.Controllers
{
    public class ParceriaController : BaseController
    {
        public ParceriaController(IConfiguration configuration, IApiCaller apiCaller) : base(configuration, apiCaller)
        {
        }

        // GET: Parceria
        public async Task<IActionResult> Index()
        {
            IEnumerable<Parceria.Models.Parceria> result;
            try
            {
                result = await _apiCaller.GetAsync<IEnumerable<Parceria.Models.Parceria>>(_config.GetConnectionString("API"), "/Parceria");
            }
            catch (Exception)
            {
                result = Enumerable.Empty<Parceria.Models.Parceria>();
            }

            return View(result);
        }

        // GET: Parceria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parceria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm]Parceria.Models.Parceria parceria)
        {
            try
            {
                await _apiCaller.Post<Parceria.Models.Parceria>(parceria,
                    _config.GetConnectionString("API"), "/Parceria");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Parceria/Edit/5
        public async Task<IActionResult> Edit(int codigo)
        {
            var parceria = await _apiCaller.GetAsync<Parceria.Models.Parceria>(_config.GetConnectionString("API"),
                $"/Parceria/{codigo}");
            return View(parceria);
        }

        // POST: Parceria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm]Parceria.Models.Parceria parceria)
        {
            try
            {
                var result = await _apiCaller.Put<Parceria.Models.Parceria>(parceria,
                        _config.GetConnectionString("API"), $"/Parceria/{parceria.Codigo}");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Parceria/Delete/5
        public async Task<IActionResult> Delete(int codigo)
        {
            try
            {
                var result = await _apiCaller.Delete<Parceria.Models.Parceria>(_config.GetConnectionString("API"), $"/Parceria/{codigo}");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}