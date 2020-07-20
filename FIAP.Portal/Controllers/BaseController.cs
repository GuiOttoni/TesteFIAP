using FIAP.Core.Infra.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Portal.Controllers
{
    public class BaseController : Controller
    {
        internal IConfiguration _config;
        internal IApiCaller _apiCaller;
        public BaseController(IConfiguration config, IApiCaller apiCaller) : base()
        {
            _config = config;
            _apiCaller = apiCaller;
        }
    }
}
