using CasinoSlotsApi.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CasinoSlotsApi.Controllers;

public class AccountController : BaseApiController
{
    [AllowAnonymous, HttpGet("GetCellType")]
    public ActionResult GetCell()
    {
        return Ok(new { ECellType = Enum.GetValues(typeof(ECellType)).Cast<ECellType>().RandomElement().ToString() });
    }
}