using Newtonsoft.Json.Linq;

namespace CruelWorld
{
    public class PayloadParams
    {
        public int RequestId;
        public string ClassName;
        public string RequestClass;
        public JArray RequestData;
        public string RequestMethod;
    }
}