using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_24.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SelectManyTests()
        {
            string expected =
@"Fabien Barthez
Gregory Coupet
Mickael Landreau
Eric Abidal
Jean-Alain Boumsong
Pascal Chimbonda
William Gallas
Gael Givet
Willy Sagnol
Mikael Silvestre
Lilian Thuram
Vikash Dhorasoo
Alou Diarra
Claude Makelele
Florent Malouda
Patrick Vieira
Zinedine Zidane
Djibril Cisse
Thierry Henry
Franck Ribery
Louis Saha
David Trezeguet
Sylvain Wiltord
Gianluigi Buffon
Angelo Peruzzi
Marco Amelia
Cristian Zaccardo
Alessandro Nesta
Gianluca Zambrotta
Fabio Cannavaro
Marco Materazzi
Fabio Grosso
Massimo Oddo
Andrea Barzagli
Andrea Pirlo
Gennaro Gattuso
Daniele De Rossi
Mauro Camoranesi
Simone Perrotta
Simone Barone
Luca Toni
Alessandro Del Piero
Francesco Totti
Alberto Gilardino
Filippo Inzaghi
Vincenzo Iaquinta";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
