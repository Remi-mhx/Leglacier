namespace Le_glacier;

public class NappageChocolatDecorator : SupplementDecorator
{
    public NappageChocolatDecorator(CoupeGlacee coupe) : base(coupe) { }

    public override double Prix()
    {
        return _coupe.Prix() + 0.7;
    }

    public override string Description()
    {
        return _coupe.Description() + " avec supplément nappage chocolat";
    }
}
