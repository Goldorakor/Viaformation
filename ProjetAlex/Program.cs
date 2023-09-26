// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Quel est le prix hors taxes de l'article ?");
string prix = Console.ReadLine();
int A = int.Parse(prix);

Console.WriteLine("Quel est le nombre d'articles ?");
string nombre = Console.ReadLine();
int B = int.Parse(nombre);

Console.WriteLine("Quel est le taux de TVA ?");
string taux = Console.ReadLine();
int C = int.Parse(taux);

int resultat = ((20 / 100) + 1) * A * B;

Console.WriteLine($"Le prix total est de {resultat}");



