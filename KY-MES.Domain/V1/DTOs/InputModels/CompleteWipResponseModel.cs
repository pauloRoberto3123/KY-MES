using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.InputModels
{
    public class CompleteWipResponseModel
    {
        [JsonProperty("WipInQueueRouteSteps")]
        public List<WipInQueueRouteStep>? WipInQueueRouteSteps { get; set; }

        [JsonProperty("ResponseMessages")]
        public List<string>? ResponseMessages { get; set; }

        [JsonProperty("Document")]
        public Document? Document { get; set; }
    }

    public partial class Document
    {
        [JsonProperty("Model")]
        public List<object>? Model { get; set; }

        [JsonProperty("ErrorMessage")]
        public object? ErrorMessage { get; set; }
    }

    public partial class WipInQueueRouteStep
    {
        [JsonProperty("InQueueRouteStep")]
        public List<InQueueRouteStep>? InQueueRouteStep { get; set; }

        [JsonProperty("SerialNumber")]
        public string? SerialNumber { get; set; }
    }

    public partial class InQueueRouteStep
    {
        [JsonProperty("RouteStepId")]
        public long RouteStepId { get; set; }

        [JsonProperty("RouteStepName")]
        public string? RouteStepName { get; set; }
    }
}
