# Essential C# 12.0 Errata Document

## Essential C# 12.0

by Mark Michaelis
ISBN-13: 
IISBN-10: 
Copyright © 2023 Pearson Education, Inc.
First printing, November 2023

The following corrections will be made in the second printing. (To determine which printing you have, turn to page IV of your book. The last line on that page contains the printing information.)

Found by            | Chapter     | Page        | Correction
------------------- | ----------- | ----------- | -----------------------------------------------------------------------------------------------------------------------------------------------------------------
Benjamin Michaelis        | 4           | 180-181          | Replace `EventArgs` with `PropertyChangedEventArgs(nameof(Property))` in Leveraging the Null-Conditional Operator with Delegates
Zhou Jing | 3  | 110 | Replace `System.Value<T1>` with `System.ValueTuple<T1>` in "For completeness, the `System.ValueTuple<T1>` exists but will rarely be used, since the C# tuple syntax requires a minimum of two items."