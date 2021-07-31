using System;
using System.Text;

namespace Modulo8DesSoftware.Web.Util
{
    public interface IApiClient
    {
        Encoding Encoding { get; set; }
        TimeSpan Timeout { set; }
        T Get<T>(string path);
        T Post<T>(string path, object entity);
        void Post(string path);
        void Post(string path, object entity);
        void Put(string path, object entity);
        T Put<T>(string path, object entity);
    }
}
