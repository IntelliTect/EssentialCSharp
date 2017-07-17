namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_02
{
    class Program
    {
        static void ChapterMain()
        {
            var patent1 =
                new
                {
                    Title = "Bifocals",
                    YearOfPublication = "1784"
                };

            var patent2 =
                new
                {
                    YearOfPublication = "1877",
                    Title = "Phonograph"
                };

            var patent3 =
                new
                {
                    patent1.Title,
                    Year = patent1.YearOfPublication
                };

            // ERROR: Cannot implicitly convert type 
            //        'AnonymousType#1' to 'AnonymousType#2'
            //patent1 = patent2; //won't compile if uncommented
            // ERROR: Cannot implicitly convert type 
            //        'AnonymousType#3' to 'AnonymousType#2'
            //patent1 = patent3; //won't compile if uncommented

            // ERROR: Property or indexer 'AnonymousType#1.Title' 
            //        cannot be assigned to -- it is read-only'
            //patent1.Title = "Swiss Cheese"; //won't compile if uncommented
        }
    }
}
