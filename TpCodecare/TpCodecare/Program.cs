using System;
using System.Collections.Generic;

namespace TpCodecare
{
	class Program
	{
		static void Main(string[] args)
		{
			Personne[] pers;
			pers = new Personne[13];
			pers[0] = new Personne("Dupire", "Paul", "responsable", "responsable", Role.Responsable);
			pers[1] = new Personne("Dupont", "Pierre", "professeur", "professeur", Role.Professeur);
			pers[2] = new Personne("François", "Jacques", "professeur2", "professeur2", Role.Professeur);
			pers[3] = new Personne("Fulachier", "Elian", "etudiant", "etudiant", Role.Etudiant);
			pers[4] = new Personne("test1", "test1", "etudiant1", "etudiant1", Role.Etudiant);
			pers[5] = new Personne("test2", "test2", "etudiant2", "etudiant2", Role.Etudiant);
			pers[6] = new Personne("test3", "test3", "etudiant3", "etudiant3", Role.Etudiant);
			pers[7] = new Personne("test4", "test4", "etudiant5", "etudiant4", Role.Etudiant);
			pers[8] = new Personne("test5", "test5", "etudiant5", "etudiant5", Role.Etudiant);
			pers[9] = new Personne("test6", "test6", "etudiant6", "etudiant6", Role.Etudiant);
			pers[10] = new Personne("test7", "test7", "etudiant7", "etudiant7", Role.Etudiant);
			pers[11] = new Personne("test8", "test8", "etudiant8", "etudiant8", Role.Etudiant);
			pers[12] = new Personne("test9", "test9", "etudiant9", "etudiant9", Role.Etudiant);

			Livre[] livres;
			livres = new Livre[16];
			livres[0] = new Livre("A77", "Harry Potter 1", "J. K. Rowling", 671);
			livres[1] = new Livre("A78", "Harry Potter 2", "J. K. Rowling", 689);
			livres[2] = new Livre("A79", "Harry Potter 3", "J. K. Rowling", 851);
			livres[3] = new Livre("A80", "Harry Potter 4", "J. K. Rowling", 796);
			livres[4] = new Livre("A81", "Harry Potter 5", "J. K. Rowling", 751);
			livres[5] = new Livre("A82", "Harry Potter 6", "J. K. Rowling", 742);
			livres[6] = new Livre("A83", "Harry Potter 7", "J. K. Rowling", 794);
			livres[7] = new Livre("B11", "Seigneur des anneaux", "J. R. R. Tolkien", 756);
			livres[8] = new Livre("B12", "Seigneur des anneaux 2", "J. R. R. Tolkien", 780);
			livres[9] = new Livre("B13", "Seigneur des anneaux 3", "J. R. R. Tolkien", 801);
			livres[10] = new Livre("C74", "Hunger Games", "Suzanne Collins", 682);
			livres[11] = new Livre("C75", "Hunger Games 2", "Suzanne Collins", 640);
			livres[12] = new Livre("C76", "Hunger Games 3", "Suzanne Collins", 742);
			livres[13] = new Livre("D14", "Les misérables", "‎Victor Hugo", 521);
			livres[14] = new Livre("E86", "1984", "George Orwell", 742);
			livres[15] = new Livre("F75", "Germinal", "Emile Zola", 799);


			Emprunt emprunt = new Emprunt();

			string choix = "";
			
			while (choix != "e")
			{
				Console.WriteLine("Veuillez vous connecter : ");
				string choice = "";
				string test = "";
				List<string> listLivre = new List<string>();
				List<string> listPers = new List<string>();
				Personne connexion;
				connexion = new Personne();
				
				while(test!="vrai")
				{
					Console.WriteLine("login : ");
					string loginSite = Console.ReadLine();
					Console.WriteLine("password : ");
					string mdpSite = Console.ReadLine();
					
					foreach (Personne personne in pers)
					{
						if (loginSite == personne.logins && mdpSite == personne.mdps)
						{
							connexion = personne;
							test = "vrai";
						}
					}
					if (test != "vrai")
					{
						Console.WriteLine("erreur de connexion\n");
					}
				}
				
				while(choice != "6")
				{
					Console.WriteLine("\nTapez 1 pour afficher tous les livres \nTapez 2 pour afficher les détails d'un livre \nTapez 3 pour emprunter un livre \nTapez 4 pour rendre un livre \nTapez 5 pour voir tous les emprunts de livre (que pour le responsable) \nTapez 6 pour vous déconnecter \nTapez \"e\" pour quitter");
					choix = Console.ReadLine();

					int n = 0;
					int m = 0;

					if (choix == "1")
					{
						for (int i = 0; i <= 15; i++)
						{
							Console.WriteLine(livres[n].AfficherLivres());
							n += 1;
						}
					}
					if (choix == "2")
					{
						Console.WriteLine("Veuillez saisir le code ISBN du livre souhaité");
						string saisie = Console.ReadLine();
						for (int i = 0; i <= 15; i++)
						{
							if (saisie == livres[m].CodeISBN)
							{
									Console.WriteLine(livres[m].AfficherInfo());
							}
							m += 1;
						}
					}

					if (choix == "3")
					{
						Console.WriteLine("Veuillez indiquer le titre du livre que vous souhaitez emprunter");
						string livreEmprunt = Console.ReadLine();
						if (livreEmprunt == "Harry Potter 1") { livreEmprunt = "0";}
						else if (livreEmprunt == "Harry Potter 2") { livreEmprunt = "1"; }
						else if (livreEmprunt == "Harry Potter 3") { livreEmprunt = "2"; }
						else if (livreEmprunt == "Harry Potter 4") { livreEmprunt = "3"; }
						else if (livreEmprunt == "Harry Potter 5") { livreEmprunt = "4"; }
						else if (livreEmprunt == "Harry Potter 6") { livreEmprunt = "5"; }
						else if (livreEmprunt == "Harry Potter 7") { livreEmprunt = "6"; }
						else if (livreEmprunt == "Seigneur des anneaux") { livreEmprunt = "7"; }
						else if (livreEmprunt == "Seigneur des anneaux 2") { livreEmprunt = "8"; }
						else if (livreEmprunt == "Seigneur des anneaux 3") { livreEmprunt = "9"; }
						else if (livreEmprunt == "Hunger Games") { livreEmprunt = "10"; }
						else if (livreEmprunt == "Hunger Games 2") { livreEmprunt = "11"; }
						else if (livreEmprunt == "Hunger Games 3") { livreEmprunt = "12"; }
						else if (livreEmprunt == "Les misérables") { livreEmprunt = "13"; }
						else if (livreEmprunt == "1984") { livreEmprunt = "14"; }
						else if (livreEmprunt == "Germinal") { livreEmprunt = "15"; }
						else { livreEmprunt = "16"; }

						if (livreEmprunt == "16")
						{
							Console.WriteLine("livre introuvable");
						}
						else
						{
							if (livres[Int32.Parse(livreEmprunt)].Disponibilite == "indisponible")
							{
								Console.WriteLine("Ce livre est indisponible");
							}
							else
							{
								if (connexion.roles.ToString() == "Etudiant")
								{
									if (connexion.addID.Count < 2)
									{
										emprunt.emprunter(livres[Int32.Parse(livreEmprunt)], connexion);
									}
									else
									{
										Console.WriteLine("vous avez trop de livres");
									}
								}
								if (connexion.roles.ToString() == "Professeur")
								{
									if (connexion.addID.Count < 4)
									{
										emprunt.emprunter(livres[Int32.Parse(livreEmprunt)], connexion);
									}
									else
									{
										Console.WriteLine("vous avez trop de livres");
									}
								}
								if (connexion.roles.ToString() == "Responsable")
								{
									emprunt.emprunter(livres[Int32.Parse(livreEmprunt)], connexion);
								}
							}
						}
					}


					if (choix == "4")
					{
						Console.WriteLine("Veuillez indiquer le titre du livre que vous souhaitez rendre");
						string livreRendre = Console.ReadLine();
						if (livreRendre == "Harry Potter 1") { livreRendre = "0"; }
						else if (livreRendre == "Harry Potter 2") { livreRendre = "1"; }
						else if (livreRendre == "Harry Potter 3") { livreRendre = "2"; }
						else if (livreRendre == "Harry Potter 4") { livreRendre = "3"; }
						else if (livreRendre == "Harry Potter 5") { livreRendre = "4"; }
						else if (livreRendre == "Harry Potter 6") { livreRendre = "5"; }
						else if (livreRendre == "Harry Potter 7") { livreRendre = "6"; }
						else if (livreRendre == "Seigneur des anneaux") { livreRendre = "7"; }
						else if (livreRendre == "Seigneur des anneaux 2") { livreRendre = "8"; }
						else if (livreRendre == "Seigneur des anneaux 3") { livreRendre = "9"; }
						else if (livreRendre == "Hunger Games") { livreRendre = "10"; }
						else if (livreRendre == "Hunger Games 2") { livreRendre = "11"; }
						else if (livreRendre == "Hunger Games 3") { livreRendre = "12"; }
						else if (livreRendre == "Les misérables") { livreRendre = "13"; }
						else if (livreRendre == "1984") { livreRendre = "14"; }
						else if (livreRendre == "Germinal") { livreRendre = "15"; }
						else { livreRendre = "16"; }

						if (livreRendre == "16")
						{
							Console.WriteLine("livre introuvable");
						}
						else
						{
							if (livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[0] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[1] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[2] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[3] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[4] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[5] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[6] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[7] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[8] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[9] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[10] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[11] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[12] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[13] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[14] || livres[Int32.Parse(livreRendre)].CodeISBN == connexion.addID[15])
							{
								emprunt.rendre(livres[Int32.Parse(livreRendre)], connexion);
							}
							else
							{
								Console.WriteLine("Vous ne possédez pas ce livre");
							}
						}
					}


					if (choix == "5")
					{
						if (connexion.roles.ToString() != "Responsable")
						{
							Console.WriteLine("Vous n'avez pas les droits");
						}
						else
						{

							foreach (Livre liv in livres)
							{
								foreach (string str in liv.addID)
								{
									listPers.Add(str);
								}
							}
							foreach (Personne pe in pers)
							{
								foreach (string str in pe.addID)
								{
									listLivre.Add(str);
								}
							}
							for (int i=0; i<listLivre.Count; i++)
							{
								Console.WriteLine(listPers[i] + " a emprunté le livre : " + listLivre[i]);
							}
							listLivre.Clear();
							listPers.Clear();
						}
					}

					if (choix == "6")
					{
						break;
					}
					if (choix == "e")
					{
						break;
					}
				}
			}
		}
	}
}
