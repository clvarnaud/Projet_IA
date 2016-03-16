using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_IA_test
{
    class Node : GenericNode
    {
        private static string _deb;
        private static string _fin;
        public static int[,] matrice;
        public static char[] correspondance;
        



        public Node(string newname) : base(newname)
        {
        }

        public Node (string deb,string fin ) :this(deb)
        {
            _deb = deb;
            _fin = fin;
            _distance_totale = 0;

        }
        public override double GetArcCost(GenericNode N1, GenericNode N2)
        {
            double cost=0;
            bool find1=false;
            bool find2 = false;
            int i=0;
            int j = 0;
            while (!find1)
            {
                if(correspondance[i].ToString()==N1.GetNom())
                {
                    find1 = true;
                    while (!find2)
                    {
                        if (correspondance[j].ToString()==N2.GetNom())
                        {
                            find2 = true;
                            cost = matrice[i, j];
                            
                        }
                        
                        j++;
                    }
                }

                i ++;
            }
            return cost;

        }

        public override bool EndState()
        {

            if(this.Name==_fin.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();
            char voisin;
            for (int i = 0; i < 23; i++)
            {
                if (correspondance[i].ToString() == Name)
                {

                    for (int j = 0; j < 23; j++)
                    {
                        if (matrice[i,j]!=0)
                        {
                            voisin = correspondance[j];
                            lsucc.Add(new Node(voisin.ToString()));                       
                        }
                    }
                }
            }

            return lsucc;
        }

        public override void CalculeHCost()
        {
            SetEstimation(0);
        }

        private string GetStringFromTab(char[,] tab)
        {
            string newname = "";
            for (int j = 0; j <= 2; j++)
                for (int i = 0; i <= 2; i++)
                {
                    newname = newname + tab[i, j];
                }
            return newname;
        }
    }
}
