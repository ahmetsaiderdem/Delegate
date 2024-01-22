﻿using Delegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Delegate.RequestCreators
{
    public class GetPostRequestCreator:BaseRequestCreator
    {

        public List<PostModel> GetPosts()
        {
           var responseContent= base.MakeRequest();
            return JsonSerializer.Deserialize<List<PostModel>>(responseContent);
        }
        protected override string GetBaseAddress()
        {
            return "https://jsonplaceholder.typicode.com/";
        }

        protected override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }

        protected override string GetUrlPath()
        {
            return "posts";
        }
    }
}
