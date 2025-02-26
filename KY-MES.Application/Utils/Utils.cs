using KY_MES.Domain.V1.DTOs.InputModels;
using KY_MES.Domain.V1.DTOs.OutputModels;

namespace KY_MES.Application.Utils
{
    public class Utils
    {
        public SignInRequestModel SignInRequest(string username, string password)
        {
            return new SignInRequestModel
            {
                Username = username,
                Password = password
            };
        }
        public GetWipIdBySerialNumberRequestModel SpiToGetWip(SPIInputModel spi)
        {
            return new GetWipIdBySerialNumberRequestModel 
            {
                SiteName = "Manaus",
                SerialNumber = spi.Inspection.Barcode
            };
        }

        public OkToStartRequestModel ToOkToStart(SPIInputModel spi, GetWipIdBySerialNumberResponseModels getWip)
        {
            return new OkToStartRequestModel
            {
                WipId = getWip.WipId,
                ResourceName = spi.Inspection.Machine
            };
        }

        public StartWipRequestModel ToStartWip(SPIInputModel spi, GetWipIdBySerialNumberResponseModels getWip)
        {
            return new StartWipRequestModel
            {
                WipId = getWip.WipId,
                SerialNumber = spi.Inspection.Barcode,
                ResourceName = spi.Inspection.Machine,
                StartDateTimeString = ""
            };
        }

        public CompleteWipRequestModel ToCompleteWip(SPIInputModel spi, GetWipIdBySerialNumberResponseModels getWip)
        {
            if (!string.IsNullOrEmpty(spi.Inspection.Result) && spi.Inspection.Result != "NG")
                return new CompleteWipRequestModel
                {
                    SerialNumber = spi.Inspection.Barcode,
                };
            else
            {
                List<FailureLabelList> failureLabels = [];
                List<PanelFailureLabelList> panelFailureLabels = [];
                List<Failure> failures = [];

                failureLabels.Add(new FailureLabelList
                {
                    SymptomLabel = spi.Board[0].Defects[0].DefectDescription,
                    FailureMessage = ""
                });

                panelFailureLabels.Add(new PanelFailureLabelList
                {
                    WipId = getWip.WipId,
                    FailureLabelList = failureLabels,
                    FailureDateTime = null
                });

                failures.Add(new Failure
                {
                    SymptomLabel = spi.Board[0].Defects[0].DefectDescription,
                    FailureMessage = spi.Board[0].Defects[0].DefectDescription,
                    PanelFailureLabelList = panelFailureLabels,
                });

                return new CompleteWipRequestModel
                {
                    IsSingleWipMode = false,
                    Failures = failures
                };
            }
                
        }
    }
}
