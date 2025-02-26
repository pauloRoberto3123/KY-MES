using KY_MES.Domain.V1.DTOs.InputModels;
using KY_MES.Domain.V1.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KY_MES.Controllers
{
    public class KY_MESController : ControllerBase
    {
        private readonly IKY_MESApplication _application;
        public KY_MESController(IKY_MESApplication application = null)
        {
            _application = application;
        }

        [HttpPost]
        public async Task<IActionResult> SPISendWipData([FromBody] SPIInputModel sPIInput)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
