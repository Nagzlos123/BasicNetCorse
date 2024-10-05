﻿using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPClientApp
{
    public class Flurl
    {
        static async Task Main()
        {
            var posts = await "https://jsonplaceholder.typicode.com/posts"
                .GetAsync()
                .ReceiveJson<List<Post>>();


            var selectedPost = posts.First(p => p.Id == 30);

            Console.WriteLine($"Title: {selectedPost.Title}");
            Console.WriteLine($"Body: {selectedPost.Body}");

            selectedPost.Title = "Lubie placki";
            selectedPost.Body = "Grubas";

            Console.WriteLine($"Title: {selectedPost.Title}");
            Console.WriteLine($"Body: {selectedPost.Body}");


            var postResult = await "https://jsonplaceholder.typicode.com/posts"
                .WithHeaders(new
                {
                    header = "value",
                    header2 = "value2",
                    some_header = "some-header"
                }, true)
                .SetQueryParams(new
                {
                    postId = 1
                })
                .PostJsonAsync(selectedPost);

            Console.WriteLine($"Status: {postResult.StatusCode}");
        }
    }
}
