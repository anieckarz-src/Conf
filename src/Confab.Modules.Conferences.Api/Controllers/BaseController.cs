using Microsoft.AspNetCore.Mvc;

namespace Confab.Modules.Conferences.Api.Controllers;

[ApiController]
[Route("conference-module/[controller]")]
internal class BaseController : ControllerBase
{
        protected ActionResult<T> OkOrNotFound<T>(T result) 
        {
            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }
}
