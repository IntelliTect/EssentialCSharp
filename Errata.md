# Essential C# 12.0 Errata Document

## Essential C# 12.0

by Mark Michaelis
ISBN-13: 978-0138219512
IISBN-10: 0138219516
Copyright © 2023 Pearson Education, Inc.
First printing, November 2023

The following corrections will be made in the second printing. (To determine which printing you have, turn to page IV of your book. The last line on that page contains the printing information.)

Found by            | Chapter     | Page        | Correction
------------------- | ----------- | ----------- | -----------------------------------------------------------------------------------------------------------------------------------------------------------------
Benjamin Michaelis        | 4           | 180-181          | Replace `EventArgs` with `PropertyChangedEventArgs(nameof(Property))` in Leveraging the Null-Conditional Operator with Delegates
Zhou Jing | 3  | 110 | Replace `System.Value<T1>` with `System.ValueTuple<T1>` in "For completeness, the `System.ValueTuple<T1>` exists but will rarely be used, since the C# tuple syntax requires a minimum of two items."
Zhou Jing | 3  | 102 | Change Listing 2.18 to " the Working with Strings listing in Chapter 2 (Listing 2.24)" in "This listing differs from Listing 2.18 in two ways"
Zhou Jing | 3 | 102 | Changed 'restrictive' to 'less restrictive' in "In each of these cases, the variable declaration is restrictive because the variable may be assigned."
Zhou Jing | 23 | 1077 | Change "Point Declaration" to "Pointer Declaration" in mindmap
Zhou Jing | 22 | 1074 | Change "Chapter 19" to "Chapter 20" in "we pointed out in Chapter 19"
Zhou Jing | 9 | 541 | Change output 9.4 to "ReadOnly, Hidden = 3"
Zhou Jing | 22 | 1063 | Change sentence about the WaitOne() overloads to be "The WaitOne() methods include several overloads: void WaitOne() for an indefinite wait, bool WaitOne(int milliseconds) for a wait timed in milliseconds, and bool WaitOne(TimeSpan timeout) for a TimeSpan duration wait."
Zhou Jing | 22 | 1058 | Changed code snippet from `OnTemperature?.Invoke` to `OnTemperatureChanged?.Invoke`
Zhou Jing | 22 | 1056 | Changed sentence in last paragraph before Listing 22.6 to "method provides a built-in method for a synchronous operation that updates the first parameter if the value(_Data) is equal to the third parameter with the second parameter."
Zhou Jing | 21 | 1028 | Change "Press any key to exit." to "Press ENTER to exit."
Zhou Jing | 20 | 1018 | Change "EncryptFilesAsunc" to "EncryptFilesAsync"
Zhou Jing | 20 | 1019 | Change "IAsycnEnumerable" to "IAsyncEnumerable"
Zhou Jing & Benjamin Michaelis | 18 | 918 | Change "For example, in LISTING 18.28 the expression () => throw new DivideByZeroException() is for the testAction parameter." from "For example, in LISTING 18.27 the expression () => throw new Exception() is for the value of testAction."
Zhou Jing | 19 | 946 | Change "The worker thread writes plus signs to the console, while the main thread writes hyphens." to "The worker thread writes hyphens to the console, while the main thread writes plus signs."
Zhou Jing | 19 | 964 | Change "3:0052:Unhandled exception handler starting." to "Event handler starting"
Zhou Jing | 21 | 1022 | Change "3.14159265358979323846264338327950288419716939937510582097494459230781640628620899862803482534211706798214808651328230664709384460955058223172535940812848111745028410270193852110555964462294895493038196442881097566593344612847564823378678316527120190914564856692346034861045432664821339360726024914127372458700660631558817488152092096282925409171536436789259036001133053054882046652138414695194151160943305727036575959195309218611738193261179310511854807446237996274956735188575272489122793818301194912" to "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679" in output 21.1
Zhou Jing | 20 | 1018 | Change paragraph beginning with "The need to support TAP from the UI is one of the key scenarios that led to TAP’s creation." to "Supporting TAP from the UI is a fundamental scenario that led to the development of TAP. Another common scenario occurs on the server side when a client’s request involves retrieving a large dataset from a database. Given that database queries can be time-consuming, it’s crucial to hangle them efficiently. Instead of creating new threads or using threads from the limited thread pool, it’s advisable to utilize asynchronous programming patterns. These patterns avoid blocking threads while waiting for the database response, especially since the actual query operations are executed on a separate machine (the database server). This approach ensures that server resources are used optimally, allowing threads to manage other tasks rather than being idle during I/O operations."
Zhou Jing | 18 | 911 | Change CommandLineRequiredAttribute to CommandLineSwitchRequiredAttribute
Zhou Jing | 18 | 902-903 | Change CommandLineAliasAttribute to CommandLineSwitchAliasAttribute
Zhou Jing | 23 | 1105 | Change `Length = 10` in listing 23.20 to `Length = 12` to show entire output message
Zhou Jing | 18 | 926-927 | Change 'LastName' references to be 'FirstName' in paragraphs
Jinhang He | 5 | 255 | Edit listing 5.20 to used `image[index]` for the second print statement
Zhou Jing | 18 | 908 | Change comment in Listing 18.21 to "Restrict the attribute to properties and fields" from "Restrict the attribute to properties and methods"
Zhou Jing | 23 | 1080 | Change "DWORD flProtect); // The type of memory allocation" to "// The type of memory protection"
Zhou Jing | 22 | 1065 - 1066 | Changed 'Thread' to 'Task' and "Application exiting" to "Application shutting down"
Zhou Jing | 4 | 161 | Fix `input < 9` to `input < 0` in Listing 4.24
Zhou Jing    | 4 | 119 | Show inconsistent size multi-dimensional array in listing 3.16
Zhou Jing | 3  | 114 | Replace `second` with `third` in "// Retrieve third item from the end (Python)"
Tyler Woody | 13 | 702 | Remove the `!` negation in `string.IsNullOrWhiteSpace(input)` in the while loop to properly allow looping
Benjamin Michaelis | 19 | 948-949 | Add a `(` before the `next + 1` to complete the parenthesis.
