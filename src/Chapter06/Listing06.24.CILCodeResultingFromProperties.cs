namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_24
{
// ...

.field private string _FirstName
.method public hidebysig specialname instance string
        get_FirstName() cil managed
    {
  // Code size       12 (0xc)
  .maxstack  1
  .locals init (string V_0)
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      string Employee::_FirstName
  IL_0007:  stloc.0
  IL_0008:  br.s IL_000a

  IL_000a:  ldloc.0
  IL_000b:  ret
    } // End of method Employee::get_FirstName

.method public hidebysig specialname instance void
        set_FirstName(string 'value') cil managed
    {
  // Code size       9 (0x9)
  .maxstack  8
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldarg.1
  IL_0003:  stfld      string Employee::_FirstName
  IL_0008:  ret
    } // End of method Employee::set_FirstName

.property instance string FirstName()
    {
  .get instance string Employee::get_FirstName()
  .set instance void Employee::set_FirstName(string)
} // End of property Employee::FirstName

    // ...

}
