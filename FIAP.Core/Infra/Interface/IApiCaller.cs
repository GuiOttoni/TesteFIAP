using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Core.Infra.Interface
{
    public interface IApiCaller
    {
        Task<T> GetAsync<T>(string baseUri, string method);

        Task<object> Post<T>(object payload, string baseUri, string method);

        Task<object> Put<T>(object payload, string baseUri, string method);

        Task<object> Delete<T>(string baseUri, string method);
    }
}
