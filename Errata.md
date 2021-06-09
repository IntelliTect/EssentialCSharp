# Essential C# 8.0 Errata Document

## Essential C# 8.0
by Mark Michaelis
ISBN-13: 978-0-13-597226-7
IISBN-10: 0-13-597226-4
Copyright © 2021 Pearson Education, Inc.
First printing, October 2020

The following corrections will be made in the second printing. (To determine which printing you have, turn to page IV of your book. The last line on that page contains the printing information.)

Found by            | Chapter     | Page        | Correction                                                                                                                                                       
------------------- | ----------- | ----------- | -----------------------------------------------------------------------------------------------------------------------------------------------------------------
Salim Gangji        | 1           | 12          | First paragraph: For a single executable, append <s>`/p:PublishSingleFile=true`</s> `-p:PublishSingleFile=true` to the command
Pieter Le Roux      | 1           | 31          | Last Line: Table 1.2 shows four different C# comment types. The program in <s>Listing 1.18</s> Listing 1.19 includes two of these.
Benjamin Michaelis  | 1           | 31          | Last Line: Table 1.2 shows four different C# comment types. The program in Listing 1.19 includes <s>two</s>three of these.
Salim Gangji        | 2           | 51          | Output 2.3: <s>1.61803398874985</s> 1.618033988749895
Alden Bansemer      | 2           | 55          | Listing 2.9: <s>`result == number`</s> `{result} == {number}`. Output 2.7: <s>`result == number`</s> `1.61803398874989 == 1.61803398874989`.
Alden Bansemer      | 3           | 89          | Listing 3.4: Changed <s>`class 3.2->3.Uppercase`</s> to match source `class Uppercase`.
Alden Bansemer      | 3           | 113         | Output 3.2: `TypeScript` replaced with `Visual Basic` as last element in sorted array and first element in the reversed, sorted array.
Alden Bansemer      | 3           | 114         | Output 3.3: Added missing second line of output: `3`.
Alden Bansemer      | 4           | 129         | Listing 4.7: Removed Trace.Assert to match codebase. Removed example #4, float converted to double now matches the double.
Alden Bansemer      | 4           | 130         | Output 4.6: Updated results of Listing 4.7 to remove <s>`4.20000006258488 != 4.20000028610229`</s>.
Pieter Le Roux      | 5           | 215         | Output 5.4: ERROR:  You must specify the URL <s>to be downloaded</s> and the file name **Usage:** Downloader.exe <URL> <TargetFileName> 
Pieter Le Roux      | 6           | 285         | Last Line in second paragraph: "DO use nameof for the paramName argument passed into exceptions like Argument<s>Null</s>Exception and ArgumentNullException that take such a parameter. For more information, see Chapter 18."
Pieter Le Roux      | 7           | 359         | return <s>@</s>$"FirstName: { FirstName + NewLine }" + $"LastName: { LastName + NewLine }"+ $"Address: { Address + NewLine }";
Benjamin Michaelis  | 7           | 359         | make the s in 'string bold' "set { string[] names = value.Split(' ');"
Pieter Le Roux      | 10          | 452         | Last paragraph: "so <s>overloading</s> overriding the method" "Consider <s>overloading</s>overriding the ToString() method "
Pieter Le Roux      | 10          | 458         | Output 10.2: "serialNumber1 reference equals serialNumber2 **serialNumber1 equals serialNumber2** serialNumber1 equals serialNumber3"
Pieter Le Roux      | 10          | 460         | Note: "The implementation of object.Equals(), the default implementation on all objects before <s>overloading</s>overriding, relies on ReferenceEquals() alone."
Pieter Le Roux      | 10          | 464         | "To correct this flaw, it is important to <s>overload</s>override the equals (==) and not equals (!=) operators as well
Pieter Le Roux      | 12          | 581         | Listing 12.47: .class <s>private</s>public auto ansi beforefieldinit Stack'1<([<s>mscorlib</s>System.Runtime]System.IComparable)** **T> extends [<s>mscorlib</s>System.Runtime]System.Object { ... } 
Benjamin Michaelis  | 12          | 582         | Listing 12.48: .class public auto ansi beforefieldinit <s>'</s>Stack'1<s>'</s><([<s>mscorlib</s>System.Runtime]System.IComparable) T> extends [<s>mscorlib</s>System.Runtime]System.Object { .field private !<s>0</s>**T**[ ] _Items ... }
Pieter Le Roux      | 12          | 542         | "you can see that the type parameter will be used for the <s>internal Items</s>InternalItems array, the type for the parameter to the"
Pieter Le Roux      | 12          | 547         | "constructor that takes the initial values for both <s>First and Second</s>first and second and assigns them to First and Second."
Pieter Le Roux      | 12          | 551         | "// Use System.ValueTup**l**e<string,Contact> prior to C# 7.0 "
Pieter Le Roux      | 12          | 579         | "Consider the **I**PairInitializer<in T> interface in Listing 12.45." 
Pieter Le Roux      | 13          | 602         | "the compiler can <s>see</s>infer that the lambda"
Pieter Le Roux      | 14          | 639         | Output 14.2: "<s>Enter temperature: 45 Heater: On Error in the application Cooler: Off</s> Enter temperature: 45 Heater: On Cooler: Off There were exceptions thrown by OnTemperatureChange Event subscribers. (Operation is not valid due to the current state of the object.)"
Pieter Le Roux      | 15          | 686         | tabs in Output 15.9 doesn't reflect Listing 15.21. Fixed by updating source code
Pieter Le Roux      | 15          | 700         | // ERROR: Cannot implicitly convert type // 'AnonymousType<s>#3</s>#1' to 'AnonymousType<s>#2</s>#3'
Pieter Le Roux      | 16          | 706         | Reorder keywords to alphabetical order in Listing 16.1, and add missing keywords
Pieter Le Roux      | 16          | 707         | "private static void Show<s>Contextual</s>Keywords1()"
Pieter Le Roux      | 16          | 712         | Output 16.3 is missing "when"
Pieter Le Roux      | 16          | 715         | "File.GetLastWriteTime(file**Name**)"
Pieter Le Roux      | 16          | 719         | Add "when" to Output 16.6 ("when*" was missing from source code)
Pieter Le Roux      | 16          | 721         | Add "when" to Output 16.7 ("when*" was missing from source code)
Pieter Le Roux      | 16          | 725         | in Listing 16.16 and Listing 16.17, add "!" prior to "word. Contains('*')" to match Listing 16.01
Pieter Le Roux      | 17          | 733         | Saw List[6] could throw error. Changed to "{ List[<s>6</s>^1] }
Pieter Le Roux      | 17          | 760         | "as you did in both CSharp<s>PrimitiveTypes</s>BuiltInTypes"
Pieter Le Roux      | 18          | 776         | errorMessage listed twice in listing 18.3
Pieter Le Roux      | 18          | 807         | "let's reexamine Listing <s>18.28</s>18.27. Notice the call to retrieve the "FirstName" element:"
Pieter Le Roux      | 19          | 824         | "The worker thread will write <s>periods</s>plus signs to the console
Pieter Le Roux      | 19          | 825         | lambda expression prints out <s>dashes</s>hyphens to the console repeatedly.
Pieter Le Roux      | 19          | 840         | "<s>(c)</s>(3)"