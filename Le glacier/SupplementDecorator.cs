namespace Le_glacier;

public abstract class SupplementDecorator : CoupeGlacee
{
    protected CoupeGlacee _coupe;

    public SupplementDecorator(CoupeGlacee coupe)
    {
        _coupe = coupe;
    }

    public override abstract double Prix();
    public override abstract string Description();
}
