namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_22
{
#region INCLUDE
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:2:0:1
}


.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:1:0:1
}


.assembly 'HelloWorld'
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = (01 00 08 00 00 00 00 00 )
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = (01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78 63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )
  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = (01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56 65 72 73 69 6F 6E 3D 76 33 2E 30 01 00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79 4E 61 6D 65 00 )
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = (01 00 0A 48 65 6C 6C 6F 57 6F 72 6C 64 00 00 )
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = (01 00 05 44 65 62 75 67 00 00 )
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = (01 00 07 31 2E 30 2E 30 2E 30 00 00 )
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = (01 00 05 31 2E 30 2E 30 00 00 )
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = (01 00 0A 48 65 6C 6C 6F 57 6F 72 6C 64 00 00 )
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = (01 00 0A 48 65 6C 6C 6F 57 6F 72 6C 64 00 00 )
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}


.module 'HelloWorld.dll'
// MVID: {05b2d1a7-c150-4f20-bd96-c065e4f97a31}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003  // WindowsCui
.corflags 0x00000001  // ILOnly


.class private auto ansi beforefieldinit HelloWorld.Program extends[System.Runtime] System.Object
{


  .method private hidebysig static void Main(string[] args) cil managed
        {
    .entrypoint
    // Code size 13
    .maxstack 8
    IL_0000: nop
    IL_0001: ldstr "Hello. My name is Inigo Montoya."
    IL_0006: call void
↪ System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ret
    } // End of method System.Void
      // HelloWorld.Program::Main(System.String[])


  .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
    {
    // Code size 8
    .maxstack 8
    IL_0000: ldarg.0
    IL_0001: call instance void [System.Runtime]
        System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret
    } // End of method System.Void HelloWorld.Program::.ctor()
} // End of class HelloWorld.Program
#endregion INCLUDE
}
