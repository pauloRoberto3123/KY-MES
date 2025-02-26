using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Domain.V1.DTOs.OutputModels
{
    public class SignInRequestModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
