namespace TheFirm;

internal abstract class Employee : Person, IContract
{
    public void Werken()
    {
        Werkt();
    }

    public abstract void Werkt();
    
}
