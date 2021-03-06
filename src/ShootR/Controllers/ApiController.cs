﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShootR.Controllers
{
    [Route("/api")]
    public class ApiController : Controller
    {
        [Route("join")]
        public async Task<IActionResult> Join([FromQuery] string name, [FromQuery] string role, [FromQuery] string photoUrl)
        {
            await LoginHelper.SignInAsync(HttpContext, name, role, photoUrl);
            return Ok();
        }
    }
}
