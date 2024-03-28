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