namespace Le_glacier;

public class CoulisFraiseDecorator : SupplementDecorator
{
    public CoulisFraiseDecorator(ICoupeGlacee coupe) : base(coupe) { }

    public override double Prix()
    {
        return _coupe.Prix() + 1.0;
    }

    public override string Description()
    {
        return _coupe.Description() + " avec son coulis de fraises fraîches";
    }
}
