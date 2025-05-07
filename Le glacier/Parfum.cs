namespace Le_glacier;

public class Parfum
{
    private string _nom;

    private Parfum(string nom)
    {
        _nom = nom;
    }

    public static readonly Parfum CASSIS = new Parfum("Cassis");
    public static readonly Parfum FRAMBOISE = new Parfum("Framboise");
    public static readonly Parfum FRAISE = new Parfum("Fraise");

    public static readonly Parfum CHOCOBLANC = new Parfum("Chocolat blanc");
    public static readonly Parfum CHOCOLAT = new Parfum("Chocolat au lait");
    public static readonly Parfum CHOCONOIR = new Parfum("Chocolat noir");

    public override string ToString()
    {
        return _nom;
    }
}
