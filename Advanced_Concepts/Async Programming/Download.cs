using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Advanced_Concepts.AsyncProgramming
{
    public class Download
    {
        // await keyword tells compiler to move on, this task will take time
        // if you use await keyword, method should be async Task

        //Asynchronous Methods
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync((url));

            using (var streamWriter = new StreamWriter("/Users/office/Desktop/test.html"))
            {
               await streamWriter.WriteAsync(html);
            }

        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }


        //Synchronous Method
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            
            using (var streamWriter = new StreamWriter("/Users/office/Desktop/test.html"))
            {
                streamWriter.Write(html);
            }
            
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

    }
}
