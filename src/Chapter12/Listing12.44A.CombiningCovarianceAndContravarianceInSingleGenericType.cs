namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_44A
{
    class Food { }

    class Pizza : Food { }

    class Salad : Food { }

    class Document { }

    class ComputerProgram : Document { }

    interface ITransformer<in TSource, out TTarget>
    {
        TTarget Transform(TSource source);
    }

    // A computer programmer is a device which transforms
    // food into computer programs:
    class Programmer : ITransformer<Food, ComputerProgram>
    {
        public ComputerProgram Transform(Food f)
        {
            // ...
            return new ComputerProgram();
        }
    }

    class Program
    {
        static void Main()
        {
            var programmer = new Programmer();
            ComputerProgram cp = programmer.Transform(new Salad());

            // A computer programmer may be converted with
            // both co- and contra-variant conversions. Because
            // a programmer can turn any food into a computer 
            // program, it can be used as a device that turns pizza
            // into documents
            ITransformer<Pizza, Document> transformer = programmer;
            Document d = transformer.Transform(new Pizza());
        }
    }
}