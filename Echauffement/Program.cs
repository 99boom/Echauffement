namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Hi, my name is Ivan and my favorite game is Uncharted.");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.Write("What's your firstname? ");
        string prenom = Console.ReadLine();

        Console.Write("How old are you? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        bool estMajeur = false;
        if (age >= 18)
        {
            Console.WriteLine("You are major.");
            estMajeur = true;
        }
        else
        {
            Console.WriteLine("You are minor.");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.Write("How much dollars do you have? ");
        double money = Convert.ToDouble(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("\n--- Available Weapons ---");
        Console.WriteLine("1. Cattleman - 500 $");
        Console.WriteLine("2. Lemat - 1000 $");
        Console.WriteLine("3. Lancaster - 2000 $");
        Console.WriteLine("4. P1911 - 1600 $");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.Write("Choose one of those firearms (1 - 4): ");
        int chose = Convert.ToInt32(Console.ReadLine());

        // Détermination du prix selon le choix
        double price = 0;
        bool choixValide = true;

        if (chose == 1)
        {
            price = 500;
        }
        else if (chose == 2)
        {
            price = 1000;
        }
        else if (chose == 3)
        {
            price = 2000;
        }
        else if (chose == 4)
        {
            price = 1600;
        }
        else
        {
            choixValide = false;
        }

        // Etape 7a & 7b : vérification de l'argent ET de la majorité (connecteur logique &&)
        if (!choixValide)
        {
            Console.WriteLine("Action impossible : Invalid choice.");
        }
        else if (estMajeur && money >= price)
        {
            money = money - price; // Correction de "pic" en "price"
            Console.WriteLine("You just bought a firearm!");
            Console.WriteLine("Your new balance is " + money + " $.");
        }
        else
        {
            // Gère le cas où l'utilisateur est mineur OU s'il n'a pas assez d'argent
            Console.WriteLine("Action impossible : You are either too young or you don't have enough money.");
        }

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}