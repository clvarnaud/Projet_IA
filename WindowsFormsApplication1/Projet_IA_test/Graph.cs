using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_IA_test
{
    class Graph
    {
        private List<GenericNode> L_Ouverts;
        private List<GenericNode> L_Fermes;
        private List<string> L_permut;
        private int cout_total;

        private GenericNode ChercheNodeDansFermes(string NodeName)
        {
            int i = 0;

            while (i < L_Fermes.Count)
            {
                if (L_Fermes[i].GetNom() == NodeName)
                    return L_Fermes[i];
                i++;
            }
            return null;
        }

        private GenericNode ChercheNodeDansOuverts(string NodeName)
        {
            int i = 0;

            while (i < L_Ouverts.Count)
            {
                if (L_Ouverts[i].GetNom() == NodeName)
                    return L_Ouverts[i];
                i++;
            }
            return null;
        }

        public List<GenericNode> RechercheSolutionAEtoile(GenericNode N0)
        {
            L_Ouverts = new List<GenericNode>();
            L_Fermes = new List<GenericNode>();
            // Le noeud passé en paramètre est supposé être le noeud initial
            GenericNode N = N0;
            L_Ouverts.Add(N0);
            

            // tant que le noeud n'est pas terminal et que ouverts n'est pas vide
            while (L_Ouverts.Count != 0 && N.EndState() == false)
            {
                // Le meilleur noeud des ouverts est supposé placé en tête de liste
                // On le place dans les fermés
                L_Ouverts.Remove(N);
                L_Fermes.Add(N);

                // Il faut trouver les noeuds successeurs de N
                this.MAJSuccesseurs(N);
                // Inutile de retrier car les insertions ont été faites en respectant l'ordre

                // On prend le meilleur, donc celui en position 0, pour continuer à explorer les états
                // A condition qu'il existe bien sûr
                if (L_Ouverts.Count > 0)
                {
                    N = L_Ouverts[0];
                }
                else
                {
                    N = null;
                }
            }

            // A* terminé
            // On retourne le chemin qui va du noeud initial au noeud final sous forme de liste
            // Le chemin est retrouvé en partant du noeud final et en accédant aux parents de manière
            // itérative jusqu'à ce qu'on tombe sur le noeud initial
            List<GenericNode> _LN = new List<GenericNode>();
            if (N != null)
            {
                _LN.Add(N);

                while (N != N0)
                {
                    N = N.GetNoeud_Parent();
                    _LN.Insert(0, N);  // On insère en position 1
                }
            }
            return _LN;
        }

        private void MAJSuccesseurs(GenericNode N)
        {
            // On fait appel à GetListSucc, méthode abstraite qu'on doit réécrire pour chaque
            // problème. Elle doit retourner la liste complète des noeuds successeurs de N.
            List<GenericNode> listsucc = N.GetListSucc();
            foreach (GenericNode N2 in listsucc)
            {
                // N2 est-il une copie d'un nœud déjà vu et placé dans la liste des fermés ?
                GenericNode N2bis = ChercheNodeDansFermes(N2.GetNom());
                if (N2bis == null)
                {
                    // Rien dans les fermés. Est-il dans les ouverts ?
                    N2bis = ChercheNodeDansOuverts(N2.GetNom());
                    if (N2bis != null)
                    {
                        // Il existe, donc on l'a déjà vu, N2 n'est qu'une copie de N2Bis
                        // Le nouveau chemin passant par N est-il meilleur ?
                        if (N.GetGCost() + N.GetArcCost(N,N2) < N2bis.GetGCost())
                        {
                            // Mise à jour de N2bis
                            N2bis.SetGCost(N.GetGCost() + N.GetArcCost(N,N2));
                            // HCost pas recalculé car toujours bon
                            N2bis.calculCoutTotal(); // somme de GCost et HCost
                            // Mise à jour de la famille ....
                            N2bis.Supprime_Liens_Parent ();
                            N2bis.SetNoeud_Parent(N);
                            // Mise à jour des ouverts
                            L_Ouverts.Remove(N2bis);
                            this.InsertNewNodeInOpenList(N2bis);
                        }
                        // else on ne fait rien, car le nouveau chemin est moins bon
                    }
                    else
                    {
                        // N2 est nouveau, MAJ et insertion dans les ouverts
                        N2.SetGCost(N.GetGCost() + N.GetArcCost(N,N2));
                        N2.CalculeHCost();
                        N2.SetNoeud_Parent(N);
                        N2.calculCoutTotal(); // somme de GCost et HCost
                        this.InsertNewNodeInOpenList(N2);
                    }
                }
                // else il est dans les fermés donc on ne fait rien,
                // car on a déjà trouvé le plus court chemin pour aller en N2
            }
        }

        public void InsertNewNodeInOpenList(GenericNode NewNode)
        {
            // Insertion pour respecter l'ordre du cout total le plus petit au plus grand
            if (this.L_Ouverts.Count == 0)
            { L_Ouverts.Add(NewNode); }
            else
            {
                GenericNode N = L_Ouverts[0];
                bool trouve = false;
                int i = 0;
                do
                    if (NewNode.Cout_Total < N.Cout_Total)
                    {
                        L_Ouverts.Insert(i, NewNode);
                        trouve = true;
                    }
                    else
                    {
                        i++;
                        if (L_Ouverts.Count == i)
                        {
                            N = null;
                            L_Ouverts.Insert(i, NewNode);
                        }
                        else
                        { N = L_Ouverts[i]; }
                    }
                while ((N != null) && (trouve == false));
            }
        }

        // Si on veut afficher l'arbre de recherche, il suffit de passer un treeview en paramètres
        // Celui-ci est mis à jour avec les noeuds de la liste des fermés, on ne tient pas compte des ouverts
        public void GetSearchTree( TreeView TV )
        {
            if (L_Fermes == null) return;
            if (L_Fermes.Count == 0) return;
            
            // On suppose le TreeView préexistant
            TV.Nodes.Clear();

            TreeNode TN = new TreeNode ( L_Fermes[0].GetNom() );
            TV.Nodes.Add(TN);

            AjouteBranche ( L_Fermes[0], TN );
        }

        // AjouteBranche est exclusivement appelée par GetSearchTree; les noeuds sont ajoutés de manière récursive
        private void AjouteBranche( GenericNode GN, TreeNode TN)
        {
            foreach (GenericNode GNfils in GN.GetEnfants())
            {
                TreeNode TNfils = new TreeNode(GNfils.GetNom());
                TN.Nodes.Add(TNfils);
                if (GNfils.GetEnfants().Count > 0) AjouteBranche(GNfils, TNfils); 
            }
        }


        public List<GenericNode> cheminAvecEtapes (string nom)
        {
            List<String> listeMots = new List < String> ();
            
            
            double cout_min=10000000000000000;
            int count_mots=0;
            List<int> L_dist = new List<int>();
            
            Debug.WriteLine(nom);
            L_permut = new List<string>();

            Permutation("",nom);
            listeMots = L_permut;
            // listeMots.Add("AKWQOA");
            Debug.WriteLine("nbPermut : " + L_permut.Count);
            List<List<GenericNode>> L_Gene = new List<List<GenericNode>>();
            foreach (var mots in listeMots)
            {
                
                Node A = new Node("A", mots[0].ToString());
                List<GenericNode> L_chemin = new List<GenericNode>();
                L_chemin = RechercheSolutionAEtoile(A);
                L_dist.Add(Node._distance_totale);
                
                for (int i = 0; i < mots.Length-1; i++)
                {
                    char depart = mots[i];
                    char  arrivee = mots[i + 1];
                    //Console.WriteLine(mots);
                    //Graph g = new Graph();
                    Debug.WriteLine(depart + "//" + arrivee);
                    Node noeud = new Node(depart.ToString(), arrivee.ToString());
                    List<GenericNode> L_resultat = RechercheSolutionAEtoile(noeud);
                    L_resultat.RemoveAt(0);
                    L_chemin.AddRange(L_resultat);
                    L_dist[count_mots] += Node._distance_totale;
                    
                }
                Node A_fin = new Node(mots[(mots.Count())-1].ToString(),"A");
                List<GenericNode> L_r = RechercheSolutionAEtoile(A_fin);
                L_r.RemoveAt(0);
                L_chemin.AddRange(L_r);
                L_dist[count_mots]+=Node._distance_totale;

                L_Gene.Add(L_chemin);
                count_mots = count_mots + 1;

            }
            int index=0;
            int k = 0;
            Debug.WriteLine(L_dist.Count + "//" + L_Gene.Count);
            foreach(int distance in L_dist)
            {
                if(distance<cout_min)
                {
                    cout_min = distance;
                    index = k;
                 }
                k++;
            }

            return L_Gene[index];
        }

        /*  static List<String> permute(char[] arry, int i, int n)
          {
              List<String> liste_possibilites = new List<String>();
              int j;
              if (i == n)
              {
                  liste_possibilites.Add(new String(arry));
              }

              else
              {
                  for (j = i; j <= n; j++)
                  {
                      swap(ref arry[i], ref arry[j]);
                      permute(arry, i + 1, n);
                      swap(ref arry[i], ref arry[j]);
                  }
              }

              return liste_possibilites;
          }

          static void swap(ref char a, ref char b)
          {
              char tmp;
              tmp = a;
              a = b;
              b = tmp;
          }*/

        
        private void Permutation(string soFar, string input)
        {
            List<String> liste_possibilites = new List<String>();
            
            if (string.IsNullOrEmpty(input))
            {
                L_permut.Add(soFar);
                liste_possibilites.Add(soFar);
                Debug.WriteLine(soFar+"//"+liste_possibilites.Count);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {

                    string remaining = input.Substring(0, i) + input.Substring(i + 1);
                    Permutation(soFar + input[i], remaining);
                }
            }
            
        }

    }
}
