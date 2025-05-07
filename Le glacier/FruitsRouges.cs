namespace Le_glacier;

public class FruitsRouges : CoupeGlacee
{
    public FruitsRouges()
    {
        _parfums.Add(Parfum.CASSIS);
        _parfums.Add(Parfum.FRAMBOISE);
        _parfums.Add(Parfum.FRAISE);
    }

    public override double Prix()
    {
        return 5.5;
    }

    public override string Description()
    {
        return "Coupe fruits rouges parfums : " + string.Join(" - ", _parfums) + " -";
    }
}
