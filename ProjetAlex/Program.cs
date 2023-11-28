// on demande la saisie à l'utilisateur d'un nombre entre 10 et 20
Console.WriteLine("Ecrire un nombre entre 10 et 20, s'il te plait ?");
string nbsaisi01 = Console.ReadLine();

// on transforme la saisie string en nombre entier et on l'affecte à age
bool succes01 = int.TryParse(nbsaisi01, out int nombre);



if (succes01)
{
    while (nombre < 10)
      
        {
            Console.WriteLine("Plus grand !");
        Console.WriteLine("Ecrire un nombre entre 10 et 20, s'il te plait ?");
        string nbsaisi01 = Console.ReadLine();
       
    }
        

   

    Console.WriteLine("Bravo !");
}

else
{
    Console.WriteLine("Merci de rentrer un nombre !");
}



