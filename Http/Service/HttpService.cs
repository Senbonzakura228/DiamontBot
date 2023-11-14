using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyNameIsGiorgio.Http.Service
{

    public class HttpService
    {
        public static T GetEntityByRequestMethod<T>(string entity, string requestMethod)
        {
            var desyBG =
                JsonConvert.DeserializeObject<dynamic>(entity);
            T result = default;
            foreach (var dd in desyBG)
            {
                if (dd is JObject)
                {
                    foreach (var d in dd as JObject)
                    {
                        if (d.Value != null && d.Key == "requestMethod")
                        {
                            if ((dd as JObject).TryGetValue("requestMethod", out JToken requestMethodToken))
                            {
                                string method = (string) requestMethodToken;
                                if (method == requestMethod)
                                {
                                    result = JsonConvert.DeserializeObject<T>(dd.ToString());
                                    return result;
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}