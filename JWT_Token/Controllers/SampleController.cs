using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace JWT_Token.Controllers
{
    public class SampleController : Controller
    {
        // GET api/sample/load
        [HttpGet]
        [Authorize(Roles = "admin,manager")]
        public ActionResult<IEnumerable<string>> Load()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/sample/loadone/{id}
        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<string> LoadOne(int id)
        {
            return "value";
        }
    }
}
