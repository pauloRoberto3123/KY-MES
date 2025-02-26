using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.InputModels
{
    public class OkToStartResponseModel
    {
        [JsonProperty("OkToStart")]
        public bool OkToStart { get; set; }

        [JsonProperty("RouteStepId")]
        public long RouteStepId { get; set; }

        [JsonProperty("RouteStepName")]
        public string? RouteStepName { get; set; }

        [JsonProperty("WipId")]
        public List<long>? WipId { get; set; }
    }
}
