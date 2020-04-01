using System;
namespace Advanced_Concepts.Exceptionhandling
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
