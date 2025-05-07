namespace Le_glacier;

public class TripleChocolat : CoupeGlacee
{
    public TripleChocolat()
    {
        _parfums.Add(Parfum.CHOCOBLANC);
        _parfums.Add(Parfum.CHOCONOIR);
        _parfums.Add(Parfum.CHOCOLAT);
    }

    public override double Prix()
    {
        return 3.0;
    }

    public override string Description()
    {
        return "Coupe triple chocolat parfums : " + string.Join(" - ", _parfums) + " -";
    }
}
