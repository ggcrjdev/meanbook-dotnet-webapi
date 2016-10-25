using MeanBookApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeanBookApi.Controllers.RequestResponse
{
    public class PostsListResponse
    {
        public List<Post> posts { get; private set; }
        public int postsCount { get; private set; }

        public PostsListResponse(List<Post> posts)
        {
            this.posts = posts;
            postsCount = posts.Count;
        }
    }
}
