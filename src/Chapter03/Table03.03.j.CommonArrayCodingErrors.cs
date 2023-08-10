﻿// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03;

public partial class CommonArayCodingErrors
{
    // 10.
    static public void MembersInJaggedArraysMustBeInstantiated()
    {
#if COMPILEERROR
        int[][] numbers = 
          { {42, 84}, {84, 42} };
#endif // COMPILEERROR
    }
}
