namespace Game.models
{
    public class Human
    {


    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
    public int Health
    {
        get
        {
            return health;
        }
    }
    public Human(string charname)
    {
        Name = charname;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }

     public Human(string charname, int str, int intel, int dex, int hp)
    {
        Name = charname;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        health = hp;
    }
    

        // *add a public "getter" property to access health

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values

        // Add a constructor to assign custom values to all fields

        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= Strength * 5;
            return target.health;
        }
    }



}