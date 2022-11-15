using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6_7_WILTHIEN_Sherylann_TD_P
{
    class Personnage
    {
        #region Attributs 
        public Position actuelle { get; set; }
        public Position fin { get; set; }
        #endregion

        #region Constructeurs 
        public Personnage(Labyrinthe laby)
        {
            actuelle = laby.depart;
            fin = laby.arrivee;    
        }
        #endregion

        #region Méthodes 
        public bool EstArrivee()
        { 
            return (actuelle.EstEgale(fin));
        }
        
        public void SeDeplaceDans(Labyrinthe laby)
        {
            Console.WriteLine(laby);
            
            Console.WriteLine("Veuillez saisir la coordonnée en x de votre prochain déplacement ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la coordonnée en y de votre prochain déplacement ");
            int y = Convert.ToInt32(Console.ReadLine());
            Position enCours = new Position(x, y);

            if (actuelle.MarquePassage(enCours, laby))
            { 
                laby.matrice[x,y] = 4;
                actuelle = enCours;
            } 
            else 
            {
                Console.WriteLine("Veuillez saisir une position valide");
                //Console.ReadKey();
            }

            
        }
        #endregion

    }



}
