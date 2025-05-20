namespace Le_glacier;

public class TripleChocolat : CoupeGlacee
{
    private static readonly TripleChocolat _instance = new TripleChocolat();

    public TripleChocolat()
    {
        _parfums.Add(Parfum.CHOCOBLANC);
        _parfums.Add(Parfum.CHOCONOIR);
        _parfums.Add(Parfum.CHOCOLAT);
    }
    
    public static TripleChocolat Instance => _instance;
    
    public override double Prix()
    {
        return 3.0;
    }

    public override string Description()
    {
        return "Coupe triple chocolat parfums : " + string.Join(" - ", _parfums) + " -";
    }
}
