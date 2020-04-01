using System;
using System.Threading.Tasks;
using Advanced_Concepts.Delegates;

namespace Advanced_Concepts
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();

            Action<Photo> filterHandler = photoFilters.ApplyBrightness;
            filterHandler += photoFilters.ApplyContrast;
            filterHandler += RemoveRedEye;

            processor.Process("Photos.jpg", filterHandler);
        }

        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove Red line");
        }
    }
}
