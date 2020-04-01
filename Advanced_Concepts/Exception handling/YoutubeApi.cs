using System;
using System.Collections.Generic;
using Advanced_Concepts.EventsandDelegates;

namespace Advanced_Concepts.Exceptionhandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos()
        {
            try
            {
                // Access youtube web service
                // Read the data
                // Create a list od Video objects

                throw new Exception("Oops!! some low level youtube error.");
            }
            catch(Exception ex)
            {
                // Log

                throw new YoutubeException("Could not fetch the videos from Youtube.", ex);
            }
        }
    }
}
