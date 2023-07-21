class animal
{
    public string hair;
    public string color;

    public animal(string haircolor,string colortype)
    {
        hair = haircolor;
        color = colortype;
    }
    public animal()
    {
        hair = "green";
        color = "Long";
    }
    public void Aype()
    {
        Console.WriteLine("Dog: " + hair + " Cat: " + color);
    }
}

class Program
{
    static void Main(string[] args)
    {
        animal dog = new animal("blue","red") ;
        animal cat = new animal();

        dog.Aype();
        



    }
}