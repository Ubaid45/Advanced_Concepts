using System;
namespace Advanced_Concepts.EventsandDelegates
{
    
    public class MailService
    {
        // Subscriber signature should match the delegate
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mail Serrvice: Sending an email..." + args.Video.Title);
        }

    }
}
