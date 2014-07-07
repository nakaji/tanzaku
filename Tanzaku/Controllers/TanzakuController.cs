using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Query.Dynamic;
using Tanzaku.Models;

namespace Tanzaku.Controllers
{
    public class TanzakuController : ApiController
    {
        public dynamic Get(string text="")
        {
            var generator = new TanzakuMaker();

            return Json(new { Text = generator.Generate(text)});
        }
    }
}
