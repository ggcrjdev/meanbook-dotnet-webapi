using MeanBookApi.Models;
using System.Collections.Generic;

namespace MeanBookApi.Controllers.RequestResponse
{
    public class PostsListResponse
    {
        public IList<Post> posts { get; private set; }
        public int postsCount { get; private set; }

        public PostsListResponse(IList<Post> posts)
        {
            this.posts = posts;
            postsCount = posts.Count;
        }
    }
}
