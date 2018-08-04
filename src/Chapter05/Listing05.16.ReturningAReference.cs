namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_16
{
    using System;

    public class Program
    {
        // Returning a reference
        static public ref byte FindFirstRedEyePixel(byte[] image)
        {
            // Do fancy image detection perhaps with machine learning
            for (int counter = 0; counter < image.Length; counter++)
            {
                if (image[counter] == (byte)ConsoleColor.Red)
                {
                    return ref image[counter];
                }
            }
            throw new InvalidOperationException("No pixels are red.");
        }
        public static void Main()
        {
            byte[] image = null;
            // Load image
            image = new byte[42];
            for (int i = 0; i < image.Length; i++)
            {
                image[i] = (byte)ConsoleColor.Black;
            }
            image[(new Random()).Next(0, image.Length - 1)] = (byte)ConsoleColor.Red;

            // Obtain a reference to the first red pixel
            ref byte redPixel = ref FindFirstRedEyePixel(image);
            // Update it to be Black
            redPixel = (byte)ConsoleColor.Black;
            System.Console.WriteLine((ConsoleColor)image[redPixel]);
        }
    }
}
