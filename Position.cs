using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6_7_WILTHIEN_Sherylann_TD_P
{
    internal class Position
    {

        #region Attributs
        public int ligne { get; set; }
        public int colonne { get; set; }

        #endregion

        # region Constructeurs
        public Position(int a, int b)
        {
             ligne=a;
             colonne=b;
        }
        #endregion

        #region Méthodes 
        public override string ToString()
        {
            return $"ligne{ligne}, colonne{colonne}";
        }
        public bool EstEgale(Position pos)
        { 
            return (pos.ligne ==ligne && pos.colonne == colonne);
        }
        public bool MarquePassage(Position enCours,Labyrinthe laby)
        {
            
            if (laby.EstOccupee(enCours))
            {
                if (ligne-1 == enCours.ligne && colonne == enCours.colonne) return true;
                else if(ligne+1==enCours.ligne && colonne==enCours.colonne)return true;
                else if (ligne == enCours.ligne && colonne+1== enCours.colonne) return true;
                else if (ligne == enCours.ligne && colonne-1 == enCours.colonne) return true;
                else return false;
            }
            return false;
            
            
        }

        #endregion


    }
   
}
