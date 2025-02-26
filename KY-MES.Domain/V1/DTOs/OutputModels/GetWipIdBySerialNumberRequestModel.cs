using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.OutputModels
{
    public class GetWipIdBySerialNumberRequestModel
    {
        public string? SiteName { get; set; }
        public string? SerialNumber { get; set; }
    }
}
