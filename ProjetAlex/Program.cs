// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Quel est le prix hors taxes de l'article ?");
string prix = Console.ReadLine();
decimal A = decimal.Parse(prix);

Console.WriteLine("Quel est le nombre d'articles ?");
string nombre = Console.ReadLine();
int B = int.Parse(nombre);

Console.WriteLine("Quel est le taux de TVA en % ?");
string taux = Console.ReadLine();
decimal C = decimal.Parse(taux);

decimal resultat = ((C / 100) + 1) * A * B;

Console.WriteLine($"Le prix total est de {resultat}");



