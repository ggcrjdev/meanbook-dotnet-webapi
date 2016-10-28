using System;

namespace MeanBookApi.Models
{
    public class Comment
    {
        public string id { get; set; }
        public string author { get; set; }
        public DateTime timestamp { get; set; }
        public string text { get; set; }
        public int likes { get; set; }
    }
}
