using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6_7_WILTHIEN_Sherylann_TD_P
{
     class Labyrinthe
    {
        #region Attributs
        public int[,] matrice;
        public int nbLignes;
        public int nbColonnes;

        public Position depart;
        public Position arrivee;
        #endregion

        #region Constructeur
        public Labyrinthe (string[] schema1, int nbLignes,int nbColonnes)
        {
            this.nbLignes=nbLignes;
            this.nbColonnes=nbColonnes;
            depart = new Position(0,0);
            arrivee = new Position(0, 0);
            matrice = new int [nbLignes,nbColonnes];
           for(int i=0;i<schema1.Length;i++)
            {
               for(int j=0;j<schema1[i].Length;j++)
                {
                    switch (schema1[i][j])
                    {
                        case ('*'):matrice[i, j] = 1;break;//mur
                        case ('-'):matrice[i,j]= 0;break;//libre
                        case ('d'):matrice[i, j] = 2; depart=new Position(i,j);break;
                        case ('a'):matrice[i, j] = 3; arrivee = new Position(i, j); break;
                        case ('.'):matrice[i, j] = 4;break; // perso 
                    }

                }
            }
        }

        #endregion

        #region Methodes
        public bool EstOccupee(Position pos)
        {
            switch (matrice[pos.ligne,pos.colonne])
            {
                case 1: return false;//mur
                case 4: return false;//occupé par le perso 
                default: return true;
            } 
        }
        public override string ToString()
        {
            string affichage = "";
            for(int i=0; i<matrice.GetLength(0); i++)
            {
               for (int j=0;j<matrice.GetLength(1);j++)
                {
                   switch (matrice[i,j])
                    {
                        case 0: affichage += "-";break;
                        case 1: affichage += "*";break;
                        case 2: affichage += "d";break;
                        case 3: affichage += "a";break;
                        case 4: affichage += ".";break;
                    }
                }
                affichage += "\n";
            }
            return affichage;
        }
        #endregion
    }
}
