using Newtonsoft.Json.Linq;

namespace CruelWorld.IronAgeRoad
{
    public class FOERequestData
    {
        private string _requestClass;
        private string _requestMethod;
        private JArray _requestData;
        
        public string RequestClass => _requestClass;
        public string RequestMethod => _requestMethod;
        public JArray RequestData => _requestData;

        public FOERequestData(string requestClass, string requestMethod, JArray requestData)
        {
            _requestClass = requestClass;
            _requestMethod = requestMethod;
            _requestData = requestData;
        }
    }
}