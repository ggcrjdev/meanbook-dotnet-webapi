using System;
using System.Collections.Generic;

namespace MeanBookApi.Models
{
    public class Post
    {
        public string id { get; set; }
	    public string author { get; set; }
        public DateTime timestamp { get; set; }
        public string text { get; set; }
        public int likes { get; set; }
        public IList<Comment> comments { get; set; }
        public bool hasComments { get; set; }
        public int commentsCount { get; set; }
    }
}
