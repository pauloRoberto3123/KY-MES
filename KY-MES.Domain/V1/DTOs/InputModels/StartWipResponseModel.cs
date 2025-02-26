using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.InputModels
{
    public class StartWipResponseModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failureReason")]
        public string? FailureReason { get; set; }
    }
}
