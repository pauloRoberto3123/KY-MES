using KY_MES.Domain.V1.DTOs.InputModels;
using KY_MES.Domain.V1.DTOs.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Services.DomainServices.Interfaces
{
    public interface IMESService
    {
        Task SignInAsync(SignInRequestModel signInRequestModel);
        Task<GetWipIdBySerialNumberResponseModels> GetWipIdBySerialNumberAsync(GetWipIdBySerialNumberRequestModel getWipIdRequestModel);
        Task<OkToStartResponseModel> OkToStartAsync(OkToStartRequestModel okToStartRequestModel);
        Task<StartWipResponseModel> StartWipAsync(StartWipRequestModel startWipRequestModel);
        Task<CompleteWipResponseModel> CompleteWipFailAsync(CompleteWipFailRequestModel completWipRequestModel, string WipId);
        Task<CompleteWipResponseModel> CompleteWipPassAsync(CompleteWipPassRequestModel completWipRequestModel, string WipId);
    }
}
