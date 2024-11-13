using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_boogle
{
   
    public class Joueur
    {
        private Stack<string> motsTrouve = new Stack<string>();// on utilise le type pile pour stocké les mots trouvés 
        private int nom;
        private int score;


        public Joueur(int nom)
        {
            this.nom = nom;
            this.score = 0;
            this.motsTrouve = null;
        }
        public bool Contain(string mot)// qui teste si le mot passé appartient déjà aux mots trouvés par le joueur pendant la partie
        {
            if (motsTrouve == null)
            {
                return false;
            }
            else if ( motsTrouve.Peek()==mot)
    
            {
                return true;
            }
            return false;


        }
        public void Add_Mot(string mot)// ajoute le mot dans la liste des mots déjà trouvés par le joueur au cours de la partie en modifiant le nombre d’occurrences si nécessaire
        {
            if (!motsTrouve.Contains(mot))
            {
                 motsTrouve.Push(mot);
                // incrémenter le score du joueur 

            }
            else
            {
                Console.WriteLine(" le mot a déjà été trouvé ! ");
            }

        }


        public string toString()// qui retourne une chaîne de caractères qui décrit un joueur.
        {
            string mots = "";
            foreach (string mot in motsTrouve)
            {
                mots += mot + ",";
            }
            return $"nom : {this.nom}  \n score : {this.score}  \n mots trouvés : {mots}";
        }
    }

}
