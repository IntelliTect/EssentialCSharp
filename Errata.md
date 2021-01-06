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
Pieter Le Roux      | 1           | 31          | Last Line: Table 1.2 shows four different C# comment types. The program in <s>Listing 1.18</s> Listing 1.19 includes two of these.
Benjamin Michaelis  | 1           | 31          | Last Line: Table 1.2 shows four different C# comment types. The program in Listing 1.19 includes <s>two</s>three of these.
Pieter Le Roux      | 5           | 215         | Output 5.4: ERROR:  You must specify the URL <s>to be downloaded</s> and the file name **Usage:** Downloader.exe <URL> <TargetFileName> 
Pieter Le Roux      | 6           | 285         | Last Line in second paragraph: "DO use nameof for the paramName argument passed into exceptions like Argument<s>Null</s>Exception and ArgumentNullException that take such a parameter. For more information, see Chapter 18."
Pieter Le Roux      | 7           | 359         | return <s>@</s>$"FirstName: { FirstName + NewLine }" + $"LastName: { LastName + NewLine }"+ $"Address: { Address + NewLine }";
Benjamin Michaelis  | 7           | 359         | make the s in 'string bold' "set { string[] names = value.Split(' ');"
Pieter Le Roux      | 10          | 452         | Last paragraph: "so <s>overloading</s> overriding the method" "Consider <s>overloading</s>overriding the ToString() method "
Pieter Le Roux      | 10          | 458         | Output 10.2: "serialNumber1 reference equals serialNumber2 **serialNumber1 equals serialNumber2** serialNumber1 equals serialNumber3"
Pieter Le Roux      | 10          | 460         | Note: "The implementation of object.Equals(), the default implementation on all objects before <s>overloading</s>overriding, relies on ReferenceEquals() alone."
Pieter Le Roux      | 10          | 464         | "To correct this flaw, it is important to <s>overload</s>override the equals (==) and not equals (!=) operators as well
Pieter Le Roux      | 12          | 542         | "you can see that the type parameter will be used for the <s>internal Items</s>InternalItems array, the type for the parameter to the"
Pieter Le Roux      | 12          | 547         | "constructor that takes the initial values for both <s>First and Second</s>first and second and assigns them to First and Second."
Pieter Le Roux      | 12          | 551         | "// Use System.ValueTup**l**e<string,Contact> prior to C# 7.0 "
Pieter Le Roux      | 12          | 579         | "Consider the **I**PairInitializer<in T> interface in Listing 12.45." 
