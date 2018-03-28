namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_14A
{
    using System;

    public class Program
    {
        // Returning a reference
        public static ref byte FindFirstRedEyePixel(byte[] image)
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
            byte[] image = new byte[254];
            // Load image
            int index = new Random().Next(0, image.Length - 1);
            image[index] =
                (byte)ConsoleColor.Red;
            System.Console.WriteLine(
                $"image[{index}]={(ConsoleColor)image[index]}");
            // ...

            // Obtain a reference to the first red pixel
            ref byte redPixel = ref FindFirstRedEyePixel(image);
            // Update it to be Black
            redPixel = (byte)ConsoleColor.Black;
            System.Console.WriteLine(
                $"image[{index}]={(ConsoleColor)image[redPixel]}");
        }
    }

}
