using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.OutputModels
{
    public class GetPanelWipsBySerialNumberRequestModel
    {
        public Data data { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public int errorCode { get; set; }
    }

    public class Data
    {
        public int panelId { get; set; }
        public string serialNumber { get; set; }
        public int actualWipPerPanel { get; set; }
        public int configuredWipPerPanel { get; set; }
        public string assemblyNumber { get; set; }
        public string assemblyRevision { get; set; }
        public string assemblyVersion { get; set; }
        public List<Wip> wips { get; set; }
    }

    public class Wip
    {
        public int wipId { get; set; }
        public string serialNumber { get; set; }
        public int panelPosition { get; set; }
    }
}
