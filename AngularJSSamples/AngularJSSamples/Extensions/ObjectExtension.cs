using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularJSSamples.Extensions
{
    public static class ObjectExtension
    {
        public static string SerializeToJson(this object me, bool isCamelCasePropertyNames = false)
        {
            return isCamelCasePropertyNames
                       ? JsonConvert.SerializeObject(
                           me,
                           new JsonSerializerSettings
                               {
                                   ContractResolver = new CamelCasePropertyNamesContractResolver()
                               })
                       : JsonConvert.SerializeObject(me);
        }
    }
}