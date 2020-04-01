using System;
namespace Advanced_Concepts.EventsandDelegates
{
    public class MessageService
    {
        // Subscriber signature should match the delegate
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Serrvice: Sending a message..." + args.Video.Title);
        }

    }
}
