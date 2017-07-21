
using AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_42;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_44;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_46;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_46
{
    // // ERROR:  Invalid variance: the type parameter 'T' is not
    // //         invariantly valid
    // interface IPairInitializer<in T>
    // {
    //     void Initialize(IPair<T> pair);
    // }

    // // Suppose the code above were legal, and see what goes
    // //  wrong:

    // // ...

    // class FruitPairInitializer : IPairInitializer<Fruit>
    // {
    //     // Let’s initiaize our pair of fruit with an 
    //     // apple and an orange:

    //     public void Initialize(IPair<Fruit> pair)
    //     {
    //          pair.First = new Orange();
    //          pair.Second = new Apple();
    //     }
    // }

    // ... later ...

    // public class Program
    // {
    //     public static void Main()
    //     {
    //         var f = new FruitPairInitializer();

    //         // This would be legal if contravariance were legal:
    //         IPairInitializer<Apple> a = f;

    //         // And now we write an orange into a pair of apples:
    //         a.Initialize(new Pair<Apple>());
    //     }
    // }
}