using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.OutputModels
{
    public class CompleteWipRequestModel
    {
        public string? SerialNumber { get; set; }
        [JsonProperty("isSingleWipMode")]
        public bool IsSingleWipMode { get; set; }

        [JsonProperty("failures")]
        public List<Failure>? Failures { get; set; }
    }

    public partial class Failure
    {
        [JsonProperty("symptomLabel")]
        public string? SymptomLabel { get; set; }

        [JsonProperty("failureMessage")]
        public string? FailureMessage { get; set; }

        [JsonProperty("panelFailureLabelList")]
        public List<PanelFailureLabelList>? PanelFailureLabelList { get; set; }
    }

    public partial class PanelFailureLabelList
    {
        [JsonProperty("wipId")]
        public long WipId { get; set; }

        [JsonProperty("failureLabelList")]
        public List<FailureLabelList>? FailureLabelList { get; set; }

        [JsonProperty("failureDateTime")]
        public object? FailureDateTime { get; set; }
    }

    public partial class FailureLabelList
    {
        [JsonProperty("symptomLabel")]
        public string? SymptomLabel { get; set; }

        [JsonProperty("failureMessage")]
        public string? FailureMessage { get; set; }
    }
}
