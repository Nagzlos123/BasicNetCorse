using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Web;

namespace HTTPClientApp
{
    public class Program
    {
        static async Task OldMain(string[] args)
        {
           using( var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
                var json = await result.Content.ReadAsStringAsync();

                var posts = JsonConvert.DeserializeObject<List<Post>>(json);

                var selectedPost = posts.First(p => p.Id == 30);

                Console.WriteLine($"Title: {selectedPost.Title}");
                Console.WriteLine($"Body: {selectedPost.Body}");

                selectedPost.Title = "Lubie placki";
                selectedPost.Body = "Grubas";

                Console.WriteLine($"Title: {selectedPost.Title}");
                Console.WriteLine($"Body: {selectedPost.Body}");

                var postJsonContent = new StringContent(JsonConvert.SerializeObject(selectedPost));

                var postResult = await httpClient
                    .PostAsync("https://jsonplaceholder.typicode.com/posts", postJsonContent);

                using (var postRequestMessage =
                    new HttpRequestMessage(HttpMethod.Post, "https://jsonplaceholder.typicode.com/posts"))
                {
                    //postRequestMessage.Headers.Add("content-type", "application/json");
                    postRequestMessage.Content = postJsonContent;

                    var postResult2 = await httpClient.SendAsync(postRequestMessage);
                }

                var queryParams = HttpUtility.ParseQueryString(string.Empty);

                queryParams["postId"] = "1";

                var formattedParams = queryParams.ToString();

                Console.WriteLine($"Formatted params: {formattedParams}");
            }
        }
    }
}
