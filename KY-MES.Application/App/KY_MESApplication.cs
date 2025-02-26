using KY_MES.Application.Utils;
using KY_MES.Domain.V1.DTOs.InputModels;
using KY_MES.Domain.V1.DTOs.OutputModels;
using KY_MES.Domain.V1.Interfaces;
using KY_MES.Services.DomainServices.Interfaces;
using System.Net;

namespace KY_MES.Controllers
{
    public class KY_MESApplication : IKY_MESApplication
    {
        private readonly IMESService _mESService;
        private readonly Utils utils;
        public KY_MESApplication(IMESService mESService)
        {
            _mESService = mESService;
        }

        public async Task<HttpStatusCode> SPISendWipData(SPIInputModel sPIInput)
        {
            var username = Environment.GetEnvironmentVariable("Username");
            var password = Environment.GetEnvironmentVariable("Password");

            await _mESService.SignInAsync(utils.SignInRequest(username, password));

            var getWipResponse = await _mESService.GetWipIdBySerialNumberAsync(utils.SpiToGetWip(sPIInput));
            if (getWipResponse.WipId == null)
            {
                return HttpStatusCode.BadRequest;
                throw new Exception("WipId is null");
            }

            var okToTestResponse = await _mESService.OkToStartAsync(utils.ToOkToStart(sPIInput, getWipResponse));
            if (!okToTestResponse.OkToStart || okToTestResponse == null)
            {
                return HttpStatusCode.BadRequest;
                throw new Exception("Check PV failed");
            }

            var startWipResponse = await _mESService.StartWipAsync(utils.ToStartWip(sPIInput, getWipResponse));
            if (!startWipResponse.Success || startWipResponse == null)
            {
                return HttpStatusCode.BadRequest;
                throw new Exception("start Wip failed");
            }

            var completeWipResponse = await _mESService.CompleteWipAsync(utils.ToCompleteWip(sPIInput, getWipResponse), getWipResponse.WipId.ToString());
            if (completeWipResponse.Equals(null))
            {
                return HttpStatusCode.BadRequest;
                throw new Exception("complete wip failed");
            }
            return HttpStatusCode.OK;
        }
    }
}
