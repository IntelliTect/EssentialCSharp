using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dnp;

namespace ProjectRename
{
    class CommandLineInfo
    {
        [CommandLineOptionAttribute("Root", "The root project from which all chapter source code derives.")]
        public string Root { get; set; }

        [CommandLineOptionAttribute("ChapterNumber", "The number of the chapter")]
        public string ChapterNumber { get; set; }
        [CommandLineOptionAttribute("FromListing", "The listing(s) covered by the project")]
        public string FromListing { get; set; }
        [CommandLineOptionAttribute("ToListing", "The listing(s) to be covered by the target project")]
        public string ToListing { get; set; }
        [CommandLineOptionAttribute("Rename", "Whether the action is just a rename (rather than a copy and rename)")]
        public bool Rename { get; set; }
    }
}
