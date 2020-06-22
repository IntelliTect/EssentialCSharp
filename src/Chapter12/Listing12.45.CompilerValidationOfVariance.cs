// IMPORTANT NOTE: This file is not compiled.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_45
{
    // // ERROR:  Invalid variance: the type parameter 'T' is not
    // //         invariantly valid
    interface IPairInitializer<in T>
    {
        void Initialize(IPair<T> pair);
    }

    // Suppose the code above were legal, and see what goes
    //  wrong:

    // ...

    class FruitPairInitializer : IPairInitializer<Fruit>
    {
        // Let’s initialize  our pair of fruits  with an 
        // apple and an orange:

        public void Initialize(IPair<Fruit> pair)
        {
            pair.First = new Orange();
            pair.Second = new Apple();
        }
    }

    // ... later ...

    public class Program
    {
        public static void Main()
        {
            var f = new FruitPairInitializer();

            // This would be legal if contravariance were legal:
            IPairInitializer<Apple> a = f;

            // And now we write an orange into a pair of apples:
            a.Initialize(new Pair<Apple>());
        }
    }
}