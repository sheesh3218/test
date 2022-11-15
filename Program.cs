using System;

namespace TD6_7_WILTHIEN_Sherylann_TD_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Position a1 = new Position(0,0);
            string[] schema1 = { "********", "*d--*--*", "**----a*", "********" };
           Labyrinthe lab = new Labyrinthe(schema1, 4, 8);
            Personnage bob = new Personnage(lab);
            while(!bob.EstArrivee()) bob.SeDeplaceDans(lab);
            Console.WriteLine("Bravo!");
        }
    }
}
