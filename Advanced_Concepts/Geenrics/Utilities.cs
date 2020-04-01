using System;
namespace Advanced_Concepts.Geenrics
{
    // Generics can be applied to a class or a method
    /* Five Generics can be specified
     * 1 -  where T : IComparable
     * 2 -  where T : Product (class)
     * 3 -  where T : struct (value Type)
     * 4 -  where T : class (reference type)
     * 5 -  where T : new()
     */

    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T first, T second) 
        {
            return first.CompareTo(second) > 0 ? first : second;
        }

        public void DoSomething(T value)
        {
            //if we want to instantiate T, we must specify where T: new()
            var obj = new T();
        }
    }

    public class DiscountCalculator<T> where T : Product
    {
        public string CalculateDiscount(T product)
        {
            return product.Title;
        }
    }

    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable() { }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue()
        {
             return _value != null; 
        }

        public T GetValueOrDefault()
        {
            if (HasValue())
                return (T)_value;
            return default (T);
        }
    }
}
