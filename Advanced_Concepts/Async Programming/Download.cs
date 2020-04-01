using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Advanced_Concepts.AsyncProgramming
{
    public class Download
    {

        //Asynchronous Method
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringAsync(Uri.EscapeUriString(url));

            using (var streamWriter = new StreamWriter("/Users/office/Desktop/test.html"))
            {
                streamWriter.Write(html);
            }

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

    }
}
