using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SystemEx.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using SearchOption = System.IO.SearchOption;

namespace ProjectRename
{
    public class Program
    {
        public const string HelpText =
            "ProjectRename.exe <FromChapterNumber> <ToChapterNumber> <FromListing> <ToListing> [/rename|/copy] [RootDirectory]";
        public static int Main(params string[] args)
        {
            DirectoryInfo rootDirectory;
            Console.WriteLine(HelpText);
            try
            {
                ValidateNumberOfParameters(args);

                string root = null;
                root = Path.Combine(
                    Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), 
                    @"..\..\..\..\..\ChapterListings\");

                if (args.Length == 6)
                {
                    root = args[5];
                }
                rootDirectory = new DirectoryInfo(root);

                if (!rootDirectory.Exists)
                {
                    throw new ArgumentException(
                        string.Format("The chapter folder, \"{0}\", could not be found.", 
                            rootDirectory.FullName));
                }

                string fromChapter = args[0].TrimStart('0');
                string toChapter = args[1].TrimStart('0');
                string fromListing = args[2];
                ValidateFromListing(fromListing);

                string toListing = args[3];
                bool rename = false;
                if (args.Length >= 5)
                {
                    rename = (args[4].ToLower() == "/rename");
                }

                string fromChapterFolder = "Chapter" + fromChapter.PadLeft(2, '0');
                string toChapterFolder = "Chapter" + toChapter.PadLeft(2, '0');
                string fromProjectName = string.Format("Listing{0}_{1}", fromChapter, fromListing);
                string toProjectName = string.Format("Listing{0}_{1}", toChapter, toListing);



                DirectoryInfo toProjectDirectory;


                // Check to make sure the source directory is available
                if (!Directory.Exists(Path.Combine(rootDirectory.FullName, fromChapterFolder)))
                {
                    throw new ArgumentException(
                        string.Format("The chapter folder, \"{0}\", could not be found.", PathEx.Combine(rootDirectory.FullName, fromChapterFolder, toProjectName)));
                }

                if (rename)
                {
                    FileSystem.RenameDirectory(PathEx.Combine(rootDirectory.FullName, fromChapterFolder, fromProjectName),
                        PathEx.Combine(rootDirectory.FullName, toChapterFolder, toProjectName));
                    toProjectDirectory =
                        new DirectoryInfo(PathEx.Combine(rootDirectory.FullName, toChapterFolder, toProjectName));
                }
                else
                {
                    toProjectDirectory = new DirectoryInfo(PathEx.Combine(rootDirectory.FullName, fromChapterFolder, fromProjectName)).Copy(
                        PathEx.Combine(rootDirectory.FullName, toChapterFolder, toProjectName));
                }

                //System.Diagnostics.Debugger.Break();
                foreach (FileInfo file in toProjectDirectory.GetFiles("*.cs*", SearchOption.AllDirectories))
                {   // Get ready to rename the files to match the new project hierarchy
                    string targetName = file.FullName.Replace(fromProjectName, toProjectName).Replace(fromChapterFolder, toChapterFolder);
//                    targetName =  targetName.Replace();
                    Console.WriteLine("{0}\t=>\t{1}", file.FullName, targetName);
                    file.IsReadOnly = false;
                    if (file.FullName != targetName)
                    {   // Rename the file
                        file.MoveTo(targetName);
                    }

                    ReplaceInFile(file, fromProjectName, toProjectName);
                    ReplaceInFile(file, fromProjectName.Replace("-", "To"), toProjectName.Replace("-", "To"));
                    ReplaceInFile(file, fromChapterFolder, toChapterFolder);
                    //ReplaceInFile(file, fromListing, toListing);
                }

            }
            catch (Exception exception)
            {
                Console.Error.WriteLine("ERROR:" + exception.Message);
                Console.WriteLine(exception.ToString());
                return -1;
            }
            return 0;
        }

        private static void ValidateFromListing(string fromListing)
        {
            if (fromListing.Contains("_"))
            {
                throw new ApplicationException(
                    string.Format("The fromListing ({0}) should only be the listing numbers, not also the chapter numbers.", fromListing));

            }
        }

        private static void ValidateNumberOfParameters(string[] args)
        {
            if (args.Length < 4)
            {
                throw new ApplicationException("The command line parameters were invalid.");
            }
        }

        /// <summary>
        /// Replaces text in a file.
        /// </summary>
        /// <param name="filePath">Path of the text file.</param>
        /// <param name="searchText">Text to search for.</param>
        /// <param name="replaceText">Text to replace the search text.</param>
        static public void ReplaceInFile(FileInfo file, string from, string to)
        {
            if (from != to)
            {
                string content;

                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    content = reader.ReadToEnd();
                }

                content = content.Replace(from, to);

                using (StreamWriter writer = new StreamWriter(file.FullName))
                {
                    writer.Write(content);
                }
            }
        }
    }
}
