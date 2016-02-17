using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Segment
    {
        private List<Noeud> noeudsAssocies;
        private int tpsTrajet;

        public Segment(List<Noeud> nodesAssocies, int _tpsTrajet)
        {
            noeudsAssocies = nodesAssocies;
            tpsTrajet = _tpsTrajet;
        }

        public int TpsTrajet
        {
            get { return tpsTrajet; }
            set { tpsTrajet = value; }
        }

        internal List<Noeud> NoeudsAssocies
        {
            get { return noeudsAssocies; }
            set { noeudsAssocies = value; }
        }
    }
}
