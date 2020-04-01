using System;
using System.Threading.Tasks;
using Advanced_Concepts.Delegates;
using Advanced_Concepts.LamdaExpressions;

namespace Advanced_Concepts
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region Generics

            Console.WriteLine("------- Starting Generics ---------");
            var number = new Nullable<int>(0);
            Console.WriteLine("Has Value: "+ number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            #endregion

            #region Delegates

            Console.WriteLine("------- Starting Delegates ---------");
            // Use for extesibility and flexibility
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();

            Action<Photo> filterHandler = photoFilters.ApplyBrightness;
            filterHandler += photoFilters.ApplyContrast;
            filterHandler += RemoveRedEye;

            processor.Process("Photos.jpg", filterHandler);
            #endregion

            #region Lambda Expressions

            Console.WriteLine("------- Starting Lambda Expressions ---------");
            const int factor = 5;
            Func<int, int> multiplier = num => num * factor;
            Console.WriteLine("The result after multiplication: " + multiplier(50));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price <= 35);
            Console.WriteLine("Books having the price less than 35: ");
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title);

            #endregion
        }

        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove Red line");
        }
    }
}
