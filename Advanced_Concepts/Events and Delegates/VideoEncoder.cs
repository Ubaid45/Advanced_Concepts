using System;
using System.Threading;

namespace Advanced_Concepts.EventsandDelegates
{
    // 1 - Define a delegate
    // 2 - Define an event based on that delegate
    // 3 - Raise the event

    // Instead of custome delegate and event, we can use EventHandler, so I am commenting first and second step
    // and replace them with EventHandler<T>

    public class VideoEncoder
    {
        // 1st Step
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //2nd Step
        //public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // For raising the event, method should be protected, virtual and void. Start with On followed by name of the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() {Video = video });

        }
    }
}
