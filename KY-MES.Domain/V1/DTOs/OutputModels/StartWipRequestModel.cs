using Newtonsoft.Json;
using System;

namespace KY_MES.Domain.V1.DTOs.OutputModels
{
    public partial class StartWipRequestModel
    {
        [JsonProperty("wipId")]
        public long WipId { get; set; }

        [JsonProperty("serialNumber")]
        public string? SerialNumber { get; set; }

        [JsonProperty("resourceName")]
        public string? ResourceName { get; set; }

        [JsonProperty("startDateTimeString")]
        public string? StartDateTimeString { get; set; }
    }
}
