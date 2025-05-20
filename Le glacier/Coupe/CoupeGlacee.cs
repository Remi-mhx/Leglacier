namespace Le_glacier;

using System.Collections.Generic;

public abstract class CoupeGlacee: ICoupeGlacee
{
    protected List<Parfum> _parfums = new List<Parfum>();

    public virtual string Description()
    {
        return string.Join(", ", _parfums);
    }
    
    public abstract double Prix();

}
