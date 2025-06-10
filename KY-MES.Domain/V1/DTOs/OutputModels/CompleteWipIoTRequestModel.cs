using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.OutputModels
{
    public class CompleteWipIoTRequestModel
    {
        //public int WipId { get; set; }
        public DateTime EndDateTimeString { get; set; }
        public bool IsSingleWIPMode { get; set; }
        public string? ValidateSetupSheet { get; set; }
    }
}
