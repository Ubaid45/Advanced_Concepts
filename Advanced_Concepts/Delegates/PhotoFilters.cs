using System;
namespace Advanced_Concepts.Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness is applied");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast is applied");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Photo is resized");
        }
    }
}
