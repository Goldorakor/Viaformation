// on demande la saisie de son âge à l'utilisateur et on corrige éventuellement le point en virgule
Console.WriteLine("Ecrire ton âge s'il te plait ?");
string nbsaisi01 = Console.ReadLine();

// on transforme la saisie string en nombre entier et on l'affecte à age
bool succes01 = int.TryParse(nbsaisi01, out int age);

// on demande la saisie de son sexe à l'utilisateur et on corrige éventuellement une mauvaise saisie
Console.WriteLine("Es-tu une fille ou un garçon ? Réponds par 1 si tu es une fille, par 2 si tu es un garçon");
string nbsaisi02 = Console.ReadLine();

// on transforme la saisie string en nombre entier et on l'affecte à sexe
bool succes02 = int.TryParse(nbsaisi02, out int sexe);

if (succes01) 
{
    if (age < 18)
        if (sexe == 1)
        {
            Console.WriteLine("Tu es mineure");
        }
        else if (sexe == 2)

        {
            Console.WriteLine("Tu es mineur");
        }
        else
        {
            Console.WriteLine("Tu es mineur(e) mais je ne sais pas déterminer ton genre.");
        }



    else if (age == 18)
        if (sexe == 1)
        {
            Console.WriteLine("Tu es tout juste majeure");
        }
        else if (sexe == 2)
        {
            Console.WriteLine("Tu es tout juste majeur");
        }
        else
        {
            Console.WriteLine("Tu es tout juste majeur(e) mais je ne sais pas déterminer ton genre.");
        }




    else if (age > 18)
        if (sexe == 1)
        {
            Console.WriteLine("Tu es majeure");
        }
        else if (sexe == 2)

        {
            Console.WriteLine("Tu es majeur");
        }
        else
        {
            Console.WriteLine("Tu es majeur(e) mais je ne sais pas déterminer ton genre.");
        }
}
else
{
    Console.WriteLine("Je ne sais pas déterminer ton âge correctement !");
}