namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_16
{
    using System.IO;

    public static class LineCounter
    {
        public static void Main(string[] args)
        {
            int totalLineCount;

            if(args.Length > 1)
            {
                totalLineCount =
                    DirectoryCountLines(args[0], args[1]);
            }
            else if(args.Length > 0)
            {
                totalLineCount = DirectoryCountLines(args[0]);
            }
            else
            {
                totalLineCount = DirectoryCountLines();
            }

            System.Console.WriteLine(totalLineCount);
        }

        static int DirectoryCountLines()
        {
            return DirectoryCountLines(
                Directory.GetCurrentDirectory());
        }

        static int DirectoryCountLines(string directory)
        {
            return DirectoryCountLines(directory, "*.cs");
        }

        static int DirectoryCountLines(
            string directory, string extension)
        {
            int lineCount = 0;
            foreach(string file in
                Directory.GetFiles(directory, extension))
            {
                lineCount += CountLines(file);
            }

            foreach(string subdirectory in
                Directory.GetDirectories(directory))
            {
                lineCount += DirectoryCountLines(subdirectory);
            }

            return lineCount;
        }

        private static int CountLines(string file)
        {
            int lineCount = 0;
            string line;
            FileStream stream =
                new FileStream(file, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            line = reader.ReadLine();
            while(line != null)
            {
                if(line.Trim() != "")
                {
                    lineCount++;
                }
                line = reader.ReadLine();
            }

            reader.Dispose();  // Automatically closes the stream
            return lineCount;
        }
    }
}