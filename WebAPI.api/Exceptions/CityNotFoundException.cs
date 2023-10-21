using System.Net;

namespace WebAPI.Exceptions
{
    public class CityNotFoundException : BaseException
    {
        public CityNotFoundException(string message) : base("BI:0001", message, HttpStatusCode.NotFound, null) { }
        public CityNotFoundException(string message, Exception ex) : base("BI:0001", message, HttpStatusCode.NotFound, ex) { }
    }
}
