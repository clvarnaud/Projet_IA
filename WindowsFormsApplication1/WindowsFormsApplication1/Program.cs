using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*#region GenereNoeuds
            Noeud a = new Noeud("A", false);
            Noeud b = new Noeud("B", true);
            Noeud c = new Noeud("C", false);
            Noeud d = new Noeud("D", false);
            Noeud e = new Noeud("E", false);
            Noeud f = new Noeud("F", true);
            Noeud g = new Noeud("G", true);
            Noeud h = new Noeud("H", true);
            Noeud i = new Noeud("I", false);
            Noeud j = new Noeud("J", true);
            Noeud k = new Noeud("K", false);
            Noeud l = new Noeud("L", false);
            Noeud m = new Noeud("M", true);
            Noeud n = new Noeud("N", false);
            Noeud o = new Noeud("O", true);
            Noeud p = new Noeud("P", false);
            Noeud q = new Noeud("Q", true);
            Noeud r = new Noeud("R", false);
            Noeud s = new Noeud("S", true);
            Noeud t = new Noeud("T", true);
            Noeud u = new Noeud("U", false);
            Noeud v = new Noeud("V", true);
            Noeud w = new Noeud("W", false);
            #endregion
            #region GenereSegments
            Segment AB = new Segment(new List<Noeud> {a,b}, 4);
            Segment AC = new Segment(new List<Noeud> {a,c}, 5);
            Segment AD = new Segment(new List<Noeud> {a,d}, 6);
            Segment BE = new Segment(new List<Noeud> {b,e}, 5);
            Segment CD = new Segment(new List<Noeud> {c,d}, 4);
            Segment CE = new Segment(new List<Noeud> {c,e}, 6);  
            Segment CG = new Segment(new List<Noeud> {c,g}, 8);            
            Segment DF = new Segment(new List<Noeud> {d,f}, 9);
            Segment EH = new Segment(new List<Noeud> {e,h}, 4);
            Segment FL = new Segment(new List<Noeud> {f,l}, 9);
            Segment GH = new Segment(new List<Noeud> {g,h}, 8);
            Segment GK = new Segment(new List<Noeud> {g,k}, 4);
            Segment HI = new Segment(new List<Noeud> {c,d}, 4);

            
            #endregion*/

            //Création des différents points du graphe
            Sommet B =new Sommet();
            Sommet C =new Sommet();
            Sommet D =new Sommet();
            Sommet E =new Sommet();
            Sommet F =new Sommet();
            Sommet G =new Sommet();
            Sommet H =new Sommet();
            Sommet I =new Sommet();
            Sommet J =new Sommet();
            Sommet K =new Sommet();
            Sommet L =new Sommet();
            Sommet M =new Sommet();
            Sommet N =new Sommet();
            Sommet O =new Sommet();
            Sommet P =new Sommet();
            Sommet Q =new Sommet();
            Sommet R =new Sommet();
            Sommet S =new Sommet();
            Sommet T =new Sommet();
            Sommet U =new Sommet();
            Sommet V =new Sommet();
            Sommet W =new Sommet();
           
            //Assignation des liaisons entre les points du graphe

            Sommet A = new Sommet(new Dictionary <Sommet,int>
            {
                {B,4},
                {C,5},
                {D,6}
            });

            B = new Sommet(new Dictionary <Sommet,int>
            {
                {A,4},
                {E,5}
            });

             C = new Sommet(new Dictionary <Sommet,int>
            {
                {A,5},
                {D,4},
                {E,6},
                {G,8}
            });

             D = new Sommet(new Dictionary <Sommet,int>
            {
                {A,6},
                {C,4},
                {F,9}
            });

             E = new Sommet(new Dictionary <Sommet,int>
            {
                {B,5},
                {C,6},
                {H,4}
            });
            
             F = new Sommet(new Dictionary <Sommet,int>
            {
                {D,9},
                {L,9}
            });

             G = new Sommet(new Dictionary <Sommet,int>
            {
                {C,8},
                {H,8},
                {K,8}
            });

             H = new Sommet(new Dictionary <Sommet,int>
            {
                {E,4},
                {G,8},
                {I,2}
             });

             I = new Sommet(new Dictionary <Sommet,int>
            {
                {H,2},
                {J,3},
                {K,4}
             });
            
             J = new Sommet(new Dictionary <Sommet,int>
            {
                {I,3}
             });

               K = new Sommet(new Dictionary <Sommet,int>
            {
                {G,8},
                {I,4},
                {W,7}
             });

             L = new Sommet(new Dictionary <Sommet,int>
            {
                {F,9},
                {M,2},
                {N,4},
                {Q,7},
                {W,10}
                
             });

            M = new Sommet(new Dictionary <Sommet,int>
            {
                {L,2}
             });

             N = new Sommet(new Dictionary <Sommet,int>
            {
                {L,4},
                {O,7},
                {P,3},
                            
             });

             O = new Sommet(new Dictionary <Sommet,int>
            {
                {N,7},
                {P,3},
                {S,8},
                            
             });

             P = new Sommet(new Dictionary <Sommet,int>
            {
                {N,3},
                {O,3},
                {R,5},
                            
             });

             Q = new Sommet(new Dictionary <Sommet,int>
            {
                {L,7},
                {R,3}
                                            
             });

             R = new Sommet(new Dictionary <Sommet,int>
            {
                {P,5},
                {Q,3},
                {T,6},
                            
             });

             S = new Sommet(new Dictionary <Sommet,int>
            {
                {O,8},
                {U,7}
                                            
             });

             T = new Sommet(new Dictionary <Sommet,int>
            {
                {R,6},
                {U,5}
                                            
             });

             U = new Sommet(new Dictionary <Sommet,int>
            {
                {S,7},
                {T,5},
                {V,11}
                                            
             });

             V = new Sommet(new Dictionary <Sommet,int>
            {
                {U,11},
                {W,6}
                                                            
             });

               W = new Sommet(new Dictionary <Sommet,int>
            {
                {K,7},
                {L,10},
                {V,6}
                                                            
             });

            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        }
    }
