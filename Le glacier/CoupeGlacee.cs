namespace Le_glacier;

using System.Collections.Generic;

public abstract class CoupeGlacee
{
    protected List<Parfum> _parfums = new List<Parfum>();

    public abstract double Prix();
    public abstract string Description();
}
