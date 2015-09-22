using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSoundCloudApi.Entities.Web;

namespace PrivateSoundCloudApi.Interfaces
{
    public interface IWebManager
    {
        Task<Result> GetData(string uri);
    }
}
