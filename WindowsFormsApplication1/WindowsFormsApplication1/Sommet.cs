using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Sommet
    {
        // Attributs de la classe Sommet
        private Dictionary<Sommet,int> _graphe;
        private List<Sommet> _ferme;

        //Constructeurs
        public Sommet() 
        { 
        }

        public Sommet(Dictionary<Sommet, int> graphe)
        {
            _graphe = graphe;
            _graphe[this] = 0;
        }

        /*=====================================================
         * Nom : public bool isImpasse ()
         * Parametres entrée : Aucuns
         * Parametres sortie : booleen
         * Role : La fonction teste combien de sommets sont accesibles
         *lorsque nous sommes sur un sommet. S'il n'y a 
         * qu'un seul alors nous nos trouvons sur un sommet se 
         * situant au bout d'une impasse nous renvoyons donc
         * la valeur true. Si le nombre de sommets accessible
         * est différent de 1 alors on renvoie la valeur false
         * ===================================================
         
         */
        public bool isImpasse()
        {
            if (_graphe.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int nbImpasse()
        {


        }




    }
}
