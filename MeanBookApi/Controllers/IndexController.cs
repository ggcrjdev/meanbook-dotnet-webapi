using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace MeanBookApi.Controllers
{
    [RoutePrefix("api")]
    public class IndexController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Index()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent(createIndexContent());
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }

        private string createIndexContent()
        {
            var title = "Mean Book API (ASP.NET Web API)";
            var html = "<doctype html><html>";
            html += "<head><title>" + title + "</title></head>";
            html += "<body><h2>Welcome to the " + title + "!</h2></body>";
            html += "</html>";
            return html;
        }
    }
}
