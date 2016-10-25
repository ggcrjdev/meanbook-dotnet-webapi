using System;

namespace MeanBookApi.Controllers
{
    public class PostAddResponse
    {
        public string id { get; set; }
	    public string authorId { get; set; }
        public string author { get; set; }
        public DateTime timestamp { get; set; }
        public string text { get; set; }
    }
}
