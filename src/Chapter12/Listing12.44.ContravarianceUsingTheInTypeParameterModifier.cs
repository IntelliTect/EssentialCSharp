namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_44
{
    class Fruit { }

    class Apple : Fruit { }

    class Orange : Fruit { }


    interface ICompareThings<in T>
    {
        bool FirstIsBetter(T t1, T t2);
    }

    class Program
    {

        class FruitComparer : ICompareThings<Fruit>
        {
            // ...
            #region Generated Interface Stub
            public bool FirstIsBetter(Fruit t1, Fruit t2)
            {
                throw new System.NotImplementedException();
            }
            #endregion Generated Interface Stub
        }
        static void Main()
        {
            // Allowed in C# 4.0
            ICompareThings<Fruit> fc = new FruitComparer();

            Apple apple1 = new Apple();

            Apple apple2 = new Apple();
            Orange orange = new Orange();

            // A fruit comparer can compare apples and oranges:

            bool b1 = fc.FirstIsBetter(apple1, orange);
            // or apples and apples:

            bool b2 = fc.FirstIsBetter(apple1, apple2);
            // This is legal because the interface is 
            // contravariant.
            ICompareThings<Apple> ac = fc;
            // This is really a fruit comparer, so it can 
            // still compare two apples 

            bool b3 = ac.FirstIsBetter(apple1, apple2);
        }
    }
}