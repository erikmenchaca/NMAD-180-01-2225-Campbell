public class Pokemon
{
    //private fields
    private string name;
    private int hp;
    private string color;
    private double level;
    private Ability[] abilities;
    private double value;
    private double tradingValue;
    public const int DEFAULT_NUMBER_OF_ABILITIES = 3;
    public const string DEFAULT_NAME = "Name Undefined";
    public const int DEFAULT_HP = 0;
    public const string DEFAULT_COLOR = "Color Undefined";
    public const double DEFAULT_LEVEL = 1, DEFAULT_VALUE = 0;
    public const string DEFAULT_ABILITY = "Ability Undefined";


    //public properties
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                name = DEFAULT_NAME;
            }
            else
            {
                name = value;
            }
        }
    }

    public int HP
    {
        get { return hp; }
        set
        {
            if (value < DEFAULT_HP)
            {
                hp = DEFAULT_HP;
            }
            else
            {
                hp = value;
            }
        }
    }

    public string Color
    {
        get { return color; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                color = DEFAULT_COLOR;
            }
            else
            {
                color = value;
            }
        }
    }

    public double Level
    {
        get { return level; }
        set
        {
            if (value < 0)
            {
                level = 0;
            }
            else
            {
                level = value;
            }
        }
    }

    public Ability[] Abilities
    {
        get => abilities;
        set
        {
            if (value == null)
            {
                abilities = new Ability[DEFAULT_NUMBER_OF_ABILITIES];
            }
            else
            {
                abilities = value;
            }
        }
    }

    public double Value
    {
        get { return value; }
        set
        {
            if (value < 0)
            {
                this.value = 1;
            }
            else
            {
                this.value = value;
            }
        }
    }

    public double TradingValue
    {
        get { return Level * Value; }
    }

    public Pokemon()
    {
        name = DEFAULT_NAME;
        hp = DEFAULT_HP;
        color = DEFAULT_COLOR;
        level = DEFAULT_LEVEL;
        abilities = new Ability[0];
        value = DEFAULT_VALUE;
    }

    public Pokemon(string name, string color, int level, int hp, double value)
    {
        this.name = name;
        this.color = color;
        this.level = level;
        this.hp = hp;
        this.value = value;
        this.abilities = new Ability[2];
    }

    public void AddAbility(Ability ability)
    {
        for (int i = 0; i < abilities.Length; i++)
        {
            //  Find an empty space in the Abilities array
            if (abilities[i] == null)
            {
                abilities[i] = ability;
                return;
            }
        }
    }

    public void TakeDamage(Ability ability)
    {
        if (ability.IsAttack())
        {
            HP -= ability.HP;
        }
    }

    public void ShieldAttack(Ability ability)
    {
        Ability highestSheild = null;

        //picking the highest shield ability from the list of abilities
        foreach (Ability ability1 in Abilities)
        {
            if (ability1.IsShield())
            {
                if (highestSheild is null)
                    highestSheild = ability1;
                else if (ability1.HP > highestSheild.HP)
                {
                    highestSheild = ability1;
                }
            }
        }

        //defend against the attack
        if (ability.IsAttack())
        {
            //we have no shield
            if (highestSheild is null)
            {
                HP -= ability.HP; // take the full damage;
                return;
            }

            //otherwise we take small amount or no damage
            int amountOfDamage = highestSheild.HP - ability.HP;

            //update our hp 
            HP -= amountOfDamage;
        }
    }

    public int Heal(Ability ability)
    {
        foreach (Ability ability1 in abilities)
        {
            HP += ability.HP;
        }

        return HP;
    }

    public override string ToString()
    {
        string abilityString = "";
        foreach (Ability ability in abilities)
        {
            if (ability is not null)
                abilityString += ability.ToString();
        }

        return
            $"Pokemon's Name: {Name}\nPokemon's Color: {Color}\nPokemon's Level: {Level}\nPokemon's HP: {HP}\nPokemon's Trading Value: {TradingValue:C}\nPokemon's Abilities: {abilityString}";
    }
}