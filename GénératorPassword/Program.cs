using FomationCS;
using System;

namespace GénératorPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NB_MP = 10;

             


            // 1- Demander la longueurs du mot de passe (demandernombre) int longueurmp = ...
             int longueurMp = outils.DemanderNOmbrePositifNonNull("Longueur du mot de passe : ");

            int choixAlphabet = outils.DemanderNombreEntre("Entre un chiffre entre 1 et 4 pour un mot de passe avec :\n" +
                 "1-minuscule\n" +
                 "2-majuscule et minuscule\n" +
                 "3-chiffre, majuscule et minuscule\n" +
                 "4-caractère spéciaux, chiffre, majuscule et minuscules\n" +
                 "Votre choix : ", 1, 4);
          

            // 2- alphabet(abc1234): 4 = '1a2d)
            // 3- commenct choisir caractere aleatoire
           

            

            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = minuscule.ToUpper() ;
            string chiffre = "0123456789";
            string caractereSpeciaux = "'(;.!?,~£$#{[]}";
            string alphabet; 
            string password = "";
            Random rand = new Random();

            if (choixAlphabet == 1)
            {
                alphabet = minuscule;
            }
            else if(choixAlphabet == 2)
            {
                alphabet = minuscule + majuscule;
            }
            else if(choixAlphabet == 3)
            {
                alphabet = minuscule + majuscule + chiffre;
            }
            else
            {
                alphabet = minuscule + majuscule + chiffre + caractereSpeciaux;
            }


           
            int longueurAlpha = alphabet.Length;

            for (int j = 0; j < NB_MP; j++)
            {

                password = "";
                for (int i = 0; i < longueurMp; i++)
                {
                    int index = rand.Next(0, longueurAlpha);
                    password += alphabet[index];

                }
                Console.WriteLine("Mot de passe n° "+(j+1)+" : " + password);
            }

            

           

            
            // 4- generer le mp
            // 5- Amelioration : choix alphabet

        }


    }
}
