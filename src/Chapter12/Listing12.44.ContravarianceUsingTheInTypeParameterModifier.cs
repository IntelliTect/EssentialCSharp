namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_44;

#region INCLUDE
class Fruit { }
class Apple : Fruit { }
class Orange : Fruit { }

#region HIGHLIGHT
interface ICompareThings<in T>
{
    bool FirstIsBetter(T t1, T t2);
}
#endregion HIGHLIGHT

public class Program
{

    private class FruitComparer : ICompareThings<Fruit>
    {
        #region EXCLUDE
        #region Generated Interface Stub
        public bool FirstIsBetter(Fruit t1, Fruit t2)
        {
            throw new System.NotImplementedException();
        }
        #endregion Generated Interface Stub
        #endregion EXCLUDE
    }
    static void Main()
    {
        ICompareThings<Fruit> fc = new FruitComparer();

        Apple apple1 = new();
        Apple apple2 = new();
        Orange orange = new();

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
#endregion INCLUDE
