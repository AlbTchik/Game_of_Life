using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsilvGui;

namespace Jeu_de_la_vie___Tchikladzé_Alban
{
    class Program
    {                           
        
        
                                                                    //Etape 1 : Une population (version améliorée)



        static int[,] InitialisationGrille()
        {
            do
            {   Console.WriteLine("choisissez votre configuration de départ : ");                  //permet a l'utilisateur de choisir une génération aléatoire ou une figure particulière
                Console.WriteLine("          1 - Oscillateur Pulsar");
                Console.WriteLine("          2 - Vaisseau Spatial Lourd");
                Console.WriteLine("          3 - Vaisseau de l'Oie");
                Console.WriteLine("          4 - Pentomino R (Vie 2x plus longue en grille ciculaire)");
                Console.WriteLine("          5 - Canon de Gosper (destructible)");
                Console.WriteLine("          6 - Génération aléatoire selon un pourcentage  (étape1)");

                string config1 = Console.ReadLine();
                int config = Convert.ToInt32(config1);

                if (config == 1)                                                            //  1 - Oscillateur Pulsar
                {   int[,] grille = new int[17, 17];                                                // nb lignes ; nb colonnes 
                    grille[6, 6] = 1;
                    grille[7, 6] = 1;
                    grille[8, 6] = 1;
                    grille[9, 6] = 1;
                    grille[10, 6] = 1;
                    grille[6, 8] = 1;
                    grille[10, 8] = 1;
                    grille[6, 10] = 1;
                    grille[7, 10] = 1;
                    grille[8, 10] = 1;
                    grille[9, 10] = 1;
                    grille[10, 10] = 1;
                    if (config <= 6 && config > 0) { return grille; }
                }

                if (config == 2)                                                    // 2 - Vaisseau Spatial Lourd
                {   int[,] grille = new int[11, 120];                                   // nb lignes ; nb colonnes 
                    grille[3, 3] = 1; grille[5, 3] = 1; grille[6, 4] = 1; grille[6, 5] = 1; grille[6, 6] = 1; grille[6, 7] = 1; grille[6, 8] = 1; grille[6, 9] = 1; grille[5, 9] = 1; grille[4, 9] = 1; grille[3, 8] = 1; grille[2, 6] = 1; grille[2, 5] = 1;
                    if (config <= 6 && config > 0) { return grille; }
                }

                if (config == 3)                                                    // 3 - Vaisseau de l'Oie
                {   int[,] grille = new int[45, 80];                                    // nb lignes ; nb colonnes
                    grille[17, 2] = 1; grille[16, 3] = 1; grille[16, 4] = 1; grille[17, 4] = 1; grille[17, 5] = 1; grille[17, 6] = 1; grille[18, 6] = 1; grille[18, 7] = 1; grille[20, 6] = 1; grille[21, 5] = 1; grille[23, 3] = 1; grille[23, 4] = 1;
                    grille[22, 6] = 1; grille[22, 7] = 1; grille[23, 6] = 1; grille[24, 6] = 1; grille[24, 7] = 1; grille[21, 9] = 1; grille[21, 10] = 1; grille[22, 9] = 1; grille[23, 9] = 1; grille[22, 11] = 1; grille[23, 11] = 1;
                    grille[24, 12] = 1; grille[25, 12] = 1; grille[26, 12] = 1; grille[25, 11] = 1; grille[26, 11] = 1; grille[18, 10] = 1; grille[19, 10] = 1; grille[18, 11] = 1; grille[15, 12] = 1; grille[15, 13] = 1;
                    grille[15, 14] = 1; grille[16, 14] = 1; grille[17, 13] = 1;
                    if (config <= 6 && config > 0) { return grille; }
                }

                if (config == 4)                                                    // 4 - Pentomino R 
                {   int[,] grille = new int[45, 120];                                    // nb lignes ; nb colonnes
                    grille[20, 60] = 1;
                    grille[21, 60] = 1;
                    grille[22, 60] = 1;
                    grille[22, 59] = 1;
                    grille[21, 61] = 1;

                    if (config <= 6 && config > 0) { return grille; }
                }
                if (config == 5)                                                    // 5 - Canon de Gosper
                {   int[,] grille = new int[45,120];                                    // nb lignes ; nb colonnes
                    grille[23, 41] = 1; grille[24, 41] = 1; grille[23, 42] = 1; grille[24, 42] = 1; grille[22, 52] = 1; grille[23, 52] = 1; grille[24, 52] = 1; grille[25, 53] = 1; grille[26, 54] = 1; grille[25, 55] = 1; grille[21, 53] = 1; grille[20, 54] = 1;
                    grille[21, 55] = 1; grille[22, 56] = 1; grille[23, 56] = 1; grille[24, 56] = 1; grille[22, 57] = 1; grille[23, 57] = 1; grille[24, 57] = 1; grille[20, 62] = 1; grille[21, 62] = 1; grille[22, 62] = 1; grille[19, 63] = 1;
                    grille[20, 63] = 1; grille[22, 63] = 1; grille[23, 63] = 1; grille[19, 64] = 1; grille[20, 64] = 1; grille[22, 64] = 1; grille[23, 64] = 1; grille[19, 65] = 1; grille[20, 65] = 1; grille[21, 65] = 1; grille[22, 65] = 1;
                    grille[23, 65] = 1; grille[18, 66] = 1; grille[19, 66] = 1; grille[23, 66] = 1; grille[24, 66] = 1; grille[19, 71] = 1; grille[20, 71] = 1; grille[21, 75] = 1; grille[21, 76] = 1; grille[22, 75] = 1; grille[22, 76] = 1;

                    if (config <= 6 && config > 0) { return grille; }
                }

                if (config == 6)                                                    //6 - Génération aléatoire selon un pourcentage(étape1)
                {   int nbLignes = ChoixNbLignes();                                     
                    int nbColonnes = ChoixNbColonnes();                                 
                    int[,] grille = new int[nbLignes, nbColonnes];                      // nb lignes ; nb colonnes

                    Console.WriteLine("Donnez le pourcentage de remplissage en cellules vivantes de la grille : [0.1,0.9]"); //Choisissez le pourcentage de cellules vivantes
                    string taux1 = Console.ReadLine();
                    double taux = Convert.ToDouble(taux1);
                    int nbCaseATransformer = (int)(taux * grille.GetLength(0) * grille.GetLength(1));           //transfomration du pourcentage en nombre de cellules vivantes a crée

                    Random generateur = new Random();                                               //générateur de nombre aléatoire
                    for (int i = 0; i < nbCaseATransformer; i=i+0) 
                    {   int y = generateur.Next(0, grille.GetLength(0) - 1);
                          int x = generateur.Next(0, grille.GetLength(1) - 1);              //on prend une cellule aléatoire
                          if (grille[y,x] == 0) { grille[y, x] = 1; i++; }       //si la cellule aléatoire est une cellule morte, on la transforme en  cellule vivante et on augmente le compteur de cellules transformées
                    }
                    if (config <= 6 && config > 0) { return grille; }
                }
            } 
            while (true);
        }
    
        static int ChoixNbLignes()                                                          //Choisissez le nombre de lignes
        {   Console.WriteLine("choisissez le nombre de lignes (nb conseillé 45) : ");
            string nbLignes1 = Console.ReadLine();
            int nbLignes = Convert.ToInt32(nbLignes1);
            Console.WriteLine();
            return nbLignes;
        }

        static int ChoixNbColonnes()                                                        //Choisissez le nombre de colonnes
        {   Console.WriteLine("choisissez le nombre de colonnes (nb conseillé 120) : ");
            string nbColonnes1 = Console.ReadLine();
            int nbColonnes = Convert.ToInt32(nbColonnes1);
            Console.WriteLine();
            return nbColonnes;
        }

        static int NbCelluleVivantes(int[,] grille)                                         //Compte le nombre de cellules vivantes dans la grille
        {   int nbVivantes = 0;
            for (int i = 0; i < grille.GetLength(0); i++)
            {   for (int j = 0; j < grille.GetLength(1); j++)
                {
                    if (grille[i, j] == 1) { nbVivantes++; }
                }
            }
            return nbVivantes;
        }

        static int AffichageEtatFutur()                                                     //Choississez si vous voulez afficher les états futur, déconseillé car difficilement visible si génération trop rapide
        {   while (true)
            {   Console.WriteLine("Voulez-vous afficher les états futurs ?");
                Console.WriteLine("           1 - Oui");
                Console.WriteLine("           2 - Non");
                Console.WriteLine();
                string etat1 = Console.ReadLine();
                int etat = Convert.ToInt32(etat1);
                if (etat == 1 || etat == 2) { return etat; }
                else {Console.WriteLine("Entrez soit 1 soit 2 !!!");  Console.WriteLine(); }
            }            
        }


        static int NbVoisinsVivant_rang1 (int[,] grille, int Ligne, int Colonne)            //regarde l'état de toute les cellules dans un carré de 3x3 incluant la cellule ciblée
        {   int nbVoisin = 0;

            for ( int i = Ligne - 1; i <= Ligne + 1; i++)
            {
                for (int j = Colonne -1; j <= Colonne + 1; j++)
                {
                    if (grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1) ] == 1 || grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1)] == 3)  
                    {nbVoisin++;}
                }
            }
            if (grille[Ligne, Colonne] == 1)                 // on supprime la cellule regardée des comptes
            { nbVoisin -= 1; }             
            return nbVoisin;
        }
      
        static int[,] Regle1 (int[,] grille, int Ligne, int Colonne)                        //régle 1 en fonction du nombre de voisins
        {   int nbVoisins = NbVoisinsVivant_rang1(grille, Ligne, Colonne);
            if (nbVoisins<2)  {grille[Ligne, Colonne] = 3;}                                     //transformation en cellule a mourir
            return grille;
        }

        static int[,] Regle2(int[,] grille, int Ligne, int Colonne)                         //régle 2 en fonction du nombre de voisins
        {   int nbVoisins = NbVoisinsVivant_rang1(grille, Ligne, Colonne);
            if (nbVoisins > 3)  { grille[Ligne, Colonne] = 3; }                                  //transformation en cellule a mourir
            return grille;
        }

        static int[,] Regle3(int[,] grille, int Ligne, int Colonne)                         //régle 3 en fonction du nombre de voisins
        {   int nbVoisins = NbVoisinsVivant_rang1(grille, Ligne, Colonne);
            if (nbVoisins == 3)  {grille[Ligne, Colonne] = 2; }                                  //transformation en cellule a vivre
            return grille;
        }

        static int[,] ApplicationRegles(int[,] grille)                                      //application des regles en fonction de l'état de la cellule
        {   for(int i = 0; i< grille.GetLength(0);i++)
            {   for (int j = 0; j < grille.GetLength(1); j++)
                {
                    if (grille[i, j] == 0) { grille = Regle3(grille, i, j); }                                       //si cellule morte on applique la règle 3
                    if (grille[i, j] == 1) { grille = Regle1(grille, i, j); grille = Regle2(grille, i, j); }            // si cellule vivante on applique la régle 1 et 2
                }
            }
            return grille;
        }

        static int[,] InstantSuivant(int[,] grille)                                     //passage a t+1 
        {   for (int i = 0; i < grille.GetLength(0); i++)
            {   for (int j = 0; j < grille.GetLength(1); j++)
                {
                    if (grille[i, j] == 3) { grille[i, j] = 0; }                        //transforme les cellules a mourir en cellules mortes
                    if (grille[i, j] == 2) { grille[i, j] = 1; }                        //transforme les cellules a vivre en cellules vivantes
                }
            }
            return grille;
        }

        static void UnePopulation()                         //fonction qui resume toute les méthodes pour une population
        {   int etatFutur = AffichageEtatFutur();               //choix de l'utilisateur pour les etats futurs

            int[,] grille = InitialisationGrille();             //choix de l'utilisateur pour la position des cellules vivantes au début de la simulation

            Fenetre gui = new Fenetre(grille, 15, 0, 0, "Jeu de la vie");    // taille cellule de 15 pixels  fenêtre centrée (décalage 0 vers le bas et 50 vers la droite) message initial : "Jeu de la vie"
            gui.Rafraichir(); 

            //System.Threading.Thread.Sleep(1000000); //permet d'afficher l'état initial pour le corriger

            for (int i = 0; i < 40000; i++)                                             //on effectue 40 000 génération de façon totalement arbitraire
            {   int nbVivantes = NbCelluleVivantes(grille);                                 
                gui.ChangerMessage("Génération " + i + ".  Actuellement " + nbVivantes + " Cellules vivantes.");        //on change le message du GUI

                grille = ApplicationRegles(grille);             //application des regles pour les donner les états futurs

                if (etatFutur == 1) { gui.Rafraichir(); System.Threading.Thread.Sleep(25); } // afficher les états futurs selon la volonté de l'utilisateur

                grille = InstantSuivant(grille);        //passage a l'état suivant 
                gui.Rafraichir(); 

                System.Threading.Thread.Sleep(25);
            }
        }





        //Etape 2 : n Populations 


        //en réalité 4 maximum car le GUI ne peut pas afficher plus de 4 couleurs (sans compter le vert et le rouge qui sont reservés)




        static int[,] InitialisationGrilleNPopulation(int nbPopulation)
        {   int nbLignes = ChoixNbLignes();
            int nbColonnes = ChoixNbColonnes();
            int[,] grille = new int[nbLignes, nbColonnes]; // nb lignes ; nb colonnes

            for (int i = 0; i < nbPopulation; i++)
            {   Console.WriteLine("Donnez le pourcentage de remplissage en cellules vivantes de la grille pour la population " + (i + 1));
                Console.WriteLine("Intervalle conseillé : [" + (0.1 / nbPopulation) + ";" + (0.9 / nbPopulation) + "]" + "      Médiane : " + (((0.1 / nbPopulation) + (0.9 / nbPopulation)) / 2));
                string taux1 = Console.ReadLine();
                double taux = Convert.ToDouble(taux1);
                int nbCaseATransformer = (int)(taux * grille.GetLength(0) * grille.GetLength(1));

                Random generateur = new Random();

                for (int j = 0; j < nbCaseATransformer; j = j + 0)
                {   int y = generateur.Next(0, grille.GetLength(0) - 1);
                    int x = generateur.Next(0, grille.GetLength(1) - 1);
                    if (grille[y, x] == 0)
                    {
                        if (i == 0) { grille[y, x] = i + 1; j++; }
                        else { grille[y, x] = i + 3; j++; }
                    }
                }
            }
            return grille;
        }

        static int NbCelluleVivantesNPopulations(int[,] grille, int Race)
        {   int nbVivantes = 0;
            for (int i = 0; i < grille.GetLength(0); i++)
            {   for (int j = 0; j < grille.GetLength(1); j++)
                {
                    if (Race == 1) { if (grille[i, j] == 1) { nbVivantes++; } }
                    else { if (grille[i, j] == Race + 2) { nbVivantes++; } }
                }
            }
            return nbVivantes;
        }

        static int NbVoisinsVivant_rang1NPopulation(int[,] grille, int Ligne, int Colonne, int Race)
        {   int nbVoisin = 0;
            for (int i = Ligne - 1; i <= Ligne + 1; i++)
            {   for (int j = Colonne - 1; j <= Colonne + 1; j++)
                {
                    if (Race == 1)
                    {
                        if (grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1)] == Race || grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1)] == (30 + Race))
                        { nbVoisin++; }
                    }
                    else
                    {
                        if (grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1)] == Race + 2 || grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1)] == (30 + Race + 2))
                        { nbVoisin++; }
                    }
                }
            }
            if (Race == 1)
            {
                if (grille[Ligne, Colonne] == Race)
                { nbVoisin -= 1; } // on supprime la cellule regardée des comptes
            }

            else
            {
                if (grille[Ligne, Colonne] == Race + 2)
                { nbVoisin -= 1; } // on supprime la cellule regardée des comptes
            }
            return nbVoisin;
        }

        static int NbVoisinsVivant_rang2(int[,] grille, int Ligne, int Colonne)
        {   int nbVoisin = 0;
            for (int i = Ligne - 2; i <= Ligne + 2; i++)
            {   for (int j = Colonne - 1; j <= Colonne + 1; j++)
                {
                    if (grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1)] == 1 || grille[(i + grille.GetLength(0)) % grille.GetLength(0), (j + grille.GetLength(1)) % grille.GetLength(1)] == 3)
                    { nbVoisin++; }
                }
            }
            if (grille[Ligne, Colonne] == 1)
            { nbVoisin -= 1; } // on supprime la cellule regardée des comptes
            return nbVoisin;
        }

        static int[,] Regle1NPopulation(int[,] grille, int Ligne, int Colonne, int Race)
        {   int nbVoisins = NbVoisinsVivant_rang1NPopulation(grille, Ligne, Colonne, Race);
            if (nbVoisins < 2)
            {   if (Race == 1)    { grille[Ligne, Colonne] = (30 + Race); }
                else    { grille[Ligne, Colonne] = (30 + Race + 2); }
            }
            return grille;
        }

        static int[,] Regle2NPopulation(int[,] grille, int Ligne, int Colonne, int Race)
        {   int nbVoisins = NbVoisinsVivant_rang1NPopulation(grille, Ligne, Colonne, Race);
            if (nbVoisins > 3)
            {
                if (Race == 1)      { grille[Ligne, Colonne] = (30 + Race); }
                else      { grille[Ligne, Colonne] = (30 + Race + 2); }
            }
            return grille;
        }

        static int[,] Regle3NPopulation(int[,] grille, int Ligne, int Colonne, int nbPopulation)
        {   for (int Race = 1; Race < nbPopulation; Race++)
            {
                if (Race == 1)
                { int nbVoisins1 = NbVoisinsVivant_rang1NPopulation(grille, Ligne, Colonne, Race); }
                if (Race == 2)
                { int nbVoisins1 = NbVoisinsVivant_rang1NPopulation(grille, Ligne, Colonne, Race); }
                if (Race == 3)
                { int nbVoisins1 = NbVoisinsVivant_rang1NPopulation(grille, Ligne, Colonne, Race); }
                if (Race == 4)
                { int nbVoisins1 = NbVoisinsVivant_rang1NPopulation(grille, Ligne, Colonne, Race); }
                else
                {
                    int nbVoisins = NbVoisinsVivant_rang1NPopulation(grille, Ligne, Colonne, Race);
                    if (nbVoisins == 3)
                    { grille[Ligne, Colonne] = (20 + Race + 2); }
                }
            }
            return grille;
        }

        static int[,] ApplicationReglesNPopulation(int[,] grille, int nbPopulations)
        {   for (int Race = 1; Race <= nbPopulations; Race++)
            {   for (int i = 0; i < grille.GetLength(0); i++)
                {   for (int j = 0; j < grille.GetLength(1); j++)
                    {
                        if (grille[i, j] == 0) { grille = Regle3NPopulation(grille, i, j, nbPopulations); }
                    }
                }
                for (int i = 0; i < grille.GetLength(0); i++)
                {   for (int j = 0; j < grille.GetLength(1); j++)
                    {
                        if (grille[i, j] == 1) { grille = Regle1NPopulation(grille, i, j, Race); grille = Regle2NPopulation(grille, i, j, Race); }
                    }
                }
            }
            return grille;
        }

        static void NPopulations(int nbPopulation)
        {   int[,] grille = InitialisationGrilleNPopulation(nbPopulation);

            Fenetre gui = new Fenetre(grille, 15, 0, 0, "Jeu de la vie");       // taille cellule de 15 pixels  fenêtre centrée (décalage 0 vers le bas et 50 vers la droite)  message initial : "Jeu de la vie"
            gui.Rafraichir(); 

            for (int i = 0; i < 40000; i++)
            {   if(nbPopulation == 2)
                {   int nbVivantes1 = NbCelluleVivantesNPopulations(grille, 1);
                    int nbVivantes2 = NbCelluleVivantesNPopulations(grille, 2);
                    gui.ChangerMessage("Génération " + i + "     " + nbVivantes1 + " Cellules vivantes de la population 1" +"     " + nbVivantes2 + " Cellules vivantes de la population 2");
                }

                if (nbPopulation == 3)
                {   int nbVivantes1 = NbCelluleVivantesNPopulations(grille, 1);
                    int nbVivantes2 = NbCelluleVivantesNPopulations(grille, 2);
                    int nbVivantes3 = NbCelluleVivantesNPopulations(grille, 3); 
                    gui.ChangerMessage("Génération " + i + "     " + nbVivantes1 + " Cellules vivantes de la population 1" + "     " + nbVivantes2 + " Cellules vivantes de la population 2" + "     " + nbVivantes3 + " Cellules vivantes de la population 3");
                }

                if (nbPopulation == 4)
                {   int nbVivantes1 = NbCelluleVivantesNPopulations(grille, 1);
                    int nbVivantes2 = NbCelluleVivantesNPopulations(grille, 2);
                    int nbVivantes3 = NbCelluleVivantesNPopulations(grille, 3);
                    int nbVivantes4 = NbCelluleVivantesNPopulations(grille, 4);
                    gui.ChangerMessage("Génération " + i + "     " + nbVivantes1 + " Cellules vivantes de la population 1" + "     " + nbVivantes2 + " Cellules vivantes de la population 2" + "     " + nbVivantes3 + " Cellules vivantes de la population 3" + "     " + nbVivantes4 + " Cellules vivantes de la population 4");
                }

                gui.Rafraichir();  
                grille = ApplicationReglesNPopulation(grille,nbPopulation);

                grille = InstantSuivant(grille);
                gui.Rafraichir(); 

                System.Threading.Thread.Sleep(10);
            }
        }



        [System.STAThreadAttribute()]
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Combien de population voulez-vous entre 1 et 4 ?");
                string nbPopulation1 = Console.ReadLine();
                int nbPopulation = Convert.ToInt32(nbPopulation1);
                Console.WriteLine();
                if (nbPopulation == 1) { UnePopulation(); break; }
                if (nbPopulation <= 4 && nbPopulation >=2) { NPopulations(nbPopulation); break; } 
                else { Console.WriteLine("veuillez rentrer un nombre appartenant a [1,4] !!!"); Console.WriteLine(); }
            }
            
        }
    }
}
