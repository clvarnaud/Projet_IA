using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_IA_test
{
    public partial class Form1 : Form
    {
        int[,] matrice = {
                {0,4,5,6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {4,0,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {5,0,0,4,6,0,8,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {6,0,4,0,0,9,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,5,6,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,9,0,0,0,0,0,0,0,9,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,8,0,0,0,0,8,0,0,8,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,4,0,8,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,2,0,3,4,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,8,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                {0,0,0,0,0,9,0,0,0,0,0,0,2,4,0,0,7,0,0,0,0,0,10},
                {0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,4,0,0,7,3,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,7,0,3,0,0,8,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,0,0,5,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,7,0,0,0,0,0,3,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,5,3,0,0,6,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,8,0,0,0,0,0,7,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,6,0,0,5,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,5,0,11,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11,0,6},
                {0,0,0,0,0,0,0,0,0,0,7,10,0,0,0,0,0,0,0,0,0,6,0},
            };


        public Form1()
        {
            InitializeComponent();
        }

        private void impasse_btn_Click(object sender, EventArgs e)
        {
            impasse_label.Text = nbImpasse(matrice).ToString();
        }

        public int nbImpasse(int [,] matrice)
        {

            int _nbImpasse=0;
            int _nbChemin=0;
            

            for (int i = 0; i <23; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (matrice[i,j]!=0)
                    {
                        _nbChemin +=1;

                    }
                }
                if(_nbChemin==1)
                {
                    _nbImpasse +=1 ;
                }

                _nbChemin = 0;
            }

            return _nbImpasse;
        }

        /*public string plusCourtChemin(int[,] matrice, char a, char b)
        {
            int depart = lettreAColonne(a);
            int arrivee = lettreAColonne(b);
            string res = "" + a;
            List<string> possibilites = tousLesChemins(matrice, a, b);
            string plusCourt = compareChemins(matrice, possibilites);
            return plusCourt;
        }

        public List<string> tousLesChemins(int[,] matrice, char a, char b)
        {
            int depart = lettreAColonne(a);
            int arrivee = lettreAColonne(b);
            string res = "" + a;
            List<string> possibilites = new List<string>();
            for (int i = 0; i < 23; i++)
            {
                if (matrice[depart, i] != 0 && i != lettreAColonne(b))
                {
                    List<string> c = tousLesChemins(matrice, colonneAlettre(i), b);
                    foreach (string s in c)
                    {
                        possibilites.Add(res + s);
                    }
                }
            }
            return possibilites;
        }

        public string compareChemins(int[,] matrice, List<string> possibilites)
        {
            string res = possibilites[0];

        }

        public char colonneAlettre(int a)
        {
            char res = (char) (a + 65);
            return res;
        }

        public int lettreAColonne(char a)
        {
            int res = a - 65;
            return res;
        }*/
    }
}
