using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSoundCloudApi.Entities.Web
{
    public class Result
    {
        public Result(bool isSuccess, string json)
        {
            IsSuccess = isSuccess;
            ResultJson = json;
        }

        public bool IsSuccess { get; private set; }
        public string ResultJson { get; private set; }
    }
}
