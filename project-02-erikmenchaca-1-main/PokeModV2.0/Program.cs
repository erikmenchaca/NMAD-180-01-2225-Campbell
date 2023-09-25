//Erik Menchaca
//April 11, 2023
//Project 2
//

const string CONSOLE_TITLE = "PokeModV2";
Console.Title = CONSOLE_TITLE;
Console.WriteLine(CONSOLE_TITLE);
Console.WriteLine("--------------");
Pokemon[] pokemons = new Pokemon[20];
Console.WriteLine();
string[] options = new string[]
{
    "Add a new Pokemon", "Search for a Pokemon", "Remove a pokemon from the array",
    "Add a new ability to a specific Pokemon", "Show all Pokemon information", "Exit"
};
while (true)
{
    for (int i = 0; i < options.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {options[i]}");
    }

    Console.Write("Enter selection (1-6): ");
    int selection = int.Parse(Console.ReadLine());

    switch (selection)
    {
        case 1:
            AddNewPokemon();
            break;
        case 2:
            SearchForAPokemon();
            break;
        case 3:
            RemoveAPokemon();
            break;
        case 4:
            AddAbility();
            break;
        case 5:
            ListAllPokemons();
            break;
        case 6:
            ExitProgram();
            break;
        default:
            Console.WriteLine("Invalid Selection");
            break;
    }
}

void AddNewPokemon()
{
    string name, color;
    int hp, level;
    double value;
    while (true)
    {
        Console.Write("Enter the pokemon's name: ");
        name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Error: Pokemon's name must be entered!");
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        Console.Write("Enter the pokemon's color: ");
        color = Console.ReadLine();
        if (string.IsNullOrEmpty(color))
        {
            Console.WriteLine("Error: Pokemon's color must be entered!");
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        Console.Write("Enter the pokemon's level: ");
        level = int.Parse(Console.ReadLine());
        if (level < 0)
        {
            Console.WriteLine("Error: Pokemon's level must be positive!");
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        System.Console.Write("Enter the pokemon's hp: ");
        hp = int.Parse(Console.ReadLine());
        if (hp < 0)
        {
            System.Console.WriteLine("Error: Pokemon's HP must be positive!");
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        Console.Write("Enter the pokemon's value: ");
        value = double.Parse(Console.ReadLine());
        if (value < 0)
        {
            Console.WriteLine("Error: Pokemon's value must be positive.");
        }
        else
        {
            break;
        }
    }

    Pokemon pokemon = new Pokemon(name, color, level, hp, value);
    for (int i = 0; i < pokemons.Length; i++)
    {
        if (pokemons[i] == null)
        {
            pokemons[i] = pokemon;
            break;
        }
    }

    System.Console.WriteLine($"{name} successfully added to the pokemons list!");
}

void SearchForAPokemon()
{
    Console.Write("Enter the pokemon's name to search: ");
    string name = Console.ReadLine();
    bool found = false;
    foreach (Pokemon pokemon in pokemons)
    {
        if (pokemon is not null)
        {
            if (pokemon.Name.ToLower().Equals(name.ToLower()))
            {
                found = true;
                Console.WriteLine($"{pokemon.Name} is in the array.");
                break;
            }
        }
    }

    if (!found)
    {
        Console.WriteLine($"Error: {name} is not in the array.");
    }
}

void RemoveAPokemon()
{
    Console.Write("Enter the pokemon's to remove: ");
    string name = Console.ReadLine();
    bool found = false;
    foreach (Pokemon pokemon in pokemons)
    {
        if (pokemon != null)
        {
            if (pokemon.Name.ToLower() == name.ToLower())
            {
                pokemons = null;
                found = true;
                break;
            }
        }
    }

    if (!found)
    {
        System.Console.WriteLine($"Error: {name} is not found in the array for removal. ");
    }

    System.Console.WriteLine($"{name} is removed from the pokemons list!");
}

void ListAllPokemons()
{
    for (int i = 0; i < pokemons.Length; i++)
    {
        System.Console.WriteLine(pokemons[i]);
    }
}

void AddAbility()
{
    Pokemon pokemon = null;

    while (pokemon is null)
    {
        System.Console.Write("Enter the pokemon's name to add an ability: ");
        string name = Console.ReadLine();

        foreach (Pokemon poke in pokemons)
        {
            if (poke.Name.ToLower() == name.ToLower())
            {
                pokemon = poke;
                break;
            }
        }

        //no match was found
        Console.WriteLine($"No pokemon name {name} was found!");
    }

    while (true)
    {
        System.Console.Write("Enter the ability's name: ");
        string abilityName = Console.ReadLine();
        if (string.IsNullOrEmpty(abilityName))
        {
            System.Console.WriteLine("Error: Pokemon's ability name cannot be empty!");
            continue;
        }

        System.Console.Write("Enter the ability's HP: ");
        int abilityHP = int.Parse(Console.ReadLine());
        if (abilityHP < 0)
        {
            System.Console.WriteLine("Error: Pokemon's ability HP must be positive!");
            continue;
        }

        System.Console.Write("Enter the ability's type: ");
        string abilityType = Console.ReadLine();

        //validate ability type

        Ability ability = new Ability(abilityName, abilityHP, abilityType);

        pokemon.AddAbility(ability);
        Console.WriteLine($"The ability was added to the list of abilities for the pokemon:{pokemon.Name}");
        break;
    }
}


void ExitProgram()
{
    Console.WriteLine("Thank you for playing PokeModV2.0! Goodbye!");
    System.Environment.Exit(0);
}