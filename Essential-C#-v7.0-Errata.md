# Essential C# 7.0 Errata Document

## Essential C# 7.0
by Mark Michaelis
ISBN-13: 978-1-5093-0358-8
IISBN-10: 1-5093-0358-8
Copyright © 2018 Pearson Education, Inc.
First printing, May 2018

The following corrections will be made in the second printing. (To determine which printing you have, turn to page IV of your book. The last line on that page contains the printing information.)

Found by        |Chapter     | Page         | Correction
------------    |----------- | ------------ | ----------
Zhou Jing       |7           | 329          | Listing 7.13: The `Run()` method should be public, `private void Run()`.
Kyle Amonson    |13          | 550          | "In Listings 13.7 and 13.10" changed to "In Listings 13.7 and 13.11"
Kyle Amonson    |5           | 190          | Output 5.1 corrected Hello Inigo Montoya! Your initials are I. M.
Kyle Amonson    |5           | 200          | “and the optional second argument is…” corrected to “and the second argument is”.  The second argument is not optional in the code example.
Kyle Amonson    |6           | 251          | “what you learned in Chapter 4” corrected to “what you learned in Chapter 5”.  Introduced in Listing 5.06
Kyle Amonson    |7           | 327          | “Overloading a member” corrected to “Overriding a member”
Kyle Amonson    |9           | 390          | “DO overload” corrected to “DO override”
Kyle Amonson    |9           | 395          | “calls `MoveTo()` to change `Hours`” corrected: “calls `MoveTo()` to change `_Degrees`”
Kyle Amonson    |9           | 396          | “updates the `_Hours` value” corrected to “updates the `_Degrees` value”
Kevin Bost      |13          | 544          | `Predicate<int T>` should be `Predicate<in T>`
Cameron Osborn  |6           | 264 && 266   | Listing 6.18 && Listing 6.19 FirstName property gets and sets _LastName backing field
Cameron Osborn  |5           | 236          | Listing 5.26 typo on Console.WriteLine "FormateException" changed to "FormatException"
Rob Mantel      |6           | 294 && 299   | Replace reference to Copy() to CopyTo() and update Listing Name
Rob Mantel      |1           | 30           | Change Listing1.18 reference to Listing1.19
Rob Mantel      |1           | 16           | Changed 'HelloWorld.exe' to 'dotnet run'
Rob Mantel      |1           | 29           | Change class name from 'Comment Samples' to CommentSamples
Rob Mantel      |7           | 334          | Change 'therefore no overload' to 'therefore no override'
Brian Bos       |11          | 467          | 'ArgumentNullException' is listed twice
Brian Bos       |11          | 472          | 'ExeptionDispatchInfo.Throw' added missing c to Exception
Brian Bos       |11          | 473          | C does not support exception throwing as described. Removed claim