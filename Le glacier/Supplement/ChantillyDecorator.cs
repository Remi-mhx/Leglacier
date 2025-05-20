namespace Le_glacier;

public class ChantillyDecorator : SupplementDecorator
{
    public ChantillyDecorator(ICoupeGlacee coupe) : base(coupe) { }

    public override double Prix()
    {
        return _coupe.Prix() + 0.5;
    }

    public override string Description()
    {
        return _coupe.Description() + " avec supplément chantilly";
    }
}
