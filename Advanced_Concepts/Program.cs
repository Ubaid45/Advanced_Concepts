using System;
using System.Threading.Tasks;
using Advanced_Concepts.Delegates;

namespace Advanced_Concepts
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region Generics

            var number = new Nullable<int>(0);
            Console.WriteLine("Has Value: "+ number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            #endregion

            #region Delegates
            // Use for extesibility and flexibility
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();

            Action<Photo> filterHandler = photoFilters.ApplyBrightness;
            filterHandler += photoFilters.ApplyContrast;
            filterHandler += RemoveRedEye;

            processor.Process("Photos.jpg", filterHandler);
            #endregion
        }

        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove Red line");
        }
    }
}
