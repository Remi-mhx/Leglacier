namespace Le_glacier;

public abstract class SupplementDecorator : ICoupeGlacee
{
    protected ICoupeGlacee _coupe;

    public SupplementDecorator(ICoupeGlacee coupe)
    {
        _coupe = coupe;
    }

    public abstract double Prix();
    public abstract string Description();
}
