using System;
using System.Diagnostics;
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

        char[] correspondance_Chiffre_Lettres = {'A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W' };
        
        public Form1()
        {
            InitializeComponent();
            Node.matrice = matrice;
            Graph.matrice = matrice;
            Node.correspondance = correspondance_Chiffre_Lettres;

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

        private void button_recherche_plus_court_Click(object sender, EventArgs e)
        {
            string depart = textBox_depart.Text.ToUpper();
            string arrivee = textBox_arrivee.Text.ToUpper();

            Graph g = new Graph();

            Node noeud = new Node(depart, arrivee);
            List<GenericNode> L_resultat = g.RechercheSolutionAEtoile(noeud);
            listbox_affichage.Items.Clear();
            foreach (GenericNode N in L_resultat)
            {
                listbox_affichage.Items.Add(N);
            }


        }

        private void button_recherche_chemin_Click(object sender, EventArgs e)
        {
            List<GenericNode> solution;
            string saisie;
            saisie = textBox_chemin.Text;
            Graph g = new Graph();
            solution = g.cheminAvecEtapes(saisie);
            listbox_affichage.Items.Clear();
            foreach (GenericNode N in solution)
            {
                listbox_affichage.Items.Add(N);
            }

            



            
        }

        private void btn_search_fermes_Click(object sender, EventArgs e)
        {
            List<GenericNode> solution;
            string saisie;
            saisie = txtBox_chemin_fermes.Text;
            Graph g = new Graph();
            solution = g.cheminAvecFermes(saisie);
            listbox_affichage.Items.Clear();
            foreach (GenericNode N in solution)
            {
                listbox_affichage.Items.Add(N);
            }

        }

        private void btn_sculpture_Click(object sender, EventArgs e)
        {
            
            int[] solution;

            solution = assignationSculpture();

            foreach(int sculpture in solution)
            {
                listbox_affichage.Items.Add(sculpture);
            }

        }

        public int[] assignationSculpture()
        {
            int[] sculpture = new int[23];

            Random rnd = new Random();

            sculpture[0] = rnd.Next(1, 4);
            List<int> index_succ = new List<int>();
            List<int> numero_sculpt_succ = new List<int>();


            for (int i = 1; i < 23; i++)
            {
                Debug.WriteLine(i);
                for (int k = 0; k < 23; k++)
                {
                    if (matrice[i, k] != 0)
                    {
                        index_succ.Add(k);
                    }

                }

                foreach (int index in index_succ)
                {
                    numero_sculpt_succ.Add(sculpture[index]);
                }

                while (sculpture[i] == 0 || numero_sculpt_succ.Contains(sculpture[i]))
                {
                    sculpture[i] = rnd.Next(1, 4);
                }

                Debug.WriteLine("sculpture"+ i +":" +sculpture[i]);

            }

            return sculpture;


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
