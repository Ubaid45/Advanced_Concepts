﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advanced_Concepts.Delegates;
using Advanced_Concepts.ExtensionMethods;
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

            #region Extension Methods

            Console.WriteLine("------- Starting Extension Methods ---------");

            string post = "This is supposed to be a very long post blah blah blah";
            //Our extension method
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);

            //Pre-defined extension method
            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 18, 9, 34, 12 };
            Console.WriteLine("The maximum number from the list:" + numbers.Max());

            #endregion

            #region LINQ

            Console.WriteLine("------- Starting LINQ ---------");

            #endregion

            #region Events and Delegates

            Console.WriteLine("------- Starting Events and Delegates ---------");

            #endregion

            #region Nullable types

            Console.WriteLine("------- Starting Nullable types ---------");

            #endregion

            #region Dynamic

            Console.WriteLine("------- Starting Dynamic ---------");

            #endregion

            #region Exception Handling

            Console.WriteLine("------- Starting Exception Handling ---------");

            #endregion

            #region Async and Await

            Console.WriteLine("------- Starting Async and Await ---------");

            #endregion
        }

        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove Red line");
        }
    }
}
