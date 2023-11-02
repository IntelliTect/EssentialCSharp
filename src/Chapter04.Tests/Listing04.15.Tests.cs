
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = 
            @"z=122	y=121	x=120	w=119	v=118	u=117	t=116	s=115	r=114	q=113	p=112	o=111	n=110	m=109	l=108	k=107	j=106	i=105	h=104	g=103	f=102	e=101	d=100	c=99	b=98	a=97	";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}