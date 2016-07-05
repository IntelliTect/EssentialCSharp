# Essential C# 6.0 Errata Document

## Essential C# 6.0
by Mark Michaelis <br>
ISBN 10: 0-13-414104-0 <br>
ISBN 13: 978-0-13-414104-6 <br>
Copyright © 2016 Pearson Education, Inc. 

First printing, September 2015

The following corrections will be made in the second printing. (To determine which printing you have, turn to page IV of your book. The last line on that page contains the printing information.)

Chapter     | Page         | Correction 
----------- | ------------ | ---------- 
1           | 16           | Listing 1.11: The second assignment of `miracleMax` was incorrectly made instead to an undeclared variable named `max`. The correct line of code is `miracleMax = "It would take a miracle.";` 
1           | 22           | Listing 1.18 is a modification of Listing 1.16, not 1.15.
3           | 116          | System.Math.E was referred to as Euler's constant, but this is in fact Euler's number.
6           | 294          | The sentence that reads “The C# compiler allows the cast operator even when the type hierarchy allows an implicit cast” should instead read “… allows an implicit **conversion**.” <br><br> The second example on the page should read “or even when no **conversion** is necessary.” 
8           | 357, 360-361 | Chapter 8 mentions that with C# 6, parameterless struct constructors are valid, but they actually aren't - this featured was dropped – see https://github.com/dotnet/roslyn/issues/1029 
10          | 438          | The section explaining conditional catch clauses is missing 6.0 tabs on the page border.
12          | 512          | Listing 12.7: The second loop should read `for(i = 0; i < items.Length; i++)` - `i` had been declared previously.
18          | 756-813      | These pages cover C# 5.0 topics, but are missing the “5.0” tabs in the page borders
Index       | 943          | String interpolation is split into two parts in the index. It should be under one entry as follows, with the redundant “String interpolation, formatting with” listing removed from the index: <br><br> Strings<br>     interpolation, 20, 50-53
Index (6.0) | 954          | String interpolation is omitted from the Index of 6.0 topics. It should be listed as above.
Index (5.0) | 956          | “Exceptions, catching” is listed twice.