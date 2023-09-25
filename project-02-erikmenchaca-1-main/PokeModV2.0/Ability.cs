public class Ability
{
    public const string UNDEFINED_NAME = "Undefined Ability Name";
    public const string UNDEFINED_TYPE = "Undefined Ability Type";
    public const int UNDEFINED_HP = 0;
    public const int DEFAULT_NUMBER_OF_TYPES = 3;

    private string name;
    private string type;
    private int hp;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                name = UNDEFINED_NAME;
            }
            else
            {
                name = value;
            }
        }
    }

    public string Type
    {
        get { return type; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                type = UNDEFINED_TYPE;
            }
            else
            {
                type = value;
            }
        }
    }

    public int HP
    {
        get { return hp; }
        set
        {
            if (value < UNDEFINED_HP)
            {
                hp = UNDEFINED_HP;
            }
            else
            {
                hp = value;
            }
        }
    }

    public Ability()
    {
        Name = UNDEFINED_NAME;
        Type = UNDEFINED_TYPE;
        HP = UNDEFINED_HP;
    }

    public Ability(string name, int hp, string type)
    {
        Name = name;
        HP = hp;
        Type = type;
    }


    public bool IsAttack()
    {
        if (Type == "Attack")
            return true;

        return false;
    }

    public bool IsShield()
    {
        if (type == "Shield")
            return true;

        return false;
    }

    public bool IsHealing()
    {
        if (type == "Healing")
            return true;

        return false;
    }

    public override string ToString()
    {
        return $"Name: {Name}, HP: {HP}, Type: {Type}";
    }
}