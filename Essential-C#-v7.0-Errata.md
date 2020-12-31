# Essential C# 7.0 Errata Document

## Essential C# 7.0
by Mark Michaelis
ISBN-13: 978-1-5093-0358-8
IISBN-10: 1-5093-0358-8
Copyright © 2018 Pearson Education, Inc.
First printing, May 2018

The following corrections will be made in the second printing. (To determine which printing you have, turn to page IV of your book. The last line on that page contains the printing information.)

Found by       | Chapter | Page       | Correction                                                                                                                                                        |
-------------- | ------- | ---------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------- |
Rob Mantel     | 1       | 16         | Changed 'HelloWorld.exe' to 'dotnet run'                                                                                                                          |
Rob Mantel     | 1       | 29         | Change class name from 'Comment Samples' to CommentSamples
Pieter Le Roux | 1       | 29         | Last Line: Table 1.2 shows four different C# comment types. The program in <s>Listing 1.18</s> Listing 1.19 includes two of these.
Rob Mantel     | 1       | 30         | Change Listing1.18 reference to Listing1.19                                                                                           
Pieter Le Roux | 1       | 38         | Change "(lowercase) to refers to" -> "(lowercase) refers to" 
Pieter Le Roux | 1       | 39         | Change "C# 5.0 compiler" -> "C# 6.0 compiler" 
Zhou Jing      | 2       | 75         | "The result is that the number variable is available from both the true and false consequence of the if statement ~~but not~~ and even outside the if statement.. |
Pieter Le Roux | 3       | 93         | Change "Listing 3.6" -> "Listing 3.7" 
Pieter Le Roux | 4       | 111        | Change "The subtraction example" -> "The division and remainder examples" 
Pieter Le Roux | 4       | 116        | Change "16 bits of a float" -> "32 bits of a float"
Pieter Le Roux | 4       | 122        | Change "In this example, notice that the increment operator" -> "In this example, notice that the decrement operator" 
Pieter Le Roux | 4       | 132        | Change operator in first else if in 4.22: `else if(input<9)` -> `else if(input>9)` 
Pieter Le Roux | 4       | 140        | Change "logical operators are of higher precedence than the relational" -> "relation operators are of higher precedence than the logical" 
Kyle Amonson   | 5       | 190        | Output 5.1 corrected Hello Inigo Montoya! Your initials are I. M.
Kyle Amonson   | 5       | 200        | “and the optional second argument is…” corrected to “and the second argument is”.  The second argument is not optional in the code example.
Pieter Le Roux | 5       | 201        | Output 5.4: ERROR:  You must specify the URL <s>to be downloaded</s> and the file name **Usage:** Downloader.exe <URL> <TargetFileName> 
Cameron Osborn | 5       | 236        | Listing 5.26 typo on Console.WriteLine "FormateException" changed to "FormatException"                                                                            |
Kyle Amonson   | 6       | 251        | “what you learned in Chapter 4” corrected to “what you learned in Chapter 5”.  Introduced in Listing 5.06                                                         |
Cameron Osborn | 6       | 264 && 266 | Listing 6.18 && Listing 6.19 FirstName property gets and sets _LastName backing field
Pieter Le Roux | 6       | 271        | Last Line in second paragraph: "DO use nameof for the paramName argument passed into exceptions like Argument<s>Null</s>Exception and ArgumentNullException that take such a parameter. For more information, see Chapter 18."
Pieter Le Roux | 6       | 290        | Change "When another Employee class is created" -> "When another instance of the Employee class is created"                                                   
Rob Mantel     | 6       | 294 && 299 | Replace reference to Copy() to CopyTo() and update Listing Name                                                                                                 
Kyle Amonson   | 7       | 327        | “Overloading a member” corrected to “Overriding a member”   
Zhou Jing      | 7       | 329        | Listing 7.13: The `Run()` method should be public, `private void Run()`.                                                                                         
Rob Mantel     | 7       | 334        | Change 'therefore no overload' to 'therefore no override'   
Pieter Le Roux | 7       | 340        | return <s>@</s>$"FirstName: { FirstName + NewLine }" + $"LastName: { LastName + NewLine }"+ $"Address: { Address + NewLine }";
Kyle Amonson   | 9       | 390        | “DO overload” corrected to “DO override”
Kyle Amonson   | 9       | 396        | “updates the `_Hours` value” corrected to “updates the `_Degrees` value”
Kyle Amonson   | 9       | 395        | “calls `MoveTo()` to change `Hours`” corrected: “calls `MoveTo()` to change `_Degrees`”
Pieter Le Roux | 10      | 412        | Last paragraph: "so <s>overloading</s> overriding the method" "Consider <s>overloading</s>overriding the ToString() method "
Pieter Le Roux | 10      | 446        | Change xml comment attribute in 10.17: `<data>January 1, 2000</date>` -> `<date>January 1, 2000</date>`
Pieter Le Roux | 10      | 418        | Output 10.2: "serialNumber1 reference equals serialNumber2 **serialNumber1 equals serialNumber2** serialNumber1 equals serialNumber3"
Pieter Le Roux | 10      | 420        | Note: "The implementation of object.Equals(), the default implementation on all objects before <s>overloading</s>overriding, relies on ReferenceEquals() alone."
Pieter Le Roux | 10      | 425        | Second sentence: "To correct this flaw, it is important to <s>overload</s>override the equals (==) and not equals (!=) operators as well
Pieter Le Roux | 11      | 466        | Listing 11.1: // Leveraging C# 2.0's <s>null coelesce operator</s>null-coalescing operator
Pieter Le Roux | 11      | 467        | Last Sentence, first paragraph: <s>null propagation operator</s>null-conditional operator
Brian Bos      | 11      | 467        | 'ArgumentNullException' is listed twice 
Brian Bos      | 11      | 472        | 'ExeptionDispatchInfo.Throw' added missing c to Exception
Brian Bos      | 11      | 473        | C does not support exception throwing as described. Removed claim
Kevin Bost     | 13      | 544        | `Predicate<int T>` should be `Predicate<in T>`
Kyle Amonson   | 13      | 550        | "In Listings 13.7 and 13.10" changed to "In Listings 13.7 and 13.11"
