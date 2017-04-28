using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestShop.Service;
using TestShop.Web.Infrastructure.Core;

namespace TestShop.Web.Api
{
    [RoutePrefix("api/home")]
    [Authorize]
    public class HomeController : ApiControllerBase
    {
        IErrorService _errorService;
        public HomeController(IErrorService errorService) : base(errorService)
        {
            this._errorService = errorService;
        }

        [Route("TestMethod")]
        [HttpGet]        
        public string TestMethod()
        {
            return "Hello, hello cái bô. ";
        }
    }
}
