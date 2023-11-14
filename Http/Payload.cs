using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruelWorld
{
    public class Payload
    {
        // private int RequestId = 0;
        // private string ClassName { get; set; } = "ServerRequest";
        // private string RequestClass { get; set; }
        // private JArray RequestData { get; set; } = new JArray();
        //
        // private string RequestMethod { get; set; }
        
        private PayloadParams[] _params;
        
        // public Payload(PayloadParams payloadParams)
        // {
        //     RequestId = payloadParams.RequestId;
        //     ClassName = payloadParams.ClassName;
        //     RequestClass = payloadParams.RequestClass;
        //     RequestData = payloadParams.RequestData;
        //     RequestMethod = payloadParams.RequestMethod;
        // }
        
        public Payload(PayloadParams[] payloadParams)
        {
            _params = payloadParams;
        }

        public JArray ToJsonObject()
        {
            var payloadParams = new JArray();
            
            foreach (var param in _params)
            {
                var j = new JObject
                {
                    ["__class__"] = param.ClassName,
                    ["requestData"] = new JArray(param.RequestData),
                    ["requestClass"] = param.RequestClass,
                    ["requestMethod"] = param.RequestMethod,
                    ["requestId"] = param.RequestId
                };

                payloadParams.Add(j);
            }
            return payloadParams;
        }
        
        public override string ToString()
        {
            return ToJsonObject().ToString(Formatting.None);
        }
    }
}