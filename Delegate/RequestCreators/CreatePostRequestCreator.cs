using Delegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Delegate.RequestCreators
{
    public class CreatePostRequestCreator:BaseRequestCreator
    {
        private PostModel postmodel;
        public PostModel CreatePost(PostModel model)
        {
            postmodel = model;
            var responseContent = base.MakeRequest();
            return JsonSerializer.Deserialize<PostModel>(responseContent);
        }
        protected override object GetBodyObject()
        {
            return postmodel;
        }
        protected override string GetBaseAddress()
        {
            return "https://jsonplaceholder.typicode.com/";
        }

        protected override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Post;
        }

        protected override string GetUrlPath()
        {
            return "posts";
        }
    }
}
