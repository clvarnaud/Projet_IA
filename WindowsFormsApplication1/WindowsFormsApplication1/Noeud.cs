using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Noeud
    {
        private string nom;
        private bool ferme;
        private List<Segment> relations;

        public Noeud(string _nom, bool _ferme)
        {
            nom = _nom;
            ferme = _ferme;
        }

        public bool Ferme
        {
            get { return ferme; }
            set { ferme = value; }
        }

        internal List<Segment> Relations
        {
            get { return relations; }
            set { relations = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

    }
}
