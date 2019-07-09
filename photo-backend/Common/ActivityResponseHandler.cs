
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Common
{
    public class ActivityResponseHandler : DelegatingHandler
    {
       /* private static HttpResponseMessage RemoveActivityBlockedFields(HttpResponseMessage response, ObjectContent content)
        {
            var formatter = new JsonMediaTypeFormatter { };
           

            formatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            formatter.SerializerSettings.ContractResolver = new DynamicContractResolver();
            response.Content = new ObjectContent(content.ObjectType, content.Value, formatter);
            return response;
        }*/
    }
}
