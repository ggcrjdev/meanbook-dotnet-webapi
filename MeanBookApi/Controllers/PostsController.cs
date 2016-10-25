using MeanBookApi.Controllers.RequestResponse;
using MeanBookApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MeanBookApi.Controllers
{
    public class PostsController : ApiController
    {
        private Post[] posts = new Post[]
        {
            new Post { id = "aa1", author = "ggc", timestamp = DateTime.UtcNow, text = "aaa", likes = 1 },
            new Post { id = "aa2", author = "ggc", timestamp = DateTime.UtcNow, text = "bbb", likes = 5 },
            new Post { id = "aa3", author = "ggc", timestamp = DateTime.UtcNow, text = "ccc", likes = 13 }
        };

        [ActionName("list")]
        public PostsListResponse GetList(string id, int extraParam)
        {
            return new PostsListResponse(new List<Post>(posts));
        }

        [ActionName("add")]
        public PostAddResponse PostAdd([FromBody] PostAddRequest post)
        {
            return new PostAddResponse();
        }

        [ActionName("like")]
        public PostLikeResponse PostLike(string id, [FromBody] PostLikeRequest post)
        {
            return new PostLikeResponse();
        }
    }
}
