namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_24
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            (string Team, string[] Players)[] worldCup2006Finalists = new[]
            {
                (
                    TeamName: "France",
                    Players: new string[]
                    {
                        "Fabien Barthez", "Gregory Coupet",
                        "Mickael Landreau", "Eric Abidal",
                        "Jean-Alain Boumsong", "Pascal Chimbonda",
                        "William Gallas", "Gael Givet",
                        "Willy Sagnol", "Mikael Silvestre",
                        "Lilian Thuram", "Vikash Dhorasoo",
                        "Alou Diarra", "Claude Makelele",
                        "Florent Malouda", "Patrick Vieira",
                        "Zinedine Zidane", "Djibril Cisse",
                        "Thierry Henry", "Franck Ribery",
                        "Louis Saha", "David Trezeguet",
                        "Sylvain Wiltord",
                    }
                ),
                (
                    TeamName: "Italy",
                    Players: new string[]
                    {
                        "Gianluigi Buffon", "Angelo Peruzzi",
                        "Marco Amelia", "Cristian Zaccardo",
                        "Alessandro Nesta", "Gianluca Zambrotta",
                        "Fabio Cannavaro", "Marco Materazzi",
                        "Fabio Grosso", "Massimo Oddo",
                        "Andrea Barzagli", "Andrea Pirlo",
                        "Gennaro Gattuso", "Daniele De Rossi",
                        "Mauro Camoranesi", "Simone Perrotta",
                        "Simone Barone", "Luca Toni",
                        "Alessandro Del Piero", "Francesco Totti",
                        "Alberto Gilardino", "Filippo Inzaghi",
                        "Vincenzo Iaquinta",
                    }
                )
            };

            IEnumerable<string> players =
                worldCup2006Finalists.SelectMany(
                    team => team.Players);

            Print(players);

        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
